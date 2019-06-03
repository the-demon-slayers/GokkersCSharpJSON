using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GokkersApp
{
    public partial class PointBetWindow : Form
    {
        public string team1name;
        public string team2name;
        public int team1points;
        public int team2points;
        public int selectedTeamSide;
        public void RefreshText()
        {
            team1Label.Text = team1name;
            team2Label.Text = team2name;
        }
        public PointBetWindow()
        {
            InitializeComponent();
            team1Choice.Checked = true;
            team2Choice.Checked = false;
            selectedTeamSide = 0;
        }

        private void PointBetWindow_Load(object sender, EventArgs e)
        {
            RefreshText();
        }

        private void confirmPointButton_Click(object sender, EventArgs e)
        {
            team1points = (int)team1Incrementor.Value;
            team2points = (int)team2Incrementor.Value;
            
            this.Close();
        }

        private void team1Choice_Click(object sender, EventArgs e)
        {
            team1Choice.Checked = true;
            team2Choice.Checked = false;
            selectedTeamSide = 0;
        }

        private void team2Choice_Click(object sender, EventArgs e)
        {
            team2Choice.Checked = true;
            team1Choice.Checked = false;
            selectedTeamSide = 1;
        }
    }
}
