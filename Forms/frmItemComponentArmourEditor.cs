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
    public partial class frmItemComponentArmourEditor : Form
    {
        private MBItemArmour itemArmour;
        public MBItemArmour ItemArmour
        {
            get { return itemArmour; }
        }

        public frmItemComponentArmourEditor(MBItemArmour itemArmour)
        {
            InitializeComponent();
            this.itemArmour = itemArmour;

            if (itemArmour != null)
            {
                txtArmArmour.Text = itemArmour.arm_armor;
                txtBodyArmour.Text = itemArmour.body_armor;
                txtBreadCoverType.Text = itemArmour.beard_cover_type;
                txtHairCoverType.Text = itemArmour.hair_cover_type;
                txtHeadArmour.Text = itemArmour.head_armor;
                txtLegArmour.Text = itemArmour.leg_armor;
                txtMaterialType.Text = itemArmour.material_type;
                txtModifierGroup.Text = itemArmour.modifier_group;
                chkCoversBody.Checked = bool.Parse(itemArmour.covers_body);
                chkCoversHands.Checked = bool.Parse(itemArmour.covers_hands);
                chkCoversLegs.Checked = bool.Parse(itemArmour.covers_legs);
                chkHasGenderVariations.Checked = bool.Parse(itemArmour.has_gender_variations);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            itemArmour = new MBItemArmour();
            itemArmour.arm_armor = txtArmArmour.Text;
            itemArmour.beard_cover_type = txtBreadCoverType.Text;
            itemArmour.body_armor = txtBodyArmour.Text;
            itemArmour.covers_body = chkCoversBody.Checked.ToString();
            itemArmour.covers_hands = chkCoversHands.Checked.ToString();
            itemArmour.covers_legs = chkCoversLegs.Checked.ToString();
            itemArmour.hair_cover_type = txtHairCoverType.Text;
            itemArmour.has_gender_variations = chkHasGenderVariations.Checked.ToString();
            itemArmour.head_armor = txtHeadArmour.Text;
            itemArmour.leg_armor = txtLegArmour.Text;
            itemArmour.material_type = txtMaterialType.Text;
            itemArmour.modifier_group = txtModifierGroup.Text;

            DialogResult = DialogResult.OK;
            Close(); ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
