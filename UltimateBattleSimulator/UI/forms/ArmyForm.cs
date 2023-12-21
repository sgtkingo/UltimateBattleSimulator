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
using UltimateBattleSimulator.engine.army.types;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.UI.forms
{
    public partial class ArmyForm : Form, IObjectHandleForm
    {
        internal IArmy Army { get; private set; } = new ArmyPrototype();

        public ArmyForm()
        {
            InitializeComponent();
        }

        public void SetObject(object obj)
        {
            if (obj == null)
            {
                return;
            }

            Army = (obj as IArmy) ?? new ArmyPrototype();
        }

        private void ArmyForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            propertyGrid.SelectedObject = Army;

            bindingSourceGroups.DataSource = Army.Groups;
            dataGridViewGroups.DataSource = bindingSourceGroups;    
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

        private void toolStripButtonGroupsNew_Click(object sender, EventArgs e)
        {
            var group = new Group();

            var result = OpenObject(group, new GroupForm());
            if (result == DialogResult.OK)
            {
                AddObject(group, dataGridViewGroups, bindingSourceGroups);
            }
        }

        private void toolStripButtonGroupsDelete_Click(object sender, EventArgs e)
        {
            object obj = bindingSourceGroups.Current;
            DeleteObject(obj, bindingSourceGroups);
        }

        private void toolStripButtonGroupsEdit_Click(object sender, EventArgs e)
        {
            OpenObject(bindingSourceGroups.Current, new GroupForm());
        }

        private void dataGridViewGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenObject(bindingSourceGroups.Current, new GroupForm());
        }

        private void dataGridViewGroups_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var obj = e.Row?.DataBoundItem;
            e.Cancel = !DeleteObjectApprove(obj);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
