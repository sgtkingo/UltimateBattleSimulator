using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.units.types;
using UltimateBattleSimulator.engine.units;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.army.types
{
    internal class ArmyPrototype : IArmy
    {
        public Guid GUID { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<Group> Groups { get; set; } = new List<Group>();
        public ArmySide ArmySide { get; set; } = ArmySide.None;

        public IDefence? Defence { get; private set; }

        public bool IsSelected { get; set; } = true;
        public bool IsLoadedFromFile { get; set; } = false;

        public int Force
        {
            get
            {
                int _force = 0;
                double _bonus = 0.0;
                foreach (var group in Groups)
                {
                    _force = group.Force;

                    _bonus = Defence?.Bonus ?? 0.0;
                    _force += (int)(group.Force * _bonus);
                }
                return _force;
            }
        }
        public int Amount
        {
            get
            {
                int _count = 0;
                foreach (var group in Groups)
                {
                    _count += group.Amount;
                }

                return _count;
            }
        }

        public ArmyPrototype(ArmySide side = ArmySide.None)
        {
            ArmySide = side;
        }

        public ArmyPrototype(ArmyPrototype prototype)
        {
            Name = prototype.Name;
            Description = prototype.Description;
            ArmySide = prototype.ArmySide;
        }

        public virtual object Clone()
        {
            var clone = new ArmyPrototype();

            clone.ArmySide = ArmySide;

            clone.Name = Name;
            clone.Description = Description;

            return clone;
        }

        public string GetInfo()
        {
            return $"[{ArmySide}] | {Name} ({Force}) \n" +
                $"Description: {Description} \n";
        }

        public virtual void Save()
        {
            IsSelected = false;
            //TODO: add save code here
        }

        public void Delete()
        {
            //TODO: add delete code here
        }

        public void SetDefence(IDefence? defence) 
        {
            this.Defence = defence;
        }

        public override string ToString()
        {
            return $"[{ArmySide}] | {Name} ({Force})";
        }
    }
}
