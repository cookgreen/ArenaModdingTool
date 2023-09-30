namespace ArenaModdingTool
{
    partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.menu = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNewProject = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNewOtherFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileOpenProject = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileOpenOtherFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuRecentlyImportedProject = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTool = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolLanguage = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPlugin = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.panelControls = new System.Windows.Forms.Panel();
			this.btnItems = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnHeros = new System.Windows.Forms.Button();
			this.btnNPCCharacters = new System.Windows.Forms.Button();
			this.btnCultures = new System.Windows.Forms.Button();
			this.btnKingdoms = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.edtorPanel = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDebugMessageOutput = new System.Windows.Forms.RichTextBox();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.menu.SuspendLayout();
			this.panelControls.SuspendLayout();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.edtorPanel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTool,
            this.mnuPlugin,
            this.mnuHelp});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
			this.menu.Size = new System.Drawing.Size(1467, 30);
			this.menu.TabIndex = 0;
			this.menu.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImport,
            this.toolStripMenuItem3,
            this.mnuFileNew,
            this.mnuFileOpen,
            this.toolStripMenuItem1,
            this.mnuRecentlyImportedProject,
            this.toolStripMenuItem2,
            this.mnuFileExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(48, 24);
			this.mnuFile.Text = "File";
			// 
			// mnuImport
			// 
			this.mnuImport.Name = "mnuImport";
			this.mnuImport.Size = new System.Drawing.Size(155, 26);
			this.mnuImport.Text = "Import";
			this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 6);
			// 
			// mnuFileNew
			// 
			this.mnuFileNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewProject,
            this.mnuFileNewOtherFile});
			this.mnuFileNew.Name = "mnuFileNew";
			this.mnuFileNew.Size = new System.Drawing.Size(155, 26);
			this.mnuFileNew.Text = "New";
			// 
			// mnuFileNewProject
			// 
			this.mnuFileNewProject.Name = "mnuFileNewProject";
			this.mnuFileNewProject.Size = new System.Drawing.Size(144, 26);
			this.mnuFileNewProject.Text = "Project";
			this.mnuFileNewProject.Click += new System.EventHandler(this.mnuFileNewProject_Click);
			// 
			// mnuFileNewOtherFile
			// 
			this.mnuFileNewOtherFile.Name = "mnuFileNewOtherFile";
			this.mnuFileNewOtherFile.Size = new System.Drawing.Size(144, 26);
			this.mnuFileNewOtherFile.Text = "File";
			this.mnuFileNewOtherFile.Click += new System.EventHandler(this.mnuFileNewOtherFile_Click);
			// 
			// mnuFileOpen
			// 
			this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenProject,
            this.mnuFileOpenOtherFile});
			this.mnuFileOpen.Name = "mnuFileOpen";
			this.mnuFileOpen.Size = new System.Drawing.Size(155, 26);
			this.mnuFileOpen.Text = "Open";
			// 
			// mnuFileOpenProject
			// 
			this.mnuFileOpenProject.Name = "mnuFileOpenProject";
			this.mnuFileOpenProject.Size = new System.Drawing.Size(144, 26);
			this.mnuFileOpenProject.Text = "Project";
			// 
			// mnuFileOpenOtherFile
			// 
			this.mnuFileOpenOtherFile.Name = "mnuFileOpenOtherFile";
			this.mnuFileOpenOtherFile.Size = new System.Drawing.Size(144, 26);
			this.mnuFileOpenOtherFile.Text = "File";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
			// 
			// mnuRecentlyImportedProject
			// 
			this.mnuRecentlyImportedProject.Name = "mnuRecentlyImportedProject";
			this.mnuRecentlyImportedProject.Size = new System.Drawing.Size(155, 26);
			this.mnuRecentlyImportedProject.Text = "Recently";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Name = "mnuFileExit";
			this.mnuFileExit.Size = new System.Drawing.Size(155, 26);
			this.mnuFileExit.Text = "Exit";
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			// 
			// mnuTool
			// 
			this.mnuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolLanguage});
			this.mnuTool.Name = "mnuTool";
			this.mnuTool.Size = new System.Drawing.Size(56, 24);
			this.mnuTool.Text = "Tool";
			// 
			// mnuToolLanguage
			// 
			this.mnuToolLanguage.Name = "mnuToolLanguage";
			this.mnuToolLanguage.Size = new System.Drawing.Size(159, 26);
			this.mnuToolLanguage.Text = "language";
			// 
			// mnuPlugin
			// 
			this.mnuPlugin.Name = "mnuPlugin";
			this.mnuPlugin.Size = new System.Drawing.Size(68, 24);
			this.mnuPlugin.Text = "Plugin";
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(58, 24);
			this.mnuHelp.Text = "Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(138, 26);
			this.mnuAbout.Text = "About";
			// 
			// panelControls
			// 
			this.panelControls.AutoScroll = true;
			this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelControls.Controls.Add(this.button1);
			this.panelControls.Controls.Add(this.btnItems);
			this.panelControls.Controls.Add(this.btnHeros);
			this.panelControls.Controls.Add(this.btnNPCCharacters);
			this.panelControls.Controls.Add(this.btnCultures);
			this.panelControls.Controls.Add(this.btnKingdoms);
			this.panelControls.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelControls.Location = new System.Drawing.Point(0, 30);
			this.panelControls.Margin = new System.Windows.Forms.Padding(6);
			this.panelControls.Name = "panelControls";
			this.panelControls.Size = new System.Drawing.Size(330, 832);
			this.panelControls.TabIndex = 1;
			// 
			// btnItems
			// 
			this.btnItems.Enabled = false;
			this.btnItems.ImageKey = "icon-item.png";
			this.btnItems.ImageList = this.imageList1;
			this.btnItems.Location = new System.Drawing.Point(14, 589);
			this.btnItems.Margin = new System.Windows.Forms.Padding(6);
			this.btnItems.Name = "btnItems";
			this.btnItems.Size = new System.Drawing.Size(285, 130);
			this.btnItems.TabIndex = 4;
			this.btnItems.Text = "Items";
			this.btnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnItems.UseVisualStyleBackColor = true;
			this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icon-culture.png");
			this.imageList1.Images.SetKeyName(1, "icon-hero.png");
			this.imageList1.Images.SetKeyName(2, "icon-item.png");
			this.imageList1.Images.SetKeyName(3, "icon-kingdom.png");
			this.imageList1.Images.SetKeyName(4, "icon-troop.png");
			// 
			// btnHeros
			// 
			this.btnHeros.Enabled = false;
			this.btnHeros.ImageKey = "icon-hero.png";
			this.btnHeros.ImageList = this.imageList1;
			this.btnHeros.Location = new System.Drawing.Point(14, 447);
			this.btnHeros.Margin = new System.Windows.Forms.Padding(6);
			this.btnHeros.Name = "btnHeros";
			this.btnHeros.Size = new System.Drawing.Size(285, 130);
			this.btnHeros.TabIndex = 3;
			this.btnHeros.Text = "Heros";
			this.btnHeros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHeros.UseVisualStyleBackColor = true;
			this.btnHeros.Click += new System.EventHandler(this.btnHeros_Click);
			// 
			// btnNPCCharacters
			// 
			this.btnNPCCharacters.Enabled = false;
			this.btnNPCCharacters.ImageKey = "icon-troop.png";
			this.btnNPCCharacters.ImageList = this.imageList1;
			this.btnNPCCharacters.Location = new System.Drawing.Point(14, 305);
			this.btnNPCCharacters.Margin = new System.Windows.Forms.Padding(6);
			this.btnNPCCharacters.Name = "btnNPCCharacters";
			this.btnNPCCharacters.Size = new System.Drawing.Size(285, 130);
			this.btnNPCCharacters.TabIndex = 2;
			this.btnNPCCharacters.Text = "NPCCharacters";
			this.btnNPCCharacters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNPCCharacters.UseVisualStyleBackColor = true;
			this.btnNPCCharacters.Click += new System.EventHandler(this.btnNPCCharacters_Click);
			// 
			// btnCultures
			// 
			this.btnCultures.Enabled = false;
			this.btnCultures.ImageKey = "icon-culture.png";
			this.btnCultures.ImageList = this.imageList1;
			this.btnCultures.Location = new System.Drawing.Point(14, 163);
			this.btnCultures.Margin = new System.Windows.Forms.Padding(6);
			this.btnCultures.Name = "btnCultures";
			this.btnCultures.Size = new System.Drawing.Size(285, 130);
			this.btnCultures.TabIndex = 1;
			this.btnCultures.Text = "Cultures";
			this.btnCultures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCultures.UseVisualStyleBackColor = true;
			this.btnCultures.Click += new System.EventHandler(this.btnCultures_Click);
			// 
			// btnKingdoms
			// 
			this.btnKingdoms.Enabled = false;
			this.btnKingdoms.ImageKey = "icon-kingdom.png";
			this.btnKingdoms.ImageList = this.imageList1;
			this.btnKingdoms.Location = new System.Drawing.Point(14, 21);
			this.btnKingdoms.Margin = new System.Windows.Forms.Padding(6);
			this.btnKingdoms.Name = "btnKingdoms";
			this.btnKingdoms.Size = new System.Drawing.Size(285, 130);
			this.btnKingdoms.TabIndex = 0;
			this.btnKingdoms.Text = "Kingdoms";
			this.btnKingdoms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnKingdoms.UseVisualStyleBackColor = true;
			this.btnKingdoms.Click += new System.EventHandler(this.btnKingdoms_Click);
			// 
			// panelMain
			// 
			this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelMain.Controls.Add(this.splitContainer1);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(330, 30);
			this.panelMain.Margin = new System.Windows.Forms.Padding(6);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1137, 832);
			this.panelMain.TabIndex = 2;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.edtorPanel);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Size = new System.Drawing.Size(1135, 830);
			this.splitContainer1.SplitterDistance = 678;
			this.splitContainer1.TabIndex = 0;
			// 
			// edtorPanel
			// 
			this.edtorPanel.Controls.Add(this.groupBox2);
			this.edtorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.edtorPanel.Location = new System.Drawing.Point(0, 0);
			this.edtorPanel.Name = "edtorPanel";
			this.edtorPanel.Size = new System.Drawing.Size(1135, 678);
			this.edtorPanel.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.mainPanel);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1135, 678);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Editor";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDebugMessageOutput);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1135, 148);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Debug Message";
			// 
			// txtDebugMessageOutput
			// 
			this.txtDebugMessageOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDebugMessageOutput.Location = new System.Drawing.Point(3, 26);
			this.txtDebugMessageOutput.Name = "txtDebugMessageOutput";
			this.txtDebugMessageOutput.ReadOnly = true;
			this.txtDebugMessageOutput.Size = new System.Drawing.Size(1129, 119);
			this.txtDebugMessageOutput.TabIndex = 0;
			this.txtDebugMessageOutput.Text = "";
			// 
			// mainPanel
			// 
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(3, 26);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1129, 649);
			this.mainPanel.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.ImageKey = "(无)";
			this.button1.ImageList = this.imageList1;
			this.button1.Location = new System.Drawing.Point(14, 737);
			this.button1.Margin = new System.Windows.Forms.Padding(6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(285, 130);
			this.button1.TabIndex = 5;
			this.button1.Text = "Party Templates";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1467, 862);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelControls);
			this.Controls.Add(this.menu);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menu;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Arena - Modding Tool for Bannerlord";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.panelControls.ResumeLayout(false);
			this.panelMain.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.edtorPanel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuPlugin;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuTool;
        private System.Windows.Forms.ToolStripMenuItem mnuToolLanguage;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewProject;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewOtherFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenProject;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenOtherFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button btnNPCCharacters;
        private System.Windows.Forms.Button btnCultures;
        private System.Windows.Forms.Button btnKingdoms;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.Button btnHeros;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.ToolStripMenuItem mnuRecentlyImportedProject;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox txtDebugMessageOutput;
		private System.Windows.Forms.Panel edtorPanel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button button1;
	}
}

