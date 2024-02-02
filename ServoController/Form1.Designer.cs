namespace ServoController
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
            Servo1Pos = new TrackBar();
            Servo2Pos = new TrackBar();
            Servo3Pos = new TrackBar();
            Servo5Pos = new TrackBar();
            Servo6Pos = new TrackBar();
            Servo4Pos = new TrackBar();
            Servo8Pos = new TrackBar();
            Servo7Pos = new TrackBar();
            connectBut = new Button();
            Servo1Lab = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            statusLabel = new Label();
            Servo1Label = new Label();
            Servo2Label = new Label();
            Servo3Label = new Label();
            Servo4Label = new Label();
            Servo5Label = new Label();
            Servo6Label = new Label();
            Servo7Label = new Label();
            Servo8Label = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            delayBox = new TextBox();
            label11 = new Label();
            button6 = new Button();
            textBox1 = new TextBox();
            button7 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            uploadTextFileToolStripMenuItem = new ToolStripMenuItem();
            saveAsTextFileToolStripMenuItem = new ToolStripMenuItem();
            textBox2 = new TextBox();
            label12 = new Label();
            speedSlider = new TrackBar();
            label13 = new Label();
            currentSpeedLabel = new Label();
            label14 = new Label();
            button8 = new Button();
            SetSliderDefaultBut = new Button();
            ClearListBut = new Button();
            ((System.ComponentModel.ISupportInitialize)Servo1Pos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Servo2Pos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Servo3Pos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Servo5Pos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Servo6Pos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Servo4Pos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Servo8Pos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Servo7Pos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)speedSlider).BeginInit();
            SuspendLayout();
            // 
            // Servo1Pos
            // 
            Servo1Pos.Anchor = AnchorStyles.Top;
            Servo1Pos.Location = new Point(44, 123);
            Servo1Pos.Margin = new Padding(4, 5, 4, 5);
            Servo1Pos.Maximum = 100;
            Servo1Pos.Minimum = -100;
            Servo1Pos.Name = "Servo1Pos";
            Servo1Pos.Orientation = Orientation.Vertical;
            Servo1Pos.Size = new Size(69, 1078);
            Servo1Pos.TabIndex = 0;
            Servo1Pos.TickStyle = TickStyle.Both;
            Servo1Pos.ValueChanged += Servo1Pos_ValueChanged;
            // 
            // Servo2Pos
            // 
            Servo2Pos.Anchor = AnchorStyles.Top;
            Servo2Pos.Location = new Point(166, 123);
            Servo2Pos.Margin = new Padding(4, 5, 4, 5);
            Servo2Pos.Maximum = 100;
            Servo2Pos.Minimum = -100;
            Servo2Pos.Name = "Servo2Pos";
            Servo2Pos.Orientation = Orientation.Vertical;
            Servo2Pos.Size = new Size(69, 1078);
            Servo2Pos.TabIndex = 1;
            Servo2Pos.TickStyle = TickStyle.Both;
            Servo2Pos.ValueChanged += Servo2Pos_ValueChanged;
            // 
            // Servo3Pos
            // 
            Servo3Pos.Anchor = AnchorStyles.Top;
            Servo3Pos.Location = new Point(276, 123);
            Servo3Pos.Margin = new Padding(4, 5, 4, 5);
            Servo3Pos.Maximum = 100;
            Servo3Pos.Minimum = -100;
            Servo3Pos.Name = "Servo3Pos";
            Servo3Pos.Orientation = Orientation.Vertical;
            Servo3Pos.Size = new Size(69, 1078);
            Servo3Pos.TabIndex = 2;
            Servo3Pos.TickStyle = TickStyle.Both;
            Servo3Pos.ValueChanged += Servo3Pos_ValueChanged;
            // 
            // Servo5Pos
            // 
            Servo5Pos.Anchor = AnchorStyles.Top;
            Servo5Pos.Location = new Point(509, 123);
            Servo5Pos.Margin = new Padding(4, 5, 4, 5);
            Servo5Pos.Maximum = 40;
            Servo5Pos.Minimum = -60;
            Servo5Pos.Name = "Servo5Pos";
            Servo5Pos.Orientation = Orientation.Vertical;
            Servo5Pos.Size = new Size(69, 1078);
            Servo5Pos.TabIndex = 3;
            Servo5Pos.TickStyle = TickStyle.Both;
            Servo5Pos.ValueChanged += Servo5Pos_ValueChanged;
            // 
            // Servo6Pos
            // 
            Servo6Pos.Anchor = AnchorStyles.Top;
            Servo6Pos.Location = new Point(617, 123);
            Servo6Pos.Margin = new Padding(4, 5, 4, 5);
            Servo6Pos.Maximum = 40;
            Servo6Pos.Minimum = -60;
            Servo6Pos.Name = "Servo6Pos";
            Servo6Pos.Orientation = Orientation.Vertical;
            Servo6Pos.Size = new Size(69, 1078);
            Servo6Pos.TabIndex = 4;
            Servo6Pos.TickStyle = TickStyle.Both;
            Servo6Pos.ValueChanged += Servo6Pos_ValueChanged;
            // 
            // Servo4Pos
            // 
            Servo4Pos.Anchor = AnchorStyles.Top;
            Servo4Pos.Location = new Point(387, 123);
            Servo4Pos.Margin = new Padding(4, 5, 4, 5);
            Servo4Pos.Maximum = 100;
            Servo4Pos.Minimum = -100;
            Servo4Pos.Name = "Servo4Pos";
            Servo4Pos.Orientation = Orientation.Vertical;
            Servo4Pos.Size = new Size(69, 1078);
            Servo4Pos.TabIndex = 8;
            Servo4Pos.TickStyle = TickStyle.Both;
            Servo4Pos.ValueChanged += Servo4Pos_ValueChanged;
            // 
            // Servo8Pos
            // 
            Servo8Pos.Anchor = AnchorStyles.Top;
            Servo8Pos.Location = new Point(849, 123);
            Servo8Pos.Margin = new Padding(4, 5, 4, 5);
            Servo8Pos.Maximum = 40;
            Servo8Pos.Minimum = -60;
            Servo8Pos.Name = "Servo8Pos";
            Servo8Pos.Orientation = Orientation.Vertical;
            Servo8Pos.Size = new Size(69, 1078);
            Servo8Pos.TabIndex = 9;
            Servo8Pos.TickStyle = TickStyle.Both;
            Servo8Pos.ValueChanged += Servo8Pos_ValueChanged;
            // 
            // Servo7Pos
            // 
            Servo7Pos.Anchor = AnchorStyles.Top;
            Servo7Pos.Location = new Point(733, 123);
            Servo7Pos.Margin = new Padding(4, 5, 4, 5);
            Servo7Pos.Maximum = 40;
            Servo7Pos.Minimum = -60;
            Servo7Pos.Name = "Servo7Pos";
            Servo7Pos.Orientation = Orientation.Vertical;
            Servo7Pos.Size = new Size(69, 1078);
            Servo7Pos.TabIndex = 10;
            Servo7Pos.TickStyle = TickStyle.Both;
            Servo7Pos.ValueChanged += Servo7Pos_ValueChanged;
            // 
            // connectBut
            // 
            connectBut.Anchor = AnchorStyles.Right;
            connectBut.Location = new Point(1707, 875);
            connectBut.Margin = new Padding(4, 5, 4, 5);
            connectBut.Name = "connectBut";
            connectBut.Size = new Size(107, 38);
            connectBut.TabIndex = 17;
            connectBut.Text = "Connect";
            connectBut.UseVisualStyleBackColor = true;
            connectBut.Click += connectBut_Click;
            // 
            // Servo1Lab
            // 
            Servo1Lab.AutoSize = true;
            Servo1Lab.Location = new Point(44, 93);
            Servo1Lab.Margin = new Padding(4, 0, 4, 0);
            Servo1Lab.Name = "Servo1Lab";
            Servo1Lab.Size = new Size(62, 25);
            Servo1Lab.TabIndex = 36;
            Servo1Lab.Text = "2 FL-X";
            Servo1Lab.DoubleClick += Servo1Lab_DoubleClick;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Right;
            numericUpDown1.Location = new Point(1527, 875);
            numericUpDown1.Margin = new Padding(4, 5, 4, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(171, 31);
            numericUpDown1.TabIndex = 37;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1469, 882);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 38;
            label1.Text = "COM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 93);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 40;
            label3.Text = "1 FR-X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 93);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 41;
            label4.Text = "1 BL-X";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 93);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 42;
            label5.Text = "2 BR-X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(509, 92);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 43;
            label6.Text = "2 FL-Y";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(617, 93);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 44;
            label7.Text = "1 FR-Y";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(733, 92);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 25);
            label8.TabIndex = 45;
            label8.Text = "1 BL-Y";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(849, 93);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 46;
            label9.Text = "2 BR-Y";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(1527, 935);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(64, 25);
            label10.TabIndex = 47;
            label10.Text = "Status:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.ForeColor = Color.DarkRed;
            statusLabel.Location = new Point(1596, 935);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(132, 25);
            statusLabel.TabIndex = 48;
            statusLabel.Text = "Not Connected";
            // 
            // Servo1Label
            // 
            Servo1Label.AutoSize = true;
            Servo1Label.Location = new Point(63, 1207);
            Servo1Label.Margin = new Padding(4, 0, 4, 0);
            Servo1Label.Name = "Servo1Label";
            Servo1Label.Size = new Size(22, 25);
            Servo1Label.TabIndex = 49;
            Servo1Label.Text = "0";
            // 
            // Servo2Label
            // 
            Servo2Label.AutoSize = true;
            Servo2Label.Location = new Point(182, 1207);
            Servo2Label.Margin = new Padding(4, 0, 4, 0);
            Servo2Label.Name = "Servo2Label";
            Servo2Label.Size = new Size(22, 25);
            Servo2Label.TabIndex = 50;
            Servo2Label.Text = "0";
            // 
            // Servo3Label
            // 
            Servo3Label.AutoSize = true;
            Servo3Label.Location = new Point(294, 1207);
            Servo3Label.Margin = new Padding(4, 0, 4, 0);
            Servo3Label.Name = "Servo3Label";
            Servo3Label.Size = new Size(22, 25);
            Servo3Label.TabIndex = 51;
            Servo3Label.Text = "0";
            // 
            // Servo4Label
            // 
            Servo4Label.AutoSize = true;
            Servo4Label.Location = new Point(407, 1207);
            Servo4Label.Margin = new Padding(4, 0, 4, 0);
            Servo4Label.Name = "Servo4Label";
            Servo4Label.Size = new Size(22, 25);
            Servo4Label.TabIndex = 52;
            Servo4Label.Text = "0";
            // 
            // Servo5Label
            // 
            Servo5Label.AutoSize = true;
            Servo5Label.Location = new Point(530, 1207);
            Servo5Label.Margin = new Padding(4, 0, 4, 0);
            Servo5Label.Name = "Servo5Label";
            Servo5Label.Size = new Size(22, 25);
            Servo5Label.TabIndex = 53;
            Servo5Label.Text = "0";
            // 
            // Servo6Label
            // 
            Servo6Label.AutoSize = true;
            Servo6Label.Location = new Point(639, 1207);
            Servo6Label.Margin = new Padding(4, 0, 4, 0);
            Servo6Label.Name = "Servo6Label";
            Servo6Label.Size = new Size(22, 25);
            Servo6Label.TabIndex = 54;
            Servo6Label.Text = "0";
            // 
            // Servo7Label
            // 
            Servo7Label.AutoSize = true;
            Servo7Label.Location = new Point(753, 1207);
            Servo7Label.Margin = new Padding(4, 0, 4, 0);
            Servo7Label.Name = "Servo7Label";
            Servo7Label.Size = new Size(22, 25);
            Servo7Label.TabIndex = 55;
            Servo7Label.Text = "0";
            // 
            // Servo8Label
            // 
            Servo8Label.AutoSize = true;
            Servo8Label.Location = new Point(869, 1207);
            Servo8Label.Margin = new Padding(4, 0, 4, 0);
            Servo8Label.Name = "Servo8Label";
            Servo8Label.Size = new Size(22, 25);
            Servo8Label.TabIndex = 56;
            Servo8Label.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(1824, 875);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 57;
            button1.Text = "Disconnect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1044, 80);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(831, 229);
            listBox1.TabIndex = 58;
            // 
            // button2
            // 
            button2.Location = new Point(1020, 603);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(107, 38);
            button2.TabIndex = 59;
            button2.Text = "Add to List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1091, 360);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(107, 38);
            button3.TabIndex = 60;
            button3.Text = "Add Delay";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1166, 603);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(107, 38);
            button4.TabIndex = 61;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1443, 315);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(107, 38);
            button5.TabIndex = 62;
            button5.Text = "Play";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // delayBox
            // 
            delayBox.Location = new Point(1076, 312);
            delayBox.Margin = new Padding(4, 5, 4, 5);
            delayBox.Name = "delayBox";
            delayBox.Size = new Size(141, 31);
            delayBox.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1011, 322);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(60, 25);
            label11.TabIndex = 64;
            label11.Text = "Delay:";
            // 
            // button6
            // 
            button6.Location = new Point(1641, 322);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(153, 38);
            button6.TabIndex = 65;
            button6.Text = "Set Slider Values";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1044, 3);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(613, 31);
            textBox1.TabIndex = 66;
            // 
            // button7
            // 
            button7.Location = new Point(1687, 2);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(107, 38);
            button7.TabIndex = 67;
            button7.Text = "Add Value";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(2564, 35);
            menuStrip1.TabIndex = 68;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uploadTextFileToolStripMenuItem, saveAsTextFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // uploadTextFileToolStripMenuItem
            // 
            uploadTextFileToolStripMenuItem.Name = "uploadTextFileToolStripMenuItem";
            uploadTextFileToolStripMenuItem.Size = new Size(235, 34);
            uploadTextFileToolStripMenuItem.Text = "Upload text file";
            uploadTextFileToolStripMenuItem.Click += uploadTextFileToolStripMenuItem_Click;
            // 
            // saveAsTextFileToolStripMenuItem
            // 
            saveAsTextFileToolStripMenuItem.Name = "saveAsTextFileToolStripMenuItem";
            saveAsTextFileToolStripMenuItem.Size = new Size(235, 34);
            saveAsTextFileToolStripMenuItem.Text = "Save as text file";
            saveAsTextFileToolStripMenuItem.Click += saveAsTextFileToolStripMenuItem_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1291, 312);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 31);
            textBox2.TabIndex = 69;
            textBox2.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1376, 47);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 25);
            label12.TabIndex = 70;
            label12.Text = "Move List";
            // 
            // speedSlider
            // 
            speedSlider.Location = new Point(1243, 440);
            speedSlider.Maximum = 5000;
            speedSlider.Minimum = 100;
            speedSlider.Name = "speedSlider";
            speedSlider.Size = new Size(571, 69);
            speedSlider.TabIndex = 71;
            speedSlider.Value = 1000;
            speedSlider.ValueChanged += speedSlider_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1261, 528);
            label13.Name = "label13";
            label13.Size = new Size(105, 25);
            label13.TabIndex = 72;
            label13.Text = "Min. 100ms";
            // 
            // currentSpeedLabel
            // 
            currentSpeedLabel.AutoSize = true;
            currentSpeedLabel.Location = new Point(1469, 528);
            currentSpeedLabel.Name = "currentSpeedLabel";
            currentSpeedLabel.Size = new Size(129, 25);
            currentSpeedLabel.TabIndex = 73;
            currentSpeedLabel.Text = "Current Speed:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1686, 528);
            label14.Name = "label14";
            label14.Size = new Size(118, 25);
            label14.TabIndex = 74;
            label14.Text = "Max. 5000ms";
            // 
            // button8
            // 
            button8.Location = new Point(1086, 519);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 75;
            button8.Text = "Set Default";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // SetSliderDefaultBut
            // 
            SetSliderDefaultBut.Location = new Point(387, 1325);
            SetSliderDefaultBut.Name = "SetSliderDefaultBut";
            SetSliderDefaultBut.Size = new Size(191, 34);
            SetSliderDefaultBut.TabIndex = 76;
            SetSliderDefaultBut.Text = "Set Sliders Default";
            SetSliderDefaultBut.UseVisualStyleBackColor = true;
            SetSliderDefaultBut.Click += SetSliderDefaultBut_Click;
            // 
            // ClearListBut
            // 
            ClearListBut.Location = new Point(1947, 137);
            ClearListBut.Name = "ClearListBut";
            ClearListBut.Size = new Size(112, 34);
            ClearListBut.TabIndex = 77;
            ClearListBut.Text = "Clear List";
            ClearListBut.UseVisualStyleBackColor = true;
            ClearListBut.Click += ClearListBut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1570);
            Controls.Add(ClearListBut);
            Controls.Add(SetSliderDefaultBut);
            Controls.Add(button8);
            Controls.Add(label14);
            Controls.Add(currentSpeedLabel);
            Controls.Add(label13);
            Controls.Add(speedSlider);
            Controls.Add(label12);
            Controls.Add(textBox2);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(label11);
            Controls.Add(delayBox);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(Servo8Label);
            Controls.Add(Servo7Label);
            Controls.Add(Servo6Label);
            Controls.Add(Servo5Label);
            Controls.Add(Servo4Label);
            Controls.Add(Servo3Label);
            Controls.Add(Servo2Label);
            Controls.Add(Servo1Label);
            Controls.Add(statusLabel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(Servo1Lab);
            Controls.Add(connectBut);
            Controls.Add(Servo7Pos);
            Controls.Add(Servo8Pos);
            Controls.Add(Servo4Pos);
            Controls.Add(Servo6Pos);
            Controls.Add(Servo5Pos);
            Controls.Add(Servo3Pos);
            Controls.Add(Servo2Pos);
            Controls.Add(Servo1Pos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Servo Controller";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Servo1Pos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Servo2Pos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Servo3Pos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Servo5Pos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Servo6Pos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Servo4Pos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Servo8Pos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Servo7Pos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)speedSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar Servo1Pos;
        private TrackBar Servo2Pos;
        private TrackBar Servo3Pos;
        private TrackBar Servo5Pos;
        private TrackBar Servo6Pos;
        private TrackBar Servo4Pos;
        private TrackBar Servo8Pos;
        private TrackBar Servo7Pos;
        private Button connectBut;
        private Label Servo1Lab;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label statusLabel;
        private Label Servo1Label;
        private Label Servo2Label;
        private Label Servo3Label;
        private Label Servo4Label;
        private Label Servo5Label;
        private Label Servo6Label;
        private Label Servo7Label;
        private Label Servo8Label;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox delayBox;
        private Label label11;
        private Button button6;
        private TextBox textBox1;
        private Button button7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveAsTextFileToolStripMenuItem;
        private TextBox textBox2;
        private ToolStripMenuItem uploadTextFileToolStripMenuItem;
        private Label label12;
        private TrackBar speedSlider;
        private Label label13;
        private Label currentSpeedLabel;
        private Label label14;
        private Button button8;
        private Button SetSliderDefaultBut;
        private Button ClearListBut;
    }
}