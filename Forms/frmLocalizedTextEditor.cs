using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArenaModdingTool.Forms
{
    public partial class frmLocalizedTextEditor : Form, ILocalization
    {
        public string ResultText
        {
            get
            {
                return "{=" + txtLocalizedID.Text + "} " + txtOriginalText.Text;
            }
        }
        public frmLocalizedTextEditor(string inputText)
        {
            InitializeComponent();
            SwitchLanguage();

            if(!string.IsNullOrEmpty(inputText))
            {
                if(inputText.StartsWith("{=") && inputText.Contains("}"))
                {
                    txtLocalizedID.Text = inputText.Substring(inputText.IndexOf("=") + 1, inputText.IndexOf("}") - inputText.IndexOf("=") - 1);
                    txtOriginalText.Text = inputText.Substring(inputText.IndexOf("}") + 1);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocalizedID.Text) || string.IsNullOrEmpty(txtOriginalText.Text))
            {
                MessageBox.Show(Helper.LOC("str_info_please_input_valid_string"), Helper.LOC("str_error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SwitchLanguage()
        {
            Text = Helper.LOC("ui_localized_text_editor");
            lbLocalizedID.Text = Helper.LOC("ui_localized_ID");
            lbOriginalText.Text = Helper.LOC("ui_original_text");
        }
    }
}
