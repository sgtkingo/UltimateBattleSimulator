namespace UltimateBattleSimulator.UI.forms
{
    partial class CreateUnitForm
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
            comboBoxUnitTypes = new ComboBox();
            labelUnitTypes = new Label();
            buttonSelect = new Button();
            richTextBoxUnitTypeDescription = new RichTextBox();
            SuspendLayout();
            // 
            // comboBoxUnitTypes
            // 
            comboBoxUnitTypes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxUnitTypes.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxUnitTypes.FormattingEnabled = true;
            comboBoxUnitTypes.Location = new Point(12, 27);
            comboBoxUnitTypes.Name = "comboBoxUnitTypes";
            comboBoxUnitTypes.Size = new Size(246, 23);
            comboBoxUnitTypes.TabIndex = 0;
            comboBoxUnitTypes.SelectedIndexChanged += comboBoxUnitTypes_SelectedIndexChanged;
            // 
            // labelUnitTypes
            // 
            labelUnitTypes.AutoSize = true;
            labelUnitTypes.Location = new Point(12, 9);
            labelUnitTypes.Name = "labelUnitTypes";
            labelUnitTypes.Size = new Size(91, 15);
            labelUnitTypes.TabIndex = 1;
            labelUnitTypes.Text = "Select unit type:";
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(12, 70);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(246, 40);
            buttonSelect.TabIndex = 2;
            buttonSelect.Text = "SELECT";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // richTextBoxUnitTypeDescription
            // 
            richTextBoxUnitTypeDescription.Location = new Point(264, 14);
            richTextBoxUnitTypeDescription.Name = "richTextBoxUnitTypeDescription";
            richTextBoxUnitTypeDescription.ReadOnly = true;
            richTextBoxUnitTypeDescription.Size = new Size(260, 96);
            richTextBoxUnitTypeDescription.TabIndex = 3;
            richTextBoxUnitTypeDescription.Text = "";
            // 
            // CreateUnitForm
            // 
            AcceptButton = buttonSelect;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 122);
            Controls.Add(richTextBoxUnitTypeDescription);
            Controls.Add(buttonSelect);
            Controls.Add(labelUnitTypes);
            Controls.Add(comboBoxUnitTypes);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreateUnitForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Unit";
            Load += CreateUnitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUnitTypes;
        private Label labelUnitTypes;
        private Button buttonSelect;
        private RichTextBox richTextBoxUnitTypeDescription;
    }
}