using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.army.types;
using UltimateBattleSimulator.engine.units.types;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.army
{
    internal static class ArmiesFactory
    {
        public static IArmy? Create(ArmySide side = ArmySide.None)
        {
            return new ArmyPrototype(side);
        }
    }
}
