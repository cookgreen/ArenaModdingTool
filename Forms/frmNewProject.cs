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
    public partial class frmNewProject : Form, ILocalization
    {
        private AMProject newProject;
        public AMProject NewProject { get; set; }
        public frmNewProject()
        {
            InitializeComponent();
            SwitchLanguage();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public void SwitchLanguage()
        {
            Text = Helper.LOC("ui_create_new_project_form_title");
            lbProjectName.Text = Helper.LOC("ui_create_new_project_form_label_project_name");
            lbModuleName.Text = Helper.LOC("ui_create_new_project_form_label_module_name");
            lbLocation.Text = Helper.LOC("ui_create_new_project_form_label_location");
            groupbox_module_info.Text = Helper.LOC("ui_create_new_project_form_groupbox_module_info");
            chkSinglePlayer.Text = Helper.LOC("ui_create_new_project_form_checkbox_singleplayer");
            chkMultiplayer.Text = Helper.LOC("ui_create_new_project_form_checkbox_multiplayer");
            groupbox_submodules.Text = Helper.LOC("ui_create_new_project_form_groupbox_submodules");
            colSubModuleName.Text = Helper.LOC("ui_create_new_project_form_listview_submodules_column_name");
            colSubModule_DllName.Text = Helper.LOC("ui_create_new_project_form_listview_submodules_column_dllname");
            colSubModuleClassType.Text = Helper.LOC("ui_create_new_project_form_listview_submodules_column_subclasstype");
            colSubModuleTags.Text = Helper.LOC("ui_create_new_project_form_listview_submodules_column_tags");
            colXmlNodeID.Text = Helper.LOC("ui_create_new_project_form_listview_xmls_column_id");
            colXmlNodePath.Text = Helper.LOC("ui_create_new_project_form_listview_xmls_column_path");
            colXmlNodeIncludedGameTypes.Text = Helper.LOC("ui_create_new_project_form_listview_xmls_included_gametypes");
        }

        private void btnAddSubModule_Click(object sender, EventArgs e)
        {

        }

        private void btnAddXmlNode_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSubModule_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteXmlNode_Click(object sender, EventArgs e)
        {

        }

        private void btnModifySubModule_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyXmlNode_Click(object sender, EventArgs e)
        {

        }
    }
}
