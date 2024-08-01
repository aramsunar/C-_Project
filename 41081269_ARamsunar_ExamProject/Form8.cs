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
    public partial class Form8 : Form
    {
        SqlConnection connect;//declaring the instances variables of sql statements 
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        //declaring the connection string globally 
        public string connectstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angelina Ramsunar\OneDrive\Desktop\41081269_ARamsunar_ExamProject\41081269_ARamsunar_ExamProject\Database1.mdf;Integrated Security=True";
        public Form8()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name, surname, membership, email,events;//decalring variables 
            int cell;
            name = txtName.Text;//storing the text into the variables 
            surname = txtSurname.Text;
            membership = txtMember.Text;
            events = txtEvent.Text;
            email = txtEmail.Text;
            cell = Convert.ToInt32(txtCell.Text);

            try
            {   
                //insert the information of the user for the regisartion 
                string sql = $"INSERT INTO Registration VALUES('{name}','{surname}',{cell},'{email}','{membership}','{events}')";//the insert statement to isert data in the database
                connect = new SqlConnection(connectstring);
                connect.Open();
                adapter = new SqlDataAdapter();
                command = new SqlCommand(sql, connect);
                adapter.InsertCommand = command;//insert command
                adapter.InsertCommand.ExecuteNonQuery();//does not  return 
                connect.Close();
                MessageBox.Show("You have successfully registered. We will send you notifications via email.");//tells the user that the data is succesfully added
              
            }
            catch (Exception er)
            {
                MessageBox.Show("Error" + er.ToString());
            }
            txtCell.Text = "";//clearing the text boxes after 
            txtEmail.Text = "";
            txtEvent.Text = "";
            txtMember.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
;               


        }
    }
}
