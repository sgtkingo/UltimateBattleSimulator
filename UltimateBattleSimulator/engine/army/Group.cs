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

        public IUnit? Unit { get; private set; } = null;
        public int Amount { get; set; } = 0;

        public int Force
        {
            get
            {
                return (Unit?.Force ?? 0) * Amount;
            }
        }

        public Group() { }

        public Group(IUnit unit) 
        {
            Unit = unit;
        }

        public void SetUnit(IUnit unit) 
        {
            this.Unit = unit;
        }

        public override string ToString()
        {
            return $"{Unit} | {Amount} | {Force}";
        }
    }
}
