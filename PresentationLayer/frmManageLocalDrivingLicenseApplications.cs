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
    public partial class frmManageLocalDrivingLicenseApplications : Form
    {
        ctrlDataPage LocalLicenseApplicationsPage;
        public frmManageLocalDrivingLicenseApplications()
        {
            
            InitializeComponent();

            LocalLicenseApplicationsPage = new ctrlDataPage();

            LocalLicenseApplicationsPage.Title = "LocalDrivingLicenses";
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
                dgv.Columns["DrivingClass"].HeaderText = "Driving Class";
                dgv.Columns["NationalNo"].HeaderText = "National No";
                dgv.Columns["FullName"].HeaderText = "Full Name";
                dgv.Columns["ApplicationDate"].HeaderText = "Application Date";
                dgv.Columns["ApplicationStatus"].HeaderText = "Application Status";

                dgv.Columns["L.D.L.AppID"].Width = 60;
                dgv.Columns["DrivingClass"].Width = 200;
                dgv.Columns["NationalNo"].Width = 100;
                dgv.Columns["FullName"].Width = 330;
                dgv.Columns["ApplicationDate"].Width = 120;
                dgv.Columns["ApplicationStatus"].Width = 120;

                dgv.ContextMenuStrip = cmsLocalLicences;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewApplication_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication NewApplication = new frmNewLocalDrivingLicenseApplication();
            NewApplication.ShowDialog();
            LocalLicenseApplicationsPage.RefreshData();
        }
    }
}
