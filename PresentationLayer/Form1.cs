using BusinessLayer;
using PresentationLayer.Global_Classes;
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
    public partial class Form1 : Form
    {
        Login _frmLogin;

        public Form1(Login LoginForm)
        {
            InitializeComponent();

            _frmLogin = LoginForm;

            InitializeControls();
        }

        private void InitializeControls()
        {

            FormatPeopleLayout();

            FormatDriverLayout();

            FormatUserLayout();

            SubscribeToEvents();
        }
        private void SubscribeToEvents()
        {
            //Override the default add new person picture box in data pages
            ctrlDataPageUsers.AddNewButton += AddNewUser_Click;

            ctrlMenuButton[]  MenuButtons = new ctrlMenuButton[] { ctrlPeopleMenuButton, ctrlDriversMenuButton, ctrlUsersMenuButton };

            foreach (ctrlMenuButton MenuButton in MenuButtons)
            {
                MenuButton.Button.Click += MenuButtonClick;
            }

            ctrlApplicationsMenuButton.Button.Click += ApplicationsMenuDropdownButton_Click;
            ctrlSettingsMenuButton.Button.Click += SettingsMenuDropdownButton_Click;
        }

        private void MenuButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ctrlMenuButton parentControl = button.Parent as ctrlMenuButton;

            foreach (ctrlMenuButton MenuButton in pSideNav.Controls)
            {
                if (MenuButton == parentControl)
                {
                    MenuButton.IsActive = true;
                    continue;
                }

                MenuButton.IsActive = false;
            }
        }

        private void ApplicationsMenuDropdownButton_Click(object sender, EventArgs e)
        {
            tsmHidden.Text = "\n";
            tsmHidden.Visible = false;
            cmsApplicationOptions.Show(ctrlApplicationsMenuButton, ctrlApplicationsMenuButton.Width, 0);
        }

        private void SettingsMenuDropdownButton_Click(object sender, EventArgs e)
        {
            tsmHidden1.Text = "\n";
            tsmHidden1.Visible = false;
            cmsSettings.Show(ctrlSettingsMenuButton, ctrlSettingsMenuButton.Width, 0);
        }

        private void FormatPeopleLayout()
        {
            DataGridView dgv = ctrlDataPagePeople.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv != null)
            {
                dgv.Columns["PersonID"].HeaderText = "Person ID";
                dgv.Columns["NationalNo"].HeaderText = "National No";
                dgv.Columns["FullName"].HeaderText = "Full Name";
                dgv.Columns["Gendor"].HeaderText = "Gender";
                dgv.Columns["DateOfBirth"].HeaderText = "Birth Date";

                dgv.Columns["FullName"].Width = 220;
                dgv.Columns["NationalNo"].Width = 120;
                dgv.Columns["DateOfBirth"].Width = 120;
                dgv.Columns["Email"].Width = 150;
                dgv.Columns["Address"].Width = 120;

                dgv.ContextMenuStrip = cmsPeople;
            }
        }
        private void FormatDriverLayout()
        {
            DataGridView dgv = ctrlDataPageDrivers.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv != null)
            {
                dgv.Columns["DriverID"].HeaderText = "Driver ID";
                dgv.Columns["NationalNo"].HeaderText = "National No";
                dgv.Columns["FullName"].HeaderText = "Full Name";
                dgv.Columns["CreatedDate"].HeaderText = "Created Date";
                dgv.Columns["CreatedByUser"].HeaderText = "Created By User";
                dgv.Columns["ActiveLicences"].HeaderText = "Active Licenses";

                dgv.Columns["DriverID"].Width = 130;
                dgv.Columns["FullName"].Width = 400;
                dgv.Columns["NationalNo"].Width = 120;
                dgv.Columns["CreatedDate"].Width = 193;
                dgv.Columns["CreatedByUser"].Width = 180;
                dgv.Columns["ActiveLicences"].Width = 130;

                dgv.ContextMenuStrip = cmsDrivers;
            }
        }

        private void FormatUserLayout()
        {
            DataGridView dgv = ctrlDataPageUsers.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv != null)
            {
                dgv.Columns["UserID"].HeaderText = "User ID";
                dgv.Columns["FullName"].HeaderText = "Full Name";
                dgv.Columns["UserName"].HeaderText = "User Name";
                dgv.Columns["IsActive"].HeaderText = "Is Active";

                dgv.Columns["UserID"].Width = 130;
                dgv.Columns["FullName"].Width = 450;
                dgv.Columns["Username"].Width = 180;
                dgv.Columns["IsActive"].Width = 180;

                dgv.ContextMenuStrip = cmsUsers;
            }
        }

        private void tsmDriverInfo_Click(object sender, EventArgs e)
        {
            ShowPersonDetails showPersonDetailsForm = new ShowPersonDetails((int)ctrlDataPageDrivers.dgv.CurrentRow.Cells[0].Value);
            showPersonDetailsForm.ShowDialog();
            //_RefreshContactsList();
        }

        private void tsmPersonInfo_Click(object sender, EventArgs e)
        {
            ShowPersonDetails showPersonDetailsForm = new ShowPersonDetails((int)ctrlDataPagePeople.dgv.CurrentRow.Cells[0].Value);
            showPersonDetailsForm.ShowDialog();
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            AddNewPerson addNewPersonForm = new AddNewPerson(-1);
            addNewPersonForm.ShowDialog();
        }
        private void tsmEdit_Click(object sender, EventArgs e)
        {
            AddNewPerson addNewPersonForm = new AddNewPerson((int)ctrlDataPagePeople.dgv.CurrentRow.Cells[0].Value);
            addNewPersonForm.ShowDialog();
        }
        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if(clsPerson.Delete((int)ctrlDataPagePeople.dgv.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Successfully Deleted!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlDataPagePeople.RefreshData();
                }
            }
        }

        private void cmsApplicationOptions_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            ctrlApplicationsMenuButton.Reset();

        }

        private void cmsApplicationOptions_Opened(object sender, EventArgs e)
        {
            ctrlApplicationsMenuButton.Selected();

        }

        private void cmsSettings_Opened(object sender, EventArgs e)
        {
            ctrlSettingsMenuButton.Selected();
        }

        private void cmsSettings_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            ctrlSettingsMenuButton.Reset();
        }

        private void tsmManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes manageApplicationTypes = new frmManageApplicationTypes();
            manageApplicationTypes.ShowDialog();
        }

        private void tsmManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes manageTestTypes = new frmManageTestTypes();
            manageTestTypes.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseApplication NewLocalDrivingLicenseApplication = new frmNewLocalDrivingLicenseApplication();
            NewLocalDrivingLicenseApplication.ShowDialog();
        }

        private void tsmLocalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApplications LocalDrivingLicenseApplications = new frmManageLocalDrivingLicenseApplications();
            LocalDrivingLicenseApplications.ShowDialog();
        }

        private void internationalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalDrivingLicenseApplication InternationalLicense = new frmNewInternationalDrivingLicenseApplication();
            InternationalLicense.ShowDialog();
        }

        private void tsmInternationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalDrivingLicenseApplications InternationalLicenses = new frmManageInternationalDrivingLicenseApplications();
            InternationalLicenses.ShowDialog();
        }

        private void tsmRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLicense RenewLicense = new frmRenewLicense();
            RenewLicense.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense();
            DetainLicense.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseLicense ReleaseLicense = new frmReleaseLicense();
            ReleaseLicense.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicenses DetainedLicenses = new frmManageDetainedLicenses();
            DetainedLicenses.ShowDialog();
        }

        private void tsmReplacement_Click(object sender, EventArgs e)
        {
            frmReplaceLicense ReplaceLicense = new frmReplaceLicense();
            ReplaceLicense.ShowDialog();
        }

        private void tsmReleaseDetainedDrivingLicenses_Click(object sender, EventArgs e)
        {
            frmReleaseLicense ReleaseLicense = new frmReleaseLicense();
            ReleaseLicense.ShowDialog();
        }

        private void tsmRetakeTest_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApplications LocalDrivingLicenseApplications = new frmManageLocalDrivingLicenseApplications();
            LocalDrivingLicenseApplications.ShowDialog();
        }
        private void tsmUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo UserInfo = new frmUserInfo(clsGlobal.LoggedInUser.UserID);
            UserInfo.ShowDialog();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePassword = new frmChangePassword(clsGlobal.LoggedInUser.UserID);
            ChangePassword.ShowDialog();
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            frmNewUser NewUser = new frmNewUser();
            NewUser.ShowDialog();
            //ctrlDataPageUsers.RefreshData();
        }

        private void tsmUserInformation_Click(object sender, EventArgs e)
        {
            frmUserInfo UserInfo = new frmUserInfo((int)ctrlDataPageUsers.dgv.CurrentRow.Cells[0].Value);
            UserInfo.ShowDialog();
        }


        private void tsmAddUser_Click(object sender, EventArgs e)
        {
            frmNewUser NewUser = new frmNewUser();
            NewUser.ShowDialog();
            ctrlDataPageUsers.RefreshData();
        }

        private void tsmEditUser_Click(object sender, EventArgs e)
        {
            frmNewUser EditUser = new frmNewUser((int)ctrlDataPageUsers.dgv.CurrentRow.Cells[0].Value);
            EditUser.ShowDialog();
            ctrlDataPageUsers.RefreshData();
        }

        private void tsmChangeUserPassword_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePassword = new frmChangePassword((int)ctrlDataPageUsers.dgv.CurrentRow.Cells[0].Value);
            ChangePassword.ShowDialog();
        }

        private void tsmDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsUser.DeleteUser((int)ctrlDataPageUsers.dgv.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Successfully Deleted!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlDataPageUsers.RefreshData();
                } else
                {
                    MessageBox.Show("This user is associated with other data. He can't be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsGlobal.LoggedInUser = null;
            _frmLogin.Show();
        }
    }
}
