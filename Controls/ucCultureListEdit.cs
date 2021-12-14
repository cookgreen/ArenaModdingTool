using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArenaModdingTool.ModdingFiles;

namespace ArenaModdingTool.Controls
{
    public partial class ucCultureListEdit : UserControl
    {
        private ucCultureList cultureList;
        private AddEditState state;

        public AddEditState State { get { return state; } }
        public event Action<MBBannerlordCulture, int> SelectCultureChanged;

        public ucCultureListEdit(MBBannerlordCultures cultures)
        {
            InitializeComponent();

            state = AddEditState.View;

            cultureList = new ucCultureList(cultures);
            panel2.Controls.Clear();
            panel2.Controls.Add(cultureList);
            cultureList.Dock = DockStyle.Fill;

            cultureList.SelectCultureChanged += CultureList_SelectCultureChanged;
        }

        private void CultureList_SelectCultureChanged(MBBannerlordCulture arg1, int arg2)
        {
            SelectCultureChanged?.Invoke(arg1, arg2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }
    }
}
