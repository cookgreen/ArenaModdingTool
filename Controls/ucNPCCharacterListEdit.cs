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
        private MBBannerlordNPCCharacter selectedCharacter;
        private int selectedIndex;

        public event Action<MBBannerlordNPCCharacter, int, AddEditState> SelectNPCCharacterChanged;
        public ucNPCCharacterListEdit(MBBannerlordNPCCharacters characters)
        {
            InitializeComponent();
            ucNPCCharacterList = new ucNPCCharacterList(characters);
            ucNPCCharacterList.SelectNPCCharacterChanged += UcNPCCharacterList_SelectNPCCharacterChanged;
            panel2.Controls.Clear();
            panel2.Controls.Add(ucNPCCharacterList);
            ucNPCCharacterList.Dock = DockStyle.Fill;
            state = AddEditState.View;
        }

        private void UcNPCCharacterList_SelectNPCCharacterChanged(MBBannerlordNPCCharacter character, int index)
        {
            selectedCharacter = character;
            selectedIndex = index;
            SelectNPCCharacterChanged?.Invoke(character, index, state);
            if (character != null)
            {
                btnDelete.Enabled = true;
                btnModify.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            state = AddEditState.Add;

            ucNPCCharacterList.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;

            MBBannerlordNPCCharacter character = new MBBannerlordNPCCharacter();
            SelectNPCCharacterChanged?.Invoke(character, -1, state);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ucNPCCharacterList.DeleteSelected();
        }

        public void RefreshData()
        {
            ucNPCCharacterList.RefreshData();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            state = AddEditState.Edit;

            ucNPCCharacterList.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;

            SelectNPCCharacterChanged?.Invoke(selectedCharacter, selectedIndex, state);
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
