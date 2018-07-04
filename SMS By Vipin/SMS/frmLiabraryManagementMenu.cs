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
    public partial class frmLiabraryManagementMenu : Form
    {
        public frmLiabraryManagementMenu()
        {
            InitializeComponent();
        }
        public void CloseAllAciveForms()
        {
            foreach (Form F in plLibraryManagement.Controls)
            {
                if (F != null)
                {
                    F.Dispose();
                    // F.MdiParent = this;
                    //F.Left = 186;

                }
            }
        }
        private void AddPublicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddPublicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            CloseAllAciveForms();
            frmAddPublication objfrmAddPublication = new frmAddPublication();
            objfrmAddPublication.TopLevel = false;
            plLibraryManagement.Controls.Add(objfrmAddPublication);
            objfrmAddPublication.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmAddPublication.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmAddPublication.Show();
        }

        private void AddBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            CloseAllAciveForms();
            frmAddbookDetails objfrmAddbookDetails = new frmAddbookDetails();
            objfrmAddbookDetails.TopLevel = false;
            plLibraryManagement.Controls.Add(objfrmAddbookDetails);
            objfrmAddbookDetails.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmAddbookDetails.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmAddbookDetails.Show();
        }

        private void IssueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseAllAciveForms();
            frmBookIssued objfrmBookIssued = new frmBookIssued();
            objfrmBookIssued.TopLevel = false;
            plLibraryManagement.Controls.Add(objfrmBookIssued);
            objfrmBookIssued.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmBookIssued.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmBookIssued.Show();
        }

        private void ReturnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {


            CloseAllAciveForms();
            frmreturnBooks objfrmreturnBooks = new frmreturnBooks();
            objfrmreturnBooks.TopLevel = false;
            plLibraryManagement.Controls.Add(objfrmreturnBooks);
            objfrmreturnBooks.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmreturnBooks.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmreturnBooks.Show();
        }
    }
}
