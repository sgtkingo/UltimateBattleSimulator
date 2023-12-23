using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.engine.global
{
    internal static class EnvironmentManager
    {
        public static WeatherConfig Weather { get; private set; } = new WeatherConfig();
        public static LandConfig Land { get; private set; } = new LandConfig();

        public static double GetPenalty() 
        {
            double penalty = Weather.GetPenalty() + Land.GetPenalty();
            if( penalty > 1.0 ) 
            {
                penalty = 1.0;
            }

            return penalty;
        }
    }
}
