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
    public partial class Form2 : Form
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        public string connectstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angelina Ramsunar\OneDrive\Desktop\41081269_ARamsunar_ExamProject\41081269_ARamsunar_ExamProject\Database1.mdf;Integrated Security=True";
        Form1 welcome = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string name, surname, password, membership,email;
            int cell;
            name = txtName.Text;
            surname = txtSurname.Text;
            password = txtPassword.Text;
            membership = txtMemberShip.Text;
            email = txtEmail.Text;
            cell = Convert.ToInt32(txtCell.Text);

            try
            {
                string sql = $"INSERT INTO Users VALUES('{name}','{surname}','{password}','{email}',{cell},'{membership}')";//the insert statement to isert data in the database
                connect = new SqlConnection(connectstring);
                connect.Open();
                adapter = new SqlDataAdapter();
                command = new SqlCommand(sql, connect);
                adapter.InsertCommand = command;//insert command
                adapter.InsertCommand.ExecuteNonQuery();//does not  return 
                connect.Close();
                MessageBox.Show("You have successfully signed in and logged in.");//tells the user that the data is succesfully added
                this.Hide();
                                                          
                Form4 function = new Form4();
                function.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error"+er.ToString());
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            welcome.Hide();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
