using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PresentationLayer.Global_Classes
{
    public static class clsUtils
    {
        static string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";

        public static void SaveCredentials(string UserName, string Password)
        {
            if (UserName == "" && Password == "")
            {
                try
                {
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        using (RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\DVLD", true))
                        {
                            if (key != null)
                            {
                                key.DeleteValue("UserName");
                                key.DeleteValue("Password");
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deleting credentials failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return;
            }

            try
            {
                Registry.SetValue(KeyPath, "UserName", UserName, RegistryValueKind.String);
                Registry.SetValue(KeyPath, "Password", Password, RegistryValueKind.String);

            } catch (Exception ex)
            {
                MessageBox.Show("Saving credentials failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

        public static bool GetStoredCredentials(ref string UserName, ref string Password)
        {
            try
            {
                string StoredUserName = Registry.GetValue(KeyPath, "UserName", null) as string;
                string StoredPassword = Registry.GetValue(KeyPath, "Password", null) as string;

                if (StoredUserName != null && StoredPassword != null)
                {
                    UserName = StoredUserName;
                    Password = StoredPassword;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
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