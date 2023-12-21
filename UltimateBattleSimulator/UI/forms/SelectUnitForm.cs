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
        public SelectUnitForm()
        {
            InitializeComponent();
        }

        private void SelectUnitForm_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            checkedListBoxUnits.Items.Clear();
            int index = 0;
            foreach (var item in UnitsManager.Instance.Loaded)
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
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkedListBoxUnits_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBoxUnits.Items[e.Index] is IUnit item)
            {
                item.IsSelected = e.NewValue == CheckState.Checked;
            }
        }
    }
}
