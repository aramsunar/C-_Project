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
    public partial class Form3 : Form
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public string connectstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angelina Ramsunar\OneDrive\Desktop\41081269_ARamsunar_ExamProject\41081269_ARamsunar_ExamProject\Database1.mdf;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LoginName, LoginPassWord;
            LoginName = txtLoginName.Text;
            LoginPassWord = txtLoginPassword.Text;
            try
            { 
                // SQL query to retrieve the user with the provided ID and password
                string query = "SELECT COUNT(*) FROM Users WHERE Name= @LoginName AND Password = @LoginPassword";

                using (SqlConnection connect = new SqlConnection(connectstring))
                {
                    connect.Open();

                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@LoginName", LoginName);
                        command.Parameters.AddWithValue("@LoginPassword", LoginPassWord);

                        // Execute the query
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            // User exists and password is correct
                            Form4 function = new Form4();
                            this.Hide();
                            function.Show();
                        }
                        else
                        {
                            // User does not exist or password is incorrect
                            MessageBox.Show("Incorrect name and password as been entered");// Handle the error or display a message to the user
                        }
                    }
                    //Closing the connection to the database
                    connect.Close();
                }

               
            }
            catch (Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());
            }
        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {
            txtLoginPassword.PasswordChar = '*';
        }
    }
}
