using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataLayer
{
    public class clsLicenseClassesDataAccess
    {
        public static DataTable GetLicenseClasses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                "SELECT LicenseClassID AS ID, ClassName FROM LicenseClasses";

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

        public static bool PersonHasLicenseClass(int PersonID, int ClassID)
        {
            int applicationStatus = 0;
            bool foundApplication = false;

            string connectionString = clsDataAccessSettings.connectionString;

            string query = "SELECT CAST(ApplicationStatus as int) AS Status FROM Applications INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID WHERE Applications.ApplicantPersonID = @PersonID and LocalDrivingLicenseApplications.LicenseClassID = @ClassID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@ClassID", ClassID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            applicationStatus = (int)reader["Status"];
                            foundApplication = true;
                        }
                        else
                        {
                            foundApplication = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    // Optionally rethrow or handle the exception as needed
                }
            }

            return (applicationStatus != 2 && foundApplication);
        }

        public static bool CreateLocalDrivingLicenseApplication(int PersonID, int ClassID)
        {
            int LocalDrivingLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) VALUES (@ApplicationID, @LicenseClassID); Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", PersonID);
            cmd.Parameters.AddWithValue("@LicenseClassID", ClassID);


            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LocalDrivingLicenseID = insertedID;
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

            return LocalDrivingLicenseID != -1;
        }

    }
}
