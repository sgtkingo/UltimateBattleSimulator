using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.army
{
    internal class Army : IArmy
    {
        public string Name { get; set; } = "";
        public List<IUnit> Units { get; set; } = new List<IUnit>();

        public IDefence? Defence { get; set; }

        public int Force
        {
            get
            {
                int _force = 0;
                int _bonus = 0;
                foreach (var unit in Units)
                {
                    _bonus = Defence?.Force ?? 0; 
                    _force += unit.Force + _bonus;
                }
                return _force;
            }
        }
    }
}
