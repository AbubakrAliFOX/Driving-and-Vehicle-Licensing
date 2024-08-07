using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmChangePassword : Form
    {
        clsUser UserDetails;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            UserDetails = clsUser.FindUserByID(UserID);

            ctrlUserCard1.UserInfo = UserDetails;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int ChangePasswordMessage = clsUser.ChangePassword(UserDetails.UserName, tbOldPassword.Text, tbNewPassword.Text);

            if (ChangePasswordMessage == -2)
            {
                MessageBox.Show("Old password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ChangePasswordMessage == -1)
            {
                MessageBox.Show("Something went wront!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
