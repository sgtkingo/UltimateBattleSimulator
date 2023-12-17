using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.engine.system
{
    internal static class DirectoryManager
    {
        public static string Global { get; private set; } = @"./global";
        public static string Units { get; private set; } = @"./units";
        public static string Simulations { get; private set; } = @"./simulations";

        public static void InitDirectories()
        {
            //Initialize (create) all dirs
            try
            {
                Directory.CreateDirectory(Global);
                Directory.CreateDirectory(Units);
                Directory.CreateDirectory(Simulations);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
