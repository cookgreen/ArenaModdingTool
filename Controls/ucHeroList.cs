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
    public partial class ucHeroList : UserControl
    {
        private MBBannerlordHero selectedHero;
        private MBBannerlordHeroes heroes;

        public MBBannerlordHero SelectedHero { get { return selectedHero; }  }

        public event Action<MBBannerlordHero, int> SelectHeroChanged;

        public ucHeroList(MBBannerlordHeroes heroes)
        {
            InitializeComponent();
            this.heroes = heroes;
            loadHeroes();
        }

        public void loadHeroes()
        {
            heroList.Nodes.Clear();
            foreach (var hero in heroes.Heroes)
            {
                heroList.Nodes.Add(hero.id);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                int index = heroList.Nodes.IndexOf(e.Node);
                selectedHero = heroes.Heroes[index];
                SelectHeroChanged?.Invoke(heroes.Heroes[index], index);
            }
        }

        public void DeleteSelected()
        {

        }
    }
}
