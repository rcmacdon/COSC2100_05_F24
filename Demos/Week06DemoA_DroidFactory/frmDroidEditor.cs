using Demo_w06a_DroidFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week06DemoA_DroidFactory
{
    public partial class frmDroidEditor : Form
    {

        private Droid droid;

        #region Constructors

        //public frmDroidEditor()
        //{
        //    InitializeComponent();
        //}

        public frmDroidEditor(string droidDesignation)
        {
            InitializeComponent();
            droid = Droid.FindDroid(droidDesignation);
            if (droid != null) PopulateForm();
        }
        #endregion

        #region Custom Methods

        private void PopulateForm()
        {
            lblDroidDesignation.Text = droid.Designation;
            txtDesignation.Text = droid.Designation;
            txtOwner.Text = droid.Owner;
            chkInService.Checked = droid.IsInService;
            lblPrimaryColour.BackColor = droid.PrimaryColor;
            lblSecondaryColour.BackColor = droid.SecondaryColor;
        }

        #endregion

        #region Events

        private void btnResetDroid_Click(object sender, EventArgs e)
        {
            PopulateForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveDroid_Click(object sender, EventArgs e)
        {
            droid.Designation = txtDesignation.Text;
            droid.IsInService = chkInService.Checked;
            droid.Owner = txtOwner.Text;
            droid.PrimaryColor = lblPrimaryColour.BackColor;
            droid.SecondaryColor = lblSecondaryColour.BackColor;
            this.Close();
        }

        private void btnSetPrimaryColour_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblPrimaryColour.BackColor;
            colorDialog1.ShowDialog();
            lblPrimaryColour.BackColor = colorDialog1.Color;
        }

        private void btnSecondaryColour_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblSecondaryColour.BackColor;
            colorDialog1.ShowDialog();
            lblSecondaryColour.BackColor = colorDialog1.Color;
        }

        #endregion

    }
}
