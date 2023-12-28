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
    public partial class CreateUnitForm : Form
    {
        internal IUnit? Unit { get; private set; }

        public CreateUnitForm()
        {
            InitializeComponent();
        }

        private void CreateUnitForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init() 
        {
            comboBoxUnitTypes.Items.AddRange(UnitCreator.Units.Keys.ToArray());
            comboBoxUnitTypes.SelectedIndex = 0;
        }

        private void SelectUnitByName(string name)
        {
            if (string.IsNullOrEmpty(name)) { return; }

            try
            {
                Unit = UnitCreator.GetUnitByName(name);
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown unit!");
            }
        }

        private void ShowDescription()
        {
            if( Unit == null) 
            {
                richTextBoxUnitTypeDescription.Text = string.Empty;
                return;
            }

            richTextBoxUnitTypeDescription.Text = UnitCreator.GetTypeDescription(Unit.UnitType);
        }

        private void comboBoxUnitTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectUnitByName(comboBoxUnitTypes.SelectedItem as string ?? string.Empty);
            
            ShowDescription();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if( Unit != null ) 
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
