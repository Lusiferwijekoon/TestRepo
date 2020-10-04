using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPrivei2020
{
    public partial class RestFloodEmergency : Form
    {
        public RestFloodEmergency()
        {
            InitializeComponent();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.uploadThreatLevel("Normal");
        }
    }
}
