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
        private int _amount = 0;
        public int Amount 
        {
            get 
            {
                return this._amount;
            }
            set 
            {
                if( value < 0) 
                {
                    value = 0;
                }
                this._amount = value;
            }
        }

        public int Vitality
        {
            get
            {
                return (int)((double)Army.Vitality * ((double)this.Amount / Army.Amount));
            }
        }

        public int Force
        {
            get
            {
                return (int)((double)Army.Force * ((double)this.Amount / Army.Amount));
            }
        }

        public bool Alive 
        { 
            get 
            {
                return this.Amount > Army.MinimalAmoutToFight; 
            }
        }

        public IArmy Army { get; set; }

        public int GetLooses 
        { 
            get 
            {
                return Army.Amount - this.Amount;
            } 
        }

        public ArmyStatus(IArmy army) 
        {
            Army = army;
            Amount = army.Amount;
        }

        public void Hit(int force) 
        {
            double forceDiv = (double)force / this.Force;
            int hit = (int)Math.Ceiling(forceDiv);

            this.Amount -= hit;
        }
    }
}
