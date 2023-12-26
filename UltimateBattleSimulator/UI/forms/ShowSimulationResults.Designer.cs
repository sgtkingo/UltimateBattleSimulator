namespace UltimateBattleSimulator.UI.forms
{
    partial class ShowSimulationResults
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
            SuspendLayout();
            // 
            // propertyGrid
            // 
            propertyGrid.Dock = DockStyle.Fill;
            propertyGrid.Location = new Point(0, 0);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new Size(591, 548);
            propertyGrid.TabIndex = 0;
            // 
            // ShowSimulationResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 548);
            Controls.Add(propertyGrid);
            Name = "ShowSimulationResults";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Simulation Results";
            Load += ShowSimulationResults_Load;
            ResumeLayout(false);
        }

        #endregion

        private PropertyGrid propertyGrid;
    }
}