namespace Week10DemoA_DataBindingPlus
{
    partial class frmEmployees
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
            this.cboEmployees = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSampleDataSet = new Week10DemoA_DataBindingPlus.employeeSampleDataSet();
            this.btnClose = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new Week10DemoA_DataBindingPlus.employeeSampleDataSetTableAdapters.employeesTableAdapter();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.nudCommissionPercent = new System.Windows.Forms.NumericUpDown();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSampleDataSetDept = new Week10DemoA_DataBindingPlus.employeeSampleDataSetDept();
            this.departmentsTableAdapter = new Week10DemoA_DataBindingPlus.employeeSampleDataSetDeptTableAdapters.departmentsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeSampleDataSetManagers = new Week10DemoA_DataBindingPlus.employeeSampleDataSetManagers();
            this.employeesTableAdapter1 = new Week10DemoA_DataBindingPlus.employeeSampleDataSetManagersTableAdapters.employeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommissionPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSetDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSetManagers)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEmployees
            // 
            this.cboEmployees.DataSource = this.employeesBindingSource;
            this.cboEmployees.DisplayMember = "fullName";
            this.cboEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(12, 22);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(667, 45);
            this.cboEmployees.TabIndex = 0;
            this.cboEmployees.ValueMember = "employeeID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.employeeSampleDataSet;
            // 
            // employeeSampleDataSet
            // 
            this.employeeSampleDataSet.DataSetName = "employeeSampleDataSet";
            this.employeeSampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(533, 508);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 75);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "firstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(52, 114);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 26);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "lastName", true));
            this.txtLastName.Location = new System.Drawing.Point(52, 146);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "email", true));
            this.txtEmail.Location = new System.Drawing.Point(52, 202);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "phoneNumber", true));
            this.txtPhone.Location = new System.Drawing.Point(52, 251);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(185, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "hireDate", true));
            this.dtpHireDate.Location = new System.Drawing.Point(52, 300);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 26);
            this.dtpHireDate.TabIndex = 6;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "jobTitle", true));
            this.txtJobTitle.Location = new System.Drawing.Point(273, 114);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(134, 26);
            this.txtJobTitle.TabIndex = 7;
            // 
            // nudSalary
            // 
            this.nudSalary.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "salary", true));
            this.nudSalary.DecimalPlaces = 2;
            this.nudSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSalary.Location = new System.Drawing.Point(273, 147);
            this.nudSalary.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(158, 26);
            this.nudSalary.TabIndex = 8;
            // 
            // nudCommissionPercent
            // 
            this.nudCommissionPercent.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "commissionPercent", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
            this.nudCommissionPercent.DecimalPlaces = 3;
            this.nudCommissionPercent.Location = new System.Drawing.Point(454, 147);
            this.nudCommissionPercent.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCommissionPercent.Name = "nudCommissionPercent";
            this.nudCommissionPercent.Size = new System.Drawing.Size(120, 26);
            this.nudCommissionPercent.TabIndex = 9;
            // 
            // cboDepartment
            // 
            this.cboDepartment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "departmentID", true));
            this.cboDepartment.DataSource = this.departmentsBindingSource;
            this.cboDepartment.DisplayMember = "departmentName";
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(413, 114);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(248, 28);
            this.cboDepartment.TabIndex = 10;
            this.cboDepartment.ValueMember = "departmentID";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "departments";
            this.departmentsBindingSource.DataSource = this.employeeSampleDataSetDept;
            // 
            // employeeSampleDataSetDept
            // 
            this.employeeSampleDataSetDept.DataSetName = "employeeSampleDataSetDept";
            this.employeeSampleDataSetDept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "managerID", true));
            this.comboBox1.DataSource = this.employeesBindingSource1;
            this.comboBox1.DisplayMember = "fullName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(359, 302);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "employeeID";
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "employees";
            this.employeesBindingSource1.DataSource = this.employeeSampleDataSetManagers;
            // 
            // employeeSampleDataSetManagers
            // 
            this.employeeSampleDataSetManagers.DataSetName = "employeeSampleDataSetManagers";
            this.employeeSampleDataSetManagers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 595);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.nudCommissionPercent);
            this.Controls.Add(this.nudSalary);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboEmployees);
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommissionPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSetDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSampleDataSetManagers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmployees;
        private System.Windows.Forms.Button btnClose;
        private employeeSampleDataSet employeeSampleDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private employeeSampleDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.NumericUpDown nudCommissionPercent;
        private System.Windows.Forms.ComboBox cboDepartment;
        private employeeSampleDataSetDept employeeSampleDataSetDept;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private employeeSampleDataSetDeptTableAdapters.departmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private employeeSampleDataSetManagers employeeSampleDataSetManagers;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private employeeSampleDataSetManagersTableAdapters.employeesTableAdapter employeesTableAdapter1;
    }
}