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
    public partial class ucItemsEditor : UserControl
    {
        private AMProject currentProject;
        private MBItems items;

        public ucItemsEditor(AMProject currentProject, MBItems items)
        {
            InitializeComponent();
            this.currentProject = currentProject;
            this.items = items;
        }
    }
}
