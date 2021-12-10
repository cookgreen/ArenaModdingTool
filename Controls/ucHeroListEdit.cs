using ArenaModdingTool.ModdingFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArenaModdingTool.Controls
{
    public partial class ucHeroListEdit : UserControl
    {
        private ucHeroList ucHeroList;
        private AddEditState state;
        private MBBannerlordHero selectedHero;
        private int selectedIndex;

        public event Action<MBBannerlordHero, int, AddEditState> SelectedHeroChanged;

        public ucHeroListEdit(MBBannerlordHeroes heroes)
        {
            InitializeComponent();
            ucHeroList = new ucHeroList(heroes);
            ucHeroList.SelectHeroChanged += UcHeroList_SelectHeroChanged;
            panel2.Controls.Clear();
            panel2.Controls.Add(ucHeroList);
            ucHeroList.Dock = DockStyle.Fill;
            state = AddEditState.View;

            RefreshData();
        }

        private void UcHeroList_SelectHeroChanged(MBBannerlordHero selectedHero, int selectedIndex)
        {
            this.selectedHero = selectedHero;
            this.selectedIndex = selectedIndex;
            SelectedHeroChanged?.Invoke(selectedHero, selectedIndex, state);
            if (selectedHero != null)
            {
                btnDelete.Enabled = true;
                btnModify.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            state = AddEditState.Add;

            ucHeroList.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;

            MBBannerlordHero hero = new MBBannerlordHero();
            SelectedHeroChanged?.Invoke(hero, -1, state);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ucHeroList.DeleteSelected();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            state = AddEditState.Edit;

            ucHeroList.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;

            SelectedHeroChanged?.Invoke(selectedHero, selectedIndex, state);
        }

        public void ChangeAddEditState(AddEditState newState)
        {
            if ((state == AddEditState.Add || state == AddEditState.Edit) &&
                 newState == AddEditState.View)
            {
                ucHeroList.Enabled = true;
                btnAdd.Enabled = true;
                if (ucHeroList.SelectedHero != null)
                {
                    btnDelete.Enabled = true;
                    btnModify.Enabled = true;
                }

                state = newState;
            }
        }

        public void RefreshData()
        {
            ucHeroList.loadHeroes();
        }
    }
}
