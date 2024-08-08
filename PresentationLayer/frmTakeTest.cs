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
    public partial class frmTakeTest : Form
    {
        clsLocalDrivingLicensApplication LocalApplicationDetails;
        int Appointment;
        public frmTakeTest(clsLocalDrivingLicensApplication LocalApplication, int AppointmentID)
        {
            InitializeComponent();

            LocalApplicationDetails = LocalApplication;
            Appointment = AppointmentID;

            FillLabels();
        }

        private void FillLabels()
        {
            lblDLAppID.Text = LocalApplicationDetails.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationID.Text = LocalApplicationDetails.Application.ApplicationID.ToString();

            lblClass.Text = LocalApplicationDetails.LicenseClassName;

            lblApplicantName.Text = LocalApplicationDetails.Application.ApplicantName;

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
                if  (clsTest.TakeTest(Appointment, Result, clsGlobal.LoggedInUser.UserID, Notes) != -1)
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
