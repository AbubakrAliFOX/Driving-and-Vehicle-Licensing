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
    public partial class frmDetainLicense : Form
    {
        clsDetain DetainDetails;
        public frmDetainLicense()
        {
            InitializeComponent();

            tbFine.Text = "50";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (ctrlFindLicense1.LicenseInfo == null)
            {
                MessageBox.Show("Select a License First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int DetainID = clsDetain.DetainLicense(ctrlFindLicense1.LicenseInfo.LicenseID, decimal.Parse(tbFine.Text));

            if (DetainID == -2)
            {
                MessageBox.Show("License is already detained!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DetainID == -1)
            {
                MessageBox.Show("License detain failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Successfully Detained!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DetainDetails = clsDetain.FindDetainByLicenseID(ctrlFindLicense1.LicenseInfo.LicenseID);
                FillLabels();
            }
        }
        private void FillLabels()
        {
            lblDetainID.Text = DetainDetails.DetainID.ToString();
            lblDetainDate.Text = DetainDetails.DetainDate.ToString("dd MMM yyyy");

            lblLicenseID.Text = DetainDetails.LicenseID.ToString();
            lblCreatedBy.Text = DetainDetails.CreatedByUser;
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseDetails License = new frmLicenseDetails(DetainDetails.LicenseID);
            License.ShowDialog();
        }
    }
}
