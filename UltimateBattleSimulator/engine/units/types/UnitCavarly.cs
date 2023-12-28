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
    internal class UnitCavarly : UnitPrototype
    {
        public override int Force
        {
            get
            {
                int force = base.Force;
                force += (this.AttackNumber * (this.HorseMove/this.HorseDefence));

                return force;
            }
        }

        public override int Vitality
        {
            get
            {
                return base.Vitality + this.HorseLife;
            }
        }

        public int HorseLife { get; set; } = 1;
        public int HorseMove { get; set; } = 1;
        public int HorseDefence { get; set; } = 1;

        public UnitCavarly() : base() 
        {
            UnitType = UnitType.Cavalerly;
        }

        public UnitCavarly(UnitPrototype prototype) : base(prototype)
        {
            UnitType = UnitType.Cavalerly;
        }

        public override object Clone()
        {
            var prototype = (UnitPrototype)base.Clone();
            var clone = new UnitCavarly(prototype);
            clone.HorseDefence = this.HorseDefence;
            clone.HorseLife = this.HorseLife;
            clone.HorseMove = this.HorseMove;

            return clone;
        }
    }
}
