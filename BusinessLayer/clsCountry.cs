using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class clsCountry
    {
        public static string find(int ID)
        {
            string CountryName = "";

            if (clsCountriesDataAccess.getCountryName(ID, ref CountryName))
            {
                return CountryName;
            } else
            {
                return "";
            }

        }
    }
}
