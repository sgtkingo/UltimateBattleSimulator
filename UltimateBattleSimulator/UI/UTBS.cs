using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateBattleSimulator.engine.army;
using UltimateBattleSimulator.engine.defence;
using UltimateBattleSimulator.engine.defence.types;
using UltimateBattleSimulator.engine.global;
using UltimateBattleSimulator.engine.simulation;
using UltimateBattleSimulator.engine.system;
using UltimateBattleSimulator.engine.units;
using UltimateBattleSimulator.interfaces;
using UltimateBattleSimulator.UI.forms;
using UltimateBattleSimulator.UI.managers;

namespace UltimateBattleSimulator.UI
{
    public partial class UTBS : Form
    {
        bool _hideUnits = false;
        bool _hideArmies = false;
        bool _hideDefence = false;

        public UTBS()
        {
            InitializeComponent();
        }

        private void UTBS_Load(object sender, EventArgs e)
        {
            DirectoryManager.InitDirectories();
            Init();
        }

        private void Init()
        {
            ReloadUnits();
            ReloadArmies();
            ReloadDefence();

            InitEnvironment();
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

        private void HideUnselectedRecords(DataGridView dataGridView, bool hide)
        {
            dataGridView.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                Ideable? item = row?.DataBoundItem as Ideable ?? null;
                if (item != null && row != null)
                {
                    if (hide)
                    {
                        row.Visible = true == item.IsSelected;
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
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

        private void toolStripTextBoxUnitFastSearch_Click(object sender, EventArgs e)
        {
            //TODO: add fast search click code here
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
            var form = new SelectUnitFromListForm();
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
            ShowHelp(HelpManager.UnitsHelp);
        }

        private void toolStripButtonUnitsHide_Click(object sender, EventArgs e)
        {
            _hideUnits = !_hideUnits;
            HideUnselectedRecords(dataGridViewUnits, _hideUnits);
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

        private void dataGridViewArmies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenObject(bindingSourceArmies.Current, new ArmyForm());
        }

        private void toolStripButtonArmiesNew_Click(object sender, EventArgs e)
        {
            var army = ArmiesFactory.Create(ArmySide.None);

            var result = OpenObject(army, new ArmyForm());
            if (result == DialogResult.OK)
            {
                AddObject(army, dataGridViewArmies, bindingSourceArmies);
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
            //TODO: add fast search click code here
        }

        private void toolStripTextBoxArmieFastSearch_KeyDown(object sender, KeyEventArgs e)
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
            ShowHelp(HelpManager.ArmiesHelp);
        }

        private void toolStripButtonArmiesHide_Click(object sender, EventArgs e)
        {
            _hideArmies = !_hideArmies;
            HideUnselectedRecords(dataGridViewArmies, _hideArmies);
        }
        #endregion

        #region Defence
        private void ReloadDefence()
        {
            DefenceManager.Instance.Reload();
            BindDefence();
        }

        private void BindDefence(bool onlySelected = false, bool includeFromFile = false)
        {
            bindingSourceDefence.DataSource = DefenceManager.Instance.Get(onlySelected, includeFromFile);
            dataGridViewDefence.DataSource = bindingSourceDefence;

            Refresh(dataGridViewDefence, bindingSourceDefence);
        }

        private void toolStripButtonDefenceNew_Click(object sender, EventArgs e)
        {
            var defence = DefenceFactory.Create();

            var result = OpenObject(defence, new DefenceForm());
            if (result == DialogResult.OK)
            {
                AddObject(defence, dataGridViewDefence, bindingSourceDefence);
            }
        }

        private void dataGridViewDefence_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenObject(bindingSourceDefence.Current, new DefenceForm());
        }

        private void toolStripButtonDefenceEdit_Click(object sender, EventArgs e)
        {
            OpenObject(bindingSourceDefence.Current, new DefenceForm());
        }

        private void toolStripButtonDefenceFromList_Click(object sender, EventArgs e)
        {
            //TODO: select defence from list here
        }

        private void dataGridViewDefence_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var obj = e.Row?.DataBoundItem;
            e.Cancel = !DeleteObjectApprove(obj);
        }

        private void toolStripButtonDefenceDelete_Click(object sender, EventArgs e)
        {
            object obj = bindingSourceDefence.Current;
            DeleteObject(obj, bindingSourceDefence);
        }

        private void toolStripButtonDefenceDeleteAll_Click(object sender, EventArgs e)
        {
            string message = $"Do you wanna delete all defence ({bindingSourceDefence.Count})?  \n This action is permanent!";
            if (MessageBox.Show(message, "Delete all units", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DefenceManager.Instance.DeleteAll();
                BindDefence();
            }
        }

        private void toolStripButtonDefenceSave_Click(object sender, EventArgs e)
        {
            var defence = (IDefence)bindingSourceDefence.Current;
            if (defence == null)
            {
                return;
            }

            string message = $"Do you wanna save {defence} ?";
            if (MessageBox.Show(message, "Save defence", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                DefenceManager.Instance.Save(defence);
            }
        }

        private void toolStripButtonDefenceSaveAll_Click(object sender, EventArgs e)
        {
            string message = $"Do you wanna save all defences in list ({bindingSourceDefence.Count})?";
            if (MessageBox.Show(message, "Save all armies", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DefenceManager.Instance.SaveAll();
            }
        }

        private void toolStripTextBoxDefenceSearch_Click(object sender, EventArgs e)
        {
            //TODO: add fast search click code here
        }

        private void toolStripTextBoxDefenceFastSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //TODO: add fast search from list here
        }

        private void toolStripButtonDefenceRefresh_Click(object sender, EventArgs e)
        {
            ReloadDefence();
        }

        private void toolStripButtonDefenceFromfile_Click(object sender, EventArgs e)
        {
            //TODO: add load from file code here
        }

        private void toolStripButtonDefenceCopy_Click(object sender, EventArgs e)
        {
            var defence = (IDefence?)bindingSourceDefence.Current;
            var clone = defence?.Clone();

            AddObject(defence, dataGridViewDefence, bindingSourceDefence);
        }

        private void toolStripButtonDefenceHelp_Click(object sender, EventArgs e)
        {
            ShowHelp(HelpManager.DefenceHelp);
        }

        private void toolStripButtonDefenceHide_Click(object sender, EventArgs e)
        {
            _hideDefence = !_hideDefence;
            HideUnselectedRecords(dataGridViewDefence, _hideDefence);
        }
        #endregion

        #region Environment
        private void InitEnvironment()
        {
            labelTerainStatus.Text = EnvironmentManager.TerainStatus[trackBarTerain.Value];
            labelRiverAndlakesStatus.Text = EnvironmentManager.RiversAndLakesStatus[trackBarRiversAndLakes.Value];
            labelSwampsStatus.Text = EnvironmentManager.SwampsStatus[trackBarSwamps.Value];

            labelRainStatus.Text = EnvironmentManager.RainStatus[trackBarRain.Value];
            labelWindStatus.Text = EnvironmentManager.WindStatus[trackBarWind.Value];
            labelFogStatus.Text = EnvironmentManager.FogStatus[trackBarFog.Value];
            labelSnowStatus.Text = EnvironmentManager.SnowStatus[trackBarSnow.Value];

            labelLandPenalty.Text = $"{EnvironmentManager.EnvironmentConfig.Land.GetPenalty():F2}";
            labelWeatherPenalty.Text = $"{EnvironmentManager.EnvironmentConfig.Weather.GetPenalty():F2}";
        }

        private void trackBarTerain_Scroll(object sender, EventArgs e)
        {
            EnvironmentManager.EnvironmentConfig.Land.Terain = trackBarTerain.Value;
            labelLandPenalty.Text = $"{EnvironmentManager.EnvironmentConfig.Land.GetPenalty():F2}";
            labelTerainStatus.Text = EnvironmentManager.TerainStatus[trackBarTerain.Value];
        }

        private void trackBarRiversAndLakes_Scroll(object sender, EventArgs e)
        {
            EnvironmentManager.EnvironmentConfig.Land.RiversAndLakes = trackBarRiversAndLakes.Value;
            labelLandPenalty.Text = $"{EnvironmentManager.EnvironmentConfig.Land.GetPenalty():F2}";
            labelRiverAndlakesStatus.Text = EnvironmentManager.RiversAndLakesStatus[trackBarRiversAndLakes.Value];
        }

        private void trackBarSwamps_Scroll(object sender, EventArgs e)
        {
            EnvironmentManager.EnvironmentConfig.Land.Swamps = trackBarSwamps.Value;
            labelLandPenalty.Text = $"{EnvironmentManager.EnvironmentConfig.Land.GetPenalty():F2}";
            labelSwampsStatus.Text = EnvironmentManager.SwampsStatus[trackBarSwamps.Value];
        }
        //------------------------------------------------------------------------

        private void trackBarRain_Scroll(object sender, EventArgs e)
        {
            EnvironmentManager.EnvironmentConfig.Weather.Rain = trackBarRain.Value;
            labelWeatherPenalty.Text = $"{EnvironmentManager.EnvironmentConfig.Weather.GetPenalty():F2}";
            labelRainStatus.Text = EnvironmentManager.RainStatus[trackBarRain.Value];
        }

        private void trackBarWind_Scroll(object sender, EventArgs e)
        {
            EnvironmentManager.EnvironmentConfig.Weather.Wind = trackBarWind.Value;
            labelWeatherPenalty.Text = $"{EnvironmentManager.EnvironmentConfig.Weather.GetPenalty():F2}";
            labelWindStatus.Text = EnvironmentManager.WindStatus[trackBarWind.Value];
        }

        private void trackBarFog_Scroll(object sender, EventArgs e)
        {
            EnvironmentManager.EnvironmentConfig.Weather.Fog = trackBarFog.Value;
            labelWeatherPenalty.Text = $"{EnvironmentManager.EnvironmentConfig.Weather.GetPenalty():F2}";
            labelFogStatus.Text = EnvironmentManager.FogStatus[trackBarFog.Value];
        }

        private void trackBarSnow_Scroll(object sender, EventArgs e)
        {
            EnvironmentManager.EnvironmentConfig.Weather.Snow = trackBarSnow.Value;
            labelWeatherPenalty.Text = $"{EnvironmentManager.EnvironmentConfig.Weather.GetPenalty():F2}";
            labelSnowStatus.Text = EnvironmentManager.SnowStatus[trackBarSnow.Value];
        }

        private void buttonHelpLandConfig_Click(object sender, EventArgs e)
        {
            ShowHelp(HelpManager.LandConfigHelp);
        }

        private void buttonHelpWeatherConfig_Click(object sender, EventArgs e)
        {
            ShowHelp(HelpManager.WeatherConfigHelp);
        }

        private void labelEnvironmentStatus_TextChanged(object sender, EventArgs e)
        {
            string origin = ((Label)sender).Text;
            if (!string.IsNullOrEmpty(origin) && origin.Length > 55)
            {
                ((Label)sender).Text = origin.Substring(0, 55) + "...";
            }
        }
        #endregion

        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            var form = new SimulatorForm();
            form.ShowDialog(this);
        }

        private void UTBS_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Dispose all objects
            Simulator.Dispose();
        }

        #region Managers
        private void unitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UnitsManagerForm();
            form.Show();
        }
        #endregion
    }
}
