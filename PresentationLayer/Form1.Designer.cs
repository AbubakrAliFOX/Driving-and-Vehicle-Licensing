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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rjDropdownMenu = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHidden = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDrivers.SuspendLayout();
            this.cmsPeople.SuspendLayout();
            this.cmsApplicationOptions.SuspendLayout();
            this.rjDropdownMenu.SuspendLayout();
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
            this.toolStripMenuItem1,
            this.manageApplicationsToolStripMenuItem1,
            this.detainLicensesToolStripMenuItem1,
            this.manageApplicationTypesToolStripMenuItem1,
            this.manageTestTypesToolStripMenuItem1,
            this.toolStripSeparator3,
            this.tsmHidden});
            this.cmsApplicationOptions.Name = "cmsApplicationOptions";
            this.cmsApplicationOptions.Size = new System.Drawing.Size(378, 278);
            this.cmsApplicationOptions.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.cmsApplicationOptions_Closed);
            this.cmsApplicationOptions.Opened += new System.EventHandler(this.cmsApplicationOptions_Opened);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem1});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(377, 40);
            this.toolStripMenuItem1.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem1
            // 
            this.newDrivingLicenseToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseToolStripMenuItem,
            this.internationalDrivingLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem1.Name = "newDrivingLicenseToolStripMenuItem1";
            this.newDrivingLicenseToolStripMenuItem1.Size = new System.Drawing.Size(309, 36);
            this.newDrivingLicenseToolStripMenuItem1.Text = "New Driving License";
            // 
            // localDrivingLicenseToolStripMenuItem
            // 
            this.localDrivingLicenseToolStripMenuItem.Name = "localDrivingLicenseToolStripMenuItem";
            this.localDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(313, 36);
            this.localDrivingLicenseToolStripMenuItem.Text = "Local License";
            // 
            // internationalDrivingLicenseToolStripMenuItem
            // 
            this.internationalDrivingLicenseToolStripMenuItem.Name = "internationalDrivingLicenseToolStripMenuItem";
            this.internationalDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(313, 36);
            this.internationalDrivingLicenseToolStripMenuItem.Text = "International License";
            // 
            // manageApplicationsToolStripMenuItem1
            // 
            this.manageApplicationsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationsToolStripMenuItem1.Image")));
            this.manageApplicationsToolStripMenuItem1.Name = "manageApplicationsToolStripMenuItem1";
            this.manageApplicationsToolStripMenuItem1.Size = new System.Drawing.Size(377, 40);
            this.manageApplicationsToolStripMenuItem1.Text = "Manage Applications";
            // 
            // detainLicensesToolStripMenuItem1
            // 
            this.detainLicensesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("detainLicensesToolStripMenuItem1.Image")));
            this.detainLicensesToolStripMenuItem1.Name = "detainLicensesToolStripMenuItem1";
            this.detainLicensesToolStripMenuItem1.Size = new System.Drawing.Size(377, 40);
            this.detainLicensesToolStripMenuItem1.Text = "Detain Licenses";
            // 
            // manageApplicationTypesToolStripMenuItem1
            // 
            this.manageApplicationTypesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationTypesToolStripMenuItem1.Image")));
            this.manageApplicationTypesToolStripMenuItem1.Name = "manageApplicationTypesToolStripMenuItem1";
            this.manageApplicationTypesToolStripMenuItem1.Size = new System.Drawing.Size(377, 40);
            this.manageApplicationTypesToolStripMenuItem1.Text = "Manage Application Types";
            // 
            // manageTestTypesToolStripMenuItem1
            // 
            this.manageTestTypesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("manageTestTypesToolStripMenuItem1.Image")));
            this.manageTestTypesToolStripMenuItem1.Name = "manageTestTypesToolStripMenuItem1";
            this.manageTestTypesToolStripMenuItem1.Size = new System.Drawing.Size(377, 40);
            this.manageTestTypesToolStripMenuItem1.Text = "Manage Test Types";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(374, 6);
            // 
            // rjDropdownMenu
            // 
            this.rjDropdownMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rjDropdownMenu.IsMainMenu = false;
            this.rjDropdownMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.rjDropdownMenu.MenuItemHeight = 25;
            this.rjDropdownMenu.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu.Name = "rjDropdownMenu";
            this.rjDropdownMenu.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu.Size = new System.Drawing.Size(255, 124);
            this.rjDropdownMenu.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.rjDropdownMenu_Closed);
            this.rjDropdownMenu.Opened += new System.EventHandler(this.rjDropdownMenu_Opened);
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem});
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.drivingLicensesServicesToolStripMenuItem.Text = "Driving License Services";
            this.drivingLicensesServicesToolStripMenuItem.Click += new System.EventHandler(this.drivingLicensesServicesToolStripMenuItem_Click);
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.helloToolStripMenuItem.Text = "Hello";
            // 
            // tsmHidden
            // 
            this.tsmHidden.AutoSize = false;
            this.tsmHidden.Name = "tsmHidden";
            this.tsmHidden.Size = new System.Drawing.Size(377, 40);
            this.tsmHidden.Text = "Hidden";
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
            this.rjDropdownMenu.ResumeLayout(false);
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
        private CustomControls.RJControls.RJDropdownMenu rjDropdownMenu;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmHidden;
    }
}

