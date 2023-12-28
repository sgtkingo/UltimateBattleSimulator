using System;
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
        public int TotalLossesNone { get; set; } = 0;

        public Dictionary<IArmy, int> Survivals { get; private set; } = new Dictionary<IArmy, int>();
        public int TotalSurvivalsAlly { get; set; } = 0;
        public int TotalSurvivalsEnemy { get; set; } = 0;
        public int TotalSurvivalsNone { get; set; } = 0;

        public Dictionary<IArmy, List<int>> Rools { get; private set; } = new Dictionary<IArmy, List<int>>();
        public int BestRoolsAlly { get; set; } = 0;
        public int TotalRoolsAlly { get; set; } = 0;

        public int BestRoolsEnemy { get; set; } = 0;
        public int TotalRoolsEnemy { get; set; } = 0;

        public int BestRoolsNone { get; set; } = 0;
        public int TotalRoolsNone { get; set; } = 0;

        public Dictionary<IArmy, List<int>> RoolsCount { get; private set; } = new Dictionary<IArmy, List<int>>();
        public int TotalRoolsCountAlly { get; set; } = 0;
        public int TotalRoolsCountEnemy { get; set; } = 0;
        public int TotalRoolsCountNone { get; set; } = 0;

        public int TotalAmountAlly { get; set; } = 0;
        public int TotalAmountEnemy { get; set; } = 0;
        public int TotalAmountNone { get; set; } = 0;

        public int LuckAlly { get; set; } = 0;
        public int LuckEnemy { get; set; } = 0;
        public int LuckNone { get; set; } = 0;

        public void Postproccesing()
        {
            //Get rools stats
            this.BestRoolsAlly = Rools.Where(kv => kv.Key.ArmySide == ArmySide.Ally).SelectMany(kv => kv.Value).DefaultIfEmpty(0).Max();
            this.BestRoolsEnemy = Rools.Where(kv => kv.Key.ArmySide == ArmySide.Enemy).SelectMany(kv => kv.Value).DefaultIfEmpty(0).Max();

            this.TotalRoolsAlly = Rools.Where(kv => kv.Key.ArmySide == ArmySide.Ally).SelectMany(kv => kv.Value).DefaultIfEmpty(0).Sum();
            this.TotalRoolsEnemy = Rools.Where(kv => kv.Key.ArmySide == ArmySide.Enemy).SelectMany(kv => kv.Value).DefaultIfEmpty(0).Sum();

            this.TotalRoolsCountAlly = RoolsCount.Where(kv => kv.Key.ArmySide == ArmySide.Ally).SelectMany(kv => kv.Value).DefaultIfEmpty(0).Sum();
            this.TotalRoolsCountEnemy = RoolsCount.Where(kv => kv.Key.ArmySide == ArmySide.Enemy).SelectMany(kv => kv.Value).DefaultIfEmpty(0).Sum();

            //Get looses
            this.TotalLossesAlly = Losses.Where(kv => kv.Key.ArmySide == ArmySide.Ally).Select(kv => kv.Value).DefaultIfEmpty(0).Sum();
            this.TotalLossesEnemy = Losses.Where(kv => kv.Key.ArmySide == ArmySide.Enemy).Select(kv => kv.Value).DefaultIfEmpty(0).Sum();

            //Get survivals
            this.TotalSurvivalsAlly = Survivals.Where(kv => kv.Key.ArmySide == ArmySide.Ally).Select(kv => kv.Value).DefaultIfEmpty(0).Sum();
            this.TotalSurvivalsEnemy = Survivals.Where(kv => kv.Key.ArmySide == ArmySide.Enemy).Select(kv => kv.Value).DefaultIfEmpty(0).Sum();
        }

        public override string ToString()
        {
            return $"Winner: {Winner} ({ConfidenceLevel * 100:F2}%)";
        }
    }
}
