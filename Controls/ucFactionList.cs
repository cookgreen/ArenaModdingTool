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
    public partial class ucFactionList : UserControl
    {
        public event Action<MBSPKingdom> SelectKingdomChanged;
        private MBSPKingdoms kingdoms;

        public ucFactionList()
        {
            InitializeComponent();
        }

        public ucFactionList(MBSPKingdoms kingdoms)
        {
            this.kingdoms = kingdoms;
            InitializeComponent();
            loadKingdoms();
        }

        private void loadKingdoms()
        {
            factionList.Nodes.Clear();
            foreach(var kingdom in kingdoms.Kingdoms)
            {
                factionList.Nodes.Add(kingdom.name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void factionList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                int index = factionList.Nodes.IndexOf(e.Node);
                btnDelete.Enabled = true;
                btnModify.Enabled = true;
                SelectKingdomChanged?.Invoke(kingdoms.Kingdoms[index]);
            }
        }
    }
}
