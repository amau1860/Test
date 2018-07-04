namespace SMS
{
    partial class frmPickupPoint
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPickupPoints = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPickPoint = new System.Windows.Forms.DataGridView();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PickPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpLeavingDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPickPoint)).BeginInit();
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
            this.label4.TabIndex = 71;
            this.label4.Text = "Pickup Point\'s";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpLeavingDetail
            // 
            this.grpLeavingDetail.Controls.Add(this.label5);
            this.grpLeavingDetail.Controls.Add(this.label3);
            this.grpLeavingDetail.Controls.Add(this.button5);
            this.grpLeavingDetail.Controls.Add(this.label2);
            this.grpLeavingDetail.Controls.Add(this.txtFare);
            this.grpLeavingDetail.Controls.Add(this.label1);
            this.grpLeavingDetail.Controls.Add(this.cmbRoute);
            this.grpLeavingDetail.Controls.Add(this.label11);
            this.grpLeavingDetail.Controls.Add(this.txtPickupPoints);
            this.grpLeavingDetail.Controls.Add(this.label9);
            this.grpLeavingDetail.Location = new System.Drawing.Point(387, 39);
            this.grpLeavingDetail.Name = "grpLeavingDetail";
            this.grpLeavingDetail.Size = new System.Drawing.Size(401, 115);
            this.grpLeavingDetail.TabIndex = 72;
            this.grpLeavingDetail.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(363, 80);
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
            this.label3.Location = new System.Drawing.Point(363, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 124;
            this.label3.Text = "*";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Location = new System.Drawing.Point(378, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(13, 23);
            this.button5.TabIndex = 123;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 122;
            this.label2.Text = "Fare :";
            // 
            // txtFare
            // 
            this.txtFare.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFare.Location = new System.Drawing.Point(113, 80);
            this.txtFare.Name = "txtFare";
            this.txtFare.Size = new System.Drawing.Size(247, 21);
            this.txtFare.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 120;
            this.label1.Text = "Pick Point :";
            // 
            // cmbRoute
            // 
            this.cmbRoute.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(113, 24);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(247, 23);
            this.cmbRoute.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(363, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 18);
            this.label11.TabIndex = 118;
            this.label11.Text = "*";
            // 
            // txtPickupPoints
            // 
            this.txtPickupPoints.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPickupPoints.Location = new System.Drawing.Point(113, 53);
            this.txtPickupPoints.Name = "txtPickupPoints";
            this.txtPickupPoints.Size = new System.Drawing.Size(247, 21);
            this.txtPickupPoints.TabIndex = 117;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 116;
            this.label9.Text = "Route :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPickPoint);
            this.panel1.Location = new System.Drawing.Point(388, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 226);
            this.panel1.TabIndex = 73;
            // 
            // dgvPickPoint
            // 
            this.dgvPickPoint.BackgroundColor = System.Drawing.Color.White;
            this.dgvPickPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPickPoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Route,
            this.PickPoint,
            this.Fare});
            this.dgvPickPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPickPoint.Location = new System.Drawing.Point(0, 0);
            this.dgvPickPoint.Name = "dgvPickPoint";
            this.dgvPickPoint.Size = new System.Drawing.Size(399, 226);
            this.dgvPickPoint.TabIndex = 0;
            // 
            // Route
            // 
            this.Route.HeaderText = "Route";
            this.Route.Name = "Route";
            // 
            // PickPoint
            // 
            this.PickPoint.HeaderText = "PickPoint";
            this.PickPoint.Name = "PickPoint";
            // 
            // Fare
            // 
            this.Fare.HeaderText = "Fare";
            this.Fare.Name = "Fare";
            // 
            // frmPickupPoint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 628);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpLeavingDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPickupPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pickup Point";
            this.grpLeavingDetail.ResumeLayout(false);
            this.grpLeavingDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPickPoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpLeavingDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPickupPoints;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPickPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn PickPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fare;

    }
}