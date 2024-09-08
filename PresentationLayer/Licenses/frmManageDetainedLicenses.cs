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
    public partial class frmManageDetainedLicenses : Form
    {
        clsLicense LicenseDetails;
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }
        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            DetainedLicensesPage.SetAddNewClickEventHandler(DetainNewLicense_Click);
            FormatLayout();
        }

        private void FormatLayout()
        {
            DataGridView dgv = DetainedLicensesPage.Controls.OfType<DataGridView>().FirstOrDefault();
            if (dgv != null && dgv.RowCount > 0)
            {
                dgv.Columns["DetainID"].HeaderText = "Detain ID";
                dgv.Columns["LicenseID"].HeaderText = "License ID";
                dgv.Columns["DetainDate"].HeaderText = "Detain Date";
                dgv.Columns["IsReleased"].HeaderText = "Is Released";
                dgv.Columns["FineFees"].HeaderText = "Fine Fees";
                dgv.Columns["ReleaseDate"].HeaderText = "Release Date";
                dgv.Columns["NationalNo"].HeaderText = "National No";
                dgv.Columns["FullName"].HeaderText = "Full Name";
                dgv.Columns["ReleaseApplicationID"].HeaderText = "Release.App.ID";

                clsUtils.dgvWidth = dgv.Width - dgv.RowHeadersWidth;

                dgv.Columns["DetainID"].Width = clsUtils.SetCellWidth(10);
                dgv.Columns["LicenseID"].Width = clsUtils.SetCellWidth(10);
                dgv.Columns["DetainDate"].Width = clsUtils.SetCellWidth(10);
                dgv.Columns["IsReleased"].Width = clsUtils.SetCellWidth(10);
                dgv.Columns["FineFees"].Width = clsUtils.SetCellWidth(10);
                dgv.Columns["ReleaseDate"].Width = clsUtils.SetCellWidth(10);
                dgv.Columns["NationalNo"].Width = clsUtils.SetCellWidth(10);
                dgv.Columns["FullName"].Width = clsUtils.SetCellWidth(19);
                dgv.Columns["ReleaseApplicationID"].Width = clsUtils.SetCellWidth(10);

                dgv.ContextMenuStrip = cmsDetainedLicenses;
            }
        }

        private void DetainNewLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicense = new frmDetainLicense();
            DetainLicense.ShowDialog();
            DetainedLicensesPage.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowPersonDetails_Click(object sender, EventArgs e)
        {
            LicenseDetails = clsLicense.FindLicenseByID((int)DetainedLicensesPage.dgv.CurrentRow.Cells[1].Value);
            frmPersonDetails PersonDetails = new frmPersonDetails(LicenseDetails.PersonInfo.ID);
            PersonDetails.ShowDialog();
        }

        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            LicenseDetails = clsLicense.FindLicenseByID((int)DetainedLicensesPage.dgv.CurrentRow.Cells[1].Value);
            frmLicenseDetails LicenseDetailsForm = new frmLicenseDetails(LicenseDetails.LicenseID);
            LicenseDetailsForm.ShowDialog();
        }

        private void tsmShowLicenseHistory_Click(object sender, EventArgs e)
        {
            LicenseDetails = clsLicense.FindLicenseByID((int)DetainedLicensesPage.dgv.CurrentRow.Cells[1].Value);
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(LicenseDetails.PersonInfo.ID);
            LicenseHistory.ShowDialog();
        }

        private void tsmReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseLicense ReleaseLicense = new frmReleaseLicense((int)DetainedLicensesPage.dgv.CurrentRow.Cells[1].Value);
            ReleaseLicense.ShowDialog();
            DetainedLicensesPage.RefreshData();
        }

        private void cmsDetainedLicenses_Opened(object sender, EventArgs e)
        {
            bool IsReleased = (bool)DetainedLicensesPage.dgv.CurrentRow.Cells[3].Value;

            if(!IsReleased)
            {
                tsmReleaseLicense.Enabled = true;
            }
        }

        private void cmsDetainedLicenses_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            tsmReleaseLicense.Enabled = false;
        }
    }
}
