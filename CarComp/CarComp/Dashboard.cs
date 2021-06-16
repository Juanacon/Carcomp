using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarComp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpBooking eb = new EmpBooking();
            this.Hide();
            eb.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpUpdates eu = new EmpUpdates();
            this.Hide();
            eu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpReports er = new EmpReports();
            this.Hide();
            er.ShowDialog();
        }
    }
}
