namespace ArenaModdingTool.Controls
{
    partial class ucHeroDetails
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBannerKey = new System.Windows.Forms.TextBox();
			this.txtSpouse = new System.Windows.Forms.TextBox();
			this.txtFaction = new System.Windows.Forms.TextBox();
			this.txtMother = new System.Windows.Forms.TextBox();
			this.txtFather = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.chkIsNoble = new System.Windows.Forms.CheckBox();
			this.chkIsAlive = new System.Windows.Forms.CheckBox();
			this.txtIntroduction = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(585, 588);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 551);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(579, 34);
			this.panel1.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(501, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtBannerKey, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.txtSpouse, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.txtFaction, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.txtMother, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.txtFather, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.chkIsNoble, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.chkIsAlive, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.txtIntroduction, 1, 8);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 542);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(3, 200);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(144, 125);
			this.label9.TabIndex = 27;
			this.label9.Text = "text";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(3, 175);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 25);
			this.label8.TabIndex = 26;
			this.label8.Text = "banner_key";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(3, 150);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 25);
			this.label7.TabIndex = 25;
			this.label7.Text = "spouse";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(144, 25);
			this.label6.TabIndex = 24;
			this.label6.Text = "faction";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 25);
			this.label4.TabIndex = 22;
			this.label4.Text = "mother";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 25);
			this.label3.TabIndex = 21;
			this.label3.Text = "father";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtBannerKey
			// 
			this.txtBannerKey.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBannerKey.Location = new System.Drawing.Point(153, 178);
			this.txtBannerKey.Name = "txtBannerKey";
			this.txtBannerKey.Size = new System.Drawing.Size(423, 25);
			this.txtBannerKey.TabIndex = 16;
			// 
			// txtSpouse
			// 
			this.txtSpouse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSpouse.Location = new System.Drawing.Point(153, 153);
			this.txtSpouse.Name = "txtSpouse";
			this.txtSpouse.Size = new System.Drawing.Size(423, 25);
			this.txtSpouse.TabIndex = 14;
			// 
			// txtFaction
			// 
			this.txtFaction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtFaction.Location = new System.Drawing.Point(153, 128);
			this.txtFaction.Name = "txtFaction";
			this.txtFaction.Size = new System.Drawing.Size(423, 25);
			this.txtFaction.TabIndex = 12;
			// 
			// txtMother
			// 
			this.txtMother.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMother.Location = new System.Drawing.Point(153, 78);
			this.txtMother.Name = "txtMother";
			this.txtMother.Size = new System.Drawing.Size(423, 25);
			this.txtMother.TabIndex = 8;
			// 
			// txtFather
			// 
			this.txtFather.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtFather.Location = new System.Drawing.Point(153, 53);
			this.txtFather.Name = "txtFather";
			this.txtFather.Size = new System.Drawing.Size(423, 25);
			this.txtFather.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtID
			// 
			this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtID.Location = new System.Drawing.Point(153, 3);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(423, 25);
			this.txtID.TabIndex = 2;
			// 
			// chkIsNoble
			// 
			this.chkIsNoble.AutoSize = true;
			this.chkIsNoble.Location = new System.Drawing.Point(153, 28);
			this.chkIsNoble.Name = "chkIsNoble";
			this.chkIsNoble.Size = new System.Drawing.Size(77, 19);
			this.chkIsNoble.TabIndex = 19;
			this.chkIsNoble.Text = "Noble?";
			this.chkIsNoble.UseVisualStyleBackColor = true;
			// 
			// chkIsAlive
			// 
			this.chkIsAlive.AutoSize = true;
			this.chkIsAlive.Location = new System.Drawing.Point(153, 103);
			this.chkIsAlive.Name = "chkIsAlive";
			this.chkIsAlive.Size = new System.Drawing.Size(77, 19);
			this.chkIsAlive.TabIndex = 28;
			this.chkIsAlive.Text = "Alive?";
			this.chkIsAlive.UseVisualStyleBackColor = true;
			// 
			// txtIntroduction
			// 
			this.txtIntroduction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtIntroduction.Location = new System.Drawing.Point(153, 203);
			this.txtIntroduction.Name = "txtIntroduction";
			this.txtIntroduction.Size = new System.Drawing.Size(423, 119);
			this.txtIntroduction.TabIndex = 29;
			this.txtIntroduction.Text = "";
			// 
			// ucHeroDetails
			// 
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "ucHeroDetails";
			this.Size = new System.Drawing.Size(585, 588);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtBannerKey;
        private System.Windows.Forms.TextBox txtSpouse;
        private System.Windows.Forms.TextBox txtFaction;
        private System.Windows.Forms.TextBox txtMother;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.CheckBox chkIsNoble;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIsAlive;
        private System.Windows.Forms.RichTextBox txtIntroduction;
    }
}
