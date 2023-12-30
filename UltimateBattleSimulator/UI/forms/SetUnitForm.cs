using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBattleSimulator.engine.units;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.UI.forms
{
    public partial class SetUnitForm : Form
    {
        internal IUnit? Unit { get; private set; }

        public SetUnitForm()
        {
            InitializeComponent();
        }

        private void SetUnitForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            bindingSourceUnits.DataSource = UnitsManager.Instance.Get(true, true);

            dataGridViewUnits.DataSource = bindingSourceUnits;
            dataGridViewUnits.CurrentCell = null;
        }

        private void bindingSourceUnits_CurrentChanged(object sender, EventArgs e)
        {
            var unit = bindingSourceUnits.Current;
            if (unit != null)
            {
                Unit = (IUnit)unit;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Unit != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
