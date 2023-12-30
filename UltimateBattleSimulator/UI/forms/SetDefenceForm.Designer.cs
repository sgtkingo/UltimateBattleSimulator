namespace UltimateBattleSimulator.UI.forms
{
    partial class SetDefenceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonOK = new Button();
            dataGridViewDefence = new DataGridView();
            bindingSourceDefence = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDefence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceDefence).BeginInit();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(12, 289);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(320, 44);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "Set";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // dataGridViewDefence
            // 
            dataGridViewDefence.AllowUserToAddRows = false;
            dataGridViewDefence.AllowUserToDeleteRows = false;
            dataGridViewDefence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDefence.Location = new Point(12, 12);
            dataGridViewDefence.MultiSelect = false;
            dataGridViewDefence.Name = "dataGridViewDefence";
            dataGridViewDefence.ReadOnly = true;
            dataGridViewDefence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDefence.Size = new Size(320, 271);
            dataGridViewDefence.TabIndex = 1;
            // 
            // bindingSourceDefence
            // 
            bindingSourceDefence.CurrentChanged += bindingSourceDefence_CurrentChanged;
            // 
            // SetDefenceForm
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 345);
            Controls.Add(dataGridViewDefence);
            Controls.Add(buttonOK);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "SetDefenceForm";
            Text = "Set unit form";
            Load += SetDefenceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDefence).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceDefence).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOK;
        private DataGridView dataGridViewDefence;
        private BindingSource bindingSourceDefence;
    }
}