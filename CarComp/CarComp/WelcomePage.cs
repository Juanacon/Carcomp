using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarComp
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            custlog cl = new custlog();
            this.Hide();
            cl.ShowDialog();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee Em = new Employee();
            this.Hide();
            Em.ShowDialog();
        }
    }
}
