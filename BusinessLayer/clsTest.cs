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
        public enum enTestType
        {
            Vision = 1,
            Written = 2,
            Street = 3
        }

        public enTestType TestType {  get; set; }
        public int TestTypeID { set; get; }
        public string TestName { set; get; }
        public decimal TestFees{ set; get; }

        public clsTest(int TestTypeID)
        {
            this.TestTypeID = TestTypeID;
            this.TestType = (enTestType)TestTypeID;
            this.TestName = this.TestType.ToString();
            this.TestFees = this.GetTestFees(TestTypeID);
        }

        public static DataTable GetTestTypes()
        {
            return clsTestsDataAccess.GetTestTypes();
        }
        public static bool UpdateTestType(int TestID, string TestTitle, string TestDescription, decimal TestFees)
        {
            return clsTestsDataAccess.UpdateTestType(TestID, TestTitle, TestDescription, TestFees);
        }

        private decimal GetTestFees(int TestTypeID)
        {
            return clsTestsDataAccess.GetTestFees(TestTypeID);
        }
    }
}