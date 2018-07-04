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
    public partial class frmStockManagementMenu : Form
    {
        public frmStockManagementMenu()
        {
            InitializeComponent();
        }

        public void CloseAllAciveForms()
        {
            try
            {
                foreach (Form F in plStockManagement.Controls)
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

        private void DealerRegi_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmDealerRegistration objfrmDealerRegistration = new frmDealerRegistration();
            objfrmDealerRegistration.TopLevel = false;
            plStockManagement.Controls.Add(objfrmDealerRegistration);
            objfrmDealerRegistration.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmDealerRegistration.Dock = DockStyle.Fill;
          

            objfrmDealerRegistration.Show();
        }

        private void staffRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmStaffRegistration objfrmStaffRegistration = new frmStaffRegistration();
            objfrmStaffRegistration.TopLevel = false;
            plStockManagement.Controls.Add(objfrmStaffRegistration);
            objfrmStaffRegistration.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmStaffRegistration.Dock = DockStyle.Fill;


            objfrmStaffRegistration.Show();
        }

        private void productSetting_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmstockName objfrmProductSetting  = new frmstockName();
            objfrmProductSetting.TopLevel = false;
            plStockManagement.Controls.Add(objfrmProductSetting);
            objfrmProductSetting.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmProductSetting.Dock = DockStyle.Fill;


            objfrmProductSetting.Show();
        }

        private void departmentSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmDepartmentSetting objfrmDepartmentSetting = new frmDepartmentSetting();
            objfrmDepartmentSetting.TopLevel = false;
            plStockManagement.Controls.Add(objfrmDepartmentSetting);
            objfrmDepartmentSetting.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmDepartmentSetting.Dock = DockStyle.Fill;


            objfrmDepartmentSetting.Show();
        }

        private void stocktype_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmStockType objfrmStockType = new frmStockType();
            objfrmStockType.TopLevel = false;
            plStockManagement.Controls.Add(objfrmStockType);
            objfrmStockType.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmStockType.Dock = DockStyle.Fill;


            objfrmStockType.Show();
        }

        private void stockin_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmStockIn objfrmfrmStockIn = new frmStockIn();
            objfrmfrmStockIn.TopLevel = false;
            plStockManagement.Controls.Add(objfrmfrmStockIn);
            objfrmfrmStockIn.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmfrmStockIn.Dock = DockStyle.Fill;


            objfrmfrmStockIn.Show();
        }

        private void StockOut_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmStockOut objfrmStockOut = new frmStockOut();
            objfrmStockOut.TopLevel = false;
            plStockManagement.Controls.Add(objfrmStockOut);
            objfrmStockOut.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmStockOut.Dock = DockStyle.Fill;


            objfrmStockOut.Show();
        }

        private void stockreturn_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmStockReturn objfrmStockReturn = new frmStockReturn();
            objfrmStockReturn.TopLevel = false;
            plStockManagement.Controls.Add(objfrmStockReturn);
            objfrmStockReturn.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmStockReturn.Dock = DockStyle.Fill;


            objfrmStockReturn.Show();
        }

        private void plStockManagement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmStockManagementMenu_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}
