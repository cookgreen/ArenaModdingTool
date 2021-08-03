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
        private ucItemsListEdit itemsListEdit;
        private ucItemsDetails itemDetailsCtrl;

        public ucItemsEditor(AMProject currentProject, MBItems items)
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

        private void ItemsListEdit_SelectedItemChanged()
        {
            panel2.Controls.Clear();
            itemDetailsCtrl = new ucItemsDetails(itemsListEdit.SelectedItem, itemsListEdit.AddEditState);
            itemDetailsCtrl.Dock = DockStyle.Fill;
            itemDetailsCtrl.DoSave += ItemDetailsCtrl_DoSave;
            panel2.Controls.Add(itemDetailsCtrl);
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
            itemsListEdit.ChangeState(AddEditState.View);
        }
    }
}
