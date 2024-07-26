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
    }
}
