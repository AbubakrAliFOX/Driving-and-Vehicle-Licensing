using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLayer
{
    public class clsLicenseClass
    {
        public static DataTable GetLicenseClasses()
        {
            return clsLicenseClassesDataAccess.GetLicenseClasses();
        }

        public static bool PersonHasLicenseClass(int PersonID, int ClassID)
        {
            return clsLicenseClassesDataAccess.PersonHasLicenseClass(PersonID, ClassID);
        }

        public static bool CreateLocalDrivingLicenseApplication(int PersonID, int ClassID)
        {
            return clsLicenseClassesDataAccess.CreateLocalDrivingLicenseApplication(PersonID, ClassID);
        }
    }
}
