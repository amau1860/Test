namespace SMS
{
    partial class frmBusSettings
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
            this.label4 = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chklstPickPoints = new System.Windows.Forms.CheckedListBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBusNo = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbDriverPhoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLicenseNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBusSettings = new System.Windows.Forms.DataGridView();
            this.grpBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1174, 36);
            this.label4.TabIndex = 73;
            this.label4.Text = "Bus Setting\'s";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.groupBox1);
            this.grpBox.Controls.Add(this.cmbName);
            this.grpBox.Controls.Add(this.label9);
            this.grpBox.Controls.Add(this.txtBusNo);
            this.grpBox.Controls.Add(this.label58);
            this.grpBox.Controls.Add(this.button3);
            this.grpBox.Controls.Add(this.cmbRoute);
            this.grpBox.Controls.Add(this.label8);
            this.grpBox.Controls.Add(this.pbDriverPhoto);
            this.grpBox.Controls.Add(this.label7);
            this.grpBox.Controls.Add(this.txtLicenseNo);
            this.grpBox.Controls.Add(this.label5);
            this.grpBox.Controls.Add(this.label3);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.txtMobileNo);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Location = new System.Drawing.Point(192, 39);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(791, 173);
            this.grpBox.TabIndex = 74;
            this.grpBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chklstPickPoints);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(484, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 138);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pickup Point\'s";
            // 
            // chklstPickPoints
            // 
            this.chklstPickPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklstPickPoints.FormattingEnabled = true;
            this.chklstPickPoints.Location = new System.Drawing.Point(3, 19);
            this.chklstPickPoints.Name = "chklstPickPoints";
            this.chklstPickPoints.Size = new System.Drawing.Size(281, 112);
            this.chklstPickPoints.TabIndex = 0;
            // 
            // cmbName
            // 
            this.cmbName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(125, 76);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(245, 23);
            this.cmbName.TabIndex = 153;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 152;
            this.label9.Text = "Bus No :";
            // 
            // txtBusNo
            // 
            this.txtBusNo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusNo.Location = new System.Drawing.Point(125, 51);
            this.txtBusNo.Name = "txtBusNo";
            this.txtBusNo.Size = new System.Drawing.Size(245, 21);
            this.txtBusNo.TabIndex = 151;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label58.Location = new System.Drawing.Point(373, 21);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(15, 18);
            this.label58.TabIndex = 150;
            this.label58.Text = "*";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(387, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(13, 23);
            this.button3.TabIndex = 148;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // cmbRoute
            // 
            this.cmbRoute.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(125, 22);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(245, 23);
            this.cmbRoute.TabIndex = 145;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 144;
            this.label8.Text = "Route :";
            // 
            // pbDriverPhoto
            // 
            this.pbDriverPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDriverPhoto.Location = new System.Drawing.Point(390, 66);
            this.pbDriverPhoto.Name = "pbDriverPhoto";
            this.pbDriverPhoto.Size = new System.Drawing.Size(90, 85);
            this.pbDriverPhoto.TabIndex = 141;
            this.pbDriverPhoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 127;
            this.label7.Text = "License No :";
            // 
            // txtLicenseNo
            // 
            this.txtLicenseNo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseNo.Location = new System.Drawing.Point(125, 103);
            this.txtLicenseNo.Name = "txtLicenseNo";
            this.txtLicenseNo.Size = new System.Drawing.Size(245, 21);
            this.txtLicenseNo.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(373, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 18);
            this.label5.TabIndex = 125;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(373, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 124;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 122;
            this.label2.Text = "Mobile No :";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(125, 130);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(245, 21);
            this.txtMobileNo.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 120;
            this.label1.Text = "Name :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBusSettings);
            this.panel1.Location = new System.Drawing.Point(2, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 390);
            this.panel1.TabIndex = 75;
            // 
            // dgvBusSettings
            // 
            this.dgvBusSettings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBusSettings.Location = new System.Drawing.Point(0, 0);
            this.dgvBusSettings.Name = "dgvBusSettings";
            this.dgvBusSettings.Size = new System.Drawing.Size(1162, 390);
            this.dgvBusSettings.TabIndex = 0;
            // 
            // frmBusSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 741);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bus Setting\'s";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.PictureBox pbDriverPhoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLicenseNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBusNo;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chklstPickPoints;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBusSettings;
    }
}