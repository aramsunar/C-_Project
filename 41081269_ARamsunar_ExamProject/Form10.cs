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
    public partial class Form10 : Form
    {
        SqlConnection connect;//declaring the instances variables of sql statements 
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        //declaring the connection string globally 
        public string connectstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angelina Ramsunar\OneDrive\Desktop\41081269_ARamsunar_ExamProject\41081269_ARamsunar_ExamProject\Database1.mdf;Integrated Security=True";
        public Form10()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text;
            try
            {
                connect = new SqlConnection(connectstring);//connecting to the database
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }//open the connection
                 //the sql atatement for selects the columns 
                string sql = "SELECT Event_Name,Description,Date,Time,Venue,Capacity,Additional_Information,Fees FROM Events WHERE Event_Name LIKE'%"+name+"%'";
                command = new SqlCommand(sql, connect);//excute the command
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet ds = new DataSet();
                adapter.Fill(ds, "events");
                dataGridView1.DataMember = "events";//disaplying it in the datagrid 
                dataGridView1.DataSource = ds;
                connect.Close();
            }
            catch(Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
           

            try
            {
                connect = new SqlConnection(connectstring);//connecting to the database
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }//open the connection
                 //the sql atatement for selects the columns 
                string sql = "SELECT Event_Name,Description,Date,Time,Venue,Capacity,Additional_Information,Fees FROM Events";
                command = new SqlCommand(sql, connect);//excute the command
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet ds = new DataSet();
                adapter.Fill(ds, "events");
                dataGridView1.DataMember = "events";//disaplying it in the datagrid 
                dataGridView1.DataSource = ds;
                connect.Close();

                populate();


            }
            catch(Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());
            }

           

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           

        }

        private void lblScroll_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                connect = new SqlConnection(connectstring);//connecting to the database
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }//open the connection
                 //the sql atatement for selects the columns 
                string sql = "SELECT Event_Name,Description,Date,Time,Venue,Capacity,Additional_Information,Fees FROM Events WHERE Venue='" + comboBox1.SelectedValue + "'";
                command = new SqlCommand(sql, connect);//excute the command
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet ds = new DataSet();
                adapter.Fill(ds,"Events");
                dataGridView1.DataMember = "Events";//disaplying it in the datagrid 
                dataGridView1.DataSource = ds;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());
            }

        }

        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            
        }

        private void populate()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            string sql2 = @"SELECT DISTINCT Venue FROM Events";//Only select the surnames
            command = new SqlCommand(sql2, connect);
            DataSet ds1 = new DataSet();//delaring the dataset
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(ds1, "Events");//a
            comboBox1.DisplayMember = "Venue"; //Field to be displayed
            comboBox1.ValueMember = "Venue"; //Value to be returned
            comboBox1.DataSource = ds1.Tables["Events"];
            connect.Close();
        }
    }
}
