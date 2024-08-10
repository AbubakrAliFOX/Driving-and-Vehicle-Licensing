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
        public clsLicense LicenseInfo { set; get; }
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
            this.LicenseInfo = clsLicense.FindLicenseByID(LicenseID);
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

        public static int DetainLicense(int LicenseID, decimal Fine, int CreatedByUserID)
        {
            if (!IsLicenseDetained(LicenseID))
            {
                return clsDetainDataAccess.DetainLicense(LicenseID, Fine, CreatedByUserID);

            }
            else
            {
                return -2;
            }
        }

        public static int ReleaseLicense(int LicenseID, int CreatedByUserID)
        {
            if (IsLicenseDetained(LicenseID))
            {
                clsLicense LicenseInfo = clsLicense.FindLicenseByID(LicenseID);
                int ReleaseApplicationID = clsApplication.CreateApplication(LicenseInfo.PersonInfo.ID, 5, CreatedByUserID);

                bool IsLicenseReleased = clsDetainDataAccess.ReleaseLicense(LicenseID, ReleaseApplicationID);
                bool IsStatusUpdated = clsApplication.UpdateApplicationStatus(ReleaseApplicationID, 3);

                if (IsLicenseReleased && IsStatusUpdated)
                {
                    return ReleaseApplicationID;
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
