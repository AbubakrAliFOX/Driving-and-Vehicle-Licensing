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
        public static bool GetPersonByID(
            int ID,
            ref string nationalNumber,
            ref string firstName,
            ref string secondName,
            ref string thirdName,
            ref string lastName,
            ref byte gender,
            ref string email,
            ref string phone,
            ref string address,
            ref DateTime dateOfBirth,
            ref int countryID,
            ref string imgPath
        )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from People where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", ID);

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

        public static bool GetPersonByNationalNo(
            string nationalNo,
            ref int ID,
            ref string firstName,
            ref string secondName,
            ref string thirdName,
            ref string lastName,
            ref byte gender,
            ref string email,
            ref string phone,
            ref string address,
            ref DateTime dateOfBirth,
            ref int countryID,
            ref string imgPath
        )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from People where NationalNo = @NationalNo";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", nationalNo);

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

            string query =
                "SELECT PersonID, NationalNo, CONCAT(FirstName, ' ', SecondName, ' ', ThirdName, ' ', LastName) AS FullName, DateOfBirth, Countries.CountryName AS Nationality, CASE WHEN Gendor = 0 THEN 'Male' ELSE 'Female' END AS Gendor, Address, Phone, Email FROM People INNER JOIN Countries ON People.NationalityCountryID = Countries.CountryID";

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
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int AddNewPerson(
            string nationalNumber,
            string firstName,
            string secondName,
            string thirdName,
            string lastName,
            byte gender,
            string email,
            string phone,
            string address,
            DateTime dateOfBirth,
            int countryID,
            string imgPath
        )
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                @"INSERT INTO People (NationalNo ,FirstName, SecondName, ThirdName, 
            LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
                            VALUES (@NationalNo ,@FirstName, @SecondName, @ThirdName, 
                            @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                            Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", nationalNumber);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@SecondName", secondName);
            
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", gender);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Phone", phone);

            cmd.Parameters.AddWithValue("@NationalityCountryID", countryID);


            if (thirdName != "")
            {
                cmd.Parameters.AddWithValue("@ThirdName", thirdName);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }
            
             if (email != "")
            {
                cmd.Parameters.AddWithValue("@Email", email);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            if (imgPath != "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", imgPath);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        public static bool UpdatePerson(
            int ID,
            string nationalNumber,
            string firstName,
            string secondName,
            string thirdName,
            string lastName,
            byte gender,
            string email,
            string phone,
            string address,
            DateTime dateOfBirth,
            int countryID,
            string imgPath
        )
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                    @"Update People 
                    Set NationalNo = @NationalNo,
                        FirstName = @FirstName,
                        SecondName = @SecondName,
                        ThirdName = @ThirdName, 
                        LastName = @LastName,
                        DateOfBirth = @DateOfBirth,
                        Gendor = @Gendor,
                        Address = @Address,
                        Phone = @Phone,
                        Email = @Email,
                        NationalityCountryID = @NationalityCountryID,
                        ImagePath = @ImagePath
                    Where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", ID);
            cmd.Parameters.AddWithValue("@NationalNo", nationalNumber);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@SecondName", secondName);

            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", gender);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Phone", phone);

            cmd.Parameters.AddWithValue("@NationalityCountryID", countryID);


            if (thirdName != "")
            {
                cmd.Parameters.AddWithValue("@ThirdName", thirdName);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }

            if (email != "")
            {
                cmd.Parameters.AddWithValue("@Email", email);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            if (imgPath != "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", imgPath);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static bool Delete (int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM People
                                WHERE PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
    }
}
