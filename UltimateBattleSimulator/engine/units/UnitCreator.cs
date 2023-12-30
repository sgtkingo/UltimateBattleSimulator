using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.units.types;
using UltimateBattleSimulator.engine.units.exceptions;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.units
{
    internal static class UnitCreator
    {
        public static string[] UnitsTypeNames { get; private set; } = Enum.GetNames(typeof(UnitType));

        public static Dictionary<UnitType, string> TypesDescription { get; private set; } = new Dictionary<UnitType, string>
        {
            { UnitType.None, "Universal classic unit..." },
            { UnitType.Infantry, "Infantry, for land operations, universal soildiers..." },
            { UnitType.Cavalerly, "Heavy and fast units, for land operations and breakthrough." },
            { UnitType.Archers, "Long-range danger units, for defence and ambush." },
        };

        public static IUnit GetUnitByName(string name)
        {
            try
            {
                var unitType = (UnitType)Enum.Parse(typeof(UnitType), name);
                return UnitFactory.Create(unitType) ?? throw new UnknownUnitTypeExceptions();
            }
            catch (Exception)
            {
                throw;
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
