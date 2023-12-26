namespace UltimateBattleSimulator.UI
{
    partial class SimulatorForm
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
            buttonStart = new Button();
            buttonStop = new Button();
            progressBar = new ProgressBar();
            labelWinner = new Label();
            groupBoxAllyStats = new GroupBox();
            dataGridViewAllyStats = new DataGridView();
            groupBoxEnemyStats = new GroupBox();
            dataGridViewEnemyStats = new DataGridView();
            labelStatus = new Label();
            numericUpDownBattles = new NumericUpDown();
            trackBarWinnerConfidence = new TrackBar();
            labelWins = new Label();
            bindingSourceAllyStats = new BindingSource(components);
            bindingSourceEnemyStats = new BindingSource(components);
            labelBattles = new Label();
            buttonShowDetailedResults = new Button();
            groupBoxAllyStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllyStats).BeginInit();
            groupBoxEnemyStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnemyStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBattles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarWinnerConfidence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAllyStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEnemyStats).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.HotTrack;
            buttonStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonStart.Location = new Point(318, 483);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(255, 58);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = SystemColors.ControlLightLight;
            buttonStop.Location = new Point(579, 483);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(113, 58);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "STOP";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 12);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(678, 44);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 2;
            // 
            // labelWinner
            // 
            labelWinner.AutoSize = true;
            labelWinner.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelWinner.Location = new Point(227, 293);
            labelWinner.Name = "labelWinner";
            labelWinner.Size = new Size(37, 50);
            labelWinner.TabIndex = 3;
            labelWinner.Text = "-";
            labelWinner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxAllyStats
            // 
            groupBoxAllyStats.Controls.Add(dataGridViewAllyStats);
            groupBoxAllyStats.Location = new Point(12, 75);
            groupBoxAllyStats.Name = "groupBoxAllyStats";
            groupBoxAllyStats.Size = new Size(316, 195);
            groupBoxAllyStats.TabIndex = 4;
            groupBoxAllyStats.TabStop = false;
            groupBoxAllyStats.Text = "Ally stats";
            // 
            // dataGridViewAllyStats
            // 
            dataGridViewAllyStats.AllowUserToAddRows = false;
            dataGridViewAllyStats.AllowUserToDeleteRows = false;
            dataGridViewAllyStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllyStats.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewAllyStats.Location = new Point(6, 22);
            dataGridViewAllyStats.MultiSelect = false;
            dataGridViewAllyStats.Name = "dataGridViewAllyStats";
            dataGridViewAllyStats.ReadOnly = true;
            dataGridViewAllyStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAllyStats.Size = new Size(304, 167);
            dataGridViewAllyStats.TabIndex = 0;
            // 
            // groupBoxEnemyStats
            // 
            groupBoxEnemyStats.Controls.Add(dataGridViewEnemyStats);
            groupBoxEnemyStats.Location = new Point(371, 75);
            groupBoxEnemyStats.Name = "groupBoxEnemyStats";
            groupBoxEnemyStats.Size = new Size(316, 195);
            groupBoxEnemyStats.TabIndex = 5;
            groupBoxEnemyStats.TabStop = false;
            groupBoxEnemyStats.Text = "Enemy stats";
            // 
            // dataGridViewEnemyStats
            // 
            dataGridViewEnemyStats.AllowUserToAddRows = false;
            dataGridViewEnemyStats.AllowUserToDeleteRows = false;
            dataGridViewEnemyStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnemyStats.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewEnemyStats.Location = new Point(6, 22);
            dataGridViewEnemyStats.MultiSelect = false;
            dataGridViewEnemyStats.Name = "dataGridViewEnemyStats";
            dataGridViewEnemyStats.ReadOnly = true;
            dataGridViewEnemyStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEnemyStats.Size = new Size(304, 167);
            dataGridViewEnemyStats.TabIndex = 6;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(328, 27);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(43, 15);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "READY";
            // 
            // numericUpDownBattles
            // 
            numericUpDownBattles.Location = new Point(192, 518);
            numericUpDownBattles.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownBattles.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBattles.Name = "numericUpDownBattles";
            numericUpDownBattles.Size = new Size(120, 23);
            numericUpDownBattles.TabIndex = 7;
            numericUpDownBattles.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBattles.ValueChanged += numericUpDownBattles_ValueChanged;
            // 
            // trackBarWinnerConfidence
            // 
            trackBarWinnerConfidence.Enabled = false;
            trackBarWinnerConfidence.LargeChange = 10;
            trackBarWinnerConfidence.Location = new Point(12, 420);
            trackBarWinnerConfidence.Maximum = 100;
            trackBarWinnerConfidence.Minimum = -100;
            trackBarWinnerConfidence.Name = "trackBarWinnerConfidence";
            trackBarWinnerConfidence.Size = new Size(669, 45);
            trackBarWinnerConfidence.TabIndex = 8;
            // 
            // labelWins
            // 
            labelWins.AutoSize = true;
            labelWins.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelWins.Location = new Point(328, 349);
            labelWins.Name = "labelWins";
            labelWins.Size = new Size(37, 50);
            labelWins.TabIndex = 9;
            labelWins.Text = "-";
            labelWins.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBattles
            // 
            labelBattles.AutoSize = true;
            labelBattles.Location = new Point(192, 500);
            labelBattles.Name = "labelBattles";
            labelBattles.Size = new Size(45, 15);
            labelBattles.TabIndex = 10;
            labelBattles.Text = "Battles:";
            // 
            // buttonShowDetailedResults
            // 
            buttonShowDetailedResults.Location = new Point(18, 471);
            buttonShowDetailedResults.Name = "buttonShowDetailedResults";
            buttonShowDetailedResults.Size = new Size(75, 70);
            buttonShowDetailedResults.TabIndex = 11;
            buttonShowDetailedResults.Text = "DETAIL";
            buttonShowDetailedResults.UseVisualStyleBackColor = true;
            buttonShowDetailedResults.Click += buttonShowDetailedResults_Click;
            // 
            // SimulatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 553);
            Controls.Add(buttonShowDetailedResults);
            Controls.Add(labelBattles);
            Controls.Add(labelWins);
            Controls.Add(trackBarWinnerConfidence);
            Controls.Add(numericUpDownBattles);
            Controls.Add(labelStatus);
            Controls.Add(groupBoxEnemyStats);
            Controls.Add(groupBoxAllyStats);
            Controls.Add(labelWinner);
            Controls.Add(progressBar);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SimulatorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Simulator";
            Load += SimulatorForm_Load;
            groupBoxAllyStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllyStats).EndInit();
            groupBoxEnemyStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnemyStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBattles).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarWinnerConfidence).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAllyStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEnemyStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private ProgressBar progressBar;
        private Label labelWinner;
        private GroupBox groupBoxAllyStats;
        private GroupBox groupBoxEnemyStats;
        private DataGridView dataGridViewAllyStats;
        private DataGridView dataGridViewEnemyStats;
        private Label labelStatus;
        private NumericUpDown numericUpDownBattles;
        private TrackBar trackBarWinnerConfidence;
        private Label labelWins;
        private BindingSource bindingSourceAllyStats;
        private BindingSource bindingSourceEnemyStats;
        private Label labelBattles;
        private Button buttonShowDetailedResults;
    }
}