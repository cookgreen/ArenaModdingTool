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

namespace ArenaModdingTool.Controls
{
    public partial class ucFactionEditor : UserControl
    {
        private ucFactionList factionListCtrl;
        private ucFactionDetails factionDetailsCtrl;
        public ucFactionEditor(AMProject project)
        {
            InitializeComponent();

            factionListCtrl = new ucFactionList(project.BannerlordModule.Kingdoms);
            factionListCtrl.SelectKingdomChanged += FactionList_SelectKingdomChanged;
            panel1.Controls.Clear();
            panel1.Controls.Add(factionListCtrl);
            factionListCtrl.Dock = DockStyle.Fill;
        }

        private void FactionList_SelectKingdomChanged(MBKingdom kingdom)
        {
            factionDetailsCtrl = new ucFactionDetails(kingdom);
            panel2.Controls.Clear();
            panel2.Controls.Add(factionDetailsCtrl);
            factionDetailsCtrl.Dock = DockStyle.Fill;
        }
    }
}
