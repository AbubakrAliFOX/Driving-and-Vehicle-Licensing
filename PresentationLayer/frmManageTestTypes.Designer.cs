namespace PresentationLayer
{
    partial class frmManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestTypes));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmsDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.cmsDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(625, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 35);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(289, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 54);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Test Types";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsNumber.Location = new System.Drawing.Point(177, 548);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(24, 28);
            this.lblRecordsNumber.TabIndex = 18;
            this.lblRecordsNumber.Text = "6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total Records:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.cmsDataGridView;
            this.dgv.Location = new System.Drawing.Point(37, 131);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(751, 374);
            this.dgv.TabIndex = 16;
            // 
            // cmsDataGridView
            // 
            this.cmsDataGridView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit});
            this.cmsDataGridView.Name = "contextMenuStrip1";
            this.cmsDataGridView.Size = new System.Drawing.Size(113, 32);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsmEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmEdit.Image")));
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(112, 28);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 614);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageTestTypes";
            this.Text = "frmManageTestTypes";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.cmsDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip cmsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
    }
}