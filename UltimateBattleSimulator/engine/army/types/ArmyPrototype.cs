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
        public string Name { get; set; } = "unknown";
        public string Description { get; set; } = "";
        public List<Group> Groups { get; set; } = new List<Group>();
        public ArmySide ArmySide { get; set; } = ArmySide.None;

        private IDefence? _defence = null;
        public IDefence? Defence 
        {
            get 
            {
                return _defence;
            } 
            private set 
            {
                _defence = value;
                foreach (var group in Groups)
                {
                    group.Defence = _defence;
                }
            } 
        }

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
                return Groups.Select(g => g.Amount).DefaultIfEmpty(0).Sum();
            }
        }

        public int Vitality
        {
            get
            {
                return Groups.Select( g=> g.Vitality ).DefaultIfEmpty(0).Sum();
            }
        }

        public int MinimalAmoutToFight 
        {
            get 
            {
                double armyMinimalAmoutByMorale = Amount * (0.2);
                armyMinimalAmoutByMorale = armyMinimalAmoutByMorale - (armyMinimalAmoutByMorale * MoraleBonus);
                return (int)armyMinimalAmoutByMorale;
            }
        }

        public virtual double MoraleBonus
        {
            get
            {
                int maxLevelFromGroups = 0;
                if (Groups.Count > 0) 
                {
                    maxLevelFromGroups = Groups.Select(g => (g.Unit?.Level ?? 0)).Max();
                }
                return (double)maxLevelFromGroups/IUnit.MaxLevel;
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

        public bool SetDefence(IDefence? defence) 
        {
            if( defence == null )  
            {
                this.Defence?.Dessigne(this);
                this.Defence = defence;
                return true;
            }

            if ( defence?.Assigne(this) ?? false ) 
            {
                this.Defence?.Dessigne(this);
                this.Defence = defence;

                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            return $"[{ArmySide}] | {Name} ({Force})";
        }
    }
}
