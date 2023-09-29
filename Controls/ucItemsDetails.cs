using ArenaModdingTool.Forms;
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

namespace ArenaModdingTool.Controls
{
    public partial class ucItemsDetails : UserControl
    {
        private MBBannerlordItem item;
        private AddEditState addEditState;
        
        public event Action DoSave;
        public MBBannerlordItem Item
        {
            get { return item; }
        }

        public ucItemsDetails(MBBannerlordItem item, AddEditState addEditState)
        {
            InitializeComponent();
            initializeTooltip();

            this.item = item;
            this.addEditState = addEditState;

            if (item != null)
            {
                decimal val;
                bool bll;
                txtId.Text = item.id;
                txtName.Text = item.name;
                txtBodyName.Text = item.body_name;
                txtMesh.Text = item.mesh;
                txtCulture.Text = item.culture;
                if (decimal.TryParse(item.value, out val))
                {
                    numValue.Value = val;
                }
                if (bool.TryParse(item.is_merchandise, out bll))
                {
                    chkIsMerchandise.Checked = bll;
                }
                if (decimal.TryParse(item.weight, out val))
                {
                    numWeight.Value = val;
                }
                if (decimal.TryParse(item.difficulty, out val))
                {
                    numDifficulty.Value = val;
                }
                txtType.Text = item.Type;
                txtAmmoOffset.Text = item.AmmoOffset;
                txtItemHolsters.Text = item.item_holsters;
                txtHolsterPositionShift.Text = item.holster_position_shift;
            }
        }

		private void initializeTooltip()
		{
            toolTip.SetToolTip(txtAmmoOffset, Helper.LOC("str_tooltip_message_item_details_ammo_offset"));
            toolTip.SetToolTip(txtBodyName, Helper.LOC("str_"));
		}

		private void txtAmmoOffset_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmVectorEditor vectorEditor = new frmVectorEditor(txtAmmoOffset.Text);
            if (vectorEditor.ShowDialog() == DialogResult.OK)
            {
                txtAmmoOffset.Text = vectorEditor.StrVector;
            }
        }

        private void txtItemHolsters_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmVectorEditor vectorEditor = new frmVectorEditor(txtItemHolsters.Text);
            if (vectorEditor.ShowDialog() == DialogResult.OK)
            {
                txtItemHolsters.Text = vectorEditor.StrVector;
            }
        }

        private void txtHolsterPositionShift_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmVectorEditor vectorEditor = new frmVectorEditor(txtHolsterPositionShift.Text);
            if (vectorEditor.ShowDialog() == DialogResult.OK)
            {
                txtHolsterPositionShift.Text = vectorEditor.StrVector;
            }
        }

        private void btnEditItemComponent_Click(object sender, EventArgs e)
        {
            if (item.ItemComponent == null)
            {
                frmItemComponentChooser itemComponentChooser = new frmItemComponentChooser();
                if (itemComponentChooser.ShowDialog() == DialogResult.OK)
                {
                    var itemComponentType = itemComponentChooser.ItemComponentType;
                    switch(itemComponentType)
                    {
                        case ItemComponentType.Armour:
                            item.ItemComponent = new MBItemComponent();
                            item.ItemComponent.Armour = new MBItemArmour();
                            frmItemComponentArmourEditor itemComponentArmourEditor = new frmItemComponentArmourEditor(item.ItemComponent.Armour);
                            if(itemComponentArmourEditor.ShowDialog() == DialogResult.OK)
                            {
                                item.ItemComponent.Armour = itemComponentArmourEditor.ItemArmour;
                            }
                            break;
                        case ItemComponentType.Weapon:
                            item.ItemComponent = new MBItemComponent();
                            item.ItemComponent.Weapon = new MBItemWeapon();
                            frmItemComponentWeaponEditor itemComponentWeaponEditor = new frmItemComponentWeaponEditor(item.ItemComponent.Weapon);
                            if (itemComponentWeaponEditor.ShowDialog() == DialogResult.OK)
                            {
                                item.ItemComponent.Weapon = itemComponentWeaponEditor.ItemWeapon;
                            }
                            break;
                    }
                }
            }
            else
            {
                if (item.ItemComponent.Weapon != null)
                {
                    frmItemComponentWeaponEditor itemComponentWeaponEditor = new frmItemComponentWeaponEditor(item.ItemComponent.Weapon);
                    if (itemComponentWeaponEditor.ShowDialog() == DialogResult.OK)
                    {
                        item.ItemComponent.Weapon = itemComponentWeaponEditor.ItemWeapon;
                    }
                }
                else if (item.ItemComponent.Armour != null)
                {
                    frmItemComponentArmourEditor itemComponentArmourEditor = new frmItemComponentArmourEditor(item.ItemComponent.Armour);
                    if (itemComponentArmourEditor.ShowDialog() == DialogResult.OK)
                    {
                        item.ItemComponent.Armour = itemComponentArmourEditor.ItemArmour;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch(addEditState)
            {
                case AddEditState.Add:
                    item = new MBBannerlordItem();
                    break;
            }

            item.id = txtId.Text;
            item.name = txtName.Text;
            item.body_name = txtBodyName.Text;
            item.mesh = txtMesh.Text;
            item.culture = txtCulture.Text;
            item.value = numValue.Value.ToString();
            item.is_merchandise = chkIsMerchandise.Checked.ToString();
            item.weight = numWeight.Value.ToString();
            item.difficulty = numDifficulty.Value.ToString();
            item.Type = txtType.Text;
            item.AmmoOffset = txtAmmoOffset.Text;
            item.item_holsters = txtItemHolsters.Text;
            item.holster_position_shift = txtHolsterPositionShift.Text;

            DoSave?.Invoke();
        }
    }
}
