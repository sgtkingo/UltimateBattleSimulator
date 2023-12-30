using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBattleSimulator.engine.global;
using UltimateBattleSimulator.engine.units;
using UltimateBattleSimulator.interfaces;
using UltimateBattleSimulator.UI.forms;

namespace UltimateBattleSimulator.UI.managers
{
    public partial class UnitsManagerForm : Form
    {
        public UnitsManagerForm()
        {
            InitializeComponent();
        }

        private void UnitsManagerForm_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            UnitsManager.Instance.Reload();
            BindData();
        }

        private void BindData(bool onlySelected = false, bool includeFromFile = false)
        {
            bindingSourceUnits.DataSource = UnitsManager.Instance.Loaded;
            dataGridViewUnits.DataSource = bindingSourceUnits;

            Refresh(dataGridViewUnits, bindingSourceUnits);
        }

        private void ShowHelp(string helpMessage)
        {
            MessageBox.Show(helpMessage, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                UnitsManager.Instance.Delete(obj as IUnit, true);
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
        private IUnit? CreateUnit()
        {
            var form = new CreateUnitForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                return form.Unit;
            }
            else
            {
                return null;
            }
        }

        private void newToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            var unit = CreateUnit();

            var result = OpenObject(unit, new UnitForm());
            if (result == DialogResult.OK)
            {
                AddObject(unit, dataGridViewUnits, bindingSourceUnits);
            }
        }

        private void dataGridViewUnitsAllies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenObject(bindingSourceUnits.Current, new UnitForm());
        }

        private void toolStripButtonEditUnits_Click(object sender, EventArgs e)
        {
            OpenObject(bindingSourceUnits.Current, new UnitForm());
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

            if (!e.Cancel) 
            {
                UnitsManager.Instance.Delete(obj as IUnit, true);
            }
        }

        private void toolStripButtonDeleteAllUnits_Click(object sender, EventArgs e)
        {
            string message = $"Do you wanna delete all units ({bindingSourceUnits.Count})?  \n This action is permanent!";
            if (MessageBox.Show(message, "Delete all units", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UnitsManager.Instance.DeleteAll(true);
                BindData();
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

        private void toolStripButtonRefreshUnits_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void copyToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            var unit = (IUnit?)bindingSourceUnits.Current;
            var clone = unit?.Clone();

            AddObject(clone, dataGridViewUnits, bindingSourceUnits);
        }

        private void helpToolStripButtonUnits_Click(object sender, EventArgs e)
        {
            ShowHelp(HelpManager.UnitsHelp);
        }
        #endregion
    }
}
