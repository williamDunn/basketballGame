namespace Basketball_Game_Program
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTeam1 = new System.Windows.Forms.TextBox();
            this.tbTeam2 = new System.Windows.Forms.TextBox();
            this.btnSetTeam1 = new System.Windows.Forms.Button();
            this.btnSetTeam2 = new System.Windows.Forms.Button();
            this.btnGameOver = new System.Windows.Forms.Button();
            this.scoreTracker2 = new ScoreTracker.ScoreTracker();
            this.scoreTracker1 = new ScoreTracker.ScoreTracker();
            this.SuspendLayout();
            // 
            // tbTeam1
            // 
            this.tbTeam1.Location = new System.Drawing.Point(39, 187);
            this.tbTeam1.Name = "tbTeam1";
            this.tbTeam1.Size = new System.Drawing.Size(100, 20);
            this.tbTeam1.TabIndex = 2;
            // 
            // tbTeam2
            // 
            this.tbTeam2.Location = new System.Drawing.Point(232, 187);
            this.tbTeam2.Name = "tbTeam2";
            this.tbTeam2.Size = new System.Drawing.Size(100, 20);
            this.tbTeam2.TabIndex = 3;
            // 
            // btnSetTeam1
            // 
            this.btnSetTeam1.Location = new System.Drawing.Point(52, 214);
            this.btnSetTeam1.Name = "btnSetTeam1";
            this.btnSetTeam1.Size = new System.Drawing.Size(75, 23);
            this.btnSetTeam1.TabIndex = 4;
            this.btnSetTeam1.Text = "Set Name";
            this.btnSetTeam1.UseVisualStyleBackColor = true;
            this.btnSetTeam1.Click += new System.EventHandler(this.btnSetTeam1_Click);
            // 
            // btnSetTeam2
            // 
            this.btnSetTeam2.Location = new System.Drawing.Point(247, 214);
            this.btnSetTeam2.Name = "btnSetTeam2";
            this.btnSetTeam2.Size = new System.Drawing.Size(75, 23);
            this.btnSetTeam2.TabIndex = 5;
            this.btnSetTeam2.Text = "Set Name";
            this.btnSetTeam2.UseVisualStyleBackColor = true;
            this.btnSetTeam2.Click += new System.EventHandler(this.btnSetTeam2_Click);
            // 
            // btnGameOver
            // 
            this.btnGameOver.Location = new System.Drawing.Point(151, 257);
            this.btnGameOver.Name = "btnGameOver";
            this.btnGameOver.Size = new System.Drawing.Size(75, 23);
            this.btnGameOver.TabIndex = 6;
            this.btnGameOver.Text = "Game Over";
            this.btnGameOver.UseVisualStyleBackColor = true;
            this.btnGameOver.Click += new System.EventHandler(this.btnGameOver_Click);
            // 
            // scoreTracker2
            // 
            this.scoreTracker2.Location = new System.Drawing.Point(217, 28);
            this.scoreTracker2.Margin = new System.Windows.Forms.Padding(2);
            this.scoreTracker2.Name = "scoreTracker2";
            this.scoreTracker2.Score = 0;
            this.scoreTracker2.ScoreColor = System.Drawing.Color.Black;
            this.scoreTracker2.Size = new System.Drawing.Size(140, 154);
            this.scoreTracker2.TabIndex = 1;
            this.scoreTracker2.TeamName = "Concordia";
            // 
            // scoreTracker1
            // 
            this.scoreTracker1.Location = new System.Drawing.Point(23, 28);
            this.scoreTracker1.Margin = new System.Windows.Forms.Padding(2);
            this.scoreTracker1.Name = "scoreTracker1";
            this.scoreTracker1.Score = 0;
            this.scoreTracker1.ScoreColor = System.Drawing.Color.Black;
            this.scoreTracker1.Size = new System.Drawing.Size(140, 154);
            this.scoreTracker1.TabIndex = 0;
            this.scoreTracker1.TeamName = "Dominican";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 292);
            this.Controls.Add(this.btnGameOver);
            this.Controls.Add(this.btnSetTeam2);
            this.Controls.Add(this.btnSetTeam1);
            this.Controls.Add(this.tbTeam2);
            this.Controls.Add(this.tbTeam1);
            this.Controls.Add(this.scoreTracker2);
            this.Controls.Add(this.scoreTracker1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScoreTracker.ScoreTracker scoreTracker1;
        private ScoreTracker.ScoreTracker scoreTracker2;
        private System.Windows.Forms.TextBox tbTeam1;
        private System.Windows.Forms.TextBox tbTeam2;
        private System.Windows.Forms.Button btnSetTeam1;
        private System.Windows.Forms.Button btnSetTeam2;
        private System.Windows.Forms.Button btnGameOver;
    }
}

