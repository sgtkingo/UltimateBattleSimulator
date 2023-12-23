using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.interfaces
{
    internal interface IGroup
    {
        public Guid ID { get; }

        public string Name { get; set; }

        IUnit? Unit { get; }
        public IDefence? Defence { get; }

        public int Amount { get; set; }

        public int Force { get; }
    }
}
