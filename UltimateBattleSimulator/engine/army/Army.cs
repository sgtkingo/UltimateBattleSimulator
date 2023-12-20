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
        public List<IGroup> Groups { get; set; } = new List<IGroup>();

        public IDefence? Defence { get; set; }

        public int Force
        {
            get
            {
                int _force = 0;
                double _bonus = 0;
                foreach (var group in Groups)
                {
                    _bonus = Defence?.Bonus ?? 0.0; 
                    _force += (int)(group.Force * _bonus);
                }
                return _force;
            }
        }

        public override string ToString()
        {
            return $"{Name} | Force: {Force}";
        }
    }
}
