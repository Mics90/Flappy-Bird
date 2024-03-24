namespace Flappy_Bird
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.restartGame = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Green;
            this.scoreText.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(65, 1182);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(180, 57);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.Image = global::Flappy_Bird.Properties.Resources._3;
            this.ground.Location = new System.Drawing.Point(-26, 1097);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1830, 174);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::Flappy_Bird.Properties.Resources.do_what_i_waaant_transparent_warp_pipe_pngs_for_all_flappy_bird_pipe_11563053283bsl2ufs1ea;
            this.pipeBottom.Location = new System.Drawing.Point(1274, 807);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(341, 346);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flappyBird.Image = global::Flappy_Bird.Properties.Resources._1628825274_447000;
            this.flappyBird.Location = new System.Drawing.Point(686, 517);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(135, 120);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::Flappy_Bird.Properties.Resources.down2;
            this.pipeTop.Location = new System.Drawing.Point(447, -129);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(341, 476);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // restartGame
            // 
            this.restartGame.BackColor = System.Drawing.Color.LimeGreen;
            this.restartGame.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartGame.Location = new System.Drawing.Point(615, 462);
            this.restartGame.Name = "restartGame";
            this.restartGame.Size = new System.Drawing.Size(323, 159);
            this.restartGame.TabIndex = 5;
            this.restartGame.Text = "Restart Game!";
            this.restartGame.UseVisualStyleBackColor = false;
            this.restartGame.Visible = false;
            this.restartGame.Click += new System.EventHandler(this.restartTheGame);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Crimson;
            this.exit.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(615, 616);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(323, 159);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit!";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exitTheGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1531, 1262);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.restartGame);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.FlappyBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button restartGame;
        private System.Windows.Forms.Button exit;
    }
}

