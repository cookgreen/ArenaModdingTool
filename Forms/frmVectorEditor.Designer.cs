﻿
namespace ArenaModdingTool.Forms
{
    partial class frmVectorEditor
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.txtVectorX = new System.Windows.Forms.NumericUpDown();
			this.txtVectorY = new System.Windows.Forms.NumericUpDown();
			this.txtVectorZ = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.txtVectorX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVectorY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVectorZ)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "X:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 61);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 103);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Z:";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(301, 142);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(125, 46);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(166, 142);
			this.btnOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(125, 46);
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txtVectorX
			// 
			this.txtVectorX.Location = new System.Drawing.Point(62, 12);
			this.txtVectorX.Name = "txtVectorX";
			this.txtVectorX.Size = new System.Drawing.Size(364, 30);
			this.txtVectorX.TabIndex = 8;
			// 
			// txtVectorY
			// 
			this.txtVectorY.Location = new System.Drawing.Point(62, 55);
			this.txtVectorY.Name = "txtVectorY";
			this.txtVectorY.Size = new System.Drawing.Size(364, 30);
			this.txtVectorY.TabIndex = 9;
			// 
			// txtVectorZ
			// 
			this.txtVectorZ.Location = new System.Drawing.Point(62, 100);
			this.txtVectorZ.Name = "txtVectorZ";
			this.txtVectorZ.Size = new System.Drawing.Size(364, 30);
			this.txtVectorZ.TabIndex = 10;
			// 
			// frmVectorEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 202);
			this.Controls.Add(this.txtVectorZ);
			this.Controls.Add(this.txtVectorY);
			this.Controls.Add(this.txtVectorX);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmVectorEditor";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vector Editor";
			((System.ComponentModel.ISupportInitialize)(this.txtVectorX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVectorY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtVectorZ)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.NumericUpDown txtVectorX;
		private System.Windows.Forms.NumericUpDown txtVectorY;
		private System.Windows.Forms.NumericUpDown txtVectorZ;
	}
}