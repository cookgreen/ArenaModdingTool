using ArenaModdingTool.ModdingFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool.Controls
{
    public partial class ucItemsList : UserControl
    {
        private MBItems items;

        public ucItemsList(MBItems items)
        {
            InitializeComponent();
            this.items = items;
            loadItems();
        }

        private void loadItems()
        {
            treeView1.Nodes.Clear();
            foreach (var item in items.Items)
            {
                treeView1.Nodes.Add(item.name);
            }
        }
    }
}
