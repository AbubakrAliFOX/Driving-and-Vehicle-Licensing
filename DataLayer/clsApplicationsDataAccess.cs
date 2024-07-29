using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;
using System.Xml.Linq;

namespace DataLayer
{
    public class clsApplicationsDataAccess
    {
        public static DataTable GetApplicationTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                "SELECT ApplicationTypeID AS ID, ApplicationTypeTitle AS Title, ApplicationFees AS Fees FROM ApplicationTypes";

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

        public static bool UpdateApplicationType(int ApplicationID, string ApplicationTitle, decimal ApplicationFees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                    @"Update ApplicationTypes 
                    Set ApplicationTypeTitle = @ApplicationTypeTitle,
                        ApplicationFees = @ApplicationFees
                    Where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationID);
            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTitle);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

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

        public static decimal GetApplicationFees(int ApplicationID)
        {
            decimal Fees = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                "SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Fees = (decimal)reader["ApplicationFees"];
             
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }

            return Fees;
        }

        public static int CreateApplication(int PersonID, int ApplicationTypeID, decimal PaidFees)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) VALUES (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID); Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", 1);
            cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", 1);


            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
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

            return ApplicationID;
        }
    }
}
