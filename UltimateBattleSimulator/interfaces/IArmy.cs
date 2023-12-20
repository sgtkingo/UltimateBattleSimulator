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
        public List<IGroup> Groups { get; }
        public IDefence? Defence { get; set; }

        public int Force { get; }

        public int Amount
        {
            get
            {
                int _count = 0;
                Groups.Select(g => _count+=g.Amount);

                return _count;
            }
        }
    }
}
