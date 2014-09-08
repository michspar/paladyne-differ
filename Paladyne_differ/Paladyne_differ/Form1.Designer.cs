namespace Paladyne_differ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Matched identical", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Matched partially", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Unique left", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Unique right", System.Windows.Forms.HorizontalAlignment.Left);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDataSources = new System.Windows.Forms.TabPage();
            this.buttonCmp = new System.Windows.Forms.Button();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataSourceControlRight = new Paladyne_differ.DataSourceControl();
            this.dataSourceControlLeft = new Paladyne_differ.DataSourceControl();
            this.tabControl.SuspendLayout();
            this.tabPageDataSources.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageDataSources);
            this.tabControl.Controls.Add(this.tabPageResults);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(703, 532);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDataSources
            // 
            this.tabPageDataSources.Controls.Add(this.buttonCmp);
            this.tabPageDataSources.Controls.Add(this.dataSourceControlRight);
            this.tabPageDataSources.Controls.Add(this.dataSourceControlLeft);
            this.tabPageDataSources.Location = new System.Drawing.Point(4, 22);
            this.tabPageDataSources.Name = "tabPageDataSources";
            this.tabPageDataSources.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataSources.Size = new System.Drawing.Size(695, 506);
            this.tabPageDataSources.TabIndex = 0;
            this.tabPageDataSources.Text = "Data sources";
            this.tabPageDataSources.UseVisualStyleBackColor = true;
            this.tabPageDataSources.SizeChanged += new System.EventHandler(this.tabPage1_SizeChanged);
            // 
            // buttonCmp
            // 
            this.buttonCmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCmp.Location = new System.Drawing.Point(612, 477);
            this.buttonCmp.Name = "buttonCmp";
            this.buttonCmp.Size = new System.Drawing.Size(75, 23);
            this.buttonCmp.TabIndex = 2;
            this.buttonCmp.Text = "Compare";
            this.buttonCmp.UseVisualStyleBackColor = true;
            this.buttonCmp.Click += new System.EventHandler(this.buttonCmp_Click);
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.listView);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(695, 506);
            this.tabPageResults.TabIndex = 1;
            this.tabPageResults.Text = "Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Matched identical";
            listViewGroup1.Name = "Identical";
            listViewGroup2.Header = "Matched partially";
            listViewGroup2.Name = "Partial";
            listViewGroup3.Header = "Unique left";
            listViewGroup3.Name = "UniqueLeft";
            listViewGroup4.Header = "Unique right";
            listViewGroup4.Name = "UniqueRight";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listView.Location = new System.Drawing.Point(3, 3);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(689, 500);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(703, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(600, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "x";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // dataSourceControlRight
            // 
            this.dataSourceControlRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataSourceControlRight.Location = new System.Drawing.Point(352, 3);
            this.dataSourceControlRight.Name = "dataSourceControlRight";
            this.dataSourceControlRight.Size = new System.Drawing.Size(343, 464);
            this.dataSourceControlRight.TabIndex = 1;
            // 
            // dataSourceControlLeft
            // 
            this.dataSourceControlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataSourceControlLeft.Location = new System.Drawing.Point(3, 3);
            this.dataSourceControlLeft.Name = "dataSourceControlLeft";
            this.dataSourceControlLeft.Size = new System.Drawing.Size(343, 464);
            this.dataSourceControlLeft.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 552);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPageDataSources.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDataSources;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.Button buttonCmp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private DataSourceControl dataSourceControlLeft;
        private DataSourceControl dataSourceControlRight;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

