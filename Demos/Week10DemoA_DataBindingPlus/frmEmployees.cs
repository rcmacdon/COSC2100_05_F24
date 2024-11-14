using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10DemoA_DataBindingPlus
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSampleDataSetManagers.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.employeeSampleDataSetManagers.employees);
            // TODO: This line of code loads data into the 'employeeSampleDataSetDept.departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.employeeSampleDataSetDept.departments);
            // TODO: This line of code loads data into the 'employeeSampleDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeSampleDataSet.employees);

        }
    }
}
