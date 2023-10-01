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
        private ModdingProject project;
        private MBBannerlordNPCCharacter character;
        private AddEditState state;
        private int index;

        public event Action<MBBannerlordNPCCharacter, AddEditState, int> SaveNPCCharacterInfoFinished;

        public ucNPCCharacterDetails(ModdingProject project, MBBannerlordNPCCharacter character, AddEditState state, int index)
        {
            InitializeComponent();
            initializeTooltip();

            this.project = project;
            this.character = character;
            this.state = state;
            this.index = index;

            if (state == AddEditState.View)
            {
                btnSave.Visible = false;
            }
            else
            {
                btnSave.Visible = true;
            }

            LoadNPCCharacter();
        }

		private void initializeTooltip()
		{
            toolTip.SetToolTip(txtID, Helper.LOC("str_tooltip_message_npc_character_details_id"));
            toolTip.SetToolTip(txtName, Helper.LOC("str_tooltip_message_npc_character_details_name"));
            toolTip.SetToolTip(txtVoice, Helper.LOC("str_tooltip_message_npc_character_details_voice"));
            toolTip.SetToolTip(txtCulture, Helper.LOC("str_tooltip_message_npc_character_details_culture"));
            toolTip.SetToolTip(chkIsHero, Helper.LOC("str_tooltip_message_npc_character_details_is_hero"));
            toolTip.SetToolTip(chkIsMecenary, Helper.LOC("str_tooltip_message_npc_character_details_is_mecenary"));
            toolTip.SetToolTip(chkIsFemale, Helper.LOC("str_tooltip_message_npc_character_details_is_female"));
            toolTip.SetToolTip(chkIsCompanion, Helper.LOC("str_tooltip_message_npc_character_details_is_companion"));
            toolTip.SetToolTip(txtCivilianTemplate, Helper.LOC("str_tooltip_message_npc_character_details_civilian_template"));
            toolTip.SetToolTip(cmbGroups, Helper.LOC("str_tooltip_message_npc_character_details_default_group"));
            toolTip.SetToolTip(txtOccupation, Helper.LOC("str_tooltip_message_npc_character_details_occupation"));
            toolTip.SetToolTip(btnEditFace, Helper.LOC("str_tooltip_message_npc_character_details_face"));
            toolTip.SetToolTip(btnEditComponents, Helper.LOC("str_tooltip_message_npc_character_details_component"));
            toolTip.SetToolTip(btnEditEquipmentSet, Helper.LOC("str_tooltip_message_npc_character_details_equipment_set"));
            toolTip.SetToolTip(btnEditOtherEquipments, Helper.LOC("str_tooltip_message_npc_character_details_other_equipment"));
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
            character.id = txtID.Text;
            character.name = txtName.Text;
            character.voice = txtVoice.Text;
            character.culture = txtCulture.Text;
            character.civilian_template = txtCivilianTemplate.Text;
            character.default_group = cmbGroups.SelectedItem.ToString();
            character.occupation = txtOccupation.Text;
            character.is_companion = chkIsCompanion.Checked;
            character.is_female = chkIsFemale.Checked;
            character.is_hero = chkIsHero.Checked;
            character.is_mecenary = chkIsMecenary.Checked;

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
            frmNPCCharacterSkillEditor characterSkillEditor = new frmNPCCharacterSkillEditor(character);
            if (characterSkillEditor.ShowDialog() == DialogResult.OK)
            {
                character.Skills = characterSkillEditor.Skills;
            }
        }

        private void btnEditEquipmentSet_Click(object sender, EventArgs e)
        {
            frmNPCCharacterEquipmentSetsEditor characterEquipmentSetsEditor = new frmNPCCharacterEquipmentSetsEditor(character);
            if (characterEquipmentSetsEditor.ShowDialog() == DialogResult.OK)
            {
                character.EquipmentSets = characterEquipmentSetsEditor.EquipmentSets;
            }
        }

        private void btnEditOtherEquipments_Click(object sender, EventArgs e)
        {
            frmNPCCharacterEquipmentsEditor characterEquipmentsEditor = new frmNPCCharacterEquipmentsEditor(false, character.OtherEquipments);
            if (characterEquipmentsEditor.ShowDialog() == DialogResult.OK)
            {
                character.OtherEquipments = characterEquipmentsEditor.Equipments;
            }
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
