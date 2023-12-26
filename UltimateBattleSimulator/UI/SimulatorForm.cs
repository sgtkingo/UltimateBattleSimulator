using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBattleSimulator.engine.simulation;
using UltimateBattleSimulator.UI.forms;

namespace UltimateBattleSimulator.UI
{
    public partial class SimulatorForm : Form
    {
        CancellationTokenSource _cts = new CancellationTokenSource();

        private int maxBattles = 1;
        private int progress = 0;

        public SimulatorForm()
        {
            InitializeComponent();
        }

        private void SimulatorForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            progressBar.Value = progress = 0;
            numericUpDownBattles.Value = maxBattles;

            dataGridViewAllyStats.DataSource = bindingSourceAllyStats;
            dataGridViewEnemyStats.DataSource = bindingSourceEnemyStats;

            Simulator.Init();
        }

        private void Restart()
        {
            Simulator.Init();

            progressBar.Value = progress = 0;
            numericUpDownBattles.Value = maxBattles;

            _cts = new CancellationTokenSource();

            ShowResults();
        }

        private void OnBattleCompleteEvent(object? sender, BattleResult e)
        {
            progress++;
            int progressValue = (int)(((double)progress / maxBattles) * 100);
            if (progressValue > 100)
            {
                progressValue = 100;
            }

            progressBar.Value = progressValue;
        }

        private async Task StartSimulation()
        {
            try
            {
                await Simulator.Start(_cts.Token, OnBattleCompleteEvent, maxBattles);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Simulation STOP!");
                Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} | {ex.Source}");
                _cts.Cancel();

                await Task.Delay(100);
                Restart();
            }
        }

        private void StopSimulation()
        {
            _cts.Cancel();
        }

        private void ShowResults()
        {
            labelWinner.Text = $"{Simulator.SimulationResult.Winner} ({Simulator.SimulationResult.ConfidenceLevel:F2} %)";
            labelWins.Text = $"[{Simulator.SimulationResult.AllyWins} : {Simulator.SimulationResult.EnemyWins}]";

            //Set tracker bar
            int confidenceLevel = (int)(Simulator.SimulationResult.ConfidenceLevel);
            confidenceLevel *= Simulator.SimulationResult.Winner == interfaces.ArmySide.Ally ? -1 : 1;
            trackBarWinnerConfidence.Value = confidenceLevel;

            //Show stats
            bindingSourceAllyStats.DataSource = null;
            bindingSourceAllyStats.DataSource = Simulator.SimulationResult.AllyStats;

            bindingSourceEnemyStats.DataSource = null;
            bindingSourceEnemyStats.DataSource = Simulator.SimulationResult.EnemyStats;
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            Restart();

            buttonStart.Enabled = false;
            await StartSimulation();

            buttonStart.Enabled = true;
            ShowResults();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            StopSimulation();
        }

        private void numericUpDownBattles_ValueChanged(object sender, EventArgs e)
        {
            maxBattles = (int)numericUpDownBattles.Value;
        }

        private void buttonShowDetailedResults_Click(object sender, EventArgs e)
        {
            var form = new ShowSimulationResults();
            form.SetObject(Simulator.SimulationResult);

            form.ShowDialog(this);
        }
    }
}
