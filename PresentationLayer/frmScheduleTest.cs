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
        clsLocalDrivingLicensApplication LocalApplicationDetails;

        int LDLApplicationID;
        int TestTypeID;
        decimal TestFees;

        string[] TestTypeName = new string[] { "Vision", "Written", "Field" };

        public frmScheduleTest(clsLocalDrivingLicensApplication LocalApplication, int TestType)
        {
            InitializeComponent();

            LocalApplicationDetails = LocalApplication;


            LDLApplicationID = LocalApplication.LocalDrivingLicenseApplicationID;
            TestTypeID = TestType;
            lblTitle.Text = $"Schedule {TestTypeName[TestTypeID - 1]} Test";
            TestFees = clsTest.GetTestFees(TestTypeID);

            FillLabels();
            //IsTestFailed = TestFailed;
            //if(TestFailed)
            //{

            //}
        }

        private bool _IsEditMode = false;

        public bool IsEditMode
        {
            get
            {
                return _IsEditMode;
            }

            set
            {
                _IsEditMode = value;
            }
        }

        private int _AppointmentID;

        public int AppointmentID
        {
            get
            {
                return _AppointmentID;
            }

            set
            {
                _AppointmentID = value;
            }
        }


        private bool _IsTestFailed = false;
        private decimal _RetestFee = 0;

        public bool IsTestFailed
        {
            get { return _IsTestFailed;}

            set
            {
                _IsTestFailed = value;
                _RetestFee = clsApplication.GetApplicationFees(2);
            }
        }
        private void FillLabels()
        {
            lblDLAppID.Text = LDLApplicationID.ToString();
            lblApplicationID.Text = LocalApplicationDetails.Application.ApplicationID.ToString();

            lblClass.Text = LocalApplicationDetails.LicenseClassName;

            lblApplicantName.Text = LocalApplicationDetails.Application.ApplicantName;

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

            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {

        }
    }
}
