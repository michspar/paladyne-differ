using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paladyne_differ
{
    public partial class DataSourceControl : UserControl
    {
        public DataSourceControl()
        {
            InitializeComponent();
        }

        private void panelStaticSettings_SizeChanged(object sender, EventArgs e)
        {
            listBoxAll.Width = listBoxComparing.Width = ((sender as Panel).Width - 62) / 2;
            listBoxComparing.Left = listBoxAll.Left + listBoxAll.Width + 55;
            buttonLeft.Left = buttonRight.Left = listBoxAll.Left + listBoxAll.Width + 6;
            listBoxAll.Height =listBoxComparing.Height = (sender as Panel).Height - listBoxAll.Top;
        }
    }
}
