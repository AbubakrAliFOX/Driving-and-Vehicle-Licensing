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

namespace PresentationLayer.Applications
{
    public partial class frmLDLApplicatinoInfo : Form
    {
        public frmLDLApplicatinoInfo(int LDLApplicationID)
        {
            InitializeComponent();

            ctrlLDLApplicationInfo1.LocalApplicationInfo = clsLocalDrivingLicensApplication.FindLocalDrivingLicenseApplicationByID(LDLApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
