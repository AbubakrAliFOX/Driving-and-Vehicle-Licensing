using System;
using System.IO;

namespace DataLayer
{
    public class clsDataAccessSettings
    {
        private static string CreateConnectionString ()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DVLD.mdf");

            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30";
        }

        public static string ConnectionString = CreateConnectionString();
    }
}
