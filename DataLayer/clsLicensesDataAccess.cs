using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.ComponentModel;
using System.Net;
using System.Security.Policy;

namespace DataLayer
{
    public class clsLicensesDataAccess
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

        public static bool FindLicenseByID(
            int LicenseID,
            ref int PersonID,
            ref int DriverID,
            ref int ApplicationID,
            ref int LicenseClassID,
            ref string LicenseClassName,
            ref DateTime IssueDate,
            ref DateTime ExpirationDate,
            ref string IssueNotes,
            ref decimal PaidFees,
            ref bool IsActive,
            ref int IssueReason,
            ref int CreatedByUser
        )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT LicenseID, Licenses.DriverID, PersonID, ApplicationID, LicenseClass, ClassName, IssueDate, ExpirationDate, Notes, PaidFees, CAST(IsActive as bit) AS IsActive, IssueReason, Licenses.CreatedByUserID FROM Licenses INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID WHERE LicenseID  = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    PersonID = (int)reader["PersonID"];
                    DriverID = (int)reader["DriverID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClass"];
                    LicenseClassName = (string)reader["ClassName"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = Convert.ToInt32(reader["IssueReason"]);
                    CreatedByUser = (int)reader["CreatedByUserID"];

                    if (reader["Notes"] != DBNull.Value)
                    {
                        IssueNotes = (string)reader["Notes"];
                    }
                    else
                    {
                        IssueNotes = "";
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

        public static bool FindLicenseByLocalDrivingLicenseApplicationID(
            int LDLApplicationID,
            ref int LicenseID,
            ref int PersonID,
            ref int DriverID,
            ref int ApplicationID,
            ref int LicenseClassID,
            ref string LicenseClassName,
            ref DateTime IssueDate,
            ref DateTime ExpirationDate,
            ref string IssueNotes,
            ref decimal PaidFees,
            ref bool IsActive,
            ref int IssueReason,
            ref int CreatedByUser
        )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT LicenseID, Licenses.DriverID, PersonID, ApplicationID, LicenseClass, ClassName, IssueDate, ExpirationDate, Notes, PaidFees, CAST(IsActive as bit) AS IsActive, IssueReason, Licenses.CreatedByUserID FROM Licenses INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID WHERE ApplicationID = (SELECT ApplicationID from LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID  = @LDLApplicationID)";
            
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    PersonID = (int)reader["PersonID"];
                    DriverID = (int)reader["DriverID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClass"];
                    LicenseClassName = (string)reader["ClassName"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = Convert.ToInt32(reader["IssueReason"]);
                    CreatedByUser = (int)reader["CreatedByUserID"];

                    

                    if (reader["Notes"] != DBNull.Value)
                    {
                        IssueNotes = (string)reader["Notes"];
                    }
                    else
                    {
                        IssueNotes = "";
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


        public static bool PersonHasApplicationWithLicenseClass(int PersonID, int ClassID)
        {
            int ApplicationStatus = 0;
            bool FoundApplication = false;

            string connectionString = clsDataAccessSettings.connectionString;

            string query = "SELECT CAST(ApplicationStatus as int) AS Status FROM Applications INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID WHERE ApplicationStatus in (1,3) and Applications.ApplicantPersonID = @PersonID and LocalDrivingLicenseApplications.LicenseClassID = @ClassID";

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
                            ApplicationStatus = (int)reader["Status"];
                            FoundApplication = true;
                        }
                        else
                        {
                            FoundApplication = false;
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

            return (ApplicationStatus != 2 && FoundApplication);
        }
        public static bool DeactivateLicense(int LicenseID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                    @"Update Licenses 
                        Set IsActive = 0
                    Where LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

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

        public static bool IsLicenseActive(int LicenseID)
        {
            bool IsLicenseActive = false;

            string connectionString = clsDataAccessSettings.connectionString;

            string query = "SELECT Found = 1 FROM Licenses WHERE IsActive = 1 and LicenseID = @LicenseID";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                IsLicenseActive = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
                // Optionally rethrow or handle the exception as needed
            }

            return IsLicenseActive;
        }
        
        public static bool IsLicenseExpired(int LicenseID)
        {
            DateTime ExpirationDate = DateTime.Now;

            string connectionString = clsDataAccessSettings.connectionString;

            string query = "SELECT ExpirationDate FROM Licenses WHERE LicenseID = @LicenseID";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
                // Optionally rethrow or handle the exception as needed
            }

            return ExpirationDate.CompareTo(DateTime.Now) < 0;
        }
        
        public static bool HasDriverActiveLicenses(int DriverID)
        {
            bool DriverHasActiveLicenses = false;

            string connectionString = clsDataAccessSettings.connectionString;

            string query = "Select Found = 1 From Licenses Where DriverID = @DriverID AND ExpirationDate > GETDATE()";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                DriverHasActiveLicenses = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
                // Optionally rethrow or handle the exception as needed
            }

            return DriverHasActiveLicenses;
        }
        
        public static int IssueLicense(int DriverID, int ApplicationID, int LicenseClassID, string IssueNotes, decimal PaidFees, int IssueReason)
        {
            int LicenseID = -1;

            int LicenseValidity = clsLicensesDataAccess.LicenseValidity(LicenseClassID);

            DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = IssueDate.AddYears(LicenseValidity);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "INSERT INTO Licenses (DriverID, ApplicationID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID) VALUES (@DriverID, @ApplicationID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID); Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@Notes", IssueNotes);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", 1);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", 1);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
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

            return LicenseID;
        }
        
        private static int LicenseValidity(int LicenseClassID)
        {
            int Validity = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                "SELECT CAST(DefaultValidityLength as int) AS Validity FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Validity = (int)reader["Validity"];
                }

                reader.Close();
            }
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }

            return Validity;
        }

        public static DataTable GetAllPersonLicenses(string NationalNo)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query =
                "SELECT LicenseID, ApplicationID, ClassName, IssueDate, ExpirationDate, IsActive FROM Licenses INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN People ON Drivers.PersonID = People.PersonID WHERE People.NationalNo = @NationalNo";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);


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

        public static bool HasInternationalLicense(int LocalLicenseID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Found = 1 FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @LocalLicenseID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                isFound = reader.HasRows;
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
    }
}
