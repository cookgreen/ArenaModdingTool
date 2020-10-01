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

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }
    }
}
