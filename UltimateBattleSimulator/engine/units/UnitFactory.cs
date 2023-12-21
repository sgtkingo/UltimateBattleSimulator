using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.global;
using UltimateBattleSimulator.engine.system;
using UltimateBattleSimulator.engine.units.types;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.units
{
    internal static class UnitFactory
    {
        public static IUnit? Create(UnitType type = UnitType.None)
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

        public static void SaveAsJsonFile(IUnit unit) 
        {
            var jsonSerializerOptions = new JsonSerializerOptions()
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(unit, jsonSerializerOptions);
            string filePath = $"{DirectoryManager.Units}/{unit.GUID}.json";
            File.WriteAllText(filePath, jsonString);
        }

        public static IUnit? LoadFromJsonFile(string jsonFile)
        {
            try
            {
                string jsonString = File.ReadAllText(jsonFile);
                int typeProperty = JsonDocument.Parse(jsonString).RootElement.GetProperty("UnitType").GetInt32();
                UnitType unitType = (UnitType)(typeProperty);

                IUnit? unit = unitType switch
                {
                    UnitType.None => JsonSerializer.Deserialize<UnitPrototype>(jsonString),
                    UnitType.Infantry => JsonSerializer.Deserialize<UnitInfantry>(jsonString),
                    UnitType.Archers => JsonSerializer.Deserialize<UnitArcher>(jsonString),
                    UnitType.Cavalerly => JsonSerializer.Deserialize<UnitCavarly>(jsonString),
                    _ => throw new ArgumentException("Unknown unit type")
                };
                unit?.Load();

                return unit;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeleteAsJsonFile(IUnit unit) 
        {
            string filePath = $"{DirectoryManager.Units}/{unit.GUID}.json";
            File.Delete(filePath);
        }
    }
}
