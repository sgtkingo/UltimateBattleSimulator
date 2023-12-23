using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UltimateBattleSimulator.engine.global;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.simulation
{
    internal class Battle
    {
        private List<IArmy> _Armies = new List<IArmy>();

        private LandConfig _LandConfig;
        private WeatherConfig _WeatherConfig;

        private Dice Dice_1k6 = new Dice(6);
        private Dice Dice_1k10 = new Dice(10);
        private Dice Dice_1k100 = new Dice(100);

        // Define an event
        public event EventHandler<BattleResult> BattleCompleted;
        protected virtual void OnBattleCompleted(BattleResult result)
        {
            BattleCompleted?.Invoke(this, result);
        }

        public Battle(List<IArmy> armies, LandConfig landConfig, WeatherConfig weatherConfig) 
        {
            _Armies = armies;
            _LandConfig = landConfig;
            _WeatherConfig = weatherConfig;
        }

        public async Task<BattleResult> StartAsync(CancellationToken cancellationToken) 
        {
            await Task.Delay(Random.Shared.Next(2500), cancellationToken);

            var taskResult = await Task.Run<BattleResult>(() => 
            {
                return Start();
            }, cancellationToken);
            // Raise the event when done
            OnBattleCompleted(taskResult);

            return taskResult;
        }

        private BattleResult Start()
        {
            //Prepare
            BattleResult battleResult = new BattleResult();
            var ally = _Armies.Where(army => army.ArmySide == ArmySide.Ally).ToList();
            var enemy = _Armies.Where(army => army.ArmySide == ArmySide.Enemy).ToList();

            int roll  =  0;
            foreach (var army in _Armies)
            {
                battleResult.Losses.Add(army, 0);

                roll = Dice_1k6.Roll();
                battleResult.Rools.Add(army, roll);
            }

            //Battle here
            battleResult.LuckAlly = Dice_1k100.Roll();
            battleResult.LuckEnemy = Dice_1k100.Roll();

            battleResult.ConfidenceLevel = Random.Shared.NextDouble();

            if (Dice_1k6.Roll() > 2)
            {
                battleResult.Winner = ArmySide.Ally;
            }
            else 
            {
                battleResult.Winner = ArmySide.Enemy;
            }

            return battleResult;
        }

    }
}
