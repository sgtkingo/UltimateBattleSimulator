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
    public partial class SelectUnitForm : Form
    {
        internal List<IUnit> SelectedUnits = new List<IUnit>();

        public SelectUnitForm()
        {
            InitializeComponent();
        }

        private void SelectUnitForm_Load(object sender, EventArgs e)
        {
            UnitsManager.Reload();
            BindData();
        }

        private void BindData()
        {
            checkedListBoxUnits.Items.Clear();
            foreach (var item in UnitsManager.Units)
            {
                checkedListBoxUnits.Items.Add(item);
            }
        }

        private void checkedListBoxUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            var unit = (IUnit?)checkedListBoxUnits.SelectedItem;
            if (unit == null)
            {
                return;
            }

            richTextBoxUnitInfo.Text = unit.GetInfo();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxUnits.CheckedItems)
            {
                SelectedUnits.Add((IUnit)item);
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
