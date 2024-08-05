namespace PresentationLayer
{
    partial class frmReplaceLicense
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
            this.btnIssue = new System.Windows.Forms.Button();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReplacedID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOldID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.LisenceClass = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlFindLicense1 = new PresentationLayer.ctrlFindLicense();
            this.llLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.llLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(545, 757);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(228, 35);
            this.btnIssue.TabIndex = 42;
            this.btnIssue.Text = "Issue Replacement";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(628, 114);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(0, 21);
            this.lblCreatedBy.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Created By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Replaced License ID:";
            // 
            // lblReplacedID
            // 
            this.lblReplacedID.AutoSize = true;
            this.lblReplacedID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedID.Location = new System.Drawing.Point(628, 39);
            this.lblReplacedID.Name = "lblReplacedID";
            this.lblReplacedID.Size = new System.Drawing.Size(0, 21);
            this.lblReplacedID.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Old License ID:";
            // 
            // lblOldID
            // 
            this.lblOldID.AutoSize = true;
            this.lblOldID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldID.Location = new System.Drawing.Point(628, 76);
            this.lblOldID.Name = "lblOldID";
            this.lblOldID.Size = new System.Drawing.Size(0, 21);
            this.lblOldID.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "ApplicationID:";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(171, 76);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(0, 21);
            this.lblApplicationDate.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Application Fees:";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(171, 114);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(0, 21);
            this.lblApplicationFees.TabIndex = 14;
            // 
            // LisenceClass
            // 
            this.LisenceClass.AutoSize = true;
            this.LisenceClass.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisenceClass.Location = new System.Drawing.Point(22, 75);
            this.LisenceClass.Name = "LisenceClass";
            this.LisenceClass.Size = new System.Drawing.Size(136, 22);
            this.LisenceClass.TabIndex = 11;
            this.LisenceClass.Text = "Application Date:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(369, 757);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 35);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCreatedBy);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblReplacedID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblOldID);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblApplicationID);
            this.groupBox3.Controls.Add(this.lblApplicationDate);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblApplicationFees);
            this.groupBox3.Controls.Add(this.LisenceClass);
            this.groupBox3.Location = new System.Drawing.Point(8, 575);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 158);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application Info";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(171, 39);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(26, 21);
            this.lblApplicationID.TabIndex = 17;
            this.lblApplicationID.Text = "??";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(88, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(628, 54);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "License Replacement Application";
            // 
            // ctrlFindLicense1
            // 
            this.ctrlFindLicense1.LicenseInfo = null;
            this.ctrlFindLicense1.Location = new System.Drawing.Point(0, 63);
            this.ctrlFindLicense1.Name = "ctrlFindLicense1";
            this.ctrlFindLicense1.Size = new System.Drawing.Size(785, 506);
            this.ctrlFindLicense1.TabIndex = 38;
            // 
            // llLicensesHistory
            // 
            this.llLicensesHistory.AutoSize = true;
            this.llLicensesHistory.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLicensesHistory.Location = new System.Drawing.Point(12, 762);
            this.llLicensesHistory.Name = "llLicensesHistory";
            this.llLicensesHistory.Size = new System.Drawing.Size(175, 22);
            this.llLicensesHistory.TabIndex = 63;
            this.llLicensesHistory.TabStop = true;
            this.llLicensesHistory.Text = "Show Licenses History";
            // 
            // llLicenseInfo
            // 
            this.llLicenseInfo.AutoSize = true;
            this.llLicenseInfo.Enabled = false;
            this.llLicenseInfo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLicenseInfo.Location = new System.Drawing.Point(191, 762);
            this.llLicenseInfo.Name = "llLicenseInfo";
            this.llLicenseInfo.Size = new System.Drawing.Size(149, 22);
            this.llLicenseInfo.TabIndex = 62;
            this.llLicenseInfo.TabStop = true;
            this.llLicenseInfo.Text = "Show New License";
            this.llLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLicenseInfo_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLost);
            this.groupBox1.Controls.Add(this.rbDamaged);
            this.groupBox1.Location = new System.Drawing.Point(529, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 100);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement For:";
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.rbLost.Location = new System.Drawing.Point(16, 59);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(114, 25);
            this.rbLost.TabIndex = 1;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Lost License";
            this.rbLost.UseVisualStyleBackColor = true;
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDamaged.Location = new System.Drawing.Point(16, 25);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(150, 25);
            this.rbDamaged.TabIndex = 0;
            this.rbDamaged.TabStop = true;
            this.rbDamaged.Text = "Damaged License";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.rbDamaged_CheckedChanged);
            // 
            // frmReplaceLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 813);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llLicensesHistory);
            this.Controls.Add(this.llLicenseInfo);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlFindLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplaceLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace License";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReplacedID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOldID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label LisenceClass;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblTitle;
        private ctrlFindLicense ctrlFindLicense1;
        private System.Windows.Forms.LinkLabel llLicensesHistory;
        private System.Windows.Forms.LinkLabel llLicenseInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.RadioButton rbDamaged;
    }
}