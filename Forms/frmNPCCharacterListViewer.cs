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
    public partial class frmNPCCharacterListViewer : Form
    {
        private AMProject project;
        private MBBannerlordNPCCharacter selectedCharacter;
        public MBBannerlordNPCCharacter SelectedCharacter
        {
            get { return selectedCharacter; }
        }
        public frmNPCCharacterListViewer(AMProject project)
        {
            InitializeComponent();
            this.project = project;
            loadNPCCharacter();
        }

        private void loadNPCCharacter()
        {
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;
            foreach (var mod in MBBannerlordModManager.Instance.OfficialMods)
            {
                foreach (var characters in mod.ModuleNPCCharacters)
                {
                    TabPage page = new TabPage(mod.ModuleInfo.Id.value + " - " + (new DirectoryInfo(characters.FilePath).Name));
                    ucNPCCharacterList ucCharacterList = new ucNPCCharacterList(characters);
                    ucCharacterList.SelectNPCCharacterChanged += UcCharacterList_SelectNPCCharacterChanged;
                    page.Controls.Clear();
                    page.Controls.Add(ucCharacterList);
                    ucCharacterList.Dock = DockStyle.Fill;
                    tabControl.TabPages.Add(page);
                }
            }

            foreach (var characters in project.BannerlordModule.ModuleNPCCharacters)
            {
                TabPage page = new TabPage((new DirectoryInfo(characters.FilePath).Name));
                ucNPCCharacterList ucCharacterList = new ucNPCCharacterList(characters);
                ucCharacterList.SelectNPCCharacterChanged += UcCharacterList_SelectNPCCharacterChanged; ;
                page.Controls.Clear();
                page.Controls.Add(ucCharacterList);
                ucCharacterList.Dock = DockStyle.Fill;
                tabControl.TabPages.Add(page);
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(tabControl);
        }

        private void UcCharacterList_SelectNPCCharacterChanged(MBBannerlordNPCCharacter character, int index)
        {
            selectedCharacter = character;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (selectedCharacter != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(Helper.LOC("str_error_message_please_select_a_valid_character"));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
