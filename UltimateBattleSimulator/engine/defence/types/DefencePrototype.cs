using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.army.types;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.defence.types
{
    internal class DefencePrototype : IDefence
    {

        public Guid GUID { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "unknown";
        public string Description { get; set; } = "";
        public Size3D Size { get; private set; } = new Size3D(0, 0, 0);

        public bool IsSelected { get; set; } = true;
        public bool IsLoadedFromFile { get; set; } = false;


        private int _mainForce = 0;
        public int MainForce 
        {
            get 
            {
                return _mainForce;
            }
            set 
            {
                if( value > IDefence.MaxMainDefenceForce ) 
                {
                    value = IDefence.MaxMainDefenceForce;
                }
                _mainForce = value;
            }
        }

        private int _seconadaryForce = 0;
        public int SecondaryForce
        {
            get
            {
                return _seconadaryForce;
            }
            set
            {
                if (value > IDefence.MaxSecondaryDefenceForce)
                {
                    value = IDefence.MaxSecondaryDefenceForce;
                }
                _seconadaryForce = value;
            }
        }

        public int Force
        {
            get
            {
                return MainForce + SecondaryForce;
            }
        }

        public double Bonus
        {
            get
            {
                return (double)Force / (double)IDefence.MaxDefenceForceForBonus;
            }
        }

        public double RealBonus
        {
            get
            {
                double bonusDeviator = (((double)(MaxCapacity - FreeSpace) / (double)(MaxCapacity + 1)) + 0.1);
                if (bonusDeviator > 1.0) 
                {
                    bonusDeviator = 1.0;
                }

                return Bonus * bonusDeviator;
            }
        }

        public int MaxCapacity
        {
            get
            {
                return Size.Total;
            }
        }

        public int FreeSpace
        {
            get
            {
                int _soilders = 0;
                foreach (var army in AssignedArmies)
                {
                    _soilders += army.Amount;
                }
                this.Size = new Size3D(this.Size, _soilders);

                return MaxCapacity - _soilders;
            }
        }

        public List<IArmy> AssignedArmies { get; protected set; } = new List<IArmy>();

        public bool HaveEnoughtSpace(IArmy army) 
        {
            return HaveEnoughtSpace(army.Amount);
        }

        public bool HaveEnoughtSpace(int amount)
        {
            return amount <= FreeSpace;
        }

        public bool Assigne(IArmy army)
        {
            if (HaveEnoughtSpace(army))
            {
                AssignedArmies.Add(army);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Dessigne(IArmy army)
        {
            AssignedArmies.Remove(army);
        }

        
        public DefencePrototype() { }

        public DefencePrototype(DefencePrototype prototype)
        {
            Name = prototype.Name;
            Description = prototype.Description;
            Size = prototype.Size;

            MainForce = prototype.MainForce;
            SecondaryForce = prototype.SecondaryForce;
        }

        public virtual object Clone()
        {
            var clone = new DefencePrototype(this);
            return clone;
        }

        public string GetInfo()
        {
            return $"{Name} | [{MaxCapacity-FreeSpace}/{MaxCapacity}] ({Force}) \n" +
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

        public override string ToString()
        {
            return $"{Name} | [{FreeSpace}/{MaxCapacity}] ({Force})";
        }
    }
}
