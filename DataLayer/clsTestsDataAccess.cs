﻿using System;
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

        public static int CreateTestAppointment(int TestType, int LDLApplicationID, DateTime Date, decimal PaidFees, int RetakeTestApplicationID, int CreatedByUserID)
        {
            int TestAppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID) VALUES (@TestTypeID, @LDLApplicationID, @Date, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID); Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestType);
            cmd.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsLocked", (byte)0);

            if (RetakeTestApplicationID == 0)
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            } else
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppointmentID = insertedID;
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

            return TestAppointmentID;
        }

        public static DataTable GetTestAppointments(int LDLApplicationID, int TestType)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "SELECT TestAppointmentID AS AppointmentID, AppointmentDate, PaidFees, IsLocked FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID AND TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestType);


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

        public static bool UpdateAppointment(int AppointmentID, DateTime NewDate)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                    @"Update TestAppointments 
                    Set AppointmentDate = @AppointmentDate
                    Where TestAppointmentID = @AppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@AppointmentDate", NewDate);
            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

        public static int TakeTest(int AppointmentID, byte Result, int CreatedByUserID, string Notes = null)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID) VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID); Select SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", AppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", Result);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (Notes == null)
            {
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Notes", Notes);
            }
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
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

           if (LockAppointment(AppointmentID))
            {
                return TestID;
            } else
            {
                return -1;
            }
        }

        private static bool LockAppointment (int AppointmentID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                    @"Update TestAppointments 
                    Set IsLocked = @IsLocked
                    Where TestAppointmentID = @AppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@IsLocked", (byte)1);
            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);

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

        public static bool IsAppointmentActiveForTest(int LDLAppID, int TestTypeID)
        {
            bool isActive = false;

            string connectionString = clsDataAccessSettings.ConnectionString;

            string query = "SELECT Found = 1 FROM TestAppointments LEFT JOIN TESTS ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID WHERE (LocalDrivingLicenseApplicationID = @LDLAppID AND TestTypeID = @TestTypeID) AND Tests.TestResult is NULL";
            
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                isActive = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return isActive;
        }
        
        public static bool HasApplicantPassedTest(int LDLAppID, int TestTypeID)
        {
            bool hasPassed = false;

            string connectionString = clsDataAccessSettings.ConnectionString;

            string query = "SELECT Tests.TestResult FROM TestAppointments INNER JOIN TESTS ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID WHERE (LocalDrivingLicenseApplicationID = @LDLAppID AND TestTypeID = @TestTypeID) AND TestResult = 1";
            
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                hasPassed = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return hasPassed;
        }
        
        public static bool HasApplicantFailedTest(int LDLAppID, int TestTypeID)
        {
            bool hasFailed = false;

            string connectionString = clsDataAccessSettings.ConnectionString;

            string query = "SELECT Tests.TestResult FROM TestAppointments INNER JOIN TESTS ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID WHERE (LocalDrivingLicenseApplicationID = @LDLAppID AND TestTypeID = @TestTypeID) AND TestResult = 0";
            
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                hasFailed = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return hasFailed;
        }
    }
}
