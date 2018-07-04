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
    public partial class frmNewStudent : Form
    {
        public frmNewStudent()
        {
            InitializeComponent();
        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void frmNewStudent_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMotherTounge objfrmMotherTounge = new frmMotherTounge();
           // objfrmMotherTounge.MdiParent = this;
            objfrmMotherTounge.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmClassCreation objfrmClassCreation = new frmClassCreation();
            objfrmClassCreation.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAddStudentType objfrmAddStudentType = new frmAddStudentType();
            objfrmAddStudentType.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCasteSettings objfrmCasteSettings = new frmCasteSettings();
            objfrmCasteSettings.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSubCasteSettings objfrmSubCasteSettings = new frmSubCasteSettings();
            objfrmSubCasteSettings.Show();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmReligionMaster objfrmReligionMaster = new frmReligionMaster();
            objfrmReligionMaster.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmCategoryMaster objfrmCategoryMaster = new frmCategoryMaster();
            objfrmCategoryMaster.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmNationality objfrmNationality = new frmNationality();
            objfrmNationality.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmCountryMaster objfrmCountryMaster = new frmCountryMaster();
            objfrmCountryMaster.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmStateMaster objfrmStateMaster = new frmStateMaster();
            objfrmStateMaster.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmCityMaster objfrmCityMaster = new frmCityMaster();
            objfrmCityMaster.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmCityMaster objfrmCityMaster = new frmCityMaster();
            objfrmCityMaster.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {

            frmStateMaster objfrmStateMaster = new frmStateMaster();
            objfrmStateMaster.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            frmCountryMaster objfrmCountryMaster = new frmCountryMaster();
            objfrmCountryMaster.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmNationality objfrmNationality = new frmNationality();
            objfrmNationality.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmDocuments objfrmDocuments = new frmDocuments();
            objfrmDocuments.Show();
        }

      
    }
}
