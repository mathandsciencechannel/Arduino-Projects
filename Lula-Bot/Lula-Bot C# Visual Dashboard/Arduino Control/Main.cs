using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Control
{
    public partial class Main : Form
    {
        string[] portarray;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void comportselect_DropDown(object sender, EventArgs e)
        {
            comportselect.Items.Clear();
            portarray = System.IO.Ports.SerialPort.GetPortNames();
            comportselect.Items.AddRange(portarray);
        }

        private void comportselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rccarcontrol_Click(object sender, EventArgs e)
        {
            RCCarControl rccarcontrol = new RCCarControl(comportselect.SelectedItem.ToString());
            try {
                rccarcontrol.Show();
            }
            catch{ }
        }
    }
}
