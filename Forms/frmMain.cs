﻿using ArenaModdingTool.Controls;
using ArenaModdingTool.Entities;
using ArenaModdingTool.Forms;
using ArenaModdingTool.ModdingFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlLoader;

namespace ArenaModdingTool
{
    public partial class frmMain : Form, ILocalization
    {
        private AppSetting appSetting;
        private ModdingProject currentProject;
        private RecentOperations recentOperations;

        public frmMain(AppSetting appSetting, RecentOperations recentOperations)
        {
            InitializeComponent();

			DebugMessageManager.Instance.MessageReceived += DebugMessageReceived;

            this.appSetting = appSetting;

            LanguageManager.Instance.CurrentLocalization = appSetting.Localization;

            SwitchLanguage();

            foreach(var langName in LanguageManager.Instance.GetLanguageNames())
            {
                var item = mnuToolLanguage.DropDownItems.Add(langName);
                item.Click += (o, e) =>
                {
                    LanguageManager.Instance.CurrentLocalization = langName;
                    appSetting.Localization = langName;
                    appSetting.Save();
                    SwitchLanguage();
                    foreach (var control in panelMain.Controls)
                    {
                        if (control is ILocalization)
                        {
                            (control as ILocalization).SwitchLanguage();
                        }
                    }
                };
            }

            this.recentOperations = recentOperations;
            foreach (var recentOpt in recentOperations.RecentOperationList)
            {
                if (recentOpt.Type == "Import")
                {
                    var item = mnuRecentlyImportedProject.DropDownItems.Add(recentOpt.Value);
                    item.Click += (o, e) =>
                    {
                        if (!Directory.Exists(recentOpt.Value))
                        {
                            MessageBox.Show(Helper.LOC("str_error_message_cannot_find_specific_directory"), Helper.LOC("str_error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        currentProject = new ModdingProject(recentOpt.Value);
                        OpenProject(currentProject);
                    };
                }
            }
        }

		private void DebugMessageReceived(string message, DebugMessageLevel level)
		{
            Color textColor = Color.Black;
            string prefix = string.Empty;
            switch(level)
            {
                case DebugMessageLevel.Info:
                    textColor = Color.Blue;
                    prefix = "[INFO] ";
					break;
                case DebugMessageLevel.Warning:
                    textColor = Color.Yellow;
					prefix = "[WARNING] ";
					break;
                case DebugMessageLevel.Error:
                    textColor = Color.Red;
					prefix = "[ERROR] ";
					break;
            }
            txtDebugMessageOutput.ForeColor = textColor;
            txtDebugMessageOutput.AppendText(prefix + message);
		}

		public void SwitchLanguage()
        {
            Text = Helper.LOC("ui_main_form_title");
            mnuFile.Text = Helper.LOC("ui_main_form_mnuFile");
            mnuFileNew.Text = Helper.LOC("ui_main_form_mnuFileNew");
            mnuFileNewProject.Text = Helper.LOC("ui_main_form_mnuFileNewProject");
            mnuFileNewOtherFile.Text = Helper.LOC("ui_main_form_mnuFileNewOtherFile");
            mnuFileOpen.Text = Helper.LOC("ui_main_form_mnuFileOpen");
            mnuFileOpenProject.Text = Helper.LOC("ui_main_form_mnuFileOpenProjet");
            mnuFileOpenOtherFile.Text = Helper.LOC("ui_main_form_mnuFileOpenOtherProject");
            mnuPlugin.Text = Helper.LOC("ui_main_form_mnuPlugin");
            mnuImport.Text = Helper.LOC("ui_main_form_mnuImport");
            mnuFileExit.Text = Helper.LOC("ui_main_form_mnuFileExit");
            mnuTool.Text = Helper.LOC("ui_main_form_mnuTool");
            mnuToolLanguage.Text = Helper.LOC("ui_main_form_mnuToolLanguage");
            mnuHelp.Text = Helper.LOC("ui_main_form_mnuHelp");
            mnuRecentlyImportedProject.Text = Helper.LOC("ui_main_form_mnuRecentImportedProject");
            btnKingdoms.Text = Helper.LOC("ui_main_form_panel_buttons_kingdom_edit");
            btnCultures.Text = Helper.LOC("ui_main_form_panel_buttons_culture_edit");
            btnNPCCharacters.Text = Helper.LOC("ui_main_form_panel_buttons_npccharacters_edit");
            btnHeros.Text = Helper.LOC("ui_main_form_panel_buttons_heroes_edit");
            btnItems.Text = Helper.LOC("ui_main_form_panel_buttons_items_edit");
        }

        private void mnuFileNewProject_Click(object sender, EventArgs e)
        {
            frmNewProject newProjectForm = new frmNewProject();
            if (newProjectForm.ShowDialog() == DialogResult.OK)
            {
                currentProject = newProjectForm.NewProject;
            }
        }

        #region Five main features

        private void btnKingdoms_Click(object sender, EventArgs e)
        {
            bool isContinue = true;
            if (!currentProject.BannerlordModule.HasModuleKingdomFile)
            {
                var dialogResult = MessageBox.Show(Helper.LOC("str_info_message_no_any_kingdoms_found_in_current_module"), Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    frmCreateNewFile frmCreateNewFile = new frmCreateNewFile(null, currentProject.BannerlordModule.ModuleDataPath, "SPKingdoms");
                    if (frmCreateNewFile.ShowDialog() == DialogResult.OK)
                    {
                        var fileName = frmCreateNewFile.FileName;
                        string errMsg;
                        bool canLoaded = currentProject.CopyFileIntoCurrentModuleAndLoad("Kingdom", fileName, out errMsg);

                        if (!canLoaded)
                        {
                            MessageBox.Show(errMsg, "Notice");
                            return;
                        }
                        else
                        {
                            var mbXmlNode = frmCreateNewFile.MBXmlNode;
                            currentProject.BannerlordModule.ModuleInfo.XmlNodes.Add(mbXmlNode);
                            currentProject.SaveModuleInfo();
                        }
                    }
                    else
                    {
                        isContinue = false;
                    }
                }
            }

            if (isContinue)
            {
                TabControl tabControl = new TabControl();
                tabControl.Dock = DockStyle.Fill;
                foreach (var kingdoms in currentProject.BannerlordModule.ModuleKingdoms)
                {
                    var moduleName = (new DirectoryInfo(kingdoms.FilePath).Parent.Parent.Name);
                    var fileName = new DirectoryInfo(kingdoms.FilePath).Name;
                    var page = new TabPage(moduleName + " - " + fileName);
                    ucKingdomEditor factionEditorCtrl = new ucKingdomEditor(currentProject, kingdoms);
                    page.Controls.Clear();
                    page.Controls.Add(factionEditorCtrl);
                    factionEditorCtrl.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(page);
                }
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(tabControl);
            }
        }

        private void btnNPCCharacters_Click(object sender, EventArgs e)
        {
            bool isContinue = true;
            if (!currentProject.BannerlordModule.HasModuleCharacterFile)
            {
                var dialogResult = MessageBox.Show(Helper.LOC("str_info_message_no_any_characters_found_in_current_module"), Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    frmCreateNewFile frmCreateNewFile = new frmCreateNewFile(null, currentProject.BannerlordModule.ModuleDataPath, "NPCCharacters");
                    string errMsg;
                    if (frmCreateNewFile.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = frmCreateNewFile.FileName;
                        bool canLoaded = currentProject.CopyFileIntoCurrentModuleAndLoad("NPCCharacters", fileName, out errMsg);

                        if (!canLoaded)
                        {
                            MessageBox.Show(errMsg, "Notice");
                            return;
                        }
                        else
                        {
                            var mbXmlNode = frmCreateNewFile.MBXmlNode;
                            currentProject.BannerlordModule.ModuleInfo.XmlNodes.Add(mbXmlNode);
                            currentProject.SaveModuleInfo();
                        }
                    }
                    else
                    {
                        isContinue = false;
                    }
                }
            }

            if (isContinue)
            {
                TabControl tabControl = new TabControl();
                tabControl.Dock = DockStyle.Fill;
                foreach (var characters in currentProject.BannerlordModule.ModuleNPCCharacters)
                {
                    var moduleName = (new DirectoryInfo(characters.FilePath).Parent.Parent.Name);
                    var fileName = new DirectoryInfo(characters.FilePath).Name;
                    var page = new TabPage(moduleName + " - " + fileName);
                    ucNPCCharacterEditor npcCharacterEditor = new ucNPCCharacterEditor(currentProject, characters);
                    page.Controls.Clear();
                    page.Controls.Add(npcCharacterEditor);
                    npcCharacterEditor.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(page);
                }
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(tabControl);
            }
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            bool isContinue = true;

            if (currentProject.BannerlordModule.ModuleItems.Count == 0)
            {
                var dialogResult = MessageBox.Show(Helper.LOC("str_info_message_no_any_items_found_in_current_module"), Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    frmCreateNewFile createNewFileWin = new frmCreateNewFile(null, currentProject.BannerlordModule.ModuleDataPath, "Items");
                    if (createNewFileWin.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = createNewFileWin.FileName;
                        string errMsg;
                        bool canLoaded = currentProject.CopyFileIntoCurrentModuleAndLoad("Items", fileName, out errMsg);

                        if (!canLoaded)
                        {
                            MessageBox.Show(errMsg, "Notice");
                            return;
                        }
                        else
                        {
                            var mbXmlNode = createNewFileWin.MBXmlNode;
                            currentProject.BannerlordModule.ModuleInfo.XmlNodes.Add(mbXmlNode);
                            currentProject.SaveModuleInfo();
                        }
                    }
                    else
                    {
                        isContinue = false;
                    }
                }
            }

            if (isContinue)
            {
                TabControl tabControl = new TabControl();
                tabControl.Dock = DockStyle.Fill;
                foreach (var items in currentProject.BannerlordModule.ModuleItems)
                {
                    var moduleName = (new DirectoryInfo(items.FilePath).Parent.Parent.Name);
                    var fileName = new DirectoryInfo(items.FilePath).Name;
                    var page = new TabPage(moduleName + " - " + fileName);
                    ucItemsEditor itemsEditor = new ucItemsEditor(currentProject, items);
                    page.Controls.Clear();
                    page.Controls.Add(itemsEditor);
                    itemsEditor.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(page);
                }
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(tabControl);
            }
        }

        private void btnHeros_Click(object sender, EventArgs e)
        {
            bool isContinue = true;

            if (currentProject.BannerlordModule.ModuleHeroes.Count == 0)
            {
                var dialogResult = MessageBox.Show(Helper.LOC("str_info_message_no_any_heroes_found_in_current_module"), Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    frmCreateNewFile createNewFileWin = new frmCreateNewFile(null, currentProject.BannerlordModule.ModuleDataPath, "Heroes");
                    if (createNewFileWin.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = createNewFileWin.FileName;
                        string errMsg;
                        bool canLoaded = currentProject.CopyFileIntoCurrentModuleAndLoad("Heroes", fileName, out errMsg);

                        if (!canLoaded)
                        {
                            MessageBox.Show(errMsg, "Notice");
                            return;
                        }
                        else
                        {
                            var mbXmlNode = createNewFileWin.MBXmlNode;
                            currentProject.BannerlordModule.ModuleInfo.XmlNodes.Add(mbXmlNode);
                            currentProject.SaveModuleInfo();
                        }
                    }
                    else
                    {
                        isContinue = false;
                    }
                }
            }

            if (isContinue)
            {
                TabControl tabControl = new TabControl();
                tabControl.Dock = DockStyle.Fill;
                foreach (var items in currentProject.BannerlordModule.ModuleHeroes)
                {
                    var moduleName = (new DirectoryInfo(items.FilePath).Parent.Parent.Name);
                    var fileName = new DirectoryInfo(items.FilePath).Name;
                    var page = new TabPage(moduleName + " - " + fileName);
                    ucHeroEditor heroEditor = new ucHeroEditor(currentProject, items);
                    page.Controls.Clear();
                    page.Controls.Add(heroEditor);
                    heroEditor.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(page);
                }
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(tabControl);
            }
        }

        private void btnCultures_Click(object sender, EventArgs e)
        {
            bool isContinue = true;

            if (currentProject.BannerlordModule.ModuleCultures.Count == 0)
            {
                var dialogResult = MessageBox.Show(Helper.LOC("str_info_message_no_any_cultures_found_in_current_module"), Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    frmCreateNewFile createNewFileWin = new frmCreateNewFile(null, currentProject.BannerlordModule.ModuleDataPath, "Cultures");
                    if (createNewFileWin.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = createNewFileWin.FileName;
                        string errMsg;
                        bool canLoaded = currentProject.CopyFileIntoCurrentModuleAndLoad("Cultures", fileName, out errMsg);

                        if (!canLoaded)
                        {
                            MessageBox.Show(errMsg, "Notice");
                            return;
                        }
                        else
                        {
                            var mbXmlNode = createNewFileWin.MBXmlNode;
                            currentProject.BannerlordModule.ModuleInfo.XmlNodes.Add(mbXmlNode);
                            currentProject.SaveModuleInfo();
                        }
                    }
                    else
                    {
                        isContinue = false;
                    }
                }
            }

            if (isContinue)
            {
                TabControl tabControl = new TabControl();
                tabControl.Dock = DockStyle.Fill;
                foreach (var items in currentProject.BannerlordModule.ModuleCultures)
                {
                    var moduleName = (new DirectoryInfo(items.FilePath).Parent.Parent.Name);
                    var fileName = new DirectoryInfo(items.FilePath).Name;
                    var page = new TabPage(moduleName + " - " + fileName);
                    ucCultureEditor cultureEditor = new ucCultureEditor(currentProject, items);
                    page.Controls.Clear();
                    page.Controls.Add(cultureEditor);
                    cultureEditor.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(page);
                }
				mainPanel.Controls.Clear();
				mainPanel.Controls.Add(tabControl);
            }
        }

        #endregion

        private void mnuImport_Click(object sender, EventArgs e)
        {
            importModuleProject();
        }

        private void importModuleProject()
        {
            frmImportProject importProjectForm = new frmImportProject();
            if (importProjectForm.ShowDialog() == DialogResult.OK)
            {
                currentProject = importProjectForm.Project;
                OpenProject(currentProject);

                string loc = currentProject.Location.Replace("\\", "/");
                if (recentOperations.RecentOperationList.Where(o => o.Value == loc).Count() == 0)
                {
                    recentOperations.RecentOperationList.Add(new RecentOperation()
                    {
                        Type = "Import",
                        Value = currentProject.Location.Replace("\\", "/")
                    });
                    XmlObjectLoader xmlObjectLoader = new XmlObjectLoader("RecentOperations.xml");
                    xmlObjectLoader.Save(recentOperations);
                }
            }
        }

        private void OpenProject(ModdingProject currentProject)
        {
            MBBannerlordModManager.Instance.Init();
            btnKingdoms.Enabled = true;
            btnNPCCharacters.Enabled = true;
            btnCultures.Enabled = true;
            btnHeros.Enabled = true;
            btnItems.Enabled = true;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuFileNewOtherFile_Click(object sender, EventArgs e)
        {
        }
    }
}
