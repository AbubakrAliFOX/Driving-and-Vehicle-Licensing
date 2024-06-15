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
            this.tsmInterLic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLicHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.pSideNav = new System.Windows.Forms.Panel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDrivers.SuspendLayout();
            this.cmsPeople.SuspendLayout();
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
            this.cmsDrivers.Size = new System.Drawing.Size(255, 88);
            // 
            // tsmDriverInfo
            // 
            this.tsmDriverInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmDriverInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmDriverInfo.Image")));
            this.tsmDriverInfo.Name = "tsmDriverInfo";
            this.tsmDriverInfo.Size = new System.Drawing.Size(254, 26);
            this.tsmDriverInfo.Text = "Show Details";
            this.tsmDriverInfo.Click += new System.EventHandler(this.tsmDriverInfo_Click);
            // 
            // tsmInterLic
            // 
            this.tsmInterLic.Image = ((System.Drawing.Image)(resources.GetObject("tsmInterLic.Image")));
            this.tsmInterLic.Name = "tsmInterLic";
            this.tsmInterLic.Size = new System.Drawing.Size(254, 26);
            this.tsmInterLic.Text = "Issue International License";
            // 
            // tsmLicHistory
            // 
            this.tsmLicHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsmLicHistory.Image")));
            this.tsmLicHistory.Name = "tsmLicHistory";
            this.tsmLicHistory.Size = new System.Drawing.Size(254, 26);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // cmsPeople
            // 
            this.cmsPeople.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPersonInfo,
            this.toolStripSeparator2,
            this.tsmAdd,
            this.tsmEdit});
            this.cmsPeople.Name = "cmsPeople";
            this.cmsPeople.Size = new System.Drawing.Size(215, 122);
            // 
            // tsmPersonInfo
            // 
            this.tsmPersonInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmPersonInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmPersonInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsmPersonInfo.Image")));
            this.tsmPersonInfo.Name = "tsmPersonInfo";
            this.tsmPersonInfo.Size = new System.Drawing.Size(214, 28);
            this.tsmPersonInfo.Text = "Show Details";
            this.tsmPersonInfo.Click += new System.EventHandler(this.tsmPersonInfo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(214, 28);
            this.tsmAdd.Text = "Add New Person";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(214, 28);
            this.tsmEdit.Text = "Edit";
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
    }
}

