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
                cmbEquipmentSlots.SelectedItem = equipment.slot;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbEquipmentSlots.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid slot!");
                return;
            }

            if (string.IsNullOrEmpty(txtItemId.Text))
            {
                MessageBox.Show("Please input a valid item!");
                return;
            }

            equipment = new MBNPCCharacterEquipment();
            equipment.slot = cmbEquipmentSlots.SelectedItem.ToString();
            equipment.id = txtItemId.Text;

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
