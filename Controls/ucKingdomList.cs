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
        private MBBannerlordKingdoms kingdoms;
        public event Action<MBBannerlordKingdom, int> SelectKingdomChanged;

        public ucKingdomList(MBBannerlordKingdoms kingdoms)
        {
            InitializeComponent();
            loadKingdoms(kingdoms);
        }

        private void loadKingdoms(MBBannerlordKingdoms kingdoms)
        {
            this.kingdoms = kingdoms;

            kingdomList.Nodes.Clear();
            foreach (var kingdom in kingdoms.Kingdoms)
            {
                kingdomList.Nodes.Add(kingdom.name);
            }
        }

        private void kingdomList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                int index = kingdomList.Nodes.IndexOf(e.Node);
                SelectKingdomChanged?.Invoke(kingdoms.Kingdoms[index], index);
            }
        }
    }
}
