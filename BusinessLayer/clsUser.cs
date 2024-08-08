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
        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }

        public clsUser(
           int UserID,
           int PersonID,
           string UserName,
           string Password,
           bool IsActive
        )
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
        }

        public static clsUser FindUserByID(int UserID)
        {
            int PersonID = 0;
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            if (clsUsersDataAccess.FindUserByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            } else
            {
                return null;
            }
        }

        public static int CreateUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            if (IsUser(PersonID))
            {
                return -2;
            } else
            {
                return clsUsersDataAccess.CreateUser(PersonID, UserName, Password, IsActive);
            }
        }
        
        public static bool UpdateUser(int UserID, string UserName, bool IsActive)
        {
            return clsUsersDataAccess.UpdateUser(UserID, UserName, IsActive);
        }
        
        public static bool DeleteUser(int UserID)
        {
            return clsUsersDataAccess.DeleteUser(UserID);
        }
        
        public static int ChangePassword(string UserName, string OldPassword, string NewPassword)
        {
            int UserID = clsUsersDataAccess.Authenticate(UserName, OldPassword);

            if (UserID != -1)
            {
                if(clsUsersDataAccess.ChangePassword(UserID, NewPassword))
                {
                    return 1;
                } else
                {
                    return -1;
                }
            } else
            {
                return -2;
            }
        }

        public static bool IsUser(int PersonID)
        {
            return clsUsersDataAccess.IsUser(PersonID);
        }

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
            int UserID = clsUsersDataAccess.Authenticate(UserName, PasswordHash);

            if (UserID != -1)
            {
                if (clsUsersDataAccess.IsUserActive(UserName))
                {
                    return UserID;
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
