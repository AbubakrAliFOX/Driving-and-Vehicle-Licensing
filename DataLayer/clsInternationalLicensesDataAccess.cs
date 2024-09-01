using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsInternationalLicensesDataAccess
    {

        public static DataTable GetAllPersonLicenses(string NationalNo)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "SELECT InternationalLicenseID, IssuedUsingLocalLicenseID AS LocalLicenseID, ApplicationID, IssueDate, ExpirationDate, IsActive FROM InternationalLicenses INNER JOIN Drivers ON InternationalLicenses.DriverID = Drivers.DriverID INNER JOIN People ON Drivers.PersonID = People.PersonID WHERE People.NationalNo = @NationalNo";
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

        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "SELECT InternationalLicenseID AS [Int.LicenseID], IssuedUsingLocalLicenseID AS [L.LicenseID], ApplicationID, DriverID, IssueDate, ExpirationDate, IsActive FROM InternationalLicenses";
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

        public static bool FindInternationalLicenseByLocalLicenseID(int LocalLicenseID, ref int InternationalLicenseID, ref int ILApplicationID, ref DateTime IssueDate, ref DateTime ApplicationDate, ref DateTime ExpirationDate, ref decimal PaidFees, ref string CreatedByUser)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT InternationalLicenseID, InternationalLicenses.ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, (SELECT UserName FROM Users WHERE UserID = InternationalLicenses.CreatedByUserID) AS CreatedByUser, PaidFees, Applications.ApplicationDate FROM InternationalLicenses INNER JOIN Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID  WHERE IssuedUsingLocalLicenseID = @LocalLicenseID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    ILApplicationID = (int)reader["ApplicationID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUser = (string)reader["CreatedByUser"];

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool FindInternationalLicenseByID(int InternationalLicenseID, ref int LocalLicenseID, ref int ILApplicationID, ref DateTime IssueDate, ref DateTime ApplicationDate, ref DateTime ExpirationDate, ref decimal PaidFees, ref string CreatedByUser)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT InternationalLicenses.ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, (SELECT UserName FROM Users WHERE UserID = InternationalLicenses.CreatedByUserID) AS CreatedByUser, PaidFees, Applications.ApplicationDate FROM InternationalLicenses INNER JOIN Applications ON InternationalLicenses.ApplicationID = Applications.ApplicationID  WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    LocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    ILApplicationID = (int)reader["ApplicationID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUser = (string)reader["CreatedByUser"];

                }
                else
                {
                    IsFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int IssueInternationalLicense(int LocalLicenseID, int ApplicationID, int DriverID, int CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = IssueDate.AddYears(1);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID); Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LocalLicenseID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", 1);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    InternationalLicenseID = insertedID;
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

            return InternationalLicenseID;
        }
    }
}
