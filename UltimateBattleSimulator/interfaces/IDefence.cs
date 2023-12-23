using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.interfaces
{
    internal interface IDefence : Ideable
    {
        public const int MaxMainDefenceForce = 50;
        public const int MaxSecondaryDefenceForce = 20;

        public const int MaxDefenceForceForBonus = 10;

        public string Name { get; set; }
        public string Description { get; set; }
        public Size3D Size { get; }

        public int MainForce { get; set; }
        public int SecondaryForce { get; set; }

        public int Force { get; }

        public double Bonus { get; }
        public double RealBonus { get; }

        public int MaxCapacity { get; }

        public int FreeSpace { get; }

        public List<IArmy> AssignedArmies { get; }

        public bool HaveEnoughtSpace(IArmy army);
        public bool HaveEnoughtSpace(int amount);

        public bool Assigne(IArmy army);

        public void Dessigne(IArmy army);
    }
}
