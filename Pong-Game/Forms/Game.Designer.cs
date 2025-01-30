namespace Pong.Forms
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            pnlTop = new PictureBox();
            pnlBottom = new PictureBox();
            tmrGame = new System.Windows.Forms.Timer(components);
            picPlayerOne = new PictureBox();
            picPlayerTwo = new PictureBox();
            picBall = new PictureBox();
            lblPlayerOneScore = new Label();
            lblPlayerTwoScore = new Label();
            tmrResetBallDelay = new System.Windows.Forms.Timer(components);
            tmrPowerup = new System.Windows.Forms.Timer(components);
            tmrPowerUpCooldown = new System.Windows.Forms.Timer(components);
            lblPowerupCooldown = new Label();
            ((System.ComponentModel.ISupportInitialize)pnlTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnlBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBall).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 17);
            pnlTop.TabIndex = 0;
            pnlTop.TabStop = false;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 433);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(800, 17);
            pnlBottom.TabIndex = 1;
            pnlBottom.TabStop = false;
            // 
            // tmrGame
            // 
            tmrGame.Interval = 10;
            tmrGame.Tick += tmrGame_Tick;
            // 
            // picPlayerOne
            // 
            picPlayerOne.BackColor = Color.White;
            picPlayerOne.Location = new Point(12, 100);
            picPlayerOne.Name = "picPlayerOne";
            picPlayerOne.Size = new Size(28, 112);
            picPlayerOne.TabIndex = 2;
            picPlayerOne.TabStop = false;
            // 
            // picPlayerTwo
            // 
            picPlayerTwo.BackColor = Color.White;
            picPlayerTwo.Location = new Point(760, 158);
            picPlayerTwo.Name = "picPlayerTwo";
            picPlayerTwo.Size = new Size(28, 112);
            picPlayerTwo.TabIndex = 3;
            picPlayerTwo.TabStop = false;
            // 
            // picBall
            // 
            picBall.BackColor = Color.Transparent;
            picBall.Location = new Point(28, 290);
            picBall.Name = "picBall";
            picBall.Size = new Size(41, 36);
            picBall.SizeMode = PictureBoxSizeMode.Zoom;
            picBall.TabIndex = 4;
            picBall.TabStop = false;
            // 
            // lblPlayerOneScore
            // 
            lblPlayerOneScore.AutoSize = true;
            lblPlayerOneScore.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerOneScore.ForeColor = Color.White;
            lblPlayerOneScore.Location = new Point(263, 34);
            lblPlayerOneScore.Name = "lblPlayerOneScore";
            lblPlayerOneScore.Size = new Size(39, 42);
            lblPlayerOneScore.TabIndex = 5;
            lblPlayerOneScore.Text = "0";
            // 
            // lblPlayerTwoScore
            // 
            lblPlayerTwoScore.AutoSize = true;
            lblPlayerTwoScore.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerTwoScore.ForeColor = Color.White;
            lblPlayerTwoScore.Location = new Point(459, 34);
            lblPlayerTwoScore.Name = "lblPlayerTwoScore";
            lblPlayerTwoScore.Size = new Size(39, 42);
            lblPlayerTwoScore.TabIndex = 6;
            lblPlayerTwoScore.Text = "0";
            // 
            // tmrResetBallDelay
            // 
            tmrResetBallDelay.Interval = 1000;
            tmrResetBallDelay.Tick += tmrResetBallDelay_Tick;
            // 
            // tmrPowerup
            // 
            tmrPowerup.Interval = 1000;
            tmrPowerup.Tick += tmrPowerup_Tick;
            // 
            // tmrPowerUpCooldown
            // 
            tmrPowerUpCooldown.Interval = 1000;
            tmrPowerUpCooldown.Tick += tmrPowerUpCooldown_Tick;
            // 
            // lblPowerupCooldown
            // 
            lblPowerupCooldown.AutoSize = true;
            lblPowerupCooldown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPowerupCooldown.ForeColor = Color.White;
            lblPowerupCooldown.Location = new Point(141, 405);
            lblPowerupCooldown.Name = "lblPowerupCooldown";
            lblPowerupCooldown.Size = new Size(176, 25);
            lblPowerupCooldown.TabIndex = 7;
            lblPowerupCooldown.Text = "Powerups Available";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPowerupCooldown);
            Controls.Add(picPlayerOne);
            Controls.Add(lblPlayerOneScore);
            Controls.Add(lblPlayerTwoScore);
            Controls.Add(picPlayerTwo);
            Controls.Add(picBall);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pong";
            FormClosing += Game_FormClosing;
            Load += Game_Load;
            KeyDown += Game_KeyDown;
            KeyPress += Game_KeyPress;
            KeyUp += Game_KeyUp;
            MouseMove += Game_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pnlTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnlBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayerTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBall).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pnlTop;
        private PictureBox pnlBottom;
        private System.Windows.Forms.Timer tmrGame;
        private PictureBox picPlayerOne;
        private PictureBox picPlayerTwo;
        private PictureBox picBall;
        private Label lblPlayerOneScore;
        private Label lblPlayerTwoScore;
        private System.Windows.Forms.Timer tmrResetBallDelay;
        private System.Windows.Forms.Timer tmrPowerup;
        private System.Windows.Forms.Timer tmrPowerUpCooldown;
        private Label lblPowerupCooldown;
    }
}