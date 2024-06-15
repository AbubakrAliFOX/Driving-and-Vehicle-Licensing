using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsDriversDataAccess
    {
        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "SELECT Drivers.DriverID, People.NationalNo, CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName, ' ', People.LastName) AS FullName, Drivers.CreatedDate, Users.Username, (SELECT COUNT(*) FROM Licenses WHERE Licenses.DriverID = Drivers.DriverID and Licenses.IsActive = 1) AS ActiveLicences FROM Drivers INNER JOIN People ON Drivers.PersonID = People.PersonID INNER JOIN Users ON Drivers.CreatedByUserID = Users.UserID;";

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
    }
}
