namespace LEDControl
{
    partial class Form1
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
            this.sendIt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.blue = new System.Windows.Forms.Label();
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.openPort = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.randomBtn = new System.Windows.Forms.Button();
            this.lightSpeed = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colourExample = new System.Windows.Forms.PictureBox();
            this.blueDisplay = new System.Windows.Forms.Label();
            this.greenDisplay = new System.Windows.Forms.Label();
            this.redDisplay = new System.Windows.Forms.Label();
            this.rgbValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.blueValue = new System.Windows.Forms.TrackBar();
            this.greenValue = new System.Windows.Forms.TrackBar();
            this.redValue = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.raveModeChk = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colourExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendIt
            // 
            this.sendIt.Location = new System.Drawing.Point(31, 417);
            this.sendIt.Name = "sendIt";
            this.sendIt.Size = new System.Drawing.Size(75, 23);
            this.sendIt.TabIndex = 3;
            this.sendIt.Text = "Send It!";
            this.sendIt.UseVisualStyleBackColor = true;
            this.sendIt.Click += new System.EventHandler(this.sendIt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "LED Changing Software";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(6, 35);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(27, 13);
            this.R.TabIndex = 5;
            this.R.Text = "Red";
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(6, 66);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(36, 13);
            this.Green.TabIndex = 6;
            this.Green.Text = "Green";
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(6, 99);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(28, 13);
            this.blue.TabIndex = 7;
            this.blue.Text = "Blue";
            // 
            // comPorts
            // 
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Location = new System.Drawing.Point(117, 24);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(121, 21);
            this.comPorts.TabIndex = 8;
            // 
            // openPort
            // 
            this.openPort.Location = new System.Drawing.Point(6, 22);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(75, 23);
            this.openPort.TabIndex = 9;
            this.openPort.Text = "Open Port";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(9, 19);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(75, 23);
            this.randomBtn.TabIndex = 11;
            this.randomBtn.Text = "Random Button";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // lightSpeed
            // 
            this.lightSpeed.Tick += new System.EventHandler(this.lightSpeed_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colourExample);
            this.groupBox1.Controls.Add(this.blueDisplay);
            this.groupBox1.Controls.Add(this.greenDisplay);
            this.groupBox1.Controls.Add(this.redDisplay);
            this.groupBox1.Controls.Add(this.rgbValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.blueValue);
            this.groupBox1.Controls.Add(this.greenValue);
            this.groupBox1.Controls.Add(this.redValue);
            this.groupBox1.Controls.Add(this.R);
            this.groupBox1.Controls.Add(this.Green);
            this.groupBox1.Controls.Add(this.blue);
            this.groupBox1.Location = new System.Drawing.Point(22, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 154);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specific Colour";
            // 
            // colourExample
            // 
            this.colourExample.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colourExample.Location = new System.Drawing.Point(213, 127);
            this.colourExample.Name = "colourExample";
            this.colourExample.Size = new System.Drawing.Size(68, 21);
            this.colourExample.TabIndex = 16;
            this.colourExample.TabStop = false;
            // 
            // blueDisplay
            // 
            this.blueDisplay.AutoSize = true;
            this.blueDisplay.Location = new System.Drawing.Point(287, 99);
            this.blueDisplay.Name = "blueDisplay";
            this.blueDisplay.Size = new System.Drawing.Size(13, 13);
            this.blueDisplay.TabIndex = 15;
            this.blueDisplay.Text = "0";
            // 
            // greenDisplay
            // 
            this.greenDisplay.AutoSize = true;
            this.greenDisplay.Location = new System.Drawing.Point(288, 67);
            this.greenDisplay.Name = "greenDisplay";
            this.greenDisplay.Size = new System.Drawing.Size(13, 13);
            this.greenDisplay.TabIndex = 14;
            this.greenDisplay.Text = "0";
            // 
            // redDisplay
            // 
            this.redDisplay.AutoSize = true;
            this.redDisplay.Location = new System.Drawing.Point(288, 35);
            this.redDisplay.Name = "redDisplay";
            this.redDisplay.Size = new System.Drawing.Size(13, 13);
            this.redDisplay.TabIndex = 13;
            this.redDisplay.Text = "0";
            // 
            // rgbValue
            // 
            this.rgbValue.AutoSize = true;
            this.rgbValue.Location = new System.Drawing.Point(113, 131);
            this.rgbValue.Name = "rgbValue";
            this.rgbValue.Size = new System.Drawing.Size(54, 13);
            this.rgbValue.TabIndex = 12;
            this.rgbValue.Text = "R0 G0 B0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Colour Combination:";
            // 
            // blueValue
            // 
            this.blueValue.Location = new System.Drawing.Point(48, 99);
            this.blueValue.Maximum = 255;
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(233, 45);
            this.blueValue.TabIndex = 10;
            this.blueValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blueValue.Scroll += new System.EventHandler(this.blueValue_Scroll);
            // 
            // greenValue
            // 
            this.greenValue.Location = new System.Drawing.Point(48, 66);
            this.greenValue.Maximum = 255;
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(233, 45);
            this.greenValue.TabIndex = 9;
            this.greenValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.greenValue.Scroll += new System.EventHandler(this.greenValue_Scroll);
            // 
            // redValue
            // 
            this.redValue.Location = new System.Drawing.Point(48, 35);
            this.redValue.Maximum = 255;
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(233, 45);
            this.redValue.TabIndex = 8;
            this.redValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.redValue.Scroll += new System.EventHandler(this.redValue_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comPorts);
            this.groupBox2.Controls.Add(this.openPort);
            this.groupBox2.Location = new System.Drawing.Point(22, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 58);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.raveModeChk);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.randomBtn);
            this.groupBox3.Location = new System.Drawing.Point(22, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modes";
            // 
            // raveModeChk
            // 
            this.raveModeChk.AutoSize = true;
            this.raveModeChk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.raveModeChk.Location = new System.Drawing.Point(178, 46);
            this.raveModeChk.Name = "raveModeChk";
            this.raveModeChk.Size = new System.Drawing.Size(78, 17);
            this.raveModeChk.TabIndex = 14;
            this.raveModeChk.Text = "checkBox1";
            this.raveModeChk.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Pulse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Fade";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendIt);
            this.Name = "Form1";
            this.Text = "By Nick Anzellotti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colourExample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendIt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label blue;
        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.Button openPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Timer lightSpeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label blueDisplay;
        private System.Windows.Forms.Label greenDisplay;
        private System.Windows.Forms.Label redDisplay;
        private System.Windows.Forms.Label rgbValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar blueValue;
        private System.Windows.Forms.TrackBar greenValue;
        private System.Windows.Forms.TrackBar redValue;
        private System.Windows.Forms.PictureBox colourExample;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox raveModeChk;
    }
}

