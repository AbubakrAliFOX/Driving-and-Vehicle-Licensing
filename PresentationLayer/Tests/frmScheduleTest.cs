using BusinessLayer;
using PresentationLayer.Global_Classes;
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
    public partial class frmScheduleTest : Form
    {
        clsTestAppointment TestAppointmentDetails;
        
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _CurrentMode;

        public frmScheduleTest(int LDLApplicationID, int TestType)
        {
            InitializeComponent();

            TestAppointmentDetails = new clsTestAppointment(LDLApplicationID, TestType, clsGlobal.LoggedInUser.UserID);
            _CurrentMode = enMode.AddNew;
        }

        public frmScheduleTest(int TestAppointmentID)
        {
            InitializeComponent();

            TestAppointmentDetails = clsTestAppointment.FindTestAppointmentByID(TestAppointmentID);

            _CurrentMode = enMode.Update;
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            FillLabels();
        }
        
        private void FillLabels()
        {
            lblTitle.Text = $"Schedule {TestAppointmentDetails.TestDetails.TestName} Test";

            dtpTestDate.MaxDate = DateTime.Now.AddDays(20);
            dtpTestDate.MinDate = DateTime.Now;

            lblDLAppID.Text = TestAppointmentDetails.LDLApplicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationID.Text = TestAppointmentDetails.LDLApplicationDetails.Application.ApplicationID.ToString();

            lblClass.Text = TestAppointmentDetails.LDLApplicationDetails.LicenseClassName;

            lblApplicantName.Text = TestAppointmentDetails.LDLApplicationDetails.Application.ApplicantName;

            lblAttempt.Text = (TestAppointmentDetails.Attempts + 1).ToString();

            if (_CurrentMode == enMode.Update)
            {
                lblAppointmentID.Text = TestAppointmentDetails.TestAppointmentID.ToString();

                lblFeesDisplay.Text = "Paid Fees:";
                lblFees.Text = TestAppointmentDetails.PaidFees.ToString();

                btnSave.Text = "Reschedule Test";
                lblTitle.Text = $"Reschedule {TestAppointmentDetails.TestDetails.TestName} Test";
                dtpTestDate.Value = TestAppointmentDetails.TestAppointmentDate;
            } else
            {
                lblFeesDisplay.Text = "Fees:";
                lblFees.Text = TestAppointmentDetails.TestDetails.TestFees.ToString();
                dtpTestDate.Value = DateTime.Now;
            }

            if (TestAppointmentDetails.Attempts > 0)
            {
                gbRetakeTestInfo.Enabled = true;

                decimal RetakeTestApplicationFees;
                string RetestDisplayLabel;

                if (_CurrentMode == enMode.Update)
                {
                    lblRetakeTestID.Text = TestAppointmentDetails.RetakeTestApplication.ApplicationID.ToString();

                    RetestDisplayLabel = "Paid Fees:";
                    RetakeTestApplicationFees = TestAppointmentDetails.RetakeTestApplication.PaidFees;
                } else
                {
                    RetestDisplayLabel = "Retest Fees:";
                    RetakeTestApplicationFees = TestAppointmentDetails.RetakeTestApplication.ApplicationTypeFees;
                }

                lblRetestDisplay.Text = RetestDisplayLabel;
                lblRetakeTestFees.Text = RetakeTestApplicationFees.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TestAppointmentDetails.TestAppointmentDate = dtpTestDate.Value;
            TestAppointmentDetails.PaidFees = Convert.ToDecimal(lblFees.Text);

            int AppointmentID = TestAppointmentDetails.Save(clsGlobal.LoggedInUser.UserID);

            if (AppointmentID != -1)
            {
                if (_CurrentMode == enMode.AddNew)
                {
                    MessageBox.Show("Appointment Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _CurrentMode = enMode.Update;
                    TestAppointmentDetails = clsTestAppointment.FindTestAppointmentByID(AppointmentID);
                    FillLabels();
                } else
                {
                    MessageBox.Show("Rescheduling Was Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            else
            {
                if (_CurrentMode == enMode.AddNew)
                {
                    MessageBox.Show("Creating Appointment Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Rescheduling Appointment Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}