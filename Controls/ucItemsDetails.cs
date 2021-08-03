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
        public ucItemsDetails(MBItem item)
        {
            InitializeComponent();
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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
