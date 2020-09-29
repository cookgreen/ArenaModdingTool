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
    public partial class ucKingdomList : UserControl
    {
        private MBKingdoms kingdoms;
        public event Action<MBKingdom, int> SelectKingdomChanged;

        public ucKingdomList(MBKingdoms kingdoms)
        {
            InitializeComponent();
            loadKingdoms(kingdoms);
        }

        private void loadKingdoms(MBKingdoms kingdoms)
        {
            this.kingdoms = kingdoms;

            treeView1.Nodes.Clear();
            foreach (var kingdom in kingdoms.Kingdoms)
            {
                treeView1.Nodes.Add(kingdom.name);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                int index = treeView1.Nodes.IndexOf(e.Node);
                SelectKingdomChanged?.Invoke(kingdoms.Kingdoms[index], index);
            }
        }
    }
}
