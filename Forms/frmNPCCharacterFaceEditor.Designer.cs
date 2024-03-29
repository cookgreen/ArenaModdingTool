﻿namespace ArenaModdingTool.Forms
{
    partial class frmNPCCharacterFaceEditor
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDonotUseFaceKeyTemplate = new System.Windows.Forms.RadioButton();
            this.txtFaceKeyTemplate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbUseFaceKeyTemplate = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBodyPropertiesMaxKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBodyPropertiesMaxBuild = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBodyPropertiesMaxWeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBodyPropertiesMaxAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBodyPropertiesMaxVersion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkUseBodyPropertiesMax = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBodyPropertiesKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtBodyPropertiesBuild = new System.Windows.Forms.Label();
            this.txtBodyPropertiesWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBodyPropertiesAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBodyPropertiesVersion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDonotUseFaceKeyTemplate);
            this.groupBox3.Controls.Add(this.txtFaceKeyTemplate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rbUseFaceKeyTemplate);
            this.groupBox3.Controls.Add(this.btnOK);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.chkUseBodyPropertiesMax);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Size = new System.Drawing.Size(805, 613);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // rbDonotUseFaceKeyTemplate
            // 
            this.rbDonotUseFaceKeyTemplate.AutoSize = true;
            this.rbDonotUseFaceKeyTemplate.Checked = true;
            this.rbDonotUseFaceKeyTemplate.Location = new System.Drawing.Point(10, 106);
            this.rbDonotUseFaceKeyTemplate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbDonotUseFaceKeyTemplate.Name = "rbDonotUseFaceKeyTemplate";
            this.rbDonotUseFaceKeyTemplate.Size = new System.Drawing.Size(252, 28);
            this.rbDonotUseFaceKeyTemplate.TabIndex = 17;
            this.rbDonotUseFaceKeyTemplate.TabStop = true;
            this.rbDonotUseFaceKeyTemplate.Text = "Don\'t Use Face Key Template";
            this.rbDonotUseFaceKeyTemplate.UseVisualStyleBackColor = true;
            this.rbDonotUseFaceKeyTemplate.CheckedChanged += new System.EventHandler(this.rbDonotUseFaceKeyTemplate_CheckedChanged);
            // 
            // txtFaceKeyTemplate
            // 
            this.txtFaceKeyTemplate.Location = new System.Drawing.Point(220, 64);
            this.txtFaceKeyTemplate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFaceKeyTemplate.Name = "txtFaceKeyTemplate";
            this.txtFaceKeyTemplate.ReadOnly = true;
            this.txtFaceKeyTemplate.Size = new System.Drawing.Size(564, 30);
            this.txtFaceKeyTemplate.TabIndex = 16;
            this.txtFaceKeyTemplate.DoubleClick += new System.EventHandler(this.txtFaceKeyTemplate_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Face Key Template:";
            // 
            // rbUseFaceKeyTemplate
            // 
            this.rbUseFaceKeyTemplate.AutoSize = true;
            this.rbUseFaceKeyTemplate.Location = new System.Drawing.Point(10, 24);
            this.rbUseFaceKeyTemplate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbUseFaceKeyTemplate.Name = "rbUseFaceKeyTemplate";
            this.rbUseFaceKeyTemplate.Size = new System.Drawing.Size(209, 28);
            this.rbUseFaceKeyTemplate.TabIndex = 14;
            this.rbUseFaceKeyTemplate.Text = "Use Face Key Template";
            this.rbUseFaceKeyTemplate.UseVisualStyleBackColor = true;
            this.rbUseFaceKeyTemplate.CheckedChanged += new System.EventHandler(this.rbUseFaceKeyTemplate_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(519, 547);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 46);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(659, 547);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 46);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBodyPropertiesMaxKey);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBodyPropertiesMaxBuild);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBodyPropertiesMaxWeight);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBodyPropertiesMaxAge);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBodyPropertiesMaxVersion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(20, 369);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(764, 166);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Body Properties Max";
            // 
            // txtBodyPropertiesMaxKey
            // 
            this.txtBodyPropertiesMaxKey.Enabled = false;
            this.txtBodyPropertiesMaxKey.Location = new System.Drawing.Point(110, 119);
            this.txtBodyPropertiesMaxKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBodyPropertiesMaxKey.Name = "txtBodyPropertiesMaxKey";
            this.txtBodyPropertiesMaxKey.Size = new System.Drawing.Size(624, 30);
            this.txtBodyPropertiesMaxKey.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "key:";
            // 
            // txtBodyPropertiesMaxBuild
            // 
            this.txtBodyPropertiesMaxBuild.Enabled = false;
            this.txtBodyPropertiesMaxBuild.Location = new System.Drawing.Point(499, 77);
            this.txtBodyPropertiesMaxBuild.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBodyPropertiesMaxBuild.Name = "txtBodyPropertiesMaxBuild";
            this.txtBodyPropertiesMaxBuild.Size = new System.Drawing.Size(235, 30);
            this.txtBodyPropertiesMaxBuild.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Build:";
            // 
            // txtBodyPropertiesMaxWeight
            // 
            this.txtBodyPropertiesMaxWeight.Enabled = false;
            this.txtBodyPropertiesMaxWeight.Location = new System.Drawing.Point(499, 35);
            this.txtBodyPropertiesMaxWeight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBodyPropertiesMaxWeight.Name = "txtBodyPropertiesMaxWeight";
            this.txtBodyPropertiesMaxWeight.Size = new System.Drawing.Size(235, 30);
            this.txtBodyPropertiesMaxWeight.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Weight:";
            // 
            // txtBodyPropertiesMaxAge
            // 
            this.txtBodyPropertiesMaxAge.Enabled = false;
            this.txtBodyPropertiesMaxAge.Location = new System.Drawing.Point(110, 77);
            this.txtBodyPropertiesMaxAge.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBodyPropertiesMaxAge.Name = "txtBodyPropertiesMaxAge";
            this.txtBodyPropertiesMaxAge.Size = new System.Drawing.Size(235, 30);
            this.txtBodyPropertiesMaxAge.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Age:";
            // 
            // txtBodyPropertiesMaxVersion
            // 
            this.txtBodyPropertiesMaxVersion.Enabled = false;
            this.txtBodyPropertiesMaxVersion.Location = new System.Drawing.Point(110, 35);
            this.txtBodyPropertiesMaxVersion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBodyPropertiesMaxVersion.Name = "txtBodyPropertiesMaxVersion";
            this.txtBodyPropertiesMaxVersion.Size = new System.Drawing.Size(235, 30);
            this.txtBodyPropertiesMaxVersion.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Version:";
            // 
            // chkUseBodyPropertiesMax
            // 
            this.chkUseBodyPropertiesMax.AutoSize = true;
            this.chkUseBodyPropertiesMax.Location = new System.Drawing.Point(35, 329);
            this.chkUseBodyPropertiesMax.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkUseBodyPropertiesMax.Name = "chkUseBodyPropertiesMax";
            this.chkUseBodyPropertiesMax.Size = new System.Drawing.Size(219, 28);
            this.chkUseBodyPropertiesMax.TabIndex = 10;
            this.chkUseBodyPropertiesMax.Text = "Use Body Properties Max";
            this.chkUseBodyPropertiesMax.UseVisualStyleBackColor = true;
            this.chkUseBodyPropertiesMax.CheckedChanged += new System.EventHandler(this.chkUseBodyPropertiesMax_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBodyPropertiesKey);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txtBodyPropertiesBuild);
            this.groupBox1.Controls.Add(this.txtBodyPropertiesWeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBodyPropertiesAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBodyPropertiesVersion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(764, 171);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Body Properties";
            // 
            // txtBodyPropertiesKey
            // 
            this.txtBodyPropertiesKey.Location = new System.Drawing.Point(110, 119);
            this.txtBodyPropertiesKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBodyPropertiesKey.Name = "txtBodyPropertiesKey";
            this.txtBodyPropertiesKey.Size = new System.Drawing.Size(624, 30);
            this.txtBodyPropertiesKey.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "key:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(499, 77);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 30);
            this.textBox3.TabIndex = 7;
            // 
            // txtBodyPropertiesBuild
            // 
            this.txtBodyPropertiesBuild.AutoSize = true;
            this.txtBodyPropertiesBuild.Location = new System.Drawing.Point(400, 80);
            this.txtBodyPropertiesBuild.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtBodyPropertiesBuild.Name = "txtBodyPropertiesBuild";
            this.txtBodyPropertiesBuild.Size = new System.Drawing.Size(50, 24);
            this.txtBodyPropertiesBuild.TabIndex = 6;
            this.txtBodyPropertiesBuild.Text = "Build:";
            // 
            // txtBodyPropertiesWeight
            // 
            this.txtBodyPropertiesWeight.Location = new System.Drawing.Point(499, 35);
            this.txtBodyPropertiesWeight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBodyPropertiesWeight.Name = "txtBodyPropertiesWeight";
            this.txtBodyPropertiesWeight.Size = new System.Drawing.Size(235, 30);
            this.txtBodyPropertiesWeight.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight:";
            // 
            // txtBodyPropertiesAge
            // 
            this.txtBodyPropertiesAge.Location = new System.Drawing.Point(110, 77);
            this.txtBodyPropertiesAge.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBodyPropertiesAge.Name = "txtBodyPropertiesAge";
            this.txtBodyPropertiesAge.Size = new System.Drawing.Size(235, 30);
            this.txtBodyPropertiesAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // txtBodyPropertiesVersion
            // 
            this.txtBodyPropertiesVersion.Location = new System.Drawing.Point(110, 35);
            this.txtBodyPropertiesVersion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtBodyPropertiesVersion.Name = "txtBodyPropertiesVersion";
            this.txtBodyPropertiesVersion.Size = new System.Drawing.Size(235, 30);
            this.txtBodyPropertiesVersion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version:";
            // 
            // frmNPCCharacterFaceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 613);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNPCCharacterFaceEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPC Character Face Editor";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDonotUseFaceKeyTemplate;
        private System.Windows.Forms.TextBox txtFaceKeyTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbUseFaceKeyTemplate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBodyPropertiesMaxKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBodyPropertiesMaxBuild;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBodyPropertiesMaxWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBodyPropertiesMaxAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBodyPropertiesMaxVersion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkUseBodyPropertiesMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBodyPropertiesKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtBodyPropertiesBuild;
        private System.Windows.Forms.TextBox txtBodyPropertiesWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBodyPropertiesAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBodyPropertiesVersion;
        private System.Windows.Forms.Label label1;
    }
}