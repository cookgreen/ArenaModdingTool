using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArenaModdingTool.ModdingFiles;

namespace ArenaModdingTool.Controls
{
    public partial class ucNPCCharacterEditor : UserControl
    {
        private MBNPCCharacters characters;
        private ucNPCCharacterListEdit npcListCtrl;
        private AMProject project;
        private AddEditState state;

        public ucNPCCharacterEditor(AMProject project, MBNPCCharacters characters)
        {
            InitializeComponent();
            this.characters = characters;
            state = AddEditState.View;

            npcListCtrl = new ucNPCCharacterListEdit(characters);
            npcListCtrl.SelectNPCCharacterChanged += NpcListCtrl_SelectNPCCharacterChanged; ;
            panel1.Controls.Clear();
            panel1.Controls.Add(npcListCtrl);
            npcListCtrl.Dock = DockStyle.Fill;
            this.project = project;
        }

        private void NpcListCtrl_SelectNPCCharacterChanged(MBNPCCharacter character, int index)
        {
            ucNPCCharacterDetails characterDetailsCtrl = new ucNPCCharacterDetails(project, character, state, index);
            panel2.Controls.Clear();
            panel2.Controls.Add(characterDetailsCtrl);
            characterDetailsCtrl.Dock = DockStyle.Fill;
        }
    }
}
