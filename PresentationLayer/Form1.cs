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
        ctrlDataPage ctrlDataPageDrivers = new ctrlDataPage("ctrlDataPageDrivers", clsPeopleBusinessLayer.GetAllDrivers());
        ctrlDataPage ctrlDataPageUsers = new ctrlDataPage("ctrlDataPageUsers", clsPeopleBusinessLayer.GetAllUsers());
        public Form1()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            //this.Width = Screen.PrimaryScreen.Bounds.Width;
            //this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Controls.Add(ctrlDataPageDrivers);
            this.Controls.Add(ctrlDataPageUsers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            ctrlDataPageDrivers.Visible = true;
            ctrlDataPageUsers.Visible = false;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ctrlDataPageDrivers.Visible = false;
            ctrlDataPageUsers.Visible = true;
        }
    }
}
