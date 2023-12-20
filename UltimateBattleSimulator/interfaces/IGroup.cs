using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.interfaces
{
    internal interface IGroup
    {
        public Guid ID { get; } 

        IUnit Unit { get; set; }
        public int Amount { get; set; }

        public int Force 
        {
            get 
            {
                return Unit.Force * Amount;
            } 
        }
    }
}
