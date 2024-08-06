using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


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

        public static bool Authenticate(string UserName, string Password)
        {
            string PasswordHash = "null";
            
            bool AreCredentialsCorrect = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Password FROM Users WHERE UserName = @UserName";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
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

            AreCredentialsCorrect = BCrypt.Net.BCrypt.Verify(Password, PasswordHash);

            return AreCredentialsCorrect;
        }
    }
}
