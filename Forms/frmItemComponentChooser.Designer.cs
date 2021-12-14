
namespace ArenaModdingTool.Forms
{
    partial class frmItemComponentChooser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbItemComponentWeapon = new System.Windows.Forms.RadioButton();
            this.rbItemComponentArmour = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbItemComponentWeapon);
            this.groupBox1.Controls.Add(this.rbItemComponentArmour);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(406, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbItemComponentWeapon
            // 
            this.rbItemComponentWeapon.AutoSize = true;
            this.rbItemComponentWeapon.Location = new System.Drawing.Point(129, 80);
            this.rbItemComponentWeapon.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbItemComponentWeapon.Name = "rbItemComponentWeapon";
            this.rbItemComponentWeapon.Size = new System.Drawing.Size(91, 28);
            this.rbItemComponentWeapon.TabIndex = 1;
            this.rbItemComponentWeapon.TabStop = true;
            this.rbItemComponentWeapon.Text = "Weapon";
            this.rbItemComponentWeapon.UseVisualStyleBackColor = true;
            // 
            // rbItemComponentArmour
            // 
            this.rbItemComponentArmour.AutoSize = true;
            this.rbItemComponentArmour.Location = new System.Drawing.Point(129, 40);
            this.rbItemComponentArmour.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.rbItemComponentArmour.Name = "rbItemComponentArmour";
            this.rbItemComponentArmour.Size = new System.Drawing.Size(85, 28);
            this.rbItemComponentArmour.TabIndex = 0;
            this.rbItemComponentArmour.TabStop = true;
            this.rbItemComponentArmour.Text = "Armour";
            this.rbItemComponentArmour.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(272, 144);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 46);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(137, 144);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 46);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmItemComponentChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 209);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemComponentChooser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Component";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbItemComponentWeapon;
        private System.Windows.Forms.RadioButton rbItemComponentArmour;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}