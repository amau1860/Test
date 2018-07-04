namespace SMS
{
    partial class frmStudentsDetail_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsAttendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.plStudentsSetting = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1374, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Detail\'s";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 512);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1374, 1);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1374, 1);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.menuStrip1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 711);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentsToolStripMenuItem,
            this.studentsAttendenceToolStripMenuItem,
            this.certificatesToolStripMenuItem,
            this.feesTransactionToolStripMenuItem,
            this.promoteStudentToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 310);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // newStudentsToolStripMenuItem
            // 
            this.newStudentsToolStripMenuItem.AutoSize = false;
            this.newStudentsToolStripMenuItem.Name = "newStudentsToolStripMenuItem";
            this.newStudentsToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.newStudentsToolStripMenuItem.Text = "New Student\'s";
            this.newStudentsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newStudentsToolStripMenuItem.Click += new System.EventHandler(this.newStudentsToolStripMenuItem_Click_1);
            // 
            // studentsAttendenceToolStripMenuItem
            // 
            this.studentsAttendenceToolStripMenuItem.AutoSize = false;
            this.studentsAttendenceToolStripMenuItem.Name = "studentsAttendenceToolStripMenuItem";
            this.studentsAttendenceToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.studentsAttendenceToolStripMenuItem.Text = "Student\'s Attendence";
            this.studentsAttendenceToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentsAttendenceToolStripMenuItem.Click += new System.EventHandler(this.studentsAttendenceToolStripMenuItem_Click);
            // 
            // certificatesToolStripMenuItem
            // 
            this.certificatesToolStripMenuItem.AutoSize = false;
            this.certificatesToolStripMenuItem.Name = "certificatesToolStripMenuItem";
            this.certificatesToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.certificatesToolStripMenuItem.Text = "Certificate\'s";
            this.certificatesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.certificatesToolStripMenuItem.Click += new System.EventHandler(this.certificatesToolStripMenuItem_Click);
            // 
            // feesTransactionToolStripMenuItem
            // 
            this.feesTransactionToolStripMenuItem.AutoSize = false;
            this.feesTransactionToolStripMenuItem.Name = "feesTransactionToolStripMenuItem";
            this.feesTransactionToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.feesTransactionToolStripMenuItem.Text = "Fee\'s Transaction";
            this.feesTransactionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feesTransactionToolStripMenuItem.Click += new System.EventHandler(this.feesTransactionToolStripMenuItem_Click);
            // 
            // promoteStudentToolStripMenuItem
            // 
            this.promoteStudentToolStripMenuItem.AutoSize = false;
            this.promoteStudentToolStripMenuItem.Name = "promoteStudentToolStripMenuItem";
            this.promoteStudentToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.promoteStudentToolStripMenuItem.Text = "Promote Student";
            this.promoteStudentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.promoteStudentToolStripMenuItem.Click += new System.EventHandler(this.promoteStudentToolStripMenuItem_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(200, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 711);
            this.panel6.TabIndex = 4;
            // 
            // plStudentsSetting
            // 
            this.plStudentsSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plStudentsSetting.Location = new System.Drawing.Point(201, 45);
            this.plStudentsSetting.Name = "plStudentsSetting";
            this.plStudentsSetting.Size = new System.Drawing.Size(1173, 711);
            this.plStudentsSetting.TabIndex = 5;
            // 
            // frmStudentsDetail_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1374, 756);
            this.ControlBox = false;
            this.Controls.Add(this.plStudentsSetting);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentsDetail_";
            this.Text = "Student\'s Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudentsDetail__Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel plStudentsSetting;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsAttendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesTransactionToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem promoteStudentToolStripMenuItem;


    }
}