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
        public int LicenseID { set; get; }
        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public int ApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        public string LicenseClassName { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string IssueNotes { set; get; }
        public decimal PaidFees { set; get; }
        public bool IsActive { set; get; }
        public int IssueReason { set; get; }
        public int CreatedByUser { set; get; }

        public clsLicense(
            int LicenseID,
            int PersonID,
            int DriverID,
            int ApplicationID,
            int LicenseClassID,
            string LicenseClassName,
            DateTime IssueDate,
            DateTime ExpirationDate,
            string IssueNotes,
            decimal PaidFees,
            bool IsActive,
            int IssueReason,
            int CreatedByUser
        )
        {
            this.LicenseID = LicenseID;
            this.PersonID = PersonID;
            this.DriverID = DriverID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassName = LicenseClassName;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IssueNotes = IssueNotes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUser = CreatedByUser;
        }

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

        //public static clsLicense FindLicenseByID(int LicenseID)
        //{
        //    int DriverID = 0;
        //    int ApplicationID = 0;
        //    int LicenseClassID = 0;
        //    string LicenseClassName = "";
        //    DateTime IssueDate = DateTime.Now;
        //    DateTime ExpirationDate = DateTime.Now;
        //    string IssueNotes = "";
        //    decimal PaidFees = 0;
        //    byte IsActive = 0;
        //    int IssueReason = 0;
        //    int CreatedByUser = 0;

        //    if (
        //        clsLicensesDataAccess.FindLicenseByID(
        //            LicenseID,
        //            ref DriverID,
        //            ref ApplicationID,
        //            ref LicenseClassID,
        //            ref LicenseClassName,
        //            ref IssueDate,
        //            ref ExpirationDate,
        //            ref IssueNotes,
        //            ref PaidFees,
        //            ref IsActive,
        //            ref IssueReason,
        //            ref CreatedByUser
        //        )
        //    )
        //    {
        //        return new clsLicense(
        //            LicenseID,
        //            DriverID,
        //            ApplicationID,
        //            LicenseClassID,
        //            LicenseClassName,
        //            IssueDate,
        //            ExpirationDate,
        //            IssueNotes,
        //            PaidFees,
        //            IsActive,
        //            IssueReason,
        //            CreatedByUser
        //        );
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        
        public static clsLicense FindLicenseByLocalDrivingLicenseApplicationID(int LDLApplicationID)
        {
            int LicenseID = 0;
            int PersonID = 0;
            int DriverID = 0;
            int ApplicationID = 0;
            int LicenseClassID = 0;
            string LicenseClassName = "";
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string IssueNotes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            int IssueReason = 0;
            int CreatedByUser = 0;

            if (
                clsLicensesDataAccess.FindLicenseByLocalDrivingLicenseApplicationID(
                    LDLApplicationID,
                    ref LicenseID,
                    ref PersonID,
                    ref DriverID,
                    ref ApplicationID,
                    ref LicenseClassID,
                    ref LicenseClassName,
                    ref IssueDate,
                    ref ExpirationDate,
                    ref IssueNotes,
                    ref PaidFees,
                    ref IsActive,
                    ref IssueReason,
                    ref CreatedByUser
                )
            )
            {
                return new clsLicense(
                    LicenseID,
                    PersonID,
                    DriverID,
                    ApplicationID,
                    LicenseClassID,
                    LicenseClassName,
                    IssueDate,
                    ExpirationDate,
                    IssueNotes,
                    PaidFees,
                    IsActive,
                    IssueReason,
                    CreatedByUser
                );
            }
            else
            {
                return null;
            }
        }
    }
}
