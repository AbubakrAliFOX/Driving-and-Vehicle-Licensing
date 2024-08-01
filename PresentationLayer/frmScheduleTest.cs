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
    public partial class frmScheduleTest : Form
    {
        clsApplication ApplicationDetails;

        int LDLApplicationID;
        int TestTypeID;
        decimal TestFees;
        bool IsEditMode = false;
        int AppointmentID;

        public frmScheduleTest(clsApplication Application, int TestType, bool EditMode = false, int Appointment = 0)
        {
            InitializeComponent();

            ApplicationDetails = Application;

            LDLApplicationID = Application.LocalDrivingLicenseApplicationID;
            TestTypeID = TestType;
            TestFees = clsTest.GetTestFees(TestTypeID);

            IsEditMode = EditMode;
            AppointmentID = Appointment;

            FillLabels();

        }

        private void FillLabels()
        {
            lblDLAppID.Text = LDLApplicationID.ToString();
            lblApplicationID.Text = ApplicationDetails.ApplicationID.ToString();

            lblClass.Text = ApplicationDetails.LicenseClassName;

            lblApplicantName.Text = ApplicationDetails.ApplicantName;

            lblFees.Text = TestFees.ToString();

            dtpTestDate.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsEditMode)
            {
                if (clsTest.CreateTestAppointment(TestTypeID, LDLApplicationID, dtpTestDate.Value, TestFees) != -1)
                {
                    MessageBox.Show("Appointment Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Creating Appointment Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                if (clsTest.UpdateAppointment(AppointmentID,dtpTestDate.Value))
                {
                    MessageBox.Show("Rescheduling Was Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rescheduling Appointment Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {

        }
    }
}
