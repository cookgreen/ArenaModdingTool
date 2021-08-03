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
        }
    }
}
