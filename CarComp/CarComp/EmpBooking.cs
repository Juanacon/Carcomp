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
    public partial class EmpBooking : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public EmpBooking()
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

        private void button3_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "update Rental set approved = 1 where RentalId = ('" + textBox1.Text + "') ";
            

            myCommand.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "delete from Rental where RentalId = ('" + textBox1.Text + "') ";
            
            myCommand.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard Db = new Dashboard();
            this.Hide();
            Db.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "Server = DESKTOP-J27TRJS; Database = cmpt291-proj; Trusted_Connection = yes;";
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            string v = "SELECT[RentalID],[fName],[LName],[Pickup_date],[Return_date],[carVin] FROM [Rental],[Customer] WHERE Rental.CustomerID = Customer.ID and approved = '0'";
            myCommand = new SqlCommand(v, myConnection);
            myReader = myCommand.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (myReader.Read())
            {
                dataGridView1.Rows.Add(myReader["RentalID"].ToString(), myReader["fName"].ToString(), myReader["LName"].ToString(),
                    myReader["Pickup_date"].ToString(), myReader["Return_date"].ToString(), myReader["CarVin"].ToString());


            }
            myReader.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
