using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateBattleSimulator.engine.units.types;
using UltimateBattleSimulator.interfaces;
using UltimateBattleSimulator.engine.global;

namespace UltimateBattleSimulator.engine.army
{
    internal class Group : IGroup
    {
        public Guid ID { get; protected set; } = Guid.NewGuid();
        public string Name { get; set; } = "unknown";

        private IUnit? _unit = null;
        public IUnit? Unit 
        {
            get 
            {
                return _unit;
            } 
            private set 
            {
                _unit = value;
                Name = _unit?.Name ?? Name;  
            }
        }

        public IDefence? Defence { get; set; } = null;

        private int _amount = 1;
        public int Amount 
        {
            get 
            {
                return _amount;
            }
            set 
            {
                if ( Defence?.HaveEnoughtSpace(value) ?? true )
                {
                    _amount = value;
                }
            }
        }

        public EnvironmentConfig EnvironmentConfig { get; set; } = EnvironmentManager.GetUsedEnvironment;

        public int Force
        {
            get
            {
                int force =  (Unit?.Force ?? 0) * Amount;

                //Apply sancitions
                force += (int)((Unit?.SanctionDefence ?? 0) * (force * Defence?.RealBonus ?? 0));
                force += (int)((Unit?.SanctionWeather ?? 0) * EnvironmentConfig.Weather.GetPenalty() * force);
                force += (int)((Unit?.SanctionLand ?? 0) * EnvironmentConfig.Land.GetPenalty() * force);

                if( force < ((Unit?.Force ?? 0) * 0.10)) 
                {
                    force = (int)((Unit?.Force ?? 0) * 0.10);
                }

                return force;
            }
        }

        public int Vitality 
        {
            get 
            {
                return (Unit?.Vitality ?? 0) * Amount;
            }
        }

        public Group() { }

        public Group(IUnit unit) 
        {
            Unit = unit;
        }

        public void SetUnit(IUnit unit) 
        {
            this.Unit = unit;
        }

        public override string ToString()
        {
            return $"{Unit} | {Amount} | {Force}";
        }
    }
}
