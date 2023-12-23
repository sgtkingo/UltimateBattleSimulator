using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBattleSimulator.engine.units.types;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.UI.forms
{
    public partial class UnitForm : Form, IObjectHandleForm
    {
        internal IUnit Unit { get; private set; } = new UnitPrototype();

        public UnitForm()
        {
            InitializeComponent();
        }

        public void SetObject(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }

            Unit = (obj as IUnit) ?? new UnitPrototype();
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            propertyGrid.SelectedObject = Unit;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
