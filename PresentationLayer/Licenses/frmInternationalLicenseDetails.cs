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
        public frmInternationalLicenseDetails(int InternationalLicenseID)
        {
            InitializeComponent();

            clsInternationalLicense IntLicense = clsInternationalLicense.FindInternationalLicenseByID(InternationalLicenseID);

            ctrlDriverLicense1.LicenseInfo = IntLicense.LocalLicenseInfo;

            lblInternationalLicenseID.Text = IntLicense.InternationalLicenseID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
