using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplication
    {
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int ApplicationID { set; get; }
        public int ApplicantID { set; get; }
        public string ApplicantName { set; get; }
        public string ApplicationType { set; get; }
        public string ApplicationStatus { set; get; }
        public string CreatedByUser { set; get; }
        public DateTime StatusDate { set; get; }
        public DateTime Date { set; get; }
        public int LicenseClassID { set; get; }
        public string LicenseClassName { set; get; }
        public decimal Fees { set; get; }

        public clsApplication()
        {
            
        }
        public clsApplication(
            int LocalDrivingLicenseApplicationID,
            int ApplicationID,
            int ApplicantID,
            string ApplicantName,
            string ApplicationType,
            string ApplicationStatus,
            string CreatedByUser,
            DateTime StatusDate,
            DateTime Date,
            int LicenseClassID,
            string LicenseClassName,
            decimal Fees
        )
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.ApplicantID = ApplicantID;
            this.ApplicantName = ApplicantName;
            this.ApplicationType = ApplicationType;
            this.ApplicationStatus = ApplicationStatus;
            this.CreatedByUser = CreatedByUser;
            this.StatusDate = StatusDate;
            this.Date = Date;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassName = LicenseClassName;
            this.Fees = Fees;
        }

        public static DataTable GetApplicationTypes()
        {
            return clsApplicationsDataAccess.GetApplicationTypes();
        }
        public static int GetApplicationTypeByName(string ApplicationID)
        {
            return clsApplicationsDataAccess.GetApplicationTypeByName(ApplicationID);
        }
        public static bool UpdateApplicationType(int ApplicationID, string ApplicationTitle, decimal ApplicationFees)
        {
            return clsApplicationsDataAccess.UpdateApplicationType(ApplicationID, ApplicationTitle, ApplicationFees);
        }

        public static bool UpdateApplicationStatus(int ApplicationID, int Status)
        {
            return clsApplicationsDataAccess.UpdateApplicationStatus(ApplicationID, Status);
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationsDataAccess.DeleteApplicationByID(ApplicationID);
        }

        public static decimal GetApplicationFees(int ApplicationID)
        {
            return clsApplicationsDataAccess.GetApplicationFees(ApplicationID);
        }


        public static clsApplication FindLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {

            int ApplicationID = -1;
            int ApplicantID = -1;
            string ApplicantName = "";
            string ApplicationType = "";
            string ApplicationStatus = "";
            string CreatedByUser = "";
            DateTime StatusDate = DateTime.Now;
            DateTime Date = DateTime.Now;
            int LicenseClassID = 0;
            string LicenseClassName = "";
            decimal Fees = 0;

            if (
                clsApplicationsDataAccess.FindLocalDrivingLicenseApplicationByID(
                    LocalDrivingLicenseApplicationID,
                    ref ApplicationID,
                    ref ApplicantName,
                    ref ApplicationType,
                    ref ApplicantID,
                    ref ApplicationStatus,
                    ref CreatedByUser,
                    ref StatusDate,
                    ref Date,
                    ref LicenseClassID,
                    ref LicenseClassName,
                    ref Fees
                )
            )
            {
                return new clsApplication(
                    LocalDrivingLicenseApplicationID,
                    ApplicationID,
                    ApplicantID,
                    ApplicantName,
                    ApplicationType,
                    ApplicationStatus,
                    CreatedByUser,
                    StatusDate,
                    Date,
                    LicenseClassID,
                    LicenseClassName,
                    Fees
                );
            }
            else
            {
                return null;
            }
        }
        public static int CreateApplication(int PersonID, int ApplicationTypeID, decimal PaidFees)
        {
            return clsApplicationsDataAccess.CreateApplication(PersonID, ApplicationTypeID, PaidFees);
        }

        public static bool CreateLocalDrivingLicenseApplication(int ApplicationID, int ClassID)
        {
            return clsApplicationsDataAccess.CreateLocalDrivingLicenseApplication(ApplicationID, ClassID);
        }

        //public static bool CancelLocalDrivingLicenseApplication(int PersonID, int ClassID)
        //{
        //    return clsApplicationsDataAccess.CreateLocalDrivingLicenseApplication(PersonID, ClassID);
        //}

        public static DataTable GetLocalDrivingLicenseApplications()
        {
            return clsApplicationsDataAccess.GetLocalDrivingLicenseApplications();
        }
        public static int PassedTestsCount(int LDLApplicationID)
        {
            return clsApplicationsDataAccess.PassedTestsCount(LDLApplicationID);
        }

    }
}
