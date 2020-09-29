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
    public partial class ucFactionEditor : UserControl
    {
        private AMProject project;
        private MBKingdoms kingdoms;
        private ucFactionList factionListCtrl;
        private ucFactionDetails factionDetailsCtrl;
        public ucFactionEditor(MBKingdoms kingdoms)
        {
            InitializeComponent();
            this.kingdoms = kingdoms;

            factionListCtrl = new ucFactionList(kingdoms);
            factionListCtrl.SelectKingdomChanged += FactionList_SelectKingdomChanged;
            panel1.Controls.Clear();
            panel1.Controls.Add(factionListCtrl);
            factionListCtrl.Dock = DockStyle.Fill;
        }

        private void FactionList_SelectKingdomChanged(MBKingdom kingdom, int index)
        {
            factionDetailsCtrl = new ucFactionDetails(kingdom, factionListCtrl.State, index);
            panel2.Controls.Clear();
            panel2.Controls.Add(factionDetailsCtrl);
            factionDetailsCtrl.Dock = DockStyle.Fill;

            factionDetailsCtrl.SaveKingdomInfoFinished += FactionDetailsCtrl_SaveKingdomInfoFinished;
        }

        private void FactionDetailsCtrl_SaveKingdomInfoFinished(MBKingdom savedKingdom, AddEditState state, int index)
        {
            if (state == AddEditState.Add)
            {
                kingdoms.Kingdoms.Add(savedKingdom);
                XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(kingdoms.FilePath);
                xmlObjectLoader.Save(kingdoms);
                factionListCtrl.ChangeAddEditState(AddEditState.View);
                factionListCtrl.RefreshData();
            }
            else if (state == AddEditState.Edit)
            {
                kingdoms.Kingdoms[index] = savedKingdom;
                XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(kingdoms.FilePath);
                xmlObjectLoader.Save(kingdoms);
                factionListCtrl.ChangeAddEditState(AddEditState.View);
                factionListCtrl.RefreshData();
            }
        }
    }
}
