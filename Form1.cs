//William Dunn - Final Exam - 275

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basketball_Game_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (scoreTracker1.Score > scoreTracker2.Score)
            {
                scoreTracker1.ScoreColor = Color.Blue;
                scoreTracker2.ScoreColor = Color.Black;
            }
            else if (scoreTracker2.Score > scoreTracker1.Score)
            {
                scoreTracker2.ScoreColor = Color.Red;
                scoreTracker1.ScoreColor = Color.Black;
            }
            else if (scoreTracker1.Score == scoreTracker2.Score)
            {
                scoreTracker1.ScoreColor = Color.Blue;
                scoreTracker2.ScoreColor = Color.Red;
            }
        }

        private void btnSetTeam1_Click(object sender, EventArgs e)
        {
            scoreTracker1.TeamName = tbTeam1.Text;
        }

        private void btnSetTeam2_Click(object sender, EventArgs e)
        {
            scoreTracker2.TeamName = tbTeam2.Text;
        }

        private void btnGameOver_Click(object sender, EventArgs e)
        {
            if (scoreTracker1.Score > scoreTracker2.Score || scoreTracker2.Score > scoreTracker1.Score)
            {
                String winner = "winner";
                String loser = "loser";
                int wScore = 0;
                int lScore = 0;
                if (scoreTracker1.Score > scoreTracker2.Score)
                {
                    winner = scoreTracker1.TeamName;
                    loser = scoreTracker2.TeamName;
                    wScore = scoreTracker1.Score;
                    lScore = scoreTracker2.Score;
                }
                else if (scoreTracker2.Score > scoreTracker1.Score)
                {
                    winner = scoreTracker2.TeamName;
                    loser = scoreTracker1.TeamName;
                    wScore = scoreTracker2.Score;
                    lScore = scoreTracker1.Score;
                }
                MessageBox.Show(winner + " wins! They beat " + loser + " " + wScore + " to " + lScore + ".");
            }
            else
            {
                MessageBox.Show("Overtime! The game is tied.");
            }
        }
    }
}
