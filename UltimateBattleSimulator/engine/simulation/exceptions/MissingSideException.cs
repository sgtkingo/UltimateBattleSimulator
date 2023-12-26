using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.simulation.exceptions
{
    internal class MissingSideException : Exception
    {
        public MissingSideException(ArmySide side) : base($"Missing side {side}!")
        {
        }
    }
}
