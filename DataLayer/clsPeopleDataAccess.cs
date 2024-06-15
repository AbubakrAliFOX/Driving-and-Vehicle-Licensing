using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsPeopleDataAccess
    {
        public static bool GetPersonByID(int ID, ref string nationalNumber, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref byte gender, ref string email, ref string phone, ref string address, ref DateTime dateOfBirth, ref int countryID, ref string imgPath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from People where PersonID = 1";

            SqlCommand cmd = new SqlCommand(query, connection);

            //cmd.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["PersonID"];

                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        thirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        thirdName = "";
                    }

                    lastName = (string)reader["LastName"];

                    nationalNumber = (string)reader["NationalNo"];
                    gender = (byte)reader["Gendor"];

                    if (reader["Email"] != DBNull.Value)
                    {
                        email = (string)reader["Email"];
                    }
                    else
                    {
                        email = "";
                    }

                    phone = (string)reader["Phone"];
                    address = (string)reader["Address"];
                    countryID = (int)reader["NationalityCountryID"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imgPath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        imgPath = "";
                    }
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


        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT PersonID, NationalNo, CONCAT(FirstName, ' ', SecondName, ' ', ThirdName, ' ', LastName) AS FullName, DateOfBirth, Gendor, Address, Phone, Email FROM People";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }

            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        
    }
}
