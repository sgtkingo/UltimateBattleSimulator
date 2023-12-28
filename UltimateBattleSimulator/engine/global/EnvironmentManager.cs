using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.engine.global
{
    internal static class EnvironmentManager
    {
        public static bool UseEnvironmentConfig { get; set; } = true;
        public static EnvironmentConfig EnvironmentConfig { get; set; } = new EnvironmentConfig();

        public static EnvironmentConfig GetUsedEnvironment 
        {
            get 
            {
                return UseEnvironmentConfig ? EnvironmentConfig : EnvironmentConfig.Empty;
            }
        }
    }
}
