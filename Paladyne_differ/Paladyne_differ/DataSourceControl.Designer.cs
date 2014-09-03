namespace Paladyne_differ
{
    partial class DataSourceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxDataSurce = new System.Windows.Forms.ComboBox();
            this.adapterListSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panelStaticSettings = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.listBoxAll = new System.Windows.Forms.ListBox();
            this.listBoxComparing = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKeyColumn = new System.Windows.Forms.ComboBox();
            this.panelVariableSettings = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adapterListSourceBindingSource)).BeginInit();
            this.groupBox.SuspendLayout();
            this.panelStaticSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDataSurce
            // 
            this.comboBoxDataSurce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDataSurce.DataSource = this.adapterListSourceBindingSource;
            this.comboBoxDataSurce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataSurce.FormattingEnabled = true;
            this.comboBoxDataSurce.Location = new System.Drawing.Point(77, 3);
            this.comboBoxDataSurce.Name = "comboBoxDataSurce";
            this.comboBoxDataSurce.Size = new System.Drawing.Size(316, 21);
            this.comboBoxDataSurce.TabIndex = 1;
            this.comboBoxDataSurce.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataSurce_SelectedIndexChanged);
            // 
            // adapterListSourceBindingSource
            // 
            this.adapterListSourceBindingSource.DataSource = typeof(Paladyne_differ.AdapterListSource);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.panelStaticSettings);
            this.groupBox.Controls.Add(this.panelVariableSettings);
            this.groupBox.Location = new System.Drawing.Point(6, 30);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(387, 374);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Data source name";
            // 
            // panelStaticSettings
            // 
            this.panelStaticSettings.Controls.Add(this.label3);
            this.panelStaticSettings.Controls.Add(this.buttonLeft);
            this.panelStaticSettings.Controls.Add(this.buttonRight);
            this.panelStaticSettings.Controls.Add(this.listBoxAll);
            this.panelStaticSettings.Controls.Add(this.listBoxComparing);
            this.panelStaticSettings.Controls.Add(this.label1);
            this.panelStaticSettings.Controls.Add(this.comboBoxKeyColumn);
            this.panelStaticSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStaticSettings.Location = new System.Drawing.Point(3, 140);
            this.panelStaticSettings.Name = "panelStaticSettings";
            this.panelStaticSettings.Size = new System.Drawing.Size(381, 231);
            this.panelStaticSettings.TabIndex = 0;
            this.panelStaticSettings.SizeChanged += new System.EventHandler(this.panelStaticSettings_SizeChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Key column:";
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.Location = new System.Drawing.Point(169, 96);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(43, 23);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.Location = new System.Drawing.Point(169, 67);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(43, 23);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // listBoxAll
            // 
            this.listBoxAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAll.FormattingEnabled = true;
            this.listBoxAll.Location = new System.Drawing.Point(3, 56);
            this.listBoxAll.Name = "listBoxAll";
            this.listBoxAll.Size = new System.Drawing.Size(160, 173);
            this.listBoxAll.TabIndex = 3;
            // 
            // listBoxComparing
            // 
            this.listBoxComparing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxComparing.FormattingEnabled = true;
            this.listBoxComparing.Location = new System.Drawing.Point(218, 56);
            this.listBoxComparing.Name = "listBoxComparing";
            this.listBoxComparing.Size = new System.Drawing.Size(160, 173);
            this.listBoxComparing.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data columns:";
            // 
            // comboBoxKeyColumn
            // 
            this.comboBoxKeyColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxKeyColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeyColumn.FormattingEnabled = true;
            this.comboBoxKeyColumn.Location = new System.Drawing.Point(74, 6);
            this.comboBoxKeyColumn.Name = "comboBoxKeyColumn";
            this.comboBoxKeyColumn.Size = new System.Drawing.Size(304, 21);
            this.comboBoxKeyColumn.TabIndex = 0;
            // 
            // panelVariableSettings
            // 
            this.panelVariableSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVariableSettings.Location = new System.Drawing.Point(3, 16);
            this.panelVariableSettings.Name = "panelVariableSettings";
            this.panelVariableSettings.Size = new System.Drawing.Size(381, 124);
            this.panelVariableSettings.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data source:";
            // 
            // DataSourceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.comboBoxDataSurce);
            this.Name = "DataSourceControl";
            this.Size = new System.Drawing.Size(396, 407);
            this.Load += new System.EventHandler(this.DataSourceControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adapterListSourceBindingSource)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.panelStaticSettings.ResumeLayout(false);
            this.panelStaticSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDataSurce;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panelStaticSettings;
        private System.Windows.Forms.ListBox listBoxAll;
        private System.Windows.Forms.ListBox listBoxComparing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKeyColumn;
        private System.Windows.Forms.Panel panelVariableSettings;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource adapterListSourceBindingSource;
    }
}
