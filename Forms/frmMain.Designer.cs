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
			this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNewProject = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileNewOtherFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileOpenProject = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuFileOpenOtherFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuRecentlyImportedProject = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTool = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolLanguage = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPlugin = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.panelControls = new System.Windows.Forms.Panel();
			this.btnItems = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnHeros = new System.Windows.Forms.Button();
			this.btnNPCCharacters = new System.Windows.Forms.Button();
			this.btnCultures = new System.Windows.Forms.Button();
			this.btnKingdoms = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.menu.SuspendLayout();
			this.panelControls.SuspendLayout();
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
			// mnuFileNew
			// 
			this.mnuFileNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewProject,
            this.mnuFileNewOtherFile});
			this.mnuFileNew.Name = "mnuFileNew";
			this.mnuFileNew.Size = new System.Drawing.Size(224, 26);
			this.mnuFileNew.Text = "New";
			// 
			// mnuFileNewProject
			// 
			this.mnuFileNewProject.Name = "mnuFileNewProject";
			this.mnuFileNewProject.Size = new System.Drawing.Size(224, 26);
			this.mnuFileNewProject.Text = "Project";
			this.mnuFileNewProject.Click += new System.EventHandler(this.mnuFileNewProject_Click);
			// 
			// mnuFileNewOtherFile
			// 
			this.mnuFileNewOtherFile.Name = "mnuFileNewOtherFile";
			this.mnuFileNewOtherFile.Size = new System.Drawing.Size(224, 26);
			this.mnuFileNewOtherFile.Text = "File";
			this.mnuFileNewOtherFile.Click += new System.EventHandler(this.mnuFileNewOtherFile_Click);
			// 
			// mnuFileOpen
			// 
			this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenProject,
            this.mnuFileOpenOtherFile});
			this.mnuFileOpen.Name = "mnuFileOpen";
			this.mnuFileOpen.Size = new System.Drawing.Size(224, 26);
			this.mnuFileOpen.Text = "Open";
			// 
			// mnuFileOpenProject
			// 
			this.mnuFileOpenProject.Name = "mnuFileOpenProject";
			this.mnuFileOpenProject.Size = new System.Drawing.Size(224, 26);
			this.mnuFileOpenProject.Text = "Project";
			// 
			// mnuFileOpenOtherFile
			// 
			this.mnuFileOpenOtherFile.Name = "mnuFileOpenOtherFile";
			this.mnuFileOpenOtherFile.Size = new System.Drawing.Size(224, 26);
			this.mnuFileOpenOtherFile.Text = "File";
			// 
			// mnuImport
			// 
			this.mnuImport.Name = "mnuImport";
			this.mnuImport.Size = new System.Drawing.Size(224, 26);
			this.mnuImport.Text = "Import";
			this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
			// 
			// mnuRecentlyImportedProject
			// 
			this.mnuRecentlyImportedProject.Name = "mnuRecentlyImportedProject";
			this.mnuRecentlyImportedProject.Size = new System.Drawing.Size(224, 26);
			this.mnuRecentlyImportedProject.Text = "Recently";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Name = "mnuFileExit";
			this.mnuFileExit.Size = new System.Drawing.Size(224, 26);
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
			this.mnuToolLanguage.Size = new System.Drawing.Size(224, 26);
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
			// panelControls
			// 
			this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelControls.Controls.Add(this.btnItems);
			this.panelControls.Controls.Add(this.btnHeros);
			this.panelControls.Controls.Add(this.btnNPCCharacters);
			this.panelControls.Controls.Add(this.btnCultures);
			this.panelControls.Controls.Add(this.btnKingdoms);
			this.panelControls.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelControls.Location = new System.Drawing.Point(0, 30);
			this.panelControls.Margin = new System.Windows.Forms.Padding(6);
			this.panelControls.Name = "panelControls";
			this.panelControls.Size = new System.Drawing.Size(312, 832);
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
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(312, 30);
			this.panelMain.Margin = new System.Windows.Forms.Padding(6);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1155, 832);
			this.panelMain.TabIndex = 2;
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(224, 26);
			this.mnuAbout.Text = "About";
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
	}
}

