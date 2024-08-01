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
    public partial class frmTestAppointment : Form
    {
        clsApplication ApplicationDetails;
        int LDLAppID;
        public frmTestAppointment(int LDLApplicationID)
        {
            InitializeComponent();

            ApplicationDetails = clsApplication.FindLocalDrivingLicenseApplication(LDLApplicationID);
            LDLAppID = LDLApplicationID;

            RefreshData();
            FormatDataGridView();
            FillLabels();
        }
        
        private void RefreshData ()
        {
            dgvAppointments.DataSource = clsTest.GetTestAppointments(LDLAppID, 1);

        }
        private void FormatDataGridView()
        {
            dgvAppointments.Columns["AppointmentID"].HeaderText = "Appointment ID";
            dgvAppointments.Columns["AppointmentDate"].HeaderText = "Appointment Date";
            dgvAppointments.Columns["PaidFees"].HeaderText = "Paid Fees";
            dgvAppointments.Columns["IsLocked"].HeaderText = "Is Locked";

            dgvAppointments.Columns["AppointmentID"].Width = 130;
            dgvAppointments.Columns["AppointmentDate"].Width = 200;
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

            lblPassedTests.Text = $"{clsApplication.PassedTestsCount(LDLAppID).ToString()}/3";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonDetails PersonDetails = new ShowPersonDetails(ApplicationDetails.ApplicantID);
            PersonDetails.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmScheduleTest Appointment = new frmScheduleTest(ApplicationDetails,1);
            Appointment.ShowDialog();
            RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            bool IsLocked = (bool)dgvAppointments.CurrentRow.Cells[3].Value;

            if (IsLocked)
            {
                MessageBox.Show("Person already took this test. This appointment is locked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                frmScheduleTest ScheduleTest = new frmScheduleTest(ApplicationDetails, 1, true, (int)dgvAppointments.CurrentRow.Cells[0].Value);
                ScheduleTest.ShowDialog();
            }
            
        }
    }
}
