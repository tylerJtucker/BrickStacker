namespace GameTemplate.Screens
{
    partial class ScoreScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.prizeTick = new System.Windows.Forms.Timer(this.components);
            this.prizeButton = new System.Windows.Forms.Button();
            this.prizesLeftS = new System.Windows.Forms.Label();
            this.prizeLeftB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bPrizeBox2 = new System.Windows.Forms.PictureBox();
            this.bPrizeBox1 = new System.Windows.Forms.PictureBox();
            this.bPrizeBox4 = new System.Windows.Forms.PictureBox();
            this.sPrizeBox2 = new System.Windows.Forms.PictureBox();
            this.sPrizeBox3 = new System.Windows.Forms.PictureBox();
            this.sPrizeBox4 = new System.Windows.Forms.PictureBox();
            this.sPrizeBox1 = new System.Windows.Forms.PictureBox();
            this.bPrizeBox3 = new System.Windows.Forms.PictureBox();
            this.prizeWon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPrizeBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPrizeBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPrizeBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPrizeBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPrizeBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPrizeBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPrizeBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPrizeBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prizeWon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.YellowGreen;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(2, 2);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(53, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // prizeTick
            // 
            this.prizeTick.Enabled = true;
            this.prizeTick.Interval = 16;
            this.prizeTick.Tick += new System.EventHandler(this.prizeTick_Tick);
            // 
            // prizeButton
            // 
            this.prizeButton.Location = new System.Drawing.Point(182, 300);
            this.prizeButton.Name = "prizeButton";
            this.prizeButton.Size = new System.Drawing.Size(75, 23);
            this.prizeButton.TabIndex = 13;
            this.prizeButton.Text = "Get Prize";
            this.prizeButton.UseVisualStyleBackColor = true;
            this.prizeButton.Click += new System.EventHandler(this.prizeButton_Click);
            // 
            // prizesLeftS
            // 
            this.prizesLeftS.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizesLeftS.Location = new System.Drawing.Point(380, 305);
            this.prizesLeftS.Name = "prizesLeftS";
            this.prizesLeftS.Size = new System.Drawing.Size(184, 27);
            this.prizesLeftS.TabIndex = 23;
            // 
            // prizeLeftB
            // 
            this.prizeLeftB.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeLeftB.Location = new System.Drawing.Point(380, 332);
            this.prizeLeftB.Name = "prizeLeftB";
            this.prizeLeftB.Size = new System.Drawing.Size(184, 27);
            this.prizeLeftB.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-49, 439);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 36);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // bPrizeBox2
            // 
            this.bPrizeBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPrizeBox2.BackgroundImage")));
            this.bPrizeBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrizeBox2.Location = new System.Drawing.Point(158, 507);
            this.bPrizeBox2.Name = "bPrizeBox2";
            this.bPrizeBox2.Size = new System.Drawing.Size(82, 67);
            this.bPrizeBox2.TabIndex = 21;
            this.bPrizeBox2.TabStop = false;
            // 
            // bPrizeBox1
            // 
            this.bPrizeBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPrizeBox1.BackgroundImage")));
            this.bPrizeBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrizeBox1.Location = new System.Drawing.Point(19, 507);
            this.bPrizeBox1.Name = "bPrizeBox1";
            this.bPrizeBox1.Size = new System.Drawing.Size(82, 67);
            this.bPrizeBox1.TabIndex = 20;
            this.bPrizeBox1.TabStop = false;
            // 
            // bPrizeBox4
            // 
            this.bPrizeBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPrizeBox4.BackgroundImage")));
            this.bPrizeBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrizeBox4.Location = new System.Drawing.Point(442, 507);
            this.bPrizeBox4.Name = "bPrizeBox4";
            this.bPrizeBox4.Size = new System.Drawing.Size(88, 67);
            this.bPrizeBox4.TabIndex = 19;
            this.bPrizeBox4.TabStop = false;
            // 
            // sPrizeBox2
            // 
            this.sPrizeBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPrizeBox2.BackgroundImage")));
            this.sPrizeBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sPrizeBox2.Location = new System.Drawing.Point(158, 368);
            this.sPrizeBox2.Name = "sPrizeBox2";
            this.sPrizeBox2.Size = new System.Drawing.Size(82, 65);
            this.sPrizeBox2.TabIndex = 18;
            this.sPrizeBox2.TabStop = false;
            // 
            // sPrizeBox3
            // 
            this.sPrizeBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPrizeBox3.BackgroundImage")));
            this.sPrizeBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sPrizeBox3.Location = new System.Drawing.Point(297, 368);
            this.sPrizeBox3.Name = "sPrizeBox3";
            this.sPrizeBox3.Size = new System.Drawing.Size(83, 65);
            this.sPrizeBox3.TabIndex = 17;
            this.sPrizeBox3.TabStop = false;
            // 
            // sPrizeBox4
            // 
            this.sPrizeBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPrizeBox4.BackgroundImage")));
            this.sPrizeBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sPrizeBox4.Location = new System.Drawing.Point(442, 368);
            this.sPrizeBox4.Name = "sPrizeBox4";
            this.sPrizeBox4.Size = new System.Drawing.Size(88, 65);
            this.sPrizeBox4.TabIndex = 16;
            this.sPrizeBox4.TabStop = false;
            // 
            // sPrizeBox1
            // 
            this.sPrizeBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPrizeBox1.BackgroundImage")));
            this.sPrizeBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sPrizeBox1.Location = new System.Drawing.Point(19, 368);
            this.sPrizeBox1.Name = "sPrizeBox1";
            this.sPrizeBox1.Size = new System.Drawing.Size(82, 65);
            this.sPrizeBox1.TabIndex = 15;
            this.sPrizeBox1.TabStop = false;
            // 
            // bPrizeBox3
            // 
            this.bPrizeBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bPrizeBox3.BackgroundImage")));
            this.bPrizeBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrizeBox3.Location = new System.Drawing.Point(297, 507);
            this.bPrizeBox3.Name = "bPrizeBox3";
            this.bPrizeBox3.Size = new System.Drawing.Size(83, 67);
            this.bPrizeBox3.TabIndex = 14;
            this.bPrizeBox3.TabStop = false;
            // 
            // prizeWon
            // 
            this.prizeWon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.prizeWon.Location = new System.Drawing.Point(231, 148);
            this.prizeWon.Name = "prizeWon";
            this.prizeWon.Size = new System.Drawing.Size(188, 146);
            this.prizeWon.TabIndex = 12;
            this.prizeWon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-49, 580);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(616, 36);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // ScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.prizeLeftB);
            this.Controls.Add(this.prizesLeftS);
            this.Controls.Add(this.bPrizeBox2);
            this.Controls.Add(this.bPrizeBox1);
            this.Controls.Add(this.bPrizeBox4);
            this.Controls.Add(this.sPrizeBox2);
            this.Controls.Add(this.sPrizeBox3);
            this.Controls.Add(this.sPrizeBox4);
            this.Controls.Add(this.sPrizeBox1);
            this.Controls.Add(this.bPrizeBox3);
            this.Controls.Add(this.prizeButton);
            this.Controls.Add(this.prizeWon);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScoreScreen";
            this.Size = new System.Drawing.Size(567, 702);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScoreScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPrizeBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPrizeBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPrizeBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPrizeBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPrizeBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPrizeBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPrizeBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPrizeBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prizeWon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Timer prizeTick;
        private System.Windows.Forms.PictureBox prizeWon;
        private System.Windows.Forms.Button prizeButton;
        private System.Windows.Forms.PictureBox bPrizeBox3;
        private System.Windows.Forms.PictureBox sPrizeBox1;
        private System.Windows.Forms.PictureBox sPrizeBox4;
        private System.Windows.Forms.PictureBox sPrizeBox3;
        private System.Windows.Forms.PictureBox sPrizeBox2;
        private System.Windows.Forms.PictureBox bPrizeBox4;
        private System.Windows.Forms.PictureBox bPrizeBox1;
        private System.Windows.Forms.PictureBox bPrizeBox2;
        private System.Windows.Forms.Label prizesLeftS;
        private System.Windows.Forms.Label prizeLeftB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
