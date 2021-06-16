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
    public partial class Empexs : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Empexs()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String connectionString = "Server = DESKTOP-J27TRJS; Database = cmpt291-proj; Trusted_Connection = yes; user id=Juanacon;" + // Username
                                       "password=Tails1;" + // Password
                                       "server=localhost;" + // IP for the server
                                                             //"Trusted_Connection=yes;" +
                                       "database= cmpt291-proj; " + // Database to connect to
                                       "connection timeout=30";
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            string l = "Please Enter an Existing Employee ID";
            string f = "SELECT COUNT(*) from Employee where ID=('" + textBox1.Text + "')";


            using (SqlCommand sqlCommand = new SqlCommand(f, myConnection))
            {

                int userCount = (int)sqlCommand.ExecuteScalar();

                if (userCount > 0)
                {
                    Dashboard DB = new Dashboard();
                    this.Hide();
                    DB.ShowDialog();

                }
                else if (userCount == 0)
                {

                    MessageBox.Show(l.ToString(), "Error");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Employee em = new Employee();
            this.Hide();
            em.ShowDialog();
        }
    }
}
