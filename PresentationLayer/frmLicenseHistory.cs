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
        public frmLicenseHistory(string NationalNo)
        {
            InitializeComponent();

            clsPerson PersonDetails = clsPerson.FindByNationalNo(NationalNo);
            ctrlPersonCard1.PersonInfo = PersonDetails;

            dgvLocalLicenses.DataSource = clsLicense.GetAllPersonLicenses(NationalNo);
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
