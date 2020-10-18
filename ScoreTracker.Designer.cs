namespace ScoreTracker
{
    partial class ScoreTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblTeamScore = new System.Windows.Forms.Label();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnAddTwo = new System.Windows.Forms.Button();
            this.btnAddThree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(18, 19);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(65, 13);
            this.lblTeamName.TabIndex = 0;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblTeamScore
            // 
            this.lblTeamScore.AutoSize = true;
            this.lblTeamScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamScore.Location = new System.Drawing.Point(14, 42);
            this.lblTeamScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamScore.Name = "lblTeamScore";
            this.lblTeamScore.Size = new System.Drawing.Size(100, 37);
            this.lblTeamScore.TabIndex = 1;
            this.lblTeamScore.Text = "Score";
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(13, 98);
            this.btnAddOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(32, 26);
            this.btnAddOne.TabIndex = 2;
            this.btnAddOne.Text = "+1";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnAddTwo
            // 
            this.btnAddTwo.Location = new System.Drawing.Point(50, 98);
            this.btnAddTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTwo.Name = "btnAddTwo";
            this.btnAddTwo.Size = new System.Drawing.Size(32, 26);
            this.btnAddTwo.TabIndex = 3;
            this.btnAddTwo.Text = "+2";
            this.btnAddTwo.UseVisualStyleBackColor = true;
            this.btnAddTwo.Click += new System.EventHandler(this.btnAddTwo_Click);
            // 
            // btnAddThree
            // 
            this.btnAddThree.Location = new System.Drawing.Point(86, 98);
            this.btnAddThree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddThree.Name = "btnAddThree";
            this.btnAddThree.Size = new System.Drawing.Size(32, 26);
            this.btnAddThree.TabIndex = 4;
            this.btnAddThree.Text = "+3";
            this.btnAddThree.UseVisualStyleBackColor = true;
            this.btnAddThree.Click += new System.EventHandler(this.btnAddThree_Click);
            // 
            // ScoreTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddThree);
            this.Controls.Add(this.btnAddTwo);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.lblTeamScore);
            this.Controls.Add(this.lblTeamName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ScoreTracker";
            this.Size = new System.Drawing.Size(140, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblTeamScore;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnAddTwo;
        private System.Windows.Forms.Button btnAddThree;
    }
}
