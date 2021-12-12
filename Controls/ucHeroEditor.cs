using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ArenaModdingTool.ModdingFiles;
using XmlLoader;

namespace ArenaModdingTool.Controls
{
    public partial class ucHeroEditor : UserControl
    {
        private AMProject currentProject;
        private MBBannerlordHeroes heroes;
        private ucHeroListEdit heroListEdit;
        private ucHeroDetails heroDetailsCtl;

        public ucHeroEditor(AMProject currentProject, MBBannerlordHeroes heroes)
        {
            InitializeComponent();
            
            this.currentProject = currentProject;
            this.heroes = heroes;

            panel1.Controls.Clear();
            heroListEdit = new ucHeroListEdit(heroes);
            heroListEdit.Dock = DockStyle.Fill;
            heroListEdit.SelectedHeroChanged += HeroListEdit_SelectedHeroChanged;
            panel1.Controls.Add(heroListEdit);
        }

        private void HeroListEdit_SelectedHeroChanged(MBBannerlordHero hero, int index, AddEditState addEditState)
        {
            heroDetailsCtl = new ucHeroDetails(currentProject, hero, index, addEditState);
            panel2.Controls.Clear();
            panel2.Controls.Add(heroDetailsCtl);
            heroDetailsCtl.SaveHeroInfoFinished += HeroDetailsCtl_SaveHeroInfoFinished;
            heroDetailsCtl.Dock = DockStyle.Fill;
        }

        private void HeroDetailsCtl_SaveHeroInfoFinished(MBBannerlordHero savedHero, AddEditState addEditState, int index)
        {
            if (addEditState == AddEditState.Add)
            {
                heroes.Heroes.Add(savedHero);
                XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(heroes.FilePath);
                xmlObjectLoader.Save(heroes);
                heroListEdit.ChangeAddEditState(AddEditState.View);
                heroListEdit.RefreshData();
            }
            else if (addEditState == AddEditState.Edit)
            {
                heroes.Heroes[index] = savedHero;
                XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(heroes.FilePath);
                xmlObjectLoader.Save(heroes);
                heroListEdit.ChangeAddEditState(AddEditState.View);
                heroListEdit.RefreshData();
            }
        }
    }
}
