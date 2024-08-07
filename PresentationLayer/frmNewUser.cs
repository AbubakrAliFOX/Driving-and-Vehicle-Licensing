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
    public partial class frmNewUser : Form
    {
        clsUser UserInfo;
        bool IsEditMode = false;
        public frmNewUser()
        {
            InitializeComponent();
        }

        public frmNewUser(int UserID)
        {
            InitializeComponent();
            
            //Edit Mode
            IsEditMode = true;
            UserInfo = clsUser.FindUserByID(UserID);
            ctrlFindPerson1.OnlyForPerson = UserInfo.PersonID;
            lblTitle.Text = "Update User";
            btnCreateUser.Text = "Update";

            FillUserInfo();
        }

        private void FillUserInfo()
        {
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
                    FillLabels();
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
    }
}
