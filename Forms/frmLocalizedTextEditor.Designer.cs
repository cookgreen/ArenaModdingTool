namespace ArenaModdingTool.Forms
{
    partial class frmLocalizedTextEditor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.lbLocalizedID = new System.Windows.Forms.Label();
			this.lbOriginalText = new System.Windows.Forms.Label();
			this.txtLocalizedID = new System.Windows.Forms.TextBox();
			this.txtOriginalText = new System.Windows.Forms.RichTextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbLocalizedID
			// 
			this.lbLocalizedID.AutoSize = true;
			this.lbLocalizedID.Location = new System.Drawing.Point(13, 13);
			this.lbLocalizedID.Name = "lbLocalizedID";
			this.lbLocalizedID.Size = new System.Drawing.Size(117, 23);
			this.lbLocalizedID.TabIndex = 0;
			this.lbLocalizedID.Text = "localized ID:";
			// 
			// lbOriginalText
			// 
			this.lbOriginalText.AutoSize = true;
			this.lbOriginalText.Location = new System.Drawing.Point(13, 57);
			this.lbOriginalText.Name = "lbOriginalText";
			this.lbOriginalText.Size = new System.Drawing.Size(52, 23);
			this.lbOriginalText.TabIndex = 1;
			this.lbOriginalText.Text = "Text:";
			// 
			// txtLocalizedID
			// 
			this.txtLocalizedID.Location = new System.Drawing.Point(136, 10);
			this.txtLocalizedID.Name = "txtLocalizedID";
			this.txtLocalizedID.Size = new System.Drawing.Size(544, 30);
			this.txtLocalizedID.TabIndex = 2;
			// 
			// txtOriginalText
			// 
			this.txtOriginalText.Location = new System.Drawing.Point(136, 57);
			this.txtOriginalText.Name = "txtOriginalText";
			this.txtOriginalText.Size = new System.Drawing.Size(544, 362);
			this.txtOriginalText.TabIndex = 3;
			this.txtOriginalText.Text = "";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(590, 425);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(90, 43);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(494, 425);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(90, 43);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// frmLocalizedTextEditor
			// 
			this.ClientSize = new System.Drawing.Size(692, 480);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtOriginalText);
			this.Controls.Add(this.txtLocalizedID);
			this.Controls.Add(this.lbOriginalText);
			this.Controls.Add(this.lbLocalizedID);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLocalizedTextEditor";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Localized Text Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLocalizedID;
        private System.Windows.Forms.Label lbOriginalText;
        private System.Windows.Forms.TextBox txtLocalizedID;
        private System.Windows.Forms.RichTextBox txtOriginalText;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}
