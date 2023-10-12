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

            switch(addEditState)
            {
                case AddEditState.Add:
                    btnEditItemComponent.Text = Helper.LOC("str_item_details_add_item_component");
                    item = new MBBannerlordItem();
                    enableEditor();
                    break;
                case AddEditState.Edit:
					btnEditItemComponent.Text = Helper.LOC("str_item_details_edit_item_component");
                    loadItemDetails();
					enableEditor();
					break;
                case AddEditState.View:
                    btnEditItemComponent.Enabled = false;
					disableEditor();
					break;
            }
        }

		private void enableEditor()
		{
            btnEditItemComponent.Enabled = true;
            btnSave.Enabled = true;

            txtAmmoOffset.Enabled = true;
            txtBodyName.Enabled = true;
            txtHolsterPositionShift.Enabled = true;
            txtId.Enabled = true;
            txtItemHolsters.Enabled = true;
            txtMesh.Enabled = true;
            txtName.Enabled = true;
            txtType.Enabled = true;

            chkIsMerchandise.Enabled = true;
            chkMultiplayerItem.Enabled = true;
		}

		private void disableEditor()
		{
			btnEditItemComponent.Enabled = false;
			btnSave.Enabled = false;

			txtAmmoOffset.Enabled = false;
			txtBodyName.Enabled = false;
			txtHolsterPositionShift.Enabled = false;
			txtId.Enabled = false;
			txtItemHolsters.Enabled = false;
			txtMesh.Enabled = false;
			txtName.Enabled = false;
			txtType.Enabled = false;

			chkIsMerchandise.Enabled = false;
			chkMultiplayerItem.Enabled = false;
		}

		private void loadItemDetails()
		{
			if (item != null)
			{
				decimal val;
				bool bll;
				txtId.Text = item.id;
				txtName.Text = item.name;
				txtBodyName.Text = item.body_name;
				txtMesh.Text = item.mesh;
				cmbCulture.SelectedItem = item.culture;
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
            toolTip.SetToolTip(txtId, Helper.LOC("str_tooltip_message_item_details_ammo_offset"));
            toolTip.SetToolTip(chkMultiplayerItem, Helper.LOC("str_tooltip_message_item_details_is_multiplayer_item"));
            toolTip.SetToolTip(txtName, Helper.LOC("str_tooltip_message_item_details_name"));
            toolTip.SetToolTip(txtMesh, Helper.LOC("str_tooltip_message_item_details_mesh"));
            toolTip.SetToolTip(cmbCulture, Helper.LOC("str_tooltip_message_item_details_culture"));
            toolTip.SetToolTip(numValue, Helper.LOC("str_tooltip_message_item_details_value"));
            toolTip.SetToolTip(chkIsMerchandise, Helper.LOC("str_tooltip_message_item_details_is_merchandise"));
            toolTip.SetToolTip(numWeight, Helper.LOC("str_tooltip_message_item_details_weight"));
            toolTip.SetToolTip(numDifficulty, Helper.LOC("str_tooltip_message_item_details_difficulty"));
            toolTip.SetToolTip(txtType, Helper.LOC("str_tooltip_message_item_details_type"));
            toolTip.SetToolTip(txtAmmoOffset, Helper.LOC("str_tooltip_message_item_details_ammo_offset"));
            toolTip.SetToolTip(txtItemHolsters, Helper.LOC("str_tooltip_message_item_details_item_holsters"));
            toolTip.SetToolTip(txtHolsterPositionShift, Helper.LOC("str_tooltip_message_item_details_holster_position_shift"));
            toolTip.SetToolTip(btnEditItemComponent, Helper.LOC("str_tooltip_message_item_details_component"));
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
            item.id = txtId.Text;
            item.name = txtName.Text;
            item.body_name = txtBodyName.Text;
            item.mesh = txtMesh.Text;
            item.culture = cmbCulture.SelectedItem.ToString();
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

		private void txtName_Enter(object sender, EventArgs e)
		{
            frmLocalizedTextEditor localizedTextEditorWin = new frmLocalizedTextEditor(txtName.Text);
            if(localizedTextEditorWin.ShowDialog() == DialogResult.OK)
            {
                txtName.Text = localizedTextEditorWin.ResultText;
            }
		}
	}
}
