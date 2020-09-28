using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool.Controls
{
    public partial class ucDataList : UserControl
    {
        protected object selecteddata;
        public Object SelectedData { get { return selecteddata; } }
        public ucDataList()
        {
            InitializeComponent();
        }
    }
}
