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
    public partial class frmLicenseDetails : Form
    {
        clsLicense LicenseDetails;
        clsPerson PersonDetails;
        public frmLicenseDetails(int LDLApplicationID)
        {
            InitializeComponent();

            LicenseDetails = clsLicense.FindLicenseByLocalDrivingLicenseApplicationID(LDLApplicationID);
            PersonDetails = clsPerson.Find(LicenseDetails.PersonID);
            FillLabels();
        }

        private void FillLabels ()
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
            } else
            {
                lblIsActive.Text = "No";
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

            //lblIsDetained.Text = LicenseDetails.deta.ToString();

            // Person Details
            lblNationalNo.Text = PersonDetails.nationalNumber;
            lblGender.Text = PersonDetails.gender == 1 ? "Female" : "Male";
            lblDOB.Text = PersonDetails.dateOfBirth.ToString("dd MMM yyyy");

            if (PersonDetails.imgPath != "")
            {
                pbPersonPhoto.Image = Image.FromFile(PersonDetails.imgPath);
            }
            else
            {
                pbPersonPhoto.Image = Image.FromFile("E:\\Downloads\\WebDev\\Projects\\DVL\\Assets\\user1.png");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
