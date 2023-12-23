using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.army;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.defence
{
    internal class DefenceManager : AbstractManager<IDefence>
    { 
        public static DefenceManager Instance { get; private set; } = new DefenceManager();
    }
}
