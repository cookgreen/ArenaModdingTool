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
    public partial class ucFactionDetails : UserControl
    {
        private AddEditState state;
        private MBSPKingdom kingdom;
        public ucFactionDetails(MBSPKingdom kingdom)
        {
            InitializeComponent();
            state = AddEditState.View;
            loadKingdomDetails(kingdom);
        }

        private void loadKingdomDetails(MBSPKingdom kingdom)
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

        }
    }
}
