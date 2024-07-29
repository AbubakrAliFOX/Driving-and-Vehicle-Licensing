using BusinessLayer;
using CustomControls.RJControls;
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
        private ctrlDataPage ctrlDataPagePeople;
        private ctrlDataPage ctrlDataPageDrivers;
        private ctrlDataPage ctrlDataPageUsers;
        private ctrlDataPage ctrlDataPageSettings;

        private ctrlMenuButton ctrlPeopleMenuButton;
        private ctrlMenuButton ctrlDriversMenuButton;
        private ctrlMenuButton ctrlUsersMenuButton;
        private ctrlMenuButton ctrlApplicationsMenuButton;
        private ctrlMenuButton ctrlSettingsMenuButton;

        private List<ctrlMenuButton> lMenuButtons;

        public Form1()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            //this.Width = Screen.PrimaryScreen.Bounds.Width;
            //this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            InitializeControls();
            AddControls();
        }

        private void InitializeControls()
        {
            lMenuButtons = new List<ctrlMenuButton>();

            string[] SearchableItems = new string[] { "None", "Person ID", "National No", "Full Name", "Nationality", "Gender", "Phone", "Email" };
            ctrlDataPagePeople = new ctrlDataPage("People", clsPerson.GetAllPeople(), SearchableItems);
            FormatPeopleLayout();

            SearchableItems = new string[] { "None","Driver ID","National No","Created By User", "Active Licences" };
            ctrlDataPageDrivers = new ctrlDataPage("Drivers", clsDriver.GetAllDrivers(), SearchableItems);
            FormatDriverLayout();

            SearchableItems = new string[] { "None", "User ID", "Full Name", "User Name"};
            ctrlDataPageUsers = new ctrlDataPage("Users", clsUser.GetAllUsers(), SearchableItems);
            FormatUserLayout();

            ctrlDataPageSettings = new ctrlDataPage("ctrlDataPageUsers", clsUser.GetAllUsers());

            ctrlPeopleMenuButton = new ctrlMenuButton("People", "people.png");
            ctrlPeopleMenuButton.Location = new System.Drawing.Point(0, 13);
            ctrlPeopleMenuButton.MainButton.Click += MenuButtonClick;
            lMenuButtons.Add(ctrlPeopleMenuButton);
            ctrlPeopleMenuButton.Page = ctrlDataPagePeople;

            ctrlDriversMenuButton = new ctrlMenuButton("Drivers", "DriverImg.png");
            ctrlDriversMenuButton.Location = new System.Drawing.Point(0, 89);
            ctrlDriversMenuButton.MainButton.Click += MenuButtonClick;
            lMenuButtons.Add(ctrlDriversMenuButton);
            ctrlDriversMenuButton.Page = ctrlDataPageDrivers;

            ctrlUsersMenuButton = new ctrlMenuButton("Users", "Users.png");
            ctrlUsersMenuButton.Location = new System.Drawing.Point(0, 165);
            ctrlUsersMenuButton.MainButton.Click += MenuButtonClick;
            lMenuButtons.Add(ctrlUsersMenuButton);
            ctrlUsersMenuButton.Page = ctrlDataPageUsers;


            ctrlApplicationsMenuButton = new ctrlMenuButton("Applications", "Application.png");
            ctrlApplicationsMenuButton.Location = new System.Drawing.Point(0, 241);
            ctrlApplicationsMenuButton.MainButton.Click += new EventHandler(this.MenuDropdownButton_Click);

            ctrlSettingsMenuButton = new ctrlMenuButton("Settings", "Settings.png");
            ctrlSettingsMenuButton.Location = new System.Drawing.Point(0, 317);
            ctrlSettingsMenuButton.MainButton.Click += MenuButtonClick;
            lMenuButtons.Add(ctrlSettingsMenuButton);
            ctrlSettingsMenuButton.Page = ctrlDataPageSettings;
        }

        private void MenuButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ctrlMenuButton parentControl = button.Parent as ctrlMenuButton;

            foreach (ctrlMenuButton item in lMenuButtons)
            {
                if (item == parentControl)
                {
                    item.Selected();
                    continue;
                }
                    item.Reset();
            }
        }

        private void MenuDropdownButton_Click(object sender, EventArgs e)
        {
            tsmHidden.Text = "\n";
            tsmHidden.Visible = false;
            cmsApplicationOptions.Show(ctrlApplicationsMenuButton, ctrlApplicationsMenuButton.Width, 0);
        }

        private void AddControls()
        {
            this.Controls.Add(ctrlDataPagePeople);
            this.Controls.Add(ctrlDataPageDrivers);
            this.Controls.Add(ctrlDataPageUsers);
            pSideNav.Controls.Add(ctrlPeopleMenuButton);
            pSideNav.Controls.Add(ctrlDriversMenuButton);
            pSideNav.Controls.Add(ctrlUsersMenuButton);
            pSideNav.Controls.Add(ctrlApplicationsMenuButton);
            pSideNav.Controls.Add(ctrlSettingsMenuButton);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            rjDropdownMenu.IsMainMenu = true;

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
                //dgv.Columns["NationalNo"].Width = 120;
                //dgv.Columns["CreatedDate"].Width = 120;
                //dgv.Columns["Username"].Width = 180;
                //dgv.Columns["ActiveLicences"].Width = 80;

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
                dgv.Columns["Username"].HeaderText = "Created By User";
                dgv.Columns["ActiveLicences"].HeaderText = "Active Licenses";

                dgv.Columns["FullName"].Width = 300;
                dgv.Columns["NationalNo"].Width = 120;
                dgv.Columns["CreatedDate"].Width = 120;
                dgv.Columns["Username"].Width = 180;
                dgv.Columns["ActiveLicences"].Width = 80;

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

                dgv.Columns["FullName"].Width = 330;
                dgv.Columns["Username"].Width = 120;

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
                }
            }
        }

        private void drivingLicensesServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rjDropdownMenu_Opened(object sender, EventArgs e)
        {
            ctrlApplicationsMenuButton.Selected();
        }

        private void rjDropdownMenu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            ctrlApplicationsMenuButton.Reset();
        }

        private void cmsApplicationOptions_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            ctrlApplicationsMenuButton.Reset();

        }

        private void cmsApplicationOptions_Opened(object sender, EventArgs e)
        {
            ctrlApplicationsMenuButton.Selected();

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
    }
}
