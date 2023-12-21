using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.engine.defence
{
    internal class DefencePrototype : IDefence
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public Size3D Size { get; set; } = new Size3D(0,0,0);


        public int MainForce { get; set; }
        public int SecondaryForce { get; set; }
        public int Force { get; set; } = 0;

        public List<IArmy> AssignedArmies { get; protected set; } = new List<IArmy>();
    }
}
