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
    public partial class ucItemsEditor : UserControl
    {
        private AMProject currentProject;
        private MBItems items;
        private ucItemListEdit itemsListEdit;

        public ucItemsEditor(AMProject currentProject, MBItems items)
        {
            InitializeComponent();
            this.currentProject = currentProject;
            this.items = items;
            panel1.Controls.Clear();
            itemsListEdit = new ucItemListEdit(items);
            itemsListEdit.Dock = DockStyle.Fill;
            panel1.Controls.Add(itemsListEdit);
            itemsListEdit.SelectedItemChanged += ItemsListEdit_SelectedItemChanged;
        }

        private void ItemsListEdit_SelectedItemChanged()
        {
            ucItemsDetails itemDetailsCtrl = new ucItemsDetails(itemsListEdit.SelectedItem);
            panel2.Controls.Clear();
            panel2.Controls.Add(itemDetailsCtrl);
            itemDetailsCtrl.Dock = DockStyle.Fill;
        }
    }
}
