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
    public partial class frmItemComponentChooser : Form
    {
        private ItemComponentType itemComponentType;
        public ItemComponentType ItemComponentType
        {
            get { return itemComponentType; }
        }

        public frmItemComponentChooser()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!rbItemComponentArmour.Checked && !rbItemComponentWeapon.Checked)
            {
                MessageBox.Show("Please select a item componet type!");
                return;
            }

            itemComponentType = 
                rbItemComponentArmour.Checked ? ItemComponentType.Armour :
                rbItemComponentWeapon.Checked ? ItemComponentType.Weapon : 
                ItemComponentType.Invalid;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
