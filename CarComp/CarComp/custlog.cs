using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarComp
{
    public partial class custlog : Form
    {
        public custlog()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelcomePage wp = new WelcomePage();
           
            this.Hide();
            wp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newcust nc = new newcust();

            this.Hide();
            nc.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excust ex = new Excust();

            this.Hide();
            ex.ShowDialog();
        }
    }
}
