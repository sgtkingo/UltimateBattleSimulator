using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBattleSimulator.engine.army;
using UltimateBattleSimulator.engine.units;
using UltimateBattleSimulator.interfaces;
using UltimateBattleSimulator.UI.forms;

namespace UltimateBattleSimulator.UI
{
    public partial class UTBS : Form
    {
        bool _hideUnits = false;
        bool _hideArmies = false;

        public UTBS()
        {
            InitializeComponent();
        }

        private void UTBS_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            ReloadUnits();
            ReloadArmies();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedTab?.Name)
            {
                case "tabPageUnits":
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

        private void AddObject(object? obj, DataGridView dataGridView, BindingSource bindingSource)
        {
            if (obj == null)
            {
                return;
            }

            bindingSource.Add(obj);
            Refresh(dataGridView, bindingSource);
        }

        private bool DeleteObjectApprove(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            string message = $"Are you sure that u wanna delete {obj} ? \n This action is permanent!";
            return MessageBox.Show(message, "Delete record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void DeleteObject(object? obj, BindingSource bindingSource)
        {
            if (DeleteObjectApprove(obj))
            {
                bindingSource.Remove(obj);
            }
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

        private void ReloadUnits()
        {
            UnitsManager.Instance.Reload();

            var autoCompleteCollection = new AutoCompleteStringCollection();
            string[] stringArray = UnitsManager.Instance.Loaded.Select(obj => obj?.Name ?? "null").ToArray();

            autoCompleteCollection.AddRange(stringArray);
            toolStripTextBoxUnitFastSearch.AutoCompleteCustomSource = autoCompleteCollection;

            BindUnits();
        }

        private void BindUnits(bool onlySelected = false, bool includeFromFile = false)
        {
            bindingSourceUnits.DataSource = UnitsManager.Instance.Get(onlySelected, includeFromFile);
            dataGridViewUnits.DataSource = bindingSourceUnits;

            Refresh(dataGridViewUnits, bindingSourceUnits);
        }

        private void toolStripButtonUnitsHide_Click(object sender, EventArgs e)
        {
            _hideUnits = !_hideUnits;
            dataGridViewUnits.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridViewUnits.Rows)
            {
                IUnit? unit = row?.DataBoundItem as IUnit ?? null;
                if (unit != null && row != null)
                {
                    if (_hideUnits)
                    {
                        row.Visible = true == unit.IsSelected;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void newToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            var unit = UnitFactory.Create(UnitType.None);

            var result = OpenObject(unit, new UniversalForm());
            if (result == DialogResult.OK)
            {
                AddObject(unit, dataGridViewUnits, bindingSourceUnits);
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

        private void toolStripButtonDeleteUnits_Click(object sender, EventArgs e)
        {
            object obj = bindingSourceUnits.Current;
            DeleteObject(obj, bindingSourceUnits);
        }

        private void dataGridViewUnits_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var obj = e.Row?.DataBoundItem;
            e.Cancel = !DeleteObjectApprove(obj);
        }

        private void toolStripButtonDeleteAllUnits_Click(object sender, EventArgs e)
        {
            string message = $"Do you wanna delete all units ({bindingSourceUnits.Count})?  \n This action is permanent!";
            if (MessageBox.Show(message, "Delete all units", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UnitsManager.Instance.DeleteAll();
                BindUnits();
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
                UnitsManager.Instance.Save(unit);
            }
        }

        private void toolStripButtonSaveAllUnits_Click(object sender, EventArgs e)
        {
            string message = $"Do you wanna save all units in list ({bindingSourceUnits.Count})?";
            if (MessageBox.Show(message, "Save all units", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UnitsManager.Instance.SaveAll();
            }
        }

        private void toolStripTextBoxUnitFastSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchText = toolStripTextBoxUnitFastSearch.Text;
                var unit = UnitsManager.Instance.Find(searchText);

                var result = OpenObject(unit, new UniversalForm());
                if (result == DialogResult.OK)
                {
                    AddObject(unit, dataGridViewUnits, bindingSourceUnits);
                }
            }
        }

        private void openToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var unit = UnitFactory.LoadFromJsonFile(openFileDialog.FileName);
                if (unit != null)
                {
                    bindingSourceUnits.Add(unit);
                }
            }
        }

        private void toolStripButtonUnitsFromLoadedList_Click(object sender, EventArgs e)
        {
            var form = new SelectUnitForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                BindUnits(false, true);
            }
        }

        private void toolStripButtonRefreshUnits_Click(object sender, EventArgs e)
        {
            UnitsManager.Instance.Clear();

            ReloadUnits();
        }

        private void copyToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            var unit = (IUnit?)bindingSourceUnits.Current;
            var clone = unit?.Clone();

            AddObject(clone, dataGridViewUnits, bindingSourceUnits);
        }

        private void helpToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            string message = "Here you can create or select units for your armies.";
            MessageBox.Show(message, "Help");
        }
        #endregion

        #region Armies
        private void ReloadArmies()
        {
            ArmiesManager.Instance.Reload();
            BindArmies();
        }

        private void BindArmies(bool onlySelected = false, bool includeFromFile = false)
        {
            bindingSourceArmies.DataSource = ArmiesManager.Instance.Get(onlySelected, includeFromFile);
            dataGridViewArmies.DataSource = bindingSourceArmies;

            Refresh(dataGridViewArmies, bindingSourceArmies);
        }
        #endregion
        private void dataGridViewArmies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenObject(bindingSourceArmies.Current, new ArmyForm());
        }

        private void toolStripButtonArmiesNew_Click(object sender, EventArgs e)
        {
            var unit = ArmiesFactory.Create(ArmySide.None);

            var result = OpenObject(unit, new ArmyForm());
            if (result == DialogResult.OK)
            {
                AddObject(unit, dataGridViewArmies, bindingSourceArmies);
            }
        }

        private void toolStripButtonArmiesFromList_Click(object sender, EventArgs e)
        {
            //TODO: add load from list code here
        }

        private void dataGridViewArmies_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var obj = e.Row?.DataBoundItem;
            e.Cancel = !DeleteObjectApprove(obj);
        }

        private void toolStripButtonArmiesEdit_Click(object sender, EventArgs e)
        {
            OpenObject(bindingSourceArmies.Current, new ArmyForm());
        }


        private void toolStripButtonArmiesDelete_Click(object sender, EventArgs e)
        {
            object obj = bindingSourceArmies.Current;
            DeleteObject(obj, bindingSourceArmies);
        }

        private void toolStripButtonArmiesDeleteAll_Click(object sender, EventArgs e)
        {
            string message = $"Do you wanna delete all armies ({bindingSourceArmies.Count})?  \n This action is permanent!";
            if (MessageBox.Show(message, "Delete all units", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ArmiesManager.Instance.DeleteAll();
                BindArmies();
            }
        }

        private void toolStripButtonArmiesSave_Click(object sender, EventArgs e)
        {
            var army = (IArmy)bindingSourceArmies.Current;
            if (army == null)
            {
                return;
            }

            string message = $"Do you wanna save {army} ?";
            if (MessageBox.Show(message, "Save army", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                ArmiesManager.Instance.Save(army);
            }
        }

        private void toolStripButtonArmiesSaveAll_Click(object sender, EventArgs e)
        {
            string message = $"Do you wanna save all armies in list ({bindingSourceArmies.Count})?";
            if (MessageBox.Show(message, "Save all armies", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ArmiesManager.Instance.SaveAll();
            }
        }

        private void toolStripButtonArmiesRefresh_Click(object sender, EventArgs e)
        {
            ReloadArmies();
        }

        private void toolStripTextBoxArmieSearch_Click(object sender, EventArgs e)
        {
            //TODO: search army from list code here
        }

        private void toolStripButtonArmiesLoadFromFile_Click(object sender, EventArgs e)
        {
            //TODO: load from file code here
        }

        private void toolStripButtonArmiesCopy_Click(object sender, EventArgs e)
        {
            var army = (IArmy?)bindingSourceArmies.Current;
            var clone = army?.Clone();

            AddObject(clone, dataGridViewArmies, bindingSourceArmies);
        }

        private void toolStripButtonArmiesHelp_Click(object sender, EventArgs e)
        {
            string message = "Here you can create or select armies for your simulation.";
            MessageBox.Show(message, "Help");
        }

        private void toolStripButtonArmiesHide_Click(object sender, EventArgs e)
        {
            _hideArmies = !_hideArmies;
            dataGridViewArmies.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridViewArmies.Rows)
            {
                IArmy? army = row?.DataBoundItem as IArmy ?? null;
                if (army != null && row != null)
                {
                    if (_hideArmies)
                    {
                        row.Visible = true == army.IsSelected;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
        }
    }
}
