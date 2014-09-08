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

        BackgroundWorker bgComparing;

        private void buttonCmp_Click(object sender, EventArgs e)
        {
            if (dataSourceControlLeft.data == null || dataSourceControlRight.data == null)
                return;

            bgComparing = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
            
            var comparer = new DataComparer(dataSourceControlLeft.data, dataSourceControlRight.data);
            var left = new OrdDataExtrator(dataSourceControlLeft);
            var right = new OrdDataExtrator(dataSourceControlRight);

            toolStripProgressBar.ProgressBar.Value = 0;

            comparer.ProgressChanged += (sndr, ea) => bgComparing.ReportProgress(ea.Progress);

            bgComparing.DoWork += (sndr, doWorkEArgs) =>
            {
                doWorkEArgs.Result = comparer.Compare(left.Key, left.Columns, right.Key, right.Columns, bgComparing);
                doWorkEArgs.Cancel = bgComparing.CancellationPending;
            };

            bgComparing.RunWorkerCompleted += bgComparing_RunWorkerCompleted;
            bgComparing.ProgressChanged += (sndr, ea) => toolStripProgressBar.ProgressBar.Value = ea.ProgressPercentage;

            AllControlsEnabledStateChange(tabPageDataSources, false);
            bgComparing.RunWorkerAsync();
        }

        private void AllControlsEnabledStateChange(Control ctrl, bool isEnabled)
        {
            foreach (var subctrl in ctrl.Controls)
                AllControlsEnabledStateChange(subctrl as Control, isEnabled);

            ctrl.Enabled = isEnabled;
        }

        void bgComparing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AllControlsEnabledStateChange(tabPageDataSources, true);

            if (e.Cancelled)
                return;

            var result = e.Result as ComparationResult;

            listView.Columns.Clear();
            listView.Items.Clear();
            
            listView.
            Columns.
            Add(string.Format("{0} / {1}", dataSourceControlLeft.comboBoxKeyColumn.SelectedItem.ToString(), dataSourceControlRight.comboBoxKeyColumn.SelectedItem.ToString()));
            
            dataSourceControlLeft.listBoxComparing.
            Items.OfType<DataColumn>().
            Zip(dataSourceControlRight.listBoxComparing.Items.OfType<DataColumn>(), (left, right) => string.Format("{0} / {1}", left.Caption, right.Caption)).
            ToList().
            ForEach(col => listView.Columns.Add(col));

            SetGroupItemsCountInCaption(listView.Groups["Identical"], "Matched identical", result.Matched.Count);
            SetGroupItemsCountInCaption(listView.Groups["Partial"], "Matched partially", result.PartiallyMatched.Count);
            SetGroupItemsCountInCaption(listView.Groups["UniqueLeft"], "Unique left", result.UniqueLeft.Count);
            SetGroupItemsCountInCaption(listView.Groups["UniqueRight"], "Unique right", result.UniqueRight.Count);

            result.Matched.ForEach(res => listView.Items.Add(new ListViewItem(res) { Group = listView.Groups["Identical"] }));

            result.PartiallyMatched.ForEach(
                res => listView.Items.Add(
                    new ListViewItem(
                        res.Key.Zip(res.Value, (k, v) => k == v ? k : string.Format("{0} / {1}", k, v)).ToArray()) { Group = listView.Groups["Partial"] }));

            result.UniqueLeft.ForEach(res => listView.Items.Add(new ListViewItem(res) { Group = listView.Groups["UniqueLeft"] }));
            result.UniqueRight.ForEach(res => listView.Items.Add(new ListViewItem(res) { Group = listView.Groups["UniqueRight"] })); 

            tabControl.SelectedTab = tabPageResults;
        }

        private void SetGroupItemsCountInCaption(ListViewGroup group, string caption, int count)
        {
            group.Header = string.Format("{0} ({1})", caption, count);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            if (bgComparing != null)
                bgComparing.CancelAsync();
        }
    }
}
