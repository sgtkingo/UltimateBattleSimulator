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

        private Dice Dice_1k6 = new Dice(6);
        private Dice Dice_1k10 = new Dice(10);
        private Dice Dice_1k100 = new Dice(100);

        // Define an event
        public event EventHandler<BattleResult> BattleCompleted;
        protected virtual void OnBattleCompleted(BattleResult result)
        {
            BattleCompleted?.Invoke(this, result);
        }

        public Battle(List<IArmy> armies) 
        {
            //Create shallow copy
            _ArmiesStatus = armies.ToDictionary(a => a, a => new ArmyStatus(a));
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
            if( battleResult.ConfidenceLevel == 0) 
            {
                battleResult.Winner = ArmySide.None;
            }

            //Calculate looses 
            foreach (var army in _ArmiesStatus.Keys) 
            {
                battleResult.Losses.Add(army, _ArmiesStatus[army].GetLooses);
                battleResult.Survivals.Add(army, _ArmiesStatus[army].Amount);
            }

            //Postproccesing
            battleResult.Postproccesing();

            return battleResult;
        }

        private void Fight(IArmy ally, IArmy enemy) 
        {
            int rollAlly = 0;
            int rollEnemy = 0;

            int roll = 0;
            int count = 0;

            int forceAlly = 0;
            int forceEnemy = 0;

            while (_ArmiesStatus[ally].Alive && _ArmiesStatus[enemy].Alive)
            {
                //Rools here
                //Ally
                for (int i = 0; i < _ArmiesStatus[ally].Amount; i++)
                {
                    roll = Dice_1k6.Roll();
                    count = Dice_1k6.GetRoolsCount(roll);

                    battleResult.Rools[ally].Add(roll);
                    battleResult.RoolsCount[ally].Add(count);

                    rollAlly += roll;
                }

                //Enemy
                for (int i = 0; i < _ArmiesStatus[enemy].Amount; i++)
                {
                    roll = Dice_1k6.Roll();
                    count = Dice_1k6.GetRoolsCount(roll);

                    battleResult.Rools[enemy].Add(roll);
                    battleResult.RoolsCount[enemy].Add(count);

                    rollEnemy += roll;
                }

                //Fight here
                forceAlly = ally.Force + rollAlly;
                forceAlly += (int)(((double)battleResult.LuckAlly/100) * forceAlly);

                forceEnemy = enemy.Force + rollEnemy;
                forceEnemy += (int)(((double)battleResult.LuckEnemy / 100) * forceEnemy);

                //Hit calc
                double amountDiv = 0.0;

                amountDiv = (double)_ArmiesStatus[ally].Amount / _ArmiesStatus[enemy].Amount;
                int allyHit = Hit(forceAlly, forceEnemy, amountDiv);

                amountDiv = (double)_ArmiesStatus[enemy].Amount / _ArmiesStatus[ally].Amount;
                int enemyHit = Hit(forceEnemy, forceAlly, amountDiv);

                _ArmiesStatus[ally].Hit(enemyHit);
                _ArmiesStatus[enemy].Hit(allyHit);
            }
        }

        private int Hit(int f1, int f2, double amountDiv)
        {
            double forceDiv = 0.0;

            if( amountDiv < 0.1)
            {
                amountDiv = 0.1; 
            }

            if( amountDiv < 1.0) 
            {
                forceDiv = (double)f1 / (f2*amountDiv);
            }
            else 
            {
                forceDiv = (double)f1 / f2;
            }

            int hit = (int)(100 * forceDiv);

            return hit;
        }

    }
}
