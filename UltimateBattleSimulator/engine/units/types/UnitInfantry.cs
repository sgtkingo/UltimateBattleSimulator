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
        }

        public UnitInfantry(UnitPrototype prototype) : base(prototype)
        {
        }

        protected override void SetDefault()
        {
            UnitType = UnitType.Infantry;

            SanctionDefence = 0.5;
            SanctionWeather = -0.25;
            SanctionLand = -0.25;
        }

        public override object Clone()
        {
            var prototype = (UnitPrototype)base.Clone();
            var clone = new UnitInfantry(prototype);

            return clone;
        }
    }
}
