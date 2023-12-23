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
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.UI.forms
{
    public partial class GroupForm : Form, IObjectHandleForm
    {
        internal Group Group { get; private set; } = new Group();   

        public GroupForm()
        {
            InitializeComponent();
        }

        public void SetObject(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }

            Group = (obj as Group) ?? new Group();
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            propertyGrid.SelectedObject = Group;
            SetUnit(Group?.Unit);
        }

        private void Reload()
        {
            propertyGrid.SelectedObject = null;
            propertyGrid.SelectedObject = Group;
        }

        private void SetUnit(IUnit? unit)
        {
            if (unit == null)
            {
                richTextBoxUnit.Text = "No unit selected...";
                return;
            }

            Group.SetUnit(unit);
            richTextBoxUnit.Text = unit.GetInfo();

            Reload();
        }

        private void buttonSetUnit_Click(object sender, EventArgs e)
        {
            var form = new SetUnitForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (MessageBox.Show($"Do you wanna change unit to {form.Unit}?", "Unit change", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SetUnit(form.Unit);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
