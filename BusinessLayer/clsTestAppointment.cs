using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTestAppointment
    {
        public int TestAppointmentID { set; get; }
        public clsLocalDrivingLicensApplication LDLApplicationDetails { set; get; }
        public clsApplication RetakeTestApplication { set; get; }
        public clsTest TestDetails{ set; get; }
        public int Attempts { set; get; }
        public decimal PaidFees { set; get; }
        public DateTime TestAppointmentDate { set; get; }
        public enum enMode { AddNew = 0, Update };
        public enMode Mode;

        public clsTestAppointment(int LDLApplicationID, int TestTypeID, int CreatedByUserID)
        {
            this.LDLApplicationDetails = clsLocalDrivingLicensApplication.FindLocalDrivingLicenseApplicationByID(LDLApplicationID);
            this.TestDetails = new clsTest(TestTypeID);
            this.Attempts = GetTestAttempts(LDLApplicationID, TestTypeID);

            if (Attempts > 0)
            {
                int RetakeTestApplicationID = clsApplication.CreateApplication(LDLApplicationDetails.Application.ApplicantID, 7, CreatedByUserID);
                this.RetakeTestApplication = clsApplication.FindApplicationByID(RetakeTestApplicationID);
            }
            Mode = enMode.AddNew;
        }

        public clsTestAppointment(
            int TestAppointmentID,
            int LDLApplicationID,
            int RetakeTestApplicationID,
            int TestTypeID,
            int Attempts,
            DateTime TestAppointmentDate,
            decimal PaidFees
        )
        {
            this.TestAppointmentID = TestAppointmentID;
            this.LDLApplicationDetails = clsLocalDrivingLicensApplication.FindLocalDrivingLicenseApplicationByID(LDLApplicationID);
            this.RetakeTestApplication = clsApplication.FindApplicationByID(RetakeTestApplicationID);
            this.TestDetails = new clsTest(TestTypeID);
            this.Attempts = Attempts;
            this.TestAppointmentDate = TestAppointmentDate;
            this.PaidFees = PaidFees;
            Mode = enMode.Update;
        }

        public static clsTestAppointment FindTestAppointmentByID(int TestAppointmentID)
        {
            int LDLApplicationID = -1;
            int TestTypeID = -1;
            int Attempts = -1;
            DateTime TestAppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            int RetakeTestApplicationID = -1;

            if (
                clsTestAppointmentsDataAccess.FindTestAppointmentByID(
                    TestAppointmentID,
                    ref LDLApplicationID,
                    ref TestTypeID,
                    ref Attempts,
                    ref RetakeTestApplicationID,
                    ref TestAppointmentDate,
                    ref PaidFees
                )
            )
            {
                return new clsTestAppointment(
                    TestAppointmentID,
                    LDLApplicationID,
                    RetakeTestApplicationID,
                    TestTypeID,
                    Attempts,
                    TestAppointmentDate,
                    PaidFees
                );
            }
            else
            {
                return null;
            }
        }

        private int GetTestAttempts(int LDLApplicationID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.TestAttempts(LDLApplicationID, TestTypeID);
        }

        private int CreateTestAppointment(int CreatedByUserID)
        {
            return clsTestAppointmentsDataAccess.CreateTestAppointment(
                this.TestDetails.TestTypeID,
                this.LDLApplicationDetails.LocalDrivingLicenseApplicationID,
                this.TestAppointmentDate,
                this.PaidFees,
                this.RetakeTestApplication != null ? this.RetakeTestApplication.ApplicationID : -1,
                CreatedByUserID
            ); 
        }

        private int UpdateTestAppointment()
        {
            if (clsTestAppointmentsDataAccess.UpdateAppointment(this.TestAppointmentID, this.TestAppointmentDate))
            {
                return 1;
            } else
            {
                return -1;
            }
        }

        public int Save(int CreatedByUserID)
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    int AppointmentID = CreateTestAppointment(CreatedByUserID);
                    if (AppointmentID != -1)
                    {
                        Mode = enMode.Update;
                        return AppointmentID;
                    }
                    else
                    {
                        return -1;
                    }
                case enMode.Update:
                    return UpdateTestAppointment();

            }
            return -1;
        }

        public static DataTable GetTestAppointments(int LDLApplicationID, int TestType)
        {
            return clsTestAppointmentsDataAccess.GetTestAppointments(LDLApplicationID, TestType);
        }

        public static int TakeTest(int AppointmentID, byte Result, int CreatedByUserID, string Notes = null)
        {
            return clsTestAppointmentsDataAccess.TakeTest(AppointmentID, Result, CreatedByUserID, Notes);
        }

        public static bool IsAppointmentActiveForTest(int LDLAppID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.IsAppointmentActiveForTest(LDLAppID, TestTypeID);
        }

        public static bool HasApplicantPassedTest(int LDLAppID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.HasApplicantPassedTest(LDLAppID, TestTypeID);
        }

        public static bool HasApplicantFailedTest(int LDLAppID, int TestTypeID)
        {
            return clsTestAppointmentsDataAccess.HasApplicantFailedTest(LDLAppID, TestTypeID);
        }

        public static int ApplicationPreviousTestResult(int LDLAppID, int TestTypeID)
        {
            // 1: Passed already, -1: Failed (Retake test), 0: Not taken before

            if (HasApplicantPassedTest(LDLAppID, TestTypeID))
            {
                return 1;
            }
            else if (HasApplicantFailedTest(LDLAppID, TestTypeID))
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static int PassedTestsCount(int LDLApplicationID)
        {
            return clsTestAppointmentsDataAccess.PassedTestsCount(LDLApplicationID);
        }
    }
}
