namespace UltimateBattleSimulator.UI
{
    partial class UTBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UTBS));
            menuStripMain = new MenuStrip();
            unitsToolStripMenuItem = new ToolStripMenuItem();
            simulationToolStripMenuItem = new ToolStripMenuItem();
            globalToolStripMenuItem = new ToolStripMenuItem();
            tabControlMain = new TabControl();
            tabPageUnits = new TabPage();
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
            toolStripTextBoxUnitFastSearch = new ToolStripTextBox();
            openToolStripButtonUnits = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            copyToolStripButtonUnits = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            helpToolStripButtonUnits = new ToolStripButton();
            dataGridViewUnits = new DataGridView();
            tabPageArmies = new TabPage();
            tabPageDefence = new TabPage();
            tabPageEnvironment = new TabPage();
            buttonSimulate = new Button();
            bindingSourceUnits = new BindingSource(components);
            toolStripButtonRefreshUnits = new ToolStripButton();
            menuStripMain.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageUnits.SuspendLayout();
            groupBoxUnits.SuspendLayout();
            toolStripUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUnits).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { unitsToolStripMenuItem, simulationToolStripMenuItem, globalToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(784, 24);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "menuStripMain";
            // 
            // unitsToolStripMenuItem
            // 
            unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            unitsToolStripMenuItem.Size = new Size(46, 20);
            unitsToolStripMenuItem.Text = "Units";
            // 
            // simulationToolStripMenuItem
            // 
            simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            simulationToolStripMenuItem.Size = new Size(76, 20);
            simulationToolStripMenuItem.Text = "Simulation";
            // 
            // globalToolStripMenuItem
            // 
            globalToolStripMenuItem.Name = "globalToolStripMenuItem";
            globalToolStripMenuItem.Size = new Size(53, 20);
            globalToolStripMenuItem.Text = "Global";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageUnits);
            tabControlMain.Controls.Add(tabPageArmies);
            tabControlMain.Controls.Add(tabPageDefence);
            tabControlMain.Controls.Add(tabPageEnvironment);
            tabControlMain.Location = new Point(0, 27);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(784, 469);
            tabControlMain.TabIndex = 2;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPageUnits
            // 
            tabPageUnits.Controls.Add(groupBoxUnits);
            tabPageUnits.Location = new Point(4, 24);
            tabPageUnits.Name = "tabPageUnits";
            tabPageUnits.Padding = new Padding(3);
            tabPageUnits.Size = new Size(776, 441);
            tabPageUnits.TabIndex = 0;
            tabPageUnits.Text = "Units";
            tabPageUnits.UseVisualStyleBackColor = true;
            // 
            // groupBoxUnits
            // 
            groupBoxUnits.Controls.Add(toolStripUnits);
            groupBoxUnits.Controls.Add(dataGridViewUnits);
            groupBoxUnits.Location = new Point(8, 6);
            groupBoxUnits.Name = "groupBoxUnits";
            groupBoxUnits.Size = new Size(762, 429);
            groupBoxUnits.TabIndex = 1;
            groupBoxUnits.TabStop = false;
            groupBoxUnits.Text = "Create and select units ";
            // 
            // toolStripUnits
            // 
            toolStripUnits.Items.AddRange(new ToolStripItem[] { newToolStripButtonUnits, toolStripButtonEditUnits, toolStripSeparator1, toolStripButtonDeleteUnits, toolStripButtonDeleteAllUnits, toolStripSeparator2, saveToolStripButtonUnits, toolStripButtonSaveAllUnits, toolStripSeparator3, toolStripTextBoxUnitFastSearch, toolStripButtonRefreshUnits, openToolStripButtonUnits, toolStripSeparator5, copyToolStripButtonUnits, toolStripSeparator4, helpToolStripButtonUnits });
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
            toolStripButtonEditUnits.Image = (Image)resources.GetObject("toolStripButtonEditUnits.Image");
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
            toolStripButtonDeleteUnits.Image = (Image)resources.GetObject("toolStripButtonDeleteUnits.Image");
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
            toolStripButtonDeleteAllUnits.Image = (Image)resources.GetObject("toolStripButtonDeleteAllUnits.Image");
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
            toolStripButtonSaveAllUnits.Image = (Image)resources.GetObject("toolStripButtonSaveAllUnits.Image");
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
            // toolStripTextBoxUnitFastSearch
            // 
            toolStripTextBoxUnitFastSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripTextBoxUnitFastSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            toolStripTextBoxUnitFastSearch.Name = "toolStripTextBoxUnitFastSearch";
            toolStripTextBoxUnitFastSearch.Size = new Size(100, 25);
            toolStripTextBoxUnitFastSearch.KeyDown += toolStripTextBoxUnitFastSearch_KeyDown;
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
            dataGridViewUnits.UserAddedRow += dataGridViewUnitsAllies_UserAddedRow;
            dataGridViewUnits.UserDeletingRow += dataGridViewUnitsAllies_UserDeletingRow;
            // 
            // tabPageArmies
            // 
            tabPageArmies.Location = new Point(4, 24);
            tabPageArmies.Name = "tabPageArmies";
            tabPageArmies.Padding = new Padding(3);
            tabPageArmies.Size = new Size(776, 441);
            tabPageArmies.TabIndex = 1;
            tabPageArmies.Text = "Armies";
            tabPageArmies.UseVisualStyleBackColor = true;
            // 
            // tabPageDefence
            // 
            tabPageDefence.Location = new Point(4, 24);
            tabPageDefence.Name = "tabPageDefence";
            tabPageDefence.Padding = new Padding(3);
            tabPageDefence.Size = new Size(776, 441);
            tabPageDefence.TabIndex = 2;
            tabPageDefence.Text = "Defence";
            tabPageDefence.UseVisualStyleBackColor = true;
            // 
            // tabPageEnvironment
            // 
            tabPageEnvironment.Location = new Point(4, 24);
            tabPageEnvironment.Name = "tabPageEnvironment";
            tabPageEnvironment.Size = new Size(776, 441);
            tabPageEnvironment.TabIndex = 3;
            tabPageEnvironment.Text = "Environment";
            tabPageEnvironment.UseVisualStyleBackColor = true;
            // 
            // buttonSimulate
            // 
            buttonSimulate.BackColor = SystemColors.Highlight;
            buttonSimulate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonSimulate.Location = new Point(545, 502);
            buttonSimulate.Name = "buttonSimulate";
            buttonSimulate.Size = new Size(227, 47);
            buttonSimulate.TabIndex = 3;
            buttonSimulate.Text = "SIMULATE";
            buttonSimulate.UseVisualStyleBackColor = false;
            // 
            // toolStripButtonRefreshUnits
            // 
            toolStripButtonRefreshUnits.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRefreshUnits.Image = (Image)resources.GetObject("toolStripButtonRefreshUnits.Image");
            toolStripButtonRefreshUnits.ImageTransparentColor = Color.Magenta;
            toolStripButtonRefreshUnits.Name = "toolStripButtonRefreshUnits";
            toolStripButtonRefreshUnits.Size = new Size(23, 22);
            toolStripButtonRefreshUnits.Text = "Refresh";
            toolStripButtonRefreshUnits.Click += toolStripButtonRefreshUnits_Click;
            // 
            // UTBS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(buttonSimulate);
            Controls.Add(tabControlMain);
            Controls.Add(menuStripMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStripMain;
            MaximizeBox = false;
            Name = "UTBS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UTBS";
            Load += UTBS_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabPageUnits.ResumeLayout(false);
            groupBoxUnits.ResumeLayout(false);
            groupBoxUnits.PerformLayout();
            toolStripUnits.ResumeLayout(false);
            toolStripUnits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUnits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStripMain;
        private ToolStripMenuItem unitsToolStripMenuItem;
        private ToolStripMenuItem simulationToolStripMenuItem;
        private ToolStripMenuItem globalToolStripMenuItem;
        private TabControl tabControlMain;
        private TabPage tabPageUnits;
        private GroupBox groupBoxUnits;
        private DataGridView dataGridViewUnits;
        private TabPage tabPageArmies;
        private TabPage tabPageDefence;
        private TabPage tabPageEnvironment;
        private Button buttonSimulate;
        private BindingSource bindingSourceUnits;
        private ToolStrip toolStripUnits;
        private ToolStripButton toolStripButtonEditUnits;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonDeleteUnits;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonSaveAllUnits;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripTextBox toolStripTextBoxUnitFastSearch;
        private ToolStripButton newToolStripButtonUnits;
        private ToolStripButton saveToolStripButtonUnits;
        private ToolStripButton openToolStripButtonUnits;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton copyToolStripButtonUnits;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton helpToolStripButtonUnits;
        private ToolStripButton toolStripButtonDeleteAllUnits;
        private ToolStripButton toolStripButtonRefreshUnits;
    }
}