using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool
{
    public partial class frmNewProject : Form
    {
        private AMProject newProject;
        public AMProject NewProject { get; set; }
        public frmNewProject()
        {
            InitializeComponent();
        }
    }
}
