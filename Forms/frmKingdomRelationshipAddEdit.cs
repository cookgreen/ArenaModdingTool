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
    public partial class frmKingdomRelationshipAddEdit : Form
    {
        private KingdomRelationship relationship;
        private ModdingProject project;
        private MBBannerlordKingdom kingdom;
        private bool isAddOrEdit;

        public KingdomRelationship Relationship
        {
            get { return relationship; }
        }

        public frmKingdomRelationshipAddEdit(ModdingProject project, MBBannerlordKingdom kingdom, bool isAddOrEdit, KingdomRelationship relationship = null)
        {
            InitializeComponent();
            this.project = project;
            this.kingdom = kingdom;
            this.isAddOrEdit = isAddOrEdit;
            if (!isAddOrEdit)
            {
                txtKingdom.Text = relationship.kingdom;
                txtValue.Text = relationship.value;
                chkIsAtWar.Checked = bool.Parse(relationship.isAtWar);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int intValue = -1;
            if (string.IsNullOrEmpty(txtKingdom.Text))
            {
                MessageBox.Show(Helper.LOC("str_error_message_please_select_a_valid_kingdom"));
                return;
            }
            if (string.IsNullOrEmpty(txtValue.Text) || int.TryParse(txtValue.Text, out intValue))
            {
                MessageBox.Show(Helper.LOC("str_error_message_please_input_a_valid_value"));
                return;
            }
            relationship = new KingdomRelationship();
            relationship.kingdom = txtKingdom.Text;
            relationship.value = intValue.ToString();
            relationship.isAtWar = chkIsAtWar.Checked.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKingdom_DoubleClick(object sender, EventArgs e)
        {
            frmKingdomListViewer kingdomListViewer = new frmKingdomListViewer(project);
            if (kingdomListViewer.ShowDialog() == DialogResult.OK && kingdom.id != kingdomListViewer.SelectedKingdom.id)
            {
                txtKingdom.Text = "Kingdoms." + kingdomListViewer.SelectedKingdom.id;
            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            int intValue;
            if (int.TryParse(txtValue.Text, out intValue))
            {
                if (intValue < 0)
                {
                    chkIsAtWar.Checked = true;
                }
                else if (intValue >= 0)
                {
                    chkIsAtWar.Checked = false;
                }
            }
        }
    }
}
