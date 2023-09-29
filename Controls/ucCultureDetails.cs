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
    public partial class ucCultureDetails : UserControl
    {
        private ModdingProject project;
        private MBBannerlordCulture culture;
        private int index;
        private AddEditState addEditState;

        public ucCultureDetails(ModdingProject project, MBBannerlordCulture culture, int index, AddEditState addEditState)
        {
            InitializeComponent();

            this.project = project;
            this.culture = culture;
            this.index = index;
            this.addEditState = addEditState;

            loadCultureDetails();
        }

        private void loadCultureDetails()
        {
            loadDataFromCulture(culture, tableLayoutPanel1);
            loadDataFromCulture(culture, tableLayoutPanel4);
            loadDataFromCulture(culture, tableLayoutPanel5);
            loadDataFromCulture(culture, tableLayoutPanel6);
        }

        private void loadDataFromCulture(MBBannerlordCulture culture, TableLayoutPanel tableLayoutPanel)
        {
            var propertiesInfos = culture.GetType().GetProperties();
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                var control = tableLayoutPanel.GetControlFromPosition(0, i);

                if (control == null)
                    continue;

                var controlName = tableLayoutPanel.GetControlFromPosition(0, i).Text;
                var searchResult = propertiesInfos.Where(o => o.Name == controlName.ToLower());
                if (searchResult.Count() == 1)
                {
                    var textBoxControl = tableLayoutPanel.GetControlFromPosition(1, i);
                    var objectVal = searchResult.First().GetValue(culture);
                    if (objectVal != null)
                    {
                        textBoxControl.Text = objectVal.ToString();
                    }
                }
            }
        }

        #region Name Builders

        private void btnAddMaleName_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteMaleName_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyMaleName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFemaleName_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFemaleName_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyFemaleName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClanName_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteClanName_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyClanName_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
