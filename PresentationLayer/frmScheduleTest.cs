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
    public partial class frmScheduleTest : Form
    {
        int LDLApplicationID;
        int TestTypeID;
        decimal TestFees;

        public frmScheduleTest(clsApplication ApplicationDetails, int TestType)
        {
            InitializeComponent();

            LDLApplicationID = ApplicationDetails.LocalDrivingLicenseApplicationID;
            TestTypeID = TestType;
            TestFees = clsTest.GetTestFees(TestTypeID);

            lblDLAppID.Text = LDLApplicationID.ToString();
            lblApplicationID.Text = ApplicationDetails.ApplicationID.ToString();

            lblClass.Text = ApplicationDetails.LicenseClassName;

            lblApplicantName.Text = ApplicationDetails.ApplicantName;

            lblFees.Text = TestFees.ToString();

            dtpTestDate.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(clsTest.CreateTestAppointment(TestTypeID, LDLApplicationID, dtpTestDate.Value, TestFees) != -1)
            {
                MessageBox.Show("Appointment Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Creating Appointment Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
