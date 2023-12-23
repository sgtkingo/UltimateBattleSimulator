using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBattleSimulator.engine.defence.types;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.UI.forms
{
    public partial class DefenceForm : Form, IObjectHandleForm
    {
        internal IDefence Defence { get; private set; } = new DefencePrototype();

        public DefenceForm()
        {
            InitializeComponent();
        }

        public void SetObject(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }

            Defence = (obj as IDefence) ?? new DefencePrototype();
        }

        private void DefenceForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            propertyGrid.SelectedObject = Defence;
            dataGridViewUnits.DataSource = Defence.AssignedArmies;

            numericUpDownW.Value = Defence.Size.Width;
            numericUpDownH.Value = Defence.Size.Height;
            numericUpDownT.Value = Defence.Size.Tall;  
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region Size
        private void numericUpDownW_ValueChanged(object sender, EventArgs e)
        {
            if (Defence.Size.Width == (int)numericUpDownW.Value)
            {
                return;
            }

            Defence.Size.Width = (int)numericUpDownW.Value;
            numericUpDownW.Value = Defence.Size.Width;
        }

        private void numericUpDownH_ValueChanged(object sender, EventArgs e)
        {
            if( Defence.Size.Height == (int)numericUpDownH.Value ) 
            {
                return;
            }

            Defence.Size.Height = (int)numericUpDownH.Value;
            numericUpDownH.Value = Defence.Size.Height;
        }

        private void numericUpDownT_ValueChanged(object sender, EventArgs e)
        {
            if (Defence.Size.Tall == (int)numericUpDownT.Value)
            {
                return;
            }

            Defence.Size.Tall = (int)numericUpDownT.Value;
            numericUpDownT.Value = Defence.Size.Tall;
        }
        #endregion
    }
}
