using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool
{
    public partial class frmImportProject : Form, ILocalization
    {
        private ModdingProject project;
        public ModdingProject Project { get { return project; } }
        public frmImportProject()
        {
            InitializeComponent();
            SwitchLanguage();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtModuleLocation.Text = dialog.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(dialog.SelectedPath);
                var files = di.EnumerateFiles();
                if (files.Where(o => o.Name == "SubModule.xml").Count() == 0)
                {
                    MessageBox.Show(
                        Helper.LOC("str_error_message_invalid_module_path"),
                        Helper.LOC("str_error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModuleLocation.Text = null;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtModuleLocation.Text))
            {
                MessageBox.Show(
                    Helper.LOC("str_error_message_please_select_a_valid_module_path"), 
                    Helper.LOC("str_error"), MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
            else
            {
                project = new ModdingProject(txtModuleLocation.Text);
                DialogResult = DialogResult.OK;

                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public void SwitchLanguage()
        {
            Text = Helper.LOC("ui_import_project_form_title");
            lbModLocation.Text = Helper.LOC("ui_import_project_form_label_location");
            btnOK.Text = Helper.LOC("ui_ok");
            btnCancel.Text = Helper.LOC("ui_cancel");
        }
    }
}
