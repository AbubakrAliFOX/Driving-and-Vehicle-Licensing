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
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (clsUser.ChangePassword(UserDetails.UserID, tbNewPassword.Text))
            {
                MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wront!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbOldPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbOldPassword, "Old password cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(tbOldPassword, null);
            };

            if (clsUser.Authenticate(UserDetails.UserName, tbOldPassword.Text.Trim()) == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbOldPassword, "Old password is incorrect");
            }
            else
            {
                errorProvider1.SetError(tbOldPassword, null);
            };

        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(tbNewPassword, null);
            };

            if (tbNewPassword.Text.Trim() == tbOldPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "New password must be different from the previous one");
            }
            else
            {
                errorProvider1.SetError(tbNewPassword, null);
            };
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPassword.Text.Trim() != tbNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, null);
            }
        }
    }
}
