namespace Music_Studio
{
    partial class Instruments
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.instrumentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegisteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentTable = new Music_Studio.InstrumentTable();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTable = new Music_Studio.EmployeeTable();
            this.TypCmb = new System.Windows.Forms.ComboBox();
            this.BckBtn = new System.Windows.Forms.Button();
            this.DltBtn = new System.Windows.Forms.Button();
            this.EdtBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DtPkr = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.RtTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BrndTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NmeTxt = new System.Windows.Forms.TextBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QnttyLst = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CstTxt = new System.Windows.Forms.TextBox();
            this.SrchBtn = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new Music_Studio.EmployeeTableTableAdapters.EmployeesTableAdapter();
            this.instrumentsTableAdapter = new Music_Studio.InstrumentTableTableAdapters.InstrumentsTableAdapter();
            this.Row = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QnttyLst)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instrumentIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.hourlyRateDataGridViewTextBoxColumn,
            this.dateRegisteredDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.instrumentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(550, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 529);
            this.dataGridView1.TabIndex = 42;
            // 
            // instrumentIdDataGridViewTextBoxColumn
            // 
            this.instrumentIdDataGridViewTextBoxColumn.DataPropertyName = "InstrumentId";
            this.instrumentIdDataGridViewTextBoxColumn.HeaderText = "InstrumentId";
            this.instrumentIdDataGridViewTextBoxColumn.Name = "instrumentIdDataGridViewTextBoxColumn";
            this.instrumentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // hourlyRateDataGridViewTextBoxColumn
            // 
            this.hourlyRateDataGridViewTextBoxColumn.DataPropertyName = "HourlyRate";
            this.hourlyRateDataGridViewTextBoxColumn.HeaderText = "HourlyRate";
            this.hourlyRateDataGridViewTextBoxColumn.Name = "hourlyRateDataGridViewTextBoxColumn";
            // 
            // dateRegisteredDataGridViewTextBoxColumn
            // 
            this.dateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.HeaderText = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.Name = "dateRegisteredDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // instrumentsBindingSource
            // 
            this.instrumentsBindingSource.DataMember = "Instruments";
            this.instrumentsBindingSource.DataSource = this.instrumentTable;
            // 
            // instrumentTable
            // 
            this.instrumentTable.DataSetName = "InstrumentTable";
            this.instrumentTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeeTable;
            // 
            // employeeTable
            // 
            this.employeeTable.DataSetName = "EmployeeTable";
            this.employeeTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TypCmb
            // 
            this.TypCmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "Type", true));
            this.TypCmb.FormattingEnabled = true;
            this.TypCmb.Items.AddRange(new object[] {
            "Guitar",
            "Violin",
            "Keyboard",
            "Piano",
            "Drums",
            "Toms",
            "Kicks",
            "Cymbols",
            "Interfaces/Consoles",
            "Computers",
            "Monitors",
            "MIDI",
            "Headphones",
            "Microphones",
            "Other"});
            this.TypCmb.Location = new System.Drawing.Point(221, 180);
            this.TypCmb.Name = "TypCmb";
            this.TypCmb.Size = new System.Drawing.Size(158, 24);
            this.TypCmb.TabIndex = 41;
            this.TypCmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(1197, 664);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(106, 27);
            this.BckBtn.TabIndex = 40;
            this.BckBtn.Text = "Back";
            this.BckBtn.UseVisualStyleBackColor = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(48, 613);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(130, 49);
            this.DltBtn.TabIndex = 39;
            this.DltBtn.Text = "Delete";
            this.DltBtn.UseVisualStyleBackColor = true;
            // 
            // EdtBtn
            // 
            this.EdtBtn.Location = new System.Drawing.Point(321, 558);
            this.EdtBtn.Name = "EdtBtn";
            this.EdtBtn.Size = new System.Drawing.Size(130, 49);
            this.EdtBtn.TabIndex = 38;
            this.EdtBtn.Text = "Edit";
            this.EdtBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(185, 558);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 49);
            this.AddBtn.TabIndex = 37;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(44, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Register Date";
            // 
            // DtPkr
            // 
            this.DtPkr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "DateRegistered", true));
            this.DtPkr.Location = new System.Drawing.Point(221, 378);
            this.DtPkr.Name = "DtPkr";
            this.DtPkr.Size = new System.Drawing.Size(230, 22);
            this.DtPkr.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(44, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Hourly Rate";
            // 
            // RtTxt
            // 
            this.RtTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "HourlyRate", true));
            this.RtTxt.Location = new System.Drawing.Point(221, 331);
            this.RtTxt.Name = "RtTxt";
            this.RtTxt.Size = new System.Drawing.Size(230, 22);
            this.RtTxt.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(44, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(44, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Brand";
            // 
            // BrndTxt
            // 
            this.BrndTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "Brand", true));
            this.BrndTxt.Location = new System.Drawing.Point(221, 234);
            this.BrndTxt.Name = "BrndTxt";
            this.BrndTxt.Size = new System.Drawing.Size(230, 22);
            this.BrndTxt.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(44, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name";
            // 
            // NmeTxt
            // 
            this.NmeTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "Name", true));
            this.NmeTxt.Location = new System.Drawing.Point(221, 129);
            this.NmeTxt.Name = "NmeTxt";
            this.NmeTxt.Size = new System.Drawing.Size(230, 22);
            this.NmeTxt.TabIndex = 24;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.CustomerLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CustomerLabel.Location = new System.Drawing.Point(487, 11);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerLabel.Size = new System.Drawing.Size(418, 46);
            this.CustomerLabel.TabIndex = 23;
            this.CustomerLabel.Text = "Manage Instruments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(44, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Quantity";
            // 
            // QnttyLst
            // 
            this.QnttyLst.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.instrumentsBindingSource, "Quantity", true));
            this.QnttyLst.Location = new System.Drawing.Point(221, 426);
            this.QnttyLst.Name = "QnttyLst";
            this.QnttyLst.Size = new System.Drawing.Size(158, 22);
            this.QnttyLst.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(44, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "Cost";
            // 
            // CstTxt
            // 
            this.CstTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentsBindingSource, "Cost", true));
            this.CstTxt.Location = new System.Drawing.Point(221, 283);
            this.CstTxt.Name = "CstTxt";
            this.CstTxt.Size = new System.Drawing.Size(230, 22);
            this.CstTxt.TabIndex = 45;
            // 
            // SrchBtn
            // 
            this.SrchBtn.Location = new System.Drawing.Point(185, 613);
            this.SrchBtn.Name = "SrchBtn";
            this.SrchBtn.Size = new System.Drawing.Size(130, 49);
            this.SrchBtn.TabIndex = 47;
            this.SrchBtn.Text = "Search";
            this.SrchBtn.UseVisualStyleBackColor = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentsTableAdapter
            // 
            this.instrumentsTableAdapter.ClearBeforeFill = true;
            // 
            // Row
            // 
            this.Row.Location = new System.Drawing.Point(49, 558);
            this.Row.Name = "Row";
            this.Row.Size = new System.Drawing.Size(130, 49);
            this.Row.TabIndex = 48;
            this.Row.Text = "New";
            this.Row.UseVisualStyleBackColor = true;
            this.Row.Click += new System.EventHandler(this.Row_Click);
            // 
            // Instruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1346, 698);
            this.Controls.Add(this.Row);
            this.Controls.Add(this.SrchBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CstTxt);
            this.Controls.Add(this.QnttyLst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TypCmb);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.EdtBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DtPkr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RtTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrndTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NmeTxt);
            this.Controls.Add(this.CustomerLabel);
            this.Name = "Instruments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instruments";
            this.Load += new System.EventHandler(this.Instruments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QnttyLst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox TypCmb;
        private System.Windows.Forms.Button BckBtn;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.Button EdtBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtPkr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RtTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BrndTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NmeTxt;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown QnttyLst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CstTxt;
        private System.Windows.Forms.Button SrchBtn;
        private EmployeeTable employeeTable;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeeTableTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private InstrumentTable instrumentTable;
        private System.Windows.Forms.BindingSource instrumentsBindingSource;
        private InstrumentTableTableAdapters.InstrumentsTableAdapter instrumentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegisteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Row;
    }
}