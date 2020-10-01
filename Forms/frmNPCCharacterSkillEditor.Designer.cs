namespace ArenaModdingTool.Forms
{
    partial class frmNPCCharacterSkillEditor
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.skillListView = new System.Windows.Forms.ListView();
            this.colSkillID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSkillValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(491, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(410, 278);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModify);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.skillListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 272);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(73, 246);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(40, 246);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(27, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "-";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // skillListView
            // 
            this.skillListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSkillID,
            this.colSkillValue});
            this.skillListView.FullRowSelect = true;
            this.skillListView.GridLines = true;
            this.skillListView.Location = new System.Drawing.Point(6, 12);
            this.skillListView.Name = "skillListView";
            this.skillListView.Size = new System.Drawing.Size(537, 227);
            this.skillListView.TabIndex = 4;
            this.skillListView.UseCompatibleStateImageBehavior = false;
            this.skillListView.View = System.Windows.Forms.View.Details;
            // 
            // colSkillID
            // 
            this.colSkillID.Text = "Skill ID";
            this.colSkillID.Width = 248;
            // 
            // colSkillValue
            // 
            this.colSkillValue.Text = "Value";
            this.colSkillValue.Width = 270;
            // 
            // frmNPCCharacterSkillEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNPCCharacterSkillEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Skills Editor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView skillListView;
        private System.Windows.Forms.ColumnHeader colSkillID;
        private System.Windows.Forms.ColumnHeader colSkillValue;
    }
}