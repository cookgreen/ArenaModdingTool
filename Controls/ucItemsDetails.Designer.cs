
namespace ArenaModdingTool.Controls
{
    partial class ucItemsDetails
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

        #region 组件设计器生成的代码

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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCulture = new System.Windows.Forms.TextBox();
            this.txtBodyName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.chkMultiplayerItem = new System.Windows.Forms.CheckBox();
            this.txtMesh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIsMerchandise = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAmmoOffset = new System.Windows.Forms.TextBox();
            this.txtItemHolsters = new System.Windows.Forms.TextBox();
            this.txtHolsterPositionShift = new System.Windows.Forms.TextBox();
            this.numDifficulty = new System.Windows.Forms.NumericUpDown();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEditItemComponent = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDifficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(600, 476);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 34);
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
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCulture, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtBodyName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkMultiplayerItem, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMesh, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkIsMerchandise, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.numWeight, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtType, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtAmmoOffset, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtItemHolsters, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtHolsterPositionShift, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.numDifficulty, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.numValue, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.btnEditItemComponent, 1, 14);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 430);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "value";
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
            this.label6.Text = "culture";
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
            this.label4.Text = "body name";
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
            this.label3.Text = "name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCulture
            // 
            this.txtCulture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCulture.Location = new System.Drawing.Point(153, 128);
            this.txtCulture.Name = "txtCulture";
            this.txtCulture.ReadOnly = true;
            this.txtCulture.Size = new System.Drawing.Size(438, 21);
            this.txtCulture.TabIndex = 12;
            // 
            // txtBodyName
            // 
            this.txtBodyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBodyName.Location = new System.Drawing.Point(153, 78);
            this.txtBodyName.Name = "txtBodyName";
            this.txtBodyName.Size = new System.Drawing.Size(438, 21);
            this.txtBodyName.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(153, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(438, 21);
            this.txtName.TabIndex = 6;
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
            // txtId
            // 
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Location = new System.Drawing.Point(153, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(438, 21);
            this.txtId.TabIndex = 2;
            // 
            // chkMultiplayerItem
            // 
            this.chkMultiplayerItem.AutoSize = true;
            this.chkMultiplayerItem.Location = new System.Drawing.Point(153, 28);
            this.chkMultiplayerItem.Name = "chkMultiplayerItem";
            this.chkMultiplayerItem.Size = new System.Drawing.Size(120, 16);
            this.chkMultiplayerItem.TabIndex = 19;
            this.chkMultiplayerItem.Text = "Multiplayer Item";
            this.chkMultiplayerItem.UseVisualStyleBackColor = true;
            // 
            // txtMesh
            // 
            this.txtMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMesh.Location = new System.Drawing.Point(153, 103);
            this.txtMesh.Name = "txtMesh";
            this.txtMesh.Size = new System.Drawing.Size(438, 21);
            this.txtMesh.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "mesh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkIsMerchandise
            // 
            this.chkIsMerchandise.AutoSize = true;
            this.chkIsMerchandise.Location = new System.Drawing.Point(153, 178);
            this.chkIsMerchandise.Name = "chkIsMerchandise";
            this.chkIsMerchandise.Size = new System.Drawing.Size(108, 16);
            this.chkIsMerchandise.TabIndex = 32;
            this.chkIsMerchandise.Text = "is_merchandise";
            this.chkIsMerchandise.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "weight";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "difficulty";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "type";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "AmmoOffset";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "item_holsters";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "holster_position_shift";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numWeight
            // 
            this.numWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numWeight.Location = new System.Drawing.Point(153, 203);
            this.numWeight.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(438, 21);
            this.numWeight.TabIndex = 39;
            // 
            // txtType
            // 
            this.txtType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtType.Location = new System.Drawing.Point(153, 253);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(438, 21);
            this.txtType.TabIndex = 41;
            // 
            // txtAmmoOffset
            // 
            this.txtAmmoOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmmoOffset.Location = new System.Drawing.Point(153, 278);
            this.txtAmmoOffset.Name = "txtAmmoOffset";
            this.txtAmmoOffset.ReadOnly = true;
            this.txtAmmoOffset.Size = new System.Drawing.Size(438, 21);
            this.txtAmmoOffset.TabIndex = 42;
            this.txtAmmoOffset.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtAmmoOffset_MouseDoubleClick);
            // 
            // txtItemHolsters
            // 
            this.txtItemHolsters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemHolsters.Location = new System.Drawing.Point(153, 303);
            this.txtItemHolsters.Name = "txtItemHolsters";
            this.txtItemHolsters.ReadOnly = true;
            this.txtItemHolsters.Size = new System.Drawing.Size(438, 21);
            this.txtItemHolsters.TabIndex = 43;
            this.txtItemHolsters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtItemHolsters_MouseDoubleClick);
            // 
            // txtHolsterPositionShift
            // 
            this.txtHolsterPositionShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHolsterPositionShift.Location = new System.Drawing.Point(153, 328);
            this.txtHolsterPositionShift.Name = "txtHolsterPositionShift";
            this.txtHolsterPositionShift.ReadOnly = true;
            this.txtHolsterPositionShift.Size = new System.Drawing.Size(438, 21);
            this.txtHolsterPositionShift.TabIndex = 44;
            this.txtHolsterPositionShift.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtHolsterPositionShift_MouseDoubleClick);
            // 
            // numDifficulty
            // 
            this.numDifficulty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numDifficulty.Location = new System.Drawing.Point(153, 228);
            this.numDifficulty.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numDifficulty.Name = "numDifficulty";
            this.numDifficulty.Size = new System.Drawing.Size(438, 21);
            this.numDifficulty.TabIndex = 45;
            // 
            // numValue
            // 
            this.numValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numValue.Location = new System.Drawing.Point(153, 153);
            this.numValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(438, 21);
            this.numValue.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 25);
            this.label13.TabIndex = 47;
            this.label13.Text = "Component";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditItemComponent
            // 
            this.btnEditItemComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditItemComponent.Location = new System.Drawing.Point(153, 353);
            this.btnEditItemComponent.Name = "btnEditItemComponent";
            this.btnEditItemComponent.Size = new System.Drawing.Size(438, 19);
            this.btnEditItemComponent.TabIndex = 48;
            this.btnEditItemComponent.Text = "Edit Item Component";
            this.btnEditItemComponent.UseVisualStyleBackColor = true;
            this.btnEditItemComponent.Click += new System.EventHandler(this.btnEditItemComponent_Click);
            // 
            // ucItemsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucItemsDetails";
            this.Size = new System.Drawing.Size(600, 476);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDifficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCulture;
        private System.Windows.Forms.TextBox txtBodyName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox chkMultiplayerItem;
        private System.Windows.Forms.TextBox txtMesh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIsMerchandise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAmmoOffset;
        private System.Windows.Forms.TextBox txtItemHolsters;
        private System.Windows.Forms.TextBox txtHolsterPositionShift;
        private System.Windows.Forms.NumericUpDown numDifficulty;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEditItemComponent;
    }
}
