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
    public partial class frmVectorEditor : Form
    {
        private string strVector;
        public string StrVector
        {
            get { return strVector; }
        }

        public frmVectorEditor(string strVector)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(strVector) && strVector.Where(o=>o == ',').Count() == 2)
            {
                string[] vectors = strVector.Split(',');
                txtVectorX.Text = vectors[0];
                txtVectorY.Text = vectors[1];
                txtVectorZ.Text = vectors[2];
            }
            else
            {
                txtVectorX.Text = null;
                txtVectorY.Text = null;
                txtVectorZ.Text = null;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVectorX.Text) &&
               !string.IsNullOrEmpty(txtVectorY.Text) &&
               !string.IsNullOrEmpty(txtVectorZ.Text))
            {
                strVector = string.Format("{0},{1},{2}", txtVectorX.Text, txtVectorY.Text, txtVectorZ.Text);

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Vector elements can't be empty!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
