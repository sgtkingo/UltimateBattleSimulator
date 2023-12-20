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
            int index = 0;
            foreach (var item in UnitsManager.LoadedUnits)
            {
                checkedListBoxUnits.Items.Add(item);
                index = checkedListBoxUnits.Items.IndexOf(item);
                checkedListBoxUnits.SetItemChecked(index, item.IsSelected);
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
            foreach (IUnit item in checkedListBoxUnits.CheckedItems)
            {
                item.IsSelected = true;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
