using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace _41081269_ARamsunar_ExamProject
{
    public partial class Form9 : Form
    {
        SqlConnection connect;//declaring the instances variables of sql statements 
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        //declaring the connection string globally 
        public string connectstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Angelina Ramsunar\OneDrive\Desktop\41081269_ARamsunar_ExamProject\41081269_ARamsunar_ExamProject\Database1.mdf;Integrated Security=True";
        public Form9()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name, des, Edate, time, venue, info;//declaring the variables
           // decimal fees=0m;
            int capacity = Convert.ToInt32(txtCapacity.Text);//converting the text in the textbox to an integer
            int fees = Convert.ToInt32(txtFees.Text);
            name = txtEName.Text;//puting the text boxes into variables 
            des = txtDes.Text;
            Edate = DateTime.ParseExact(txtDate.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            time =DateTime.ParseExact(txtTime.Text, "HH:mm", CultureInfo.InvariantCulture).ToString("HH:mm");
            venue = txtVenue.Text;
            info = txtInfo.Text;

            try
            {   
                //the sql statement for inserting the event details 
                string sql = $"INSERT INTO Events VALUES('{name}','{des}','{Edate}','{time}','{venue}',{capacity},'{info}',{fees})";//the insert statement to isert data in the database
                connect = new SqlConnection(connectstring);//connecting to the database
                connect.Open();//opening the connection
                adapter = new SqlDataAdapter();
                command = new SqlCommand(sql, connect);
                adapter.InsertCommand = command;//insert command
                adapter.InsertCommand.ExecuteNonQuery();//does not  return
                UpdateGrid();
                connect.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show("Error" + er.ToString());
            }

            txtCapacity.Text = "";//clearing all the text boxes so that other details can be added after 
            txtDate.Text = "";
            txtDes.Text = "";
            txtEName.Text = "";
            txtFees.Text = "";
            txtInfo.Text = "";
            txtTime.Text = "";
            txtVenue.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtDeleteName.Text;//puting the text boxes into variables 

            try
            {
                if (connect.State == ConnectionState.Closed)//check if the conection is closed, if it is open the connection
                {
                    connect.Open();
                }
                string sql = "DELETE Events WHERE Event_Name= '" + name + "'";//sql statement for deleting a event 
                command = new SqlCommand(sql, connect);
                adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command;//the delete command
                adapter.DeleteCommand.ExecuteNonQuery();

               // UpdateGrid();

                connect.Close();
            
            }
            catch (Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());
            }
            UpdateGrid();
            connect.Close();

            txtDeleteName.Text = "";//clearing the text boxes after the event is deleted 
        }
        private void UpdateGrid()
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
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            try
            { 
                UpdateGrid();//calling the method that is populating the datagrid 
                connect.Close();//closing the connection 
            }
            catch(Exception er)
            {
                MessageBox.Show("Error \t" + er.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name, des, Edate, time, venue, info; // declaring the variables
            int capacity, fees;
            name = des = Edate = time = venue = info = string.Empty; // initialize variables

           
            try
            {
                capacity = Convert.ToInt32(txtCapacity.Text);//converting the text in the textbox to an integer
                fees = Convert.ToInt32(txtFees.Text);
                name = txtEName.Text;//puting the text boxes into variables 
                des = txtDes.Text;
                Edate = DateTime.ParseExact(txtDate.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                time = DateTime.ParseExact(txtTime.Text, "HH:mm", CultureInfo.InvariantCulture).ToString("HH:mm");
                venue = txtVenue.Text;
                info = txtInfo.Text;

                using (SqlConnection connect = new SqlConnection(connectstring))
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                    }

                    // the SQL statement to update all the event details
                    string sql = "UPDATE Events SET Description = @Value1, Date = @Value2, Time = @Value3, Venue = @Value4, Capacity = @Value5, Additional_Information = @Value6, Fees = @Value7 WHERE Event_Name = @Name";
                    using (SqlCommand command = new SqlCommand(sql, connect))
                    {
                        command.Parameters.AddWithValue("@Value1", des);
                        command.Parameters.AddWithValue("@Value2", Edate);
                        command.Parameters.AddWithValue("@Value3", time);
                        command.Parameters.AddWithValue("@Value4", venue);
                        command.Parameters.AddWithValue("@Value5", capacity);
                        command.Parameters.AddWithValue("@Value6", info);
                        command.Parameters.AddWithValue("@Value7", fees);
                        command.Parameters.AddWithValue("@Name", name);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("Update successful!");
                            UpdateGrid(); // Update your grid or perform any other necessary actions
                            connect.Close();
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated.");
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.ToString());
            }

            txtCapacity.Text = "";//clearing all the text boxes so that other details can be added after 
            txtDate.Text = "";
            txtDes.Text = "";
            txtEName.Text = "";
            txtFees.Text = "";
            txtInfo.Text = "";
            txtTime.Text = "";
            txtVenue.Text = "";
        }
    }
}
