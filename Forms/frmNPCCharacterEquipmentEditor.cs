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
    public partial class frmNPCCharacterEquipmentEditor : Form
    {
        private MBNPCCharacterEquipment equipment;
        private bool isAddOrEdit;

        public MBNPCCharacterEquipment Equipment { get { return equipment; } }
        public frmNPCCharacterEquipmentEditor(bool isAddOrEdit = false, MBNPCCharacterEquipment equipment = null)
        {
            InitializeComponent();
            this.isAddOrEdit = isAddOrEdit;
            if (!isAddOrEdit && equipment != null)
            {
                txtItemId.Text = equipment.id;
                txtSlot.Text = equipment.slot;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            equipment = new MBNPCCharacterEquipment();
            equipment.slot = txtSlot.Text;
            equipment.id = txtItemId.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
