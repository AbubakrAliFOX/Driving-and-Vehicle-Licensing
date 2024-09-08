using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        //public static void SetSize(Control control)
        //{
        //    float WidthPercentage = (float) control.Width / 1920;
        //    float HeightPercentage = (float) control.Height / 1040;

        //    System.Drawing.Rectangle WorkingRectangle = WorkingScreenSize;

        //    int NewWidth = Convert.ToInt32(Math.Ceiling(WidthPercentage * WorkingRectangle.Width));
        //    int NewHeight = Convert.ToInt32(Math.Ceiling(HeightPercentage * WorkingRectangle.Height));

        //    control.Size = new System.Drawing.Size(
        //        NewWidth,
        //        NewHeight
        //    );
        //}

        public static int SetCellWidth(float CellWidthPercentage)
        {
            float dgvWidth = (float)(890 - 27);

            float CellWidth = (CellWidthPercentage / (float)100) * dgvWidth;


            return (int)Math.Ceiling(CellWidth);
        }

        public static int SetSmallCellWidth(float CellWidthPercentage)
        {
            float dgvWidth = (float)(563 - 27);

            float CellWidth = (CellWidthPercentage / (float)100) * dgvWidth;

            return (int)Math.Ceiling(CellWidth);
        }

        //public static void SetSize(Control control, int Width, int Height)
        //{
        //    control.Size = new System.Drawing.Size(
        //        Width,
        //        Height
        //    );
        //}

        //public static System.Drawing.Rectangle WorkingScreenSize
        //{
        //    set; get;
        //}
    }
}