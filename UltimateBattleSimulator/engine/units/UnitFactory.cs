using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.global;
using UltimateBattleSimulator.engine.units.types;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.units
{
    internal static class UnitFactory
    {
        public static IUnit? CreateUnit(UnitType type = UnitType.None)
        {
            return type switch
            {
                UnitType.None => new UnitPrototype(),
                UnitType.Infantry => new UnitInfantry(),
                UnitType.Archers => new UnitArcher(),
                UnitType.Cavalerly => new UnitCavarly(),
                _ => throw new ArgumentException("Unknown unit type")
            };
        }

        public static void SaveUnitAsJsonFile(IUnit? unit) 
        {
            unit?.Save();
        }

        public static IUnit? LoadUnitFromJsonFile(string jsonFile)
        {
            try
            {
                string jsonString = File.ReadAllText(jsonFile);
                int typeProperty = JsonDocument.Parse(jsonString).RootElement.GetProperty("UnitType").GetInt32();
                UnitType unitType = (UnitType)(typeProperty);

                return unitType switch
                {
                    UnitType.None => JsonSerializer.Deserialize<UnitPrototype>(jsonString),
                    UnitType.Infantry => JsonSerializer.Deserialize<UnitInfantry>(jsonString),
                    UnitType.Archers => JsonSerializer.Deserialize<UnitArcher>(jsonString),
                    UnitType.Cavalerly => JsonSerializer.Deserialize<UnitCavarly>(jsonString),
                    _ => throw new ArgumentException("Unknown unit type")
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
