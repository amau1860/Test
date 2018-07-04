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
    public partial class frmTransportationMenu : Form
    {
        public frmTransportationMenu()
        {
            InitializeComponent();
        }
        public void CloseAllAciveForms()
        {
            foreach (Form F in plTrasnportationSettings.Controls)
            {
                if (F != null)
                {
                    F.Dispose();
                    // F.MdiParent = this;
                    //F.Left = 186;

                }
            }
        }

        private void RouteSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseAllAciveForms();
            frmRouteSetting objfrmRouteSetting = new frmRouteSetting();
            objfrmRouteSetting.TopLevel = false;
            plTrasnportationSettings.Controls.Add(objfrmRouteSetting);
            objfrmRouteSetting.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmRouteSetting.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmRouteSetting.Show();
        }

        private void PickupPointSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmPickupPoint objfrmPickupPoint = new frmPickupPoint();
            objfrmPickupPoint.TopLevel = false;
            plTrasnportationSettings.Controls.Add(objfrmPickupPoint);
            objfrmPickupPoint.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmPickupPoint.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmPickupPoint.Show();
        }

        private void driverRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmDriverDetail_s objfrmDriverDetail_s = new frmDriverDetail_s();
            objfrmDriverDetail_s.TopLevel = false;
            plTrasnportationSettings.Controls.Add(objfrmDriverDetail_s);
            objfrmDriverDetail_s.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmDriverDetail_s.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmDriverDetail_s.Show();
        }

        private void BusSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmBusSettings objfrmBusSettings = new frmBusSettings();
            objfrmBusSettings.TopLevel = false;
            plTrasnportationSettings.Controls.Add(objfrmBusSettings);
            objfrmBusSettings.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmBusSettings.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmBusSettings.Show();
        }

        private void StudentAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmStudentAllocation objfrmtudentAllocation = new frmStudentAllocation();
            objfrmtudentAllocation.TopLevel = false;
            plTrasnportationSettings.Controls.Add(objfrmtudentAllocation);
            objfrmtudentAllocation.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmtudentAllocation.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmtudentAllocation.Show();
        }

        private void busFeesCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseAllAciveForms();
            frmBusFeeCollection objfrmBusFeeCollection = new frmBusFeeCollection();
            objfrmBusFeeCollection.TopLevel = false;
            plTrasnportationSettings.Controls.Add(objfrmBusFeeCollection);
            objfrmBusFeeCollection.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmBusFeeCollection.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmBusFeeCollection.Show();
        }
        
    }
}
