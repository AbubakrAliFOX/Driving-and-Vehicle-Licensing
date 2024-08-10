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
    public partial class ctrlLDLApplicationInfo : UserControl
    {
        public ctrlLDLApplicationInfo()
        {
            InitializeComponent();
        }

        clsLocalDrivingLicensApplication LocalLicenseApplicationDetails;
        public clsLocalDrivingLicensApplication LocalApplicationInfo
        {
            set
            {
                LocalLicenseApplicationDetails = value;
                if (LocalLicenseApplicationDetails != null)
                {
                    FillLabels();
                }
            }

            get { return LocalLicenseApplicationDetails; }
        }


        private void FillLabels()
        {
            lblDLAppID.Text = LocalLicenseApplicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationID.Text = LocalLicenseApplicationDetails.Application.ApplicationID.ToString();

            lblClass.Text = LocalLicenseApplicationDetails.LicenseClassName;
            lblType.Text = LocalLicenseApplicationDetails.Application.ApplicationType;
            lblStatus.Text = LocalLicenseApplicationDetails.Application.ApplicationStatus;
            lblFees.Text = LocalLicenseApplicationDetails.Application.Fees.ToString();
            lblApplicantName.Text = LocalLicenseApplicationDetails.Application.ApplicantName;

            lblDate.Text = LocalLicenseApplicationDetails.Application.Date.ToString("dd MMM yyyy");
            lblStatusDate.Text = LocalLicenseApplicationDetails.Application.StatusDate.ToString("dd MMM yyyy");

            lblUser.Text = LocalLicenseApplicationDetails.Application.CreatedByUser;

            lblPassedTests.Text = $"{clsTest.PassedTestsCount(LocalLicenseApplicationDetails.LocalDrivingLicenseApplicationID).ToString()}/3";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails PersonDetails = new frmPersonDetails(LocalLicenseApplicationDetails.Application.ApplicantID);
            PersonDetails.ShowDialog();
        }
    }
}
