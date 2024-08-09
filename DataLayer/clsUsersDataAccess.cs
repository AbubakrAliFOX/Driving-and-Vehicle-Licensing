using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net;


namespace DataLayer
{
    public class clsUsersDataAccess
    {
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Users.UserID, CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName, ' ', People.LastName) AS FullName, Users.UserName, Users.IsActive FROM Users INNER JOIN People ON Users.PersonID = People.PersonID";

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

        public static bool FindUserByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT PersonID, UserName, Password, IsActive FROM Users WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int CreateUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            int UserID = -1;
            
            string HashedPassword = BCrypt.Net.BCrypt.HashPassword(Password);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "INSERT INTO Users (PersonID, UserName, Password, IsActive) VALUES (@PersonID, @UserName, @Password, @IsActive); Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", HashedPassword);
            cmd.Parameters.AddWithValue("@IsActive", IsActive? 1 : 0);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
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

            return UserID;
        }

        public static bool UpdateUser(int UserID, string UserName, bool IsActive)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                    @"Update Users 
                    Set UserName = @UserName,
                        IsActive = @IsActive
                    Where UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@IsActive", IsActive ? 1 : 0);

            try
            {
                connection.Open();
                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }

        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM Users
                                WHERE UserID = @UserID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                RowsAffected = cmd.ExecuteNonQuery();

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

            return (RowsAffected > 0);
        }
        
        public static bool ChangePassword(int UserID, string NewPassword)
        {
            int RowsAffected = 0;

            string HashedPassword = BCrypt.Net.BCrypt.HashPassword(NewPassword);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                    @"Update Users 
                    Set Password = @Password
                    Where UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Password", HashedPassword);

            try
            {
                connection.Open();
                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }

        public static int Authenticate(string UserName, string Password)
        {
            int UserID = -1;
            string PasswordHash = "";
            
            bool AreCredentialsCorrect = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Password, UserID FROM Users WHERE UserName = @UserName";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    PasswordHash = (string)reader["Password"];
                }
                reader.Close();
            }
            catch
            {
                AreCredentialsCorrect = false;
            }
            finally
            {
                connection.Close();
            }

            if (PasswordHash != "")
            {
                AreCredentialsCorrect = BCrypt.Net.BCrypt.Verify(Password, PasswordHash);

            }

            return AreCredentialsCorrect ? UserID : -1;
        }
        
        public static bool IsUserActive(string UserName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Found = 1 FROM Users WHERE UserName = @UserName And IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                IsFound = reader.HasRows;
                reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        
        public static bool IsUser(int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Found = 1 FROM Users WHERE PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                IsFound = reader.HasRows;
                reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        
        public static bool IsUser(string UserName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Found = 1 FROM Users WHERE UserName = @UserName";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                IsFound = reader.HasRows;
                reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
    }
}
