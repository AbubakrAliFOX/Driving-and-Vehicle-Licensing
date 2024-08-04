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
        ctrlDataPage LocalLicenseApplicationsPage;
        public frmManageInternationalDrivingLicenseApplications()
        {
            InitializeComponent();

            LocalLicenseApplicationsPage = new ctrlDataPage();

            LocalLicenseApplicationsPage.Title = "International Driving Licenses";
            LocalLicenseApplicationsPage.Location = new System.Drawing.Point(0, 0);
            LocalLicenseApplicationsPage.Visible = true;

            LocalLicenseApplicationsPage.SetAddNewClickEventHandler(AddNewApplication_Click);

            this.Controls.Add(LocalLicenseApplicationsPage);

            FormatLayout();
        }

        private void FormatLayout()
        {
            DataGridView dgv = LocalLicenseApplicationsPage.Controls.OfType<DataGridView>().FirstOrDefault();
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
            LocalLicenseApplicationsPage.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
