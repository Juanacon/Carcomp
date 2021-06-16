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
    public partial class Excust : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Excust()
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "select (fName +' '+ LName) from Customer as fullName where (fName +' '+ LName) = '" +
                customer_name.Text + "'";

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "error");
            }
            try
            {
                myReader = myCommand.ExecuteReader();
                if (!myReader.Read())
                {
                    MessageBox.Show("Your Name does not exist in the system, Please sign up as a new Customer");
                    
                }
                else
                {
                    CustReg cs = new CustReg();
                    this.Hide();
                    cs.ShowDialog();

                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            custlog cs = new custlog();
            this.Hide();
            cs.ShowDialog();
        }
    }
}
