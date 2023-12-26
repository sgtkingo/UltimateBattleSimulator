using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.army
{
    internal class ArmyStatus
    {
        public int Amount { get; set; } = 0;
        public bool Alive 
        { 
            get 
            {
                return Amount > Army?.MinimalAmoutToFight; 
            }
        }

        public IArmy? Army { get; set; }

        public int GetLooses 
        { 
            get 
            {
                return (Army?.Amount ?? 0) - this.Amount;
            } 
        }

        public ArmyStatus() { }

        public ArmyStatus(int amount) 
        {
            Amount = amount;
        }

        public ArmyStatus(IArmy army) 
        {
            Army = army;
            Amount = army.Amount;
        }
    }
}
