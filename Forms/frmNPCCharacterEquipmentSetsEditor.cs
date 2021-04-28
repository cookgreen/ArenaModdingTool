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
    public partial class frmNPCCharacterEquipmentSetsEditor : Form
    {
        private List<MBNPCCharacterEquipmentSet> equipmentSets;
        public List<MBNPCCharacterEquipmentSet> EquipmentSets { get { return equipmentSets; } }
        private MBNPCCharacter character;

        public frmNPCCharacterEquipmentSetsEditor(MBNPCCharacter character)
        {
            InitializeComponent();
            this.character = character;
            equipmentSets = character.EquipmentSets;
            RefreshData();
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
            frmNPCCharacterEquipmentsEditor characterEquipmentsEditor = new frmNPCCharacterEquipmentsEditor();
            if (characterEquipmentsEditor.ShowDialog() == DialogResult.OK)
            {
                MBNPCCharacterEquipmentSet equipmentSet = new MBNPCCharacterEquipmentSet();
                equipmentSet.Equipments = characterEquipmentsEditor.Equipments;
                equipmentSets.Add(equipmentSet);
                RefreshData();
            }
        }

        private void RefreshData()
        {
            equipmentSetList.Items.Clear();
            for (int i = 0; i < equipmentSets.Count; i++)
            {
                equipmentSetList.Items.Add("Equipment Set #" + (i + 1).ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            equipmentSets.RemoveAt(equipmentSetList.SelectedIndex);
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedIndex = equipmentSetList.SelectedIndex;
            frmNPCCharacterEquipmentsEditor characterEquipmentsEditor = new frmNPCCharacterEquipmentsEditor(false, equipmentSets[selectedIndex].Equipments, equipmentSets[selectedIndex].IsCivilian);
            if (characterEquipmentsEditor.ShowDialog() == DialogResult.OK)
            {
                equipmentSets.RemoveAt(selectedIndex);
                MBNPCCharacterEquipmentSet equipmentSet = new MBNPCCharacterEquipmentSet();
                equipmentSet.Equipments = characterEquipmentsEditor.Equipments;
                equipmentSet.IsCivilian = characterEquipmentsEditor.IsCivilian;
                equipmentSets.Insert(selectedIndex, equipmentSet);
                RefreshData();
            }
        }

        private void equipmentSetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equipmentSetList.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
