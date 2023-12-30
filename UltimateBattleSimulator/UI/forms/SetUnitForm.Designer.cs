namespace UltimateBattleSimulator.UI.forms
{
    partial class SetUnitForm
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
            buttonOK = new Button();
            dataGridViewUnits = new DataGridView();
            bindingSourceUnits = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUnits).BeginInit();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(12, 289);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(320, 44);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "Set";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // dataGridViewUnits
            // 
            dataGridViewUnits.AllowUserToAddRows = false;
            dataGridViewUnits.AllowUserToDeleteRows = false;
            dataGridViewUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnits.Location = new Point(12, 12);
            dataGridViewUnits.MultiSelect = false;
            dataGridViewUnits.Name = "dataGridViewUnits";
            dataGridViewUnits.ReadOnly = true;
            dataGridViewUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUnits.Size = new Size(320, 271);
            dataGridViewUnits.TabIndex = 1;
            // 
            // bindingSourceUnits
            // 
            bindingSourceUnits.CurrentChanged += bindingSourceUnits_CurrentChanged;
            // 
            // SetUnitForm
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 345);
            Controls.Add(dataGridViewUnits);
            Controls.Add(buttonOK);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "SetUnitForm";
            Text = "Set unit form";
            Load += SetUnitForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceUnits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOK;
        private DataGridView dataGridViewUnits;
        private BindingSource bindingSourceUnits;
    }
}