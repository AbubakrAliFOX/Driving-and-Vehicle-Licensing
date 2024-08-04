using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    public class clsLocalDrivingLicensApplication
    {
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        public string LicenseClassName { set; get; }

        public clsApplication Application { set; get; }

        public clsLocalDrivingLicensApplication(
            int LocalDrivingLicenseApplicationID,
            clsApplication Application,
            int LicenseClassID,
            string LicenseClassName
        )
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.Application = Application;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassName = LicenseClassName;
        }

        public static clsLocalDrivingLicensApplication FindLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
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
                clsApplication Application = new clsApplication(
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

                return new clsLocalDrivingLicensApplication(
                    LocalDrivingLicenseApplicationID,
                    Application,
                    LicenseClassID,
                    LicenseClassName
                );
            }
            else
            {
                return null;
            }
        }
    }
}
