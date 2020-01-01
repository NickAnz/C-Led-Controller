using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LEDControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAvaliblePorts();
            
        }

        private void getAvaliblePorts()
        {
            //connects to all the avalible COM ports and displays them
            string[] ports = SerialPort.GetPortNames();
            comPorts.Items.AddRange(ports);
            sendIt.Enabled = false;
            randomBtn.Enabled = false;
            lightSpeed.Interval = 50;
            raveModeChk.Enabled = false;
            lightSpeed.Start();
            

        }

        private void updateRGBValues()
        {
            rgbValue.Text = "R" + redValue.Value + " G" + greenValue.Value + " B" + blueValue.Value;
            blueDisplay.Text = blueValue.Value.ToString();
            greenDisplay.Text = greenValue.Value.ToString();
            redDisplay.Text = redValue.Value.ToString();
            colourExample.BackColor = Color.FromArgb(redValue.Value, greenValue.Value, blueValue.Value);

        }

        private void randomColourChange()
        {
            Random rnd = new Random();
            serialPort1.WriteLine("R");
            blueValue.Value = rnd.Next(0, 255);
            greenValue.Value = rnd.Next(0, 255);
            redValue.Value = rnd.Next(0, 255);
            sendIt.PerformClick();
        }

        private void sendIt_Click(object sender, EventArgs e)
        {
            //R represents that the arduino on the serial connection will read the incoming serial values
            serialPort1.WriteLine("R");
            serialPort1.WriteLine(redValue.Value.ToString());
            serialPort1.WriteLine(greenValue.Value.ToString());
            serialPort1.WriteLine(blueValue.Value.ToString());
        }

       

        private void openPort_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comPorts.Text;
            serialPort1.BaudRate = 115200;
            serialPort1.Open();

            if (serialPort1.IsOpen)
            {
                openPort.Enabled = false;
                sendIt.Enabled = true;
                randomBtn.Enabled = true;
                raveModeChk.Enabled = true;
            }
            



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            randomColourChange();
            updateRGBValues();
        }

        private void lightSpeed_Tick(object sender, EventArgs e)
        {
            if (raveModeChk.Checked)
            {
                randomColourChange();
            }

        }
        
       

        private void redValue_Scroll(object sender, EventArgs e)
        {
            updateRGBValues();
        }

        private void greenValue_Scroll(object sender, EventArgs e)
        {
            updateRGBValues();
        }

        private void blueValue_Scroll(object sender, EventArgs e)
        {
            updateRGBValues();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
