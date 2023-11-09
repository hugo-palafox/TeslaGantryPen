using System.Diagnostics;

namespace TeslaPenGantry
{
    public partial class Form1 : Form
    {
        // Declare and initialize various class-level variables and objects.

        // Static objects for controlling the ITF HMI, X-axis servo, Y-axis servo, and actuator.

        public static ITFHMI ITF_HMI { get; set; } = new ITFHMI();
        public static Servo ServoX { get; set; } = new Servo();
        public static Servo ServoY { get; set; } = new Servo();
        public static Actuator ActuatorZ { get; set; } = new Actuator();

        // Other class-level variables.

        public static bool AutoRunning { get; set; }
        public static Point PartSelectedP1 { get; set; }
        public static Point PartSelectedP2 { get; set; }
        public static int PartIndexSelected { get; set; }
        public static List<Part> Parts { get; set; } = new List<Part>()
        {
             // Initialize a list of parts with their respective names, min, and max points.

             new Part() { Name="Part1",min=new Point(){X=30, Y=700}, max=new Point(){X=180,Y=850 } },
             new Part() { Name="Part2",min=new Point(){X=650,Y=750}, max=new Point(){X=750,Y=870 } },
             new Part() { Name="Part3",min=new Point(){X=50, Y=20}, max=new Point(){ X=250,Y=120 } },
             new Part() { Name="Part4",min=new Point(){X=500,Y=500}, max=new Point(){X=700,Y=550 } }
        };



        public Form1()
        {
            // Initialize form components and start background threads.
            AutoRunning = true;
            InitializeComponent();
            btnStart.Enabled = false;
            cmbPartList.DataSource = Parts;
            cmbPartList.DisplayMember = "Name";
            cmbPartList.SelectedIndex = 0;
            Thread ServoX = new Thread(ServoXController);
            ServoX.Start();
            Thread ServoY = new Thread(ServoYController);
            ServoY.Start();


        }
        /// Method to execute the auto mode of the gantry system.
        public void AutoMode()
        {///
            if (AutoRunning)
            {
                LogMessage("Start draw sequence");
                var p1 = new Point() { X = Convert.ToInt32(numP1X.Value), Y = Convert.ToInt32(numP1Y.Value) };
                var p3 = new Point() { X = Convert.ToInt32(numP2X.Value), Y = Convert.ToInt32(numP2Y.Value) };
                LogMessage($"Point loaded({p1.X},{p1.Y})");
                LogMessage($"Point loaded({p3.X},{p3.Y})");
                var points = GeneratePoints(p1, p3);
                while (!RunPart(points)) ;
            }

        }
        /// Generates a list of points between two given points.
        public List<Point> GeneratePoints(Point p1, Point p3)
        {
            List<Point> PointList = new List<Point>();
            PointList.Add(p1);
            var p2 = new Point() { X = p1.X, Y = p3.Y };
            PointList.Add(p2);
            PointList.Add(p3);
            var p4 = new Point() { X = p3.X, Y = p1.Y };
            PointList.Add(p4);
            return PointList;

        }
        /// Runs a part by moving the servos to the specified points.
        public bool RunPart(List<Point> PointList)
        {
            foreach (Point p in PointList)
            {

                ServoX.cmdServoPosTarget = p.X;
                ServoX.cmdServoStart = true;
                while (!ServoX.stsServoPosReached) ;
                ServoX.stsServoPosReached = false;

                LogMessage($"Command Complete: Pos X={ServoX.cmdServoPosTarget} reached");

                ServoY.cmdServoPosTarget = p.Y;
                ServoY.cmdServoStart = true;
                while (!ServoY.stsServoPosReached) ;
                ServoY.stsServoPosReached = false;

                LogMessage($"Command Complete: Pos Y={ServoY.cmdServoPosTarget} reached");

                if (PointList.IndexOf(p) == 0)
                {
                    ActuatorZ.cmdActuatorReturn = false;
                    ActuatorZ.cmdActuatorAdvance = true;
                    LogMessage($"PenAdvanced");
                }
                Thread.Sleep(1000);
            }
            LogMessage($"PenReturned");
            ActuatorZ.cmdActuatorAdvance = false;
            ActuatorZ.cmdActuatorReturn = true;
            Homing();
            while (!ServoX.stsServoHomeReached) ;
            while (!ServoY.stsServoHomeReached) ;
            return true;
        }

        /// Control the X-axis servo's behavior.
        public void ServoXController()
        {

            ServoX.cmdServoHomePos = 10;
            ServoX.cmdServoSpeed = 5;
            while (AutoRunning)
            {
                if (!ServoX.stsServoFault)
                {
                    if (ServoX.cmdServoStart)
                    {
                        ServoX.cmdServoStop = false;
                        var diffhomepos = ServoX.stsServoPos - ServoX.cmdServoPosTarget;
                        if (diffhomepos < 0)
                            ServoX.stsServoPos++;
                        else if (diffhomepos > 0)
                            ServoX.stsServoPos--;
                        if (ServoX.stsServoPos == ServoX.cmdServoPosTarget)
                        {
                            ServoX.stsServoPosReached = true;
                            ServoX.cmdServoStop = true;
                            ServoX.cmdServoStart = false;
                        }
                    }
                    else if (ServoX.cmdServoHomeStart)
                    {
                        ServoX.cmdServoStop = false;
                        var diffhomepos = ServoX.stsServoPos - ServoX.cmdServoHomePos;
                        if (diffhomepos < 0)
                            ServoX.stsServoPos++;
                        else if (diffhomepos > 0)
                            ServoX.stsServoPos--;

                        if (ServoX.stsServoPos == ServoX.cmdServoHomePos)
                        {
                            LogMessage("Servo X in Home");
                            ServoX.stsServoHomeReached = true;
                            ServoX.cmdServoStop = true;
                            ServoX.cmdServoStart = false;
                            ServoX.cmdServoHomeStart = false;
                        }

                    }
                }
                else
                {
                    if (ITF_HMI.fromHMI.cmdReset)
                    {
                        ServoX.stsServoFault = false;
                    }
                    else
                    {
                        ServoX.cmdServoStop = false;
                        ServoX.cmdServoStart = false;
                    }

                }

                if (ServoX.cmdServoStart || ServoX.cmdServoHomeStart)
                    Thread.Sleep(5 * ServoX.cmdServoSpeed);
            }
        }
        /// Control the Y-axis servo's behavior.

        public void ServoYController()
        {

            ServoY.cmdServoHomePos = 10;
            ServoY.cmdServoSpeed = 5;
            while (AutoRunning)
            {
                if (!ServoY.stsServoFault)
                {
                    if (ServoY.cmdServoStart)
                    {
                        ServoY.cmdServoStop = false;
                        var diffhomepos = ServoY.stsServoPos - ServoY.cmdServoPosTarget;
                        if (diffhomepos < 0)
                            ServoY.stsServoPos++;
                        else if (diffhomepos > 0)
                            ServoY.stsServoPos--;
                        if (ServoY.stsServoPos == ServoY.cmdServoPosTarget)
                        {
                            ServoY.stsServoPosReached = true;
                            ServoY.cmdServoStop = true;
                            ServoY.cmdServoStart = false;
                        }
                    }
                    else if (ServoY.cmdServoHomeStart)
                    {


                        ServoY.cmdServoStop = false;
                        var diffhomepos = ServoY.stsServoPos - ServoY.cmdServoHomePos;
                        if (diffhomepos < 0)
                            ServoY.stsServoPos++;
                        else if (diffhomepos > 0)
                            ServoY.stsServoPos--;

                        if (ServoY.stsServoPos == ServoY.cmdServoHomePos)
                        {
                            LogMessage("Servo Y in Home");
                            ServoY.stsServoHomeReached = true;
                            ServoY.cmdServoStop = true;
                            ServoY.cmdServoStart = false;
                            ServoY.cmdServoHomeStart = false;

                        }

                    }
                }
                else
                {
                    if (ITF_HMI.fromHMI.cmdReset)
                    {
                        ServoY.stsServoFault = false;
                    }
                    else
                    {
                        ServoY.cmdServoStop = false;
                        ServoY.cmdServoStart = false;
                    }

                }

                if (ServoY.cmdServoStart || ServoY.cmdServoHomeStart)
                    Thread.Sleep(5 * ServoY.cmdServoSpeed);
            }
        }



        //UI Updater every 100 ms
        private void Tick_Tick(object sender, EventArgs e)
        {

            numAxisXPos.Value = ServoX.stsServoPos;
            numAxisYPos.Value = ServoY.stsServoPos;


            if (ServoX.stsServoPos != ServoX.cmdServoHomePos || ServoY.stsServoPos != ServoY.cmdServoHomePos)
            {
                btnHome.Enabled = true;
            }
            if (ServoX.stsServoPos == ServoX.cmdServoHomePos && ServoX.stsServoHomeReached) Indicator(true, indXHome);
            else Indicator(false, indXHome);

            if (ServoY.stsServoPos == ServoY.cmdServoHomePos && ServoY.stsServoHomeReached) Indicator(true, indYHome);
            else Indicator(false, indYHome);

            if (ServoX.cmdServoStart) Indicator(true, indXRunning);
            else Indicator(false, indXRunning);

            if (ServoY.cmdServoStart) Indicator(true, indYRunning);
            else Indicator(false, indYRunning);

            if (ActuatorZ.cmdActuatorAdvance) Indicator(true, indActuatorAdvanced);
            else Indicator(false, indActuatorAdvanced);

            if (ActuatorZ.cmdActuatorReturn) Indicator(true, indActuatorRetracted);
            else Indicator(false, indActuatorRetracted);


            //controller states
            if (ServoX.stsServoFault || ServoY.stsServoFault)
                ITF_HMI.toHMI.stsState = States.Faulted;
            else if (!ServoY.cmdServoStart && !ServoX.cmdServoStart && !ServoY.cmdServoStart && !ServoX.cmdServoHomeStart && !ServoY.cmdServoHomeStart)
                ITF_HMI.toHMI.stsState = States.Stopped;
            else
                ITF_HMI.toHMI.stsState = States.Running;
            txtState.ReadOnly = true;
            txtState.Text = ITF_HMI.toHMI.stsState.ToString();
        }
        //Indicator loader
        private void Indicator(bool state, PictureBox pictureBox)
        {

            if (state)
            {
                pictureBox.ImageLocation = "C:\\IOT\\EzIotCore\\TeslaGantryTest\\TeslaPenGantry\\Images\\indicator_green.png";
            }
            else
            {
                pictureBox.ImageLocation = "C:\\IOT\\EzIotCore\\TeslaGantryTest\\TeslaPenGantry\\Images\\indicator_red.png";
            }
        }

        //Homing command
        private void Homing()
        {
            ActuatorZ.cmdActuatorAdvance = false;
            ActuatorZ.cmdActuatorReturn = true;

            ServoX.cmdServoHomeStart = true;
            ServoY.cmdServoHomeStart = true;
            ServoX.stsServoHomeReached = false;
            ServoY.stsServoHomeReached = false;
            LogMessage("Homing");
        }

        private void LogMessage(string message)
        {
            if (textBoxLog.InvokeRequired)
            {
                // If this method is called from a non-UI thread, use Invoke to update the UI.
                Action<string> logAction = LogMessage;
                textBoxLog.Invoke(logAction, message);
            }
            else
            {
                // Append the new message with a timestamp
                string logEntry = $"{DateTime.Now:HH:mm:ss} - {message}{Environment.NewLine}";

                // Append the log entry to the TextBox
                textBoxLog.AppendText(logEntry);
            }

        }



        #region Commmands buttons
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Homing();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {

            Thread Sequence = new Thread(AutoMode);
            Sequence.Start();
        }
        private void btnAxisXCommand_Click(object sender, EventArgs e)
        {
            ServoX.cmdServoPosTarget = Convert.ToInt32(numAxisXPosTarget.Value);
            ServoX.cmdServoStart = true;
        }

        private void btnAxisYCommand_Click(object sender, EventArgs e)
        {
            ServoY.cmdServoPosTarget = Convert.ToInt32(numAxisYPosTarget.Value);
            ServoY.cmdServoStart = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            ServoX.cmdServoStart = false;
            ServoY.cmdServoStart = false;
            ServoX.cmdServoStop = true;
            ServoY.cmdServoStop = true;

            btnStart.Enabled = true;
            btnHome.Enabled = true;
        }

        private void btnAck_Click(object sender, EventArgs e)
        {
            ServoX.stsServoFault = false;
            ServoY.stsServoFault = false;

            Homing();
        }

        private void btnFault_Click(object sender, EventArgs e)
        {
            ServoX.stsServoFault = true;
            ServoY.stsServoFault = true;

        }
        #endregion

        //Parts list events
        private void cmbPartList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PartSelectedP1 = Parts[cmbPartList.SelectedIndex].min;
            PartSelectedP2 = Parts[cmbPartList.SelectedIndex].max;
            numP1X.Value = PartSelectedP1.X;
            numP2X.Value = PartSelectedP2.X;

            numP1Y.Value = PartSelectedP1.Y;
            numP2Y.Value = PartSelectedP2.Y;

            if (ServoX.stsServoHomeReached && ServoY.stsServoHomeReached) btnStart.Enabled = true;
        }

        private void btnGetPoint_Click(object sender, EventArgs e)
        {
            var r1 = new Random().Next(0, 3);
            var r2 = new Random().Next(0, 1);
            Point NewPoint = new Point();
            if (r2 == 0) NewPoint = Parts[r1].min;
            if (r2 == 1) NewPoint = Parts[r1].max;
            numGetX.Value = Convert.ToInt32(NewPoint.X);
            numGetY.Value = Convert.ToInt32(NewPoint.Y);

            foreach (var part in Parts)
            {
                if (part.min.X == NewPoint.X && part.min.Y == NewPoint.Y || part.max.X == NewPoint.X && part.max.Y == NewPoint.Y)
                {
                    lblResultGet.Text = "Point belongs to " + part.Name;
                    break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxLog.Text = string.Empty;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoRunning = false;
        }
    }
    //Classes/Data Structs
    public class ITFHMI
    {
        public fromHMI fromHMI { get; set; } = new fromHMI();
        public toHMI toHMI { get; set; } = new toHMI();
    }
    public class fromHMI
    {
        public bool cmdReset { get; set; }
        public bool cmdHome { get; set; }
        public bool cmdAbort { get; set; }
        public bool cmdStart { get; set; }
        public bool cmdReboot { get; set; }
        public int[] cmdPointSelected { get; set; } = new int[2];
    }
    public class toHMI
    {
        public int stsController { get; set; }
        public int stsPartSelected { get; set; }
        public States stsState { get; set; }
    }
    public class Part
    {
        public string? Name { get; set; }
        public Point min { get; set; }
        public Point max { get; set; }

    }
    public class Servo
    {
        public bool cmdServoStart { get; set; }
        public bool cmdServoStop { get; set; }
        public int cmdServoSpeed { get; set; }
        public int cmdServoPosTarget { get; set; }
        public int cmdServoHomePos { get; set; }
        public bool cmdServoHomeStart { get; set; }
        public int stsServoPos { get; set; }
        public int stsServoSpeed { get; set; }
        public bool stsServoPosReached { get; set; }
        public bool stsServoHomeReached { get; set; }
        public bool stsServoFault { get; set; }

    }
    public class Actuator
    {
        public bool cmdActuatorAdvance { get; set; }
        public bool cmdActuatorReturn { get; set; }
        public bool stsActuatorAdvanced { get; set; }
        public bool stsActuatorReturned { get; set; }
    }
    public enum States
    {
        Stopped,
        Paused,
        Running,
        Faulted
    }

}
