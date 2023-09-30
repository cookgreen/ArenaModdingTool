namespace ArenaModdingTool
{
    partial class frmImportProject
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
			this.lbModLocation = new System.Windows.Forms.Label();
			this.txtModuleLocation = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbModLocation
			// 
			this.lbModLocation.AutoSize = true;
			this.lbModLocation.Location = new System.Drawing.Point(14, 30);
			this.lbModLocation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbModLocation.Name = "lbModLocation";
			this.lbModLocation.Size = new System.Drawing.Size(135, 24);
			this.lbModLocation.TabIndex = 0;
			this.lbModLocation.Text = "Module Location:";
			// 
			// txtModuleLocation
			// 
			this.txtModuleLocation.Location = new System.Drawing.Point(169, 27);
			this.txtModuleLocation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtModuleLocation.Name = "txtModuleLocation";
			this.txtModuleLocation.ReadOnly = true;
			this.txtModuleLocation.Size = new System.Drawing.Size(460, 30);
			this.txtModuleLocation.TabIndex = 1;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(639, 19);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(70, 46);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(584, 108);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(125, 46);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(449, 108);
			this.btnOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(125, 46);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// frmImportProject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 166);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtModuleLocation);
			this.Controls.Add(this.lbModLocation);
			this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmImportProject";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Import Project";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbModLocation;
        private System.Windows.Forms.TextBox txtModuleLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}