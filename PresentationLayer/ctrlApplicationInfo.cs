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
    public partial class ctrlApplicationInfo : UserControl
    {
        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }

        clsApplication ApplicationDetails;
        public clsApplication ApplicationInfo
        {
            set
            {
                ApplicationDetails = value;
                if (ApplicationDetails != null)
                {
                    FillLabels();
                }
            }

            get { return ApplicationDetails; }
        }

        private void FillLabels()
        {
            lblDLAppID.Text = ApplicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationID.Text = ApplicationDetails.ApplicationID.ToString();

            lblClass.Text = ApplicationDetails.LicenseClassName;
            lblType.Text = ApplicationDetails.ApplicationType;
            lblStatus.Text = ApplicationDetails.ApplicationStatus;
            lblFees.Text = ApplicationDetails.Fees.ToString();
            lblApplicantName.Text = ApplicationDetails.ApplicantName;

            lblDate.Text = ApplicationDetails.Date.ToString("dd MMM yyyy");
            lblStatusDate.Text = ApplicationDetails.StatusDate.ToString("dd MMM yyyy");

            lblUser.Text = ApplicationDetails.CreatedByUser;

            lblPassedTests.Text = $"{clsApplication.PassedTestsCount(ApplicationDetails.LocalDrivingLicenseApplicationID).ToString()}/3";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonDetails PersonDetails = new ShowPersonDetails(ApplicationDetails.ApplicantID);
            PersonDetails.ShowDialog();
        }
    }
}
