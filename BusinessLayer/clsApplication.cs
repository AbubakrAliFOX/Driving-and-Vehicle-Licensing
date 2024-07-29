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
        public static DataTable GetApplicationTypes()
        {
            return clsApplicationsDataAccess.GetApplicationTypes();
        }
        public static bool UpdateApplicationType(int ApplicationID, string ApplicationTitle, decimal ApplicationFees)
        {

            return clsApplicationsDataAccess.UpdateApplicationType(ApplicationID, ApplicationTitle, ApplicationFees);
        }

        public static decimal GetApplicationFees(int ApplicationID)
        {
            return clsApplicationsDataAccess.GetApplicationFees(ApplicationID);
        }

        public static int CreateApplication(int PersonID, int ApplicationTypeID, decimal PaidFees)
        {
            return clsApplicationsDataAccess.CreateApplication(PersonID, ApplicationTypeID, PaidFees);
        }
    }
}
