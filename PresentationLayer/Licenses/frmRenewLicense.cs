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
    public partial class frmRenewLicense : Form
    {
        clsLicense OldLicenseDetails;
        clsLicense NewLicenseDetails;
        clsApplication ApplicationDetails;
        public frmRenewLicense()
        {
            InitializeComponent();

            decimal ApplicationFees = clsApplication.GetApplicationFees(2);
            decimal LicenseFees = clsApplication.GetApplicationFees(1);
            decimal TotalFees = ApplicationFees + LicenseFees;

            lblTotalFees.Text = TotalFees.ToString();
            lblApplicationFees.Text = ApplicationFees.ToString();
            lblLicenseFees.Text = LicenseFees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (ctrlFindLicense1.LicenseInfo == null)
            {
                MessageBox.Show("Select a License First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int OldLicenseID = ctrlFindLicense1.LicenseInfo.LicenseID;

            int RenwedLicenseID = clsLicense.RenewLicense(OldLicenseID, tbNotes.Text, clsGlobal.LoggedInUser.UserID);

            if (RenwedLicenseID == -1)
            {
                MessageBox.Show("The current license has not expired yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (RenwedLicenseID == -2)
            {
                MessageBox.Show("Driver already has an active license that is not expired!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (RenwedLicenseID == -3)
            {
                MessageBox.Show("Deactivating the previous license failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (RenwedLicenseID == -4)
            {
                MessageBox.Show("Issueing a new license failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Successfully Renewed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OldLicenseDetails = clsLicense.FindLicenseByID(OldLicenseID);
                NewLicenseDetails = clsLicense.FindLicenseByID(RenwedLicenseID);
                ApplicationDetails = clsApplication.FindApplicationByID(ctrlFindLicense1.LicenseInfo.ApplicationID);

                FillLabels();
            }
        }

        private void FillLabels ()
        {
            lblApplicationID.Text = ApplicationDetails.ApplicationID.ToString();
            lblApplicationDate.Text = ApplicationDetails.Date.ToString("dd MMM yyyy");

            lblIssueDate.Text = NewLicenseDetails.IssueDate.ToString("dd MMM yyyy");
            lblRenewedID.Text = NewLicenseDetails.LicenseID.ToString();
            lblOldID.Text = OldLicenseDetails.LicenseID.ToString();
            lblExpirationDate.Text = NewLicenseDetails.ExpirationDate.ToString("dd MMM yyyy");
            lblCreatedBy.Text = ApplicationDetails.CreatedByUser;
        }
    }
}
