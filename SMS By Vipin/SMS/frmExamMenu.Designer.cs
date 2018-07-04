namespace SMS
{
    partial class frmExamMenu
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ExamType = new System.Windows.Forms.ToolStripMenuItem();
            this.ExamTimeTable = new System.Windows.Forms.ToolStripMenuItem();
            this.Result = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.plExamMenu = new System.Windows.Forms.Panel();
            this.panel8.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.menuStrip2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 44);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 705);
            this.panel8.TabIndex = 1;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowMerge = false;
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExamType,
            this.ExamTimeTable,
            this.Result});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(198, 703);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ExamType
            // 
            this.ExamType.AutoSize = false;
            this.ExamType.Name = "ExamType";
            this.ExamType.Size = new System.Drawing.Size(193, 35);
            this.ExamType.Text = "ExamType";
            this.ExamType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExamType.Click += new System.EventHandler(this.ExamType_Click);
            // 
            // ExamTimeTable
            // 
            this.ExamTimeTable.AutoSize = false;
            this.ExamTimeTable.Name = "ExamTimeTable";
            this.ExamTimeTable.Size = new System.Drawing.Size(193, 35);
            this.ExamTimeTable.Text = "Exam Time Table";
            this.ExamTimeTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExamTimeTable.Click += new System.EventHandler(this.ExamTimeTable_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = false;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(193, 22);
            this.Result.Text = "Result";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 1);
            this.panel1.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1370, 43);
            this.panel7.TabIndex = 13;
            // 
            // plExamMenu
            // 
            this.plExamMenu.BackColor = System.Drawing.Color.White;
            this.plExamMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plExamMenu.Location = new System.Drawing.Point(200, 44);
            this.plExamMenu.Name = "plExamMenu";
            this.plExamMenu.Size = new System.Drawing.Size(1170, 705);
            this.plExamMenu.TabIndex = 15;
            // 
            // frmExamMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.plExamMenu);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExamMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmExamMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel8.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ExamTimeTable;
        private System.Windows.Forms.ToolStripMenuItem Result;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStripMenuItem ExamType;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel plExamMenu;
    }
}