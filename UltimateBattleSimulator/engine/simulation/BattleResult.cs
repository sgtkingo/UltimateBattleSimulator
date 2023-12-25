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

        public Dictionary<IArmy, int> Losses = new Dictionary<IArmy, int>();
        public Dictionary<IArmy, int> Rools = new Dictionary<IArmy, int>();

        public int TotalAmountAlly { get; set; } = 0;
        public int TotalAmountEnemy { get; set; } = 0;

        public int LuckAlly { get; set; } = 0;
        public int LuckEnemy { get; set; } = 0;

        public override string ToString()
        {
            return $"Winner: {Winner} ({ConfidenceLevel*100:F2}%)";
        }
    }
}
