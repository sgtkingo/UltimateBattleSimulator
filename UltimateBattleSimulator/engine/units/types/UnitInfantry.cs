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
                return this.AttackNumber * this.DefenceNumber * (this.Iniciative + this.Move);
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
