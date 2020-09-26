using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool
{
    public partial class frmMain : Form, ILocalization
    {
        private AppSetting appSetting;
        public frmMain(AppSetting appSetting)
        {
            InitializeComponent();
            this.appSetting = appSetting;
            SwitchLanguage();
        }

        public void SwitchLanguage()
        {
            Text = Helper.LOC(appSetting.Localization, "ui_main_form_title");
            mnuFile.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuFile");
            mnuFileNew.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuFileNew");
            mnuFileNewProject.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuFileNewProject");
            mnuFileNewOtherFile.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuFileNewOtherFile");
            mnuFileOpen.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuFileOpen");
            mnuFileOpenProject.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuFileOpenProjet");
            mnuFileOpenOtherFile.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuFileOpenOtherProject");
            mnuPlugin.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuPlugin");
            mnuTool.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuTool");
            mnuToolLanguage.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuToolLanguage");
            mnuHelp.Text = Helper.LOC(appSetting.Localization, "ui_main_form_mnuHelp");
            btnFactions.Text = Helper.LOC(appSetting.Localization, "ui_main_form_panel_buttons_faction");
            btnTroops.Text = Helper.LOC(appSetting.Localization, "ui_main_form_panel_buttons_troop");
            btnParties.Text = Helper.LOC(appSetting.Localization, "ui_main_form_panel_buttons_parties");
        }
    }
}
