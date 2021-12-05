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
using XmlLoader;

namespace ArenaModdingTool.Controls
{
    public partial class ucKingdomsList : UserControl
    {
        private AddEditState state;
        public event Action<MBBannerlordKingdom, int> SelectKingdomChanged;
        private MBBannerlordKingdoms kingdoms;

        public AddEditState State
        {
            get { return state; }
        }

        public ucKingdomsList()
        {
            InitializeComponent();
            state = AddEditState.View;
        }

        public ucKingdomsList(MBBannerlordKingdoms kingdoms)
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
            state = AddEditState.Add;

            factionList.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;

            MBBannerlordKingdom kingdom = new MBBannerlordKingdom();
            SelectKingdomChanged?.Invoke(kingdom, -1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (factionList.SelectedNode != null)
            {
                int index = factionList.Nodes.IndexOf(factionList.SelectedNode);
                kingdoms.Kingdoms.RemoveAt(index);
                factionList.Nodes.RemoveAt(index);

                XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(kingdoms.FilePath);
                xmlObjectLoader.Save(kingdoms);

                RefreshData();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            state = AddEditState.Edit;

            factionList.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnModify.Enabled = false;

            int index = factionList.Nodes.IndexOf(factionList.SelectedNode);
            SelectKingdomChanged?.Invoke(kingdoms.Kingdoms[index], index);
        }

        public void ChangeAddEditState(AddEditState newState)
        {
            if ((state == AddEditState.Add || state == AddEditState.Edit) && 
                 newState == AddEditState.View)
            {
                factionList.Enabled = true;
                btnAdd.Enabled = true;
                if (factionList.SelectedNode != null)
                {
                    btnDelete.Enabled = true;
                    btnModify.Enabled = true;
                }

                state = newState;
            }
        }

        public void RefreshData()
        {
            loadKingdoms();
        }

        private void factionList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                int index = factionList.Nodes.IndexOf(e.Node);
                btnDelete.Enabled = true;
                btnModify.Enabled = true;
                SelectKingdomChanged?.Invoke(kingdoms.Kingdoms[index], index);
            }
            else
            {
                btnDelete.Enabled = false;
                btnModify.Enabled = false;
            }
        }
    }
}
