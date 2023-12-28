using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.units.types;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.units
{
    internal static class UnitCreator
    {
        public static Dictionary<string, IUnit> Units { get; private set; } = new Dictionary<string, IUnit>
        {
            { "Infantry", new UnitInfantry() },
            { "Archers", new UnitArcher() },
            { "Cavarly", new UnitCavarly() },
            { "Universal", new UnitPrototype() }
        };

        public static Dictionary<UnitType, string> TypesDescription { get; private set; } = new Dictionary<UnitType, string>
        {
            { UnitType.None, "Universal classic unit..." },
            { UnitType.Infantry, "Infantry, for land operations, universal soildiers..." },
            { UnitType.Cavalerly, "Heavy and fast units, for land operations and breakthrough." },
            { UnitType.Archers, "Long-range danger units, for defence and ambush." },
        };

        public static IUnit GetUnitByName(string name)
        {
            if (Units.ContainsKey(name))
            {
                return Units[name];
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public static string GetTypeDescription(UnitType type)
        {
            if (TypesDescription.ContainsKey(type))
            {
                return TypesDescription[type];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
