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
    public partial class frmItemComponentArmourEditor : Form
    {
        private MBItemArmour itemArmour;
        public MBItemArmour ItemArmour
        {
            get { return itemArmour; }
        }

        public frmItemComponentArmourEditor(MBItemArmour itemArmour)
        {
            InitializeComponent();
            this.itemArmour = itemArmour;
        }
    }
}
