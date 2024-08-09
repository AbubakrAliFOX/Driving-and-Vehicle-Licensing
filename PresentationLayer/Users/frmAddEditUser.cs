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
    public partial class frmAddEditUser : Form
    {
        clsUser UserInfo;
        public frmAddEditUser()
        {
            InitializeComponent();
        }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            
            //Edit Mode
            UserInfo = clsUser.FindUserByID(UserID);

            IsEditMode = true;
        }

        private bool _IsEditMode;
        private bool IsEditMode
        {
            get { return _IsEditMode; }

            set
            {
                _IsEditMode = value;
                if (UserInfo != null)
                {
                    ctrlFindPerson1.OnlyForPerson = UserInfo.PersonID;
                    lblTitle.Text = "Update User";
                    btnCreateUser.Text = "Update";

                    FillUserInfo();
                }
            }
        }

        private void FillUserInfo()
        {
            if (UserInfo == null)
            {
                MessageBox.Show("No User with ID = " + UserInfo.UserID.ToString(), "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            FillLabels();

            tbUserName.Text = UserInfo.UserName;
            tbPassword.Enabled = false;
            tbConfirmPassword.Enabled = false;
            cbIsActive.Checked = UserInfo.IsActive;
        }
        
        private void FillLabels()
        {
            lblUserID.Text = UserInfo.UserID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (ctrlFindPerson1.PersonInfo == null)
            {
                MessageBox.Show("Select a Person First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!IsEditMode)
            {
                int NewUserID = clsUser.CreateUser(ctrlFindPerson1.PersonInfo.ID, tbUserName.Text, tbPassword.Text, cbIsActive.Checked);

                if (NewUserID == -1)
                {
                    MessageBox.Show("Failed to create new user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (NewUserID == -2)
                {
                    MessageBox.Show("Person is already a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("User created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserInfo = clsUser.FindUserByID(NewUserID);
                    IsEditMode = true;
                }
            } else
            {
                if(clsUser.UpdateUser(UserInfo.UserID, tbUserName.Text, cbIsActive.Checked))
                {
                    MessageBox.Show("User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Failed to update user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUserName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(tbUserName, null);
            };


            if (!IsEditMode)
            {
                if (clsUser.IsUser(tbUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(tbUserName, null);
                };
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (UserInfo.UserName != tbUserName.Text.Trim())
                {
                    if (clsUser.IsUser(tbUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(tbUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(tbUserName, null);
                    };
                }
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if(!IsEditMode)
            {
                if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbPassword, "Password cannot be blank");
                }
                else
                {
                    errorProvider1.SetError(tbPassword, null);
                };
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!IsEditMode)
            {
                if (tbConfirmPassword.Text.Trim() != tbPassword.Text.Trim())
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
}
