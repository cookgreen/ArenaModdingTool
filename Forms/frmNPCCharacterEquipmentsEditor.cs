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
    public partial class frmNPCCharacterEquipmentsEditor : Form
    {
        private bool isAddOrEdit;
        private List<MBNPCCharacterEquipment> equipments;

        public List<MBNPCCharacterEquipment> Equipments { get { return equipments; } }

        public bool IsCivilian { get { return chkIsCivilian.Checked; } }

        public frmNPCCharacterEquipmentsEditor(bool isAddOrEdit = true, List<MBNPCCharacterEquipment> equipments = null, bool isCivilian  = false)
        {
            InitializeComponent();
            this.isAddOrEdit = isAddOrEdit;
            this.equipments = equipments;
            chkIsCivilian.Checked = isCivilian;
            if (!isAddOrEdit && equipments != null)
            {
                loadEquipments();
            }
        }

        private void loadEquipments()
        {
            listView1.Items.Clear();
            foreach (var equipment in equipments)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = equipment.slot;
                lvi.SubItems.Add(equipment.id);
                listView1.Items.Add(lvi);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNPCCharacterEquipmentEditor characterEquipmentEditor = new frmNPCCharacterEquipmentEditor();
            if (characterEquipmentEditor.ShowDialog() == DialogResult.OK)
            {
                var equipment = characterEquipmentEditor.Equipment;
                equipments.Add(equipment);
                loadEquipments();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = listView1.SelectedIndices[0];
            listView1.Items.RemoveAt(index);
            equipments.RemoveAt(index);
            loadEquipments();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var index = listView1.SelectedIndices[0];
            listView1.Items.RemoveAt(index);
            equipments.RemoveAt(index);

            frmNPCCharacterEquipmentEditor characterEquipmentEditor = new frmNPCCharacterEquipmentEditor();
            if (characterEquipmentEditor.ShowDialog() == DialogResult.OK)
            {
                var equipment = characterEquipmentEditor.Equipment;
                equipments.Insert(index, equipment);
                loadEquipments();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                btnDelete.Enabled = true;
                btnModify.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnModify.Enabled = false;
            }
        }
    }
}
