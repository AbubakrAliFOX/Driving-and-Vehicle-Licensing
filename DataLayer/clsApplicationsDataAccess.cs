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
        public static int GetApplicationTypeByName(string ApplicationName)
        {
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT ApplicationTypeID FROM ApplicationTypes WHERE ApplicationTypeTitle = @ApplicationName";


            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationName", ApplicationName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationTypeID"];
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

            return ApplicationID;
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

        public static bool UpdateApplicationStatus(int ApplicationID, int Status)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                    @"Update Applications 
                    Set ApplicationStatus = @ApplicationStatus
                    Where ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", Status);

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

        public static bool DeleteApplicationByID(int ApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                    @"DELETE FROM Applications 
                    Where ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static bool FindLocalDrivingLicenseApplicationByID(
            int LocalDrivingLicenseApplicationID,
            ref int ApplicationID,
            ref string ApplicantName,
            ref string ApplicationType,
            ref int ApplicantID,
            ref string ApplicationStatus,
            ref string CreatedByUser,
            ref DateTime StatusDate,
            ref DateTime Date,
            ref int LicenseClassID,
            ref string LicenseClassName,
            ref decimal Fees
        )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Applications.PaidFees AS Fees, People.PersonID, CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName, ' ', People.LastName) AS FullName, Applications.ApplicationDate, CASE WHEN Applications.ApplicationStatus = 1 THEN 'New' WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled' ELSE 'Completed' END AS ApplicationStatus, Applications.ApplicationID, Applications.LastStatusDate AS StatusDate, Users.UserName AS CreatedByUser, LicenseClasses.LicenseClassID, LicenseClasses.ClassName AS DrivingClass, ApplicationTypes.ApplicationTypeTitle AS ApplicationType FROM Applications INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID INNER JOIN Users ON Applications.CreatedByUserID = Users.UserID WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID= @LDLApplication";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LDLApplication", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    ApplicantID = (int)reader["PersonID"];
                    ApplicantName = (string)reader["FullName"];
                    ApplicationType = (string)reader["ApplicationType"];
                    ApplicationStatus = (string)reader["ApplicationStatus"];
                    CreatedByUser = (string)reader["CreatedByUser"];
                    StatusDate = (DateTime)reader["StatusDate"];
                    Date = (DateTime)reader["ApplicationDate"];
                    Fees = (decimal)reader["Fees"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    LicenseClassName = (string)reader["DrivingClass"];


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
        
        public static int PassedTestsCount(int LDLApplicationID)
        {
            int PassedTests = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT COUNT(*) AS PassedTests FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID WHERE Tests.TestResult = 1 AND TestAppointments.LocalDrivingLicenseApplicationID = @LDLApplicationID";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PassedTests = (int)reader["PassedTests"];
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

            return PassedTests;
        }
        public static int CreateApplication(int PersonID, int ApplicationTypeID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "INSERT INTO Applications(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) VALUES(@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, (SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID), @CreatedByUserID); Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", 1);
            cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
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

        public static bool CreateLocalDrivingLicenseApplication(int ApplicationID, int ClassID)
        {
            int LocalDrivingLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) VALUES (@ApplicationID, @LicenseClassID); Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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
        //public static bool CancelApplication(int LDLApplicationID)
        //{
        //    int rowsAffected = 0;
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

        //    string query = @"UPDATE Applications
        //                    SET ApplicationStatus = 2
        //                    WHERE ApplicationID = (SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID)";

        //    SqlCommand cmd = new SqlCommand(query, connection);

        //    cmd.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);


        //    try
        //    {
        //        connection.Open();
        //        rowsAffected = cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Console.WriteLine("Error: " + ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return (rowsAffected > 0);
        //}

        public static DataTable GetLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
               "SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID AS [L.D.L.AppID], LicenseClasses.ClassName AS DrivingClass, People.NationalNo, CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName, ' ', People.LastName) AS FullName, (SELECT COUNT(*) AS PassedTests FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID WHERE Tests.TestResult = 1 AND TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID) AS PassedTests, Applications.ApplicationDate, CASE WHEN Applications.ApplicationStatus = 1 THEN 'New' WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled' ELSE 'Completed' END AS ApplicationStatus FROM     Applications INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID";
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

    }
}
