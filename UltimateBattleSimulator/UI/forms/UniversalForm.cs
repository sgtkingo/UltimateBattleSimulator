using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.UI.forms
{
    public partial class UniversalForm : Form, IObjectHandleForm
    {
        object? customObject = null;

        public UniversalForm()
        {
            InitializeComponent();
        }

        private void UniversalForm_Load(object sender, EventArgs e)
        {
            //Some code here
            DialogResult = DialogResult.None;
        }

        public void SetObject(object obj)
        {
            this.customObject = obj;
            propertyGrid.SelectedObject = customObject;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
