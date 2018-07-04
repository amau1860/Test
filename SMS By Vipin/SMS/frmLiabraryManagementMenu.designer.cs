namespace SMS
{
    partial class frmLiabraryManagementMenu
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddPublicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plLibraryManagement = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1164, 43);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(3, 42);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 512);
            this.panel8.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 698);
            this.panel2.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPublicationToolStripMenuItem,
            this.AddBookDetailsToolStripMenuItem,
            this.IssueBookToolStripMenuItem,
            this.ReturnBookToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 698);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddPublicationToolStripMenuItem
            // 
            this.AddPublicationToolStripMenuItem.AutoSize = false;
            this.AddPublicationToolStripMenuItem.Name = "AddPublicationToolStripMenuItem";
            this.AddPublicationToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.AddPublicationToolStripMenuItem.Text = "Add Publication";
            this.AddPublicationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPublicationToolStripMenuItem.Click += new System.EventHandler(this.AddPublicationToolStripMenuItem_Click_1);
            // 
            // AddBookDetailsToolStripMenuItem
            // 
            this.AddBookDetailsToolStripMenuItem.AutoSize = false;
            this.AddBookDetailsToolStripMenuItem.Name = "AddBookDetailsToolStripMenuItem";
            this.AddBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.AddBookDetailsToolStripMenuItem.Text = "Add Book Detail\'s";
            this.AddBookDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.AddBookDetailsToolStripMenuItem_Click);
            // 
            // IssueBookToolStripMenuItem
            // 
            this.IssueBookToolStripMenuItem.AutoSize = false;
            this.IssueBookToolStripMenuItem.Name = "IssueBookToolStripMenuItem";
            this.IssueBookToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.IssueBookToolStripMenuItem.Text = "Issue Book";
            this.IssueBookToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IssueBookToolStripMenuItem.Click += new System.EventHandler(this.IssueBookToolStripMenuItem_Click);
            // 
            // ReturnBookToolStripMenuItem
            // 
            this.ReturnBookToolStripMenuItem.AutoSize = false;
            this.ReturnBookToolStripMenuItem.Name = "ReturnBookToolStripMenuItem";
            this.ReturnBookToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.ReturnBookToolStripMenuItem.Text = "Return Book";
            this.ReturnBookToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnBookToolStripMenuItem.Click += new System.EventHandler(this.ReturnBookToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(200, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 698);
            this.panel3.TabIndex = 7;
            // 
            // plLibraryManagement
            // 
            this.plLibraryManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plLibraryManagement.Location = new System.Drawing.Point(201, 44);
            this.plLibraryManagement.Name = "plLibraryManagement";
            this.plLibraryManagement.Size = new System.Drawing.Size(963, 698);
            this.plLibraryManagement.TabIndex = 8;
            // 
            // frmLiabraryManagementMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 742);
            this.ControlBox = false;
            this.Controls.Add(this.plLibraryManagement);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLiabraryManagementMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel plLibraryManagement;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddPublicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReturnBookToolStripMenuItem;
    }
}