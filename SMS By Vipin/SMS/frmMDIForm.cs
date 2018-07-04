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
    public partial class frmMDIForm : Form
    {
        public frmMDIForm()
        {
            InitializeComponent();
        }

        public void CloseAllAciveForms()
        {
            foreach (Form F in this.MdiChildren)
            {
                if (F != null)
                {
                    F.Dispose();
                    // F.MdiParent = this;
                    //F.Left = 186;



                }
            }
        }
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmStudentsDetail_ objfrmStudentsDetail_ = new frmStudentsDetail_();
            objfrmStudentsDetail_.MdiParent = this;
            objfrmStudentsDetail_.Show();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMDIForm_Load(object sender, EventArgs e)
        {

        }

        private void transportationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmTransportationMenu objfrmTransportation = new frmTransportationMenu();
            objfrmTransportation.MdiParent = this;
            objfrmTransportation.Show();
        }

        private void stockManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmStockManagementMenu objfrmStockManagementMenu = new frmStockManagementMenu();
            objfrmStockManagementMenu.MdiParent = this;
            objfrmStockManagementMenu.Show();
        }

        private void examToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmExamMenu objfrmfrmExamMenu = new frmExamMenu();
            objfrmfrmExamMenu.MdiParent = this;
            objfrmfrmExamMenu.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmLiabraryManagementMenu objfrmLiabraryManagementMenu = new frmLiabraryManagementMenu();
            objfrmLiabraryManagementMenu.MdiParent = this;
            objfrmLiabraryManagementMenu.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmSettingMenus objfrmSettingMenus = new frmSettingMenus();
            objfrmSettingMenus.MdiParent = this;
            objfrmSettingMenus.Show();
        }
    }
}
