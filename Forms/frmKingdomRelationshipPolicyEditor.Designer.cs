﻿namespace ArenaModdingTool.Forms
{
    partial class frmKingdomRelationshipPolicyEditor
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
            this.btnModifyRelationship = new System.Windows.Forms.Button();
            this.btnDeleteRelationship = new System.Windows.Forms.Button();
            this.btnAddRelationship = new System.Windows.Forms.Button();
            this.relationshipList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModifyPolicy = new System.Windows.Forms.Button();
            this.btnDeletePolicy = new System.Windows.Forms.Button();
            this.btnAddPolicy = new System.Windows.Forms.Button();
            this.policyList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModifyRelationship);
            this.groupBox1.Controls.Add(this.btnDeleteRelationship);
            this.groupBox1.Controls.Add(this.btnAddRelationship);
            this.groupBox1.Controls.Add(this.relationshipList);
            this.groupBox1.Location = new System.Drawing.Point(9, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1024, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relationship";
            // 
            // btnModifyRelationship
            // 
            this.btnModifyRelationship.Enabled = false;
            this.btnModifyRelationship.Location = new System.Drawing.Point(126, 225);
            this.btnModifyRelationship.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModifyRelationship.Name = "btnModifyRelationship";
            this.btnModifyRelationship.Size = new System.Drawing.Size(138, 44);
            this.btnModifyRelationship.TabIndex = 3;
            this.btnModifyRelationship.Text = "Modify";
            this.btnModifyRelationship.UseVisualStyleBackColor = true;
            this.btnModifyRelationship.Click += new System.EventHandler(this.btnModifyRelationship_Click);
            // 
            // btnDeleteRelationship
            // 
            this.btnDeleteRelationship.Enabled = false;
            this.btnDeleteRelationship.Location = new System.Drawing.Point(68, 225);
            this.btnDeleteRelationship.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteRelationship.Name = "btnDeleteRelationship";
            this.btnDeleteRelationship.Size = new System.Drawing.Size(45, 44);
            this.btnDeleteRelationship.TabIndex = 5;
            this.btnDeleteRelationship.Text = "-";
            this.btnDeleteRelationship.UseVisualStyleBackColor = true;
            this.btnDeleteRelationship.Click += new System.EventHandler(this.btnDeleteRelationship_Click);
            // 
            // btnAddRelationship
            // 
            this.btnAddRelationship.Location = new System.Drawing.Point(12, 225);
            this.btnAddRelationship.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddRelationship.Name = "btnAddRelationship";
            this.btnAddRelationship.Size = new System.Drawing.Size(45, 44);
            this.btnAddRelationship.TabIndex = 4;
            this.btnAddRelationship.Text = "+";
            this.btnAddRelationship.UseVisualStyleBackColor = true;
            this.btnAddRelationship.Click += new System.EventHandler(this.btnAddRelationship_Click);
            // 
            // relationshipList
            // 
            this.relationshipList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.relationshipList.FullRowSelect = true;
            this.relationshipList.GridLines = true;
            this.relationshipList.HideSelection = false;
            this.relationshipList.Location = new System.Drawing.Point(11, 38);
            this.relationshipList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.relationshipList.Name = "relationshipList";
            this.relationshipList.Size = new System.Drawing.Size(1000, 175);
            this.relationshipList.TabIndex = 0;
            this.relationshipList.UseCompatibleStateImageBehavior = false;
            this.relationshipList.View = System.Windows.Forms.View.Details;
            this.relationshipList.SelectedIndexChanged += new System.EventHandler(this.relationshipList_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kingdom";
            this.columnHeader2.Width = 281;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "IsAtWar";
            this.columnHeader4.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModifyPolicy);
            this.groupBox2.Controls.Add(this.btnDeletePolicy);
            this.groupBox2.Controls.Add(this.btnAddPolicy);
            this.groupBox2.Controls.Add(this.policyList);
            this.groupBox2.Location = new System.Drawing.Point(9, 313);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1024, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Policies";
            // 
            // btnModifyPolicy
            // 
            this.btnModifyPolicy.Enabled = false;
            this.btnModifyPolicy.Location = new System.Drawing.Point(126, 218);
            this.btnModifyPolicy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModifyPolicy.Name = "btnModifyPolicy";
            this.btnModifyPolicy.Size = new System.Drawing.Size(138, 44);
            this.btnModifyPolicy.TabIndex = 7;
            this.btnModifyPolicy.Text = "Modify";
            this.btnModifyPolicy.UseVisualStyleBackColor = true;
            this.btnModifyPolicy.Click += new System.EventHandler(this.btnModifyPolicy_Click);
            // 
            // btnDeletePolicy
            // 
            this.btnDeletePolicy.Enabled = false;
            this.btnDeletePolicy.Location = new System.Drawing.Point(70, 218);
            this.btnDeletePolicy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeletePolicy.Name = "btnDeletePolicy";
            this.btnDeletePolicy.Size = new System.Drawing.Size(45, 44);
            this.btnDeletePolicy.TabIndex = 9;
            this.btnDeletePolicy.Text = "-";
            this.btnDeletePolicy.UseVisualStyleBackColor = true;
            this.btnDeletePolicy.Click += new System.EventHandler(this.btnDeletePolicy_Click);
            // 
            // btnAddPolicy
            // 
            this.btnAddPolicy.Location = new System.Drawing.Point(12, 218);
            this.btnAddPolicy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddPolicy.Name = "btnAddPolicy";
            this.btnAddPolicy.Size = new System.Drawing.Size(45, 44);
            this.btnAddPolicy.TabIndex = 8;
            this.btnAddPolicy.Text = "+";
            this.btnAddPolicy.UseVisualStyleBackColor = true;
            this.btnAddPolicy.Click += new System.EventHandler(this.btnAddPolicy_Click);
            // 
            // policyList
            // 
            this.policyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.policyList.FullRowSelect = true;
            this.policyList.GridLines = true;
            this.policyList.HideSelection = false;
            this.policyList.Location = new System.Drawing.Point(11, 38);
            this.policyList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.policyList.Name = "policyList";
            this.policyList.Size = new System.Drawing.Size(1000, 168);
            this.policyList.TabIndex = 6;
            this.policyList.UseCompatibleStateImageBehavior = false;
            this.policyList.View = System.Windows.Forms.View.Details;
            this.policyList.SelectedIndexChanged += new System.EventHandler(this.policyList_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id";
            this.columnHeader5.Width = 517;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(891, 611);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 44);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(742, 611);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 44);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmKingdomRelationshipPolicyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 672);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKingdomRelationshipPolicyEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kingdom - {0}\'s Relationship and Policy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModifyRelationship;
        private System.Windows.Forms.Button btnDeleteRelationship;
        private System.Windows.Forms.Button btnAddRelationship;
        private System.Windows.Forms.ListView relationshipList;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnModifyPolicy;
        private System.Windows.Forms.Button btnDeletePolicy;
        private System.Windows.Forms.Button btnAddPolicy;
        private System.Windows.Forms.ListView policyList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}