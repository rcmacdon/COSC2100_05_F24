using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week11Demo_DataGrid_Inheritance_Abstraction.Classes;

namespace Week11Demo_DataGrid_Inheritance_Abstraction
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSampleDataSetJoined.countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.employeeSampleDataSetJoined.countries);
            // TODO: This line of code loads data into the 'employeeSampleDataSetJoined.EmployeeInfo' table. You can move, or remove it, as needed.
            this.employeeInfoTableAdapter.Fill(this.employeeSampleDataSetJoined.EmployeeInfo);

        }


        private void InheritenceTest() 
        {

            Car car = new Car("fhdsj", "Honda", "Civic", 2024, Color.Black, "Sedan", 4);
            Truck truck = new Truck("fdsag", "Ford", "F150", 2023, Color.Orange, 12000, 3, 24000);

            //Vehicle v = new Vehicle();
        
        }


    }
}
