namespace PresentationLayer
{
    partial class frmManageLocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalDrivingLicenseApplications));
            this.cmsLocalLicences = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.LocalLicenseApplicationsPage = new PresentationLayer.ctrlDataPage();
            this.cmsLocalLicences.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsLocalLicences
            // 
            this.cmsLocalLicences.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLocalLicences.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowApplicationDetails,
            this.toolStripSeparator1,
            this.tsmDeleteApplication,
            this.tsmCancelApplication,
            this.tsmScheduleTests,
            this.tsmIssueDrivingLicenseFirstTime,
            this.tsmShowLicense,
            this.tsmShowPersonLicenseHistory});
            this.cmsLocalLicences.Name = "cmsDrivers";
            this.cmsLocalLicences.Size = new System.Drawing.Size(357, 220);
            this.cmsLocalLicences.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cmsLocalLicences_Closed);
            this.cmsLocalLicences.Opened += new System.EventHandler(this.cmsLocalLicences_Opened);
            // 
            // tsmShowApplicationDetails
            // 
            this.tsmShowApplicationDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmShowApplicationDetails.Image = global::PresentationLayer.Properties.Resources.information;
            this.tsmShowApplicationDetails.Name = "tsmShowApplicationDetails";
            this.tsmShowApplicationDetails.Size = new System.Drawing.Size(356, 30);
            this.tsmShowApplicationDetails.Text = "Show Application Details";
            this.tsmShowApplicationDetails.Click += new System.EventHandler(this.tsmShowApplicationDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(353, 6);
            // 
            // tsmDeleteApplication
            // 
            this.tsmDeleteApplication.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmDeleteApplication.Image = global::PresentationLayer.Properties.Resources.delete;
            this.tsmDeleteApplication.Name = "tsmDeleteApplication";
            this.tsmDeleteApplication.Size = new System.Drawing.Size(356, 30);
            this.tsmDeleteApplication.Text = "Delete Application";
            this.tsmDeleteApplication.Click += new System.EventHandler(this.tsmDeleteApplication_Click);
            // 
            // tsmCancelApplication
            // 
            this.tsmCancelApplication.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmCancelApplication.Image = global::PresentationLayer.Properties.Resources.detain;
            this.tsmCancelApplication.Name = "tsmCancelApplication";
            this.tsmCancelApplication.Size = new System.Drawing.Size(356, 30);
            this.tsmCancelApplication.Text = "Cancel Application";
            this.tsmCancelApplication.Click += new System.EventHandler(this.tsmCancelApplication_Click);
            // 
            // tsmScheduleTests
            // 
            this.tsmScheduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmScheduleVisionTest,
            this.tsmScheduleWrittenTest,
            this.tsmScheduleStreetTest});
            this.tsmScheduleTests.Enabled = false;
            this.tsmScheduleTests.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmScheduleTests.Image = global::PresentationLayer.Properties.Resources.schedule;
            this.tsmScheduleTests.Name = "tsmScheduleTests";
            this.tsmScheduleTests.Size = new System.Drawing.Size(356, 30);
            this.tsmScheduleTests.Text = "Schedule Tests";
            // 
            // tsmScheduleVisionTest
            // 
            this.tsmScheduleVisionTest.Enabled = false;
            this.tsmScheduleVisionTest.Image = global::PresentationLayer.Properties.Resources.eye;
            this.tsmScheduleVisionTest.Name = "tsmScheduleVisionTest";
            this.tsmScheduleVisionTest.Size = new System.Drawing.Size(266, 30);
            this.tsmScheduleVisionTest.Text = "Schedule Vision Test";
            this.tsmScheduleVisionTest.Click += new System.EventHandler(this.tsmScheduleVisionTest_Click);
            // 
            // tsmScheduleWrittenTest
            // 
            this.tsmScheduleWrittenTest.Enabled = false;
            this.tsmScheduleWrittenTest.Image = global::PresentationLayer.Properties.Resources.application1;
            this.tsmScheduleWrittenTest.Name = "tsmScheduleWrittenTest";
            this.tsmScheduleWrittenTest.Size = new System.Drawing.Size(266, 30);
            this.tsmScheduleWrittenTest.Text = "Schedule Written Test";
            this.tsmScheduleWrittenTest.Click += new System.EventHandler(this.tsmScheduleWrittenTest_Click);
            // 
            // tsmScheduleStreetTest
            // 
            this.tsmScheduleStreetTest.Enabled = false;
            this.tsmScheduleStreetTest.Image = global::PresentationLayer.Properties.Resources.test_drive;
            this.tsmScheduleStreetTest.Name = "tsmScheduleStreetTest";
            this.tsmScheduleStreetTest.Size = new System.Drawing.Size(266, 30);
            this.tsmScheduleStreetTest.Text = "Schedule Street Test";
            this.tsmScheduleStreetTest.Click += new System.EventHandler(this.tsmScheduleStreetTest_Click);
            // 
            // tsmIssueDrivingLicenseFirstTime
            // 
            this.tsmIssueDrivingLicenseFirstTime.Enabled = false;
            this.tsmIssueDrivingLicenseFirstTime.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmIssueDrivingLicenseFirstTime.Image = global::PresentationLayer.Properties.Resources.application1;
            this.tsmIssueDrivingLicenseFirstTime.Name = "tsmIssueDrivingLicenseFirstTime";
            this.tsmIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(356, 30);
            this.tsmIssueDrivingLicenseFirstTime.Text = "Issue Driving License (First Time)";
            this.tsmIssueDrivingLicenseFirstTime.Click += new System.EventHandler(this.tsmIssueDrivingLicenseFirstTime_Click);
            // 
            // tsmShowLicense
            // 
            this.tsmShowLicense.Enabled = false;
            this.tsmShowLicense.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmShowLicense.Image = global::PresentationLayer.Properties.Resources.licence;
            this.tsmShowLicense.Name = "tsmShowLicense";
            this.tsmShowLicense.Size = new System.Drawing.Size(356, 30);
            this.tsmShowLicense.Text = "Show License";
            this.tsmShowLicense.Click += new System.EventHandler(this.tsmShowLicense_Click);
            // 
            // tsmShowPersonLicenseHistory
            // 
            this.tsmShowPersonLicenseHistory.Enabled = false;
            this.tsmShowPersonLicenseHistory.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tsmShowPersonLicenseHistory.Image = global::PresentationLayer.Properties.Resources.history;
            this.tsmShowPersonLicenseHistory.Name = "tsmShowPersonLicenseHistory";
            this.tsmShowPersonLicenseHistory.Size = new System.Drawing.Size(356, 30);
            this.tsmShowPersonLicenseHistory.Text = "Show Person License History";
            this.tsmShowPersonLicenseHistory.Click += new System.EventHandler(this.tsmShowPersonLicenseHistory_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(792, 424);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 28);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LocalLicenseApplicationsPage
            // 
            this.LocalLicenseApplicationsPage.AutoScroll = true;
            this.LocalLicenseApplicationsPage.AutoSize = true;
            this.LocalLicenseApplicationsPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LocalLicenseApplicationsPage.Location = new System.Drawing.Point(-1, 3);
            this.LocalLicenseApplicationsPage.Margin = new System.Windows.Forms.Padding(2);
            this.LocalLicenseApplicationsPage.Name = "LocalLicenseApplicationsPage";
            this.LocalLicenseApplicationsPage.Size = new System.Drawing.Size(1074, 460);
            this.LocalLicenseApplicationsPage.TabIndex = 24;
            this.LocalLicenseApplicationsPage.Title = "Local Driving Licenses";
            // 
            // frmManageLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 466);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LocalLicenseApplicationsPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManageLocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmManageLocalDrivingLicenseApplications_Load);
            this.cmsLocalLicences.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicences;
        private System.Windows.Forms.ToolStripMenuItem tsmShowApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleTests;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleStreetTest;
        private System.Windows.Forms.ToolStripMenuItem tsmIssueDrivingLicenseFirstTime;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
        private System.Windows.Forms.Button btnClose;
        private ctrlDataPage LocalLicenseApplicationsPage;
    }
}