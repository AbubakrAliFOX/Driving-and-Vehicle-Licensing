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
            int ApplicationID,
            int ApplicantID,
            string ApplicantName,
            string ApplicationType,
            string ApplicationStatus,
            string CreatedByUser,
            DateTime StatusDate,
            DateTime Date,
            decimal Fees
        )
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantID = ApplicantID;
            this.ApplicantName = ApplicantName;
            this.ApplicationType = ApplicationType;
            this.ApplicationStatus = ApplicationStatus;
            this.CreatedByUser = CreatedByUser;
            this.StatusDate = StatusDate;
            this.Date = Date;
            this.Fees = Fees;
        }

        public static DataTable GetApplicationTypes()
        {
            return clsApplicationsDataAccess.GetApplicationTypes();
        }
        public static int GetApplicationTypeByName(string ApplicationName)
        {
            return clsApplicationsDataAccess.GetApplicationTypeByName(ApplicationName);
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

        public static decimal GetApplicationFees(int ApplicationTypeID)
        {
            return clsApplicationsDataAccess.GetApplicationFees(ApplicationTypeID);
        }
        
        public static clsApplication FindApplicationByID(int ApplicationID)
        {

            int ApplicantID = -1;
            string ApplicantName = "";
            string ApplicationType = "";
            string ApplicationStatus = "";
            string CreatedByUser = "";
            DateTime StatusDate = DateTime.Now;
            DateTime Date = DateTime.Now;
            decimal Fees = 0;

            if (
                clsApplicationsDataAccess.FindApplicationByID(
                    ApplicationID,
                    ref ApplicantName,
                    ref ApplicationType,
                    ref ApplicantID,
                    ref ApplicationStatus,
                    ref CreatedByUser,
                    ref StatusDate,
                    ref Date,
                    ref Fees
                )
            )
            {
                return new clsApplication(
                    ApplicationID,
                    ApplicantID,
                    ApplicantName,
                    ApplicationType,
                    ApplicationStatus,
                    CreatedByUser,
                    StatusDate,
                    Date,
                    Fees
                );
            }
            else
            {
                return null;
            }
        }
        public static int CreateApplication(int PersonID, int ApplicationTypeID, int CreatedByUserID)
        {
            return clsApplicationsDataAccess.CreateApplication(PersonID, ApplicationTypeID, CreatedByUserID);
        }

        public static int CreateLocalDrivingLicenseApplication(int PersonID, int LicenseClassID, int CreatedByUserID)
        {
            if (clsLicense.IsPersonWithinAgeForLicenseClass(PersonID, LicenseClassID))
            {
                if (!clsLicense.PersonHasApplicationWithLicenseClass(PersonID, LicenseClassID))
                {
                    int ApplicationID = CreateApplication(PersonID, 1, CreatedByUserID);

                    if (ApplicationID != -1)
                    {
                        int LDLApplicationID = clsApplicationsDataAccess.CreateLocalDrivingLicenseApplication(ApplicationID, LicenseClassID);
                        if (LDLApplicationID != -1)
                        {
                            return LDLApplicationID;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        return -2;
                    }
                }
                else
                {
                    return -3;
                }
            } else
            {
                return -4;
            }
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
