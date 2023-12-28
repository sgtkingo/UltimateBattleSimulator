using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.engine.global
{
    internal class EnvironmentConfig
    {
        public static EnvironmentConfig Empty = new EnvironmentConfig();

        public WeatherConfig Weather { get; private set; } = new WeatherConfig();
        public LandConfig Land { get; private set; } = new LandConfig();
    }
}
