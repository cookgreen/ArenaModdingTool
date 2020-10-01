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

        public frmNPCCharacterSkillAddEdit(bool isAddOrEdit = true, MBNPCCharacterSkill skill = null)
        {
            InitializeComponent();
            this.isAddOrEdit = isAddOrEdit;
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
        }
    }
}
