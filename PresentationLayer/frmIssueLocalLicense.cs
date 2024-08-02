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
    public partial class frmIssueLocalLicense : Form
    {
        clsApplication ApplicationDetails;
        public frmIssueLocalLicense(int LDLApplicationID)
        {
            InitializeComponent();

            ApplicationDetails = clsApplication.FindLocalDrivingLicenseApplication(LDLApplicationID);

            ctrlApplicationInfo.ApplicationInfo = ApplicationDetails;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Issue License?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (clsLicense.IssueLicense(ApplicationDetails, tbNotes.Text, 1) != -1)
                {
                    MessageBox.Show("License Issued Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Close();
        }
    }
}
