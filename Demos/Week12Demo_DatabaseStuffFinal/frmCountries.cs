using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12Demo_DatabaseStuffFinal
{
    public partial class frmCountries : Form
    {
        public frmCountries()
        {
            InitializeComponent();
        }

        private void frmCountries_Load(object sender, EventArgs e)
        {
            try
            {
                Country.PopulateCountries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Country.countries;   
        }


        private void Update()
        {
            Country c = new Country();
            c.CountryName = "Clint's Dominion";
            c.RegionID = 1;
            c.CountryID = "CD";

            try {
                if (c.UpdateCountry()) { MessageBox.Show("Country successfully Updated"); }
                else { MessageBox.Show("Country was not Updated");  };
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
