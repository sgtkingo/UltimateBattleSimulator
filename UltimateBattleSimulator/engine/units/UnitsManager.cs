using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.system;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.units
{
    internal class UnitsManager : AbstractManager<IUnit>
    {
        public static UnitsManager Instance { get; private set; } = new UnitsManager();

        public override void Reload()
        {
            base.Reload();

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
                var unit = UnitFactory.LoadFromJsonFile(filePath);
                if (unit != null)
                {
                    Loaded.Add(unit);
                }
            }
        }
    }
}
