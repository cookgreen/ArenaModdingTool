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
        private AMProject project;
        private MBBannerlordCulture culture;
        private int index;
        private AddEditState addEditState;

        public ucCultureDetails(AMProject project, MBBannerlordCulture culture, int index, AddEditState addEditState)
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
            var propertiesInfos = culture.GetType().GetProperties();
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                var controlName = tableLayoutPanel1.GetControlFromPosition(0, i).Text;
                var searchResult = propertiesInfos.Where(o => o.Name == controlName);
                if (searchResult.Count() == 1)
                {
                    tableLayoutPanel1.GetControlFromPosition(1, i).Text = searchResult.First().GetValue(culture).ToString();
                }
            }
            for (int i = 0; i < tableLayoutPanel4.RowCount; i++)
            {
                var controlName = tableLayoutPanel1.GetControlFromPosition(0, i).Text;
                var searchResult = propertiesInfos.Where(o => o.Name == controlName);
                if (searchResult.Count() == 1)
                {
                    tableLayoutPanel1.GetControlFromPosition(1, i).Text = searchResult.First().GetValue(culture).ToString();
                }
            }
            for (int i = 0; i < tableLayoutPanel5.RowCount; i++)
            {
                var controlName = tableLayoutPanel1.GetControlFromPosition(0, i).Text;
                var searchResult = propertiesInfos.Where(o => o.Name == controlName);
                if (searchResult.Count() == 1)
                {
                    tableLayoutPanel1.GetControlFromPosition(1, i).Text = searchResult.First().GetValue(culture).ToString();
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
