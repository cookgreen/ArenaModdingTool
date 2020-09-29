using ArenaModdingTool.Controls;
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

namespace ArenaModdingTool
{
    public partial class frmMain : Form, ILocalization
    {
        private AppSetting appSetting;
        private AMProject currentProject;
        public frmMain(AppSetting appSetting)
        {
            InitializeComponent();
            this.appSetting = appSetting;
            SwitchLanguage();

            MBBannerlordModManager.Instance.Init();

            foreach(var langName in LanguageManager.Instance.GetLanguageNames())
            {
                var item = mnuToolLanguage.DropDownItems.Add(langName);
                item.Click += (o, e) =>
                {
                    LanguageManager.Instance.CurrentLocalization = langName;
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
            btnFactions.Text = Helper.LOC("ui_main_form_panel_buttons_faction");
            btnTroops.Text = Helper.LOC("ui_main_form_panel_buttons_troop");
            btnParties.Text = Helper.LOC("ui_main_form_panel_buttons_parties");
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
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;
            foreach(var kingdoms in currentProject.BannerlordModule.ModuleKingdoms)
            {
                var moduleName = (new DirectoryInfo(kingdoms.FilePath).Parent.Parent.Name);
                var fileName = new DirectoryInfo(kingdoms.FilePath).Name;
                var page = new TabPage(moduleName + " - " + fileName);
                ucKingdomEditor factionEditorCtrl = new ucKingdomEditor(kingdoms);
                page.Controls.Clear();
                page.Controls.Add(factionEditorCtrl);
                factionEditorCtrl.Dock = DockStyle.Fill;
                tabControl.TabPages.Add(page);
            }
            panelMain.Controls.Clear();
            panelMain.Controls.Add(tabControl);
        }

        private void btnTroops_Click(object sender, EventArgs e)
        {

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
            }
        }

        private void OpenProject(AMProject currentProject)
        {
            btnFactions.Enabled = true;
            btnParties.Enabled = true;
            btnTroops.Enabled = true;
        }
    }
}
