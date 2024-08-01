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
    public partial class Form4 : Form
    {
        Form6 upcoming = new Form6();//creating a instance of the form so that it can be shown in the mdi container 
        Form5 account = new Form5();//creating a instance of the form so that it can be shown in the mdi container
        Form7 history = new Form7();//creating a instance of the form so that it can be shown in the mdi container
        Form8 register = new Form8();
        Form9 hosting = new Form9();
        Form10 reports = new Form10();
        Form11 invoice = new Form11();
        public Form4()
        {
            InitializeComponent();
        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history.Hide();//hiding the other forms when another one is clicked and entered
            upcoming.Hide();//hiding the other forms when another one is clicked and entered
            register.Hide();
            reports.Hide();
            invoice.Hide();
            account.MdiParent = this;
            account.Show();//showing the form in the mdi container


        }

        private void viewEventsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            history.Hide();//hiding the other forms when another one is clicked and entered
            account.Hide();//hiding the other forms when another one is clicked and entered
            register.Hide();
            reports.Hide();
            invoice.Hide();
            upcoming.MdiParent = this;
            upcoming.Show();//showing the form in the mdi container
        }

        private void eventHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upcoming.Hide();//hiding the other forms when another one is clicked and entered
            account.Hide();//hiding the other forms when another one is clicked and entered
            register.Hide();
            reports.Hide();
            invoice.Hide();
            history.MdiParent = this;
            history.Show();//showing the form in the mdi container
        }

        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upcoming.Hide();//hiding the other forms when another one is clicked and entered
            account.Hide();//hiding the other forms when another one is clicked and entered
            history.Hide();
            reports.Hide();
            invoice.Hide();
            register.MdiParent = this;
            register.Show();

        }

        private void eventHostingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upcoming.Hide();//hiding the other forms when another one is clicked and entered
            account.Hide();//hiding the other forms when another one is clicked and entered
            history.Hide();
            reports.Hide();
            invoice.Hide();
            hosting.MdiParent = this;
            hosting.Show();
        }

        private void generatingReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upcoming.Hide();//hiding the other forms when another one is clicked and entered
            account.Hide();//hiding the other forms when another one is clicked and entered
            history.Hide();
            hosting.Hide();
            invoice.Hide();
            reports.MdiParent = this;
            reports.Show();
        }

        private void requestInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upcoming.Hide();//hiding the other forms when another one is clicked and entered
            account.Hide();//hiding the other forms when another one is clicked and entered
            history.Hide();
            hosting.Hide();
            reports.Hide();
            invoice.MdiParent = this;
            invoice.Show();

        }
    }
}
