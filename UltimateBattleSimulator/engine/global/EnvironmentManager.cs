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
    }
}
