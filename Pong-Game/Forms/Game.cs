using Microsoft.Win32;
using Pong.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong.Forms
{
    public partial class Game : Form
    {
        GameOver gameOverScreen = new GameOver();
        Pause pauseMenu = new Pause();
        SoundPlayer collision = new SoundPlayer(Properties.Resources.ping_pong_collision_sound);
        SoundPlayer score = new SoundPlayer(Properties.Resources.ping_pong_score_sound);
        Random ran = new Random();
        string game_mode;
        string game_difficulty;
        double ballX_speed = -4;
        double ballY_speed = 4;
        int player_score = 0;
        int computer_score = 0;
        int player_speed = 4;
        int computer_speed = 4;
        bool moving_up;
        bool moving_down;
        int reset_ball_delay = 0;
        bool game_paused = false;
        int collision_count = 0;
        int[] easy_speeds = { 1, 2, 3 };
        int[] amateur_speeds = { 3, 4, 5 };
        int[] hard_speeds = { 5, 6, 7 };
        bool speed_increase_powerup_active = false;
        bool invisible_powerup_active = false;
        bool speed_decrease_powerup_active = false;
        int powerup_cooldown = 10;

        List<Image> balls = new List<Image>
        {
            Properties.Resources.pong_tennis_ball,
            Properties.Resources.pong_bowling_ball,

        };

        public Game(string game_mode, string game_difficulty)
        {
            InitializeComponent();
            center(pauseMenu, (this.ClientSize.Height - pauseMenu.Height) / 2);
            pauseMenu.Visible = false;
            pauseMenu.BringToFront();
            pauseMenu.GameResumed += game_Resumed;
            pauseMenu.ReturnToMenu += returnToMenu;
            this.Controls.Add(pauseMenu);
            center(gameOverScreen, (this.ClientSize.Height - gameOverScreen.Height) / 2);
            gameOverScreen.Visible = false;
            gameOverScreen.BringToFront();
            gameOverScreen.GameRestarted += restartGame;
            gameOverScreen.GameExited += returnToMenu;
            this.Controls.Add(gameOverScreen);
            this.game_mode = game_mode;
            this.game_difficulty = game_difficulty;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            picBall.Image = Properties.Resources.pong_bowling_ball;
            positionScore();
            resetGame();
            tmrGame.Start();
        }

        private void positionScore()
        {
            lblPlayerOneScore.Location = new Point(((this.ClientSize.Width - lblPlayerOneScore.Width) / 2) - 100, 35);
            lblPlayerTwoScore.Location = new Point(((this.ClientSize.Width - lblPlayerTwoScore.Width) / 2) + 100, 35);
        }

        private void center(Control control, int Y)
        {
            control.Location = new Point((this.ClientSize.Width - control.Width) / 2, Y);
        }

        private void chooseRandomBall()
        {
            Image ball = balls[ran.Next(balls.Count)];
            picBall.Image = ball;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    moving_up = true;
                    break;
                case Keys.Down:
                    moving_down = true;
                    break;
            }
        }

        private void ballSpeedIncreasePowerup()
        {
            ballY_speed *= 4;
            ballX_speed *= 4;
        }

        private void ballInvisiblePowerup()
        {
            picBall.Visible = false;
        }

        private void ballSpeedDecreasePowerup()
        {
            ballY_speed /= 4;
            ballX_speed /= 4;
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    moving_up = false;
                    break;
                case Keys.Down:
                    moving_down = false;
                    break;
            }
        }

        private void endGame()
        {
            gameOverScreen.Visible = true;
            this.MouseMove -= Game_MouseMove;
            tmrGame.Stop();
            ballX_speed = 0;
            ballY_speed = 0;
            player_speed = 0;
            player_score = 0;
        }

        private void restartGame()
        {
            gameOverScreen.Visible = false;
            this.MouseMove += Game_MouseMove;
            tmrGame.Start();
            resetPosition();
            player_score = 0;
            computer_score = 0;
        }

        private void resetGame()
        {
            picBall.Location = new Point((this.ClientSize.Width - picBall.Width) / 2, (this.ClientSize.Height - picBall.Height) / 2);
            tmrGame.Start();
        }

        private void resetPosition()
        {
            picBall.Visible = true;
            picBall.Location = new Point((this.ClientSize.Width - picBall.Width) / 2, (this.ClientSize.Height - picBall.Height) / 2);
            collision_count = 0;
            ballX_speed = 4;
            ballY_speed = 4;
            speed_decrease_powerup_active = false;
            speed_increase_powerup_active = false;
            invisible_powerup_active = false;
            poweruptime = 0;
            tmrPowerup.Stop();
        }

        private void checkCollision(PictureBox pic1, PictureBox pic2, int offset)
        {
            var maxBounceAngle = Math.PI / 3; // 60 degrees
            if (pic1.Bounds.IntersectsWith(pic2.Bounds))
            {
                collision_count++;
                var originalSpeed = Math.Sqrt((ballX_speed * ballX_speed) + (ballY_speed * ballY_speed));
                var paddleCenter = pic1.Location.Y + (pic1.Height / 2);
                var ballCenter = pic2.Location.Y + (pic2.Height / 2);
                var normalisedIntersectionY = (double)(ballCenter - paddleCenter) / (pic1.Height / 2);
                normalisedIntersectionY = Math.Max(-1, Math.Min(1, normalisedIntersectionY));
                var bounceAngle = normalisedIntersectionY * maxBounceAngle;

                //Debug.WriteLine($"Normalised Y: {normalisedIntersectionY}, Bounce angle: {Math.Abs(bounceAngle * 180 / Math.PI)} degrees");

                pic2.Left = offset;
                if (!GameSettings.sfx_muted)
                {
                    collision.Play();
                }
                bool isNegative = false;
                if (ballX_speed < 0)
                {
                    isNegative = true;
                }

                ballY_speed = originalSpeed * Math.Sin(bounceAngle);
                ballX_speed = originalSpeed * Math.Cos(bounceAngle);

                if (ballX_speed < 0 && isNegative || !isNegative && ballX_speed > 0)
                {
                    ballX_speed *= -1;
                }

                switch (game_difficulty)
                {
                    case "easy":
                        computer_speed = easy_speeds[ran.Next(easy_speeds.Length)];
                        break;
                    case "amateur":
                        computer_speed = amateur_speeds[ran.Next(amateur_speeds.Length)];
                        break;
                    case "hard":
                        computer_speed = hard_speeds[ran.Next(hard_speeds.Length)];
                        break;
                }

                if (collision_count % 5 == 0 && collision_count < 30)
                {
                    if (ballY_speed < 0)
                    {
                        ballY_speed -= 1;
                    }
                    else
                    {
                        ballY_speed += 1;
                    }
                    if (ballX_speed < 0)
                    {
                        ballX_speed -= 1;
                    }
                    else
                    {
                        ballX_speed += 1;
                    }
                }
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        int ticks = 0;

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            ticks++;
            picBall.Top += (int)ballY_speed;
            picBall.Left += (int)ballX_speed;

            if (picBall.Left > 200 && picBall.Visible && ballX_speed > 0 && game_mode == "single")
            {
                if (ticks % 1000 != 0)
                {
                    if (picBall.Top < picPlayerTwo.Top + (picPlayerTwo.Height / 2) && picPlayerTwo.Top > pnlTop.Top + pnlTop.Height)
                    {
                        picPlayerTwo.Top -= computer_speed;
                    }
                    if (picBall.Top > picPlayerTwo.Top + (picPlayerTwo.Height / 2) && picPlayerTwo.Top < this.ClientSize.Height - pnlBottom.Height - picPlayerOne.Height)
                    {
                        picPlayerTwo.Top += computer_speed;
                    }
                }
            }



            if (picBall.Left < -picBall.Width && picBall.Visible)
            {
                computer_score++;
                picBall.Visible = false;
                if (!GameSettings.sfx_muted)
                {
                    score.Play();
                }
                lblPlayerTwoScore.Text = $"{computer_score}";
                tmrResetBallDelay.Start();
            }
            if (picBall.Left > this.ClientSize.Width && picBall.Visible)
            {
                player_score++;
                picBall.Visible = false;
                if (!GameSettings.sfx_muted)
                {
                    score.Play();
                }
                lblPlayerOneScore.Text = $"{player_score}";
                tmrResetBallDelay.Start();
            }

            if (picBall.Top < pnlTop.Top + pnlTop.Height || picBall.Bottom > this.ClientSize.Height - pnlBottom.Height)
            {
                if (!GameSettings.sfx_muted)
                {
                    collision.Play();
                }
                ballY_speed = -ballY_speed;
            }

            checkCollision(picPlayerOne, picBall, picPlayerOne.Right + 10);
            checkCollision(picPlayerTwo, picBall, picPlayerTwo.Left - 45);

            if (moving_up && picPlayerOne.Top > pnlTop.Top + pnlTop.Height)
            {
                picPlayerOne.Top -= player_speed;
            }
            if (moving_down && picPlayerOne.Bottom < this.ClientSize.Height - pnlBottom.Height)
            {
                picPlayerOne.Top += player_speed;
            }

            if (player_score == 10)
            {
                endGame();
            }
            else if (computer_score == 10)
            {
                endGame();
            }
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y > pnlTop.Top + pnlTop.Height && e.Y < this.ClientSize.Height - pnlBottom.Height - picPlayerOne.Height)
            {
                picPlayerOne.Top = e.Y;
            }
        }

        private void tmrResetBallDelay_Tick(object sender, EventArgs e)
        {
            reset_ball_delay++;
            if (reset_ball_delay == 1)
            {
                resetPosition();
                reset_ball_delay = 0;
                tmrResetBallDelay.Stop();
            }
        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (!game_paused)
                {
                    this.MouseMove -= Game_MouseMove;
                    tmrPowerUpCooldown.Stop();
                    tmrGame.Stop();
                    pauseMenu.Visible = true;
                    game_paused = true;
                }
                else
                {
                    game_Resumed();
                }
            }

            if (powerup_cooldown == 10)
            {
                if (e.KeyChar == (char)Keys.D1 && !speed_increase_powerup_active)
                {
                    ballSpeedIncreasePowerup();
                    speed_increase_powerup_active = true;
                    tmrPowerup.Start();
                    tmrPowerUpCooldown.Start();
                }
                if (e.KeyChar == (char)Keys.D2 && !invisible_powerup_active)
                {
                    ballInvisiblePowerup();
                    invisible_powerup_active = true;
                    tmrPowerup.Start();
                    tmrPowerUpCooldown.Start();
                }
                if (e.KeyChar == (char)Keys.D3 && !speed_decrease_powerup_active)
                {
                    ballSpeedDecreasePowerup();
                    speed_decrease_powerup_active = true;
                    tmrPowerup.Start();
                    tmrPowerUpCooldown.Start();
                }
            }
        }

        private void game_Resumed()
        {
            pauseMenu.Visible = false;
            tmrGame.Start();
            if (powerup_cooldown < 10)
            {
                tmrPowerUpCooldown.Start();
            }
            this.MouseMove += Game_MouseMove;
            this.Focus();
            game_paused = false;
        }

        private void returnToMenu()
        {
            pauseMenu.Hide();
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        int poweruptime = 0;
        private void tmrPowerup_Tick(object sender, EventArgs e)
        {
            poweruptime++;
            if (poweruptime == 1 && speed_increase_powerup_active)
            {
                ballX_speed /= 4;
                ballY_speed /= 4;
                speed_increase_powerup_active = false;
                tmrPowerup.Stop();
                poweruptime = 0;
            }
            if (poweruptime == 2 && invisible_powerup_active)
            {
                picBall.Visible = true;
                invisible_powerup_active = false;
                tmrPowerup.Stop();
                poweruptime = 0;
            }
            if (poweruptime == 3 && speed_decrease_powerup_active)
            {
                ballX_speed *= 2;
                ballY_speed *= 2;
                speed_decrease_powerup_active = false;
                tmrPowerup.Stop();
                poweruptime = 0;
            }
        }

        private void tmrPowerUpCooldown_Tick(object sender, EventArgs e)
        {
            if (powerup_cooldown > 0)
            {
                powerup_cooldown--;
                lblPowerupCooldown.Text = $"Powerups available in {powerup_cooldown} seconds";
            }
            else if (powerup_cooldown == 0)
            {
                powerup_cooldown = 10;
                tmrPowerUpCooldown.Stop();
                lblPowerupCooldown.Text = $"Powerups available!";
            }
        }
    }
}
