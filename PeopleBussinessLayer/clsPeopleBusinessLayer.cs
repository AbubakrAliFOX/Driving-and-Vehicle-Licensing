using PeopleDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleBussinessLayer
{
    public class clsPeopleBusinessLayer
    {
        public static DataTable GetAllDrivers()
        {
            return clsDataAccessLayer.GetAllDrivers();
        }

        public static DataTable GetAllUsers()
        {
            return clsDataAccessLayer.GetAllUsers();
        }
    }
}
