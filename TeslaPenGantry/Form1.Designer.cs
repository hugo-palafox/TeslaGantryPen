namespace TeslaPenGantry
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Tick = new System.Windows.Forms.Timer(components);
            textBoxLog = new TextBox();
            btnAxisYCommand = new Button();
            btnAxisXCommand = new Button();
            numAxisYPosTarget = new NumericUpDown();
            numAxisXPosTarget = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnStop = new Button();
            label5 = new Label();
            cmbPartList = new ComboBox();
            btnStart = new Button();
            btnHome = new Button();
            numAxisYPos = new NumericUpDown();
            numP2Y = new NumericUpDown();
            numP2X = new NumericUpDown();
            numP1Y = new NumericUpDown();
            numP1X = new NumericUpDown();
            numAxisXPos = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtState = new TextBox();
            label12 = new Label();
            indActuatorRetracted = new PictureBox();
            label11 = new Label();
            indActuatorAdvanced = new PictureBox();
            label8 = new Label();
            indYHome = new PictureBox();
            label9 = new Label();
            indXHome = new PictureBox();
            label7 = new Label();
            indYRunning = new PictureBox();
            label10 = new Label();
            label6 = new Label();
            indXRunning = new PictureBox();
            btnFault = new Button();
            btnAck = new Button();
            btnGetPoint = new Button();
            numGetY = new NumericUpDown();
            numGetX = new NumericUpDown();
            label13 = new Label();
            label14 = new Label();
            lblResultGet = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)numAxisYPosTarget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAxisXPosTarget).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAxisYPos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numP2Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numP2X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numP1Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numP1X).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAxisXPos).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)indActuatorRetracted).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indActuatorAdvanced).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indYHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indXHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indYRunning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indXRunning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGetY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGetX).BeginInit();
            SuspendLayout();
            // 
            // Tick
            // 
            Tick.Enabled = true;
            Tick.Tick += Tick_Tick;
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(374, 38);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(423, 545);
            textBoxLog.TabIndex = 6;
            // 
            // btnAxisYCommand
            // 
            btnAxisYCommand.Location = new Point(193, 88);
            btnAxisYCommand.Name = "btnAxisYCommand";
            btnAxisYCommand.Size = new Size(75, 23);
            btnAxisYCommand.TabIndex = 12;
            btnAxisYCommand.Text = "Execute";
            btnAxisYCommand.UseVisualStyleBackColor = true;
            btnAxisYCommand.Click += btnAxisYCommand_Click;
            // 
            // btnAxisXCommand
            // 
            btnAxisXCommand.Location = new Point(53, 88);
            btnAxisXCommand.Name = "btnAxisXCommand";
            btnAxisXCommand.Size = new Size(75, 23);
            btnAxisXCommand.TabIndex = 13;
            btnAxisXCommand.Text = "Execute";
            btnAxisXCommand.UseVisualStyleBackColor = true;
            btnAxisXCommand.Click += btnAxisXCommand_Click;
            // 
            // numAxisYPosTarget
            // 
            numAxisYPosTarget.Location = new Point(173, 46);
            numAxisYPosTarget.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numAxisYPosTarget.Name = "numAxisYPosTarget";
            numAxisYPosTarget.Size = new Size(120, 23);
            numAxisYPosTarget.TabIndex = 10;
            // 
            // numAxisXPosTarget
            // 
            numAxisXPosTarget.Location = new Point(33, 48);
            numAxisXPosTarget.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numAxisXPosTarget.Name = "numAxisXPosTarget";
            numAxisXPosTarget.Size = new Size(120, 23);
            numAxisXPosTarget.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 29);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 8;
            label4.Text = "Axis Y Target";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 30);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 9;
            label3.Text = "Axis X Target";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnStop);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbPartList);
            groupBox1.Controls.Add(btnStart);
            groupBox1.Controls.Add(btnHome);
            groupBox1.Controls.Add(numAxisYPos);
            groupBox1.Controls.Add(numP2Y);
            groupBox1.Controls.Add(numP2X);
            groupBox1.Controls.Add(numP1Y);
            groupBox1.Controls.Add(numP1X);
            groupBox1.Controls.Add(numAxisXPos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 270);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Auto Mode";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(165, 229);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(131, 27);
            btnStop.TabIndex = 20;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 114);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 19;
            label5.Text = "Select a Part ";
            // 
            // cmbPartList
            // 
            cmbPartList.FormattingEnabled = true;
            cmbPartList.Location = new Point(88, 132);
            cmbPartList.Name = "cmbPartList";
            cmbPartList.Size = new Size(127, 23);
            cmbPartList.TabIndex = 18;
            cmbPartList.SelectedIndexChanged += cmbPartList_SelectedIndexChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(19, 229);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(129, 28);
            btnStart.TabIndex = 16;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(88, 24);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(129, 28);
            btnHome.TabIndex = 17;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click_1;
            // 
            // numAxisYPos
            // 
            numAxisYPos.Location = new Point(159, 78);
            numAxisYPos.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numAxisYPos.Name = "numAxisYPos";
            numAxisYPos.Size = new Size(120, 23);
            numAxisYPos.TabIndex = 10;
            // 
            // numP2Y
            // 
            numP2Y.Location = new Point(159, 198);
            numP2Y.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numP2Y.Name = "numP2Y";
            numP2Y.Size = new Size(120, 23);
            numP2Y.TabIndex = 11;
            // 
            // numP2X
            // 
            numP2X.Location = new Point(19, 200);
            numP2X.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numP2X.Name = "numP2X";
            numP2X.Size = new Size(120, 23);
            numP2X.TabIndex = 12;
            // 
            // numP1Y
            // 
            numP1Y.Location = new Point(159, 170);
            numP1Y.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numP1Y.Name = "numP1Y";
            numP1Y.Size = new Size(120, 23);
            numP1Y.TabIndex = 13;
            // 
            // numP1X
            // 
            numP1X.Location = new Point(19, 171);
            numP1X.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numP1X.Name = "numP1X";
            numP1X.Size = new Size(120, 23);
            numP1X.TabIndex = 14;
            // 
            // numAxisXPos
            // 
            numAxisXPos.Location = new Point(19, 78);
            numAxisXPos.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numAxisXPos.Name = "numAxisXPos";
            numAxisXPos.Size = new Size(120, 23);
            numAxisXPos.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 60);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Axis Y Pos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 60);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 9;
            label1.Text = "Axis X Pos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numAxisXPosTarget);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnAxisYCommand);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnAxisXCommand);
            groupBox2.Controls.Add(numAxisYPosTarget);
            groupBox2.Location = new Point(16, 527);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 123);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manual Mode";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtState);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(indActuatorRetracted);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(indActuatorAdvanced);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(indYHome);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(indXHome);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(indYRunning);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(indXRunning);
            groupBox3.Location = new Point(16, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(327, 238);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "State";
            // 
            // txtState
            // 
            txtState.Location = new Point(191, 39);
            txtState.Name = "txtState";
            txtState.Size = new Size(119, 23);
            txtState.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(60, 202);
            label12.Name = "label12";
            label12.Size = new Size(106, 15);
            label12.TabIndex = 4;
            label12.Text = "Actuator Retracted";
            // 
            // indActuatorRetracted
            // 
            indActuatorRetracted.Image = Properties.Resources.indicator_green;
            indActuatorRetracted.Location = new Point(29, 192);
            indActuatorRetracted.Name = "indActuatorRetracted";
            indActuatorRetracted.Size = new Size(25, 25);
            indActuatorRetracted.SizeMode = PictureBoxSizeMode.StretchImage;
            indActuatorRetracted.TabIndex = 2;
            indActuatorRetracted.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(60, 172);
            label11.Name = "label11";
            label11.Size = new Size(109, 15);
            label11.TabIndex = 4;
            label11.Text = "Actuator Advanced";
            // 
            // indActuatorAdvanced
            // 
            indActuatorAdvanced.Image = Properties.Resources.indicator_green;
            indActuatorAdvanced.Location = new Point(29, 162);
            indActuatorAdvanced.Name = "indActuatorAdvanced";
            indActuatorAdvanced.Size = new Size(25, 25);
            indActuatorAdvanced.SizeMode = PictureBoxSizeMode.StretchImage;
            indActuatorAdvanced.TabIndex = 2;
            indActuatorAdvanced.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(59, 141);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 4;
            label8.Text = "Servo Y Home";
            // 
            // indYHome
            // 
            indYHome.Image = Properties.Resources.indicator_green;
            indYHome.Location = new Point(28, 131);
            indYHome.Name = "indYHome";
            indYHome.Size = new Size(25, 25);
            indYHome.SizeMode = PictureBoxSizeMode.StretchImage;
            indYHome.TabIndex = 2;
            indYHome.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 107);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 5;
            label9.Text = "Servo X Home";
            // 
            // indXHome
            // 
            indXHome.Image = Properties.Resources.indicator_green;
            indXHome.InitialImage = Properties.Resources.indicator_green;
            indXHome.Location = new Point(28, 97);
            indXHome.Name = "indXHome";
            indXHome.Size = new Size(25, 25);
            indXHome.SizeMode = PictureBoxSizeMode.StretchImage;
            indXHome.TabIndex = 3;
            indXHome.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 65);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 1;
            label7.Text = "Servo Y Running";
            // 
            // indYRunning
            // 
            indYRunning.Image = Properties.Resources.indicator_green;
            indYRunning.Location = new Point(28, 55);
            indYRunning.Name = "indYRunning";
            indYRunning.Size = new Size(25, 25);
            indYRunning.SizeMode = PictureBoxSizeMode.StretchImage;
            indYRunning.TabIndex = 0;
            indYRunning.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(199, 21);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 1;
            label10.Text = "Gantry State";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 31);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 1;
            label6.Text = "Servo X Running";
            // 
            // indXRunning
            // 
            indXRunning.Image = Properties.Resources.indicator_green;
            indXRunning.InitialImage = Properties.Resources.indicator_green;
            indXRunning.Location = new Point(28, 21);
            indXRunning.Name = "indXRunning";
            indXRunning.Size = new Size(25, 25);
            indXRunning.SizeMode = PictureBoxSizeMode.StretchImage;
            indXRunning.TabIndex = 0;
            indXRunning.TabStop = false;
            // 
            // btnFault
            // 
            btnFault.BackColor = Color.Red;
            btnFault.ForeColor = SystemColors.ButtonHighlight;
            btnFault.Location = new Point(194, 665);
            btnFault.Name = "btnFault";
            btnFault.Size = new Size(148, 41);
            btnFault.TabIndex = 17;
            btnFault.Text = "Fault";
            btnFault.UseVisualStyleBackColor = false;
            btnFault.Click += btnFault_Click;
            // 
            // btnAck
            // 
            btnAck.Location = new Point(43, 666);
            btnAck.Name = "btnAck";
            btnAck.Size = new Size(145, 40);
            btnAck.TabIndex = 18;
            btnAck.Text = "Ack";
            btnAck.UseVisualStyleBackColor = true;
            btnAck.Click += btnAck_Click;
            // 
            // btnGetPoint
            // 
            btnGetPoint.ForeColor = SystemColors.ControlText;
            btnGetPoint.Location = new Point(407, 632);
            btnGetPoint.Name = "btnGetPoint";
            btnGetPoint.Size = new Size(123, 31);
            btnGetPoint.TabIndex = 19;
            btnGetPoint.Text = "Get Point";
            btnGetPoint.UseVisualStyleBackColor = true;
            btnGetPoint.Click += btnGetPoint_Click;
            // 
            // numGetY
            // 
            numGetY.Location = new Point(677, 640);
            numGetY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numGetY.Name = "numGetY";
            numGetY.Size = new Size(120, 23);
            numGetY.TabIndex = 22;
            // 
            // numGetX
            // 
            numGetX.Location = new Point(537, 640);
            numGetX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numGetX.Name = "numGetX";
            numGetX.Size = new Size(120, 23);
            numGetX.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(706, 622);
            label13.Name = "label13";
            label13.Size = new Size(61, 15);
            label13.TabIndex = 20;
            label13.Text = "Axis Y Pos";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(571, 622);
            label14.Name = "label14";
            label14.Size = new Size(61, 15);
            label14.TabIndex = 21;
            label14.Text = "Axis X Pos";
            // 
            // lblResultGet
            // 
            lblResultGet.AutoSize = true;
            lblResultGet.Location = new Point(589, 683);
            lblResultGet.Name = "lblResultGet";
            lblResultGet.Size = new Size(0, 15);
            lblResultGet.TabIndex = 24;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(535, 588);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 24);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear Log";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 718);
            Controls.Add(btnClear);
            Controls.Add(lblResultGet);
            Controls.Add(numGetY);
            Controls.Add(numGetX);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(btnGetPoint);
            Controls.Add(btnAck);
            Controls.Add(btnFault);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBoxLog);
            Name = "Form1";
            Text = "Pen Gantry Challenge";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numAxisYPosTarget).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAxisXPosTarget).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAxisYPos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numP2Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)numP2X).EndInit();
            ((System.ComponentModel.ISupportInitialize)numP1Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)numP1X).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAxisXPos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)indActuatorRetracted).EndInit();
            ((System.ComponentModel.ISupportInitialize)indActuatorAdvanced).EndInit();
            ((System.ComponentModel.ISupportInitialize)indYHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)indXHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)indYRunning).EndInit();
            ((System.ComponentModel.ISupportInitialize)indXRunning).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGetY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGetX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer Tick;
        private TextBox textBoxLog;
        private Button btnAxisYCommand;
        private Button btnAxisXCommand;
        private NumericUpDown numAxisYPosTarget;
        private NumericUpDown numAxisXPosTarget;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cmbPartList;
        private Button btnStart;
        private Button btnHome;
        private NumericUpDown numAxisYPos;
        private NumericUpDown numP2Y;
        private NumericUpDown numP2X;
        private NumericUpDown numP1Y;
        private NumericUpDown numP1X;
        private NumericUpDown numAxisXPos;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox indXRunning;
        private Label label6;
        private Label label7;
        private PictureBox indYRunning;
        private Label label8;
        private PictureBox indYHome;
        private Label label9;
        private PictureBox indXHome;
        private TextBox txtState;
        private Label label10;
        private Button btnStop;
        private Button btnFault;
        private Button btnAck;
        private Label label12;
        private PictureBox indActuatorRetracted;
        private Label label11;
        private PictureBox indActuatorAdvanced;
        private Button btnGetPoint;
        private NumericUpDown numGetY;
        private NumericUpDown numGetX;
        private Label label13;
        private Label label14;
        private Label lblResultGet;
        private Button btnClear;
    }
}