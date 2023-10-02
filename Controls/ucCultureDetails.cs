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
using ArenaModdingTool.Forms;

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
            initializeTooltip();

            this.project = project;
            this.culture = culture;
            this.index = index;
            this.addEditState = addEditState;

            loadCultureDetails();
        }

		private void initializeTooltip()
		{
            foreach (TabPage tabPage in tabCtrlCultureDetails.TabPages)
            {
                foreach (Control control in tabPage.Controls[0].Controls)
                {
                    if (control is TextBox || control is CheckBox)
                    {
                        string fieldName = Helper.RenameSnakeCase(control.Name.Substring(2));
                        toolTip.SetToolTip(control, Helper.LOC("str_tooltip_message_culture_details_" + fieldName));
                    }
                }
            }
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
            frmValueInputer maleNameEditorWin = new frmValueInputer("Male Name");
            if(maleNameEditorWin.ShowDialog() == DialogResult.OK)
            {
                maleNamesList.Items.Add(maleNameEditorWin.Value);
            }
        }

        private void btnDeleteMaleName_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Helper.LOC("str_info_message_do_you_want_to_delete_this"), 
                Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                maleNamesList.Items.Remove(maleNamesList.SelectedItem);
            }
        }

        private void btnModifyMaleName_Click(object sender, EventArgs e)
		{
			frmValueInputer maleNameEditorWin = new frmValueInputer("Male Name", maleNamesList.SelectedItem.ToString());
			if (maleNameEditorWin.ShowDialog() == DialogResult.OK)
			{
				maleNamesList.Items.Add(maleNameEditorWin.Value);
			}
		}

        private void btnAddFemaleName_Click(object sender, EventArgs e)
		{
			frmValueInputer femaleNameEditorWin = new frmValueInputer("Female Name");
			if (femaleNameEditorWin.ShowDialog() == DialogResult.OK)
			{
				femaleNamesList.Items.Add(femaleNameEditorWin.Value);
			}
		}

        private void btnDeleteFemaleName_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(
				Helper.LOC("str_info_message_do_you_want_to_delete_this"),
				Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				== DialogResult.Yes)
			{
				femaleNamesList.Items.Remove(femaleNamesList.SelectedItem);
			}
		}

        private void btnModifyFemaleName_Click(object sender, EventArgs e)
		{
			frmValueInputer femaleNameEditorWin = new frmValueInputer("Female Name", femaleNamesList.SelectedItem.ToString());
			if (femaleNameEditorWin.ShowDialog() == DialogResult.OK)
			{
				femaleNamesList.Items.Add(femaleNameEditorWin.Value);
			}
		}

        private void btnAddClanName_Click(object sender, EventArgs e)
		{
			frmValueInputer clanNameEditorWin = new frmValueInputer("Clan Name");
			if (clanNameEditorWin.ShowDialog() == DialogResult.OK)
			{
				clanNamesList.Items.Add(clanNameEditorWin.Value);
			}
		}

        private void btnDeleteClanName_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(
				Helper.LOC("str_info_message_do_you_want_to_delete_this"),
				Helper.LOC("str_notice"), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
				== DialogResult.Yes)
			{
				clanNamesList.Items.Remove(clanNamesList.SelectedItem);
			}
		}

        private void btnModifyClanName_Click(object sender, EventArgs e)
		{
			frmValueInputer clanNameEditorWin = new frmValueInputer("Clan Name", clanNamesList.SelectedItem.ToString());
			if (clanNameEditorWin.ShowDialog() == DialogResult.OK)
			{
				clanNamesList.Items.Add(clanNameEditorWin.Value);
			}
		}

		private void femaleNamesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (femaleNamesList.SelectedIndex > 0)
			{
				btnDeleteFemaleName.Enabled = true;
				btnModifyFemaleName.Enabled = true;
			}
			else
			{
				btnDeleteFemaleName.Enabled = false;
				btnModifyFemaleName.Enabled = false;
			}
		}

		private void clanNamesList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (clanNamesList.SelectedIndex > 0)
			{
				btnDeleteClanName.Enabled = true;
				btnModifyClanName.Enabled = true;
			}
			else
			{
				btnDeleteClanName.Enabled = false;
				btnModifyClanName.Enabled = false;
			}
		}

		#endregion

		private void btnSave_Click(object sender, EventArgs e)
        {

        }

		private void maleNamesList_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (maleNamesList.SelectedIndex > 0)
            {
                btnDeleteMaleName.Enabled = true;
                btnModifyMaleName.Enabled = true;
            }
            else
			{
				btnDeleteMaleName.Enabled = false;
				btnModifyMaleName.Enabled = false;
			}
		}
	}
}
