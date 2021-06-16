using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CarComp
{
    public partial class EmpReports : Form
    {
        public EmpReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            this.Hide();
            db.ShowDialog();
        }
    }
}
