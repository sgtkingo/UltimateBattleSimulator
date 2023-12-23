using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.engine.global
{
    internal class LandConfig
    {
        public const int MaxValue = 10;

        public int Terain { get; set; } = 0;
        public int RiversAndLakes { get; set; } = 0;
        public int Swamps { get; set; } = 0;

        public double GetPenalty()
        { 
            return (((double)Terain/MaxValue) + ((double)RiversAndLakes/MaxValue) + ((double)Swamps/MaxValue))/3.0;
        }
    }
}
