using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool.Forms
{
    public partial class frmAppSetting : Form
    {
        private AppSetting appSetting;
        public AppSetting AppSetting { get { return appSetting; } }

        public frmAppSetting(AppSetting appSetting)
        {
            InitializeComponent();
            this.appSetting = appSetting;
            loadLanguages();
            cmbLanguages.SelectedItem = appSetting.Localization;
        }

        private void loadLanguages()
        {
            foreach (var lang in LanguageManager.Instance.GetLanguageNames())
            {
                cmbLanguages.Items.Add(lang);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            appSetting.Localization = cmbLanguages.SelectedItem.ToString();
            appSetting.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
