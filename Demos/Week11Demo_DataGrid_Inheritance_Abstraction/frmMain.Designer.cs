namespace Week11Demo_DataGrid_Inheritance_Abstraction
{
    partial class frmMain
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSampleDataSetJoined = new Week11Demo_DataGrid_Inheritance_Abstraction.employeeSampleDataSetJoined();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeInfoTableAdapter = new Week11Demo_DataGrid_Inheritance_Abstraction.employeeSampleDataSetJoinedTableAdapters.EmployeeInfoTableAdapter();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter = new Week11Demo_DataGrid_Inheritance_Abstraction.employeeSampleDataSetJoinedTableAdapters.countriesTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateProvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSetJoined)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.employeeSampleDataSetJoined;
            this.bindingSource1.Position = 0;
            // 
            // employeeSampleDataSetJoined
            // 
            this.employeeSampleDataSetJoined.DataSetName = "employeeSampleDataSetJoined";
            this.employeeSampleDataSetJoined.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateProvDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 498);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeInfoBindingSource
            // 
            this.employeeInfoBindingSource.DataMember = "EmployeeInfo";
            this.employeeInfoBindingSource.DataSource = this.bindingSource1;
            // 
            // employeeInfoTableAdapter
            // 
            this.employeeInfoTableAdapter.ClearBeforeFill = true;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "countries";
            this.countriesBindingSource.DataSource = this.bindingSource1;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.employeeIDDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Given Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Family Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "departmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "Dept.";
            this.departmentNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 120;
            // 
            // stateProvDataGridViewTextBoxColumn
            // 
            this.stateProvDataGridViewTextBoxColumn.DataPropertyName = "stateProv";
            this.stateProvDataGridViewTextBoxColumn.HeaderText = "Prov.";
            this.stateProvDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stateProvDataGridViewTextBoxColumn.Name = "stateProvDataGridViewTextBoxColumn";
            this.stateProvDataGridViewTextBoxColumn.Width = 130;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "countryName";
            this.countryNameDataGridViewTextBoxColumn.DataSource = this.countriesBindingSource;
            this.countryNameDataGridViewTextBoxColumn.DisplayMember = "countryName";
            this.countryNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            this.countryNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countryNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.countryNameDataGridViewTextBoxColumn.ValueMember = "countryName";
            this.countryNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 561);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSetJoined)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private employeeSampleDataSetJoined employeeSampleDataSetJoined;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource employeeInfoBindingSource;
        private employeeSampleDataSetJoinedTableAdapters.EmployeeInfoTableAdapter employeeInfoTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private employeeSampleDataSetJoinedTableAdapters.countriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateProvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn countryNameDataGridViewTextBoxColumn;
    }
}

