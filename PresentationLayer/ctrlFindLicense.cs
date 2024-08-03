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
    public partial class ctrlFindLicense : UserControl
    {
        public ctrlFindLicense()
        {
            InitializeComponent();
        }

        public clsLicense LicenseInfo
        {
            get { return ctrlDriverLicense1.LicenseInfo; }
            set
            {
                ctrlDriverLicense1.LicenseInfo = value;
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                int SearchTerm;
                int.TryParse(tbSearch.Text, out SearchTerm);

                clsLicense GetLicense = clsLicense.FindLicenseByID(SearchTerm);

                if (GetLicense != null)
                {
                    ctrlDriverLicense1.LicenseInfo = GetLicense;
                }
                else
                {
                    ctrlDriverLicense1.LicenseInfo = null;
                    MessageBox.Show("License not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
