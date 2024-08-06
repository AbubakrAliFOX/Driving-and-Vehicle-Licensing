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
    public partial class frmReleaseLicense : Form
    {
        clsDetain DetainDetails;
        int ApplicationID;

        public frmReleaseLicense()
        {
            InitializeComponent();

            ctrlFindLicense1.SetSearchEventHandlerOnClick(FillDetainLabels_Click);
        }

        public frmReleaseLicense(int LicenseID)
        {
            InitializeComponent();

            ctrlFindLicense1.OnlyForLicense = LicenseID;
            ctrlFindLicense1.SetSearchEventHandlerOnLoad(FillDetainLabels_Click);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ctrlFindLicense1.LicenseInfo == null)
            {
                MessageBox.Show("Select a License First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmLicenseHistory LicenseHistory = new frmLicenseHistory(ctrlFindLicense1.LicenseInfo.PersonID);
            LicenseHistory.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (ctrlFindLicense1.LicenseInfo == null)
            {
                MessageBox.Show("Select a License First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //..int DetainID = clsDetain.ReleaseLicense(ctrlFindLicense1.LicenseInfo.LicenseID);

            ApplicationID = clsDetain.ReleaseLicense(ctrlFindLicense1.LicenseInfo.LicenseID);

            if (ApplicationID == -1)
            {
                MessageBox.Show("License is not detained!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ApplicationID == -2)
            {
                MessageBox.Show("License release failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Successfully Released!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetApplicationLabels();
                FillApplicationLabels();
                llLicenseInfo.Enabled = true;
            }
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseDetails License = new frmLicenseDetails(ctrlFindLicense1.LicenseInfo.LicenseID);
            License.ShowDialog();
        }

        private void FillDetainLabels_Click(object sender, EventArgs e)
        {
            ResetDetainLabels();
            ResetApplicationLabels();
            if (ctrlFindLicense1.LicenseInfo  != null)
            {
                int LicenseID = ctrlFindLicense1.LicenseInfo.LicenseID;
                if (clsDetain.IsLicenseDetained(LicenseID))
                {
                    DetainDetails = clsDetain.FindDetainByLicenseID(LicenseID);
                    FillDetainLabels();
                }
            }
        }

        private void FillDetainLabels()
        {
            lblDetainID.Text = DetainDetails.DetainID.ToString();
            lblDetainDate.Text = DetainDetails.DetainDate.ToString("dd MMM yyyy");

            decimal FineFees = DetainDetails.FineFees;
            decimal ApplicationFees = clsApplication.GetApplicationFees(5);
            decimal TotalFees = FineFees + ApplicationFees;

            lblFineFees.Text = FineFees.ToString();
            lblApplicationFees.Text = ApplicationFees.ToString();
            lblTotalFees.Text = TotalFees.ToString();

            lblLicenseID.Text = DetainDetails.LicenseID.ToString();
            lblCreatedBy.Text = DetainDetails.CreatedByUser;
        }

        private void ResetDetainLabels()
        {
            lblDetainID.Text = "";
            lblDetainDate.Text = "";

            lblFineFees.Text = "";
            lblApplicationFees.Text = "";
            lblTotalFees.Text = "";

            lblLicenseID.Text = "";
            lblCreatedBy.Text = "";
        }

        private void FillApplicationLabels()
        {
            lblApplicationID.Text = ApplicationID.ToString();
        }

        private void ResetApplicationLabels()
        {
            lblApplicationID.Text = "";
        }

    }
}
