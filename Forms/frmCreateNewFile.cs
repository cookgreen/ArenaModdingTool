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
    public partial class frmCreateNewFile: Form
    {
        public string FileName
        {
            get { return txtFileName.Text; }
        }
        public List<string> IncludeGameTypes
        {
            get
            {
                List<string> includeGameTypes = new List<string>();
                foreach(var control in groupBoxIncludeGameType.Controls)
                {
                    if (((CheckBox)control).Checked)
                    {
                        includeGameTypes.Add(((CheckBox)control).Text);
                    }
                }
                return includeGameTypes;
            }
        }

        public frmCreateNewFile(string fileName, string filePath)
        {
            InitializeComponent();
            txtFileName.Text = fileName;
            txtFilePath.Text = filePath;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show("File name can't be empty!");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
