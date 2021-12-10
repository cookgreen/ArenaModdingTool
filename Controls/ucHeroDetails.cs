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
        private AMProject project;
        private MBBannerlordHero hero;
        private int selectedIndex;
        private AddEditState addEditState;

        public event Action<MBBannerlordHero, AddEditState, int> SaveHeroInfoFinished;

        public ucHeroDetails(AMProject project, MBBannerlordHero hero, int index, AddEditState addEditState)
        {
            InitializeComponent();

            this.project = project;
            this.hero = hero;
            selectedIndex = index;
            this.addEditState = addEditState;

            loadHeroDetails();
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
    }
}
