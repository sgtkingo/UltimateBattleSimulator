using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.system;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.units
{
    internal static class UnitsManager
    {
        public static List<IUnit> TempUnits { get; private set; } = new List<IUnit>();

        public static List<IUnit> Units { get; private set; } = new List<IUnit>();

        public async static Task ReloadAsync()
        {
            await Task.Run(() => 
            {
                Reload();
            });
        }

        public static void Reload() 
        {
            Units.Clear();
            string directoryPath = DirectoryManager.Units;

            // Check if the directory exists
            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("Directory does not exist.");
                return;
            }

            // Get all file paths
            string[] filePaths = Directory.GetFiles(directoryPath);

            // Process each file path
            foreach (var filePath in filePaths)
            {
                var unit = UnitFactory.LoadUnitFromJsonFile(filePath);
                if (unit != null) 
                {
                    Units.Add(unit);
                }
            }
        }

        public static IUnit? Find(string text) 
        {
            return Units.Find(unit =>  unit?.ToString()?.Contains(text) ?? false); 
        }

        public static void Save(IUnit unit)
        {
            UnitFactory.SaveUnitAsJsonFile(unit);
        }

        public static void SaveAll(List<IUnit> units) 
        {
            foreach (var unit in units) 
            {
                UnitFactory.SaveUnitAsJsonFile(unit);
            }
        }
    }
}
