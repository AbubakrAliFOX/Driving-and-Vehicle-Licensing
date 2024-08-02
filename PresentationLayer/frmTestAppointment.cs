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
        int TestTypeID;
        string[] TestTypeName = new string[] {"Vision", "Written", "Field"};
        public frmTestAppointment(int LDLApplicationID, int TestType)
        {
            InitializeComponent();

            ApplicationDetails = clsApplication.FindLocalDrivingLicenseApplication(LDLApplicationID);
            LDLAppID = LDLApplicationID;
            TestTypeID = TestType;
            lblTitle.Text = $"{TestTypeName[TestTypeID-1]} Test Appointments";

            ctrlApplicationInfo.ApplicationInfo = ApplicationDetails;
            RefreshData();
            FormatDataGridView();
        }
        
        private void RefreshData ()
        {
            dgvAppointments.DataSource = clsTest.GetTestAppointments(LDLAppID, TestTypeID);

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
            if(!clsTest.IsAppointmentActiveForTest(LDLAppID, TestTypeID))
            {
                if (clsTest.HasApplicantPassedTest(LDLAppID, TestTypeID))
                {
                    MessageBox.Show("Person already has passed this test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Implement retake test fee later
                    frmScheduleTest Appointment;

                    if (clsTest.HasApplicantFailedTest(LDLAppID, TestTypeID))
                    {
                        Appointment = new frmScheduleTest(ApplicationDetails, TestTypeID);
                    }
                    else
                    {
                        Appointment = new frmScheduleTest(ApplicationDetails, TestTypeID);
                    }

                    Appointment.ShowDialog();
                    RefreshData();

                }
                
                
            } else
            {
                MessageBox.Show("Person already has an active test.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                frmScheduleTest ScheduleTest = new frmScheduleTest(ApplicationDetails, TestTypeID);

                ScheduleTest.IsEditMode = true;
                ScheduleTest.AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

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
                frmTakeTest TakeTest = new frmTakeTest(ApplicationDetails, (int)dgvAppointments.CurrentRow.Cells[0].Value);
                TakeTest.ShowDialog();
                RefreshData();
            }

        }
    }
}
