using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.interfaces
{
    internal interface IArmy
    {
        public string Name { get; set; }
        public List<IUnit> Units { get; }
        public IDefence? Defence { get; set; }

        public int Force { get; }

        public int Amount
        {
            get
            {
                return Units.Count;
            }
        }
    }
}
