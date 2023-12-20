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

        public static List<IUnit> LoadedUnits { get; private set; } = new List<IUnit>();

        public static List<IUnit> GetUnits()
        {
            var units = new List<IUnit>();
            units.AddRange(LoadedUnits);
            units.AddRange(TempUnits);

            TempUnits = units;

            return TempUnits;
        }

        public static void Reload()
        {
            LoadedUnits.Clear();
            TempUnits.Clear();

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
                    LoadedUnits.Add(unit);
                }
            }
        }

        public static IUnit? Find(string text)
        {
            return LoadedUnits.Find(unit => unit?.ToString()?.Contains(text) ?? false);
        }

        public static void Save(IUnit unit)
        {
            unit.Save();
        }

        public static void SaveAll()
        {
            foreach (var unit in TempUnits)
            {
                unit.Save();
            }
        }

        public static void Delete(IUnit unit, bool permanent = false)
        {
            TempUnits.Remove(unit);
            if (permanent)
            {
                unit.Delete();
            }
        }

        public static void DeleteAll()
        {
            foreach (var unit in TempUnits)
            {
                unit.Delete();
            }

            TempUnits.Clear();
        }
    }
}
