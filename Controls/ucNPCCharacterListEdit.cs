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
    public partial class ucNPCCharacterListEdit : UserControl
    {
        private ucNPCCharacterList ucNPCCharacterList;
        private AddEditState state;
        private MBNPCCharacter selectedCharacter;
        private int selectedIndex;

        public event Action<MBNPCCharacter, int> SelectNPCCharacterChanged;
        public ucNPCCharacterListEdit(MBNPCCharacters characters)
        {
            InitializeComponent();
            ucNPCCharacterList = new ucNPCCharacterList(characters);
            ucNPCCharacterList.SelectNPCCharacterChanged += UcNPCCharacterList_SelectNPCCharacterChanged;
            panel2.Controls.Clear();
            panel2.Controls.Add(ucNPCCharacterList);
            ucNPCCharacterList.Dock = DockStyle.Fill;
        }

        private void UcNPCCharacterList_SelectNPCCharacterChanged(MBNPCCharacter arg1, int arg2)
        {
            selectedCharacter = arg1;
            selectedIndex = arg2;
            SelectNPCCharacterChanged?.Invoke(arg1, arg2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            state = AddEditState.Add;

            ucNPCCharacterList.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;

            MBNPCCharacter character = new MBNPCCharacter();
            SelectNPCCharacterChanged?.Invoke(character, -1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            state = AddEditState.Edit;

            ucNPCCharacterList.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;

            SelectNPCCharacterChanged?.Invoke(selectedCharacter, selectedIndex);
        }

        public void ChangeAddEditState(AddEditState newState)
        {
            if ((state == AddEditState.Add || state == AddEditState.Edit) &&
                 newState == AddEditState.View)
            {
                ucNPCCharacterList.Enabled = true;
                btnAdd.Enabled = true;
                if (ucNPCCharacterList.SelectedCharacter != null)
                {
                    btnDelete.Enabled = true;
                    btnModify.Enabled = true;
                }

                state = newState;
            }
        }
    }
}
