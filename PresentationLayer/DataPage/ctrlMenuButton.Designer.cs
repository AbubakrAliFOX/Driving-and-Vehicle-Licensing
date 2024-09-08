namespace PresentationLayer
{
    partial class ctrlMenuButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlMenuButton));
            this.pSidePanel = new System.Windows.Forms.Panel();
            this.btnMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pSidePanel
            // 
            this.pSidePanel.BackColor = System.Drawing.Color.Gold;
            this.pSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pSidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.pSidePanel.Name = "pSidePanel";
            this.pSidePanel.Size = new System.Drawing.Size(5, 62);
            this.pSidePanel.TabIndex = 3;
            this.pSidePanel.Visible = false;
            // 
            // btnMenuButton
            // 
            this.btnMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(95)))));
            this.btnMenuButton.FlatAppearance.BorderSize = 0;
            this.btnMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuButton.ForeColor = System.Drawing.Color.White;
            this.btnMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuButton.Image")));
            this.btnMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuButton.Location = new System.Drawing.Point(5, 0);
            this.btnMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuButton.Name = "btnMenuButton";
            this.btnMenuButton.Size = new System.Drawing.Size(184, 62);
            this.btnMenuButton.TabIndex = 1;
            this.btnMenuButton.Text = "        Drivers";
            this.btnMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuButton.UseVisualStyleBackColor = false;
            // 
            // ctrlMenuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pSidePanel);
            this.Controls.Add(this.btnMenuButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ctrlMenuButton";
            this.Size = new System.Drawing.Size(190, 62);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pSidePanel;
        private System.Windows.Forms.Button btnMenuButton;
    }
}
