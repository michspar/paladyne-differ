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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDataSources = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataSourceControl2 = new Paladyne_differ.DataSourceControl();
            this.dataSourceControl1 = new Paladyne_differ.DataSourceControl();
            this.tabControl.SuspendLayout();
            this.tabPageDataSources.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDataSources);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(703, 513);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDataSources
            // 
            this.tabPageDataSources.Controls.Add(this.dataSourceControl2);
            this.tabPageDataSources.Controls.Add(this.dataSourceControl1);
            this.tabPageDataSources.Location = new System.Drawing.Point(4, 22);
            this.tabPageDataSources.Name = "tabPageDataSources";
            this.tabPageDataSources.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataSources.Size = new System.Drawing.Size(695, 487);
            this.tabPageDataSources.TabIndex = 0;
            this.tabPageDataSources.Text = "Data sources";
            this.tabPageDataSources.UseVisualStyleBackColor = true;
            this.tabPageDataSources.SizeChanged += new System.EventHandler(this.tabPage1_SizeChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataSourceControl2
            // 
            this.dataSourceControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataSourceControl2.Location = new System.Drawing.Point(352, 3);
            this.dataSourceControl2.Name = "dataSourceControl2";
            this.dataSourceControl2.Size = new System.Drawing.Size(343, 488);
            this.dataSourceControl2.TabIndex = 1;
            // 
            // dataSourceControl1
            // 
            this.dataSourceControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataSourceControl1.Location = new System.Drawing.Point(3, 3);
            this.dataSourceControl1.Name = "dataSourceControl1";
            this.dataSourceControl1.Size = new System.Drawing.Size(343, 488);
            this.dataSourceControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 513);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPageDataSources.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDataSources;
        private System.Windows.Forms.TabPage tabPage2;
        private DataSourceControl dataSourceControl1;
        private DataSourceControl dataSourceControl2;
    }
}

