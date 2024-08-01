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
    public partial class frmTakeTest : Form
    {
        clsApplication ApplicationDetails;
        int Appointment;
        public frmTakeTest(clsApplication Application, int AppointmentID)
        {
            InitializeComponent();

            ApplicationDetails = Application;
            Appointment = AppointmentID;

            FillLabels();
        }

        private void FillLabels()
        {
            lblDLAppID.Text = ApplicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationID.Text = ApplicationDetails.ApplicationID.ToString();

            lblClass.Text = ApplicationDetails.LicenseClassName;

            lblApplicantName.Text = ApplicationDetails.ApplicantName;

            //lblFees.Text = TestFees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte Result = rbPass.Checked ? (byte)1 : (byte)0;
            string Notes = string.IsNullOrWhiteSpace(tbNotes.Text) ? null : tbNotes.Text;

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if  (clsTest.TakeTest(Appointment, Result, Notes) != -1)
                {
                    MessageBox.Show("Test result has been set", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                this.Close();
            } 
        }
    }
}
