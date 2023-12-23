using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.army;
using UltimateBattleSimulator.engine.global;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.simulation
{
    internal static class Simulator
    {
        public static SimulationResult SimulationResult { get; private set; } = new SimulationResult();

        public static void Init()
        {
            SimulationResult = new SimulationResult();
        }

        public static async Task Start(CancellationToken cancellationToken, EventHandler<BattleResult> eventHandler, int nBattles = 100)
        {
            Init();

            List<Battle> battles = new List<Battle>();
            List<BattleResult> results = new List<BattleResult>();

            var armies = ArmiesManager.Instance.Get();

            for (int i = 0; i < nBattles; i++) 
            {
                var battle = new Battle(armies, EnvironmentManager.Land, EnvironmentManager.Weather);
                battle.BattleCompleted += eventHandler;

                battles.Add(battle);
            }

            try
            {
                // Start all battles and store their tasks
                var battleTasks = battles.Select(battle => battle.StartAsync(cancellationToken)).ToList();
                // Wait for all battles to complete
                results = (await Task.WhenAll(battleTasks)).ToList();

                ProcessResults(results);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
        }

        private static void ProcessResults(List<BattleResult> results) 
        {
            //Get wins ratio
            SimulationResult.AllyWins = results.Where( r => r.Winner == ArmySide.Ally ).Count();
            SimulationResult.EnemyWins = results.Where( r => r.Winner == ArmySide.Enemy ).Count();

            //Set winner
            SimulationResult.Winner = SimulationResult.AllyWins > SimulationResult.EnemyWins ? ArmySide.Ally : ArmySide.Enemy;
            if(SimulationResult.AllyWins == SimulationResult.EnemyWins) 
            {
                SimulationResult.Winner = ArmySide.None;
            }

            //Get confidence level
            SimulationResult.ConfidenceLevel = results.Where( r => r.Winner == SimulationResult.Winner ).Select( r => r.ConfidenceLevel ).Average() * 100;

            //Get rools stats
            SimulationResult.BestRoll = results.Select(d => d.Rools).SelectMany(dict => dict.Values).Max();
            SimulationResult.RoolsCount = results.Select(d => d.Rools).SelectMany(dict => dict.Values).Count();
        }
    }
}
