using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.army;

namespace UltimateBattleSimulator.interfaces
{
    public enum ArmySide
    {
        None = 0,
        Ally = 1,
        Enemy = 2,
    }

    internal interface IArmy : Ideable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ArmySide ArmySide { get; }

        public List<Group> Groups { get; }
        public IDefence? Defence { get; }


        public int Force { get; }

        public int Amount { get; }

        public void SetDefence(IDefence? defence);
    }
}
