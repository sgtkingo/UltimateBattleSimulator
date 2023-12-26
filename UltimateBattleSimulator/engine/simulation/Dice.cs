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

        public int RollX(int roolsAmount, bool allowRepeating = true) 
        {
            int roll = 0;
            for (int i = 0; i < roolsAmount; i++) 
            {
                roll += Roll(allowRepeating);
            }
            return roll;
        }

        public int GetRoolsCount(int roolValue) 
        {
            int count = 0;
            int tmp = 0;

            while ( tmp < roolValue )
            {
                tmp += _DiceMaxRoll;
                count++;
            }
            return count;
        }
    }
}
