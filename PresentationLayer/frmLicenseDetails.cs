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
    public partial class frmLicenseDetails : Form
    {
        public frmLicenseDetails(int LDLApplicationID)
        {
            InitializeComponent();

            clsLicense LicenseDetails = clsLicense.FindLicenseByLocalDrivingLicenseApplicationID(LDLApplicationID);
            ctrlDriverLicense1.LicenseInfo = LicenseDetails;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
