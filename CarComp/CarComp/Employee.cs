using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarComp
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelcomePage Wp = new WelcomePage();
            this.Hide();
            Wp.ShowDialog();
        }

        private void New_Click(object sender, EventArgs e)
        {
            Empnew en = new Empnew();
            this.Hide();
            en.ShowDialog();

        }

        private void Existing_Click(object sender, EventArgs e)
        {
            Empexs ex = new Empexs();
            this.Hide();
            ex.ShowDialog();
        }
    }
}
