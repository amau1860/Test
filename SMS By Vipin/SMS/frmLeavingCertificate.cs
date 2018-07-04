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
    public partial class frmLeavingCertificate : Form
    {
        public frmLeavingCertificate()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLeavingCertificate_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(tabPage2);
        }
    }
}
