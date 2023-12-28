using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBattleSimulator.engine.defence;
using UltimateBattleSimulator.interfaces;

namespace UltimateBattleSimulator.UI.forms
{
    public partial class SetDefenceForm : Form
    {
        internal IDefence? Defence { get; private set; }

        public SetDefenceForm()
        {
            InitializeComponent();
        }

        private void SetDefenceForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            dataGridViewDefence.DataSource = DefenceManager.Instance.Get(true, true);
            dataGridViewDefence.CurrentCell = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewDefence.Rows[e.RowIndex];
            Defence = row?.DataBoundItem as IDefence;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if( Defence != null ) 
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
