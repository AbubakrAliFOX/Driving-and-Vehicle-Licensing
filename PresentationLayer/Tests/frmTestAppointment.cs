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
        clsLocalDrivingLicensApplication LocalApplicationDetails;
        clsTest TestDetails;

        public frmTestAppointment(int LDLApplicationID, int TestTypeID)
        {
            InitializeComponent();

            LocalApplicationDetails = clsLocalDrivingLicensApplication.FindLocalDrivingLicenseApplicationByID(LDLApplicationID);
            TestDetails = new clsTest(TestTypeID);
            lblTitle.Text = $"{TestDetails.TestName} Test Appointments";

            ctrlApplicationInfo.LocalApplicationInfo = LocalApplicationDetails;
            RefreshData();
            FormatDataGridView();
        }
        
        private void RefreshData ()
        {
            dgvAppointments.DataSource = clsTestAppointment.GetTestAppointments(LocalApplicationDetails.LocalDrivingLicenseApplicationID, TestDetails.TestTypeID);
        }

        private void FormatDataGridView()
        {
            if (dgvAppointments.Rows.Count != 0)
            {
                dgvAppointments.Columns["AppointmentID"].HeaderText = "Appointment ID";
                dgvAppointments.Columns["AppointmentDate"].HeaderText = "Appointment Date";
                dgvAppointments.Columns["PaidFees"].HeaderText = "Paid Fees";
                dgvAppointments.Columns["IsLocked"].HeaderText = "Is Locked";

                dgvAppointments.Columns["AppointmentID"].Width = 130;
                dgvAppointments.Columns["AppointmentDate"].Width = 200;

                lblRecordsNumber.Text = dgvAppointments.Rows.Count.ToString();
            }

        }

        private bool IsAppointmentLocked ()
        {
            return (bool)dgvAppointments.CurrentRow.Cells[3].Value;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(!clsTestAppointment.IsAppointmentActiveForTest(LocalApplicationDetails.LocalDrivingLicenseApplicationID, TestDetails.TestTypeID))
            {
                // 1: Passed, 0: Not Taken Test, -1: Failed
                int PreviousTestResult = clsTestAppointment.ApplicationPreviousTestResult(LocalApplicationDetails.LocalDrivingLicenseApplicationID, TestDetails.TestTypeID);
                
                if (PreviousTestResult == 1)
                {
                    MessageBox.Show("Person already has passed this test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                frmScheduleTest Appointment = new frmScheduleTest(LocalApplicationDetails.LocalDrivingLicenseApplicationID, TestDetails.TestTypeID);
                Appointment.ShowDialog();

            } else
            {
                MessageBox.Show("Person already has an active test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            if (IsAppointmentLocked())
            {
                MessageBox.Show("Person already took this test. This appointment is locked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
                frmScheduleTest ScheduleTest = new frmScheduleTest(AppointmentID);
                ScheduleTest.ShowDialog();

                RefreshData();
                FormatDataGridView();
            }
            
        }

        private void tsmTakeTest_Click(object sender, EventArgs e)
        {
            if (IsAppointmentLocked())
            {
                MessageBox.Show("Person already took this test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                frmTakeTest TakeTest = new frmTakeTest(LocalApplicationDetails, (int)dgvAppointments.CurrentRow.Cells[0].Value);
                TakeTest.ShowDialog();
                RefreshData();
            }

        }
    }
}
