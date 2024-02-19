namespace Music_Studio
{
    partial class CreateLogins
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
            this.label8 = new System.Windows.Forms.Label();
            this.PswrdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsrNmTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpIdTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccntCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DltBtn = new System.Windows.Forms.Button();
            this.EdtBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EmpLgnLbl = new System.Windows.Forms.Label();
            this.BckBtn = new System.Windows.Forms.Button();
            this.studioDatabaseDataSet = new Music_Studio.StudioDatabaseDataSet();
            this.loginInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginInfoTableAdapter = new Music_Studio.StudioDatabaseDataSetTableAdapters.LoginInfoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(130, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Password";
            // 
            // PswrdTxt
            // 
            this.PswrdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginInfoBindingSource, "Password", true));
            this.PswrdTxt.Location = new System.Drawing.Point(307, 183);
            this.PswrdTxt.Name = "PswrdTxt";
            this.PswrdTxt.Size = new System.Drawing.Size(274, 22);
            this.PswrdTxt.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(776, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Username";
            // 
            // UsrNmTxt
            // 
            this.UsrNmTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginInfoBindingSource, "Username", true));
            this.UsrNmTxt.Location = new System.Drawing.Point(953, 128);
            this.UsrNmTxt.Name = "UsrNmTxt";
            this.UsrNmTxt.Size = new System.Drawing.Size(274, 22);
            this.UsrNmTxt.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(130, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Employee ID";
            // 
            // EmpIdTxt
            // 
            this.EmpIdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginInfoBindingSource, "EmployeeID", true));
            this.EmpIdTxt.Location = new System.Drawing.Point(307, 130);
            this.EmpIdTxt.Name = "EmpIdTxt";
            this.EmpIdTxt.Size = new System.Drawing.Size(274, 22);
            this.EmpIdTxt.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1094, 340);
            this.dataGridView1.TabIndex = 39;
            // 
            // AccntCmb
            // 
            this.AccntCmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginInfoBindingSource, "Account", true));
            this.AccntCmb.FormattingEnabled = true;
            this.AccntCmb.Location = new System.Drawing.Point(953, 181);
            this.AccntCmb.Name = "AccntCmb";
            this.AccntCmb.Size = new System.Drawing.Size(140, 24);
            this.AccntCmb.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(776, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Account";
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(407, 248);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(130, 49);
            this.DltBtn.TabIndex = 44;
            this.DltBtn.Text = "Delete";
            this.DltBtn.UseVisualStyleBackColor = true;
            // 
            // EdtBtn
            // 
            this.EdtBtn.Location = new System.Drawing.Point(271, 248);
            this.EdtBtn.Name = "EdtBtn";
            this.EdtBtn.Size = new System.Drawing.Size(130, 49);
            this.EdtBtn.TabIndex = 43;
            this.EdtBtn.Text = "Edit";
            this.EdtBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(135, 248);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(130, 49);
            this.AddBtn.TabIndex = 42;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EmpLgnLbl
            // 
            this.EmpLgnLbl.AutoSize = true;
            this.EmpLgnLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.EmpLgnLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmpLgnLbl.Location = new System.Drawing.Point(523, 9);
            this.EmpLgnLbl.Name = "EmpLgnLbl";
            this.EmpLgnLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmpLgnLbl.Size = new System.Drawing.Size(294, 46);
            this.EmpLgnLbl.TabIndex = 45;
            this.EmpLgnLbl.Text = "Create Logins";
            // 
            // BckBtn
            // 
            this.BckBtn.Location = new System.Drawing.Point(1121, 660);
            this.BckBtn.Name = "BckBtn";
            this.BckBtn.Size = new System.Drawing.Size(106, 27);
            this.BckBtn.TabIndex = 46;
            this.BckBtn.Text = "Back";
            this.BckBtn.UseVisualStyleBackColor = true;
            this.BckBtn.Click += new System.EventHandler(this.BckBtn_Click);
            // 
            // studioDatabaseDataSet
            // 
            this.studioDatabaseDataSet.DataSetName = "StudioDatabaseDataSet";
            this.studioDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginInfoBindingSource
            // 
            this.loginInfoBindingSource.DataMember = "LoginInfo";
            this.loginInfoBindingSource.DataSource = this.studioDatabaseDataSet;
            // 
            // loginInfoTableAdapter
            // 
            this.loginInfoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            // 
            // CreateLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1346, 698);
            this.Controls.Add(this.BckBtn);
            this.Controls.Add(this.EmpLgnLbl);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.EdtBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AccntCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PswrdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsrNmTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpIdTxt);
            this.Name = "CreateLogins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Logins";
            this.Load += new System.EventHandler(this.CreateLogins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studioDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PswrdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsrNmTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpIdTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox AccntCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.Button EdtBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label EmpLgnLbl;
        private System.Windows.Forms.Button BckBtn;
        private StudioDatabaseDataSet studioDatabaseDataSet;
        private System.Windows.Forms.BindingSource loginInfoBindingSource;
        private StudioDatabaseDataSetTableAdapters.LoginInfoTableAdapter loginInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
    }
}