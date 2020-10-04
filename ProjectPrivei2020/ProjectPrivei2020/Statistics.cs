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
    public partial class Statistics : Form
    {
        BL.SelectBL slectbl = new BL.SelectBL();

        public Statistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = slectbl.fetchDataToGraphs();
            if(dt != null)
            {
                this.chart1.DataSource = dt;
                this.chart1.Series[0].XValueMember = "Time";
                this.chart1.Series[0].YValueMembers = "Value";
                this.chart1.DataBind();
            }
            else
            {
                MessageBox.Show("No Data to Show", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
