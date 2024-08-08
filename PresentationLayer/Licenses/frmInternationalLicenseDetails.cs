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
    public partial class frmInternationalLicenseDetails : Form
    {
        public frmInternationalLicenseDetails(int InternationalLicenseID,int LocalLicenseID)
        {
            InitializeComponent();

            clsLicense LicenseDetails = clsLicense.FindLicenseByID(LocalLicenseID);
            ctrlDriverLicense1.LicenseInfo = LicenseDetails;

            lblInternationalLicenseID.Text = InternationalLicenseID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
