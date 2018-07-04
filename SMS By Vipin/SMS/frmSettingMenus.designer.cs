namespace SMS
{
    partial class frmSettingMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingMenus));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.schoolSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentTypeSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorySettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casteSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countrySettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citySettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motherToungeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.plSettingsMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.religionSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 550);
            this.panel3.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolSettingToolStripMenuItem,
            this.classSettingToolStripMenuItem,
            this.categorySettingToolStripMenuItem,
            this.casteSettingToolStripMenuItem,
            this.documentsSettingToolStripMenuItem,
            this.countrySettingToolStripMenuItem,
            this.stateSettingToolStripMenuItem,
            this.citySettingToolStripMenuItem,
            this.motherToungeToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(199, 550);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // schoolSettingToolStripMenuItem
            // 
            this.schoolSettingToolStripMenuItem.AutoSize = false;
            this.schoolSettingToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.schoolSettingToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schoolSettingToolStripMenuItem.Image")));
            this.schoolSettingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.schoolSettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schoolSettingToolStripMenuItem.Name = "schoolSettingToolStripMenuItem";
            this.schoolSettingToolStripMenuItem.Size = new System.Drawing.Size(192, 35);
            this.schoolSettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.schoolSettingToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.schoolSettingToolStripMenuItem.Click += new System.EventHandler(this.schoolSettingToolStripMenuItem_Click);
            // 
            // classSettingToolStripMenuItem
            // 
            this.classSettingToolStripMenuItem.AutoSize = false;
            this.classSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createClassToolStripMenuItem,
            this.studentTypeSettingToolStripMenuItem,
            this.setClassToolStripMenuItem,
            this.subjectMasterToolStripMenuItem,
            this.assignSubjectsToolStripMenuItem});
            this.classSettingToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("classSettingToolStripMenuItem.Image")));
            this.classSettingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.classSettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.classSettingToolStripMenuItem.Name = "classSettingToolStripMenuItem";
            this.classSettingToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.classSettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classSettingToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // createClassToolStripMenuItem
            // 
            this.createClassToolStripMenuItem.Name = "createClassToolStripMenuItem";
            this.createClassToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.createClassToolStripMenuItem.Text = "Create Class";
            this.createClassToolStripMenuItem.Click += new System.EventHandler(this.createClassToolStripMenuItem_Click);
            // 
            // studentTypeSettingToolStripMenuItem
            // 
            this.studentTypeSettingToolStripMenuItem.Name = "studentTypeSettingToolStripMenuItem";
            this.studentTypeSettingToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.studentTypeSettingToolStripMenuItem.Text = "Student Type Setting";
            this.studentTypeSettingToolStripMenuItem.Click += new System.EventHandler(this.studentTypeSettingToolStripMenuItem_Click);
            // 
            // setClassToolStripMenuItem
            // 
            this.setClassToolStripMenuItem.Name = "setClassToolStripMenuItem";
            this.setClassToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.setClassToolStripMenuItem.Text = "Set Class Fee\'s";
            this.setClassToolStripMenuItem.Click += new System.EventHandler(this.setClassToolStripMenuItem_Click);
            // 
            // subjectMasterToolStripMenuItem
            // 
            this.subjectMasterToolStripMenuItem.Name = "subjectMasterToolStripMenuItem";
            this.subjectMasterToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.subjectMasterToolStripMenuItem.Text = "Subject Master";
            this.subjectMasterToolStripMenuItem.Click += new System.EventHandler(this.subjectMasterToolStripMenuItem_Click);
            // 
            // assignSubjectsToolStripMenuItem
            // 
            this.assignSubjectsToolStripMenuItem.Name = "assignSubjectsToolStripMenuItem";
            this.assignSubjectsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.assignSubjectsToolStripMenuItem.Text = "Assign Subject\'s";
            this.assignSubjectsToolStripMenuItem.Click += new System.EventHandler(this.assignSubjectsToolStripMenuItem_Click);
            // 
            // categorySettingToolStripMenuItem
            // 
            this.categorySettingToolStripMenuItem.AutoSize = false;
            this.categorySettingToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F);
            this.categorySettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categorySettingToolStripMenuItem.Image")));
            this.categorySettingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.categorySettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.categorySettingToolStripMenuItem.Name = "categorySettingToolStripMenuItem";
            this.categorySettingToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.categorySettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorySettingToolStripMenuItem.Click += new System.EventHandler(this.categorySettingToolStripMenuItem_Click);
            // 
            // casteSettingToolStripMenuItem
            // 
            this.casteSettingToolStripMenuItem.AutoSize = false;
            this.casteSettingToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F);
            this.casteSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("casteSettingToolStripMenuItem.Image")));
            this.casteSettingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.casteSettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.casteSettingToolStripMenuItem.Name = "casteSettingToolStripMenuItem";
            this.casteSettingToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.casteSettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.casteSettingToolStripMenuItem.Click += new System.EventHandler(this.casteSettingToolStripMenuItem_Click);
            // 
            // documentsSettingToolStripMenuItem
            // 
            this.documentsSettingToolStripMenuItem.AutoSize = false;
            this.documentsSettingToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F);
            this.documentsSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("documentsSettingToolStripMenuItem.Image")));
            this.documentsSettingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.documentsSettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.documentsSettingToolStripMenuItem.Name = "documentsSettingToolStripMenuItem";
            this.documentsSettingToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.documentsSettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.documentsSettingToolStripMenuItem.Click += new System.EventHandler(this.documentsSettingToolStripMenuItem_Click);
            // 
            // countrySettingToolStripMenuItem
            // 
            this.countrySettingToolStripMenuItem.AutoSize = false;
            this.countrySettingToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F);
            this.countrySettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("countrySettingToolStripMenuItem.Image")));
            this.countrySettingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.countrySettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.countrySettingToolStripMenuItem.Name = "countrySettingToolStripMenuItem";
            this.countrySettingToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.countrySettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.countrySettingToolStripMenuItem.Click += new System.EventHandler(this.countrySettingToolStripMenuItem_Click);
            // 
            // stateSettingToolStripMenuItem
            // 
            this.stateSettingToolStripMenuItem.AutoSize = false;
            this.stateSettingToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F);
            this.stateSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stateSettingToolStripMenuItem.Image")));
            this.stateSettingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stateSettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stateSettingToolStripMenuItem.Name = "stateSettingToolStripMenuItem";
            this.stateSettingToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.stateSettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stateSettingToolStripMenuItem.Click += new System.EventHandler(this.stateSettingToolStripMenuItem_Click);
            // 
            // citySettingToolStripMenuItem
            // 
            this.citySettingToolStripMenuItem.AutoSize = false;
            this.citySettingToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F);
            this.citySettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("citySettingToolStripMenuItem.Image")));
            this.citySettingToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.citySettingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.citySettingToolStripMenuItem.Name = "citySettingToolStripMenuItem";
            this.citySettingToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.citySettingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.citySettingToolStripMenuItem.Click += new System.EventHandler(this.citySettingToolStripMenuItem_Click);
            // 
            // motherToungeToolStripMenuItem
            // 
            this.motherToungeToolStripMenuItem.AutoSize = false;
            this.motherToungeToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F);
            this.motherToungeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("motherToungeToolStripMenuItem.Image")));
            this.motherToungeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.motherToungeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.motherToungeToolStripMenuItem.Name = "motherToungeToolStripMenuItem";
            this.motherToungeToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.motherToungeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.motherToungeToolStripMenuItem.Click += new System.EventHandler(this.motherToungeToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(200, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 550);
            this.panel4.TabIndex = 3;
            // 
            // plSettingsMenu
            // 
            this.plSettingsMenu.BackColor = System.Drawing.Color.White;
            this.plSettingsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plSettingsMenu.Location = new System.Drawing.Point(201, 44);
            this.plSettingsMenu.Name = "plSettingsMenu";
            this.plSettingsMenu.Size = new System.Drawing.Size(1169, 550);
            this.plSettingsMenu.TabIndex = 4;
            this.plSettingsMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.plSettingsMenu_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 43);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1370, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Setting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // religionSettingToolStripMenuItem
            // 
            this.religionSettingToolStripMenuItem.Name = "religionSettingToolStripMenuItem";
            this.religionSettingToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.religionSettingToolStripMenuItem.Text = "Religion Setting ";
            // 
            // frmSettingMenus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 594);
            this.ControlBox = false;
            this.Controls.Add(this.plSettingsMenu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettingMenus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSettingMenus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSettingMenus_Load);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem schoolSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentTypeSettingToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem setClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignSubjectsToolStripMenuItem;
        private System.Windows.Forms.Panel plSettingsMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem stateSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citySettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casteSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorySettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countrySettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motherToungeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem religionSettingToolStripMenuItem;
        private System.Windows.Forms.Label label1;

    }
}