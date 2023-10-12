using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ArenaModdingTool.ModdingFiles;

namespace ArenaModdingTool.Controls
{
    public partial class ucHeroDetails : UserControl
    {
        private ModdingProject project;
        private MBBannerlordHero hero;
        private int selectedIndex;
        private AddEditState addEditState;

        public event Action<MBBannerlordHero, AddEditState, int> SaveHeroInfoFinished;

        public ucHeroDetails(ModdingProject project, MBBannerlordHero hero, int index, AddEditState addEditState)
        {
            InitializeComponent();
            initializeTooltip();

            this.project = project;
            this.hero = hero;
            selectedIndex = index;
            this.addEditState = addEditState;

            switch(addEditState)
            {
                case AddEditState.Add:
                    hero = new MBBannerlordHero();
                    enableEditor();
                    break;
                case AddEditState.Edit:
					loadHeroDetails();
					enableEditor();
					break;
                case AddEditState.View:
					disableEditor();
					break;
            }
		}

		private void enableEditor()
		{
            txtBannerKey.Enabled = true;
            txtFaction.Enabled = true;
            txtFather.Enabled = true;
            txtID.Enabled = true;
            txtIntroduction.Enabled = true;
            txtMother.Enabled = true;
            txtSpouse.Enabled = true;

            chkIsAlive.Enabled = true;
            chkIsNoble.Enabled = true; 
		}

		private void disableEditor()
		{
			txtBannerKey.Enabled = false;
			txtFaction.Enabled = false;
			txtFather.Enabled = false;
			txtID.Enabled = false;
			txtIntroduction.Enabled = false;
			txtMother.Enabled = false;
			txtSpouse.Enabled = false;

			chkIsAlive.Enabled = false;
			chkIsNoble.Enabled = false;
		}

		private void initializeTooltip()
		{
            toolTip.SetToolTip(txtID, Helper.LOC("str_tooltip_message_hero_details_id"));
            toolTip.SetToolTip(chkIsNoble, Helper.LOC("str_tooltip_message_hero_details_is_noble"));
            toolTip.SetToolTip(txtFather, Helper.LOC("str_tooltip_message_hero_details_father"));
            toolTip.SetToolTip(txtMother, Helper.LOC("str_tooltip_message_hero_details_mother"));
            toolTip.SetToolTip(chkIsAlive, Helper.LOC("str_tooltip_message_hero_details_is_alive"));
            toolTip.SetToolTip(txtFaction, Helper.LOC("str_tooltip_message_hero_details_faction"));
            toolTip.SetToolTip(txtSpouse, Helper.LOC("str_tooltip_message_hero_details_spouse"));
            toolTip.SetToolTip(txtBannerKey, Helper.LOC("str_tooltip_message_hero_details_banner_key"));
            toolTip.SetToolTip(txtIntroduction, Helper.LOC("str_tooltip_message_hero_details_introduction"));
		}

		private void loadHeroDetails()
        {
            txtID.Text = hero.id;
            
            if (!string.IsNullOrEmpty(hero.is_noble))
            {
                chkIsNoble.Checked = bool.Parse(hero.is_noble);
            }
            
            txtFather.Text = hero.father;
            txtMother.Text = hero.mother;

            if (!string.IsNullOrEmpty(hero.alive))
            {
                chkIsAlive.Checked = bool.Parse(hero.alive);
            }

            txtFaction.Text = hero.faction;
            txtSpouse.Text = hero.spouse;
            txtBannerKey.Text = hero.banner_key;
            txtIntroduction.Text = hero.text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show(Helper.LOC("str_error_message_ID_and_Name_are_necessary"));
                return;
            }

            hero.id = txtID.Text;
            hero.is_noble = chkIsNoble.Checked.ToString();
            hero.mother = txtMother.Text;
            hero.spouse = txtSpouse.Text;
            hero.text = txtIntroduction.Text;
            hero.alive = chkIsAlive.Checked.ToString();
            hero.banner_key = txtBannerKey.Text;
            hero.faction = txtFaction.Text;
            hero.father = txtFather.Text;

            btnSave.Enabled = false;

            SaveHeroInfoFinished?.Invoke(hero, addEditState, selectedIndex);

            addEditState = AddEditState.View;
		}

		private void txtBannerKey_DoubleClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://bannerlord.party/banner/");
		}
	}
}
