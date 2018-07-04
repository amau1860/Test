namespace SMS
{
    partial class frmStockManagementMenu
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
            this.plStockManagement = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.DealerRegi = new System.Windows.Forms.ToolStripMenuItem();
            this.staffRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocktype = new System.Windows.Forms.ToolStripMenuItem();
            this.stockin = new System.Windows.Forms.ToolStripMenuItem();
            this.StockOut = new System.Windows.Forms.ToolStripMenuItem();
            this.stockreturn = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.plStockManagement.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // plStockManagement
            // 
            this.plStockManagement.BackColor = System.Drawing.Color.White;
            this.plStockManagement.Controls.Add(this.panel3);
            this.plStockManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plStockManagement.Location = new System.Drawing.Point(201, 44);
            this.plStockManagement.Name = "plStockManagement";
            this.plStockManagement.Size = new System.Drawing.Size(1169, 665);
            this.plStockManagement.TabIndex = 12;
            this.plStockManagement.Paint += new System.Windows.Forms.PaintEventHandler(this.plStockManagement_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 665);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.menuStrip2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(1, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 665);
            this.panel5.TabIndex = 10;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AllowMerge = false;
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.White;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DealerRegi,
            this.staffRegistrationToolStripMenuItem,
            this.productSetting,
            this.departmentSettingToolStripMenuItem,
            this.stocktype,
            this.stockin,
            this.StockOut,
            this.stockreturn});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(200, 663);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // DealerRegi
            // 
            this.DealerRegi.AutoSize = false;
            this.DealerRegi.Name = "DealerRegi";
            this.DealerRegi.Size = new System.Drawing.Size(193, 35);
            this.DealerRegi.Text = "Dealer Registration";
            this.DealerRegi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DealerRegi.Click += new System.EventHandler(this.DealerRegi_Click);
            // 
            // staffRegistrationToolStripMenuItem
            // 
            this.staffRegistrationToolStripMenuItem.AutoSize = false;
            this.staffRegistrationToolStripMenuItem.Name = "staffRegistrationToolStripMenuItem";
            this.staffRegistrationToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.staffRegistrationToolStripMenuItem.Text = "Staff Registration";
            this.staffRegistrationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffRegistrationToolStripMenuItem.Click += new System.EventHandler(this.staffRegistrationToolStripMenuItem_Click);
            // 
            // productSetting
            // 
            this.productSetting.AutoSize = false;
            this.productSetting.Name = "productSetting";
            this.productSetting.Size = new System.Drawing.Size(193, 35);
            this.productSetting.Text = "Stock  Name Setting";
            this.productSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productSetting.Click += new System.EventHandler(this.productSetting_Click);
            // 
            // departmentSettingToolStripMenuItem
            // 
            this.departmentSettingToolStripMenuItem.AutoSize = false;
            this.departmentSettingToolStripMenuItem.Name = "departmentSettingToolStripMenuItem";
            this.departmentSettingToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.departmentSettingToolStripMenuItem.Text = "Department Setting";
            this.departmentSettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.departmentSettingToolStripMenuItem.Click += new System.EventHandler(this.departmentSettingToolStripMenuItem_Click);
            // 
            // stocktype
            // 
            this.stocktype.AutoSize = false;
            this.stocktype.Name = "stocktype";
            this.stocktype.Size = new System.Drawing.Size(193, 35);
            this.stocktype.Text = "Stock Type";
            this.stocktype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stocktype.Click += new System.EventHandler(this.stocktype_Click);
            // 
            // stockin
            // 
            this.stockin.AutoSize = false;
            this.stockin.Name = "stockin";
            this.stockin.Size = new System.Drawing.Size(193, 35);
            this.stockin.Text = "Stock In";
            this.stockin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockin.Click += new System.EventHandler(this.stockin_Click);
            // 
            // StockOut
            // 
            this.StockOut.AutoSize = false;
            this.StockOut.Name = "StockOut";
            this.StockOut.Size = new System.Drawing.Size(193, 35);
            this.StockOut.Text = "Stock Out";
            this.StockOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StockOut.Click += new System.EventHandler(this.StockOut_Click);
            // 
            // stockreturn
            // 
            this.stockreturn.AutoSize = false;
            this.stockreturn.Name = "stockreturn";
            this.stockreturn.Size = new System.Drawing.Size(193, 35);
            this.stockreturn.Text = "Stock Return";
            this.stockreturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockreturn.Click += new System.EventHandler(this.stockreturn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 665);
            this.panel2.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 43);
            this.panel8.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1370, 43);
            this.panel7.TabIndex = 8;
            // 
            // frmStockManagementMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.ControlBox = false;
            this.Controls.Add(this.plStockManagement);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockManagementMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Management Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStockManagementMenu_Load);
            this.plStockManagement.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plStockManagement;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem DealerRegi;
        private System.Windows.Forms.ToolStripMenuItem staffRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productSetting;
        private System.Windows.Forms.ToolStripMenuItem departmentSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocktype;
        private System.Windows.Forms.ToolStripMenuItem stockin;
        private System.Windows.Forms.ToolStripMenuItem StockOut;
        private System.Windows.Forms.ToolStripMenuItem stockreturn;
        private System.Windows.Forms.Panel panel3;


    }
}