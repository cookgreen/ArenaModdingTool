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
            cultureList.Nodes.Clear();
            foreach (var culture in cultures.Cultures)
            {
                cultureList.Nodes.Add(culture.name);
            }
        }

        private void cultureList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                int index = cultureList.Nodes.IndexOf(e.Node);
				selectedCulture = cultures.Cultures[index];
				SelectCultureChanged?.Invoke(cultures.Cultures[index], index);
            }
		}

		public void DeleteSelected()
		{

		}
	}
}
