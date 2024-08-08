using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsTest
    {
        public static DataTable GetTestTypes()
        {
            return clsTestsDataAccess.GetTestTypes();
        }
        public static bool UpdateTestType(int TestID, string TestTitle, string TestDescription, decimal TestFees)
        {

            return clsTestsDataAccess.UpdateTestType(TestID, TestTitle, TestDescription ,TestFees);
        }

        public static decimal GetTestFees(int TestTypeID)
        {
            return clsTestsDataAccess.GetTestFees(TestTypeID);
        }

        public static int CreateTestAppointment(int TestType, int LDLApplicationID, DateTime Date, decimal PaidFees, int RetakeTestApplicationID, int CreatedByUserID)
        {
            return clsTestsDataAccess.CreateTestAppointment(TestType, LDLApplicationID, Date, PaidFees, RetakeTestApplicationID, CreatedByUserID);
        }

        public static DataTable GetTestAppointments(int LDLApplicationID, int TestType)
        {
            return clsTestsDataAccess.GetTestAppointments(LDLApplicationID, TestType);
        }
        
        public static bool UpdateAppointment(int AppointmentID, DateTime NewDate)
        {
            return clsTestsDataAccess.UpdateAppointment(AppointmentID, NewDate);
        }
        
        public static int TakeTest(int AppointmentID, byte Result, int CreatedByUserID, string Notes = null)
        {
            return clsTestsDataAccess.TakeTest(AppointmentID, Result, CreatedByUserID, Notes);
        }
        public static bool IsAppointmentActiveForTest(int LDLAppID, int TestTypeID)
        {
            return clsTestsDataAccess.IsAppointmentActiveForTest(LDLAppID, TestTypeID);
        }
        
        public static bool HasApplicantPassedTest(int LDLAppID, int TestTypeID)
        {
            return clsTestsDataAccess.HasApplicantPassedTest(LDLAppID, TestTypeID);
        }

        public static bool HasApplicantFailedTest(int LDLAppID, int TestTypeID)
        {
            return clsTestsDataAccess.HasApplicantFailedTest(LDLAppID, TestTypeID);
        }
        public static int ApplicationPreviousTestResult(int LDLAppID, int TestTypeID)
        {
            // 1: Passed already, -1: Failed (Retake test), 0: Not taken before

            if(HasApplicantPassedTest(LDLAppID, TestTypeID))
            {
                return 1;
            } else if (HasApplicantFailedTest(LDLAppID, TestTypeID))
            {
                return -1;
            } else
            {
                return 0;
            }
        }
    }
}
