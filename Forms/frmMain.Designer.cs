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
            this.btnHeros = new System.Windows.Forms.Button();
            this.btnNPCCharacters = new System.Windows.Forms.Button();
            this.btnCultures = new System.Windows.Forms.Button();
            this.btnKingdoms = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTool,
            this.mnuPlugin,
            this.mnuHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuImport,
            this.toolStripMenuItem1,
            this.mnuRecentlyImportedProject,
            this.toolStripMenuItem2,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(39, 21);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewProject,
            this.mnuFileNewOtherFile});
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(219, 22);
            this.mnuFileNew.Text = "New";
            // 
            // mnuFileNewProject
            // 
            this.mnuFileNewProject.Name = "mnuFileNewProject";
            this.mnuFileNewProject.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNewProject.Text = "Project";
            this.mnuFileNewProject.Click += new System.EventHandler(this.mnuFileNewProject_Click);
            // 
            // mnuFileNewOtherFile
            // 
            this.mnuFileNewOtherFile.Name = "mnuFileNewOtherFile";
            this.mnuFileNewOtherFile.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNewOtherFile.Text = "File";
            this.mnuFileNewOtherFile.Click += new System.EventHandler(this.mnuFileNewOtherFile_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenProject,
            this.mnuFileOpenOtherFile});
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(219, 22);
            this.mnuFileOpen.Text = "Open";
            // 
            // mnuFileOpenProject
            // 
            this.mnuFileOpenProject.Name = "mnuFileOpenProject";
            this.mnuFileOpenProject.Size = new System.Drawing.Size(116, 22);
            this.mnuFileOpenProject.Text = "Project";
            // 
            // mnuFileOpenOtherFile
            // 
            this.mnuFileOpenOtherFile.Name = "mnuFileOpenOtherFile";
            this.mnuFileOpenOtherFile.Size = new System.Drawing.Size(116, 22);
            this.mnuFileOpenOtherFile.Text = "File";
            // 
            // mnuImport
            // 
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(219, 22);
            this.mnuImport.Text = "Import";
            this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 6);
            // 
            // mnuRecentlyImportedProject
            // 
            this.mnuRecentlyImportedProject.Name = "mnuRecentlyImportedProject";
            this.mnuRecentlyImportedProject.Size = new System.Drawing.Size(219, 22);
            this.mnuRecentlyImportedProject.Text = "RecentlyImportedProject";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(219, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuTool
            // 
            this.mnuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolLanguage});
            this.mnuTool.Name = "mnuTool";
            this.mnuTool.Size = new System.Drawing.Size(46, 21);
            this.mnuTool.Text = "Tool";
            // 
            // mnuToolLanguage
            // 
            this.mnuToolLanguage.Name = "mnuToolLanguage";
            this.mnuToolLanguage.Size = new System.Drawing.Size(130, 22);
            this.mnuToolLanguage.Text = "language";
            // 
            // mnuPlugin
            // 
            this.mnuPlugin.Name = "mnuPlugin";
            this.mnuPlugin.Size = new System.Drawing.Size(55, 21);
            this.mnuPlugin.Text = "Plugin";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(47, 21);
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
            this.panelControls.Location = new System.Drawing.Point(0, 25);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(142, 425);
            this.panelControls.TabIndex = 1;
            // 
            // btnItems
            // 
            this.btnItems.Enabled = false;
            this.btnItems.Location = new System.Drawing.Point(22, 312);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(95, 68);
            this.btnItems.TabIndex = 4;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnHeros
            // 
            this.btnHeros.Enabled = false;
            this.btnHeros.Location = new System.Drawing.Point(22, 238);
            this.btnHeros.Name = "btnHeros";
            this.btnHeros.Size = new System.Drawing.Size(95, 68);
            this.btnHeros.TabIndex = 3;
            this.btnHeros.Text = "Heros";
            this.btnHeros.UseVisualStyleBackColor = true;
            this.btnHeros.Click += new System.EventHandler(this.btnHeros_Click);
            // 
            // btnNPCCharacters
            // 
            this.btnNPCCharacters.Enabled = false;
            this.btnNPCCharacters.Location = new System.Drawing.Point(22, 164);
            this.btnNPCCharacters.Name = "btnNPCCharacters";
            this.btnNPCCharacters.Size = new System.Drawing.Size(95, 68);
            this.btnNPCCharacters.TabIndex = 2;
            this.btnNPCCharacters.Text = "NPCCharacters";
            this.btnNPCCharacters.UseVisualStyleBackColor = true;
            this.btnNPCCharacters.Click += new System.EventHandler(this.btnNPCCharacters_Click);
            // 
            // btnCultures
            // 
            this.btnCultures.Enabled = false;
            this.btnCultures.Location = new System.Drawing.Point(22, 90);
            this.btnCultures.Name = "btnCultures";
            this.btnCultures.Size = new System.Drawing.Size(95, 68);
            this.btnCultures.TabIndex = 1;
            this.btnCultures.Text = "Cultures";
            this.btnCultures.UseVisualStyleBackColor = true;
            this.btnCultures.Click += new System.EventHandler(this.btnCultures_Click);
            // 
            // btnKingdoms
            // 
            this.btnKingdoms.Enabled = false;
            this.btnKingdoms.Location = new System.Drawing.Point(22, 16);
            this.btnKingdoms.Name = "btnKingdoms";
            this.btnKingdoms.Size = new System.Drawing.Size(95, 68);
            this.btnKingdoms.TabIndex = 0;
            this.btnKingdoms.Text = "Kingdoms";
            this.btnKingdoms.UseVisualStyleBackColor = true;
            this.btnKingdoms.Click += new System.EventHandler(this.btnKingdoms_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(142, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(658, 425);
            this.panelMain.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
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
    }
}

