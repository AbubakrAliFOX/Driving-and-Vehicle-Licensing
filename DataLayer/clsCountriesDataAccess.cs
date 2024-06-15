using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsCountriesDataAccess
    {
        public static bool GetCountryName(int ID, ref string CountryName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from Countries where CountryID = @CountryID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryName = (string)reader["CountryName"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int GetCountryID(string CountryName)
        {
            int CountryID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select CountryID from Countries where CountryName = @CountryName";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CountryID = (int)reader["CountryID"];
                }

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }

            return CountryID;
        }

        public static List<string> GetAllCountries() 
        {
            List<string> Countries = new List<string>();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select CountryName from Countries";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Countries.Add(reader["CountryName"].ToString());
                }

                reader.Close();
            }
            catch
            {
                
            }
            finally
            {
                connection.Close();
            }

            return Countries;
        }
    }
}
