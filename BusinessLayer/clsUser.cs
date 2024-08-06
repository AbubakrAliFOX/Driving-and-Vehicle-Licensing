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

        public static bool Authenticate(string UserName, string PasswordHash)
        {
            return clsUsersDataAccess.Authenticate(UserName, PasswordHash);
        }
    }
}
