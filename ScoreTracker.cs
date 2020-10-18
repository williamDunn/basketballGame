//William Dunn - Final Exam - 275

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreTracker
{
    public partial class ScoreTracker: UserControl
    {
        public ScoreTracker()
        {
            InitializeComponent();
            lblTeamName.Text = "Unknown";
            lblTeamScore.Text = "0";
            lblTeamScore.ForeColor = Color.Black;
        }

        private void AddToTotal(int points)
        {
            int total = int.Parse(lblTeamScore.Text);
            total += points;

            lblTeamScore.Text = total.ToString();
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            AddToTotal(1);
            if(ScoreChanged != null)
            {
                ScoreChanged(this, new EventArgs());
            }
        }

        private void btnAddTwo_Click(object sender, EventArgs e)
        {
            AddToTotal(2);
            if (ScoreChanged != null)
            {
                ScoreChanged(this, new EventArgs());
            }
        }

        private void btnAddThree_Click(object sender, EventArgs e)
        {
            AddToTotal(3);
            if (ScoreChanged != null)
            {
                ScoreChanged(this, new EventArgs());
            }
        }

        public int Score
        {
            get { return int.Parse(lblTeamScore.Text); }
            set { if(value < 0)
                {
                    lblTeamScore.Text = "0";
                    if (ScoreChanged != null)
                    {
                        ScoreChanged(this, new EventArgs());
                    }
                }
                else if (int.Parse(lblTeamScore.Text) == value)
                    {
                        lblTeamScore.Text = value.ToString();
                    }
                else
                {
                    lblTeamScore.Text = value.ToString();
                }
                if (ScoreChanged != null)
                {
                    ScoreChanged(this, new EventArgs());
                }
            }
        }
        public String TeamName
        {
            get { return lblTeamName.Text; }
            set { lblTeamName.Text = value; }
        }

        public Color ScoreColor
        {
            get { return lblTeamScore.ForeColor; }
            set { lblTeamScore.ForeColor = value; }
        }

        public event EventHandler<EventArgs> ScoreChanged;

    }
}
