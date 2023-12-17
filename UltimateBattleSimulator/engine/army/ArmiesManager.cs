using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.army
{
    internal static class ArmiesManager
    {
        public static List<IArmy> Ally { get; private set; } = new List<IArmy>();
        public static List<IArmy> Enemy { get; private set; } = new List<IArmy>();
    }
}
