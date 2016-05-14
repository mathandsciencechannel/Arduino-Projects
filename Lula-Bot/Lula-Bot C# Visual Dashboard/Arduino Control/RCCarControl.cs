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

namespace Arduino_Control
{
    public partial class RCCarControl: Form
    {
        string data = "0.00";
        SerialPort Audrino = new SerialPort();
        char[] splitchars = { ' ' };
        public RCCarControl(string comport)
        {
            InitializeComponent();
            setupArduino(comport);
        }
        public void setupArduino(string comport)
        {
            try
            {
                Audrino.BaudRate = 9600;
                Audrino.PortName = comport;
                Audrino.Open();
                Audrino.DataReceived += Arduino_DataReceived;
                // serialtimer.Start();
            }
            catch(Exception ex)
            {
                this.Close();
            }
        }

        public void resetButtonColors()
        {
            FWD.BackColor = Color.FromArgb(255, 255, 255, 255);
            BWD.BackColor = Color.FromArgb(255, 255, 255, 255);
            RGT.BackColor = Color.FromArgb(255, 255, 255, 255);
            LFT.BackColor = Color.FromArgb(255, 255, 255, 255);
            STP.BackColor = Color.FromArgb(255, 255, 255, 255);
        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.mvoltage.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.mvoltage.Text = text;
            }
        }
        private void Arduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            data = Audrino.ReadLine();
            
            string[] splitarray = data.Split(splitchars);



            //double doubdata = Math.Round(Int32.Parse(data) / 204.8, 2);
            //double doubdata = Int32.Parse(splitarray[0]);
            if (data.ToString() != "")
                {
                SetText(splitarray[0]);
                }
            try
            {
                splitarray[1] = splitarray[1].Replace("\n", String.Empty);
                splitarray[1] = splitarray[1].Replace("\r", String.Empty);
                splitarray[1] = splitarray[1].Replace("\t", String.Empty);

                if (splitarray[1] == "F")
                {
                    resetButtonColors();
                    FWD.BackColor = Color.FromArgb(255, 0, 255, 0);
                }
                else if (splitarray[1] == "B")
                {
                    resetButtonColors();
                    BWD.BackColor = Color.FromArgb(255, 0, 255, 0);
                }
                else if (splitarray[1] == "L")
                {
                    resetButtonColors();
                    LFT.BackColor = Color.FromArgb(255, 0, 255, 0);
                }
                else if (splitarray[1] == "R")
                {
                    resetButtonColors();
                    RGT.BackColor = Color.FromArgb(255, 0, 255, 0);
                }
                else if (splitarray[1] == "S")
                {
                    resetButtonColors();
                    STP.BackColor = Color.FromArgb(255, 0, 255, 0);
                }
                else if (splitarray[1] == "M")
                {
                    

                }
            }
            catch
            {
                SetText("Error");
            }




        }
        private void Control_Load(object sender, EventArgs e)
        {
            
        }

        private void Forward(int speed)
        {
            Audrino.WriteLine("Forward " + speed);
        }

        private void Backward(int speed)
        {
            Audrino.WriteLine("Backward " + -speed);
        }

        private void Leftward(int speed)
        {
            Audrino.WriteLine("Left " + -speed);
        }

        private void Rightward(int speed)
        {
            Audrino.WriteLine("Right " + -speed);
        }

        private void Stop(int speed)
        {
            Audrino.WriteLine("Stop " + -speed);
        }


        private void FWD_Click(object sender, EventArgs e)
        {
            Forward(255);
        }

        private void STP_Click(object sender, EventArgs e)
        {
            Stop(255);
        }

        private void LFT_Click(object sender, EventArgs e)
        {
            Leftward(255);
        }

        private void RGT_Click(object sender, EventArgs e)
        {
            Rightward(255);
        }

        private void BWD_Click(object sender, EventArgs e)
        {
            Backward(255);
        }

        private void ToggleAutoDrive(bool autodrive)
        {
            if (autodrive == true)
            {
                Audrino.WriteLine("autodrive " + 1);
            }
            else
            {
                Audrino.WriteLine("autodrive " + 0);
            }
        }
        private void ToggleDistanceEnabled(bool DistanceEnabled)
        {
            if (DistanceEnabled == true)
            {
                Audrino.WriteLine("DistanceEnabled " + 1);
            }
            else
            {
                Audrino.WriteLine("DistanceEnabled " + 0);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ToggleAutoDrive(checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ToggleDistanceEnabled(checkBox2.Checked);
        }

        private void RCCarControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Audrino.Close();
        }

        private void LRTB_Scroll(object sender, EventArgs e)
        {
            FBTB.Value = 0;
            if(LRTB.Value>0)
            {
                Rightward(LRTB.Value);
            }
            if (LRTB.Value<0)
            {
                Rightward(LRTB.Value);
            }
            
        }

        private void FBTB_Scroll(object sender, EventArgs e)
        {
            LRTB.Value = 0;
            if (FBTB.Value > 0)
            {
                Forward(FBTB.Value);
            }
            if (FBTB.Value < 0)
            {
                Backward(FBTB.Value);
            }
        }
    }
}
