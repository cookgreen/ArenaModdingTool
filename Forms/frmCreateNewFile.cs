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

namespace ArenaModdingTool.Forms
{
    public partial class frmCreateNewFile: Form
    {
        private string fileType;
        private MBXmlNode mbXmlNode;

        public MBXmlNode MBXmlNode
        {
            get { return mbXmlNode; }
        }


        public string FileName
        {
            get { return txtFileName.Text; }
        }

        public frmCreateNewFile(string fileName, string filePath, string fileType)
        {
            InitializeComponent();
            txtFileName.Text = fileName;
            txtFilePath.Text = filePath;
            this.fileType = fileType;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show("File name can't be empty!");
                return;
            }

            List<string> includeGameTypes = new List<string>();
            foreach (var control in groupBoxIncludeGameType.Controls)
            {
                if (((CheckBox)control).Checked)
                {
                    includeGameTypes.Add(((CheckBox)control).Text);
                }
            }
            mbXmlNode = new MBXmlNode();
            mbXmlNode.XmlName = new MBXmlNodeName();
            mbXmlNode.XmlName.id = fileType;
            mbXmlNode.XmlName.path = txtFileName.Text;
            mbXmlNode.IncludedGameTypes = new MBXmlNodeIncludedGameTypes();
            mbXmlNode.IncludedGameTypes.GameTypes = new List<MBSubModuleInfoElement>();
            foreach (var igt in includeGameTypes)
            {
                MBSubModuleInfoElement element = new MBSubModuleInfoElement();
                element.value = igt;
                mbXmlNode.IncludedGameTypes.GameTypes.Add(element);
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
