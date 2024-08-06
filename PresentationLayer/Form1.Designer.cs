using BusinessLayer;

namespace PresentationLayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmsDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDriverInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmInterLic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLicHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.pSideNav = new System.Windows.Forms.Panel();
            this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsApplicationOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDrivingLicenseServices = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInternationalDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDetainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReplacement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReleaseDetainedDrivingLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDrivers.SuspendLayout();
            this.cmsPeople.SuspendLayout();
            this.cmsApplicationOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDrivers
            // 
            this.cmsDrivers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDriverInfo,
            this.toolStripSeparator1,
            this.tsmInterLic,
            this.tsmLicHistory});
            this.cmsDrivers.Name = "cmsDrivers";
            this.cmsDrivers.Size = new System.Drawing.Size(285, 94);
            // 
            // tsmDriverInfo
            // 
            this.tsmDriverInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmDriverInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmDriverInfo.Image")));
            this.tsmDriverInfo.Name = "tsmDriverInfo";
            this.tsmDriverInfo.Size = new System.Drawing.Size(284, 28);
            this.tsmDriverInfo.Text = "Show Details";
            this.tsmDriverInfo.Click += new System.EventHandler(this.tsmDriverInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(281, 6);
            // 
            // tsmInterLic
            // 
            this.tsmInterLic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmInterLic.Image = ((System.Drawing.Image)(resources.GetObject("tsmInterLic.Image")));
            this.tsmInterLic.Name = "tsmInterLic";
            this.tsmInterLic.Size = new System.Drawing.Size(284, 28);
            this.tsmInterLic.Text = "Issue International License";
            // 
            // tsmLicHistory
            // 
            this.tsmLicHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmLicHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsmLicHistory.Image")));
            this.tsmLicHistory.Name = "tsmLicHistory";
            this.tsmLicHistory.Size = new System.Drawing.Size(284, 28);
            this.tsmLicHistory.Text = "Show License History";
            // 
            // pSideNav
            // 
            this.pSideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(95)))));
            this.pSideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSideNav.Location = new System.Drawing.Point(0, 0);
            this.pSideNav.Name = "pSideNav";
            this.pSideNav.Size = new System.Drawing.Size(246, 478);
            this.pSideNav.TabIndex = 1;
            // 
            // cmsPeople
            // 
            this.cmsPeople.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPersonInfo,
            this.toolStripSeparator2,
            this.tsmAdd,
            this.tsmEdit,
            this.tsmDelete});
            this.cmsPeople.Name = "cmsPeople";
            this.cmsPeople.Size = new System.Drawing.Size(210, 122);
            // 
            // tsmPersonInfo
            // 
            this.tsmPersonInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmPersonInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmPersonInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmPersonInfo.Image")));
            this.tsmPersonInfo.Name = "tsmPersonInfo";
            this.tsmPersonInfo.Size = new System.Drawing.Size(209, 28);
            this.tsmPersonInfo.Text = "Show Details";
            this.tsmPersonInfo.Click += new System.EventHandler(this.tsmPersonInfo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsmAdd.Image")));
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(209, 28);
            this.tsmAdd.Text = "Add New Person";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmEdit.Image")));
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(209, 28);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmDelete.Image")));
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(209, 28);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // cmsApplicationOptions
            // 
            this.cmsApplicationOptions.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplicationOptions.ImageScalingSize = new System.Drawing.Size(33, 33);
            this.cmsApplicationOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDrivingLicenseServices,
            this.tsmManageApplicationsToolStripMenuItem,
            this.tsmDetainLicensesToolStripMenuItem,
            this.tsmManageApplicationTypes,
            this.tsmManageTestTypes,
            this.toolStripSeparator3,
            this.tsmHidden});
            this.cmsApplicationOptions.Name = "cmsApplicationOptions";
            this.cmsApplicationOptions.Size = new System.Drawing.Size(378, 278);
            this.cmsApplicationOptions.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cmsApplicationOptions_Closed);
            this.cmsApplicationOptions.Opened += new System.EventHandler(this.cmsApplicationOptions_Opened);
            // 
            // tsmDrivingLicenseServices
            // 
            this.tsmDrivingLicenseServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem1,
            this.tsmRenewDrivingLicense,
            this.tsmReplacement,
            this.toolStripSeparator4,
            this.tsmReleaseDetainedDrivingLicenses,
            this.tsmRetakeTest});
            this.tsmDrivingLicenseServices.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDrivingLicenseServices.Image = ((System.Drawing.Image)(resources.GetObject("tsmDrivingLicenseServices.Image")));
            this.tsmDrivingLicenseServices.ImageTransparentColor = System.Drawing.Color.White;
            this.tsmDrivingLicenseServices.Name = "tsmDrivingLicenseServices";
            this.tsmDrivingLicenseServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmDrivingLicenseServices.Size = new System.Drawing.Size(377, 40);
            this.tsmDrivingLicenseServices.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem1
            // 
            this.newDrivingLicenseToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseToolStripMenuItem,
            this.internationalDrivingLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem1.Name = "newDrivingLicenseToolStripMenuItem1";
            this.newDrivingLicenseToolStripMenuItem1.Size = new System.Drawing.Size(449, 36);
            this.newDrivingLicenseToolStripMenuItem1.Text = "New Driving License";
            // 
            // localDrivingLicenseToolStripMenuItem
            // 
            this.localDrivingLicenseToolStripMenuItem.Name = "localDrivingLicenseToolStripMenuItem";
            this.localDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(313, 36);
            this.localDrivingLicenseToolStripMenuItem.Text = "Local License";
            this.localDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseToolStripMenuItem_Click);
            // 
            // internationalDrivingLicenseToolStripMenuItem
            // 
            this.internationalDrivingLicenseToolStripMenuItem.Name = "internationalDrivingLicenseToolStripMenuItem";
            this.internationalDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(313, 36);
            this.internationalDrivingLicenseToolStripMenuItem.Text = "International License";
            this.internationalDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLicenseToolStripMenuItem_Click);
            // 
            // tsmManageApplicationsToolStripMenuItem
            // 
            this.tsmManageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalDrivingLicenseApplicationsToolStripMenuItem,
            this.tsmInternationalDrivingLicenseApplicationsToolStripMenuItem});
            this.tsmManageApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tsmManageApplicationsToolStripMenuItem.Image")));
            this.tsmManageApplicationsToolStripMenuItem.Name = "tsmManageApplicationsToolStripMenuItem";
            this.tsmManageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(377, 40);
            this.tsmManageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // tsmLocalDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.tsmLocalDrivingLicenseApplicationsToolStripMenuItem.Name = "tsmLocalDrivingLicenseApplicationsToolStripMenuItem";
            this.tsmLocalDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(527, 36);
            this.tsmLocalDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.tsmLocalDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.tsmLocalDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // tsmInternationalDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.tsmInternationalDrivingLicenseApplicationsToolStripMenuItem.Name = "tsmInternationalDrivingLicenseApplicationsToolStripMenuItem";
            this.tsmInternationalDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(527, 36);
            this.tsmInternationalDrivingLicenseApplicationsToolStripMenuItem.Text = "International Driving License Applications";
            this.tsmInternationalDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.tsmInternationalDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // tsmDetainLicensesToolStripMenuItem
            // 
            this.tsmDetainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.tsmDetainLicensesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tsmDetainLicensesToolStripMenuItem.Image")));
            this.tsmDetainLicensesToolStripMenuItem.Name = "tsmDetainLicensesToolStripMenuItem";
            this.tsmDetainLicensesToolStripMenuItem.Size = new System.Drawing.Size(377, 40);
            this.tsmDetainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // tsmManageApplicationTypes
            // 
            this.tsmManageApplicationTypes.Image = ((System.Drawing.Image)(resources.GetObject("tsmManageApplicationTypes.Image")));
            this.tsmManageApplicationTypes.Name = "tsmManageApplicationTypes";
            this.tsmManageApplicationTypes.Size = new System.Drawing.Size(377, 40);
            this.tsmManageApplicationTypes.Text = "Manage Application Types";
            this.tsmManageApplicationTypes.Click += new System.EventHandler(this.tsmManageApplicationTypes_Click);
            // 
            // tsmManageTestTypes
            // 
            this.tsmManageTestTypes.Image = ((System.Drawing.Image)(resources.GetObject("tsmManageTestTypes.Image")));
            this.tsmManageTestTypes.Name = "tsmManageTestTypes";
            this.tsmManageTestTypes.Size = new System.Drawing.Size(377, 40);
            this.tsmManageTestTypes.Text = "Manage Test Types";
            this.tsmManageTestTypes.Click += new System.EventHandler(this.tsmManageTestTypes_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(374, 6);
            // 
            // tsmHidden
            // 
            this.tsmHidden.AutoSize = false;
            this.tsmHidden.Name = "tsmHidden";
            this.tsmHidden.Size = new System.Drawing.Size(377, 40);
            this.tsmHidden.Text = "Hidden";
            // 
            // tsmRenewDrivingLicense
            // 
            this.tsmRenewDrivingLicense.Name = "tsmRenewDrivingLicense";
            this.tsmRenewDrivingLicense.Size = new System.Drawing.Size(449, 36);
            this.tsmRenewDrivingLicense.Text = "Renew Driving License";
            this.tsmRenewDrivingLicense.Click += new System.EventHandler(this.tsmRenewDrivingLicense_Click);
            // 
            // tsmReplacement
            // 
            this.tsmReplacement.Name = "tsmReplacement";
            this.tsmReplacement.Size = new System.Drawing.Size(449, 36);
            this.tsmReplacement.Text = "Replacement (Lost / Damaged)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(446, 6);
            // 
            // tsmReleaseDetainedDrivingLicenses
            // 
            this.tsmReleaseDetainedDrivingLicenses.Name = "tsmReleaseDetainedDrivingLicenses";
            this.tsmReleaseDetainedDrivingLicenses.Size = new System.Drawing.Size(449, 36);
            this.tsmReleaseDetainedDrivingLicenses.Text = "Release Detained Driving Licenses";
            // 
            // tsmRetakeTest
            // 
            this.tsmRetakeTest.Name = "tsmRetakeTest";
            this.tsmRetakeTest.Size = new System.Drawing.Size(449, 36);
            this.tsmRetakeTest.Text = "Retake Test";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(376, 36);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(376, 36);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(376, 36);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 478);
            this.Controls.Add(this.pSideNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsDrivers.ResumeLayout(false);
            this.cmsPeople.ResumeLayout(false);
            this.cmsApplicationOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmDriverInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmInterLic;
        private System.Windows.Forms.ToolStripMenuItem tsmLicHistory;
        private System.Windows.Forms.Panel pSideNav;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip cmsPeople;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmDrivingLicenseServices;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmDetainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmManageTestTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmHidden;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmRenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmReplacement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmReleaseDetainedDrivingLicenses;
        private System.Windows.Forms.ToolStripMenuItem tsmRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}

