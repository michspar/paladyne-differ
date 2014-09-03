using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQLAdapter
{
    public partial class MSSQLConnectionSettings : UserControl
    {
        MSSqlDataAdapter parent;

        public MSSQLConnectionSettings(MSSqlDataAdapter parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxU.Enabled = textBoxP.Enabled = (sender as CheckBox).Checked;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            parent.ApplySettings(string.Format("{0}", comboBoxTables.SelectedItem));
        }

        private void textBoxServer_Leave(object sender, EventArgs e)
        {
            comboBoxDB.Items.Clear();
            comboBoxDB.Items.AddRange(parent.FetchDatabases((sender as TextBox).Text));
        }

        private void comboBoxDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTables.Items.Clear();
            comboBoxTables.Items.AddRange(parent.FetchTables(string.Format("{0}", (sender as ComboBox).SelectedItem)));
        }
    }
}
