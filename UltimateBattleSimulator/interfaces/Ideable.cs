using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateBattleSimulator.interfaces
{
    internal interface Ideable : ICloneable
    {
        public Guid GUID { get; }


        public bool IsSelected { get; set; }
        public bool IsLoadedFromFile { get; protected set; }

        public string GetInfo();
        public void Save();

        public void Delete();

        public void Load()
        {
            IsLoadedFromFile = true;
        }
    }
}
