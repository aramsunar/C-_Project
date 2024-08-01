using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _41081269_ARamsunar_ExamProject
{
    public partial class Form11 : Form
    {
        SqlConnection connect;//the instance of variables are declared for the sql statements 
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        //the connection string sis declared globally 
        public string connectstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angelina Ramsunar\OneDrive\Desktop\41081269_ARamsunar_ExamProject\41081269_ARamsunar_ExamProject\Database1.mdf;Integrated Security=True";
        public Form11()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, email;
            name = txtName.Text;
            email = txtEmailAddress.Text;

            try
            {
                // SQL query to retrieve the user with the provided ID and password
                string query = "SELECT COUNT(*) FROM Registration WHERE Name= @name AND Email_Address = @email";

                using (SqlConnection connect = new SqlConnection(connectstring))
                {
                    connect.Open();

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@email", email);

                        // Execute the query
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            try
                            {
                                if (connect.State == ConnectionState.Closed)//checks if the connection is closed
                                {
                                    connect.Open();
                                }
                                string sql2 = "SELECT * FROM Registration WHERE Name='" + name + "'" ;
                                SqlCommand comm = new SqlCommand(sql2, connect);
                                reader = comm.ExecuteReader();
                                listBox1.Items.Clear();
                                while (reader.Read()) //Read a record based on the SQL statement above, do the commands below, read the next record while there is another record to read!
                                {
                                    string output = reader.GetValue(0) + " \t " + reader.GetValue(1) + " \t " +reader.GetValue(2) + " \t 0" +Convert.ToInt32(reader.GetValue(3))+ " \t " + reader.GetValue(4)+ " \t " + reader.GetValue(5)+ " \t " + reader.GetValue(6);
                                    //adding the data to the listBox;
                                    listBox1.Items.Add("EventConnect Invoice");
                                    listBox1.Items.Add("\nThese are the details of the Event you registered for:");
                                    listBox1.Items.Add(" ");
                                    listBox1.Items.Add("\nID \t Name \t Surname\t Cellphone Number \t Email address \t Membership \t EventName");
                                    listBox1.Items.Add(output);
                                    listBox1.Items.Add(" ");
                                    listBox1.Items.Add("Fee that needs to be paid for this event: ");
                                    //listBox1.Items.Add("");

                                }

                                //Closing the connection to the database
                                connect.Close();

                            }
                            catch (Exception er)
                            {
                                MessageBox.Show(er.ToString());
                            }
                        }
                        else
                        {
                            // Registration does not exist 
                            listBox1.Items.Add("There is no invoice for you.");
                            listBox1.Items.Add("You did not make any registrations for an event.");
                        }
                    }
                    //Closing the connection to the database
                    connect.Close();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }
       
    }
  
}


