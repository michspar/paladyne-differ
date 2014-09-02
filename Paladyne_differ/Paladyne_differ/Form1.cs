using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paladyne_differ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_SizeChanged(object sender, EventArgs e)
        {
            dataSourceControl1.Width = dataSourceControl2.Width = ((sender as Control).Width - 10) / 2;
            dataSourceControl2.Left = dataSourceControl1.Left + dataSourceControl1.Width + 5;
        }
    }
}
