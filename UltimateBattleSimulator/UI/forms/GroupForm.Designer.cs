namespace UltimateBattleSimulator.UI.forms
{
    partial class GroupForm
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
            groupBoxUnit = new GroupBox();
            buttonSetUnit = new Button();
            richTextBoxUnit = new RichTextBox();
            groupBoxUnit.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(198, 386);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(202, 42);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save changes";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // propertyGrid
            // 
            propertyGrid.Location = new Point(12, 172);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new Size(388, 208);
            propertyGrid.TabIndex = 1;
            // 
            // groupBoxUnit
            // 
            groupBoxUnit.Controls.Add(buttonSetUnit);
            groupBoxUnit.Controls.Add(richTextBoxUnit);
            groupBoxUnit.Location = new Point(12, 12);
            groupBoxUnit.Name = "groupBoxUnit";
            groupBoxUnit.Size = new Size(379, 154);
            groupBoxUnit.TabIndex = 2;
            groupBoxUnit.TabStop = false;
            groupBoxUnit.Text = "Unit";
            // 
            // buttonSetUnit
            // 
            buttonSetUnit.BackgroundImageLayout = ImageLayout.Center;
            buttonSetUnit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSetUnit.Location = new Point(213, 117);
            buttonSetUnit.Name = "buttonSetUnit";
            buttonSetUnit.Size = new Size(160, 23);
            buttonSetUnit.TabIndex = 1;
            buttonSetUnit.Text = "Change unit";
            buttonSetUnit.UseVisualStyleBackColor = true;
            buttonSetUnit.Click += buttonSetUnit_Click;
            // 
            // richTextBoxUnit
            // 
            richTextBoxUnit.Location = new Point(6, 22);
            richTextBoxUnit.Name = "richTextBoxUnit";
            richTextBoxUnit.ReadOnly = true;
            richTextBoxUnit.Size = new Size(367, 89);
            richTextBoxUnit.TabIndex = 0;
            richTextBoxUnit.Text = "";
            // 
            // GroupForm
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 440);
            Controls.Add(groupBoxUnit);
            Controls.Add(propertyGrid);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "GroupForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Group";
            Load += GroupForm_Load;
            groupBoxUnit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private PropertyGrid propertyGrid;
        private GroupBox groupBoxUnit;
        private RichTextBox richTextBoxUnit;
        private Button buttonSetUnit;
    }
}