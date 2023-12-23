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
        public string Name { get; set; } = "unknown";

        private IUnit? _unit = null;
        public IUnit? Unit 
        {
            get 
            {
                return _unit;
            } 
            private set 
            {
                _unit = value;
                Name = _unit?.Name ?? Name;  
            }
        }

        public IDefence? Defence { get; set; } = null;

        private int _amount = 0;
        public int Amount 
        {
            get 
            {
                return _amount;
            }
            set 
            {
                if ( Defence?.HaveEnoughtSpace(value) ?? true )
                {
                    _amount = value;
                }
            }
        }

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
