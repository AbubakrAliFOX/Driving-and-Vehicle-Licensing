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
    public partial class ctrlDriverLicense : UserControl
    {
        private clsLicense LicenseDetails;
        
        public ctrlDriverLicense()
        {
            InitializeComponent();
        }

        public clsLicense LicenseInfo
        {
            get {  return LicenseDetails; }

            set
            {
                LicenseDetails = value;

                if (LicenseDetails != null)
                {
                    FillLabels();
                }
            }
        }

        private void FillLabels()
        {
            //License Details
            lblLicenseID.Text = LicenseDetails.LicenseID.ToString();
            lblClass.Text = LicenseDetails.LicenseClassName.ToString();
            lblIssueDate.Text = LicenseDetails.IssueDate.ToString("dd MMM yyyy");
            lblExpirationDate.Text = LicenseDetails.ExpirationDate.ToString("dd MMM yyyy");
            lblNotes.Text = LicenseDetails.IssueNotes;
            lblDriverID.Text = LicenseDetails.DriverID.ToString();

            if (LicenseDetails.IsActive == true)
            {
                lblIsActive.Text = "Yes";
            }
            else
            {
                lblIsActive.Text = "No";
            }

            if (LicenseDetails.IsDetained == true)
            {
                lblIsDetained.Text = "Yes";
            }
            else
            {
                lblIsDetained.Text = "No";
            }

            if (LicenseDetails.IssueReason == 1)
            {
                lblIssueReason.Text = "First Time";
            }
            else if (LicenseDetails.IssueReason == 2)
            {
                lblIssueReason.Text = "Renew";
            }
            else if (LicenseDetails.IssueReason == 3)
            {
                lblIssueReason.Text = "Replaced For Damaged";
            }
            else if (LicenseDetails.IssueReason == 4)
            {
                lblIssueReason.Text = "Replaced For Lost";
            }

            // Person Details
            lblNationalNo.Text = LicenseDetails.PersonInfo.NationalNumber;
            lblGender.Text = LicenseDetails.PersonInfo.Gender.ToString();
            lblDOB.Text = LicenseDetails.PersonInfo.DateOfBirth.ToString("dd MMM yyyy");

            if (LicenseDetails.PersonInfo.ImagePath != "")
            {
                pbPersonPhoto.Image = Image.FromFile(clsUtils.GetProfileImage(LicenseDetails.PersonInfo.ImagePath));
            }
            else
            {
                pbPersonPhoto.Image = Properties.Resources.user1;

            }
        }
    }
}
