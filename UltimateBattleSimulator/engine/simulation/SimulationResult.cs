using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.simulation
{
    internal class SimulationResult
    {
        public ArmySide Winner { get; set; } = ArmySide.None;
        public double ConfidenceLevel { get; set; } = 0.0;

        public int AllyWins { get; set;  } = 0;
        public int EnemyWins { get; set; } = 0;

        public int BestRoll { get; set; } = 0;
        public int RoolsCount { get; set; } = 0;

        //TODO: Add looses tables + stats
    }
}
