using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsDetain
    {
        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }
        public decimal FineFees { set; get; }
        public string CreatedByUser { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public string ReleasedByUser { set; get; }
        public int ReleaseApplicationID { set; get; }

        public clsDetain(
            int DetainID,
            int LicenseID,
            DateTime DetainDate,
            decimal FineFees,
            string CreatedByUser,
            bool IsReleased,
            DateTime ReleaseDate,
            string ReleasedByUser,
            int ReleaseApplicationID
        )
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUser = CreatedByUser;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUser = ReleasedByUser;
            this.ReleaseApplicationID = ReleaseApplicationID;
        }

        public static clsDetain FindDetainByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = 0;
            string CreatedByUser = "";
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            string ReleasedByUser = "";
            int ReleaseApplicationID = -1;

            if (clsDetainDataAccess.FindDetainByLicenseID(
                LicenseID,
                ref DetainID,
                ref DetainDate,
                ref FineFees,
                ref CreatedByUser,
                ref IsReleased,
                ref ReleaseDate,
                ref ReleasedByUser,
                ref ReleaseApplicationID
            ))
            {
                return new clsDetain(
                    DetainID,
                    LicenseID,
                    DetainDate,
                    FineFees,
                    CreatedByUser,
                    IsReleased,
                    ReleaseDate,
                    ReleasedByUser,
                    ReleaseApplicationID
                );
            }
            else
            {
                return null;
            }
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainDataAccess.IsLicenseDetained(LicenseID);
        }

        public static int DetainLicense(int LicenseID, decimal Fine)
        {
            if (!IsLicenseDetained(LicenseID))
            {
                return clsDetainDataAccess.DetainLicense(LicenseID, Fine);

            }
            else
            {
                return -2;
            }
        }

        public static int ReleaseLicense(int LicenseID)
        {
            if (IsLicenseDetained(LicenseID))
            {
                clsLicense LicenseInfo = clsLicense.FindLicenseByID(LicenseID);
                int ApplicationID = clsApplication.CreateApplication(LicenseInfo.PersonID, 5);

                bool IsLicenseReleased = clsDetainDataAccess.ReleaseLicense(LicenseID, ApplicationID);
                bool IsStatusUpdated = clsApplication.UpdateApplicationStatus(ApplicationID, 3);

                if (IsLicenseReleased && IsStatusUpdated)
                {
                    return ApplicationID;
                }
                else
                {
                    return -2;
                }
            }
            else
            {
                return -1;
            }
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainDataAccess.GetAllDetainedLicenses();
        }

    }
}
