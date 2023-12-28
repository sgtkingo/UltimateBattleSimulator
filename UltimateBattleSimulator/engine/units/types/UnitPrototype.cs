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
                int force =  this.AttackNumber * this.DefenceNumber * (this.Iniciative + this.Move);
                force += (int)(force * LevelBonus);

                return force;
            }
        }

        public virtual int Vitality
        {
            get 
            {
                return Life;
            }
        }

        public double LevelBonus
        {
            get
            {
                return (double)this.Level / (IUnit.MaxLevel/2);
            }
        }

        public int AttackNumber { get; set; } = 1;
        public int DefenceNumber { get; set; } = 1;
        public int Iniciative { get; set; } = 0;
        public int Life { get; set; } = 1;
        public int Level { get; set; } = 1;
        public int Move { get; set; } = 1;

        public bool IsSelected { get; set; } = true;
        public bool IsLoadedFromFile { get; set; } = false;


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

                $"Level: {Level} \n" +
                $"Life: {Life} \n" +
                $"AttackNumber: {AttackNumber} \n" +
                $"DefenceNumber: {DefenceNumber} \n" +
                $"Iniciative: {Iniciative} \n" +
                $"Move: {Move} \n";
        }

        public virtual void Save()
        {
            this.IsSelected = false;
            UnitFactory.SaveAsJsonFile(this);
        }

        public void Delete() 
        {
            UnitFactory.DeleteAsJsonFile(this);
        }

        public override string ToString()
        {
            return $"{Name} ({Force}) | [{UnitType}]";
        }
    }
}
