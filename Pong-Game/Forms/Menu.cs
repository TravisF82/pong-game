using Pong.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            GameSettings.loadSettings();
            this.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_pointer).GetHicon());
            btnOnePlayer.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            btnTwoPlayer.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            btnSettings.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
        }

        private void btnOnePlayer_MouseEnter(object sender, EventArgs e)
        {
            btnOnePlayer.FlatStyle = FlatStyle.Flat;
            btnOnePlayer.FlatAppearance.BorderSize = 2;
        }

        private void btnOnePlayer_MouseLeave(object sender, EventArgs e)
        {
            btnOnePlayer.FlatStyle = FlatStyle.Standard;
            btnOnePlayer.FlatAppearance.BorderSize = 1;
        }

        private void btnTwoPlayer_MouseEnter(object sender, EventArgs e)
        {
            btnTwoPlayer.FlatStyle = FlatStyle.Flat;
            btnTwoPlayer.FlatAppearance.BorderSize = 2;
        }

        private void btnTwoPlayer_MouseLeave(object sender, EventArgs e)
        {
            btnTwoPlayer.FlatStyle = FlatStyle.Standard;
            btnTwoPlayer.FlatAppearance.BorderSize = 1;
        }

        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            DIfficulty difficulty = new DIfficulty();
            difficulty.ReturnToMenu += ReturnToMenu;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(difficulty);
        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {
            Game game = new Game("double", "easy");
            this.Hide();
            game.Show();
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.FlatAppearance.BorderSize = 2;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.FlatStyle = FlatStyle.Standard;
            btnSettings.FlatAppearance.BorderSize = 1;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            Settings settings = new Settings();
            settings.ReturnToMenu += ReturnToMenu;
            pnlContainer.Controls.Add(settings);
        }

        private void ReturnToMenu()
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(btnOnePlayer);
            pnlContainer.Controls.Add(btnTwoPlayer);
            pnlContainer.Controls.Add(btnSettings);
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
