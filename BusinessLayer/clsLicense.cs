using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicense
    {
        public static DataTable GetLicenseClasses()
        {
            return clsLicensesDataAccess.GetLicenseClasses();
        }

        public static bool PersonHasLicenseClass(int PersonID, int ClassID)
        {
            return clsLicensesDataAccess.PersonHasLicenseClass(PersonID, ClassID);
        }

        public static bool CreateLocalDrivingLicenseApplication(int PersonID, int ClassID)
        {
            return clsLicensesDataAccess.CreateLocalDrivingLicenseApplication(PersonID, ClassID);
        }

        public static int LicenseValidity(int LicenseClassID)
        {
            return clsLicensesDataAccess.LicenseValidity(LicenseClassID);
        }

        public static int IssueLicense(clsApplication ApplicationDetails, string IssueNotes)
        {
            int DriverID = clsDriver.CreateDriver(ApplicationDetails.ApplicantID);

            int ApplicationID = ApplicationDetails.ApplicationID;

            int LicenseClassID = ApplicationDetails.LicenseClassID;

            decimal PaidFees = clsApplication.GetApplicationFees(ApplicationDetails.ApplicationType);

            return clsLicensesDataAccess.IssueLicense(DriverID, ApplicationID, LicenseClassID, IssueNotes, );
        }
    }
}
