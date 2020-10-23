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
        private MBHero selectedHero;
        private MBHeroes heroes;

        public MBHero SelectedHero { get { return selectedHero; }  }

        public event Action<MBHero, int> SelectHeroChanged;

        public ucHeroList(MBHeroes heroes)
        {
            InitializeComponent();
            this.heroes = heroes;
            loadHeroes();
        }

        private void loadHeroes()
        {
            treeView1.Nodes.Clear();
            foreach (var hero in heroes.Heroes)
            {
                treeView1.Nodes.Add(hero.id);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                int index = treeView1.Nodes.IndexOf(e.Node);
                selectedHero = heroes.Heroes[index];
                SelectHeroChanged?.Invoke(heroes.Heroes[index], index);
            }
        }

        public void DeleteSelected()
        {

        }
    }
}
