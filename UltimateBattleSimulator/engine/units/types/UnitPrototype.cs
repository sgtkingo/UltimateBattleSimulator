using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.system;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.units.types
{
    internal class UnitPrototype : IUnit
    {
        public Guid GUID { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "unknown";
        public string Description { get; set; } = "";
        public UnitType UnitType { get; set; } = UnitType.None;

        public virtual int Force
        {
            get
            {
                return 0;
            }
        }

        public int AttackNumber { get; set; } = 0;
        public int DefenceNumber { get; set; } = 0;
        public int Iniciative { get; set; } = 0;
        public int Life { get; set; } = 0;
        public int Level { get; set; } = 0;
        public int Move { get; set; } = 0;


        public UnitPrototype() 
        {
            UnitType = UnitType.None;
        }

        public UnitPrototype(UnitPrototype prototype)
        {
            Name = prototype.Name;
            Description = prototype.Description;
            UnitType = prototype.UnitType;
            AttackNumber = prototype.AttackNumber;
            DefenceNumber = prototype.DefenceNumber;
            Iniciative = prototype.Iniciative;
            Life = prototype.Life;
            Level = prototype.Level;
            Move = prototype.Move;
        }

        public virtual object Clone()
        {
            var clone = new UnitPrototype();

            clone.UnitType = UnitType;

            clone.Name = Name;
            clone.Description = Description;

            clone.AttackNumber = AttackNumber;
            clone.DefenceNumber = DefenceNumber;
            clone.Level = Level;
            clone.Life = Life;
            clone.Iniciative = Iniciative;
            clone.Move = Move;

            return clone;
        }

        public string GetInfo()
        {
            return $"[{UnitType}] | {Name} ({Force}) \n" +
                $"Description: {Description} \n" +

                $"Description: {Level} \n" +
                $"Description: {Life} \n" +
                $"Description: {AttackNumber} \n" +
                $"Description: {DefenceNumber} \n" +
                $"Description: {Iniciative} \n" +
                $"Description: {Move} \n";
        }

        public virtual void Save()
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

        public override string ToString()
        {
            return $"[{UnitType}] | {Name} ({Force})";
        }
    }
}
