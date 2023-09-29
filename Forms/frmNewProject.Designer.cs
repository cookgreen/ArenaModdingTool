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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tbBasicInfo = new System.Windows.Forms.TabPage();
			this.tbSubModule = new System.Windows.Forms.TabPage();
			this.tbXmls = new System.Windows.Forms.TabPage();
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
			this.btnEditDepencyModules = new System.Windows.Forms.Button();
			this.txtBannerlordVersion = new System.Windows.Forms.TextBox();
			this.lbVersion = new System.Windows.Forms.Label();
			this.chkMultiplayer = new System.Windows.Forms.CheckBox();
			this.chkSinglePlayer = new System.Windows.Forms.CheckBox();
			this.groupbox_module_info.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tbBasicInfo.SuspendLayout();
			this.tbSubModule.SuspendLayout();
			this.tbXmls.SuspendLayout();
			this.groupbox_xmls.SuspendLayout();
			this.groupbox_submodules.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbProjectName
			// 
			this.lbProjectName.AutoSize = true;
			this.lbProjectName.Location = new System.Drawing.Point(14, 9);
			this.lbProjectName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbProjectName.Name = "lbProjectName";
			this.lbProjectName.Size = new System.Drawing.Size(115, 24);
			this.lbProjectName.TabIndex = 0;
			this.lbProjectName.Text = "Project Name:";
			// 
			// txtProjectName
			// 
			this.txtProjectName.Location = new System.Drawing.Point(150, 6);
			this.txtProjectName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtProjectName.Name = "txtProjectName";
			this.txtProjectName.Size = new System.Drawing.Size(539, 30);
			this.txtProjectName.TabIndex = 1;
			// 
			// lbModuleName
			// 
			this.lbModuleName.AutoSize = true;
			this.lbModuleName.Location = new System.Drawing.Point(14, 51);
			this.lbModuleName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbModuleName.Name = "lbModuleName";
			this.lbModuleName.Size = new System.Drawing.Size(119, 24);
			this.lbModuleName.TabIndex = 2;
			this.lbModuleName.Text = "Module Name:";
			// 
			// txtMBModuleName
			// 
			this.txtMBModuleName.Location = new System.Drawing.Point(150, 48);
			this.txtMBModuleName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtMBModuleName.Name = "txtMBModuleName";
			this.txtMBModuleName.Size = new System.Drawing.Size(539, 30);
			this.txtMBModuleName.TabIndex = 3;
			// 
			// lbLocation
			// 
			this.lbLocation.AutoSize = true;
			this.lbLocation.Location = new System.Drawing.Point(14, 93);
			this.lbLocation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbLocation.Name = "lbLocation";
			this.lbLocation.Size = new System.Drawing.Size(76, 24);
			this.lbLocation.TabIndex = 4;
			this.lbLocation.Text = "Location:";
			// 
			// txtLocation
			// 
			this.txtLocation.Location = new System.Drawing.Point(150, 90);
			this.txtLocation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.ReadOnly = true;
			this.txtLocation.Size = new System.Drawing.Size(450, 30);
			this.txtLocation.TabIndex = 5;
			// 
			// btnLocationBrowse
			// 
			this.btnLocationBrowse.Location = new System.Drawing.Point(610, 82);
			this.btnLocationBrowse.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnLocationBrowse.Name = "btnLocationBrowse";
			this.btnLocationBrowse.Size = new System.Drawing.Size(79, 46);
			this.btnLocationBrowse.TabIndex = 6;
			this.btnLocationBrowse.Text = "...";
			this.btnLocationBrowse.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(579, 554);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(125, 46);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(444, 554);
			this.btnOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(125, 46);
			this.btnOK.TabIndex = 8;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// groupbox_module_info
			// 
			this.groupbox_module_info.Controls.Add(this.tabControl1);
			this.groupbox_module_info.Location = new System.Drawing.Point(18, 132);
			this.groupbox_module_info.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.groupbox_module_info.Name = "groupbox_module_info";
			this.groupbox_module_info.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.groupbox_module_info.Size = new System.Drawing.Size(686, 410);
			this.groupbox_module_info.TabIndex = 9;
			this.groupbox_module_info.TabStop = false;
			this.groupbox_module_info.Text = "Module Information";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbBasicInfo);
			this.tabControl1.Controls.Add(this.tbSubModule);
			this.tabControl1.Controls.Add(this.tbXmls);
			this.tabControl1.Location = new System.Drawing.Point(8, 32);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(663, 369);
			this.tabControl1.TabIndex = 8;
			// 
			// tbBasicInfo
			// 
			this.tbBasicInfo.Controls.Add(this.btnEditDepencyModules);
			this.tbBasicInfo.Controls.Add(this.txtBannerlordVersion);
			this.tbBasicInfo.Controls.Add(this.lbVersion);
			this.tbBasicInfo.Controls.Add(this.chkMultiplayer);
			this.tbBasicInfo.Controls.Add(this.chkSinglePlayer);
			this.tbBasicInfo.Location = new System.Drawing.Point(4, 33);
			this.tbBasicInfo.Name = "tbBasicInfo";
			this.tbBasicInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tbBasicInfo.Size = new System.Drawing.Size(655, 332);
			this.tbBasicInfo.TabIndex = 0;
			this.tbBasicInfo.Text = "Basic Info";
			this.tbBasicInfo.UseVisualStyleBackColor = true;
			// 
			// tbSubModule
			// 
			this.tbSubModule.Controls.Add(this.groupbox_submodules);
			this.tbSubModule.Location = new System.Drawing.Point(4, 33);
			this.tbSubModule.Name = "tbSubModule";
			this.tbSubModule.Padding = new System.Windows.Forms.Padding(3);
			this.tbSubModule.Size = new System.Drawing.Size(655, 332);
			this.tbSubModule.TabIndex = 1;
			this.tbSubModule.Text = "Sub Module";
			this.tbSubModule.UseVisualStyleBackColor = true;
			// 
			// tbXmls
			// 
			this.tbXmls.Controls.Add(this.groupbox_xmls);
			this.tbXmls.Location = new System.Drawing.Point(4, 33);
			this.tbXmls.Name = "tbXmls";
			this.tbXmls.Padding = new System.Windows.Forms.Padding(3);
			this.tbXmls.Size = new System.Drawing.Size(655, 332);
			this.tbXmls.TabIndex = 2;
			this.tbXmls.Text = "Xmls";
			this.tbXmls.UseVisualStyleBackColor = true;
			// 
			// groupbox_xmls
			// 
			this.groupbox_xmls.Controls.Add(this.btnModifyXmlNode);
			this.groupbox_xmls.Controls.Add(this.btnDeleteXmlNode);
			this.groupbox_xmls.Controls.Add(this.btnAddXmlNode);
			this.groupbox_xmls.Controls.Add(this.lsvXmls);
			this.groupbox_xmls.Location = new System.Drawing.Point(8, 9);
			this.groupbox_xmls.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.groupbox_xmls.Name = "groupbox_xmls";
			this.groupbox_xmls.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.groupbox_xmls.Size = new System.Drawing.Size(639, 314);
			this.groupbox_xmls.TabIndex = 5;
			this.groupbox_xmls.TabStop = false;
			this.groupbox_xmls.Text = "Xmls";
			// 
			// btnModifyXmlNode
			// 
			this.btnModifyXmlNode.Location = new System.Drawing.Point(126, 256);
			this.btnModifyXmlNode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnModifyXmlNode.Name = "btnModifyXmlNode";
			this.btnModifyXmlNode.Size = new System.Drawing.Size(119, 46);
			this.btnModifyXmlNode.TabIndex = 6;
			this.btnModifyXmlNode.Text = "Modify";
			this.btnModifyXmlNode.UseVisualStyleBackColor = true;
			// 
			// btnDeleteXmlNode
			// 
			this.btnDeleteXmlNode.Location = new System.Drawing.Point(69, 256);
			this.btnDeleteXmlNode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnDeleteXmlNode.Name = "btnDeleteXmlNode";
			this.btnDeleteXmlNode.Size = new System.Drawing.Size(49, 46);
			this.btnDeleteXmlNode.TabIndex = 5;
			this.btnDeleteXmlNode.Text = "-";
			this.btnDeleteXmlNode.UseVisualStyleBackColor = true;
			// 
			// btnAddXmlNode
			// 
			this.btnAddXmlNode.Location = new System.Drawing.Point(10, 256);
			this.btnAddXmlNode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnAddXmlNode.Name = "btnAddXmlNode";
			this.btnAddXmlNode.Size = new System.Drawing.Size(49, 46);
			this.btnAddXmlNode.TabIndex = 4;
			this.btnAddXmlNode.Text = "+";
			this.btnAddXmlNode.UseVisualStyleBackColor = true;
			// 
			// lsvXmls
			// 
			this.lsvXmls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colXmlNodeID,
            this.colXmlNodePath,
            this.colXmlNodeIncludedGameTypes});
			this.lsvXmls.HideSelection = false;
			this.lsvXmls.Location = new System.Drawing.Point(10, 40);
			this.lsvXmls.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.lsvXmls.Name = "lsvXmls";
			this.lsvXmls.Size = new System.Drawing.Size(619, 204);
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
			this.groupbox_submodules.Location = new System.Drawing.Point(8, 9);
			this.groupbox_submodules.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.groupbox_submodules.Name = "groupbox_submodules";
			this.groupbox_submodules.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.groupbox_submodules.Size = new System.Drawing.Size(639, 298);
			this.groupbox_submodules.TabIndex = 4;
			this.groupbox_submodules.TabStop = false;
			this.groupbox_submodules.Text = "Sub Modules";
			// 
			// btnModifySubModule
			// 
			this.btnModifySubModule.Location = new System.Drawing.Point(126, 240);
			this.btnModifySubModule.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnModifySubModule.Name = "btnModifySubModule";
			this.btnModifySubModule.Size = new System.Drawing.Size(119, 46);
			this.btnModifySubModule.TabIndex = 3;
			this.btnModifySubModule.Text = "Modify";
			this.btnModifySubModule.UseVisualStyleBackColor = true;
			// 
			// btnDeleteSubModule
			// 
			this.btnDeleteSubModule.Location = new System.Drawing.Point(69, 240);
			this.btnDeleteSubModule.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnDeleteSubModule.Name = "btnDeleteSubModule";
			this.btnDeleteSubModule.Size = new System.Drawing.Size(49, 46);
			this.btnDeleteSubModule.TabIndex = 2;
			this.btnDeleteSubModule.Text = "-";
			this.btnDeleteSubModule.UseVisualStyleBackColor = true;
			// 
			// btnAddSubModule
			// 
			this.btnAddSubModule.Location = new System.Drawing.Point(10, 240);
			this.btnAddSubModule.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnAddSubModule.Name = "btnAddSubModule";
			this.btnAddSubModule.Size = new System.Drawing.Size(49, 46);
			this.btnAddSubModule.TabIndex = 1;
			this.btnAddSubModule.Text = "+";
			this.btnAddSubModule.UseVisualStyleBackColor = true;
			// 
			// lsvSubModules
			// 
			this.lsvSubModules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSubModuleName,
            this.colSubModule_DllName,
            this.colSubModuleClassType,
            this.colSubModuleTags});
			this.lsvSubModules.HideSelection = false;
			this.lsvSubModules.Location = new System.Drawing.Point(10, 40);
			this.lsvSubModules.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.lsvSubModules.Name = "lsvSubModules";
			this.lsvSubModules.Size = new System.Drawing.Size(619, 190);
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
			// btnEditDepencyModules
			// 
			this.btnEditDepencyModules.Location = new System.Drawing.Point(12, 67);
			this.btnEditDepencyModules.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnEditDepencyModules.Name = "btnEditDepencyModules";
			this.btnEditDepencyModules.Size = new System.Drawing.Size(476, 46);
			this.btnEditDepencyModules.TabIndex = 12;
			this.btnEditDepencyModules.Text = "Edit Depency Modules";
			this.btnEditDepencyModules.UseVisualStyleBackColor = true;
			// 
			// txtBannerlordVersion
			// 
			this.txtBannerlordVersion.Location = new System.Drawing.Point(107, 12);
			this.txtBannerlordVersion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtBannerlordVersion.Name = "txtBannerlordVersion";
			this.txtBannerlordVersion.ReadOnly = true;
			this.txtBannerlordVersion.Size = new System.Drawing.Size(379, 30);
			this.txtBannerlordVersion.TabIndex = 11;
			// 
			// lbVersion
			// 
			this.lbVersion.AutoSize = true;
			this.lbVersion.Location = new System.Drawing.Point(8, 19);
			this.lbVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbVersion.Name = "lbVersion";
			this.lbVersion.Size = new System.Drawing.Size(69, 24);
			this.lbVersion.TabIndex = 10;
			this.lbVersion.Text = "Version:";
			// 
			// chkMultiplayer
			// 
			this.chkMultiplayer.AutoSize = true;
			this.chkMultiplayer.Location = new System.Drawing.Point(498, 57);
			this.chkMultiplayer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.chkMultiplayer.Name = "chkMultiplayer";
			this.chkMultiplayer.Size = new System.Drawing.Size(111, 28);
			this.chkMultiplayer.TabIndex = 9;
			this.chkMultiplayer.Text = "Multiplayer";
			this.chkMultiplayer.UseVisualStyleBackColor = true;
			// 
			// chkSinglePlayer
			// 
			this.chkSinglePlayer.AutoSize = true;
			this.chkSinglePlayer.Location = new System.Drawing.Point(498, 17);
			this.chkSinglePlayer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.chkSinglePlayer.Name = "chkSinglePlayer";
			this.chkSinglePlayer.Size = new System.Drawing.Size(122, 28);
			this.chkSinglePlayer.TabIndex = 8;
			this.chkSinglePlayer.Text = "SinglePlayer";
			this.chkSinglePlayer.UseVisualStyleBackColor = true;
			// 
			// frmNewProject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 613);
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
			this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNewProject";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create New Project";
			this.groupbox_module_info.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tbBasicInfo.ResumeLayout(false);
			this.tbBasicInfo.PerformLayout();
			this.tbSubModule.ResumeLayout(false);
			this.tbXmls.ResumeLayout(false);
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
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tbBasicInfo;
		private System.Windows.Forms.TabPage tbSubModule;
		private System.Windows.Forms.TabPage tbXmls;
		private System.Windows.Forms.GroupBox groupbox_xmls;
		private System.Windows.Forms.Button btnModifyXmlNode;
		private System.Windows.Forms.Button btnDeleteXmlNode;
		private System.Windows.Forms.Button btnAddXmlNode;
		private System.Windows.Forms.ListView lsvXmls;
		private System.Windows.Forms.ColumnHeader colXmlNodeID;
		private System.Windows.Forms.ColumnHeader colXmlNodePath;
		private System.Windows.Forms.ColumnHeader colXmlNodeIncludedGameTypes;
		private System.Windows.Forms.GroupBox groupbox_submodules;
		private System.Windows.Forms.Button btnModifySubModule;
		private System.Windows.Forms.Button btnDeleteSubModule;
		private System.Windows.Forms.Button btnAddSubModule;
		private System.Windows.Forms.ListView lsvSubModules;
		private System.Windows.Forms.ColumnHeader colSubModuleName;
		private System.Windows.Forms.ColumnHeader colSubModule_DllName;
		private System.Windows.Forms.ColumnHeader colSubModuleClassType;
		private System.Windows.Forms.ColumnHeader colSubModuleTags;
		private System.Windows.Forms.Button btnEditDepencyModules;
		private System.Windows.Forms.TextBox txtBannerlordVersion;
		private System.Windows.Forms.Label lbVersion;
		private System.Windows.Forms.CheckBox chkMultiplayer;
		private System.Windows.Forms.CheckBox chkSinglePlayer;
	}
}