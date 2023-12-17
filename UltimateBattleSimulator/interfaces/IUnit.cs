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

    internal interface IUnit : ICloneable
    {
        public Guid GUID { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public UnitType UnitType { get; }

        public int Force { get; }

        public string GetInfo();

        public void Save();
    }
}
