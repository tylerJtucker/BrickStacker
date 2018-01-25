namespace GameTemplate.Screens
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.stopTimer = new System.Windows.Forms.Timer(this.components);
            this.loseLabel = new System.Windows.Forms.Label();
            this.winSLabel = new System.Windows.Forms.Label();
            this.winBLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 200;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // stopTimer
            // 
            this.stopTimer.Enabled = true;
            this.stopTimer.Interval = 1;
            this.stopTimer.Tick += new System.EventHandler(this.stopTimer_Tick);
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.BackColor = System.Drawing.Color.Red;
            this.loseLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseLabel.Location = new System.Drawing.Point(217, 218);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(113, 34);
            this.loseLabel.TabIndex = 0;
            this.loseLabel.Text = "YOU LOSE";
            // 
            // winSLabel
            // 
            this.winSLabel.AutoSize = true;
            this.winSLabel.BackColor = System.Drawing.Color.Lime;
            this.winSLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winSLabel.Location = new System.Drawing.Point(153, 218);
            this.winSLabel.Name = "winSLabel";
            this.winSLabel.Size = new System.Drawing.Size(244, 34);
            this.winSLabel.TabIndex = 1;
            this.winSLabel.Text = "YOU WIN SMALL PRIZE";
            // 
            // winBLabel
            // 
            this.winBLabel.AutoSize = true;
            this.winBLabel.BackColor = System.Drawing.Color.Lime;
            this.winBLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winBLabel.Location = new System.Drawing.Point(153, 218);
            this.winBLabel.Name = "winBLabel";
            this.winBLabel.Size = new System.Drawing.Size(215, 34);
            this.winBLabel.TabIndex = 2;
            this.winBLabel.Text = "YOU WIN BIG PRIZE";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.winBLabel);
            this.Controls.Add(this.winSLabel);
            this.Controls.Add(this.loseLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(561, 636);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer stopTimer;
        private System.Windows.Forms.Label loseLabel;
        private System.Windows.Forms.Label winSLabel;
        private System.Windows.Forms.Label winBLabel;
    }
}
