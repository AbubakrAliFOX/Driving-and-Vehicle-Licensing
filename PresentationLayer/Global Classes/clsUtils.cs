using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Global_Classes
{
    public static class clsUtils
    {
        static string FilePath = @"..\..\Remember.txt";

        public static void SaveCredentials(string UserName, string Password)
        {
            if (UserName == "" && Password == "")
            {
                File.Delete(FilePath);
                return;
            }

            using (StreamWriter Writer = new StreamWriter(FilePath, false))
            {
                Writer.WriteLine(UserName);
                Writer.WriteLine(Password);
            }
        }

        public static bool GetStoredCredentials(ref string UserName, ref string Password)
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader Reader = new StreamReader(FilePath))
                {
                    string Line;
                    List<string> Credentials = new List<string>();

                    while ((Line = Reader.ReadLine()) != null)
                    {
                        Credentials.Add(Line);
                    }

                    UserName = Credentials[0];
                    Password = Credentials[1];
                }

                return true;
            } else
            {
                return false;
            }
        }

        public static string GetProfileImage(string ImageName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "ProfilePics", ImageName);
        }

        public static int SetCellWidth(float CellWidthPercentage)
        {
            float dgvAvailableWidth = (float)(dgvWidth);

            float CellWidth = (CellWidthPercentage / (float)100) * dgvAvailableWidth;

            return (int)Math.Ceiling(CellWidth);
        }

        public static int dgvWidth
        {
            set; get;
        }
    }
}