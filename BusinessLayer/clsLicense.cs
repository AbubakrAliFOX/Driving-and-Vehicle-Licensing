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

        public static int IssueLicense(clsApplication ApplicationDetails, string IssueNotes, int IssueReason)
        {
            // Check Wether he is already a driver?
            // Fix pricing on issue license form
            int DriverID = clsDriver.CreateDriver(ApplicationDetails.ApplicantID);

            int ApplicationID = ApplicationDetails.ApplicationID;

            int LicenseClassID = ApplicationDetails.LicenseClassID;

            decimal PaidFees = clsApplication.GetApplicationFees(clsApplication.GetApplicationTypeByName(ApplicationDetails.ApplicationType));

            int IssuedLicenseID = clsLicensesDataAccess.IssueLicense(DriverID, ApplicationID, LicenseClassID, IssueNotes, PaidFees, IssueReason);

            bool IsStatusUpdated = clsApplication.UpdateApplicationStatus(ApplicationID, 3);

            if (IssuedLicenseID != -1 && IsStatusUpdated)
            {
                return IssuedLicenseID;
            } else
            {
                return -1;
            }
        }
    }
}
