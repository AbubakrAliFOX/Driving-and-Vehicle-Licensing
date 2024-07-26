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
    }
}
