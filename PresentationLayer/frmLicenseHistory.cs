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
    public partial class frmLicenseHistory : Form
    {
        clsPerson PersonDetails;
        public frmLicenseHistory(string NationalNo)
        {
            InitializeComponent();

            PersonDetails = clsPerson.FindByNationalNo(NationalNo);
        }
        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();

            PersonDetails = clsPerson.Find(PersonID);
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.PersonInfo = PersonDetails;

            dgvLocalLicenses.DataSource = clsLicense.GetAllPersonLicenses(PersonDetails.nationalNumber);
            dgvInternationalLicenses.DataSource = clsInternationalLicense.GetAllPersonLicenses(PersonDetails.nationalNumber);
            FormatLayout();
        }

        private void FormatLayout()
        {
            if (dgvLocalLicenses != null)
            {
                dgvLocalLicenses.RowHeadersWidth = 20;
                dgvLocalLicenses.Columns["LicenseID"].HeaderText = "Lic.ID";
                dgvLocalLicenses.Columns["ApplicationID"].HeaderText = "App.ID";
                dgvLocalLicenses.Columns["ClassName"].HeaderText = "Class Name";
                dgvLocalLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns["IsActive"].HeaderText = "Active";

                dgvLocalLicenses.Columns["LicenseID"].Width = 60;
                dgvLocalLicenses.Columns["ApplicationID"].Width = 60;
                dgvLocalLicenses.Columns["ClassName"].Width = 240;
                dgvLocalLicenses.Columns["IssueDate"].Width = 160;
                dgvLocalLicenses.Columns["ExpirationDate"].Width = 160;
                dgvLocalLicenses.Columns["IsActive"].Width = 60;
            }

            if (dgvInternationalLicenses != null)
            {
                dgvInternationalLicenses.RowHeadersWidth = 20;
                dgvInternationalLicenses.Columns["InternationalLicenseID"].HeaderText = "International Lic.ID";
                dgvInternationalLicenses.Columns["LocalLicenseID"].HeaderText = "Local Lic.ID";
                dgvInternationalLicenses.Columns["ApplicationID"].HeaderText = "App.ID";
                dgvInternationalLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns["IsActive"].HeaderText = "Active";

                dgvInternationalLicenses.Columns["InternationalLicenseID"].Width = 130;
                dgvInternationalLicenses.Columns["LocalLicenseID"].Width = 130;
                dgvInternationalLicenses.Columns["ApplicationID"].Width = 100;
                dgvInternationalLicenses.Columns["IssueDate"].Width = 160;
                dgvInternationalLicenses.Columns["ExpirationDate"].Width = 160;
                dgvInternationalLicenses.Columns["IsActive"].Width = 60;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            clsInternationalLicense InternationalLicenseDetails = clsInternationalLicense.FindInternationalLicenseByLocalLicenseID((int)dgvInternationalLicenses.CurrentRow.Cells[1].Value);
            frmInternationalLicenseDetails InternationalLicenseForm = new frmInternationalLicenseDetails(InternationalLicenseDetails.InternationalLicenseID, InternationalLicenseDetails.LocalLicense.LicenseID);
            InternationalLicenseForm.ShowDialog();
        }

        private void cmsLocalLicenceDetails_Opening(object sender, CancelEventArgs e)
        {
            //clsLicense LocalLicense = clsLicense.FindLicenseByID((int)dgvLocalLicenses.CurrentRow.Cells[0].Value);
            //clsApplication ApplicationDetails = clsApplication.
            //frmLicenseDetails LicenseDetails = new frmLicenseDetails(LocalLicense.)
        }
    }
}
