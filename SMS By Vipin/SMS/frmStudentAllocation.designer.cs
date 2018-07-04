namespace SMS
{
    partial class frmStudentAllocation
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
            this.grpLeavingDetail = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label34 = new System.Windows.Forms.Label();
            this.txtBusNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPickupPoint = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbStudentName = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStudentAllocation = new System.Windows.Forms.DataGridView();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpLeavingDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAllocation)).BeginInit();
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
            this.label4.Text = "Student Allocation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpLeavingDetail
            // 
            this.grpLeavingDetail.Controls.Add(this.dtpDate);
            this.grpLeavingDetail.Controls.Add(this.label34);
            this.grpLeavingDetail.Controls.Add(this.txtBusNo);
            this.grpLeavingDetail.Controls.Add(this.label11);
            this.grpLeavingDetail.Controls.Add(this.txtFare);
            this.grpLeavingDetail.Controls.Add(this.label10);
            this.grpLeavingDetail.Controls.Add(this.txtRoute);
            this.grpLeavingDetail.Controls.Add(this.label7);
            this.grpLeavingDetail.Controls.Add(this.cmbPickupPoint);
            this.grpLeavingDetail.Controls.Add(this.label2);
            this.grpLeavingDetail.Controls.Add(this.label5);
            this.grpLeavingDetail.Controls.Add(this.cmbSection);
            this.grpLeavingDetail.Controls.Add(this.label6);
            this.grpLeavingDetail.Controls.Add(this.label9);
            this.grpLeavingDetail.Controls.Add(this.cmbStudentName);
            this.grpLeavingDetail.Controls.Add(this.label58);
            this.grpLeavingDetail.Controls.Add(this.cmbClass);
            this.grpLeavingDetail.Controls.Add(this.label8);
            this.grpLeavingDetail.Controls.Add(this.label3);
            this.grpLeavingDetail.Controls.Add(this.label1);
            this.grpLeavingDetail.Location = new System.Drawing.Point(199, 39);
            this.grpLeavingDetail.Name = "grpLeavingDetail";
            this.grpLeavingDetail.Size = new System.Drawing.Size(777, 143);
            this.grpLeavingDetail.TabIndex = 74;
            this.grpLeavingDetail.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(499, 18);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(113, 23);
            this.dtpDate.TabIndex = 180;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold);
            this.label34.Location = new System.Drawing.Point(449, 21);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(48, 16);
            this.label34.TabIndex = 179;
            this.label34.Text = "Date :";
            // 
            // txtBusNo
            // 
            this.txtBusNo.Enabled = false;
            this.txtBusNo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusNo.Location = new System.Drawing.Point(499, 102);
            this.txtBusNo.Name = "txtBusNo";
            this.txtBusNo.Size = new System.Drawing.Size(245, 21);
            this.txtBusNo.TabIndex = 178;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(432, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 177;
            this.label11.Text = "Bus No :";
            // 
            // txtFare
            // 
            this.txtFare.Enabled = false;
            this.txtFare.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFare.Location = new System.Drawing.Point(499, 73);
            this.txtFare.Name = "txtFare";
            this.txtFare.Size = new System.Drawing.Size(245, 21);
            this.txtFare.TabIndex = 176;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 175;
            this.label10.Text = "Fare :";
            // 
            // txtRoute
            // 
            this.txtRoute.Enabled = false;
            this.txtRoute.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoute.Location = new System.Drawing.Point(499, 47);
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(245, 21);
            this.txtRoute.TabIndex = 174;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 173;
            this.label7.Text = "Route :";
            // 
            // cmbPickupPoint
            // 
            this.cmbPickupPoint.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPickupPoint.FormattingEnabled = true;
            this.cmbPickupPoint.Location = new System.Drawing.Point(148, 102);
            this.cmbPickupPoint.Name = "cmbPickupPoint";
            this.cmbPickupPoint.Size = new System.Drawing.Size(245, 23);
            this.cmbPickupPoint.TabIndex = 172;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(396, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 171;
            this.label2.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 170;
            this.label5.Text = "Pickup Point :";
            // 
            // cmbSection
            // 
            this.cmbSection.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(148, 47);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(245, 23);
            this.cmbSection.TabIndex = 169;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(396, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 18);
            this.label6.TabIndex = 168;
            this.label6.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 167;
            this.label9.Text = "Section :";
            // 
            // cmbStudentName
            // 
            this.cmbStudentName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentName.FormattingEnabled = true;
            this.cmbStudentName.Location = new System.Drawing.Point(148, 73);
            this.cmbStudentName.Name = "cmbStudentName";
            this.cmbStudentName.Size = new System.Drawing.Size(245, 23);
            this.cmbStudentName.TabIndex = 166;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label58.Location = new System.Drawing.Point(396, 20);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(15, 18);
            this.label58.TabIndex = 163;
            this.label58.Text = "*";
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(148, 21);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(245, 23);
            this.cmbClass.TabIndex = 162;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 161;
            this.label8.Text = "Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(396, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 157;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 154;
            this.label1.Text = "Student Name :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStudentAllocation);
            this.panel1.Location = new System.Drawing.Point(4, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 420);
            this.panel1.TabIndex = 76;
            // 
            // dgvStudentAllocation
            // 
            this.dgvStudentAllocation.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentAllocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Class,
            this.Section,
            this.StudentName,
            this.PickPoint,
            this.Date,
            this.Route,
            this.Fare,
            this.BusNo});
            this.dgvStudentAllocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentAllocation.Location = new System.Drawing.Point(0, 0);
            this.dgvStudentAllocation.Name = "dgvStudentAllocation";
            this.dgvStudentAllocation.Size = new System.Drawing.Size(1162, 420);
            this.dgvStudentAllocation.TabIndex = 0;
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.Name = "Class";
            // 
            // Section
            // 
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            // 
            // PickPoint
            // 
            this.PickPoint.HeaderText = "PickPoint";
            this.PickPoint.Name = "PickPoint";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Route
            // 
            this.Route.HeaderText = "Route";
            this.Route.Name = "Route";
            // 
            // Fare
            // 
            this.Fare.HeaderText = "Fare";
            this.Fare.Name = "Fare";
            // 
            // BusNo
            // 
            this.BusNo.HeaderText = "BusNo";
            this.BusNo.Name = "BusNo";
            // 
            // frmStudentAllocation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 741);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpLeavingDetail);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStudentAllocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Allocation";
            this.grpLeavingDetail.ResumeLayout(false);
            this.grpLeavingDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAllocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpLeavingDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPickupPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbStudentName;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFare;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.TextBox txtBusNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStudentAllocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fare;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusNo;
    }
}