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
    public partial class frmReplaceLicense : Form
    {
        clsLicense OldLicenseDetails;
        clsLicense ReplacedLicenseDetails;
        clsApplication ApplicationDetails;
        decimal ApplicationFees;
        bool IsForDamaged;
        public frmReplaceLicense()
        {
            InitializeComponent();

            rbDamaged.Checked = true;
            IsForDamaged = true;
            ApplicationFees = clsApplication.GetApplicationFees(4);
            lblApplicationFees.Text = ApplicationFees.ToString();
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

            int OldLicenseID = ctrlFindLicense1.LicenseInfo.LicenseID;
                      
            int ReplacementLicenseID = clsLicense.ReplaceLicense(OldLicenseID, IsForDamaged);

            if (ReplacementLicenseID == -1)
            {
                MessageBox.Show("The current license is not active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ReplacementLicenseID == -2)
            {
                MessageBox.Show("Deactivating the previous license failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ReplacementLicenseID == -3)
            {
                MessageBox.Show("Issueing a new license failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Successfully Renewed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OldLicenseDetails = clsLicense.FindLicenseByID(OldLicenseID);
                ReplacedLicenseDetails = clsLicense.FindLicenseByID(ReplacementLicenseID);
                ApplicationDetails = clsApplication.FindApplicationByID(ctrlFindLicense1.LicenseInfo.ApplicationID);
                FillLabels();
                llLicenseInfo.Enabled = true;
            }
        }

        private void FillLabels()
        {
            lblApplicationID.Text = ApplicationDetails.ApplicationID.ToString();
            lblApplicationDate.Text = ApplicationDetails.Date.ToString("dd MMM yyyy");

            lblReplacedID.Text = ReplacedLicenseDetails.LicenseID.ToString();
            lblOldID.Text = OldLicenseDetails.LicenseID.ToString();
            lblCreatedBy.Text = ApplicationDetails.CreatedByUser;
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {            
            if (rbDamaged.Checked)
            {
                ApplicationFees = clsApplication.GetApplicationFees(4);
                IsForDamaged = true;
            } else
            {
                ApplicationFees = clsApplication.GetApplicationFees(3);
                IsForDamaged = false;
            }
            
            lblApplicationFees.Text = ApplicationFees.ToString();
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmLicenseDetails LicenseDetails = new frmLicenseDetails(ReplacedLicenseDetails.local);
            //LicenseDetails.ShowDialog();
        }
    }
}
