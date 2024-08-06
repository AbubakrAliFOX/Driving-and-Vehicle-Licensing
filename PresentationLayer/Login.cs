using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        string FilePath = @"..\..\Remember.txt";

        public Login()
        {
            InitializeComponent();

            FillCredentials();

            cbRememberMe.Checked = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int AuthResult = clsUser.Authenticate(tbUserName.Text, tbPassword.Text);
            bool RememberCredentials = cbRememberMe.Checked;

            if (AuthResult == -1)
            {
                MessageBox.Show("Incorrect username / password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (AuthResult == -2)
            {
                MessageBox.Show("Your account is deactivated, contact your admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AuthResult == 1)
            {
                MessageBox.Show("Successfully logged in!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (RememberCredentials)
                {
                    SaveCredentials(tbUserName.Text, tbPassword.Text);
                }

                this.Close();

            }
        }

        private void SaveCredentials(string UserName, string Password)
        {
            using (StreamWriter Writer = new StreamWriter(FilePath, false))
            {
                Writer.WriteLine(UserName);
                Writer.WriteLine(Password);
            }         
        }
        
        private void FillCredentials()
        {
            FilePath = @"..\..\Remember.txt";

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

                    tbUserName.Text = Credentials[0];
                    tbPassword.Text = Credentials[1];
                }
            }
        }

        private void cbRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbRememberMe.Checked)
            {
                File.Delete(FilePath);
            }
        }
    }
}
