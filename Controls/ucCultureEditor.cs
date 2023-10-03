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
using XmlLoader;

namespace ArenaModdingTool.Controls
{
    public partial class ucCultureEditor : UserControl
    {
        private ModdingProject project;
        private MBBannerlordCultures cultures;
        private ucCultureListEdit cultureListCtrl;
        private ucCultureDetails cultureDetailsCtrl;

        public ucCultureEditor(ModdingProject project, MBBannerlordCultures cultures)
        {
            InitializeComponent();

            this.project = project;
            this.cultures = cultures;

            panel1.Controls.Clear();
            cultureListCtrl = new ucCultureListEdit(cultures);
            cultureListCtrl.Dock = DockStyle.Fill;
            cultureListCtrl.SelectCultureChanged += CultureListCtrl_SelectCultureChanged; ;
            panel1.Controls.Add(cultureListCtrl);
        }

        private void CultureListCtrl_SelectCultureChanged(MBBannerlordCulture selectedCulture, int index)
        {
            cultureDetailsCtrl = new ucCultureDetails(project, selectedCulture, index, cultureListCtrl.State);
            panel3.Controls.Clear();
            panel3.Controls.Add(cultureDetailsCtrl);
            cultureDetailsCtrl.Dock = DockStyle.Fill;

			cultureDetailsCtrl.SaveCultureInfoFinished += CultureDetailsCtrl_SaveCultureInfoFinished;

		}

		private void CultureDetailsCtrl_SaveCultureInfoFinished(MBBannerlordCulture savedCulture, AddEditState addEditState, int index)
		{
			if (addEditState == AddEditState.Add)
			{
				cultures.Cultures.Add(savedCulture);
				XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(cultures.FilePath);
				xmlObjectLoader.Save(cultures);
				cultureListCtrl.ChangeAddEditState(AddEditState.View);
				cultureListCtrl.RefreshData();
			}
			else if (addEditState == AddEditState.Edit)
			{
				cultures.Cultures[index] = savedCulture;
				XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(cultures.FilePath);
				xmlObjectLoader.Save(cultures);
				cultureListCtrl.ChangeAddEditState(AddEditState.View);
				cultureListCtrl.RefreshData();
			}
		}
	}
}
