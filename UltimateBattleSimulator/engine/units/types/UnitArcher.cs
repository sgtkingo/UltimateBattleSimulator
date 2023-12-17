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
                return this.AttackNumber * this.DefenceNumber * (this.Iniciative + this.Move);
            }
        }

        public int Range { get; set; } = 0;
        public int RangeAttack { get; set; } = 0;

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
