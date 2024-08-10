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
    public partial class frmManageInternationalDrivingLicenseApplications : Form
    {
        clsInternationalLicense InternationalLicenseDetails;
        public frmManageInternationalDrivingLicenseApplications()
        {
            InitializeComponent();
        }
        private void frmManageInternationalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            InternationalLicenseApplicationsPage.SetAddNewClickEventHandler(AddNewApplication_Click);
            FormatLayout();
        }

        private void FormatLayout()
        {
            DataGridView dgv = InternationalLicenseApplicationsPage.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv != null)
            {
                dgv.Columns["Int.LicenseID"].HeaderText = "Int.License ID";
                dgv.Columns["L.LicenseID"].HeaderText = "L.License ID";
                dgv.Columns["ApplicationID"].HeaderText = "Application ID";
                dgv.Columns["DriverID"].HeaderText = "Driver ID";
                dgv.Columns["IssueDate"].HeaderText = "Issue Date";
                dgv.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgv.Columns["IsActive"].HeaderText = "Is Active";

                dgv.Columns["Int.LicenseID"].Width = 130;
                dgv.Columns["L.LicenseID"].Width = 130;
                dgv.Columns["ApplicationID"].Width = 120;
                dgv.Columns["DriverID"].Width = 120;
                dgv.Columns["IssueDate"].Width = 160;
                dgv.Columns["ExpirationDate"].Width = 160;
                dgv.Columns["IsActive"].Width = 100;

                dgv.ContextMenuStrip = cmsInternationalLicences;
            }
        }

        private void AddNewApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalDrivingLicenseApplication NewApplication = new frmNewInternationalDrivingLicenseApplication();
            NewApplication.ShowDialog();
            InternationalLicenseApplicationsPage.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowPersonDetails_Click(object sender, EventArgs e)
        {
            InternationalLicenseDetails = clsInternationalLicense.FindInternationalLicenseByLocalLicenseID((int)InternationalLicenseApplicationsPage.dgv.CurrentRow.Cells[1].Value);
            
            frmPersonDetails PersonDetails = new frmPersonDetails(InternationalLicenseDetails.LocalLicenseInfo.PersonInfo.ID);
            PersonDetails.ShowDialog();
        }

        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            InternationalLicenseDetails = clsInternationalLicense.FindInternationalLicenseByLocalLicenseID((int)InternationalLicenseApplicationsPage.dgv.CurrentRow.Cells[1].Value);
            
            frmInternationalLicenseDetails InternationalLicenseForm = new frmInternationalLicenseDetails(InternationalLicenseDetails.InternationalLicenseID);
            InternationalLicenseForm.ShowDialog();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            InternationalLicenseDetails = clsInternationalLicense.FindInternationalLicenseByLocalLicenseID((int)InternationalLicenseApplicationsPage.dgv.CurrentRow.Cells[1].Value);
            
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(InternationalLicenseDetails.LocalLicenseInfo.PersonInfo.ID);
            LicenseHistory.ShowDialog();
        }
    }
}
