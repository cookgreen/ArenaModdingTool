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
    public partial class frmCultureListViewer : Form
    {
        private AMProject project;

        public frmCultureListViewer(AMProject project)
        {
            InitializeComponent();
            this.project = project;
            loadCulture();
        }

        public MBBannerlordCulture SelectedCulture { get; set; }

        private void loadCulture()
        {
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;
            foreach (var mod in MBBannerlordModManager.Instance.OfficialMods)
            {
                foreach (var cultures in mod.ModuleCultures)
                {
                    TabPage page = new TabPage(mod.ModuleInfo.Id.value + " - " + (new DirectoryInfo(cultures.FilePath).Name));
                    ucCultureList ucCultureList = new ucCultureList(cultures);
                    ucCultureList.SelectCultureChanged += UcCultureList_SelectCultureChanged;
                    page.Controls.Clear();
                    page.Controls.Add(ucCultureList);
                    ucCultureList.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(page);
                }
            }

            foreach (var cultures in project.BannerlordModule.ModuleCultures)
            {
                TabPage page = new TabPage((new DirectoryInfo(cultures.FilePath).Name));
                ucCultureList ucCultureList = new ucCultureList(cultures);
                ucCultureList.SelectCultureChanged += UcCultureList_SelectCultureChanged;
                page.Controls.Clear();
                page.Controls.Add(ucCultureList);
                ucCultureList.Dock = DockStyle.Fill;
                tabControl.TabPages.Add(page);
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(tabControl);
        }

        private void UcCultureList_SelectCultureChanged(MBBannerlordCulture culture, int index)
        {
            SelectedCulture = culture;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (SelectedCulture != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(Helper.LOC("str_error_message_please_select_a_valid_culture"));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
