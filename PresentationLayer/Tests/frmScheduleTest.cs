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
        clsLocalDrivingLicensApplication LocalApplicationDetails;
        int TestTypeID;
        decimal TestFees;

        private int RetakeTestApplicationID = 0;

        string[] TestTypeName = new string[] { "Vision", "Written", "Field" };

        public frmScheduleTest(clsLocalDrivingLicensApplication LocalApplication, int TestType)
        {
            InitializeComponent();

            LocalApplicationDetails = LocalApplication;

            TestTypeID = TestType;
            lblTitle.Text = $"Schedule {TestTypeName[TestTypeID - 1]} Test";
            TestFees = clsTest.GetTestFees(TestTypeID);

        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            FillLabels();
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


        private bool _IsRetakeTest = false;
        private decimal _RetestFee = 0;

        public bool IsRetakeTest
        {
            get { return _IsRetakeTest;}

            set
            {
                _IsRetakeTest = value;

                if(_IsRetakeTest == true)
                {
                    _RetestFee = clsApplication.GetApplicationFees(7);
                }
            }
        }
        private void FillLabels()
        {
            lblDLAppID.Text = LocalApplicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationID.Text = LocalApplicationDetails.Application.ApplicationID.ToString();

            lblClass.Text = LocalApplicationDetails.LicenseClassName;

            lblApplicantName.Text = LocalApplicationDetails.Application.ApplicantName;

            lblFees.Text = TestFees.ToString();

            dtpTestDate.Value = DateTime.Now;

            if(IsEditMode)
            {
                btnSave.Text = "Reschedule Test";
                lblTitle.Text = $"Reschedule {TestTypeName[TestTypeID - 1]} Test";

            }

            if (IsRetakeTest)
            {
                gbRetakeTestInfo.Enabled = true;
                lblRetakeTestFees.Text = _RetestFee.ToString();

                if(RetakeTestApplicationID == 0)
                {
                    lblRetakeTestID.Text = "??";
                } else
                {
                    lblRetakeTestID.Text = RetakeTestApplicationID.ToString();
                }

            } 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsEditMode)
            {
                if(IsRetakeTest)
                {
                    RetakeTestApplicationID = clsApplication.CreateApplication(LocalApplicationDetails.Application.ApplicantID, 7, clsGlobal.LoggedInUser.UserID);
                }

                int CreatedAppointmentID = clsTest.CreateTestAppointment(
                    TestTypeID, 
                    LocalApplicationDetails.LocalDrivingLicenseApplicationID, 
                    dtpTestDate.Value, 
                    TestFees,
                    RetakeTestApplicationID,
                    clsGlobal.LoggedInUser.UserID
                );

                if (CreatedAppointmentID != -1)
                {
                    MessageBox.Show("Appointment Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsEditMode = true;
                    AppointmentID = CreatedAppointmentID;
                    FillLabels();
                }
                else
                {
                    MessageBox.Show("Creating Appointment Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else
            {
                if (clsTest.UpdateAppointment(AppointmentID, dtpTestDate.Value))
                {
                    MessageBox.Show("Rescheduling Was Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rescheduling Appointment Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //this.Close();
        }

    }
}
