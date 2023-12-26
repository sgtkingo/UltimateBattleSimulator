using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UltimateBattleSimulator.engine.army;
using UltimateBattleSimulator.engine.global;
using UltimateBattleSimulator.engine.simulation.exceptions;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.simulation
{
    internal class Battle
    {
        private BattleResult battleResult = new BattleResult();

        private Dictionary<IArmy, ArmyStatus> _ArmiesStatus = new Dictionary<IArmy, ArmyStatus>();

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
            //Create shallow copy
            _ArmiesStatus = armies.ToDictionary(a => a, a => new ArmyStatus(a));

            _LandConfig = landConfig;
            _WeatherConfig = weatherConfig;
        }

        public async Task<BattleResult> StartAsync(CancellationToken cancellationToken) 
        {
            await Task.Delay(100, cancellationToken);

            var taskResult = await Task.Run<BattleResult>(() => 
            {
                try
                {
                    return Start();
                }
                catch (Exception)
                {
                    throw;
                }
            }, cancellationToken);
            // Raise the event when done
            OnBattleCompleted(taskResult);

            return taskResult;
        }

        private void Prepare()
        {
            battleResult = new BattleResult();
        }

        private BattleResult Start()
        {
            //Prepare
            Prepare();

            var ally = _ArmiesStatus.Keys.Where(army => army.ArmySide == ArmySide.Ally).ToList();
            var enemy = _ArmiesStatus.Keys.Where(army => army.ArmySide == ArmySide.Enemy).ToList();
            var none = _ArmiesStatus.Keys.Where(army => army.ArmySide == ArmySide.None).ToList();

            //Count amounts
            battleResult.TotalAmountAlly = ally.Select(a => a.Amount).Sum();
            battleResult.TotalAmountEnemy = enemy.Select(a => a.Amount).Sum();
            battleResult.TotalAmountNone = none.Select(a => a.Amount).Sum();

            //Luck Rools here
            battleResult.LuckAlly = Dice_1k100.Roll(false);
            battleResult.LuckEnemy = Dice_1k100.Roll(false);
            battleResult.LuckNone = Dice_1k100.Roll(false);

            //Automaticly split None armies by luck
            if ( battleResult.LuckAlly > battleResult.LuckEnemy ) 
            {
                ally.AddRange(none);
            }
            else 
            {
                enemy.AddRange(none);
            }

            //Init dics
            foreach ( var a in _ArmiesStatus.Keys.ToList() ) 
            {
                battleResult.Rools.Add(a, new List<int>());
                battleResult.RoolsCount.Add(a, new List<int>());
            }

            //Battle here
            foreach (var allyArmy in ally)
            {
                foreach (var enemyArmy in enemy)
                {
                    Fight(allyArmy, enemyArmy);
                }
            }

            //Summary looses
            int allyArmyAliveCount = _ArmiesStatus.Where(kv => kv.Value.Army?.ArmySide == ArmySide.Ally).Select( kv => kv.Value ).Where( v => v.Alive == true ).Count();
            int enemyArmyAliveCount = _ArmiesStatus.Where(kv => kv.Value.Army?.ArmySide == ArmySide.Enemy).Select(kv => kv.Value).Where(v => v.Alive == true).Count();

            //Get the winner
            battleResult.Winner = allyArmyAliveCount > enemyArmyAliveCount ? ArmySide.Ally : ArmySide.Enemy;
            if (allyArmyAliveCount == enemyArmyAliveCount) 
            {
                battleResult.Winner = battleResult.LuckAlly > battleResult.LuckEnemy ? ArmySide.Ally : ArmySide.Enemy;
            }

            //With confidence
            int totalSurvivals = _ArmiesStatus.Where(kv => kv.Value.Army?.ArmySide == battleResult.Winner).Select(kv => kv.Value.Amount).Sum();
            battleResult.ConfidenceLevel = battleResult.Winner == ArmySide.Ally ? ((double)totalSurvivals / battleResult.TotalAmountAlly) : ((double)totalSurvivals / battleResult.TotalAmountEnemy);

            //Calculate looses 
            foreach (var army in _ArmiesStatus.Keys) 
            {
                battleResult.Losses.Add(army, _ArmiesStatus[army].GetLooses);
            }

            //Postproccesing
            battleResult.Postproccesing();

            return battleResult;
        }

        private void Fight(IArmy ally, IArmy enemy) 
        {
            int rollAlly = 0;
            int rollEnemy = 0;
            int count = 0;

            int forceAlly = 0;
            int forceEnemy = 0;

            while (_ArmiesStatus[ally].Alive && _ArmiesStatus[enemy].Alive)
            {
                //Rools here
                //Ally
                rollAlly = Dice_1k6.RollX(_ArmiesStatus[ally].Amount);
                battleResult.Rools[ally].Add(rollAlly);
                count = Dice_1k6.GetRoolsCount(rollAlly);
                battleResult.RoolsCount[ally].Add(count);

                //Enemy
                rollEnemy = Dice_1k6.RollX(_ArmiesStatus[enemy].Amount);
                battleResult.Rools[enemy].Add(rollEnemy);
                count = Dice_1k6.GetRoolsCount(rollEnemy);
                battleResult.RoolsCount[enemy].Add(count);

                //Fight here
                forceAlly = ally.Force + rollAlly + (int)(battleResult.LuckAlly * ally.Force);
                forceEnemy = enemy.Force + rollEnemy + (int)(battleResult.LuckEnemy * enemy.Force);

                int hitAmout = 0;
                if (forceAlly > forceEnemy ) 
                {
                    hitAmout = (int)(Math.Ceiling((double)forceAlly / forceEnemy));
                    _ArmiesStatus[enemy].Amount -= hitAmout;
                    _ArmiesStatus[ally].Amount -= 1;
                }
                else 
                {
                    hitAmout = (int)(Math.Ceiling((double)forceEnemy / forceAlly));
                    _ArmiesStatus[ally].Amount -= hitAmout;
                    _ArmiesStatus[enemy].Amount -= 1;
                }
            }
        }

    }
}
