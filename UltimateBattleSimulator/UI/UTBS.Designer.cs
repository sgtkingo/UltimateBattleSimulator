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
            toolStripButtonUnitsFromLoadedList = new ToolStripButton();
            toolStripButtonEditUnits = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonDeleteUnits = new ToolStripButton();
            toolStripButtonDeleteAllUnits = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            saveToolStripButtonUnits = new ToolStripButton();
            toolStripButtonSaveAllUnits = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripTextBoxUnitFastSearch = new ToolStripTextBox();
            toolStripButtonRefreshUnits = new ToolStripButton();
            openToolStripButtonUnits = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            copyToolStripButtonUnits = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            helpToolStripButtonUnits = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButtonUnitsHide = new ToolStripButton();
            dataGridViewUnits = new DataGridView();
            tabPageArmies = new TabPage();
            groupBoxArmies = new GroupBox();
            toolStripArmies = new ToolStrip();
            toolStripButtonArmiesNew = new ToolStripButton();
            toolStripButtonArmiesFromList = new ToolStripButton();
            toolStripButtonArmiesEdit = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButtonArmiesDelete = new ToolStripButton();
            toolStripButtonArmiesDeleteAll = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripButtonArmiesSave = new ToolStripButton();
            toolStripButtonArmiesSaveAll = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripTextBoxArmieSearch = new ToolStripTextBox();
            toolStripButtonArmiesRefresh = new ToolStripButton();
            toolStripButtonArmiesLoadFromFile = new ToolStripButton();
            toolStripSeparator10 = new ToolStripSeparator();
            toolStripButtonArmiesCopy = new ToolStripButton();
            toolStripSeparator11 = new ToolStripSeparator();
            toolStripButtonArmiesHelp = new ToolStripButton();
            toolStripSeparator12 = new ToolStripSeparator();
            toolStripButtonArmiesHide = new ToolStripButton();
            dataGridViewArmies = new DataGridView();
            tabPageDefence = new TabPage();
            tabPageEnvironment = new TabPage();
            buttonSimulate = new Button();
            bindingSourceUnits = new BindingSource(components);
            openFileDialog = new OpenFileDialog();
            bindingSourceArmies = new BindingSource(components);
            menuStripMain.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageUnits.SuspendLayout();
            groupBoxUnits.SuspendLayout();
            toolStripUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).BeginInit();
            tabPageArmies.SuspendLayout();
            groupBoxArmies.SuspendLayout();
            toolStripArmies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArmies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceArmies).BeginInit();
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
            toolStripUnits.Items.AddRange(new ToolStripItem[] { newToolStripButtonUnits, toolStripButtonEditUnits, toolStripButtonUnitsFromLoadedList, toolStripSeparator1, toolStripButtonDeleteUnits, toolStripButtonDeleteAllUnits, toolStripSeparator2, saveToolStripButtonUnits, toolStripButtonSaveAllUnits, toolStripSeparator3, toolStripTextBoxUnitFastSearch, toolStripButtonRefreshUnits, openToolStripButtonUnits, toolStripSeparator5, copyToolStripButtonUnits, toolStripSeparator4, helpToolStripButtonUnits, toolStripSeparator6, toolStripButtonUnitsHide });
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
            // toolStripButtonUnitsFromLoadedList
            // 
            toolStripButtonUnitsFromLoadedList.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUnitsFromLoadedList.Image = (Image)resources.GetObject("toolStripButtonUnitsFromLoadedList.Image");
            toolStripButtonUnitsFromLoadedList.ImageTransparentColor = Color.Magenta;
            toolStripButtonUnitsFromLoadedList.Name = "toolStripButtonUnitsFromLoadedList";
            toolStripButtonUnitsFromLoadedList.Size = new Size(23, 22);
            toolStripButtonUnitsFromLoadedList.Text = "From list";
            toolStripButtonUnitsFromLoadedList.Click += toolStripButtonUnitsFromLoadedList_Click;
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
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // toolStripButtonUnitsHide
            // 
            toolStripButtonUnitsHide.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUnitsHide.Image = (Image)resources.GetObject("toolStripButtonUnitsHide.Image");
            toolStripButtonUnitsHide.ImageTransparentColor = Color.Magenta;
            toolStripButtonUnitsHide.Name = "toolStripButtonUnitsHide";
            toolStripButtonUnitsHide.Size = new Size(23, 22);
            toolStripButtonUnitsHide.Text = "Hide";
            toolStripButtonUnitsHide.Click += toolStripButtonUnitsHide_Click;
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
            // tabPageArmies
            // 
            tabPageArmies.Controls.Add(groupBoxArmies);
            tabPageArmies.Location = new Point(4, 24);
            tabPageArmies.Name = "tabPageArmies";
            tabPageArmies.Padding = new Padding(3);
            tabPageArmies.Size = new Size(776, 441);
            tabPageArmies.TabIndex = 1;
            tabPageArmies.Text = "Armies";
            tabPageArmies.UseVisualStyleBackColor = true;
            // 
            // groupBoxArmies
            // 
            groupBoxArmies.Controls.Add(toolStripArmies);
            groupBoxArmies.Controls.Add(dataGridViewArmies);
            groupBoxArmies.Location = new Point(7, 6);
            groupBoxArmies.Name = "groupBoxArmies";
            groupBoxArmies.Size = new Size(762, 429);
            groupBoxArmies.TabIndex = 2;
            groupBoxArmies.TabStop = false;
            groupBoxArmies.Text = "Create and select armies ";
            // 
            // toolStripArmies
            // 
            toolStripArmies.Items.AddRange(new ToolStripItem[] { toolStripButtonArmiesNew, toolStripButtonArmiesEdit, toolStripButtonArmiesFromList, toolStripSeparator7, toolStripButtonArmiesDelete, toolStripButtonArmiesDeleteAll, toolStripSeparator8, toolStripButtonArmiesSave, toolStripButtonArmiesSaveAll, toolStripSeparator9, toolStripTextBoxArmieSearch, toolStripButtonArmiesRefresh, toolStripButtonArmiesLoadFromFile, toolStripSeparator10, toolStripButtonArmiesCopy, toolStripSeparator11, toolStripButtonArmiesHelp, toolStripSeparator12, toolStripButtonArmiesHide });
            toolStripArmies.Location = new Point(3, 19);
            toolStripArmies.Name = "toolStripArmies";
            toolStripArmies.Size = new Size(756, 25);
            toolStripArmies.TabIndex = 5;
            toolStripArmies.Text = "Armies ToolBox";
            // 
            // toolStripButtonArmiesNew
            // 
            toolStripButtonArmiesNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesNew.Image = (Image)resources.GetObject("toolStripButtonArmiesNew.Image");
            toolStripButtonArmiesNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesNew.Name = "toolStripButtonArmiesNew";
            toolStripButtonArmiesNew.Size = new Size(23, 22);
            toolStripButtonArmiesNew.Text = "&New";
            toolStripButtonArmiesNew.Click += toolStripButtonArmiesNew_Click;
            // 
            // toolStripButtonArmiesFromList
            // 
            toolStripButtonArmiesFromList.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesFromList.Image = (Image)resources.GetObject("toolStripButtonArmiesFromList.Image");
            toolStripButtonArmiesFromList.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesFromList.Name = "toolStripButtonArmiesFromList";
            toolStripButtonArmiesFromList.Size = new Size(23, 22);
            toolStripButtonArmiesFromList.Text = "From list";
            toolStripButtonArmiesFromList.Click += toolStripButtonArmiesFromList_Click;
            // 
            // toolStripButtonArmiesEdit
            // 
            toolStripButtonArmiesEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesEdit.Image = (Image)resources.GetObject("toolStripButtonArmiesEdit.Image");
            toolStripButtonArmiesEdit.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesEdit.Name = "toolStripButtonArmiesEdit";
            toolStripButtonArmiesEdit.Size = new Size(23, 22);
            toolStripButtonArmiesEdit.Text = "&Edit";
            toolStripButtonArmiesEdit.ToolTipText = "Edit";
            toolStripButtonArmiesEdit.Click += toolStripButtonArmiesEdit_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 25);
            // 
            // toolStripButtonArmiesDelete
            // 
            toolStripButtonArmiesDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesDelete.Image = (Image)resources.GetObject("toolStripButtonArmiesDelete.Image");
            toolStripButtonArmiesDelete.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesDelete.Name = "toolStripButtonArmiesDelete";
            toolStripButtonArmiesDelete.Size = new Size(23, 22);
            toolStripButtonArmiesDelete.Text = "&Delete";
            toolStripButtonArmiesDelete.ToolTipText = "Delete";
            toolStripButtonArmiesDelete.Click += toolStripButtonArmiesDelete_Click;
            // 
            // toolStripButtonArmiesDeleteAll
            // 
            toolStripButtonArmiesDeleteAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesDeleteAll.Image = (Image)resources.GetObject("toolStripButtonArmiesDeleteAll.Image");
            toolStripButtonArmiesDeleteAll.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesDeleteAll.Name = "toolStripButtonArmiesDeleteAll";
            toolStripButtonArmiesDeleteAll.Size = new Size(23, 22);
            toolStripButtonArmiesDeleteAll.Text = "Delete All";
            toolStripButtonArmiesDeleteAll.Click += toolStripButtonArmiesDeleteAll_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 25);
            // 
            // toolStripButtonArmiesSave
            // 
            toolStripButtonArmiesSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesSave.Image = (Image)resources.GetObject("toolStripButtonArmiesSave.Image");
            toolStripButtonArmiesSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesSave.Name = "toolStripButtonArmiesSave";
            toolStripButtonArmiesSave.Size = new Size(23, 22);
            toolStripButtonArmiesSave.Text = "&Save";
            toolStripButtonArmiesSave.Click += toolStripButtonArmiesSave_Click;
            // 
            // toolStripButtonArmiesSaveAll
            // 
            toolStripButtonArmiesSaveAll.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesSaveAll.Image = (Image)resources.GetObject("toolStripButtonArmiesSaveAll.Image");
            toolStripButtonArmiesSaveAll.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesSaveAll.Name = "toolStripButtonArmiesSaveAll";
            toolStripButtonArmiesSaveAll.Size = new Size(23, 22);
            toolStripButtonArmiesSaveAll.Text = "&Save All";
            toolStripButtonArmiesSaveAll.Click += toolStripButtonArmiesSaveAll_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 25);
            // 
            // toolStripTextBoxArmieSearch
            // 
            toolStripTextBoxArmieSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripTextBoxArmieSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            toolStripTextBoxArmieSearch.Name = "toolStripTextBoxArmieSearch";
            toolStripTextBoxArmieSearch.Size = new Size(100, 25);
            toolStripTextBoxArmieSearch.Click += toolStripTextBoxArmieSearch_Click;
            // 
            // toolStripButtonArmiesRefresh
            // 
            toolStripButtonArmiesRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesRefresh.Image = (Image)resources.GetObject("toolStripButtonArmiesRefresh.Image");
            toolStripButtonArmiesRefresh.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesRefresh.Name = "toolStripButtonArmiesRefresh";
            toolStripButtonArmiesRefresh.Size = new Size(23, 22);
            toolStripButtonArmiesRefresh.Text = "Refresh";
            toolStripButtonArmiesRefresh.Click += toolStripButtonArmiesRefresh_Click;
            // 
            // toolStripButtonArmiesLoadFromFile
            // 
            toolStripButtonArmiesLoadFromFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesLoadFromFile.Image = (Image)resources.GetObject("toolStripButtonArmiesLoadFromFile.Image");
            toolStripButtonArmiesLoadFromFile.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesLoadFromFile.Name = "toolStripButtonArmiesLoadFromFile";
            toolStripButtonArmiesLoadFromFile.Size = new Size(23, 22);
            toolStripButtonArmiesLoadFromFile.Text = "&Open";
            toolStripButtonArmiesLoadFromFile.Click += toolStripButtonArmiesLoadFromFile_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(6, 25);
            // 
            // toolStripButtonArmiesCopy
            // 
            toolStripButtonArmiesCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesCopy.Image = (Image)resources.GetObject("toolStripButtonArmiesCopy.Image");
            toolStripButtonArmiesCopy.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesCopy.Name = "toolStripButtonArmiesCopy";
            toolStripButtonArmiesCopy.Size = new Size(23, 22);
            toolStripButtonArmiesCopy.Text = "&Copy";
            toolStripButtonArmiesCopy.Click += toolStripButtonArmiesCopy_Click;
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(6, 25);
            // 
            // toolStripButtonArmiesHelp
            // 
            toolStripButtonArmiesHelp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesHelp.Image = (Image)resources.GetObject("toolStripButtonArmiesHelp.Image");
            toolStripButtonArmiesHelp.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesHelp.Name = "toolStripButtonArmiesHelp";
            toolStripButtonArmiesHelp.Size = new Size(23, 22);
            toolStripButtonArmiesHelp.Text = "He&lp";
            toolStripButtonArmiesHelp.Click += toolStripButtonArmiesHelp_Click;
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(6, 25);
            // 
            // toolStripButtonArmiesHide
            // 
            toolStripButtonArmiesHide.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonArmiesHide.Image = (Image)resources.GetObject("toolStripButtonArmiesHide.Image");
            toolStripButtonArmiesHide.ImageTransparentColor = Color.Magenta;
            toolStripButtonArmiesHide.Name = "toolStripButtonArmiesHide";
            toolStripButtonArmiesHide.Size = new Size(23, 22);
            toolStripButtonArmiesHide.Text = "Hide";
            toolStripButtonArmiesHide.Click += toolStripButtonArmiesHide_Click;
            // 
            // dataGridViewArmies
            // 
            dataGridViewArmies.BackgroundColor = SystemColors.Control;
            dataGridViewArmies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArmies.Location = new Point(3, 47);
            dataGridViewArmies.MultiSelect = false;
            dataGridViewArmies.Name = "dataGridViewArmies";
            dataGridViewArmies.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewArmies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewArmies.Size = new Size(756, 376);
            dataGridViewArmies.TabIndex = 0;
            dataGridViewArmies.CellContentDoubleClick += dataGridViewArmies_CellContentDoubleClick;
            dataGridViewArmies.UserDeletingRow += dataGridViewArmies_UserDeletingRow;
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
            // openFileDialog
            // 
            openFileDialog.Filter = "JSON files|*.json|Text files |*.txt |All files |*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Select file to open";
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
            tabPageArmies.ResumeLayout(false);
            groupBoxArmies.ResumeLayout(false);
            groupBoxArmies.PerformLayout();
            toolStripArmies.ResumeLayout(false);
            toolStripArmies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArmies).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceArmies).EndInit();
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
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButtonUnitsHide;
        private OpenFileDialog openFileDialog;
        private ToolStripButton toolStripButtonUnitsFromLoadedList;
        private GroupBox groupBoxArmies;
        private ToolStrip toolStripArmies;
        private ToolStripButton toolStripButtonArmiesNew;
        private ToolStripButton toolStripButtonArmiesFromList;
        private ToolStripButton toolStripButtonArmiesEdit;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButtonArmiesDelete;
        private ToolStripButton toolStripButtonArmiesDeleteAll;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButtonArmiesSave;
        private ToolStripButton toolStripButtonArmiesSaveAll;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripTextBox toolStripTextBoxArmieSearch;
        private ToolStripButton toolStripButtonArmiesRefresh;
        private ToolStripButton toolStripButtonArmiesLoadFromFile;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton toolStripButtonArmiesCopy;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton toolStripButtonArmiesHelp;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripButton toolStripButtonArmiesHide;
        private DataGridView dataGridViewArmies;
        private BindingSource bindingSourceArmies;
    }
}