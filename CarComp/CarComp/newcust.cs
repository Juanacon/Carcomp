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
    public partial class newcust : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public newcust()
        {
            InitializeComponent();
            String connectionString = "Server = DESKTOP-J27TRJS; Database = cmpt291-proj; Trusted_Connection = yes;";


            /* Starting the connection */
            SqlConnection myConnection = new SqlConnection("user id=Juanacon;" + // Username
                                        "password=Tails1;" + // Password
                                        "server=localhost;" + // IP for the server
                                                              //"Trusted_Connection=yes;" +
                                        "database= cmpt291-proj; " + // Database to connect to
                                        "connection timeout=30"); // Timeout in seconds */

            myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void newcust_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Fname.Text.Trim() == "" || Lname.Text.Trim() == "" || Cnum.Text.Trim() == "" ||
              Snum.Text.Trim() == "" || Sname.Text.Trim() == "" || Prov.Text.Trim() == "" || Count.Text.Trim() == "" || membership.Text.Trim() == "" || label.Text.Trim() == ""
              || City.Text.Trim() == "" || Zip.Text.Trim() == "")
            {
                MessageBox.Show("All Fields are required", "Error");
            }
            else
            {
                try
                {
                    Random r = new Random();
                    int randNum = r.Next(1000000);
                    string sixDigitNumber = randNum.ToString("D6");
                    myCommand.CommandText = "insert into customer values (" + sixDigitNumber + ", '"
                                    + Fname.Text + "','" + Lname.Text + "','" + Sname.Text + "','" + Snum.Text + "','" + Aptnum.Text + "'" +
                             ",'" + City.Text + "','" + Zip.Text + "','" + Prov.Text + "','" + Count.Text + "','" + Cnum.Text + "','" + Onum.Text + "','" + membership.Text + "','" + label.Text + "')";
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                    custlog cl = new custlog();
                    this.Hide();
                    cl.ShowDialog();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            custlog cl = new custlog();
            this.Hide();
            cl.ShowDialog();
        }
    }
}
