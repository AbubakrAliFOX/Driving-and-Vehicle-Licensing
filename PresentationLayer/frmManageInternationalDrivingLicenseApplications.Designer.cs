namespace PresentationLayer
{
    partial class frmManageInternationalDrivingLicenseApplications
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInternationalDrivingLicenseApplications));
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsInternationalLicences = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInternationalLicences.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(837, 467);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 35);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmsInternationalLicences
            // 
            this.cmsInternationalLicences.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInternationalLicences.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowApplicationDetails,
            this.toolStripSeparator1,
            this.tsmEditApplication,
            this.tsmDeleteApplication,
            this.tsmCancelApplication,
            this.tsmScheduleTests,
            this.tsmIssueDrivingLicenseFirstTime,
            this.tsmShowLicense,
            this.tsmShowPersonLicenseHistory});
            this.cmsInternationalLicences.Name = "cmsDrivers";
            this.cmsInternationalLicences.Size = new System.Drawing.Size(419, 298);
            // 
            // tsmShowApplicationDetails
            // 
            this.tsmShowApplicationDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmShowApplicationDetails.Image = ((System.Drawing.Image)(resources.GetObject("tsmShowApplicationDetails.Image")));
            this.tsmShowApplicationDetails.Name = "tsmShowApplicationDetails";
            this.tsmShowApplicationDetails.Size = new System.Drawing.Size(418, 36);
            this.tsmShowApplicationDetails.Text = "Show Application Details";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(415, 6);
            // 
            // tsmEditApplication
            // 
            this.tsmEditApplication.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmEditApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditApplication.Image")));
            this.tsmEditApplication.Name = "tsmEditApplication";
            this.tsmEditApplication.Size = new System.Drawing.Size(418, 36);
            this.tsmEditApplication.Text = "Edit Application";
            // 
            // tsmDeleteApplication
            // 
            this.tsmDeleteApplication.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmDeleteApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmDeleteApplication.Image")));
            this.tsmDeleteApplication.Name = "tsmDeleteApplication";
            this.tsmDeleteApplication.Size = new System.Drawing.Size(418, 36);
            this.tsmDeleteApplication.Text = "Delete Application";
            // 
            // tsmCancelApplication
            // 
            this.tsmCancelApplication.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmCancelApplication.Image = ((System.Drawing.Image)(resources.GetObject("tsmCancelApplication.Image")));
            this.tsmCancelApplication.Name = "tsmCancelApplication";
            this.tsmCancelApplication.Size = new System.Drawing.Size(418, 36);
            this.tsmCancelApplication.Text = "Cancel Application";
            // 
            // tsmScheduleTests
            // 
            this.tsmScheduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmScheduleVisionTest,
            this.tsmScheduleWrittenTest,
            this.tsmScheduleStreetTest});
            this.tsmScheduleTests.Enabled = false;
            this.tsmScheduleTests.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmScheduleTests.Image = ((System.Drawing.Image)(resources.GetObject("tsmScheduleTests.Image")));
            this.tsmScheduleTests.Name = "tsmScheduleTests";
            this.tsmScheduleTests.Size = new System.Drawing.Size(418, 36);
            this.tsmScheduleTests.Text = "Schedule Tests";
            // 
            // tsmScheduleVisionTest
            // 
            this.tsmScheduleVisionTest.Enabled = false;
            this.tsmScheduleVisionTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmScheduleVisionTest.Image")));
            this.tsmScheduleVisionTest.Name = "tsmScheduleVisionTest";
            this.tsmScheduleVisionTest.Size = new System.Drawing.Size(323, 36);
            this.tsmScheduleVisionTest.Text = "Schedule Vision Test";
            // 
            // tsmScheduleWrittenTest
            // 
            this.tsmScheduleWrittenTest.Enabled = false;
            this.tsmScheduleWrittenTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmScheduleWrittenTest.Image")));
            this.tsmScheduleWrittenTest.Name = "tsmScheduleWrittenTest";
            this.tsmScheduleWrittenTest.Size = new System.Drawing.Size(323, 36);
            this.tsmScheduleWrittenTest.Text = "Schedule Written Test";
            // 
            // tsmScheduleStreetTest
            // 
            this.tsmScheduleStreetTest.Enabled = false;
            this.tsmScheduleStreetTest.Image = ((System.Drawing.Image)(resources.GetObject("tsmScheduleStreetTest.Image")));
            this.tsmScheduleStreetTest.Name = "tsmScheduleStreetTest";
            this.tsmScheduleStreetTest.Size = new System.Drawing.Size(323, 36);
            this.tsmScheduleStreetTest.Text = "Schedule Street Test";
            // 
            // tsmIssueDrivingLicenseFirstTime
            // 
            this.tsmIssueDrivingLicenseFirstTime.Enabled = false;
            this.tsmIssueDrivingLicenseFirstTime.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmIssueDrivingLicenseFirstTime.Name = "tsmIssueDrivingLicenseFirstTime";
            this.tsmIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(418, 36);
            this.tsmIssueDrivingLicenseFirstTime.Text = "Issue Driving License (First Time)";
            // 
            // tsmShowLicense
            // 
            this.tsmShowLicense.Enabled = false;
            this.tsmShowLicense.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmShowLicense.Name = "tsmShowLicense";
            this.tsmShowLicense.Size = new System.Drawing.Size(418, 36);
            this.tsmShowLicense.Text = "Show License";
            // 
            // tsmShowPersonLicenseHistory
            // 
            this.tsmShowPersonLicenseHistory.Enabled = false;
            this.tsmShowPersonLicenseHistory.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmShowPersonLicenseHistory.Name = "tsmShowPersonLicenseHistory";
            this.tsmShowPersonLicenseHistory.Size = new System.Drawing.Size(418, 36);
            this.tsmShowPersonLicenseHistory.Text = "Show Person License History";
            // 
            // frmManageInternationalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 514);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageInternationalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage International Driving License Applications";
            this.cmsInternationalLicences.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicences;
        private System.Windows.Forms.ToolStripMenuItem tsmShowApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmEditApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleTests;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleStreetTest;
        private System.Windows.Forms.ToolStripMenuItem tsmIssueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
    }
}