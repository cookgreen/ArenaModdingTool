using ArenaModdingTool.ModdingFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool.Forms
{
    public partial class frmNPCCharacterSkillAddEdit : Form
    {
        private bool isAddOrEdit;
        private MBNPCCharacterSkill skill;
        public MBNPCCharacterSkill Skill
        {
            get { return skill; }
        }

        MBBannerlordNPCCharacter character;

        public frmNPCCharacterSkillAddEdit(MBBannerlordNPCCharacter character, bool isAddOrEdit = true, MBNPCCharacterSkill skill = null)
        {
            InitializeComponent();
            this.isAddOrEdit = isAddOrEdit;
            this.character = character;

            loadHardcodedSkillList();
            if (!isAddOrEdit)
            {
                cmbSkills.SelectedItem = skill.id;
                numericUpDown1.Value = decimal.Parse(skill.value);
            }
        }

        private void loadHardcodedSkillList()
        {
            cmbSkills.Items.Clear();
            cmbSkills.Items.Add("OneHandWeapon");
            cmbSkills.Items.Add("TwoHandWeapon");
            cmbSkills.Items.Add("Polearm");
            cmbSkills.Items.Add("Crossbow");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var skillid = cmbSkills.SelectedItem.ToString();
            if (character.Skills.Where(o => o.id == skillid).Count() > 0)
            {
                MessageBox.Show(Helper.LOC("str_error_message_there_is_already_same_skill_id_existed"), Helper.LOC("str_error"));
                return;
            }

            skill = new MBNPCCharacterSkill();
            skill.id = cmbSkills.SelectedItem.ToString();
            skill.value = numericUpDown1.Value.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
