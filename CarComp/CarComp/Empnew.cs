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
    public partial class Empnew : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Empnew()
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

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee Em = new Employee();
            this.Hide();
            Em.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
      new System.Data.SqlClient.SqlConnection("user id=Juanacon;" + // Username
                                   "password=Tails1;" + // Password
                                   "server=localhost;" + // IP for the server
                                                         //"Trusted_Connection=yes;" +
                                   "database= cmpt291-proj; " + // Database to connect to
                                   "connection timeout=30"); // Timeout in seconds */
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            string bran = "123";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Employee values ('" + ID.Text +
                             "','" + Fname.Text + "','" + Lname.Text + "','" + Sname.Text + "','" + Snum.Text + "','" + Aptnum.Text + "'" +
                             ",'" + City.Text + "','" + Zip.Text + "','" + Prov.Text + "','" + Count.Text + "','" + Cnum.Text + "','" + Onum.Text + "','" + DOB.Text + "','" + bran + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();

            Employee Em = new Employee();
            this.Hide();
            Em.ShowDialog();
        }
    }
}
