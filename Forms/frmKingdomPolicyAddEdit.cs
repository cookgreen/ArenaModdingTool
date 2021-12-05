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

namespace ArenaModdingTool.Forms
{
    public partial class frmKingdomPolicyAddEdit : Form
    {
        private AMProject project;
        private MBBannerlordKingdom kingdom;
        private bool isAddOrEdit;
        private KingdomPolicy kingdomPolicy;

        public KingdomPolicy KingdomPolicy
        {
            get { return kingdomPolicy; }
        }

        public frmKingdomPolicyAddEdit(AMProject project, MBBannerlordKingdom kingdom, bool isAddOrEdit, KingdomPolicy kingdomPolicy = null)
        {
            InitializeComponent();

            this.project = project;
            this.kingdom = kingdom;
            this.isAddOrEdit = isAddOrEdit;

            if (!isAddOrEdit)
            {
                this.kingdomPolicy = kingdomPolicy;
                if (kingdomPolicy != null)
                {
                    txtKingdomPolicyID.Text = kingdomPolicy.id;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKingdomPolicyID.Text))
            {
                kingdomPolicy = new KingdomPolicy();
                kingdomPolicy.id = txtKingdomPolicyID.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
