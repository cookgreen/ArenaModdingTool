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
    public partial class frmItemComponentWeaponEditor : Form
    {
        private MBItemWeapon itemWeapon;
        public MBItemWeapon ItemWeapon
        {
            get { return itemWeapon; }
        }

        public frmItemComponentWeaponEditor(MBItemWeapon itemWeapon)
        {
            InitializeComponent();
            this.itemWeapon = itemWeapon;
            if (itemWeapon != null)
            {
                txtItemUsage.Text = itemWeapon.item_usage;
                txtMissileSpeed.Text = itemWeapon.missile_speed;
                txtPhysicsMaterial.Text = itemWeapon.physics_material;
                txtSpeedRating.Text = itemWeapon.speed_rating;
                txtSwingDamage.Text = itemWeapon.swing_damage;
                txtSwingDamageType.Text = itemWeapon.swing_damage_type;
                txtThrustSpeed.Text = itemWeapon.thrust_speed;
                txtWeaponBalance.Text = itemWeapon.weapon_balance;
                txtWeaponClass.Text = itemWeapon.weapon_class;
                txtWeaponLength.Text = itemWeapon.weapon_length;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            itemWeapon = new MBItemWeapon();
            itemWeapon.item_usage = txtItemUsage.Text;
            itemWeapon.missile_speed = txtMissileSpeed.Text;
            itemWeapon.physics_material = txtPhysicsMaterial.Text;
            itemWeapon.speed_rating = txtSpeedRating.Text;
            itemWeapon.swing_damage = txtSwingDamage.Text;
            itemWeapon.swing_damage_type = txtSwingDamageType.Text;
            itemWeapon.thrust_speed = txtThrustSpeed.Text;
            itemWeapon.weapon_balance = txtWeaponBalance.Text;
            itemWeapon.weapon_class = txtWeaponClass.Text;
            itemWeapon.weapon_length = txtWeaponLength.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
