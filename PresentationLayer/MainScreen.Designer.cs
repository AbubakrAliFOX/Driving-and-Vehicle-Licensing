using BusinessLayer;

namespace PresentationLayer
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.cmsDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDriverInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmInterLic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLicHistory = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReplacement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReleaseDetainedDrivingLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInternationalDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDetainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmHidden1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmUserInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangeUserPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.pSideNav = new System.Windows.Forms.Panel();
            this.ctrlSettingsMenuButton = new PresentationLayer.ctrlMenuButton();
            this.ctrlApplicationsMenuButton = new PresentationLayer.ctrlMenuButton();
            this.ctrlUsersMenuButton = new PresentationLayer.ctrlMenuButton();
            this.ctrlDataPageUsers = new PresentationLayer.ctrlDataPage();
            this.ctrlDriversMenuButton = new PresentationLayer.ctrlMenuButton();
            this.ctrlDataPageDrivers = new PresentationLayer.ctrlDataPage();
            this.ctrlPeopleMenuButton = new PresentationLayer.ctrlMenuButton();
            this.ctrlDataPagePeople = new PresentationLayer.ctrlDataPage();
            this.pbOff = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.cmsDrivers.SuspendLayout();
            this.cmsPeople.SuspendLayout();
            this.cmsApplicationOptions.SuspendLayout();
            this.cmsSettings.SuspendLayout();
            this.cmsUsers.SuspendLayout();
            this.pSideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
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
            this.cmsApplicationOptions.Size = new System.Drawing.Size(378, 250);
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
            this.tsmReplacement.Click += new System.EventHandler(this.tsmReplacement_Click);
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
            this.tsmReleaseDetainedDrivingLicenses.Click += new System.EventHandler(this.tsmReleaseDetainedDrivingLicenses_Click);
            // 
            // tsmRetakeTest
            // 
            this.tsmRetakeTest.Name = "tsmRetakeTest";
            this.tsmRetakeTest.Size = new System.Drawing.Size(449, 36);
            this.tsmRetakeTest.Text = "Retake Test";
            this.tsmRetakeTest.Click += new System.EventHandler(this.tsmRetakeTest_Click);
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
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(376, 36);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
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
            // cmsSettings
            // 
            this.cmsSettings.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsSettings.ImageScalingSize = new System.Drawing.Size(33, 33);
            this.cmsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUserInfo,
            this.tsmChangePassword,
            this.tsmLogout,
            this.toolStripSeparator5,
            this.tsmHidden1});
            this.cmsSettings.Name = "cmsApplicationOptions";
            this.cmsSettings.Size = new System.Drawing.Size(286, 170);
            this.cmsSettings.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cmsSettings_Closed);
            this.cmsSettings.Opened += new System.EventHandler(this.cmsSettings_Opened);
            // 
            // tsmUserInfo
            // 
            this.tsmUserInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmUserInfo.Image")));
            this.tsmUserInfo.ImageTransparentColor = System.Drawing.Color.White;
            this.tsmUserInfo.Name = "tsmUserInfo";
            this.tsmUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsmUserInfo.Size = new System.Drawing.Size(285, 40);
            this.tsmUserInfo.Text = "User Info";
            this.tsmUserInfo.Click += new System.EventHandler(this.tsmUserInfo_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("tsmChangePassword.Image")));
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(285, 40);
            this.tsmChangePassword.Text = "Change Password";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsmLogout.Image")));
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(285, 40);
            this.tsmLogout.Text = "Logout";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(282, 6);
            // 
            // tsmHidden1
            // 
            this.tsmHidden1.AutoSize = false;
            this.tsmHidden1.Name = "tsmHidden1";
            this.tsmHidden1.Size = new System.Drawing.Size(377, 40);
            this.tsmHidden1.Text = "Hidden";
            // 
            // cmsUsers
            // 
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUserInformation,
            this.toolStripSeparator6,
            this.tsmAddUser,
            this.tsmEditUser,
            this.tsmChangeUserPassword,
            this.tsmDeleteUser});
            this.cmsUsers.Name = "cmsPeople";
            this.cmsUsers.Size = new System.Drawing.Size(228, 150);
            // 
            // tsmUserInformation
            // 
            this.tsmUserInformation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmUserInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmUserInformation.Image = ((System.Drawing.Image)(resources.GetObject("tsmUserInformation.Image")));
            this.tsmUserInformation.Name = "tsmUserInformation";
            this.tsmUserInformation.Size = new System.Drawing.Size(227, 28);
            this.tsmUserInformation.Text = "Show Details";
            this.tsmUserInformation.Click += new System.EventHandler(this.tsmUserInformation_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(224, 6);
            // 
            // tsmAddUser
            // 
            this.tsmAddUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tsmAddUser.Image")));
            this.tsmAddUser.Name = "tsmAddUser";
            this.tsmAddUser.Size = new System.Drawing.Size(227, 28);
            this.tsmAddUser.Text = "Add New User";
            this.tsmAddUser.Click += new System.EventHandler(this.tsmAddUser_Click);
            // 
            // tsmEditUser
            // 
            this.tsmEditUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmEditUser.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditUser.Image")));
            this.tsmEditUser.Name = "tsmEditUser";
            this.tsmEditUser.Size = new System.Drawing.Size(227, 28);
            this.tsmEditUser.Text = "Change UserName";
            this.tsmEditUser.Click += new System.EventHandler(this.tsmEditUser_Click);
            // 
            // tsmChangeUserPassword
            // 
            this.tsmChangeUserPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmChangeUserPassword.Image = ((System.Drawing.Image)(resources.GetObject("tsmChangeUserPassword.Image")));
            this.tsmChangeUserPassword.Name = "tsmChangeUserPassword";
            this.tsmChangeUserPassword.Size = new System.Drawing.Size(227, 28);
            this.tsmChangeUserPassword.Text = "Change Password";
            this.tsmChangeUserPassword.Click += new System.EventHandler(this.tsmChangeUserPassword_Click);
            // 
            // tsmDeleteUser
            // 
            this.tsmDeleteUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("tsmDeleteUser.Image")));
            this.tsmDeleteUser.Name = "tsmDeleteUser";
            this.tsmDeleteUser.Size = new System.Drawing.Size(227, 28);
            this.tsmDeleteUser.Text = "Delete";
            this.tsmDeleteUser.Click += new System.EventHandler(this.tsmDeleteUser_Click);
            // 
            // pSideNav
            // 
            this.pSideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(95)))));
            this.pSideNav.Controls.Add(this.ctrlSettingsMenuButton);
            this.pSideNav.Controls.Add(this.ctrlApplicationsMenuButton);
            this.pSideNav.Controls.Add(this.ctrlUsersMenuButton);
            this.pSideNav.Controls.Add(this.ctrlDriversMenuButton);
            this.pSideNav.Controls.Add(this.ctrlPeopleMenuButton);
            this.pSideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSideNav.Location = new System.Drawing.Point(0, 0);
            this.pSideNav.Name = "pSideNav";
            this.pSideNav.Size = new System.Drawing.Size(246, 575);
            this.pSideNav.TabIndex = 1;
            // 
            // ctrlSettingsMenuButton
            // 
            this.ctrlSettingsMenuButton.ButtonName = "Settings";
            this.ctrlSettingsMenuButton.ImageName = "Settings.png";
            this.ctrlSettingsMenuButton.IsActive = false;
            this.ctrlSettingsMenuButton.Location = new System.Drawing.Point(0, 304);
            this.ctrlSettingsMenuButton.Name = "ctrlSettingsMenuButton";
            this.ctrlSettingsMenuButton.Page = null;
            this.ctrlSettingsMenuButton.Size = new System.Drawing.Size(253, 76);
            this.ctrlSettingsMenuButton.TabIndex = 4;
            // 
            // ctrlApplicationsMenuButton
            // 
            this.ctrlApplicationsMenuButton.ButtonName = "Applications";
            this.ctrlApplicationsMenuButton.ImageName = "Application.png";
            this.ctrlApplicationsMenuButton.IsActive = false;
            this.ctrlApplicationsMenuButton.Location = new System.Drawing.Point(0, 228);
            this.ctrlApplicationsMenuButton.Name = "ctrlApplicationsMenuButton";
            this.ctrlApplicationsMenuButton.Page = null;
            this.ctrlApplicationsMenuButton.Size = new System.Drawing.Size(253, 76);
            this.ctrlApplicationsMenuButton.TabIndex = 3;
            // 
            // ctrlUsersMenuButton
            // 
            this.ctrlUsersMenuButton.ButtonName = "Users";
            this.ctrlUsersMenuButton.ImageName = "Users.png";
            this.ctrlUsersMenuButton.IsActive = false;
            this.ctrlUsersMenuButton.Location = new System.Drawing.Point(0, 152);
            this.ctrlUsersMenuButton.Name = "ctrlUsersMenuButton";
            this.ctrlUsersMenuButton.Page = this.ctrlDataPageUsers;
            this.ctrlUsersMenuButton.Size = new System.Drawing.Size(253, 76);
            this.ctrlUsersMenuButton.TabIndex = 2;
            // 
            // ctrlDataPageUsers
            // 
            this.ctrlDataPageUsers.Location = new System.Drawing.Point(256, 0);
            this.ctrlDataPageUsers.Name = "ctrlDataPageUsers";
            this.ctrlDataPageUsers.Size = new System.Drawing.Size(1246, 575);
            this.ctrlDataPageUsers.TabIndex = 9;
            this.ctrlDataPageUsers.Title = "Users";
            this.ctrlDataPageUsers.Visible = false;
            // 
            // ctrlDriversMenuButton
            // 
            this.ctrlDriversMenuButton.ButtonName = "Drivers";
            this.ctrlDriversMenuButton.ImageName = "DriverImg.png";
            this.ctrlDriversMenuButton.IsActive = false;
            this.ctrlDriversMenuButton.Location = new System.Drawing.Point(0, 76);
            this.ctrlDriversMenuButton.Name = "ctrlDriversMenuButton";
            this.ctrlDriversMenuButton.Page = this.ctrlDataPageDrivers;
            this.ctrlDriversMenuButton.Size = new System.Drawing.Size(253, 76);
            this.ctrlDriversMenuButton.TabIndex = 1;
            // 
            // ctrlDataPageDrivers
            // 
            this.ctrlDataPageDrivers.Location = new System.Drawing.Point(256, 0);
            this.ctrlDataPageDrivers.Name = "ctrlDataPageDrivers";
            this.ctrlDataPageDrivers.Size = new System.Drawing.Size(1246, 575);
            this.ctrlDataPageDrivers.TabIndex = 10;
            this.ctrlDataPageDrivers.Title = "Drivers";
            this.ctrlDataPageDrivers.Visible = false;
            // 
            // ctrlPeopleMenuButton
            // 
            this.ctrlPeopleMenuButton.ButtonName = "People";
            this.ctrlPeopleMenuButton.ImageName = "people.png";
            this.ctrlPeopleMenuButton.IsActive = true;
            this.ctrlPeopleMenuButton.Location = new System.Drawing.Point(0, 0);
            this.ctrlPeopleMenuButton.Name = "ctrlPeopleMenuButton";
            this.ctrlPeopleMenuButton.Page = this.ctrlDataPagePeople;
            this.ctrlPeopleMenuButton.Size = new System.Drawing.Size(253, 76);
            this.ctrlPeopleMenuButton.TabIndex = 0;
            // 
            // ctrlDataPagePeople
            // 
            this.ctrlDataPagePeople.Location = new System.Drawing.Point(256, 0);
            this.ctrlDataPagePeople.Name = "ctrlDataPagePeople";
            this.ctrlDataPagePeople.Size = new System.Drawing.Size(1246, 575);
            this.ctrlDataPagePeople.TabIndex = 11;
            this.ctrlDataPagePeople.Title = "People";
            // 
            // pbOff
            // 
            this.pbOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOff.Image = ((System.Drawing.Image)(resources.GetObject("pbOff.Image")));
            this.pbOff.Location = new System.Drawing.Point(1443, 12);
            this.pbOff.Name = "pbOff";
            this.pbOff.Size = new System.Drawing.Size(35, 35);
            this.pbOff.TabIndex = 5;
            this.pbOff.TabStop = false;
            this.pbOff.Click += new System.EventHandler(this.pbOff_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(1390, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(35, 35);
            this.pbMinimize.TabIndex = 7;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 575);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbOff);
            this.Controls.Add(this.pSideNav);
            this.Controls.Add(this.ctrlDataPagePeople);
            this.Controls.Add(this.ctrlDataPageUsers);
            this.Controls.Add(this.ctrlDataPageDrivers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.cmsDrivers.ResumeLayout(false);
            this.cmsPeople.ResumeLayout(false);
            this.cmsApplicationOptions.ResumeLayout(false);
            this.cmsSettings.ResumeLayout(false);
            this.cmsUsers.ResumeLayout(false);
            this.pSideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmDriverInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmInterLic;
        private System.Windows.Forms.ToolStripMenuItem tsmLicHistory;
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
        private System.Windows.Forms.ContextMenuStrip cmsSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmHidden1;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmUserInformation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem tsmAddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmEditUser;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem tsmChangeUserPassword;
        private System.Windows.Forms.Panel pSideNav;
        private System.Windows.Forms.PictureBox pbOff;
        private System.Windows.Forms.PictureBox pbMinimize;
        private ctrlDataPage ctrlDataPageUsers;
        private ctrlDataPage ctrlDataPageDrivers;
        private ctrlDataPage ctrlDataPagePeople;
        private ctrlMenuButton ctrlPeopleMenuButton;
        private ctrlMenuButton ctrlSettingsMenuButton;
        private ctrlMenuButton ctrlApplicationsMenuButton;
        private ctrlMenuButton ctrlUsersMenuButton;
        private ctrlMenuButton ctrlDriversMenuButton;
    }
}

