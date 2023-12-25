using System;
using System.Collections;
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
            Dictionary<IArmy, int> amounts = armies.ToDictionary(army => army, army => army.Amount);

            for (int i = 0; i < nBattles; i++) 
            {
                var battle = new Battle(armies, amounts, EnvironmentManager.Land, EnvironmentManager.Weather);
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
            SimulationResult.CalculateStats(results);
            SimulationResult.FillStats();
        }
    }
}
