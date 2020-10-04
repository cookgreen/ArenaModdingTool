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
using ArenaModdingTool.Forms;

namespace ArenaModdingTool.Controls
{
    public partial class ucNPCCharacterDetails : UserControl
    {
        private AMProject project;
        private MBNPCCharacter character;
        private AddEditState state;
        private int index;

        public event Action<MBNPCCharacter, AddEditState, int> SaveNPCCharacterInfoFinished;

        public ucNPCCharacterDetails(AMProject project, MBNPCCharacter character, AddEditState state, int index)
        {
            InitializeComponent();
            this.project = project;
            this.character = character;
            this.state = state;
            this.index = index;

            LoadNPCCharacter();
        }

        private void LoadNPCCharacter()
        {
            txtID.Text = character.id;
            txtName.Text = character.name;
            txtVoice.Text = character.voice;
            txtCulture.Text = character.culture;
            chkIsCompanion.Checked = character.is_companion;
            chkIsFemale.Checked = character.is_female;
            chkIsHero.Checked = character.is_hero;
            chkIsMecenary.Checked = character.is_mecenary;
            txtCivilianTemplate.Text = character.civilian_template;
            cmbGroups.SelectedItem = character.default_group;
            txtOccupation.Text = character.occupation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveNPCCharacterInfoFinished?.Invoke(character, state, index);
        }

        private void btnEditFace_Click(object sender, EventArgs e)
        {
            frmNPCCharacterFaceEditor characterFaceEditor = new frmNPCCharacterFaceEditor(project, character);
            if (characterFaceEditor.ShowDialog() == DialogResult.OK)
            {
                character.Face = characterFaceEditor.CharacterFace;
            }
        }

        private void btnEditComponents_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSkills_Click(object sender, EventArgs e)
        {

        }

        private void btnEditEquipmentSet_Click(object sender, EventArgs e)
        {

        }

        private void btnEditOtherEquipments_Click(object sender, EventArgs e)
        {

        }

        private void txtCivilianTemplate_DoubleClick(object sender, EventArgs e)
        {
            frmNPCCharacterListViewer characterListViewer = new frmNPCCharacterListViewer(project);
            if (characterListViewer.ShowDialog() == DialogResult.OK)
            {
                txtCivilianTemplate.Text = "NPCCharacters." + characterListViewer.SelectedCharacter.id;
            }
        }

        private void txtCulture_DoubleClick(object sender, EventArgs e)
        {
            frmCultureListViewer cultureListViewer = new frmCultureListViewer(project);
            if (cultureListViewer.ShowDialog() == DialogResult.OK)
            {
                txtCulture.Text = "Cultures." + cultureListViewer.SelectedCulture.id;
            }
        }
    }
}
