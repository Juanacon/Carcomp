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
    public partial class CustReg : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public CustReg()
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

        private void CustReg_Load(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            String connectionString = "Server = DESKTOP-J27TRJS; Database = cmpt291-proj; Trusted_Connection = yes;";
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand = new SqlCommand("select Vin,make,model,year,color from car", myConnection);
            myReader = myCommand.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (myReader.Read())
            {
                dataGridView1.Rows.Add(myReader["VIN"].ToString(), myReader["Make"].ToString(), myReader["Model"].ToString(),
                    myReader["Year"].ToString(), myReader["Color"].ToString());


            }
            myReader.Close();
        }

        private void Request_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
     new System.Data.SqlClient.SqlConnection("user id=Juanacon;" + // Username
                                  "password=Tails1;" + // Password
                                  "server=localhost;" + // IP for the server
                                                        //"Trusted_Connection=yes;" +
                                  "database= cmpt291-proj; " + // Database to connect to
                                  "connection timeout=30"); // Timeout in seconds */
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyyMMdd";
            dateTimePicker1.CustomFormat = "yyyyMMdd";
            string m = comboBox1.SelectedItem.ToString();
            cmd.CommandText = "insert into Rental values ('" + textBox2.Text +
                             "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + "20010908" + "','" + textBox1.Text + "','" + "12" + "','" + textBox2.Text + "'" +
                             ",'" + textBox3.Text + "','" + textBox4.Text + "','" + m + "','" + "40" + "','" + "0" + "')";
            cmd.Connection = sqlConnection1;
            //MessageBox.Show(dateTimePicker1.Text.ToString(), "Error");

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            custlog cs = new custlog();
            this.Hide();
            cs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime febDate = dateTimePicker2.Value;
            DateTime pickerDate = dateTimePicker1.Value;

            TimeSpan tspan = febDate - pickerDate;

            int differenceInDays = tspan.Days;
            differenceInDays = differenceInDays + 1;
            string differenceAsString = differenceInDays.ToString();
            //MessageBox.Show(differenceAsString.ToString(), "Error");

            if (differenceInDays <= 7)
            {
                string m = comboBox1.SelectedItem.ToString();
                if (m == "Comp")
                {
                    int i = 25 * differenceInDays;
                    MessageBox.Show(i.ToString(), "Price");
                   // MessageBox.Show(differenceInDays.ToString(), "Error");
                }
                else if (m == "CompSuv")
                {
                    int r = 75 * differenceInDays;
                    MessageBox.Show(r.ToString(), "Price");
                    //MessageBox.Show(differenceInDays.ToString(), "Error");
                }
                else if (m == "Eco")
                {
                    int j = 50 * differenceInDays;
                    MessageBox.Show(j.ToString(), "Price");
                   // MessageBox.Show(differenceInDays.ToString(), "Error");


                }
                else if (m == "Full")
                {
                    int c = 100 * differenceInDays;
                    MessageBox.Show(c.ToString(), "Price");
                   // MessageBox.Show(differenceInDays.ToString(), "Error");

                }
                else if (m == "Lux")
                {
                    int b = 100 * differenceInDays;
                    MessageBox.Show(b.ToString(), "Price");
                   // MessageBox.Show(differenceInDays.ToString(), "Error");



                }
                else if (m == "Stand")
                {
                    int s = 75 * differenceInDays;
                    MessageBox.Show(s.ToString(), "Price");
                    //MessageBox.Show(differenceInDays.ToString(), "Error");
                }
                }



                if (differenceInDays > 7 && differenceInDays < 30)
                {
                    string w = comboBox1.SelectedItem.ToString();
                    if (w == "Comp")
                    {
                        int i = 21 * differenceInDays;
                        MessageBox.Show(i.ToString(), "Price");
                        //MessageBox.Show(differenceInDays.ToString(), "Error");
                        if (w == "CompSuv")
                        {
                            int r = 64 * differenceInDays;
                            MessageBox.Show(r.ToString(), "Price");
                           // MessageBox.Show(differenceInDays.ToString(), "Error");
                        }
                        else if (w == "Eco")
                        {
                            int j = 45 * differenceInDays;
                            MessageBox.Show(j.ToString(), "Price");
                           // MessageBox.Show(differenceInDays.ToString(), "Error");


                        }
                        else if (w == "Full")
                        {
                            int c = 94 * differenceInDays;
                            MessageBox.Show(c.ToString(), "Price");
                           // MessageBox.Show(differenceInDays.ToString(), "Error");

                        }
                        else if (w == "Lux")
                        {
                            int b = 94 * differenceInDays;
                            MessageBox.Show(b.ToString(), "Price");
                           // MessageBox.Show(differenceInDays.ToString(), "Error");



                        }
                        else if (w == "Stand")
                        {
                            int s = 64 * differenceInDays;
                            MessageBox.Show(s.ToString(), "Price");
                           // MessageBox.Show(differenceInDays.ToString(), "Error");
                        }
                    }


                    if (differenceInDays >= 30)
                    {
                        string h = comboBox1.SelectedItem.ToString();
                        if (h == "Comp")
                        {
                            int i = 19 * differenceInDays;
                            MessageBox.Show(i.ToString(), "Price");
                           // MessageBox.Show(differenceInDays.ToString(), "Error");
                        }
                        else if (h == "CompSuv")
                        {
                            int r = 56 * differenceInDays;
                            MessageBox.Show(r.ToString(), "Price");
                           // MessageBox.Show(differenceInDays.ToString(), "Error");
                        }
                        else if (h == "Eco")
                        {
                            int j = 41 * differenceInDays;
                            MessageBox.Show(j.ToString(), "Price");
                            //MessageBox.Show(differenceInDays.ToString(), "Error");
                        }


                        else if (h == "Full")
                        {
                            int c = 89 * differenceInDays;
                            MessageBox.Show(c.ToString(), "Price");
                           // MessageBox.Show(differenceInDays.ToString(), "Error");

                        }
                        else if (h == "Lux")
                        {
                            int b = 89 * differenceInDays;
                            MessageBox.Show(b.ToString(), "Price");
                           // MessageBox.Show(differenceInDays.ToString(), "Error");



                        }
                        else if (h == "Stand")
                        {
                            int s = 56 * differenceInDays;
                            MessageBox.Show(s.ToString(), "Price");
                            //MessageBox.Show(differenceInDays.ToString(), "Error");
                        }
                    }
                }
            }

        }
    }



                    
                  
    

