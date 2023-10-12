using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArenaModdingTool.ModdingFiles;

namespace ArenaModdingTool.Controls
{
    public partial class ucCultureListEdit : UserControl
    {
        private ucCultureList cultureList;
        private AddEditState state;
		private MBBannerlordCulture selectedCulture;
		private int selectedIndex;

		public AddEditState State { get { return state; } }
        public event Action<MBBannerlordCulture, int> SelectCultureChanged;

        public ucCultureListEdit(MBBannerlordCultures cultures)
        {
            InitializeComponent();

            state = AddEditState.View;

            cultureList = new ucCultureList(cultures);
            panelList.Controls.Clear();
            panelList.Controls.Add(cultureList);
            cultureList.Dock = DockStyle.Fill;

            cultureList.SelectCultureChanged += CultureList_SelectCultureChanged;
        }

        private void CultureList_SelectCultureChanged(MBBannerlordCulture selectedCulture, int selectedIndex)
		{
			this.selectedCulture = selectedCulture;
			this.selectedIndex = selectedIndex;
			SelectCultureChanged?.Invoke(selectedCulture, selectedIndex);
			if (selectedCulture != null)
			{
				btnDelete.Enabled = true;
				btnModify.Enabled = true;
			}
		}

        private void btnAdd_Click(object sender, EventArgs e)
		{
			state = AddEditState.Add;

			cultureList.Enabled = false;
			btnAdd.Enabled = false;
			btnDelete.Enabled = false;
			btnModify.Enabled = false;

			MBBannerlordCulture hero = new MBBannerlordCulture();
			SelectCultureChanged?.Invoke(hero, -1);
		}

        private void btnDelete_Click(object sender, EventArgs e)
		{
			cultureList.DeleteSelected();
		}

        private void btnModify_Click(object sender, EventArgs e)
		{
			state = AddEditState.Edit;

			cultureList.Enabled = false;
			btnAdd.Enabled = false;
			btnDelete.Enabled = false;
			btnModify.Enabled = false;

			SelectCultureChanged?.Invoke(selectedCulture, selectedIndex);
		}

		public void ChangeAddEditState(AddEditState newState)
		{
			if ((state == AddEditState.Add || state == AddEditState.Edit) &&
				 newState == AddEditState.View)
			{
				cultureList.Enabled = true;
				btnAdd.Enabled = true;
				if (cultureList.SelectedCulture != null)
				{
					btnDelete.Enabled = true;
					btnModify.Enabled = true;
				}

				state = newState;
			}
		}

		public void RefreshData()
		{
			cultureList.loadCultures();
		}
	}
}
