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
    public partial class frmIssueLocalLicense : Form
    {
        clsLocalDrivingLicensApplication LocalApplicationDetails;
        public frmIssueLocalLicense(int LDLApplicationID)
        {
            InitializeComponent();

            LocalApplicationDetails = clsLocalDrivingLicensApplication.FindLocalDrivingLicenseApplicationByID(LDLApplicationID);

            ctrlApplicationInfo.LocalApplicationInfo = LocalApplicationDetails;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Issue License?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (clsLicense.IssueLicense(LocalApplicationDetails, tbNotes.Text, 1, clsGlobal.LoggedInUser.UserID) != -1)
                {
                    MessageBox.Show("License Issued Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("An Error Occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }
    }
}
