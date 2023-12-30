namespace UltimateBattleSimulator.UI.managers
{
    partial class UnitsManagerForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitsManagerForm));
            groupBoxUnits = new GroupBox();
            toolStripUnits = new ToolStrip();
            newToolStripButtonUnits = new ToolStripButton();
            toolStripButtonEditUnits = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonDeleteUnits = new ToolStripButton();
            toolStripButtonDeleteAllUnits = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            saveToolStripButtonUnits = new ToolStripButton();
            toolStripButtonSaveAllUnits = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButtonRefreshUnits = new ToolStripButton();
            openToolStripButtonUnits = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            copyToolStripButtonUnits = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            helpToolStripButtonUnits = new ToolStripButton();
            dataGridViewUnits = new DataGridView();
            bindingSourceUnits = new BindingSource(components);
            openFileDialog = new OpenFileDialog();
            groupBoxUnits.SuspendLayout();
            toolStripUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUnits).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUnits
            // 
            groupBoxUnits.Controls.Add(toolStripUnits);
            groupBoxUnits.Controls.Add(dataGridViewUnits);
            groupBoxUnits.Location = new Point(12, 12);
            groupBoxUnits.Name = "groupBoxUnits";
            groupBoxUnits.Size = new Size(762, 429);
            groupBoxUnits.TabIndex = 2;
            groupBoxUnits.TabStop = false;
            groupBoxUnits.Text = "Manage Units here";
            // 
            // toolStripUnits
            // 
            toolStripUnits.Items.AddRange(new ToolStripItem[] { newToolStripButtonUnits, toolStripButtonEditUnits, toolStripSeparator1, toolStripButtonDeleteUnits, toolStripButtonDeleteAllUnits, toolStripSeparator2, saveToolStripButtonUnits, toolStripButtonSaveAllUnits, toolStripSeparator3, toolStripButtonRefreshUnits, openToolStripButtonUnits, toolStripSeparator5, copyToolStripButtonUnits, toolStripSeparator4, helpToolStripButtonUnits });
            toolStripUnits.Location = new Point(3, 19);
            toolStripUnits.Name = "toolStripUnits";
            toolStripUnits.Size = new Size(756, 25);
            toolStripUnits.TabIndex = 5;
            toolStripUnits.Text = "toolStrip1";
            // 
            // newToolStripButtonUnits
            // 
            newToolStripButtonUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButtonUnits.Image = (Image)resources.GetObject("newToolStripButtonUnits.Image");
            newToolStripButtonUnits.ImageTransparentColor = Color.Magenta;
            newToolStripButtonUnits.Name = "newToolStripButtonUnits";
            newToolStripButtonUnits.Size = new Size(23, 22);
            newToolStripButtonUnits.Text = "&New";
            newToolStripButtonUnits.Click += newToolStripButtonUnits_Click;
            // 
            // toolStripButtonEditUnits
            // 
            toolStripButtonEditUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditUnits.Image = Properties.Resources.edit;
            toolStripButtonEditUnits.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditUnits.Name = "toolStripButtonEditUnits";
            toolStripButtonEditUnits.Size = new Size(23, 22);
            toolStripButtonEditUnits.Text = "&Edit";
            toolStripButtonEditUnits.ToolTipText = "Edit";
            toolStripButtonEditUnits.Click += toolStripButtonEditUnits_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButtonDeleteUnits
            // 
            toolStripButtonDeleteUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeleteUnits.Image = Properties.Resources.delete_icon;
            toolStripButtonDeleteUnits.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteUnits.Name = "toolStripButtonDeleteUnits";
            toolStripButtonDeleteUnits.Size = new Size(23, 22);
            toolStripButtonDeleteUnits.Text = "&Delete";
            toolStripButtonDeleteUnits.ToolTipText = "Delete";
            toolStripButtonDeleteUnits.Click += toolStripButtonDeleteUnits_Click;
            // 
            // toolStripButtonDeleteAllUnits
            // 
            toolStripButtonDeleteAllUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeleteAllUnits.Image = Properties.Resources.delete_all_icon;
            toolStripButtonDeleteAllUnits.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteAllUnits.Name = "toolStripButtonDeleteAllUnits";
            toolStripButtonDeleteAllUnits.Size = new Size(23, 22);
            toolStripButtonDeleteAllUnits.Text = "Delete All";
            toolStripButtonDeleteAllUnits.Click += toolStripButtonDeleteAllUnits_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // saveToolStripButtonUnits
            // 
            saveToolStripButtonUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButtonUnits.Image = (Image)resources.GetObject("saveToolStripButtonUnits.Image");
            saveToolStripButtonUnits.ImageTransparentColor = Color.Magenta;
            saveToolStripButtonUnits.Name = "saveToolStripButtonUnits";
            saveToolStripButtonUnits.Size = new Size(23, 22);
            saveToolStripButtonUnits.Text = "&Save";
            saveToolStripButtonUnits.Click += saveToolStripButtonUnits_Click;
            // 
            // toolStripButtonSaveAllUnits
            // 
            toolStripButtonSaveAllUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSaveAllUnits.Image = Properties.Resources.document_save_icon;
            toolStripButtonSaveAllUnits.ImageTransparentColor = Color.Magenta;
            toolStripButtonSaveAllUnits.Name = "toolStripButtonSaveAllUnits";
            toolStripButtonSaveAllUnits.Size = new Size(23, 22);
            toolStripButtonSaveAllUnits.Text = "&Save All";
            toolStripButtonSaveAllUnits.Click += toolStripButtonSaveAllUnits_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripButtonRefreshUnits
            // 
            toolStripButtonRefreshUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRefreshUnits.Image = Properties.Resources.refresh_icon;
            toolStripButtonRefreshUnits.ImageTransparentColor = Color.Magenta;
            toolStripButtonRefreshUnits.Name = "toolStripButtonRefreshUnits";
            toolStripButtonRefreshUnits.Size = new Size(23, 22);
            toolStripButtonRefreshUnits.Text = "Refresh";
            toolStripButtonRefreshUnits.Click += toolStripButtonRefreshUnits_Click;
            // 
            // openToolStripButtonUnits
            // 
            openToolStripButtonUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButtonUnits.Image = (Image)resources.GetObject("openToolStripButtonUnits.Image");
            openToolStripButtonUnits.ImageTransparentColor = Color.Magenta;
            openToolStripButtonUnits.Name = "openToolStripButtonUnits";
            openToolStripButtonUnits.Size = new Size(23, 22);
            openToolStripButtonUnits.Text = "&Open";
            openToolStripButtonUnits.Click += openToolStripButtonUnits_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 25);
            // 
            // copyToolStripButtonUnits
            // 
            copyToolStripButtonUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButtonUnits.Image = (Image)resources.GetObject("copyToolStripButtonUnits.Image");
            copyToolStripButtonUnits.ImageTransparentColor = Color.Magenta;
            copyToolStripButtonUnits.Name = "copyToolStripButtonUnits";
            copyToolStripButtonUnits.Size = new Size(23, 22);
            copyToolStripButtonUnits.Text = "&Copy";
            copyToolStripButtonUnits.Click += copyToolStripButtonUnits_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // helpToolStripButtonUnits
            // 
            helpToolStripButtonUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButtonUnits.Image = (Image)resources.GetObject("helpToolStripButtonUnits.Image");
            helpToolStripButtonUnits.ImageTransparentColor = Color.Magenta;
            helpToolStripButtonUnits.Name = "helpToolStripButtonUnits";
            helpToolStripButtonUnits.Size = new Size(23, 22);
            helpToolStripButtonUnits.Text = "He&lp";
            helpToolStripButtonUnits.Click += helpToolStripButtonUnits_Click;
            // 
            // dataGridViewUnits
            // 
            dataGridViewUnits.BackgroundColor = SystemColors.Control;
            dataGridViewUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnits.Location = new Point(3, 47);
            dataGridViewUnits.MultiSelect = false;
            dataGridViewUnits.Name = "dataGridViewUnits";
            dataGridViewUnits.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUnits.Size = new Size(756, 379);
            dataGridViewUnits.TabIndex = 0;
            dataGridViewUnits.CellContentDoubleClick += dataGridViewUnitsAllies_CellContentDoubleClick;
            dataGridViewUnits.UserDeletingRow += dataGridViewUnits_UserDeletingRow;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "JSON files|*.json|Text files |*.txt |All files |*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Select file to open";
            // 
            // UnitsManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(groupBoxUnits);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UnitsManagerForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Units Manager";
            Load += UnitsManagerForm_Load;
            groupBoxUnits.ResumeLayout(false);
            groupBoxUnits.PerformLayout();
            toolStripUnits.ResumeLayout(false);
            toolStripUnits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUnits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUnits;
        private ToolStrip toolStripUnits;
        private ToolStripButton newToolStripButtonUnits;
        private ToolStripButton toolStripButtonEditUnits;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonDeleteUnits;
        private ToolStripButton toolStripButtonDeleteAllUnits;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton saveToolStripButtonUnits;
        private ToolStripButton toolStripButtonSaveAllUnits;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButtonRefreshUnits;
        private ToolStripButton openToolStripButtonUnits;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton copyToolStripButtonUnits;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton helpToolStripButtonUnits;
        private DataGridView dataGridViewUnits;
        private BindingSource bindingSourceUnits;
        private OpenFileDialog openFileDialog;
    }
}