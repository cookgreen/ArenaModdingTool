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
    public partial class ucItemsListEdit : UserControl
    {
        private MBBannerlordItem selectedItem;
        private ucItemsList itemsListCtrl;
        private AddEditState addEditState;
        private int selectedIndex;

        public event Action AddEditStateChanged;
        public event Action<int> SelectedItemChanged;
        public MBBannerlordItem SelectedItem
        {
            get { return selectedItem; }
        }
        public AddEditState AddEditState
        {
            get { return addEditState; }
        }

        public ucItemsListEdit(MBBannerlordItems items)
        {
            InitializeComponent();
            panel2.Controls.Clear();
            itemsListCtrl = new ucItemsList(items);
            itemsListCtrl.SelectedItemChanged += ItemsListCtrl_SelectedItemChanged;
            itemsListCtrl.Dock = DockStyle.Fill;
            panel2.Controls.Add(itemsListCtrl);
        }

        private void ItemsListCtrl_SelectedItemChanged(MBBannerlordItem item, int index)
        {
            selectedItem = item;
            selectedIndex = index;

            SelectedItemChanged?.Invoke(index);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            itemsListCtrl.Enabled = false;
            addEditState = AddEditState.Add;
            AddEditStateChanged?.Invoke();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            itemsListCtrl.DeleteSelectedItem();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            itemsListCtrl.Enabled = false;
            addEditState = AddEditState.Edit;
            AddEditStateChanged?.Invoke();
        }

        public void ChangeState(AddEditState addEditState)
        {
            if (addEditState == AddEditState.View)
            {
                itemsListCtrl.Enabled = true;
            }
            this.addEditState = addEditState;
        }
    }
}
