namespace UltimateBattleSimulator.UI.forms
{
    partial class DefenceForm
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
            buttonSave = new Button();
            propertyGrid = new PropertyGrid();
            dataGridViewUnits = new DataGridView();
            groupBoxSize = new GroupBox();
            numericUpDownT = new NumericUpDown();
            numericUpDownH = new NumericUpDown();
            numericUpDownW = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).BeginInit();
            groupBoxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownW).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(272, 570);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(182, 36);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save changes";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // propertyGrid
            // 
            propertyGrid.Location = new Point(12, 12);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new Size(443, 317);
            propertyGrid.TabIndex = 2;
            // 
            // dataGridViewUnits
            // 
            dataGridViewUnits.AllowUserToAddRows = false;
            dataGridViewUnits.AllowUserToDeleteRows = false;
            dataGridViewUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnits.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewUnits.Location = new Point(12, 381);
            dataGridViewUnits.MultiSelect = false;
            dataGridViewUnits.Name = "dataGridViewUnits";
            dataGridViewUnits.ReadOnly = true;
            dataGridViewUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUnits.Size = new Size(442, 183);
            dataGridViewUnits.TabIndex = 4;
            // 
            // groupBoxSize
            // 
            groupBoxSize.Controls.Add(numericUpDownT);
            groupBoxSize.Controls.Add(numericUpDownH);
            groupBoxSize.Controls.Add(numericUpDownW);
            groupBoxSize.Location = new Point(12, 332);
            groupBoxSize.Name = "groupBoxSize";
            groupBoxSize.Size = new Size(442, 43);
            groupBoxSize.TabIndex = 5;
            groupBoxSize.TabStop = false;
            groupBoxSize.Text = "Size";
            // 
            // numericUpDownT
            // 
            numericUpDownT.Location = new Point(288, 14);
            numericUpDownT.Name = "numericUpDownT";
            numericUpDownT.Size = new Size(120, 23);
            numericUpDownT.TabIndex = 2;
            numericUpDownT.ValueChanged += numericUpDownT_ValueChanged;
            // 
            // numericUpDownH
            // 
            numericUpDownH.Location = new Point(162, 14);
            numericUpDownH.Name = "numericUpDownH";
            numericUpDownH.Size = new Size(120, 23);
            numericUpDownH.TabIndex = 1;
            numericUpDownH.ValueChanged += numericUpDownH_ValueChanged;
            // 
            // numericUpDownW
            // 
            numericUpDownW.Location = new Point(36, 14);
            numericUpDownW.Name = "numericUpDownW";
            numericUpDownW.Size = new Size(120, 23);
            numericUpDownW.TabIndex = 0;
            numericUpDownW.ValueChanged += numericUpDownW_ValueChanged;
            // 
            // DefenceForm
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 618);
            Controls.Add(groupBoxSize);
            Controls.Add(dataGridViewUnits);
            Controls.Add(buttonSave);
            Controls.Add(propertyGrid);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DefenceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Defence";
            Load += DefenceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).EndInit();
            groupBoxSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownT).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownH).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownW).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private PropertyGrid propertyGrid;
        private DataGridView dataGridViewUnits;
        private GroupBox groupBoxSize;
        private NumericUpDown numericUpDownH;
        private NumericUpDown numericUpDownW;
        private NumericUpDown numericUpDownT;
    }
}