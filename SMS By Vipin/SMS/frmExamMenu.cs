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
    public partial class frmExamMenu : Form
    {
        public frmExamMenu()
        {
            InitializeComponent();
        }

        public void CloseAllAciveForms()
        {
            try
            {
                foreach (Form F in plExamMenu.Controls)
                {
                    if (F != null)
                    {
                        F.Dispose();
                        // F.MdiParent = this;
                        //F.Left = 186;



                    }
                }
            }
            catch { }
        }
        private void ExamType_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmExamType objfrmExamType = new frmExamType();
            objfrmExamType.TopLevel = false;
            plExamMenu.Controls.Add(objfrmExamType);
            objfrmExamType.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmExamType.Dock = DockStyle.Fill;


            objfrmExamType.Show();
        }

     
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExamTimeTable_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmExamTimeTable objfrmExamTimeTable = new frmExamTimeTable();
            objfrmExamTimeTable.TopLevel = false;
            plExamMenu.Controls.Add(objfrmExamTimeTable);
            objfrmExamTimeTable.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmExamTimeTable.Dock = DockStyle.Fill;


            objfrmExamTimeTable.Show();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmResult objfrmResult = new frmResult();
            objfrmResult.TopLevel = false;
            plExamMenu.Controls.Add(objfrmResult);
            objfrmResult.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmResult.Dock = DockStyle.Fill;


            objfrmResult.Show();
        }
    }
}
