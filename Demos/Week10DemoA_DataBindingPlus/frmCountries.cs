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
    public partial class frmCountries : Form
    {
        public frmCountries()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // do stuff
        }

        private void MyCustomClickEvent(object sender, EventArgs e) { 
            MessageBox.Show("My Custom Click Event");
        }

        private void frmCountries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeSampleDataSet1.countries' table. You can move, or remove it, as needed.
            this.countriesTableAdapter.Fill(this.employeeSampleDataSetCountries.countries);

        }
    }
}
