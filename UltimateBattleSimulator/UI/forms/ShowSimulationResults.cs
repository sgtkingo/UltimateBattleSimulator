using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBattleSimulator.engine.simulation;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.UI.forms
{
    public partial class ShowSimulationResults : Form, IObjectHandleForm
    {
        private SimulationResult? simulationResult;

        public ShowSimulationResults()
        {
            InitializeComponent();
        }

        public void SetObject(object obj)
        {
            if(obj == null) 
            {
                return;
            }

            this.simulationResult = obj as SimulationResult;
        }

        private void ShowSimulationResults_Load(object sender, EventArgs e)
        {
            propertyGrid.SelectedObject = this.simulationResult;
        }
    }
}
