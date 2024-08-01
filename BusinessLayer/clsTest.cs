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

        public static int CreateTestAppointment(int TestType, int LDLApplicationID, DateTime Date, decimal PaidFees)
        {
            return clsTestsDataAccess.CreateTestAppointment(TestType, LDLApplicationID, Date, PaidFees);
        }

        public static DataTable GetTestAppointments(int LDLApplicationID, int TestType)
        {
            return clsTestsDataAccess.GetTestAppointments(LDLApplicationID, TestType);
        }
        
        public static bool UpdateAppointment(int AppointmentID, DateTime NewDate)
        {
            return clsTestsDataAccess.UpdateAppointment(AppointmentID, NewDate);
        }
        
        public static int TakeTest(int AppointmentID, byte Result, string Notes = null)
        {
            return clsTestsDataAccess.TakeTest(AppointmentID, Result, Notes);
        }
        public static bool IsAppointmentActiveForTest(int LDLAppID, int TestTypeID)
        {
            return clsTestsDataAccess.IsAppointmentActiveForTest(LDLAppID, TestTypeID);
        }
        
        public static bool HasApplicantPassedTest(int LDLAppID, int TestTypeID)
        {
            return clsTestsDataAccess.HasApplicantPassedTest(LDLAppID, TestTypeID);
        }
    }
}
