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
using UltimateBattleSimulator.UI.forms;

namespace UltimateBattleSimulator.UI
{
    public partial class UTBS : Form
    {
        public UTBS()
        {
            InitializeComponent();
        }

        private void UTBS_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            BindUnits();
        }

        private async void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedTab?.Name)
            {
                case "tabPageUnits":
                    await RefreshUnitsAsync();
                    break;
                default:
                    break;
            }
        }

        private DialogResult OpenObject(object? obj, IObjectHandleForm form)
        {
            if (obj == null)
            {
                return DialogResult.None;
            }

            form.SetObject(obj);
            return ((Form)form).ShowDialog(this); // Cast to Form to call ShowDialog
        }

        private void AddObject(object? obj, BindingSource bindingSource)
        {
            if (obj == null)
            {
                return;
            }

            bindingSource.Add(obj);
            Refresh(dataGridViewUnits, bindingSource);
        }

        private bool DeleteObject(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            string message = $"Are you sure that u wanna delete {obj} ?";
            return MessageBox.Show(message, "Delete record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand) == DialogResult.Yes;
        }

        private void Refresh(DataGridView dataGridView, BindingSource bindingSource)
        {
            var source = bindingSource.DataSource;
            bindingSource.DataSource = null;
            bindingSource.DataSource = source;

            dataGridView.DataSource = null;
            dataGridView.DataSource = bindingSource;
        }

        #region Units
        private async Task RefreshUnitsAsync()
        {
            await UnitsManager.ReloadAsync();
            var autoCompleteCollection = new AutoCompleteStringCollection();
            string[] stringArray = UnitsManager.Units.Select(obj => obj?.Name ?? "null").ToArray();

            autoCompleteCollection.AddRange(stringArray);
            toolStripTextBoxUnitFastSearch.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void BindUnits()
        {
            bindingSourceUnits.DataSource = UnitsManager.TempUnits;
            dataGridViewUnits.DataSource = bindingSourceUnits;
        }

        private void dataGridViewUnitsAllies_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //TODO
        }

        private void newToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            var unit = UnitFactory.CreateUnit(UnitType.None);

            var result = OpenObject(unit, new UniversalForm());
            if (result == DialogResult.OK)
            {
                AddObject(unit, bindingSourceUnits);
            }
        }

        private void dataGridViewUnitsAllies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenObject(bindingSourceUnits.Current, new UniversalForm());
        }

        private void toolStripButtonEditUnits_Click(object sender, EventArgs e)
        {
            OpenObject(bindingSourceUnits.Current, new UniversalForm());
        }

        private void dataGridViewUnitsAllies_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var obj = e.Row?.DataBoundItem;
            e.Cancel = !DeleteObject(obj);
        }

        private void toolStripButtonDeleteUnits_Click(object sender, EventArgs e)
        {
            var obj = bindingSourceUnits.Current;
            if (DeleteObject(obj))
            {
                bindingSourceUnits.Remove(obj);
            }
        }

        private void toolStripButtonDeleteAllUnits_Click(object sender, EventArgs e)
        {
            string message = $"Do you wanna delete all units ({bindingSourceUnits.Count})?";
            if (MessageBox.Show(message, "Delete all units", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UnitsManager.TempUnits.Clear();
                Refresh(dataGridViewUnits, bindingSourceUnits);
            }
        }

        private void saveToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            var unit = (IUnit)bindingSourceUnits.Current;
            if (unit == null)
            {
                return;
            }

            string message = $"Do you wanna save {unit} ?";
            if (MessageBox.Show(message, "Save unit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UnitsManager.Save(unit);
            }
        }

        private void toolStripButtonSaveAllUnits_Click(object sender, EventArgs e)
        {
            string message = $"Do you wanna save all units in list ({bindingSourceUnits.Count})?";
            if (MessageBox.Show(message, "Save all units", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UnitsManager.SaveAll((List<IUnit>)bindingSourceUnits.DataSource);
            }
        }

        private void toolStripTextBoxUnitFastSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = toolStripTextBoxUnitFastSearch.Text;
                var unit = UnitsManager.Find(searchText);

                var result = OpenObject(unit, new UniversalForm());
                if (result == DialogResult.OK)
                {
                    AddObject(unit, bindingSourceUnits);
                }
            }
        }

        private void openToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            var form = new SelectUnitForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                foreach (var unit in form.SelectedUnits)
                {
                    AddObject(unit, bindingSourceUnits);
                }
            }
        }

        private async void toolStripButtonRefreshUnits_Click(object sender, EventArgs e)
        {
            await RefreshUnitsAsync();
        }

        private void copyToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            var unit = (IUnit?)bindingSourceUnits.Current;
            var clone = unit?.Clone();

            AddObject(clone, bindingSourceUnits);
        }

        private void helpToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            string message = "Here you can create or select units for your armies.";
            MessageBox.Show(message, "Help");
        }
        #endregion
    }
}
