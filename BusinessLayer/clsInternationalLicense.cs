using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsInternationalLicense
    {
        public clsLicense LocalLicense;
        public int ILApplicationID { set; get; }
        public int InternationalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ApplicationDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public decimal PaidFees { set; get; }
        public string CreatedByUser { set; get; }

        public clsInternationalLicense(clsLicense LocalLicense, int InternationalLicenseID, int ILApplicationID, DateTime IssueDate, DateTime ApplicationDate, DateTime ExpirationDate, decimal PaidFees, string CreatedByUser)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.LocalLicense = LocalLicense;
            this.ILApplicationID = ILApplicationID;
            this.IssueDate = IssueDate;
            this.ApplicationDate = ApplicationDate;
            this.ExpirationDate = ExpirationDate;
            this.PaidFees = PaidFees;
            this.CreatedByUser = CreatedByUser;
        }

        public static clsInternationalLicense FindInternationalLicenseByLocalLicenseID(int LocalLicenseID)
        {
            clsLicense LocalLicenseDetails = clsLicense.FindLicenseByID(LocalLicenseID);

            int InternationalLicenseID = -1;
            int ILApplicationID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ApplicationDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            decimal PaidFees = 0;
            string CreatedByUser = "";

            if (clsLicensesDataAccess.FindInternationalLicenseByLocalLicenseID(
                LocalLicenseID,
                ref InternationalLicenseID,
                ref ILApplicationID,
                ref IssueDate,
                ref ApplicationDate,
                ref ExpirationDate,
                ref PaidFees,
                ref CreatedByUser
            ))
            {
                return new clsInternationalLicense(LocalLicenseDetails, InternationalLicenseID, ILApplicationID, IssueDate, ApplicationDate, ExpirationDate, PaidFees, CreatedByUser);
            }
            else
            {
                return null;
            }
        }

        public static bool HasInternationalLicense(int LocalLicenseID)
        {
            return clsLicensesDataAccess.HasInternationalLicense(LocalLicenseID);
        }

        public static int IssueInternationalLicense(int LocalLicenseID)
        {
            clsLicense LocalLicenseDetails = clsLicense.FindLicenseByID(LocalLicenseID);

            if (LocalLicenseDetails.LicenseClassID != 3)
            {
                return -2;
            }

            int ApplicationID = clsApplication.CreateApplication(LocalLicenseDetails.PersonID, 6);
            int DriverID = LocalLicenseDetails.DriverID;


            return clsLicensesDataAccess.IssueInternationalLicense(LocalLicenseID, ApplicationID, DriverID);
        }

    }
}
