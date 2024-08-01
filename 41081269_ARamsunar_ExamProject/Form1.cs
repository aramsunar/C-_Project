using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41081269_ARamsunar_ExamProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Form2 signForm = new Form2();
            this.Hide();
            signForm.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form3 loginForm = new Form3();
            this.Hide();
            loginForm.Show();
        }
    }
}
