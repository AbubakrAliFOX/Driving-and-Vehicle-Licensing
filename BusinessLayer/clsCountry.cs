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
        public static string Find(int ID)
        {
            string CountryName = "";

            if (clsCountriesDataAccess.GetCountryName(ID, ref CountryName))
            {
                return CountryName;
            } else
            {
                return "";
            }

        }

        public static int GetCountryID (string CountryName)
        {
            return clsCountriesDataAccess.GetCountryID(CountryName);
        }

        public static List<string> GetAllCountries ()
        {
            return clsCountriesDataAccess.GetAllCountries();
        }
    }
}
