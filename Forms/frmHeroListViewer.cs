using ArenaModdingTool.Controls;
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

namespace ArenaModdingTool.Forms
{
    public partial class frmHeroListViewer : Form
    {
        private AMProject project;

        public frmHeroListViewer(AMProject project)
        {
            InitializeComponent();
            this.project = project;
            loadHeroes();
        }

        public MBHero SelectedHero { get; set; }

        private void loadHeroes()
        {
            if (project.BannerlordModule.ModuleHeroes == null || project.BannerlordModule.ModuleHeroes.Count == 0)
            {
                TabControl tabControl = new TabControl();
                tabControl.Dock = DockStyle.Fill;
                foreach (var mod in MBBannerlordModManager.Instance.OfficialMods)
                {
                    foreach (var cultures in mod.ModuleHeroes)
                    {
                        TabPage page = new TabPage(mod.ModuleInfo.Id.value + " - " + (new DirectoryInfo(cultures.FilePath).Name));
                        ucHeroList ucCultureList = new ucHeroList(cultures);
                        ucCultureList.SelectHeroChanged += UcCultureList_SelectHeroChanged;
                        page.Controls.Clear();
                        page.Controls.Add(ucCultureList);
                        ucCultureList.Dock = DockStyle.Fill;
                        tabControl.TabPages.Add(page);
                    }
                }
                panel1.Controls.Clear();
                panel1.Controls.Add(tabControl);
            }
            else
            {
                TabControl tabControl = new TabControl();
                tabControl.Dock = DockStyle.Fill;
                foreach (var heroes in project.BannerlordModule.ModuleHeroes)
                {
                    TabPage page = new TabPage((new DirectoryInfo(heroes.FilePath).Name));
                    ucHeroList ucCultureList = new ucHeroList(heroes);
                    ucCultureList.SelectHeroChanged += UcCultureList_SelectHeroChanged;
                    page.Controls.Clear();
                    page.Controls.Add(ucCultureList);
                    ucCultureList.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(page);
                }
                panel1.Controls.Clear();
                panel1.Controls.Add(tabControl);
            }
        }

        private void UcCultureList_SelectHeroChanged(ModdingFiles.MBHero hero, int index)
        {
            SelectedHero = hero;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (SelectedHero != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(Helper.LOC("str_error_message_please_select_a_valid_hero"));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
