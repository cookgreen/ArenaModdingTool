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
    public partial class frmNPCCharacterSkillEditor : Form
    {
        private MBNPCCharacter character;
        private List<MBNPCCharacterSkill> skills;
        public List<MBNPCCharacterSkill> Skills
        {
            get { return skills; }
        }

        public frmNPCCharacterSkillEditor(MBNPCCharacter character)
        {
            InitializeComponent();
            this.character = character;
            loadSkills();
        }

        private void loadSkills()
        {
            skillListView.Items.Clear();
            foreach (var skill in character.Skills)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = skill.id;
                lvi.SubItems.Add(skill.value);
                skillListView.Items.Add(lvi);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            skills = new List<MBNPCCharacterSkill>();
            foreach (ListViewItem lvi in skillListView.Items)
            {
                MBNPCCharacterSkill skill = new MBNPCCharacterSkill();
                skill.id = lvi.SubItems[0].Text;
                skill.value = lvi.SubItems[1].Text;
                skills.Add(skill);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNPCCharacterSkillAddEdit characterSkillAddEdit = new frmNPCCharacterSkillAddEdit(character);
            if (characterSkillAddEdit.ShowDialog() == DialogResult.OK)
            {
                var skill = characterSkillAddEdit.Skill;
                ListViewItem lvi = new ListViewItem();
                lvi.Text = skill.id;
                lvi.SubItems.Add(skill.value);
                skillListView.Items.Add(lvi);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            skillListView.Items.Remove(skillListView.SelectedItems[0]);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var lvi = skillListView.SelectedItems[0];
            var selectedIndex = skillListView.SelectedIndices[0];

            MBNPCCharacterSkill oldSkill = new MBNPCCharacterSkill();
            oldSkill.id = lvi.SubItems[0].Text;
            oldSkill.value = lvi.SubItems[1].Text;

            frmNPCCharacterSkillAddEdit characterSkillAddEdit = new frmNPCCharacterSkillAddEdit(character, true, oldSkill);
            if (characterSkillAddEdit.ShowDialog() == DialogResult.OK)
            {
                var skill = characterSkillAddEdit.Skill;
                ListViewItem newItem = new ListViewItem();
                newItem.Text = skill.id;
                newItem.SubItems.Add(skill.value);
                skillListView.Items.Insert(selectedIndex, newItem);
            }
        }

        private void skillListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skillListView.SelectedIndices.Count > 0)
            {
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
