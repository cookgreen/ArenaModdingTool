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
    public partial class frmKingdomListViewer : Form
    {
        private MBKingdom selectedKingdom;
        private AMProject project;

        public MBKingdom SelectedKingdom
        {
            get { return selectedKingdom; }
        }

        public frmKingdomListViewer(AMProject project)
        {
            InitializeComponent();
            this.project = project;
            LoadKingdoms();
        }

        private void LoadKingdoms()
        {
            if (project.BannerlordModule.ModuleKingdoms == null || project.BannerlordModule.ModuleKingdoms.Count == 0)
            {
                TabControl tabControl = new TabControl();
                tabControl.Dock = DockStyle.Fill;
                foreach (var mod in MBBannerlordModManager.Instance.OfficialMods)
                {
                    foreach (var kingdoms in mod.ModuleKingdoms)
                    {
                        TabPage page = new TabPage(mod.ModuleInfo.Id.value + " - " + (new DirectoryInfo(kingdoms.FilePath).Name));
                        ucKingdomList ucCultureList = new ucKingdomList(kingdoms);
                        ucCultureList.SelectKingdomChanged += UcKingdomList_SelectKingdomChanged; ;
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
                foreach (var kingdoms in project.BannerlordModule.ModuleKingdoms)
                {
                    TabPage page = new TabPage((new DirectoryInfo(kingdoms.FilePath).Name));
                    ucKingdomList ucKingdomList = new ucKingdomList(kingdoms);
                    ucKingdomList.SelectKingdomChanged += UcKingdomList_SelectKingdomChanged;
                    page.Controls.Clear();
                    page.Controls.Add(ucKingdomList);
                    ucKingdomList.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(page);
                }
                panel1.Controls.Clear();
                panel1.Controls.Add(tabControl);
            }
        }

        private void UcKingdomList_SelectKingdomChanged(MBKingdom kingdom, int index)
        {
            selectedKingdom = kingdom;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (selectedKingdom != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(Helper.LOC("str_error_message_please_a_valid_kingdom"));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
