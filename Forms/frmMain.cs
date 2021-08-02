using ArenaModdingTool.Controls;
using ArenaModdingTool.Forms;
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
        private AMProject currentProject;
        private RecentOperations recentOperations;

        public frmMain(AppSetting appSetting, RecentOperations recentOperations)
        {
            InitializeComponent();
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
                        currentProject = new AMProject(recentOpt.Value);
                        OpenProject(currentProject);
                    };
                }
            }
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

        private void btnFactions_Click(object sender, EventArgs e)
        {
            string errMsg = string.Empty;
            bool canLoaded = false;
            if (!currentProject.BannerlordModule.HasModuleKingdomFile)
            {
                if (MessageBox.Show(Helper.LOC("str_info_message_no_any_characters_found_in_current_module"), Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                     DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    canLoaded = currentProject.CopyFileIntoCurrentModuleAndLoad("NPCCharacters", "npccharacters", out errMsg);

                    if (!canLoaded)
                    {
                        MessageBox.Show(errMsg, "Notice");
                        return;
                    }
                    else
                    {
                        currentProject.BannerlordModule.ModuleInfo.XmlNodes.Add(new ModdingFiles.MBXmlNode()
                        {
                            XmlName = new ModdingFiles.MBXmlNodeName()
                            {
                                id = "NPCCharacters",
                                path = "npccharacters"
                            },
                            IncludedGameTypes = new ModdingFiles.MBXmlNodeIncludedGameTypes()
                            {
                                GameTypes = new List<ModdingFiles.MBSubModuleInfoElement>()
                                {
                                    new ModdingFiles.MBSubModuleInfoElement(){value = "Campaign"},
                                    new ModdingFiles.MBSubModuleInfoElement(){value = "CampaignStoryMode"},
                                }
                            }
                        });
                        currentProject.SaveModuleInfo();
                    }
                }
            }

            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;
            foreach(var kingdoms in currentProject.BannerlordModule.ModuleKingdoms)
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
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tabControl);
        }

        private void btnCultures_Click(object sender, EventArgs e)
        {

        }

        private void btnNPCCharacters_Click(object sender, EventArgs e)
        {
            string errMsg = string.Empty;
            bool canLoaded = false;
            bool isContinue = true;

            if (!currentProject.BannerlordModule.HasModuleCharacterFile)
            {
                if (MessageBox.Show(Helper.LOC("str_info_message_no_any_characters_found_in_current_module"), Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                     DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    frmValueInputer frmInputFileName = new frmValueInputer(Helper.LOC("str_info_please_input_a_valid_file_name"));
                    if (frmInputFileName.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = frmInputFileName.Value;
                        canLoaded = currentProject.CopyFileIntoCurrentModuleAndLoad("NPCCharacters", fileName, out errMsg);

                        if (!canLoaded)
                        {
                            MessageBox.Show(errMsg, "Notice");
                            return;
                        }
                        else
                        {
                            currentProject.BannerlordModule.ModuleInfo.XmlNodes.Add(new ModdingFiles.MBXmlNode()
                            {
                                XmlName = new ModdingFiles.MBXmlNodeName()
                                {
                                    id = "NPCCharacters",
                                    path = "npccharacters"
                                },
                                IncludedGameTypes = new ModdingFiles.MBXmlNodeIncludedGameTypes()
                                {
                                    GameTypes = new List<ModdingFiles.MBSubModuleInfoElement>()
                                {
                                    new ModdingFiles.MBSubModuleInfoElement(){value = "Campaign"},
                                    new ModdingFiles.MBSubModuleInfoElement(){value = "CampaignStoryMode"},
                                }
                                }
                            });
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
                panelMain.Controls.Clear();
                panelMain.Controls.Add(tabControl);
            }
        }

        private void btnHeros_Click(object sender, EventArgs e)
        {

        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            string errMsg = string.Empty;
            bool canLoaded = false;
            bool isContinue = true;

            if (currentProject.BannerlordModule.ModuleItems.Count == 0)
            {
                if (MessageBox.Show(Helper.LOC("str_info_message_no_any_items_found_in_current_module"), Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                     DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    frmValueInputer frmInputFileName = new frmValueInputer(Helper.LOC("str_info_please_input_a_valid_file_name"));
                    if (frmInputFileName.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = frmInputFileName.Value;
                        canLoaded = currentProject.CopyFileIntoCurrentModuleAndLoad("Item", fileName, out errMsg);

                        if (!canLoaded)
                        {
                            MessageBox.Show(errMsg, "Notice");
                            return;
                        }
                        else
                        {
                            currentProject.BannerlordModule.ModuleInfo.XmlNodes.Add(new ModdingFiles.MBXmlNode()
                            {
                                XmlName = new ModdingFiles.MBXmlNodeName()
                                {
                                    id = "Items",
                                    path = "spitems"
                                },
                                IncludedGameTypes = new ModdingFiles.MBXmlNodeIncludedGameTypes()
                                {
                                    GameTypes = new List<ModdingFiles.MBSubModuleInfoElement>()
                                {
                                    new ModdingFiles.MBSubModuleInfoElement(){value = "Campaign"},
                                    new ModdingFiles.MBSubModuleInfoElement(){value = "CampaignStoryMode"},
                                }
                                }
                            });
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
                panelMain.Controls.Clear();
                panelMain.Controls.Add(tabControl);
            }
        }

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

        private void OpenProject(AMProject currentProject)
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
            frmCreateNewFile createNewFileForm = new frmCreateNewFile();
            if (createNewFileForm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
