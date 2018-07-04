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
    public partial class frmBonafideCertificate : Form
    {
        public frmBonafideCertificate()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cmbCertificateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (cmbCertificateType.Text == "Bonafide Certificate")
                {
                    grpBonafideCertificate.Visible = true;
                    grpBonafideButtons.Visible = true;
                    grpLeavingDetail.Visible = false;

                }
                else if (cmbCertificateType.Text == "Leaving Certificate")
                {
                    grpBonafideCertificate.Visible = true;
                    grpBonafideButtons.Visible = false;
                    grpLeavingDetail.Visible = true;
                }
            }
            catch { }
        }
    }
}
