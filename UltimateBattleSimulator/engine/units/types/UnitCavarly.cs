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
                return this.AttackNumber * this.DefenceNumber * (this.Iniciative + this.Move);
            }
        }

        public int HorseLife { get; set; } = 0;
        public int HorseMove { get; set; } = 0;
        public int HorseDefence { get; set; } = 0;

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

        public override void Save()
        {
            var jsonSerializerOptions = new JsonSerializerOptions()
            {
                AllowTrailingCommas = true,
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(this, jsonSerializerOptions);
            string filePath = $"{DirectoryManager.Units}/{GUID}.json";
            File.WriteAllText(filePath, jsonString);
        }
    }
}
