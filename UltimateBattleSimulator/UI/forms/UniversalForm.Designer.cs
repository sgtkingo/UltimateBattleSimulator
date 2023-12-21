namespace UltimateBattleSimulator.UI.forms
{
    partial class UniversalForm
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
            propertyGrid = new PropertyGrid();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // propertyGrid
            // 
            propertyGrid.Location = new Point(12, 12);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new Size(438, 443);
            propertyGrid.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(314, 461);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(136, 30);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save changes";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // UniversalForm
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 499);
            Controls.Add(buttonSave);
            Controls.Add(propertyGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UniversalForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Universal Form";
            Load += UniversalForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private PropertyGrid propertyGrid;
        private Button buttonSave;
    }
}