using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMS
{
    public partial class frmStudentsDetail_ : Form
    {
        public frmStudentsDetail_()
        {
            InitializeComponent();
        }
        public void CloseAllAciveForms()
        {
            foreach (Form F in plStudentsSetting.Controls)
            {
                if (F != null)
                {
                    F.Dispose();
                    // F.MdiParent = this;
                    //F.Left = 186;

                }
            }
        }
        private void frmStudentsDetail__Load(object sender, EventArgs e)
        {

        }

        private void plSettingsMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void plStudentsSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newStudentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            CloseAllAciveForms();
            frmNewStudent objfrmNewStudent = new frmNewStudent();
            objfrmNewStudent.TopLevel = false;
            plStudentsSetting.Controls.Add(objfrmNewStudent);
            objfrmNewStudent.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmNewStudent.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmNewStudent.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void studentsAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmStudentAttendence objfrmStudentAttendence = new frmStudentAttendence();
            objfrmStudentAttendence.TopLevel = false;
            plStudentsSetting.Controls.Add(objfrmStudentAttendence);
            objfrmStudentAttendence.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmStudentAttendence.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmStudentAttendence.Show();
        }

       

        private void certificatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmBonafideCertificate objfrmBonafideCertificate = new frmBonafideCertificate();
            objfrmBonafideCertificate.TopLevel = false;
            plStudentsSetting.Controls.Add(objfrmBonafideCertificate);
            objfrmBonafideCertificate.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmBonafideCertificate.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmBonafideCertificate.Show();
        }

        private void feesTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmFeeTransaction objfrmFeeTransaction = new frmFeeTransaction();
            objfrmFeeTransaction.TopLevel = false;
            plStudentsSetting.Controls.Add(objfrmFeeTransaction);
            objfrmFeeTransaction.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmFeeTransaction.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmFeeTransaction.Show();
        }

        private void promoteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseAllAciveForms();
            frmPramoteStudent objfrmPramoteStudent = new frmPramoteStudent();
            objfrmPramoteStudent.TopLevel = false;
            plStudentsSetting.Controls.Add(objfrmPramoteStudent);
            objfrmPramoteStudent.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmPramoteStudent.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmPramoteStudent.Show();
        }
    }
}
