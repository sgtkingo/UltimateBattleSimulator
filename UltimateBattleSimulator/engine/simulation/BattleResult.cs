﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.simulation
{
    internal class BattleResult
    {
        public ArmySide Winner { get; set; } = ArmySide.None;
        public double ConfidenceLevel { get; set; } = 0.0;

        public Dictionary<IArmy, int> Losses { get; private set; } = new Dictionary<IArmy, int>();
        public int TotalLossesAlly { get; set; } = 0;
        public int TotalLossesEnemy { get; set; } = 0;

        public Dictionary<IArmy, int> Rools { get; private set; } = new Dictionary<IArmy, int>();
        public int BestRoolsAlly { get; set; } = 0;
        public int TotalRoolsAlly { get; set; } = 0;

        public int BestRoolsEnemy { get; set; } = 0;
        public int TotalRoolsEnemy { get; set; } = 0;

        public Dictionary<IArmy, int> RoolsCount { get; private set; } = new Dictionary<IArmy, int>();
        public int TotalRoolsCountAlly { get; set; } = 0;
        public int TotalRoolsCountEnemy { get; set; } = 0;

        public int TotalAmountAlly { get; set; } = 0;
        public int TotalAmountEnemy { get; set; } = 0;

        public int LuckAlly { get; set; } = 0;
        public int LuckEnemy { get; set; } = 0;

        public void Postproccesing()
        {
            //Get rools stats
            if (Rools.Count != 0)
            {
                this.BestRoolsAlly = Rools.Where(kv => kv.Key.ArmySide == ArmySide.Ally).Select(kv => kv.Value).Max();
                this.BestRoolsEnemy = Rools.Where(kv => kv.Key.ArmySide == ArmySide.Enemy).Select(kv => kv.Value).Max();

                this.TotalRoolsAlly = Rools.Where(kv => kv.Key.ArmySide == ArmySide.Ally).Select(kv => kv.Value).Sum();
                this.TotalRoolsEnemy = Rools.Where(kv => kv.Key.ArmySide == ArmySide.Enemy).Select(kv => kv.Value).Sum();
            }

            if (RoolsCount.Count != 0)
            {
                this.TotalRoolsCountAlly = RoolsCount.Where(kv => kv.Key.ArmySide == ArmySide.Ally).Select(kv => kv.Value).Sum();
                this.TotalRoolsCountEnemy = RoolsCount.Where(kv => kv.Key.ArmySide == ArmySide.Enemy).Select(kv => kv.Value).Sum();
            }

            //Get looses
            if (Losses.Count != 0)
            {
                this.TotalLossesAlly = Losses.Where(kv => kv.Key.ArmySide == ArmySide.Ally).Select(kv => kv.Value).Sum();
                this.TotalLossesEnemy = Losses.Where(kv => kv.Key.ArmySide == ArmySide.Enemy).Select(kv => kv.Value).Sum();
            }
        }

        public override string ToString()
        {
            return $"Winner: {Winner} ({ConfidenceLevel * 100:F2}%)";
        }
    }
}
