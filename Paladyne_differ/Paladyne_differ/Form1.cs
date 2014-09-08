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
            dataSourceControlLeft.Width = dataSourceControlRight.Width = ((sender as Control).Width - 10) / 2;
            dataSourceControlRight.Left = dataSourceControlLeft.Left + dataSourceControlLeft.Width + 5;
        }

        class OrdDataExtrator
        {
            public OrdDataExtrator(DataSourceControl dsc)
            {
                Key = (dsc.comboBoxKeyColumn.SelectedItem as DataColumn).Ordinal;
                Columns = dsc.listBoxComparing.Items.OfType<DataColumn>().Select(c => c.Ordinal).ToArray();
            }

            public int Key { get; private set; }
            public int[] Columns { get; private set; }
        }

        private void buttonCmp_Click(object sender, EventArgs e)
        {
            var bgComparing = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
            var comparer = new DataComparer(dataSourceControlLeft.data, dataSourceControlRight.data);
            var left = new OrdDataExtrator(dataSourceControlLeft);
            var right = new OrdDataExtrator(dataSourceControlRight);

            toolStripProgressBar.ProgressBar.Value = 0;

            comparer.ProgressChanged += (sndr, ea) => bgComparing.ReportProgress(ea.Progress);
            bgComparing.DoWork += (sndr, doWorkEArgs) => comparer.Compare(left.Key, left.Columns, right.Key, right.Columns);
            bgComparing.RunWorkerCompleted += bgComparing_RunWorkerCompleted;
            bgComparing.ProgressChanged += (sndr, ea) => toolStripProgressBar.ProgressBar.Value = ea.ProgressPercentage;

            bgComparing.RunWorkerAsync();
        }

        void bgComparing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                return;

            tabControl.SelectedTab = tabPage2;
        }

    }
}
