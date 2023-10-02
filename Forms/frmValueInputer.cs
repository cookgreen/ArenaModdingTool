using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArenaModdingTool.Forms
{
    public partial class frmValueInputer : Form
    {
        public string Value { get { return txtValue.Text; } }
        public frmValueInputer(string title, string val = "")
        {
            InitializeComponent();
            Text = title + " Editor";
            txtValue.Text = val;
            lbValue.Text = title + ":";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
