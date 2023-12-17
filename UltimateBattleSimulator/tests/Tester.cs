using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.system;
using UltimateBattleSimulator.engine.units;

namespace UltimateBattleSimulator.tests
{
    internal class Tester
    {
        public static void UnitsTest(int count = 1) 
        {
            var unit = UnitFactory.CreateUnit(interfaces.UnitType.Cavalerly);
            Console.WriteLine(unit);
            //unit.Save();


            string fn = $"{DirectoryManager.Units}/2e5aada7-d57b-470d-92d2-a348920c4a27.json";
            var desUnit = UnitFactory.LoadUnitFromJsonFile(fn);
            Console.WriteLine(desUnit); 
        }
    }
}
