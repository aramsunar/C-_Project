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
    public partial class Form6 : Form
    {
        SqlConnection connect;//the instance of variables are declared for the sql statements 
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        //the connection string sis declared globally 
        public string connectstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angelina Ramsunar\OneDrive\Desktop\41081269_ARamsunar_ExamProject\41081269_ARamsunar_ExamProject\Database1.mdf;Integrated Security=True";
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;// the datatime class get the current date and time 
            try 
            {
                connect = new SqlConnection(connectstring);//connecting the database to the form 

                connect.Open();//opening the connection
                adapter = new SqlDataAdapter();//declaring dataAdapter
                string sql = "SELECT Event_Name,Description,Date,Time,Venue,Capacity,Additional_Information,Fees FROM Events Where Date>='"+currentDate+"'";//select all the data from the database
                command = new SqlCommand(sql, connect);
                adapter.SelectCommand = command;//excuting the command 

                DataSet ds = new DataSet();//declaring an dataset
                adapter.Fill(ds, "Events");//storing the command in the dataset
                dataGridView1.DataSource = ds;//displaying the data in the datagrid 
                dataGridView1.DataMember = "Events";

                connect.Close();//closing the connection 

            }
            catch(Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());//Error message will show if the error.
            }

        }
    }
}
