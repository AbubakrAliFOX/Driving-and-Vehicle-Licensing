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
    public partial class frmNewInternationalDrivingLicenseApplication : Form
    {
        public frmNewInternationalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void FillLabels(clsInternationalLicense LicenseInfo)
        {
            lblApplicationID.Text = LicenseInfo.ILApplicationID.ToString();
            lblApplicationDate.Text = LicenseInfo.ApplicationDate.ToString("dd MMM yyyy");
            lblIssueDate.Text = LicenseInfo.IssueDate.ToString("dd MMM yyyy");
            lblExpirationDate.Text = LicenseInfo.ExpirationDate.ToString("dd MMM yyyy");
            lblFees.Text = LicenseInfo.PaidFees.ToString();
            lblUser.Text = LicenseInfo.CreatedByUser;
            lblLicenseID.Text = LicenseInfo.LocalLicense.LicenseID.ToString();
            lblInternationalLicenseID.Text = LicenseInfo.InternationalLicenseID.ToString();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (ctrlFindLicense1.LicenseInfo == null)
            {
                MessageBox.Show("Select a License First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsInternationalLicense.HasInternationalLicense(ctrlFindLicense1.LicenseInfo.LicenseID))
            {
                int InternationalLicenseID = clsInternationalLicense.IssueInternationalLicense(ctrlFindLicense1.LicenseInfo.LicenseID);

                if (InternationalLicenseID == -1)
                {
                    MessageBox.Show("Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (InternationalLicenseID == -2)
                {
                    MessageBox.Show("Driver must have a license of class 3 'Ordinary Driving License'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Internatinoal license issued successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsInternationalLicense InternationalLicense = clsInternationalLicense.FindInternationalLicenseByLocalLicenseID(ctrlFindLicense1.LicenseInfo.LicenseID);
                    FillLabels(InternationalLicense);
                }

            }
            else
            {
                MessageBox.Show("Driver already has an international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
