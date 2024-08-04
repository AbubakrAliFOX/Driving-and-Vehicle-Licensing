﻿using BusinessLayer;
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
            lblLicenseID.Text = InternationalLicense.LocalLicense.LicenseID.ToString();
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

            if (!clsInternationalLicense.HasInternationalLicense(ctrlFindLicense1.LicenseInfo.LicenseID))
            {
                if (!clsLicense.IsLicenseActive(ctrlFindLicense1.LicenseInfo.LicenseID))
                {
                    MessageBox.Show("License is inactive!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
                    InternationalLicense = clsInternationalLicense.FindInternationalLicenseByLocalLicenseID(ctrlFindLicense1.LicenseInfo.LicenseID);
                    FillLabels();
                    llLicenseInfo.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Driver already has an international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(InternationalLicense.LocalLicense.PersonID);
            LicenseHistory.ShowDialog();
        }
    }
}
