using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.engine.global
{
    internal class WeatherConfig
    {
        public const int MaxValue = 10;

        public int Rain { get; set; } = 0;
        public int Wind { get; set; } = 0;
        public int Fog { get; set; } = 0;
        public int Snow { get; set; } = 0;

        public double GetPenalty()
        {
            return (((double)Rain / MaxValue) + ((double)Fog / MaxValue) + ((double)Wind / MaxValue) + ((double)Snow / MaxValue))/4.0;
        }
    }
}
