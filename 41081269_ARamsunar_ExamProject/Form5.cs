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
    public partial class Form5 : Form
    {
        SqlConnection connect;// declaring variables for the sql statements
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public string connectstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angelina Ramsunar\OneDrive\Desktop\41081269_ARamsunar_ExamProject\41081269_ARamsunar_ExamProject\Database1.mdf;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            string emailAdress = txtEmailAdd.Text;//storing the texts in the variables
            string password = txtNewPass.Text;
            try
            {
                connect = new SqlConnection(connectstring);//conecting to the database
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                string sql = "UPDATE Users SET Password = '" + password+ "' WHERE Email_Address = '" + emailAdress + "'";
                command = new SqlCommand(sql, connect);
                adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;//the update command to be excuted 
                adapter.UpdateCommand.ExecuteNonQuery(); 
                connect.Close();
                MessageBox.Show("The password has been changed");//notify the user 
            }
            catch (Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());
            }
            txtEmailAdd.Text = "";//clearing texts
            txtNewPass.Text = "";

        }

        private void btnChangeCell_Click(object sender, EventArgs e)
        {
            string password = txtPassCell.Text;//Storing the text in variables so it is easier
            int cell = Convert.ToInt32(txtCell.Text);

            try
            {
                connect = new SqlConnection(connectstring);
                if (connect.State == ConnectionState.Closed)//checks if the connection is closed
                {
                    connect.Open();
                }
                string sql = "UPDATE Users SET Cellphone_Number = '" + cell + "' WHERE Password = '" + password + "'";
                command = new SqlCommand(sql, connect);
                adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("The cellphone number has been changed");//if sucessfully it notifies the user
            }
            catch(Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());//error message
            }
            txtPassCell.Text = "";//clearing texts
            txtCell.Text = "";

        }

        private void btnChangePremium_Click(object sender, EventArgs e)
        {
            string password = txtPassPremium.Text;//storing the text in variables 
            string premium = txtPremium.Text;

            try
            {
                connect = new SqlConnection(connectstring);//connect to database
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();//connection is opened 
                }
                //sql statement for an update for the membership
                string sql = "UPDATE Users SET Membership = '" + premium + "' WHERE Password = '" + password + "'";
                command = new SqlCommand(sql, connect);
                adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                connect.Close();//close connection 
                MessageBox.Show("The Membership has been changed to premium");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());
            }
            txtPassPremium.Text = "";//clearing text so the user can enter again if pleased 
            txtPremium.Text = "";
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            string password = txtPassEmail.Text;//declaring and initialising the variables 
            string email = txtEmail.Text;

            try
            {
                connect = new SqlConnection(connectstring);
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                //updating the email address
                string sql = "UPDATE Users SET Email_Address = '" + email + "' WHERE Password = '" + password + "'";
                command = new SqlCommand(sql, connect);
                adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("The Email address has been changed");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());
            }
            txtEmail.Text = "";//clearing the texts 
            txtPassEmail.Text = "";

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPassCell_TextChanged(object sender, EventArgs e)
        {
            txtPassCell.Focus();
        }
    }
}
