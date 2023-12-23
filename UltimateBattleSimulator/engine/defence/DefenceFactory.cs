using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.army.types;
using UltimateBattleSimulator.engine.defence.types;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.defence
{
    internal class DefenceFactory
    {
        public static IDefence? Create()
        {
            return new DefencePrototype();
        }
    }
}
