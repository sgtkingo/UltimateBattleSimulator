using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.system;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.units.types
{
    internal class UnitArcher : UnitPrototype
    {
        public override int Force
        {
            get
            {
                int force = base.Force;
                force += (this.RangeAttack * 2 * (int)((double)this.Range / 50));

                return force;
            }
        }

        public int Range { get; set; } = 1;
        public int RangeAttack { get; set; } = 1;

        public UnitArcher() : base()
        {
            UnitType = UnitType.Archers;
        }

        public UnitArcher(UnitPrototype prototype) : base(prototype)
        {
            UnitType = UnitType.Archers;
        }

        public override object Clone()
        {
            var prototype = (UnitPrototype)base.Clone();
            var clone = new UnitArcher(prototype);
            clone.Range = Range;

            return clone;
        }
    }
}
