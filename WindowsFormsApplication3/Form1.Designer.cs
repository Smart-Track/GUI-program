namespace WindowsFormsApplication3
{
    partial class appWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lap1Time = new System.Windows.Forms.Label();
            this.Lap1Timer = new System.Windows.Forms.Timer(this.components);
            this.spLabel = new System.Windows.Forms.Label();
            this.cp1TimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lapText = new System.Windows.Forms.Label();
            this.Lap2Split = new System.Windows.Forms.Label();
            this.Lap2Cp2Split = new System.Windows.Forms.Label();
            this.Lap2Cp1Split = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Lap2TimeLabel = new System.Windows.Forms.Label();
            this.Lap3Cp2Split = new System.Windows.Forms.Label();
            this.Lap3Cp1Split = new System.Windows.Forms.Label();
            this.Lap3Split = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.Lap3TimeLabel = new System.Windows.Forms.Label();
            this.Lap2Timer = new System.Windows.Forms.Timer(this.components);
            this.Lap3Timer = new System.Windows.Forms.Timer(this.components);
            this.Lap1Label = new System.Windows.Forms.Label();
            this.Lap1Cp1Label = new System.Windows.Forms.Label();
            this.Lap1Cp2Label = new System.Windows.Forms.Label();
            this.Lap2Label = new System.Windows.Forms.Label();
            this.Lap2Cp2Label = new System.Windows.Forms.Label();
            this.Lap3Label = new System.Windows.Forms.Label();
            this.Lap3Cp1Label = new System.Windows.Forms.Label();
            this.Lap3Cp2Label = new System.Windows.Forms.Label();
            this.Lap2Cp1Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataIn = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "/dev/ttyACM0";
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(34)))), ((int)(((byte)(255)))));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(448, 60);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Select Device...";
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(557, 1696);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 52);
            this.label2.TabIndex = 5;
            this.label2.Text = "Device Select:";
            // 
            // Lap1Time
            // 
            this.Lap1Time.AutoSize = true;
            this.Lap1Time.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap1Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap1Time.Location = new System.Drawing.Point(550, 654);
            this.Lap1Time.Name = "Lap1Time";
            this.Lap1Time.Size = new System.Drawing.Size(125, 52);
            this.Lap1Time.TabIndex = 13;
            this.Lap1Time.Text = "Time:";
            // 
            // Lap1Timer
            // 
            this.Lap1Timer.Interval = 94;
            this.Lap1Timer.Tick += new System.EventHandler(this.appTimer_Tick);
            // 
            // spLabel
            // 
            this.spLabel.AutoSize = true;
            this.spLabel.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.spLabel.Location = new System.Drawing.Point(8, 1696);
            this.spLabel.Name = "spLabel";
            this.spLabel.Size = new System.Drawing.Size(457, 52);
            this.spLabel.TabIndex = 18;
            this.spLabel.Text = "Waiting for Port Select...";
            // 
            // cp1TimeLabel
            // 
            this.cp1TimeLabel.AutoSize = true;
            this.cp1TimeLabel.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp1TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.cp1TimeLabel.Location = new System.Drawing.Point(389, 861);
            this.cp1TimeLabel.Name = "cp1TimeLabel";
            this.cp1TimeLabel.Size = new System.Drawing.Size(264, 52);
            this.cp1TimeLabel.TabIndex = 24;
            this.cp1TimeLabel.Text = "Checkpoint 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.label3.Location = new System.Drawing.Point(389, 1018);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 52);
            this.label3.TabIndex = 30;
            this.label3.Text = "Checkpoint 2:";
            // 
            // lapText
            // 
            this.lapText.AutoSize = true;
            this.lapText.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(31)))));
            this.lapText.Location = new System.Drawing.Point(625, 594);
            this.lapText.Name = "lapText";
            this.lapText.Size = new System.Drawing.Size(118, 52);
            this.lapText.TabIndex = 31;
            this.lapText.Text = "Lap 1";
            // 
            // Lap2Split
            // 
            this.Lap2Split.AutoSize = true;
            this.Lap2Split.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap2Split.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.Lap2Split.Location = new System.Drawing.Point(1318, 714);
            this.Lap2Split.Name = "Lap2Split";
            this.Lap2Split.Size = new System.Drawing.Size(175, 52);
            this.Lap2Split.TabIndex = 33;
            this.Lap2Split.Text = "+ -- : -- . -";
            this.Lap2Split.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lap2Cp2Split
            // 
            this.Lap2Cp2Split.AutoSize = true;
            this.Lap2Cp2Split.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap2Cp2Split.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.Lap2Cp2Split.Location = new System.Drawing.Point(1318, 1078);
            this.Lap2Cp2Split.Name = "Lap2Cp2Split";
            this.Lap2Cp2Split.Size = new System.Drawing.Size(175, 52);
            this.Lap2Cp2Split.TabIndex = 56;
            this.Lap2Cp2Split.Text = "+ -- : -- . -";
            this.Lap2Cp2Split.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lap2Cp1Split
            // 
            this.Lap2Cp1Split.AutoSize = true;
            this.Lap2Cp1Split.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap2Cp1Split.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.Lap2Cp1Split.Location = new System.Drawing.Point(1318, 921);
            this.Lap2Cp1Split.Name = "Lap2Cp1Split";
            this.Lap2Cp1Split.Size = new System.Drawing.Size(175, 52);
            this.Lap2Cp1Split.TabIndex = 55;
            this.Lap2Cp1Split.Text = "+ -- : -- . -";
            this.Lap2Cp1Split.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.label13.Location = new System.Drawing.Point(1072, 1018);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(264, 52);
            this.label13.TabIndex = 53;
            this.label13.Text = "Checkpoint 2:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.label19.Location = new System.Drawing.Point(1073, 861);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(264, 52);
            this.label19.TabIndex = 47;
            this.label19.Text = "Checkpoint 1:";
            // 
            // Lap2TimeLabel
            // 
            this.Lap2TimeLabel.AutoSize = true;
            this.Lap2TimeLabel.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap2TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap2TimeLabel.Location = new System.Drawing.Point(1233, 654);
            this.Lap2TimeLabel.Name = "Lap2TimeLabel";
            this.Lap2TimeLabel.Size = new System.Drawing.Size(125, 52);
            this.Lap2TimeLabel.TabIndex = 41;
            this.Lap2TimeLabel.Text = "Time:";
            // 
            // Lap3Cp2Split
            // 
            this.Lap3Cp2Split.AutoSize = true;
            this.Lap3Cp2Split.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap3Cp2Split.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            this.Lap3Cp2Split.Location = new System.Drawing.Point(2008, 1078);
            this.Lap3Cp2Split.Name = "Lap3Cp2Split";
            this.Lap3Cp2Split.Size = new System.Drawing.Size(175, 52);
            this.Lap3Cp2Split.TabIndex = 77;
            this.Lap3Cp2Split.Text = "+ -- : -- . -";
            this.Lap3Cp2Split.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lap3Cp1Split
            // 
            this.Lap3Cp1Split.AutoSize = true;
            this.Lap3Cp1Split.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap3Cp1Split.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            this.Lap3Cp1Split.Location = new System.Drawing.Point(2004, 921);
            this.Lap3Cp1Split.Name = "Lap3Cp1Split";
            this.Lap3Cp1Split.Size = new System.Drawing.Size(175, 52);
            this.Lap3Cp1Split.TabIndex = 76;
            this.Lap3Cp1Split.Text = "+ -- : -- . -";
            this.Lap3Cp1Split.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lap3Split
            // 
            this.Lap3Split.AutoSize = true;
            this.Lap3Split.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap3Split.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(117)))));
            this.Lap3Split.Location = new System.Drawing.Point(2004, 714);
            this.Lap3Split.Name = "Lap3Split";
            this.Lap3Split.Size = new System.Drawing.Size(175, 52);
            this.Lap3Split.TabIndex = 75;
            this.Lap3Split.Text = "+ -- : -- . -";
            this.Lap3Split.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.label34.Location = new System.Drawing.Point(1758, 1018);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(264, 52);
            this.label34.TabIndex = 74;
            this.label34.Text = "Checkpoint 2:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.label40.Location = new System.Drawing.Point(1758, 861);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(264, 52);
            this.label40.TabIndex = 68;
            this.label40.Text = "Checkpoint 1:";
            // 
            // Lap3TimeLabel
            // 
            this.Lap3TimeLabel.AutoSize = true;
            this.Lap3TimeLabel.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap3TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap3TimeLabel.Location = new System.Drawing.Point(1919, 654);
            this.Lap3TimeLabel.Name = "Lap3TimeLabel";
            this.Lap3TimeLabel.Size = new System.Drawing.Size(125, 52);
            this.Lap3TimeLabel.TabIndex = 62;
            this.Lap3TimeLabel.Text = "Time:";
            // 
            // Lap2Timer
            // 
            this.Lap2Timer.Interval = 94;
            this.Lap2Timer.Tick += new System.EventHandler(this.Lap2Timer_Tick);
            // 
            // Lap3Timer
            // 
            this.Lap3Timer.Interval = 94;
            this.Lap3Timer.Tick += new System.EventHandler(this.Lap3Timer_Tick);
            // 
            // Lap1Label
            // 
            this.Lap1Label.AutoSize = true;
            this.Lap1Label.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap1Label.Location = new System.Drawing.Point(701, 654);
            this.Lap1Label.Name = "Lap1Label";
            this.Lap1Label.Size = new System.Drawing.Size(143, 52);
            this.Lap1Label.TabIndex = 78;
            this.Lap1Label.Text = "-- : -- . -";
            // 
            // Lap1Cp1Label
            // 
            this.Lap1Cp1Label.AutoSize = true;
            this.Lap1Cp1Label.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap1Cp1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap1Cp1Label.Location = new System.Drawing.Point(701, 861);
            this.Lap1Cp1Label.Name = "Lap1Cp1Label";
            this.Lap1Cp1Label.Size = new System.Drawing.Size(143, 52);
            this.Lap1Cp1Label.TabIndex = 79;
            this.Lap1Cp1Label.Text = "-- : -- . -";
            // 
            // Lap1Cp2Label
            // 
            this.Lap1Cp2Label.AutoSize = true;
            this.Lap1Cp2Label.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap1Cp2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap1Cp2Label.Location = new System.Drawing.Point(701, 1018);
            this.Lap1Cp2Label.Name = "Lap1Cp2Label";
            this.Lap1Cp2Label.Size = new System.Drawing.Size(143, 52);
            this.Lap1Cp2Label.TabIndex = 80;
            this.Lap1Cp2Label.Text = "-- : -- . -";
            // 
            // Lap2Label
            // 
            this.Lap2Label.AutoSize = true;
            this.Lap2Label.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap2Label.Location = new System.Drawing.Point(1384, 654);
            this.Lap2Label.Name = "Lap2Label";
            this.Lap2Label.Size = new System.Drawing.Size(143, 52);
            this.Lap2Label.TabIndex = 81;
            this.Lap2Label.Text = "-- : -- . -";
            // 
            // Lap2Cp2Label
            // 
            this.Lap2Cp2Label.AutoSize = true;
            this.Lap2Cp2Label.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap2Cp2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap2Cp2Label.Location = new System.Drawing.Point(1384, 1018);
            this.Lap2Cp2Label.Name = "Lap2Cp2Label";
            this.Lap2Cp2Label.Size = new System.Drawing.Size(143, 52);
            this.Lap2Cp2Label.TabIndex = 82;
            this.Lap2Cp2Label.Text = "-- : -- . -";
            // 
            // Lap3Label
            // 
            this.Lap3Label.AutoSize = true;
            this.Lap3Label.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap3Label.Location = new System.Drawing.Point(2070, 654);
            this.Lap3Label.Name = "Lap3Label";
            this.Lap3Label.Size = new System.Drawing.Size(143, 52);
            this.Lap3Label.TabIndex = 83;
            this.Lap3Label.Text = "-- : -- . -";
            // 
            // Lap3Cp1Label
            // 
            this.Lap3Cp1Label.AutoSize = true;
            this.Lap3Cp1Label.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap3Cp1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap3Cp1Label.Location = new System.Drawing.Point(2070, 861);
            this.Lap3Cp1Label.Name = "Lap3Cp1Label";
            this.Lap3Cp1Label.Size = new System.Drawing.Size(143, 52);
            this.Lap3Cp1Label.TabIndex = 84;
            this.Lap3Cp1Label.Text = "-- : -- . -";
            // 
            // Lap3Cp2Label
            // 
            this.Lap3Cp2Label.AutoSize = true;
            this.Lap3Cp2Label.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap3Cp2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap3Cp2Label.Location = new System.Drawing.Point(2071, 1018);
            this.Lap3Cp2Label.Name = "Lap3Cp2Label";
            this.Lap3Cp2Label.Size = new System.Drawing.Size(143, 52);
            this.Lap3Cp2Label.TabIndex = 85;
            this.Lap3Cp2Label.Text = "-- : -- . -";
            // 
            // Lap2Cp1Label
            // 
            this.Lap2Cp1Label.AutoSize = true;
            this.Lap2Cp1Label.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lap2Cp1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.Lap2Cp1Label.Location = new System.Drawing.Point(1384, 861);
            this.Lap2Cp1Label.Name = "Lap2Cp1Label";
            this.Lap2Cp1Label.Size = new System.Drawing.Size(143, 52);
            this.Lap2Cp1Label.TabIndex = 86;
            this.Lap2Cp1Label.Text = "-- : -- . -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(31)))));
            this.label4.Location = new System.Drawing.Point(1993, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 52);
            this.label4.TabIndex = 87;
            this.label4.Text = "Lap 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(31)))));
            this.label5.Location = new System.Drawing.Point(1309, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 52);
            this.label5.TabIndex = 88;
            this.label5.Text = "Lap 2";
            // 
            // dataIn
            // 
            this.dataIn.AutoSize = true;
            this.dataIn.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.dataIn.Location = new System.Drawing.Point(681, 1696);
            this.dataIn.Name = "dataIn";
            this.dataIn.Size = new System.Drawing.Size(47, 52);
            this.dataIn.TabIndex = 89;
            this.dataIn.Text = "--";
            this.dataIn.TextChanged += new System.EventHandler(this.dataIn_TextChanged_1);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(34)))), ((int)(((byte)(255)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Gill Sans MT", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.startButton.Location = new System.Drawing.Point(1242, 327);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(285, 92);
            this.startButton.TabIndex = 90;
            this.startButton.Text = "Start Race";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(34)))), ((int)(((byte)(255)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.resetButton.Location = new System.Drawing.Point(2551, 1683);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(173, 59);
            this.resetButton.TabIndex = 91;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // appWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(82)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(2736, 1754);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.dataIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lap2Cp1Label);
            this.Controls.Add(this.Lap3Cp2Label);
            this.Controls.Add(this.Lap3Cp1Label);
            this.Controls.Add(this.Lap3Label);
            this.Controls.Add(this.Lap2Cp2Label);
            this.Controls.Add(this.Lap2Label);
            this.Controls.Add(this.Lap1Cp2Label);
            this.Controls.Add(this.Lap1Cp1Label);
            this.Controls.Add(this.Lap1Label);
            this.Controls.Add(this.Lap3Cp2Split);
            this.Controls.Add(this.Lap3Cp1Split);
            this.Controls.Add(this.Lap3Split);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.Lap3TimeLabel);
            this.Controls.Add(this.Lap2Cp2Split);
            this.Controls.Add(this.Lap2Cp1Split);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Lap2TimeLabel);
            this.Controls.Add(this.Lap2Split);
            this.Controls.Add(this.lapText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cp1TimeLabel);
            this.Controls.Add(this.spLabel);
            this.Controls.Add(this.Lap1Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "appWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "appWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.appWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lap1Time;
        private System.Windows.Forms.Timer Lap1Timer;
        private System.Windows.Forms.Label spLabel;
        private System.Windows.Forms.Label cp1TimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lapText;
        private System.Windows.Forms.Label Lap2Split;
        private System.Windows.Forms.Label Lap2Cp2Split;
        private System.Windows.Forms.Label Lap2Cp1Split;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label Lap2TimeLabel;
        private System.Windows.Forms.Label Lap3Cp2Split;
        private System.Windows.Forms.Label Lap3Cp1Split;
        private System.Windows.Forms.Label Lap3Split;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label Lap3TimeLabel;
        private System.Windows.Forms.Timer Lap2Timer;
        private System.Windows.Forms.Timer Lap3Timer;
        private System.Windows.Forms.Label Lap1Label;
        private System.Windows.Forms.Label Lap1Cp1Label;
        private System.Windows.Forms.Label Lap1Cp2Label;
        private System.Windows.Forms.Label Lap2Label;
        private System.Windows.Forms.Label Lap2Cp2Label;
        private System.Windows.Forms.Label Lap3Label;
        private System.Windows.Forms.Label Lap3Cp1Label;
        private System.Windows.Forms.Label Lap3Cp2Label;
        private System.Windows.Forms.Label Lap2Cp1Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dataIn;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
    }
}

