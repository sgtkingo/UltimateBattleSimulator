using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.system;
using UltimateBattleSimulator.engine.units;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.army
{
    internal class ArmiesManager : AbstractManager<IArmy>
    {
        public static ArmiesManager Instance { get; private set; } = new ArmiesManager();
    }
}
