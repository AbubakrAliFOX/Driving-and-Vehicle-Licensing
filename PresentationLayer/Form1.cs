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

        private ctrlMenuButton ctrlDriversMenuButton;
        private ctrlMenuButton ctrlUsersMenuButton;
        private ctrlMenuButton ctrlApplicationsMenuButton;
        private ctrlMenuButton ctrlSettingsMenuButton;

        private List<Button> selectedButtons;

        public Form1()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            //this.Width = Screen.PrimaryScreen.Bounds.Width;
            //this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            selectedButtons = new List<Button>();
            AddButtonEventHandlers();

            InitializeControls();
            SetupLayout();
        }

        private void AddButtonEventHandlers()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    //button.Click += Button_Click;
                }
            }
        }

        private void InitializeControls()
        {
            ctrlDataPageDrivers = new ctrlDataPage("ctrlDataPageDrivers", clsPeopleBusinessLayer.GetAllDrivers());
            ctrlDataPageUsers = new ctrlDataPage("ctrlDataPageUsers", clsPeopleBusinessLayer.GetAllUsers());

            ctrlDriversMenuButton = new ctrlMenuButton("Drivers", "DriverImg.png");
            ctrlDriversMenuButton.Location = new System.Drawing.Point(378, 89);

            ctrlUsersMenuButton = new ctrlMenuButton("Users", "Users.png");
            ctrlUsersMenuButton.Location = new System.Drawing.Point(378, 164);

            ctrlApplicationsMenuButton = new ctrlMenuButton("Applications", "Application.png");
            ctrlApplicationsMenuButton.Location = new System.Drawing.Point(378, 250);

            ctrlSettingsMenuButton = new ctrlMenuButton("Settings", "Settings.png");
            ctrlSettingsMenuButton.Location = new System.Drawing.Point(378, 336);

            ctrlSettingsMenuButton.MainButton.Click += setThis;
        }

        private void setThis(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ctrlMenuButton parentControl = button.Parent as ctrlMenuButton;
            parentControl.SidePanel.Visible = true;
            MessageBox.Show(parentControl.GetType().ToString());
        }
        private void SetupLayout()
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

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            ctrlDataPageDrivers.Visible = true;
            ctrlDataPageUsers.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(200))))); ;
            btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(95))))); ;
            FormatDriverLayout();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ctrlDataPageDrivers.Visible = false;
            ctrlDataPageUsers.Visible = true;
            panel1.Visible = false;
            panel2.Visible = true;
            btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(200))))); ;
            btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(95))))); ;
            FormatUserLayout();

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

    }
}
