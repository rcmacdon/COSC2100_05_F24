using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03DemoA_GuessTheNumber
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            SetGTNDefaults();
        }

        private void SetGTNDefaults()
        {
            cboGTNSettingDifficulty.SelectedIndex = 0;
            SetGTNRandomNumber();
            nudGTNGuess.Value = 1;
            lblGTNOutput.Text = String.Empty;
            btnGTNPlayAgain.Visible = false;
        }

        private void SetGTNRandomNumber()
        {
            nudGTNActualNumber.Value = Tools.RandomInt(1, (int)nudGTNGuess.Maximum);
            nudGTNnumGuesses.Value = 0;
        }
        private void btnGTN_Click(object sender, EventArgs e)
        {
            panGTN.Visible = !panGTN.Visible;
        }

        private void cboGTNSettingDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGTNDifficulty();
        }

        private void SetGTNDifficulty()
        {
            switch (cboGTNSettingDifficulty.SelectedIndex)
            {
                case 1:
                    nudGTNGuess.Maximum = 100;
                    lblGTNGuessMaximum.Text = 100.ToString();
                    break;
                case 2:
                    nudGTNGuess.Maximum = 1000;
                    lblGTNGuessMaximum.Text = 1000.ToString();
                    break;
                default:
                    nudGTNGuess.Maximum = 10;
                    lblGTNGuessMaximum.Text = 10.ToString();
                    break;
            }

            SetGTNRandomNumber();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        private void btnGTNGuess_Click(object sender, EventArgs e)
        {
            nudGTNnumGuesses.Value += 1;

            // compare guess to the random number
            if (nudGTNGuess.Value > nudGTNActualNumber.Value)
            {
                lblGTNOutput.Text += "Guess " + nudGTNnumGuesses.Value + " is TOO HIGH!\n";
            }
            else if (nudGTNGuess.Value < nudGTNActualNumber.Value)
            {
                lblGTNOutput.Text += "Guess " + nudGTNnumGuesses.Value + " is TOO LOW!\n";
            }
            else
            {
                lblGTNOutput.Text += "YEAH! You got it!  It took you " + nudGTNnumGuesses.Value + " guesses!";
                btnGTNPlayAgain.Visible = true;
            }
        }

        private void btnGTNPlayAgain_Click(object sender, EventArgs e)
        {
            SetGTNDefaults();
        }
    }
}
