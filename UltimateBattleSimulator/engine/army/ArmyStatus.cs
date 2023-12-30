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

        private int _vitality  = 0;
        private double _vitalityDiv = 0;
        public int Vitality
        {
            get
            {
                return _vitality;
            }
            set 
            {
                if( value < 0 ) 
                {
                    value = 0;
                }
                this._vitality = value;

                this._vitalityDiv = ((double)this._vitality) / Army.Vitality;
                this.Amount -= (int)Math.Ceiling((1.0- this._vitalityDiv) * this.Amount);
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
            Vitality = army.Vitality;
        }
        
        public void Hit(int hit)
        {
            Vitality -= hit;
        }
    }
}
