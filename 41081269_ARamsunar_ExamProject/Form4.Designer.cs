
namespace _41081269_ARamsunar_ExamProject
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEventsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventHostingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatingReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountManagementToolStripMenuItem,
            this.viewEventsToolStripMenuItem,
            this.viewEventsToolStripMenuItem1,
            this.eventHostingToolStripMenuItem,
            this.generatingReportsToolStripMenuItem,
            this.requestInvoiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountManagementToolStripMenuItem
            // 
            this.accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            this.accountManagementToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.accountManagementToolStripMenuItem.Text = "Account management ";
            this.accountManagementToolStripMenuItem.Click += new System.EventHandler(this.accountManagementToolStripMenuItem_Click);
            // 
            // viewEventsToolStripMenuItem
            // 
            this.viewEventsToolStripMenuItem.Name = "viewEventsToolStripMenuItem";
            this.viewEventsToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.viewEventsToolStripMenuItem.Text = "Event Registration";
            this.viewEventsToolStripMenuItem.Click += new System.EventHandler(this.viewEventsToolStripMenuItem_Click);
            // 
            // viewEventsToolStripMenuItem1
            // 
            this.viewEventsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventHistoryToolStripMenuItem});
            this.viewEventsToolStripMenuItem1.Name = "viewEventsToolStripMenuItem1";
            this.viewEventsToolStripMenuItem1.Size = new System.Drawing.Size(105, 24);
            this.viewEventsToolStripMenuItem1.Text = "View Events ";
            this.viewEventsToolStripMenuItem1.Click += new System.EventHandler(this.viewEventsToolStripMenuItem1_Click);
            // 
            // eventHistoryToolStripMenuItem
            // 
            this.eventHistoryToolStripMenuItem.Name = "eventHistoryToolStripMenuItem";
            this.eventHistoryToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.eventHistoryToolStripMenuItem.Text = "Event History";
            this.eventHistoryToolStripMenuItem.Click += new System.EventHandler(this.eventHistoryToolStripMenuItem_Click);
            // 
            // eventHostingToolStripMenuItem
            // 
            this.eventHostingToolStripMenuItem.Name = "eventHostingToolStripMenuItem";
            this.eventHostingToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.eventHostingToolStripMenuItem.Text = "Event Hosting ";
            this.eventHostingToolStripMenuItem.Click += new System.EventHandler(this.eventHostingToolStripMenuItem_Click);
            // 
            // generatingReportsToolStripMenuItem
            // 
            this.generatingReportsToolStripMenuItem.Name = "generatingReportsToolStripMenuItem";
            this.generatingReportsToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.generatingReportsToolStripMenuItem.Text = "Generating reports";
            this.generatingReportsToolStripMenuItem.Click += new System.EventHandler(this.generatingReportsToolStripMenuItem_Click);
            // 
            // requestInvoiceToolStripMenuItem
            // 
            this.requestInvoiceToolStripMenuItem.Name = "requestInvoiceToolStripMenuItem";
            this.requestInvoiceToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.requestInvoiceToolStripMenuItem.Text = "Request Invoice";
            this.requestInvoiceToolStripMenuItem.Click += new System.EventHandler(this.requestInvoiceToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(868, 498);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Functionality";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventHostingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatingReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestInvoiceToolStripMenuItem;
    }
}