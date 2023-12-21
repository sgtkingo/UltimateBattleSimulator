namespace UltimateBattleSimulator.UI.forms
{
    partial class ArmyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmyForm));
            buttonSave = new Button();
            propertyGrid = new PropertyGrid();
            groupBoxGroups = new GroupBox();
            toolStripGroups = new ToolStrip();
            toolStripButtonGroupsNew = new ToolStripButton();
            toolStripButtonGroupsDelete = new ToolStripButton();
            toolStripButtonGroupsEdit = new ToolStripButton();
            dataGridViewGroups = new DataGridView();
            bindingSourceGroups = new BindingSource(components);
            toolStripSeparator1 = new ToolStripSeparator();
            groupBoxGroups.SuspendLayout();
            toolStripGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceGroups).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(161, 564);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(240, 41);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save changes";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // propertyGrid
            // 
            propertyGrid.Location = new Point(12, 238);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new Size(389, 320);
            propertyGrid.TabIndex = 1;
            // 
            // groupBoxGroups
            // 
            groupBoxGroups.Controls.Add(toolStripGroups);
            groupBoxGroups.Controls.Add(dataGridViewGroups);
            groupBoxGroups.Location = new Point(12, 12);
            groupBoxGroups.Name = "groupBoxGroups";
            groupBoxGroups.Size = new Size(389, 220);
            groupBoxGroups.TabIndex = 2;
            groupBoxGroups.TabStop = false;
            groupBoxGroups.Text = "Groups";
            // 
            // toolStripGroups
            // 
            toolStripGroups.Items.AddRange(new ToolStripItem[] { toolStripButtonGroupsNew, toolStripButtonGroupsEdit, toolStripSeparator1, toolStripButtonGroupsDelete });
            toolStripGroups.Location = new Point(3, 19);
            toolStripGroups.Name = "toolStripGroups";
            toolStripGroups.Size = new Size(383, 25);
            toolStripGroups.TabIndex = 1;
            toolStripGroups.Text = "Groups";
            // 
            // toolStripButtonGroupsNew
            // 
            toolStripButtonGroupsNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonGroupsNew.Image = (Image)resources.GetObject("toolStripButtonGroupsNew.Image");
            toolStripButtonGroupsNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonGroupsNew.Name = "toolStripButtonGroupsNew";
            toolStripButtonGroupsNew.Size = new Size(23, 22);
            toolStripButtonGroupsNew.Text = "New";
            toolStripButtonGroupsNew.Click += toolStripButtonGroupsNew_Click;
            // 
            // toolStripButtonGroupsDelete
            // 
            toolStripButtonGroupsDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonGroupsDelete.Image = (Image)resources.GetObject("toolStripButtonGroupsDelete.Image");
            toolStripButtonGroupsDelete.ImageTransparentColor = Color.Magenta;
            toolStripButtonGroupsDelete.Name = "toolStripButtonGroupsDelete";
            toolStripButtonGroupsDelete.Size = new Size(23, 22);
            toolStripButtonGroupsDelete.Text = "Delete";
            toolStripButtonGroupsDelete.Click += toolStripButtonGroupsDelete_Click;
            // 
            // toolStripButtonGroupsEdit
            // 
            toolStripButtonGroupsEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonGroupsEdit.Image = (Image)resources.GetObject("toolStripButtonGroupsEdit.Image");
            toolStripButtonGroupsEdit.ImageTransparentColor = Color.Magenta;
            toolStripButtonGroupsEdit.Name = "toolStripButtonGroupsEdit";
            toolStripButtonGroupsEdit.Size = new Size(23, 22);
            toolStripButtonGroupsEdit.Text = "Edit";
            toolStripButtonGroupsEdit.Click += toolStripButtonGroupsEdit_Click;
            // 
            // dataGridViewGroups
            // 
            dataGridViewGroups.AllowUserToAddRows = false;
            dataGridViewGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGroups.Location = new Point(6, 44);
            dataGridViewGroups.MultiSelect = false;
            dataGridViewGroups.Name = "dataGridViewGroups";
            dataGridViewGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGroups.Size = new Size(377, 170);
            dataGridViewGroups.TabIndex = 0;
            dataGridViewGroups.CellContentClick += dataGridViewGroups_CellContentClick;
            dataGridViewGroups.UserDeletingRow += dataGridViewGroups_UserDeletingRow;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // ArmyForm
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 617);
            Controls.Add(groupBoxGroups);
            Controls.Add(propertyGrid);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "ArmyForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Army";
            Load += ArmyForm_Load;
            groupBoxGroups.ResumeLayout(false);
            groupBoxGroups.PerformLayout();
            toolStripGroups.ResumeLayout(false);
            toolStripGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGroups).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceGroups).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private PropertyGrid propertyGrid;
        private GroupBox groupBoxGroups;
        private DataGridView dataGridViewGroups;
        private BindingSource bindingSourceGroups;
        private ToolStrip toolStripGroups;
        private ToolStripButton toolStripButtonGroupsNew;
        private ToolStripButton toolStripButtonGroupsDelete;
        private ToolStripButton toolStripButtonGroupsEdit;
        private ToolStripSeparator toolStripSeparator1;
    }
}