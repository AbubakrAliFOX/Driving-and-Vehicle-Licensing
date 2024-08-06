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
        int UserID;
        public frmNewUser()
        {
            InitializeComponent();
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
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserID = NewUserID;
                FillLabels();
            }
        }

        private void FillLabels()
        {
            lblUserID.Text = UserID.ToString();
        }
    }
}
