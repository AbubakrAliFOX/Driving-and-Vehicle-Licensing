namespace PresentationLayer
{
    partial class frmScheduleTest
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpTestDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.lblFeesDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAttempt = new System.Windows.Forms.Label();
            this.LisenceClass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.gbRetakeTestInfo = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblRetestDisplay = new System.Windows.Forms.Label();
            this.lblRetakeTestFees = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblRetakeTestID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.gbRetakeTestInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(22, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 42);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Schedule Vision Test";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblAppointmentID);
            this.groupBox3.Controls.Add(this.dtpTestDate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblFees);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblApplicantName);
            this.groupBox3.Controls.Add(this.lblFeesDisplay);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblApplicationID);
            this.groupBox3.Controls.Add(this.lblClass);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblAttempt);
            this.groupBox3.Controls.Add(this.LisenceClass);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblDLAppID);
            this.groupBox3.Location = new System.Drawing.Point(14, 66);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(360, 286);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application Info";
            // 
            // dtpTestDate
            // 
            this.dtpTestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTestDate.Location = new System.Drawing.Point(145, 241);
            this.dtpTestDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTestDate.Name = "dtpTestDate";
            this.dtpTestDate.Size = new System.Drawing.Size(122, 20);
            this.dtpTestDate.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date:";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(145, 210);
            this.lblFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(0, 17);
            this.lblFees.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Applicant:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantName.Location = new System.Drawing.Point(145, 150);
            this.lblApplicantName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(0, 17);
            this.lblApplicantName.TabIndex = 20;
            // 
            // lblFeesDisplay
            // 
            this.lblFeesDisplay.AutoSize = true;
            this.lblFeesDisplay.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeesDisplay.Location = new System.Drawing.Point(16, 208);
            this.lblFeesDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFeesDisplay.Name = "lblFeesDisplay";
            this.lblFeesDisplay.Size = new System.Drawing.Size(41, 18);
            this.lblFeesDisplay.TabIndex = 19;
            this.lblFeesDisplay.Text = "Fees:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "ApplicationID:";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(145, 87);
            this.lblApplicationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(20, 17);
            this.lblApplicationID.TabIndex = 17;
            this.lblApplicationID.Text = "??";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(145, 119);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 17);
            this.lblClass.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Attempt:";
            // 
            // lblAttempt
            // 
            this.lblAttempt.AutoSize = true;
            this.lblAttempt.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempt.Location = new System.Drawing.Point(145, 178);
            this.lblAttempt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttempt.Name = "lblAttempt";
            this.lblAttempt.Size = new System.Drawing.Size(0, 17);
            this.lblAttempt.TabIndex = 14;
            // 
            // LisenceClass
            // 
            this.LisenceClass.AutoSize = true;
            this.LisenceClass.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LisenceClass.Location = new System.Drawing.Point(16, 117);
            this.LisenceClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LisenceClass.Name = "LisenceClass";
            this.LisenceClass.Size = new System.Drawing.Size(92, 18);
            this.LisenceClass.TabIndex = 11;
            this.LisenceClass.Text = "License Class:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "D.L.AppID:";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppID.Location = new System.Drawing.Point(145, 56);
            this.lblDLAppID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(20, 17);
            this.lblDLAppID.TabIndex = 6;
            this.lblDLAppID.Text = "??";
            // 
            // gbRetakeTestInfo
            // 
            this.gbRetakeTestInfo.Controls.Add(this.label26);
            this.gbRetakeTestInfo.Controls.Add(this.label27);
            this.gbRetakeTestInfo.Controls.Add(this.lblRetestDisplay);
            this.gbRetakeTestInfo.Controls.Add(this.lblRetakeTestFees);
            this.gbRetakeTestInfo.Controls.Add(this.label24);
            this.gbRetakeTestInfo.Controls.Add(this.lblRetakeTestID);
            this.gbRetakeTestInfo.Enabled = false;
            this.gbRetakeTestInfo.Location = new System.Drawing.Point(14, 369);
            this.gbRetakeTestInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbRetakeTestInfo.Name = "gbRetakeTestInfo";
            this.gbRetakeTestInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbRetakeTestInfo.Size = new System.Drawing.Size(360, 90);
            this.gbRetakeTestInfo.TabIndex = 33;
            this.gbRetakeTestInfo.TabStop = false;
            this.gbRetakeTestInfo.Text = "Retake Test Info";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(16, 92);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 18);
            this.label26.TabIndex = 34;
            this.label26.Text = "Total Fees:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(130, 92);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(20, 17);
            this.label27.TabIndex = 33;
            this.label27.Text = "??";
            // 
            // lblRetestDisplay
            // 
            this.lblRetestDisplay.AutoSize = true;
            this.lblRetestDisplay.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetestDisplay.Location = new System.Drawing.Point(16, 63);
            this.lblRetestDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetestDisplay.Name = "lblRetestDisplay";
            this.lblRetestDisplay.Size = new System.Drawing.Size(84, 18);
            this.lblRetestDisplay.TabIndex = 18;
            this.lblRetestDisplay.Text = "Retest Fees:";
            // 
            // lblRetakeTestFees
            // 
            this.lblRetakeTestFees.AutoSize = true;
            this.lblRetakeTestFees.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetakeTestFees.Location = new System.Drawing.Point(130, 63);
            this.lblRetakeTestFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetakeTestFees.Name = "lblRetakeTestFees";
            this.lblRetakeTestFees.Size = new System.Drawing.Size(20, 17);
            this.lblRetakeTestFees.TabIndex = 17;
            this.lblRetakeTestFees.Text = "??";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(16, 32);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 18);
            this.label24.TabIndex = 8;
            this.label24.Text = "Retest ID:";
            // 
            // lblRetakeTestID
            // 
            this.lblRetakeTestID.AutoSize = true;
            this.lblRetakeTestID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetakeTestID.Location = new System.Drawing.Point(130, 32);
            this.lblRetakeTestID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetakeTestID.Name = "lblRetakeTestID";
            this.lblRetakeTestID.Size = new System.Drawing.Size(20, 17);
            this.lblRetakeTestID.TabIndex = 6;
            this.lblRetakeTestID.Text = "??";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(100, 476);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 28);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(233, 476);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 28);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Schedule Test";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "ApppointmentID:";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(145, 27);
            this.lblAppointmentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(20, 17);
            this.lblAppointmentID.TabIndex = 33;
            this.lblAppointmentID.Text = "??";
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 518);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbRetakeTestInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbRetakeTestInfo.ResumeLayout(false);
            this.gbRetakeTestInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblFeesDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAttempt;
        private System.Windows.Forms.Label LisenceClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.DateTimePicker dtpTestDate;
        private System.Windows.Forms.GroupBox gbRetakeTestInfo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblRetestDisplay;
        private System.Windows.Forms.Label lblRetakeTestFees;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblRetakeTestID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAppointmentID;
    }
}