using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsTestsDataAccess
    {
        public static DataTable GetTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

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

        public static bool UpdateTestType(int TestID, string TestTitle, string TestDescription, decimal TestFees)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

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
    }
}
