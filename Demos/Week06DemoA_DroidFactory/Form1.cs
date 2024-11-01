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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLES
       

        #endregion

        #region Control Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            Droid.PopulateSampleDroids(); // temporary method
            PopulateDroidList();
            ResetDroidEntryForm();
        }

        private void btnSellDroid_Click(object sender, EventArgs e)
        {
            frmInputBox frm = new frmInputBox();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (lboxDroids.SelectedIndex != -1)
                {
                    String dd = lboxDroids.SelectedItem.ToString();

                    // find this droid in the list of droids
                    Droid d = Droid.FindDroid(dd);

                    if (d != null)
                    {
                        d.SellDroid(frm.InputValue, true);
                        PopulateDroidDetails(d);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSetPrimaryColour_Click(object sender, EventArgs e)
        {
           colorDialogMain.ShowDialog();
            lblPrimaryColour.BackColor = colorDialogMain.Color;
        }

        private void btnSecondaryColour_Click(object sender, EventArgs e)
        {
            colorDialogMain.ShowDialog();
            lblSecondaryColour.BackColor = colorDialogMain.Color;
        }

        private void lboxDroids_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxDroids.SelectedIndex != -1) 
            { 
                String dd = lboxDroids.SelectedItem.ToString();
            
                // find this droid in the list of droids
                Droid d = Droid.FindDroid(dd);

                if (d != null)
                {
                    PopulateDroidDetails(d);
                }
            }
        }

        private void btnResetDroid_Click(object sender, EventArgs e)
        {
            ResetDroidEntryForm();
        }

        private void btnSaveDroid_Click(object sender, EventArgs e)
        {

            if (txtDesignation.Text.Trim().Length >= Droid.MIN_DESIGNATION_LENGTH
                && txtDesignation.Text.Trim().Length <= Droid.MAX_DESIGNATION_LENGTH)
            {
                // instantiate a new droid and set it properties
                Droid tempDroid = new Droid();
                tempDroid.Designation = this.txtDesignation.Text.Trim();
                tempDroid.Owner = this.txtOwner.Text.Trim();
                tempDroid.IsInService = this.chkInService.Checked;
                tempDroid.PrimaryColor = this.lblPrimaryColour.BackColor;
                tempDroid.SecondaryColor = this.lblSecondaryColour.BackColor;

                // add it to the list of droids
                Droid.droids.Add(tempDroid);

                // update the listbox to show the latest list
                PopulateDroidList();

                ResetDroidEntryForm();
            }
        }
        #endregion

        #region Custom UI Functions and Methods

        private void PopulateDroidList()
        {
            lboxDroids.Items.Clear();
            foreach (Droid droid in Droid.droids)
            {
                lboxDroids.Items.Add(droid.Designation);
            }
        }

        private void ResetDroidEntryForm()
        {
            txtDesignation.Text = String.Empty;
            txtOwner.Text = String.Empty;
            chkInService.Checked = false;
            lblPrimaryColour.BackColor = Color.Gray;
            lblSecondaryColour.BackColor = Color.Gray;

            txtDesignation.Focus();
        }

        private void PopulateDroidDetails(Droid droid)
        {
            if (droid != null)
            {
                lblDetailsDesignation.Text = droid.Designation;
                lblDetailsOwner.Text = droid.Owner;
                chkDetailsInService.Checked = droid.IsInService;
                lblDetailsPrimaryColour.BackColor = droid.PrimaryColor;
                lblDetailsSecondaryColour.BackColor = droid.SecondaryColor;
            } else
            {
                lblDetailsDesignation.Text = string.Empty;
                lblDetailsOwner.Text = string.Empty;
                chkDetailsInService.Checked = false;
                lblDetailsPrimaryColour.BackColor = Color.Gray;
                lblDetailsSecondaryColour.BackColor = Color.Gray;
            }
        }

        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lboxDroids.SelectedIndex > -1)
            {
                frmDroidEditor frm = new frmDroidEditor(lboxDroids.SelectedItem.ToString());
                frm.ShowDialog();
                PopulateDroidList();
                PopulateDroidDetails(null);

            }
        }
    }
}
