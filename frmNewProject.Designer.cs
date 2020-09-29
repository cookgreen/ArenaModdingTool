namespace ArenaModdingTool
{
    partial class frmNewProject
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
            this.lbProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lbModuleName = new System.Windows.Forms.Label();
            this.txtMBModuleName = new System.Windows.Forms.TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnLocationBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupbox_module_info = new System.Windows.Forms.GroupBox();
            this.txtBannerlordVersion = new System.Windows.Forms.TextBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.groupbox_xmls = new System.Windows.Forms.GroupBox();
            this.btnModifyXmlNode = new System.Windows.Forms.Button();
            this.btnDeleteXmlNode = new System.Windows.Forms.Button();
            this.btnAddXmlNode = new System.Windows.Forms.Button();
            this.lsvXmls = new System.Windows.Forms.ListView();
            this.colXmlNodeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colXmlNodePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colXmlNodeIncludedGameTypes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupbox_submodules = new System.Windows.Forms.GroupBox();
            this.btnModifySubModule = new System.Windows.Forms.Button();
            this.btnDeleteSubModule = new System.Windows.Forms.Button();
            this.btnAddSubModule = new System.Windows.Forms.Button();
            this.lsvSubModules = new System.Windows.Forms.ListView();
            this.colSubModuleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubModule_DllName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubModuleClassType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubModuleTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkMultiplayer = new System.Windows.Forms.CheckBox();
            this.chkSinglePlayer = new System.Windows.Forms.CheckBox();
            this.btnEditDepencyModules = new System.Windows.Forms.Button();
            this.groupbox_module_info.SuspendLayout();
            this.groupbox_xmls.SuspendLayout();
            this.groupbox_submodules.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Location = new System.Drawing.Point(13, 13);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(83, 12);
            this.lbProjectName.TabIndex = 0;
            this.lbProjectName.Text = "Project Name:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(102, 10);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(325, 21);
            this.txtProjectName.TabIndex = 1;
            // 
            // lbModuleName
            // 
            this.lbModuleName.AutoSize = true;
            this.lbModuleName.Location = new System.Drawing.Point(15, 44);
            this.lbModuleName.Name = "lbModuleName";
            this.lbModuleName.Size = new System.Drawing.Size(77, 12);
            this.lbModuleName.TabIndex = 2;
            this.lbModuleName.Text = "Module Name:";
            // 
            // txtMBModuleName
            // 
            this.txtMBModuleName.Location = new System.Drawing.Point(102, 41);
            this.txtMBModuleName.Name = "txtMBModuleName";
            this.txtMBModuleName.Size = new System.Drawing.Size(325, 21);
            this.txtMBModuleName.TabIndex = 3;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(13, 77);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(59, 12);
            this.lbLocation.TabIndex = 4;
            this.lbLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(102, 74);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(272, 21);
            this.txtLocation.TabIndex = 5;
            // 
            // btnLocationBrowse
            // 
            this.btnLocationBrowse.Location = new System.Drawing.Point(380, 72);
            this.btnLocationBrowse.Name = "btnLocationBrowse";
            this.btnLocationBrowse.Size = new System.Drawing.Size(47, 23);
            this.btnLocationBrowse.TabIndex = 6;
            this.btnLocationBrowse.Text = "...";
            this.btnLocationBrowse.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(271, 490);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupbox_module_info
            // 
            this.groupbox_module_info.Controls.Add(this.btnEditDepencyModules);
            this.groupbox_module_info.Controls.Add(this.txtBannerlordVersion);
            this.groupbox_module_info.Controls.Add(this.lbVersion);
            this.groupbox_module_info.Controls.Add(this.groupbox_xmls);
            this.groupbox_module_info.Controls.Add(this.groupbox_submodules);
            this.groupbox_module_info.Controls.Add(this.chkMultiplayer);
            this.groupbox_module_info.Controls.Add(this.chkSinglePlayer);
            this.groupbox_module_info.Location = new System.Drawing.Point(15, 101);
            this.groupbox_module_info.Name = "groupbox_module_info";
            this.groupbox_module_info.Size = new System.Drawing.Size(412, 383);
            this.groupbox_module_info.TabIndex = 9;
            this.groupbox_module_info.TabStop = false;
            this.groupbox_module_info.Text = "Module Information";
            // 
            // txtBannerlordVersion
            // 
            this.txtBannerlordVersion.Location = new System.Drawing.Point(69, 18);
            this.txtBannerlordVersion.Name = "txtBannerlordVersion";
            this.txtBannerlordVersion.ReadOnly = true;
            this.txtBannerlordVersion.Size = new System.Drawing.Size(229, 21);
            this.txtBannerlordVersion.TabIndex = 6;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(10, 21);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(53, 12);
            this.lbVersion.TabIndex = 5;
            this.lbVersion.Text = "Version:";
            // 
            // groupbox_xmls
            // 
            this.groupbox_xmls.Controls.Add(this.btnModifyXmlNode);
            this.groupbox_xmls.Controls.Add(this.btnDeleteXmlNode);
            this.groupbox_xmls.Controls.Add(this.btnAddXmlNode);
            this.groupbox_xmls.Controls.Add(this.lsvXmls);
            this.groupbox_xmls.Location = new System.Drawing.Point(6, 229);
            this.groupbox_xmls.Name = "groupbox_xmls";
            this.groupbox_xmls.Size = new System.Drawing.Size(400, 148);
            this.groupbox_xmls.TabIndex = 4;
            this.groupbox_xmls.TabStop = false;
            this.groupbox_xmls.Text = "Xmls";
            // 
            // btnModifyXmlNode
            // 
            this.btnModifyXmlNode.Location = new System.Drawing.Point(76, 120);
            this.btnModifyXmlNode.Name = "btnModifyXmlNode";
            this.btnModifyXmlNode.Size = new System.Drawing.Size(71, 23);
            this.btnModifyXmlNode.TabIndex = 6;
            this.btnModifyXmlNode.Text = "Modify";
            this.btnModifyXmlNode.UseVisualStyleBackColor = true;
            this.btnModifyXmlNode.Click += new System.EventHandler(this.btnModifyXmlNode_Click);
            // 
            // btnDeleteXmlNode
            // 
            this.btnDeleteXmlNode.Location = new System.Drawing.Point(41, 120);
            this.btnDeleteXmlNode.Name = "btnDeleteXmlNode";
            this.btnDeleteXmlNode.Size = new System.Drawing.Size(29, 23);
            this.btnDeleteXmlNode.TabIndex = 5;
            this.btnDeleteXmlNode.Text = "-";
            this.btnDeleteXmlNode.UseVisualStyleBackColor = true;
            this.btnDeleteXmlNode.Click += new System.EventHandler(this.btnDeleteXmlNode_Click);
            // 
            // btnAddXmlNode
            // 
            this.btnAddXmlNode.Location = new System.Drawing.Point(6, 120);
            this.btnAddXmlNode.Name = "btnAddXmlNode";
            this.btnAddXmlNode.Size = new System.Drawing.Size(29, 23);
            this.btnAddXmlNode.TabIndex = 4;
            this.btnAddXmlNode.Text = "+";
            this.btnAddXmlNode.UseVisualStyleBackColor = true;
            this.btnAddXmlNode.Click += new System.EventHandler(this.btnAddXmlNode_Click);
            // 
            // lsvXmls
            // 
            this.lsvXmls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colXmlNodeID,
            this.colXmlNodePath,
            this.colXmlNodeIncludedGameTypes});
            this.lsvXmls.Location = new System.Drawing.Point(6, 20);
            this.lsvXmls.Name = "lsvXmls";
            this.lsvXmls.Size = new System.Drawing.Size(388, 97);
            this.lsvXmls.TabIndex = 0;
            this.lsvXmls.UseCompatibleStateImageBehavior = false;
            this.lsvXmls.View = System.Windows.Forms.View.Details;
            // 
            // colXmlNodeID
            // 
            this.colXmlNodeID.Text = "id";
            this.colXmlNodeID.Width = 121;
            // 
            // colXmlNodePath
            // 
            this.colXmlNodePath.Text = "path";
            this.colXmlNodePath.Width = 103;
            // 
            // colXmlNodeIncludedGameTypes
            // 
            this.colXmlNodeIncludedGameTypes.Text = "Included Game Types";
            this.colXmlNodeIncludedGameTypes.Width = 153;
            // 
            // groupbox_submodules
            // 
            this.groupbox_submodules.Controls.Add(this.btnModifySubModule);
            this.groupbox_submodules.Controls.Add(this.btnDeleteSubModule);
            this.groupbox_submodules.Controls.Add(this.btnAddSubModule);
            this.groupbox_submodules.Controls.Add(this.lsvSubModules);
            this.groupbox_submodules.Location = new System.Drawing.Point(6, 74);
            this.groupbox_submodules.Name = "groupbox_submodules";
            this.groupbox_submodules.Size = new System.Drawing.Size(400, 149);
            this.groupbox_submodules.TabIndex = 3;
            this.groupbox_submodules.TabStop = false;
            this.groupbox_submodules.Text = "Sub Modules";
            // 
            // btnModifySubModule
            // 
            this.btnModifySubModule.Location = new System.Drawing.Point(76, 120);
            this.btnModifySubModule.Name = "btnModifySubModule";
            this.btnModifySubModule.Size = new System.Drawing.Size(71, 23);
            this.btnModifySubModule.TabIndex = 3;
            this.btnModifySubModule.Text = "Modify";
            this.btnModifySubModule.UseVisualStyleBackColor = true;
            this.btnModifySubModule.Click += new System.EventHandler(this.btnModifySubModule_Click);
            // 
            // btnDeleteSubModule
            // 
            this.btnDeleteSubModule.Location = new System.Drawing.Point(41, 120);
            this.btnDeleteSubModule.Name = "btnDeleteSubModule";
            this.btnDeleteSubModule.Size = new System.Drawing.Size(29, 23);
            this.btnDeleteSubModule.TabIndex = 2;
            this.btnDeleteSubModule.Text = "-";
            this.btnDeleteSubModule.UseVisualStyleBackColor = true;
            this.btnDeleteSubModule.Click += new System.EventHandler(this.btnDeleteSubModule_Click);
            // 
            // btnAddSubModule
            // 
            this.btnAddSubModule.Location = new System.Drawing.Point(6, 120);
            this.btnAddSubModule.Name = "btnAddSubModule";
            this.btnAddSubModule.Size = new System.Drawing.Size(29, 23);
            this.btnAddSubModule.TabIndex = 1;
            this.btnAddSubModule.Text = "+";
            this.btnAddSubModule.UseVisualStyleBackColor = true;
            this.btnAddSubModule.Click += new System.EventHandler(this.btnAddSubModule_Click);
            // 
            // lsvSubModules
            // 
            this.lsvSubModules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSubModuleName,
            this.colSubModule_DllName,
            this.colSubModuleClassType,
            this.colSubModuleTags});
            this.lsvSubModules.Location = new System.Drawing.Point(6, 20);
            this.lsvSubModules.Name = "lsvSubModules";
            this.lsvSubModules.Size = new System.Drawing.Size(388, 97);
            this.lsvSubModules.TabIndex = 0;
            this.lsvSubModules.UseCompatibleStateImageBehavior = false;
            this.lsvSubModules.View = System.Windows.Forms.View.Details;
            // 
            // colSubModuleName
            // 
            this.colSubModuleName.Text = "Name";
            // 
            // colSubModule_DllName
            // 
            this.colSubModule_DllName.Text = "DLLName";
            // 
            // colSubModuleClassType
            // 
            this.colSubModuleClassType.Text = "SubModuleClassType";
            this.colSubModuleClassType.Width = 112;
            // 
            // colSubModuleTags
            // 
            this.colSubModuleTags.Text = "Tags";
            this.colSubModuleTags.Width = 142;
            // 
            // chkMultiplayer
            // 
            this.chkMultiplayer.AutoSize = true;
            this.chkMultiplayer.Location = new System.Drawing.Point(304, 49);
            this.chkMultiplayer.Name = "chkMultiplayer";
            this.chkMultiplayer.Size = new System.Drawing.Size(90, 16);
            this.chkMultiplayer.TabIndex = 2;
            this.chkMultiplayer.Text = "Multiplayer";
            this.chkMultiplayer.UseVisualStyleBackColor = true;
            // 
            // chkSinglePlayer
            // 
            this.chkSinglePlayer.AutoSize = true;
            this.chkSinglePlayer.Location = new System.Drawing.Point(304, 20);
            this.chkSinglePlayer.Name = "chkSinglePlayer";
            this.chkSinglePlayer.Size = new System.Drawing.Size(96, 16);
            this.chkSinglePlayer.TabIndex = 1;
            this.chkSinglePlayer.Text = "SinglePlayer";
            this.chkSinglePlayer.UseVisualStyleBackColor = true;
            // 
            // btnEditDepencyModules
            // 
            this.btnEditDepencyModules.Location = new System.Drawing.Point(12, 45);
            this.btnEditDepencyModules.Name = "btnEditDepencyModules";
            this.btnEditDepencyModules.Size = new System.Drawing.Size(286, 23);
            this.btnEditDepencyModules.TabIndex = 7;
            this.btnEditDepencyModules.Text = "Edit Depency Modules";
            this.btnEditDepencyModules.UseVisualStyleBackColor = true;
            // 
            // frmNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 520);
            this.Controls.Add(this.groupbox_module_info);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLocationBrowse);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.txtMBModuleName);
            this.Controls.Add(this.lbModuleName);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lbProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewProject";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Project";
            this.groupbox_module_info.ResumeLayout(false);
            this.groupbox_module_info.PerformLayout();
            this.groupbox_xmls.ResumeLayout(false);
            this.groupbox_submodules.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lbModuleName;
        private System.Windows.Forms.TextBox txtMBModuleName;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnLocationBrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupbox_module_info;
        private System.Windows.Forms.CheckBox chkMultiplayer;
        private System.Windows.Forms.CheckBox chkSinglePlayer;
        private System.Windows.Forms.GroupBox groupbox_submodules;
        private System.Windows.Forms.ListView lsvSubModules;
        private System.Windows.Forms.GroupBox groupbox_xmls;
        private System.Windows.Forms.ListView lsvXmls;
        private System.Windows.Forms.ColumnHeader colSubModuleName;
        private System.Windows.Forms.ColumnHeader colSubModule_DllName;
        private System.Windows.Forms.ColumnHeader colSubModuleClassType;
        private System.Windows.Forms.ColumnHeader colSubModuleTags;
        private System.Windows.Forms.ColumnHeader colXmlNodeID;
        private System.Windows.Forms.ColumnHeader colXmlNodePath;
        private System.Windows.Forms.ColumnHeader colXmlNodeIncludedGameTypes;
        private System.Windows.Forms.Button btnModifySubModule;
        private System.Windows.Forms.Button btnDeleteSubModule;
        private System.Windows.Forms.Button btnAddSubModule;
        private System.Windows.Forms.Button btnModifyXmlNode;
        private System.Windows.Forms.Button btnDeleteXmlNode;
        private System.Windows.Forms.Button btnAddXmlNode;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.TextBox txtBannerlordVersion;
        private System.Windows.Forms.Button btnEditDepencyModules;
    }
}