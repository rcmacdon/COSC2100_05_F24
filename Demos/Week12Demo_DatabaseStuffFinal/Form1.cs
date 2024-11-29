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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportleaguesDataSetPlayersOnTeams.PlayerRosters' table. You can move, or remove it, as needed.
            //this.playerRosterTableAdapter.Fill(this.sportleaguesDataSetPlayersOnTeams.PlayerRosters);
            // TODO: This line of code loads data into the 'sportleaguesDataSet.teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.sportleaguesDataSet.teams);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1) { 
                this.playerRosterTableAdapter.Fill(this.sportleaguesDataSetPlayersOnTeams.PlayerRosters, (int)comboBox1.SelectedValue);
            }
        }
    }
}
