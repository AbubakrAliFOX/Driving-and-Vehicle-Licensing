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

        private void tsmScheduleVisionTest_Click(object sender, EventArgs e)
        {
            frmTestAppointment TestAppointment = new frmTestAppointment((int)LocalLicenseApplicationsPage.dgv.CurrentRow.Cells[0].Value, 1);
            TestAppointment.ShowDialog();
            LocalLicenseApplicationsPage.RefreshData();
        }

        private void tsmScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            frmTestAppointment TestAppointment = new frmTestAppointment((int)LocalLicenseApplicationsPage.dgv.CurrentRow.Cells[0].Value, 2);
            TestAppointment.ShowDialog();
            LocalLicenseApplicationsPage.RefreshData();

        }

        private void tsmScheduleStreetTest_Click(object sender, EventArgs e)
        {
            frmTestAppointment TestAppointment = new frmTestAppointment((int)LocalLicenseApplicationsPage.dgv.CurrentRow.Cells[0].Value, 3);
            TestAppointment.ShowDialog();
            LocalLicenseApplicationsPage.RefreshData();

        }

        private void cmsLocalLicences_Opened(object sender, EventArgs e)
        {
            int PassedTests = (int)LocalLicenseApplicationsPage.dgv.CurrentRow.Cells[4].Value;
            string ApplicationStatus = (string)LocalLicenseApplicationsPage.dgv.CurrentRow.Cells[6].Value;

            if(ApplicationStatus == "New")
            {
                if (PassedTests == 0)
                {
                    tsmScheduleVisionTest.Enabled = true;
                }
                else if (PassedTests == 1)
                {
                    tsmScheduleWrittenTest.Enabled = true;
                }
                else if (PassedTests == 2)
                {
                    tsmScheduleStreetTest.Enabled = true;
                }
                else if (PassedTests == 3)
                {
                    tsmScheduleTests.Enabled = false;

                    tsmIssueDrivingLicenseFirstTime.Enabled = true;
                }
            }


            
        }

        private void cmsLocalLicences_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            tsmScheduleTests.Enabled = true;

            tsmScheduleVisionTest.Enabled = false;
            tsmScheduleWrittenTest.Enabled = false;
            tsmScheduleStreetTest.Enabled = false;

            tsmIssueDrivingLicenseFirstTime.Enabled = false;
        }

        private void tsmIssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
            frmIssueLocalLicense IssueLicense = new frmIssueLocalLicense((int)LocalLicenseApplicationsPage.dgv.CurrentRow.Cells[0].Value);
            IssueLicense.ShowDialog();
            LocalLicenseApplicationsPage.RefreshData();
        }
    }
}
