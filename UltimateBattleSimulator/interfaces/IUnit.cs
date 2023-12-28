using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.interfaces
{
    public enum UnitType
    {
        None = 0,
        Infantry = 1,
        Archers = 2,
        Cavalerly = 3
    }

    internal interface IUnit : Ideable
    {
        public const int MaxLevel = 36;

        public string Name { get; set; }
        public string Description { get; set; }
        public UnitType UnitType { get; }

        public int AttackNumber { get; set; }
        public int DefenceNumber { get; set; }
        public int Iniciative { get; set; }
        public int Life { get; set; }
        public int Level { get; set; }
        public int Move { get; set; }

        public int Force { get; }
        public int Vitality { get; }
        public double LevelBonus { get; }

        public double SanctionWeather { get; set; }
        public double SanctionLand { get; set; }
        public double SanctionDefence { get; set; }

        public string ToString();
    }
}
