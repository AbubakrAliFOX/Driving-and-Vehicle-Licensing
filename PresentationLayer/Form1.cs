using PeopleBussinessLayer;
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
        private ctrlDataPage ctrlDataPageDrivers;
        private ctrlDataPage ctrlDataPageUsers;
        private ctrlDataPage ctrlDataPageApplications;
        private ctrlDataPage ctrlDataPageSettings;

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

            ctrlDataPageDrivers = new ctrlDataPage("ctrlDataPageDrivers", clsPerson.GetAllDrivers());
            FormatDriverLayout();
            ctrlDataPageUsers = new ctrlDataPage("ctrlDataPageUsers", clsPerson.GetAllUsers());
            FormatUserLayout();
            ctrlDataPageApplications = new ctrlDataPage("ctrlDataPageUsers", clsPerson.GetAllUsers());
            ctrlDataPageSettings = new ctrlDataPage("ctrlDataPageUsers", clsPerson.GetAllUsers());

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
            ctrlApplicationsMenuButton.MainButton.Click += MenuButtonClick;
            lMenuButtons.Add(ctrlApplicationsMenuButton);
            ctrlApplicationsMenuButton.Page = ctrlDataPageApplications;

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
        private void AddControls()
        {
            this.Controls.Add(ctrlDataPageDrivers);
            this.Controls.Add(ctrlDataPageUsers);
            pSideNav.Controls.Add(ctrlDriversMenuButton);
            pSideNav.Controls.Add(ctrlUsersMenuButton);
            pSideNav.Controls.Add(ctrlApplicationsMenuButton);
            pSideNav.Controls.Add(ctrlSettingsMenuButton);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
