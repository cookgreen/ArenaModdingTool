using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArenaModdingTool.ModdingFiles;

namespace ArenaModdingTool.Controls
{
    public partial class ucCultureList : UserControl
	{
        private MBBannerlordCulture selectedCulture;
		private MBBannerlordCultures cultures;

		public MBBannerlordCulture SelectedCulture { get { return selectedCulture; } }
		public event Action<MBBannerlordCulture, int> SelectCultureChanged;

        public ucCultureList(MBBannerlordCultures cultures)
        {
            InitializeComponent();
            this.cultures = cultures;
            loadCultures();
        }

        public void loadCultures()
        {
            treeView1.Nodes.Clear();
            foreach (var culture in cultures.Cultures)
            {
                treeView1.Nodes.Add(culture.name);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                int index = treeView1.Nodes.IndexOf(e.Node);
				selectedCulture = cultures.Cultures[index];
				SelectCultureChanged?.Invoke(cultures.Cultures[index], index);
            }
		}

		public void DeleteSelected()
		{

		}
	}
}
