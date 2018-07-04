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
    public partial class frmSettingMenus : Form
    {
        public frmSettingMenus()
        {
            InitializeComponent();
        }

        public void CloseAllAciveForms()
        {
            foreach (Form F in plSettingsMenu.Controls)
            {
                if (F != null)
                {
                    F.Dispose();
                    // F.MdiParent = this;
                    //F.Left = 186;
                   
                 

                }
            }
        }

        private void createClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmClassCreation objfrmClassCreation = new frmClassCreation();
            //objfrmClassCreation.MdiParent= this;
            //objfrmClassCreation.Show();
            CloseAllAciveForms();
            frmClassCreation objfrmClassCreation = new frmClassCreation();
            objfrmClassCreation.TopLevel = false;
            plSettingsMenu.Controls.Add(objfrmClassCreation);
            objfrmClassCreation.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmClassCreation.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmClassCreation.Show();
            //objAddNewUser.Show();
            
        }

        private void studentTypeSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmAddStudentType objfrmAddStudentType = new frmAddStudentType();
            objfrmAddStudentType.TopLevel = false;
            plSettingsMenu.Controls.Add(objfrmAddStudentType);
            objfrmAddStudentType.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmAddStudentType.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmAddStudentType.Show();



            //frmAddStudentType objfrmAddStudentType = new frmAddStudentType();
            //objfrmAddStudentType.MdiParent = this;
            //objfrmAddStudentType.Show();
        }

        private void setClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmSetClassFee objfrmSetClassFee = new frmSetClassFee();
            objfrmSetClassFee.TopLevel = false;
            plSettingsMenu.Controls.Add(objfrmSetClassFee);
            objfrmSetClassFee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmSetClassFee.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmSetClassFee.Show();



            //frmSetClassFee objfrmSetClassFee = new frmSetClassFee();
            //objfrmSetClassFee.MdiParent = this;
            //objfrmSetClassFee.Show();
        }

        private void subjectMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmSubjectMaster objfrmSubjectMaster = new frmSubjectMaster();
            objfrmSubjectMaster.TopLevel = false;
            plSettingsMenu.Controls.Add(objfrmSubjectMaster);
            objfrmSubjectMaster.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmSubjectMaster.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmSubjectMaster.Show();





            //frmSubjectMaster objfrmSubjectMaster = new frmSubjectMaster();
            //objfrmSubjectMaster.MdiParent = this;
            //objfrmSubjectMaster.Show();
        }

        private void assignSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmAssignSubject objfrmAssignSubject = new frmAssignSubject();
            objfrmAssignSubject.TopLevel = false;
            plSettingsMenu.Controls.Add(objfrmAssignSubject);
            objfrmAssignSubject.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmAssignSubject.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmAssignSubject.Show();

            //frmAssignSubject objfrmAssignSubject = new frmAssignSubject();
            //objfrmAssignSubject.MdiParent = this;
            //objfrmAssignSubject.Show();
        }

        private void schoolSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllAciveForms();
                frmSchoolSetting objfrmSchoolSetting = new frmSchoolSetting();
                objfrmSchoolSetting.TopLevel = false;
                plSettingsMenu.Controls.Add(objfrmSchoolSetting);
                objfrmSchoolSetting.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objfrmSchoolSetting.Dock = DockStyle.Fill;
                //splitContainer2.Panel2.Controls.Add(objAddNewUser);
                //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                //objAddNewUser.Dock = DockStyle.Fill;

                objfrmSchoolSetting.Show();
             //   this.schoolSettingToolStripMenuItem.ForeColor = Color.AliceBlue;
                this.schoolSettingToolStripMenuItem.BackColor = Color.FromArgb(48, 175, 242);
            }
            catch { }

            //frmSchoolSetting objfrmAssignSubject = new frmSchoolSetting();
            //objfrmAssignSubject.MdiParent = this;
            //objfrmAssignSubject.Show();
        }


        public void addseparator()
        {
            this.menuStrip1.Items.Insert(1, new ToolStripSeparator());
            this.menuStrip1.Items.Insert(3, new ToolStripSeparator());
            this.menuStrip1.Items.Insert(5, new ToolStripSeparator());
            this.menuStrip1.Items.Insert(7, new ToolStripSeparator());
            this.menuStrip1.Items.Insert(9, new ToolStripSeparator());
            this.menuStrip1.Items.Insert(11, new ToolStripSeparator());
            this.menuStrip1.Items.Insert(13, new ToolStripSeparator());
            this.menuStrip1.Items.Insert(15, new ToolStripSeparator());
        }

        private void frmSettingMenus_Load(object sender, EventArgs e)
        {
            addseparator(); 
        }

        public void changecolor()
        {
            
        }
        private void plSettingsMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void casteSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllAciveForms();
                frmCasteSettings objfrmCasteSettings = new frmCasteSettings();
                objfrmCasteSettings.TopLevel = false;
                plSettingsMenu.Controls.Add(objfrmCasteSettings);
                objfrmCasteSettings.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objfrmCasteSettings.Dock = DockStyle.Fill;
                objfrmCasteSettings.Show();
            }
            catch { }
        }

        private void stateSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllAciveForms();
                frmStateMaster objfrmStateMaster = new frmStateMaster();
                objfrmStateMaster.TopLevel = false;
                plSettingsMenu.Controls.Add(objfrmStateMaster);
                objfrmStateMaster.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objfrmStateMaster.Dock = DockStyle.Fill;
                objfrmStateMaster.Show();
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //if (e.ClickedItem.BackColor != Color.Blue)
            //    e.ClickedItem.BackColor = Color.Blue;
        }

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllAciveForms();
            frmAddStudentType objfrmAddStudentType = new frmAddStudentType();
            objfrmAddStudentType.TopLevel = false;
            plSettingsMenu.Controls.Add(objfrmAddStudentType);
            objfrmAddStudentType.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objfrmAddStudentType.Dock = DockStyle.Fill;
            //splitContainer2.Panel2.Controls.Add(objAddNewUser);
            //objAddNewUser.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //objAddNewUser.Dock = DockStyle.Fill;

            objfrmAddStudentType.Show();

        }

        private void demo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllAciveForms();
                frmSchoolSetting objfrmSchoolSetting = new frmSchoolSetting();
                objfrmSchoolSetting.TopLevel = false;
                plSettingsMenu.Controls.Add(objfrmSchoolSetting);
                objfrmSchoolSetting.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objfrmSchoolSetting.Dock = DockStyle.Fill;
                objfrmSchoolSetting.Show();
            }
            catch { }
        }

      
        private void documentsSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllAciveForms();
                frmDocuments objfrmDocuments = new frmDocuments();
                objfrmDocuments.TopLevel = false;
                plSettingsMenu.Controls.Add(objfrmDocuments);
                objfrmDocuments.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objfrmDocuments.Dock = DockStyle.Fill;
                objfrmDocuments.Show();
            }
            catch { }
        }

        private void countrySettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllAciveForms();
                frmCountryMaster objfrmCountryMaster = new frmCountryMaster();
                objfrmCountryMaster.TopLevel = false;
                plSettingsMenu.Controls.Add(objfrmCountryMaster);
                objfrmCountryMaster.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objfrmCountryMaster.Dock = DockStyle.Fill;
                objfrmCountryMaster.Show();
            }
            catch { }
        }

        private void citySettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllAciveForms();
                frmCityMaster objfrmCityMaster = new frmCityMaster();
                objfrmCityMaster.TopLevel = false;
                plSettingsMenu.Controls.Add(objfrmCityMaster);
                objfrmCityMaster.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objfrmCityMaster.Dock = DockStyle.Fill;
                objfrmCityMaster.Show();
            }
            catch { }
        }

        private void motherToungeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllAciveForms();
                frmMotherTounge objfrmMotherTounge = new frmMotherTounge();
                objfrmMotherTounge.TopLevel = false;
                plSettingsMenu.Controls.Add(objfrmMotherTounge);
                objfrmMotherTounge.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objfrmMotherTounge.Dock = DockStyle.Fill;
                objfrmMotherTounge.Show();
            }
            catch { }
        }

        private void categorySettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllAciveForms();
                frmCategoryMaster objfrmCategoryMaster = new frmCategoryMaster();
                objfrmCategoryMaster.TopLevel = false;
                plSettingsMenu.Controls.Add(objfrmCategoryMaster);
                objfrmCategoryMaster.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objfrmCategoryMaster.Dock = DockStyle.Fill;
                objfrmCategoryMaster.Show();
            }
            catch { }
        }

      
       
    }
}
