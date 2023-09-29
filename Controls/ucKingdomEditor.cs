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
    public partial class ucKingdomEditor : UserControl
    {
        private MBBannerlordKingdoms kingdoms;
        private ucKingdomsList factionListCtrl;
        private ucKingdomDetails factionDetailsCtrl;
        private ModdingProject project;

        public ucKingdomEditor(ModdingProject project, MBBannerlordKingdoms kingdoms)
        {
            InitializeComponent();
            this.kingdoms = kingdoms;

            factionListCtrl = new ucKingdomsList(kingdoms);
            factionListCtrl.SelectKingdomChanged += FactionList_SelectKingdomChanged;
            panel1.Controls.Clear();
            panel1.Controls.Add(factionListCtrl);
            factionListCtrl.Dock = DockStyle.Fill;
            this.project = project;
        }

        private void FactionList_SelectKingdomChanged(MBBannerlordKingdom kingdom, int index)
        {
            factionDetailsCtrl = new ucKingdomDetails(project, kingdom, factionListCtrl.State, index);
            panel3.Controls.Clear();
            panel3.Controls.Add(factionDetailsCtrl);
            factionDetailsCtrl.Dock = DockStyle.Fill;

            factionDetailsCtrl.SaveKingdomInfoFinished += FactionDetailsCtrl_SaveKingdomInfoFinished;
        }

        private void FactionDetailsCtrl_SaveKingdomInfoFinished(MBBannerlordKingdom savedKingdom, AddEditState state, int index)
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
