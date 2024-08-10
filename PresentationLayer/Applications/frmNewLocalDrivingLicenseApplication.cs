using BusinessLayer;
using PresentationLayer.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();

            //btnSave.Enabled = false;
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblFees.Text = clsApplication.GetApplicationFees(1).ToString();
            lblUser.Text = clsGlobal.LoggedInUser.UserName;
            //this.Location = new Point(940, 640);

            FillLicenseClassesComboBox();
        }

        private void FillLicenseClassesComboBox ()
        {
            DataTable LicenseClasses = clsLicense.GetLicenseClasses();
            cbLicenseClasses.Items.Clear();

            foreach (DataRow row in LicenseClasses.Rows)
            {
                cbLicenseClasses.Items.Add(row[1].ToString());
            }

            cbLicenseClasses.SelectedIndex = 2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrlFindPerson1.PersonInfo == null)
            {
                MessageBox.Show("Select a Person First", "No Person Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LDLApplicationID = clsLocalDrivingLicensApplication.CreateLocalDrivingLicenseApplication(ctrlFindPerson1.PersonInfo.ID, cbLicenseClasses.SelectedIndex + 1, clsGlobal.LoggedInUser.UserID);
            
            if(LDLApplicationID == -4)
            {
                MessageBox.Show("This person does not meet the minimum age required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (LDLApplicationID == -3)
            {
                MessageBox.Show("This person already has an open application of the same class type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LDLApplicationID == -2)
            {
                MessageBox.Show("Application couldn't be made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (LDLApplicationID == -1)
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblApplicationID.Text = LDLApplicationID.ToString();
                MessageBox.Show("Application Created Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
