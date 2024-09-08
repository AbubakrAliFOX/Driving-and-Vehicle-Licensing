using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace DataLayer
{
    public class clsTestsDataAccess
    {
        public static DataTable GetTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "SELECT TestTypeID AS ID, TestTypeTitle AS Title, TestTypeDescription AS Description, TestTypeFees AS Fees FROM TestTypes";

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

        public static bool FindTestAppointmentByID(int TestID, ref int LDLApplicationID, ref int TestTypeID, ref int RetakeTestApplicationID, ref decimal PaidFees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT LocalDrivingLicenseApplicationID as LDLApplicationID, TestTypeID, RetakeTestApplicationID, PaidFees FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    LDLApplicationID = (int)reader["LDLApplicationID"];
                    TestTypeID = (int)reader["TestTypeID"];
                    PaidFees = (decimal)reader["PaidFees"];

                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    }
                    else
                    {
                        RetakeTestApplicationID = -1;
                    }
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
        
        public static bool FindTestAppointmentByLocalDrivingLicenseApplicationID(int LDLApplicationID, ref int TestAppointmentID, ref int TestTypeID, ref int RetakeTestApplicationID, ref decimal PaidFees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TestAppointmentID, TestTypeID, RetakeTestApplicationID, PaidFees FROM TestAppointments WHERE LocalDrivingLicenseApplicationID  = @LocalDrivingLicenseApplicationID ";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID ", LDLApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestTypeID = (int)reader["TestTypeID"];
                    PaidFees = (decimal)reader["PaidFees"];

                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                    }
                    else
                    {
                        RetakeTestApplicationID = -1;
                    }
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

        public static bool UpdateTestType(int TestID, string TestTitle, string TestDescription, decimal TestFees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                    @"Update TestTypes 
                    Set TestTypeTitle = @TestTypeTitle,
                        TestTypeDescription = @TestTypeDescription,
                        TestTypeFees = @TestTypeFees
                    Where TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestID);
            cmd.Parameters.AddWithValue("@TestTypeTitle", TestTitle);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestDescription);
            cmd.Parameters.AddWithValue("@TestTypeFees", TestFees);

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

        public static decimal GetTestFees(int TestTypeID)
        {
            decimal Fees = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "SELECT TestTypeFees FROM TestTypes WHERE TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Fees = (decimal)reader["TestTypeFees"];

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
    }
}
