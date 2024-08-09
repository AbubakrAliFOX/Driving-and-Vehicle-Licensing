using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Global_Classes;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int UserID = clsUser.AuthenticateForLogin(tbUserName.Text, tbPassword.Text);

            if (UserID == -1)
            {
                MessageBox.Show("Incorrect username / password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (UserID == -2)
            {
                MessageBox.Show("Your account is deactivated, contact your admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                clsUser User = clsUser.FindUserByID(UserID);

                clsGlobal.LoggedInUser = User;

                if (cbRememberMe.Checked)
                {
                    clsUtils.SaveCredentials(tbUserName.Text, tbPassword.Text);
                } else
                {
                    clsUtils.SaveCredentials("", "");
                }

                this.Hide();
                MainScreen Application = new MainScreen(this);
                Application.ShowDialog();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsUtils.GetStoredCredentials(ref UserName, ref Password))
            {
                tbUserName.Text = UserName;
                tbPassword.Text = Password;
                cbRememberMe.Checked = true;
            }
            else
                cbRememberMe.Checked = false;
        }
    }
}
