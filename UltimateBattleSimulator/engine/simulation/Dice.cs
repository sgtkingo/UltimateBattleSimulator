using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.engine.simulation
{
    internal class Dice
    {
        private int _DiceMaxRoll = 1;

        public Dice(int diceMaxRoll = 6)
        {
            _DiceMaxRoll = diceMaxRoll;
        }

        public int Roll(bool allowRepeating = true)
        {
            int roll = 0;
            do
            {
                roll += Random.Shared.Next(1, _DiceMaxRoll + 1);
            }
            while ( (roll % _DiceMaxRoll == 0) && allowRepeating );

            return roll;
        }

        public int GetRoolsCount(int roolValue) 
        {
            int count = 1;
            while ( roolValue % _DiceMaxRoll == 0 )
            {
                roolValue /= _DiceMaxRoll;
                count++;
            }
            return count;
        }
    }
}
