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
using XmlLoader;

namespace ArenaModdingTool.Controls
{
    public partial class ucItemsList : UserControl
    {
        private MBBannerlordItems items;
        private int index;
        private MBBannerlordItem selectedItem;

        public event Action<MBBannerlordItem, int> SelectedItemChanged;

        public ucItemsList(MBBannerlordItems items)
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
                var node = treeView1.Nodes.Add(item.name);
                node.Tag = item;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                MBBannerlordItem item = e.Node.Tag as MBBannerlordItem;
                selectedItem = item;
                index = treeView1.Nodes.IndexOf(e.Node);
                SelectedItemChanged?.Invoke(item, index);
            }
        }

        public void DeleteSelectedItem()
        {
            treeView1.Nodes.RemoveAt(index);
            items.Items.RemoveAt(index);

            XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(items.FilePath);
            xmlObjectLoader.Save(items);
        }
    }
}
