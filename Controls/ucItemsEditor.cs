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
    public partial class ucItemsEditor : UserControl
    {
        private ModdingProject currentProject;
        private MBBannerlordItems items;
        private ucItemsListEdit itemsListEdit;
        private ucItemsDetails itemDetailsCtrl;
        private int editIndex;

        public ucItemsEditor(ModdingProject currentProject, MBBannerlordItems items)
        {
            InitializeComponent();

            this.currentProject = currentProject;
            this.items = items;

            panel1.Controls.Clear();
            itemsListEdit = new ucItemsListEdit(items);
            itemsListEdit.Dock = DockStyle.Fill;
            itemsListEdit.SelectedItemChanged += ItemsListEdit_SelectedItemChanged;
            itemsListEdit.AddEditStateChanged += ItemsListEdit_AddEditStateChanged;
            panel1.Controls.Add(itemsListEdit);
        }

        private void ItemsListEdit_SelectedItemChanged(int index)
        {
            panel2.Controls.Clear();
            itemDetailsCtrl = new ucItemsDetails(itemsListEdit.SelectedItem, itemsListEdit.AddEditState);
            itemDetailsCtrl.Dock = DockStyle.Fill;
            itemDetailsCtrl.DoSave += ItemDetailsCtrl_DoSave;
            panel2.Controls.Add(itemDetailsCtrl);
            editIndex = index;
        }

        private void ItemsListEdit_AddEditStateChanged()
        {
            switch(itemsListEdit.AddEditState)
            {
                case AddEditState.Add:

                    panel2.Controls.Clear();
                    itemDetailsCtrl = new ucItemsDetails(null, itemsListEdit.AddEditState);
                    itemDetailsCtrl.Dock = DockStyle.Fill;
                    itemDetailsCtrl.DoSave += ItemDetailsCtrl_DoSave;
                    panel2.Controls.Add(itemDetailsCtrl);

                    break;

                case AddEditState.Edit:

                    panel2.Controls.Clear();
                    itemDetailsCtrl = new ucItemsDetails(itemsListEdit.SelectedItem, itemsListEdit.AddEditState);
                    itemDetailsCtrl.Dock = DockStyle.Fill;
                    itemDetailsCtrl.DoSave += ItemDetailsCtrl_DoSave;
                    panel2.Controls.Add(itemDetailsCtrl);

                    break;
            }
        }

        private void ItemDetailsCtrl_DoSave()
        {
            var item = itemDetailsCtrl.Item;
            switch(itemsListEdit.AddEditState)
            {
                case AddEditState.Add:
                    items.Items.Add(item);
                    break;
                case AddEditState.Edit:
                    items.Items[editIndex] = item;
                    break;
            }
            XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(items.FilePath);
            xmlObjectLoader.Save(items);

            itemsListEdit.ChangeState(AddEditState.View);
        }
    }
}
