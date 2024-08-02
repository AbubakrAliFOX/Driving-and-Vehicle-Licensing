using BusinessLayer;
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

            if(!clsLicense.PersonHasLicenseClass(ctrlFindPerson1.PersonInfo.ID, cbLicenseClasses.SelectedIndex + 1))
            {
                int NewApplicationID = clsApplication.CreateApplication(ctrlFindPerson1.PersonInfo.ID, 1, clsApplication.GetApplicationFees(1));

                if (NewApplicationID != -1)
                {
                    if (clsLicense.CreateLocalDrivingLicenseApplication(NewApplicationID, cbLicenseClasses.SelectedIndex + 1))
                    {
                        lblApplicationID.Text = NewApplicationID.ToString();
                        MessageBox.Show("Application Created Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("This person already has an open application of the same class type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
