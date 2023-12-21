using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.units.types;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.army
{
    internal class Group : IGroup
    {
        public Guid ID { get; protected set; } = Guid.NewGuid();

        public IUnit Unit { get; set; } = new UnitPrototype();
        public int Amount { get; set; } = 0;
    }
}
