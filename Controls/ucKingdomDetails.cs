﻿using System;
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
    public partial class ucKingdomDetails : UserControl
    {
        private AddEditState state;
        private MBKingdom kingdom;
        private int index;
        private AMProject project;

        public event Action<MBKingdom, AddEditState, int> SaveKingdomInfoFinished;
        public ucKingdomDetails(AMProject project, MBKingdom kingdom, AddEditState state, int index)
        {
            InitializeComponent();
            loadKingdomDetails(kingdom);
            this.state = state;
            this.index = index;
            this.project = project;
            if (state == AddEditState.Add || state == AddEditState.Edit)
            {
                btnSave.Enabled = true;
            }
            else if(state == AddEditState.View)
            {
                btnSave.Enabled = false;
            }
        }

        private void loadKingdomDetails(MBKingdom kingdom)
        {
            this.kingdom = kingdom;
            txtAlternativeColor.Text = kingdom.alternative_color;
            txtAlternativeColor2.Text = kingdom.alternative_color2;
            txtBannerKey.Text = kingdom.banner_key;
            txtColor.Text = kingdom.color;
            txtColor2.Text = kingdom.color2;
            txtCulture.Text = kingdom.culture;
            txtFlagMesh.Text = kingdom.flag_mesh;
            txtID.Text = kingdom.id;
            txtIntroduction.Text = kingdom.text;
            txtLabelColor.Text = kingdom.label_color;
            txtName.Text = kingdom.name;
            txtOwner.Text = kingdom.owner;
            txtPrimaryBannerColor.Text = kingdom.primary_banner_color;
            txtRulerTitle.Text = kingdom.ruler_title;
            txtSecondaryBannerlordColor.Text = kingdom.secondary_banner_color;
            txtSettlementBannerMesh.Text = kingdom.settlement_banner_mesh;
            txtShortName.Text = kingdom.short_name;
            txtTitle.Text = kingdom.title;
        }

        public void ChangeAddEditState(AddEditState state)
        {
            this.state = state;
        }

        private void colorTextBox_Click(object sender, EventArgs e)
        {
            string name = (sender as TextBox).Name;
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                string color = colorDialog.Color.ToHexString();
                string color2 = colorDialog.Color.ToHexStringPrefix("0x");
                if (name == txtAlternativeColor.Name)
                {
                    txtAlternativeColor.Text = color;
                }
                else if (name == txtAlternativeColor2.Name)
                {
                    txtAlternativeColor2.Text = color;
                }
                else if (name == txtColor.Name)
                {
                    txtColor.Text = color;
                }
                else if (name == txtColor2.Name)
                {
                    txtColor2.Text = color;
                }
                else if (name == txtLabelColor.Name)
                {
                    txtLabelColor.Text = color;
                }
                else if (name == txtPrimaryBannerColor.Name)
                {
                    txtPrimaryBannerColor.Text = color2;
                }
                else if (name == txtSecondaryBannerlordColor.Name)
                {
                    txtSecondaryBannerlordColor.Text = color2;
                }
            }
        }

        private void txtBannerKey_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bannerlord.party/banner/");
        }

        private void txtBannerKey_Enter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtBannerKey, Helper.LOC("str_tooltip_message_double_click_textbox_will_open_banner_editor"));
        }

        private void btnEditRelationshipsAndPolicies_Click(object sender, EventArgs e)
        {
            frmKingdomRelationshipPolicyEditor relationshipPolicyEditor = new frmKingdomRelationshipPolicyEditor(project, kingdom);
            if (relationshipPolicyEditor.ShowDialog() == DialogResult.OK)
            {
                kingdom.Relationships = relationshipPolicyEditor.Relationships;
                kingdom.Policies = relationshipPolicyEditor.Policies;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show(Helper.LOC("str_error_message_ID_and_Name_are_necessary"));
                return;
            }

            kingdom.alternative_color = txtAlternativeColor.Text;
            kingdom.alternative_color2 = txtAlternativeColor2.Text;
            kingdom.banner_key = txtBannerKey.Text;
            kingdom.color = txtColor.Text;
            kingdom.color2 = txtColor2.Text;
            kingdom.culture = txtCulture.Text;
            kingdom.flag_mesh = txtFlagMesh.Text;
            kingdom.id = txtID.Text;
            kingdom.label_color = txtLabelColor.Text;
            kingdom.name = txtName.Text;
            kingdom.owner = txtOwner.Text;
            kingdom.primary_banner_color = txtPrimaryBannerColor.Text;
            kingdom.ruler_title = txtRulerTitle.Text;
            kingdom.secondary_banner_color = txtSecondaryBannerlordColor.Text;
            kingdom.settlement_banner_mesh = txtSettlementBannerMesh.Text;
            kingdom.short_name = txtShortName.Text;
            kingdom.text = txtIntroduction.Text;
            kingdom.title = txtTitle.Text;

            btnSave.Enabled = false;

            SaveKingdomInfoFinished?.Invoke(kingdom, state, index);

            state = AddEditState.View;
        }

        private void txtCulture_DoubleClick(object sender, EventArgs e)
        {
            frmCultureListViewer cultureListViewer = new frmCultureListViewer(project);
            if (cultureListViewer.ShowDialog() == DialogResult.OK)
            {
                txtCulture.Text = "Cultures." + cultureListViewer.SelectedCulture.id;
            }
        }

        private void txtOwner_DoubleClick(object sender, EventArgs e)
        {
            frmHeroListViewer heroListViewer = new frmHeroListViewer(project);
            if (heroListViewer.ShowDialog() == DialogResult.OK)
            {
                txtOwner.Text = "Heroes." + heroListViewer.SelectedHero.id;
            }
        }
    }
}
