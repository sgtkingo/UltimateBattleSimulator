namespace UltimateBattleSimulator.UI.forms
{
    partial class UnitForm
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
            propertyGrid.Size = new Size(443, 577);
            propertyGrid.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(273, 595);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(182, 36);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save changes";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // UnitForm
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 643);
            Controls.Add(buttonSave);
            Controls.Add(propertyGrid);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UnitForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Unit";
            Load += UnitForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private PropertyGrid propertyGrid;
        private Button buttonSave;
    }
}