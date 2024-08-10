using BusinessLayer;
using PresentationLayer;
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
    public partial class frmNewInternationalDrivingLicenseApplication : Form
    {
        clsInternationalLicense InternationalLicense;
        public frmNewInternationalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void FillLabels()
        {
            lblApplicationID.Text = InternationalLicense.ILApplicationID.ToString();
            lblApplicationDate.Text = InternationalLicense.ApplicationDate.ToString("dd MMM yyyy");
            lblIssueDate.Text = InternationalLicense.IssueDate.ToString("dd MMM yyyy");
            lblExpirationDate.Text = InternationalLicense.ExpirationDate.ToString("dd MMM yyyy");
            lblFees.Text = InternationalLicense.PaidFees.ToString();
            lblUser.Text = InternationalLicense.CreatedByUser;
            lblLicenseID.Text = InternationalLicense.LocalLicenseInfo.LicenseID.ToString();
            lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
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

            int InternationalLicenseID = clsInternationalLicense.IssueInternationalLicense(ctrlFindLicense1.LicenseInfo.LicenseID, clsGlobal.LoggedInUser.UserID);

            if (InternationalLicenseID == -4)
            {
                MessageBox.Show("Driver already has an international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (InternationalLicenseID == -3)
            {
                MessageBox.Show("License is inactive!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (InternationalLicenseID == -2)
            {
                MessageBox.Show("Driver must have a license of class 3 'Ordinary Driving License'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (InternationalLicenseID == -1)
            {
                MessageBox.Show("Something Went Wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                MessageBox.Show("Internatinoal license issued successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InternationalLicense = clsInternationalLicense.FindInternationalLicenseByLocalLicenseID(ctrlFindLicense1.LicenseInfo.LicenseID);
                FillLabels();
                llLicenseInfo.Enabled = true;
            }
        }

        private void llLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ctrlFindLicense1.LicenseInfo == null)
            {
                MessageBox.Show("Select a License First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmLicenseHistory LicenseHistory = new frmLicenseHistory(ctrlFindLicense1.LicenseInfo.PersonInfo.ID);
            LicenseHistory.ShowDialog();
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseDetails InternationalLicenseDetails = new frmInternationalLicenseDetails(InternationalLicense.InternationalLicenseID);
            InternationalLicenseDetails.ShowDialog();
        }
    }
}
