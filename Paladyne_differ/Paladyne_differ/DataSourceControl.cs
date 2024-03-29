﻿using System;
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
            listBoxAll.Height = listBoxComparing.Height = (sender as Panel).Height - listBoxAll.Top;
        }

        private void comboBoxDataSurce_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVariablePanel(sender);
        }

        private void UpdateVariablePanel(object sender)
        {
            if (!((sender as ComboBox).SelectedValue is IDataAdapter))
                return;

            var adapter = (sender as ComboBox).SelectedValue as IDataAdapter;
            var ctrl = adapter.GetSettingsControl();

            ctrl.Width = panelVariableSettings.Width;
            panelVariableSettings.Height = ctrl.Height;

            panelVariableSettings.Controls.Clear();
            panelVariableSettings.Controls.Add(ctrl);
            groupBox.Text = adapter.ToString() + " data source settings";

            ctrl.Dock = DockStyle.Fill;
            ctrl.TabIndex = 1;
            adapter.SettingsApplied += adapter_SettingsApplied;
            (ctrl as ISettingsChandedInformer).SettingsChanged += DataSourceControl_SettingsChanged;
        }

        void DataSourceControl_SettingsChanged(object sender, EventArgs e)
        {
            comboBoxKeyColumn.DataSource = null;
            data = null;

            comboBoxKeyColumn.Items.Clear();
            listBoxAll.Items.Clear();
            listBoxComparing.Items.Clear();
        }

        public DataTable data { get; private set; }

        void adapter_SettingsApplied(object sender, DataTableEventArgs e)
        {
            data = e.Table;

            var columns = data.Columns.OfType<DataColumn>();

            comboBoxKeyColumn.DataSource = columns.ToArray();
            listBoxAll.DisplayMember = listBoxComparing.DisplayMember = comboBoxKeyColumn.DisplayMember = "ColumnName";
        }

        private void DataSourceControl_Load(object sender, EventArgs e)
        {
            UpdateVariablePanel(comboBoxDataSource);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (!listBoxComparing.Items.Contains(listBoxAll.SelectedItem))
                listBoxComparing.Items.Add(listBoxAll.SelectedItem);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            listBoxComparing.Items.Remove(listBoxComparing.SelectedItem);
        }

        private void comboBoxKeyColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxComparing.Items.Clear();
            listBoxAll.Items.Clear();

            var list = data.Columns.OfType<DataColumn>().ToList();

            if ((sender as ComboBox).SelectedItem != null)
                list.Remove((sender as ComboBox).SelectedItem as DataColumn);

            listBoxAll.Items.AddRange(list.ToArray());
            listBoxAll.Refresh();
        }
    }
}
