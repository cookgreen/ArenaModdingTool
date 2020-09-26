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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnParties = new System.Windows.Forms.Button();
            this.btnTroops = new System.Windows.Forms.Button();
            this.btnFactions = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.toolStripMenuItem1,
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
            this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
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
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenProject,
            this.mnuFileOpenOtherFile});
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(180, 22);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "Exit";
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
            this.panelControls.Controls.Add(this.btnParties);
            this.panelControls.Controls.Add(this.btnTroops);
            this.panelControls.Controls.Add(this.btnFactions);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControls.Location = new System.Drawing.Point(0, 25);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(142, 425);
            this.panelControls.TabIndex = 1;
            // 
            // btnParties
            // 
            this.btnParties.Enabled = false;
            this.btnParties.Location = new System.Drawing.Point(29, 201);
            this.btnParties.Name = "btnParties";
            this.btnParties.Size = new System.Drawing.Size(75, 50);
            this.btnParties.TabIndex = 2;
            this.btnParties.Text = "Parties";
            this.btnParties.UseVisualStyleBackColor = true;
            // 
            // btnTroops
            // 
            this.btnTroops.Enabled = false;
            this.btnTroops.Location = new System.Drawing.Point(29, 108);
            this.btnTroops.Name = "btnTroops";
            this.btnTroops.Size = new System.Drawing.Size(75, 50);
            this.btnTroops.TabIndex = 1;
            this.btnTroops.Text = "Troops";
            this.btnTroops.UseVisualStyleBackColor = true;
            // 
            // btnFactions
            // 
            this.btnFactions.Enabled = false;
            this.btnFactions.Location = new System.Drawing.Point(29, 19);
            this.btnFactions.Name = "btnFactions";
            this.btnFactions.Size = new System.Drawing.Size(75, 50);
            this.btnFactions.TabIndex = 0;
            this.btnFactions.Text = "Factions";
            this.btnFactions.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(142, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 425);
            this.panel2.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewProject;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewOtherFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenProject;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenOtherFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button btnParties;
        private System.Windows.Forms.Button btnTroops;
        private System.Windows.Forms.Button btnFactions;
    }
}

