﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.interfaces
{
    internal interface IDefence
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Size3D Size { get; set; }

        public int MainForce { get; set; }
        public int SecondaryForce { get; set; }

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
                return Force/20.0; 
            }
        }

        public int MaxCapacity 
        {
            get 
            {
                return (int)(Size.Width * Size.Height * Size.Depth);
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
                return MaxCapacity - _soilders;
            }
        }

        public List<IArmy> AssignedArmies { get; }

        public bool Assigne(IArmy army)
        {
            if( army.Amount <= FreeSpace ) 
            {
                AssignedArmies.Add(army);
                army.SetDefence(this);

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
            army.SetDefence(null);
        }
    }
}
