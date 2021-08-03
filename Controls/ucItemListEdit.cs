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
    public partial class ucItemListEdit : UserControl
    {
        private MBItem selectedItem;
        private ucItemsList itemsListCtrl;
        public event Action SelectedItemChanged;
        public MBItem SelectedItem
        {
            get { return selectedItem; }
        }

        public ucItemListEdit(MBItems items)
        {
            InitializeComponent();
            panel2.Controls.Clear();
            itemsListCtrl = new ucItemsList(items);
            itemsListCtrl.SelectedItemChanged += ItemsListCtrl_SelectedItemChanged;
            itemsListCtrl.Dock = DockStyle.Fill;
            panel2.Controls.Add(itemsListCtrl);
        }

        private void ItemsListCtrl_SelectedItemChanged(MBItem item, int index)
        {
            selectedItem = item;

            SelectedItemChanged?.Invoke();
        }
    }
}
