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
using XmlLoader;

namespace ArenaModdingTool.Controls
{
    public partial class ucNPCCharacterEditor : UserControl
    {
        private MBNPCCharacters characters;
        private ucNPCCharacterListEdit trooperListCtrl;
        private AMProject project;

        public ucNPCCharacterEditor(AMProject project, MBNPCCharacters characters)
        {
            InitializeComponent();
            this.characters = characters;

            trooperListCtrl = new ucNPCCharacterListEdit(characters);
            trooperListCtrl.SelectNPCCharacterChanged += NpcListCtrl_SelectNPCCharacterChanged;
            panel1.Controls.Clear();
            panel1.Controls.Add(trooperListCtrl);
            trooperListCtrl.Dock = DockStyle.Fill;
            this.project = project;
        }

        private void NpcListCtrl_SelectNPCCharacterChanged(MBNPCCharacter character, int index, AddEditState state)
        {
            ucNPCCharacterDetails trooperDetailsCtrl = new ucNPCCharacterDetails(project, character, state, index);
            panel2.Controls.Clear();
            panel2.Controls.Add(trooperDetailsCtrl);
            trooperDetailsCtrl.Dock = DockStyle.Fill;
            trooperDetailsCtrl.SaveNPCCharacterInfoFinished += CharacterDetailsCtrl_SaveNPCCharacterInfoFinished;
        }

        private void CharacterDetailsCtrl_SaveNPCCharacterInfoFinished(MBNPCCharacter savedCharatcer, AddEditState state, int index)
        {
            if (state == AddEditState.Add)
            {
                characters.NPCCharacters.Add(savedCharatcer);
                XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(characters.FilePath);
                xmlObjectLoader.Save(characters);
                trooperListCtrl.ChangeAddEditState(AddEditState.View);
                trooperListCtrl.RefreshData();
            }
            else if (state == AddEditState.Edit)
            {
                characters.NPCCharacters[index] = savedCharatcer;
                XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(characters.FilePath);
                xmlObjectLoader.Save(characters);
                trooperListCtrl.ChangeAddEditState(AddEditState.View);
                trooperListCtrl.RefreshData();
            }
        }
    }
}
