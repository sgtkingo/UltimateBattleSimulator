﻿namespace UltimateBattleSimulator.UI.forms
{
    partial class SelectUnitFromListForm
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
            checkedListBoxUnits = new CheckedListBox();
            richTextBoxUnitInfo = new RichTextBox();
            buttonSelect = new Button();
            buttonReload = new Button();
            SuspendLayout();
            // 
            // checkedListBoxUnits
            // 
            checkedListBoxUnits.FormattingEnabled = true;
            checkedListBoxUnits.Location = new Point(12, 48);
            checkedListBoxUnits.Name = "checkedListBoxUnits";
            checkedListBoxUnits.Size = new Size(235, 436);
            checkedListBoxUnits.TabIndex = 0;
            checkedListBoxUnits.ItemCheck += checkedListBoxUnits_ItemCheck;
            checkedListBoxUnits.SelectedIndexChanged += checkedListBoxUnits_SelectedIndexChanged;
            // 
            // richTextBoxUnitInfo
            // 
            richTextBoxUnitInfo.Location = new Point(253, 12);
            richTextBoxUnitInfo.Name = "richTextBoxUnitInfo";
            richTextBoxUnitInfo.ReadOnly = true;
            richTextBoxUnitInfo.Size = new Size(298, 418);
            richTextBoxUnitInfo.TabIndex = 1;
            richTextBoxUnitInfo.Text = "";
            // 
            // buttonSelect
            // 
            buttonSelect.BackColor = SystemColors.Highlight;
            buttonSelect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonSelect.Location = new Point(253, 436);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(298, 48);
            buttonSelect.TabIndex = 2;
            buttonSelect.Text = "Select";
            buttonSelect.UseVisualStyleBackColor = false;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonReload
            // 
            buttonReload.BackColor = Color.DarkOrange;
            buttonReload.BackgroundImage = Properties.Resources.refresh_icon;
            buttonReload.BackgroundImageLayout = ImageLayout.Zoom;
            buttonReload.Location = new Point(210, 12);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(37, 30);
            buttonReload.TabIndex = 3;
            buttonReload.UseVisualStyleBackColor = false;
            buttonReload.Click += buttonReload_Click;
            // 
            // SelectUnitFromListForm
            // 
            AcceptButton = buttonSelect;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 493);
            Controls.Add(buttonReload);
            Controls.Add(buttonSelect);
            Controls.Add(richTextBoxUnitInfo);
            Controls.Add(checkedListBoxUnits);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "SelectUnitFromListForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select Unit From List";
            Load += SelectUnitForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBoxUnits;
        private RichTextBox richTextBoxUnitInfo;
        private Button buttonSelect;
        private Button buttonReload;
    }
}