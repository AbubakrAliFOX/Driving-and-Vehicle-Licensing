using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsUser
    {
        public static DataTable GetAllUsers()
        {
            return clsUsersDataAccess.GetAllUsers();
        }
        
        public static bool IsUserActive(string UserName)
        {
            return clsUsersDataAccess.IsUserActive(UserName);
        }

        public static int Authenticate(string UserName, string PasswordHash)
        {
            if(clsUsersDataAccess.Authenticate(UserName, PasswordHash))
            {
                if (clsUsersDataAccess.IsUserActive(UserName))
                {
                    return 1;
                }
                else
                {
                    return -2;
                }
            } else
            {
                return -1;
            }
        }
    }
}
