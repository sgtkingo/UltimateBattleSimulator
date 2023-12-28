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
    internal class UnitInfantry : UnitPrototype
    {
        public override int Force
        {
            get
            {
                return base.Force;
            }
        }

        public UnitInfantry()
        {
            UnitType = UnitType.Infantry;
        }

        public UnitInfantry(UnitPrototype prototype) : base(prototype)
        {
            UnitType = UnitType.Infantry;
        }

        public override object Clone()
        {
            var prototype = (UnitPrototype)base.Clone();
            var clone = new UnitInfantry(prototype);

            return clone;
        }
    }
}
