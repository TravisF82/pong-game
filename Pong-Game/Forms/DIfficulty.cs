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
    public partial class DIfficulty : UserControl
    {
        public delegate void ReturnToMenuClick();
        public event ReturnToMenuClick ReturnToMenu;

        public DIfficulty()
        {
            InitializeComponent();
        }

        private void DIfficulty_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_pointer).GetHicon());
            btnEasy.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            btnAmateur.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            btnHard.Cursor = btnEasy.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            lblBackToMenu.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Game game = new Game("single", "easy");
            this.Hide();
            game.Show();
        }

        private void btnAmateur_Click(object sender, EventArgs e)
        {
            Game game = new Game("single", "amateur");
            this.Hide();
            game.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Game game = new Game("single", "hard");
            this.Hide();
            game.Show();
        }

        private void btnEasy_MouseEnter(object sender, EventArgs e)
        {
            btnEasy.FlatStyle = FlatStyle.Flat;
            btnEasy.FlatAppearance.BorderSize = 2;
        }

        private void btnEasy_MouseLeave(object sender, EventArgs e)
        {
            btnEasy.FlatStyle = FlatStyle.Standard;
            btnEasy.FlatAppearance.BorderSize = 1;
        }

        private void btnAmateur_MouseEnter(object sender, EventArgs e)
        {
            btnAmateur.FlatStyle = FlatStyle.Flat;
            btnAmateur.FlatAppearance.BorderSize = 2;
        }

        private void btnAmateur_MouseLeave(object sender, EventArgs e)
        {
            btnAmateur.FlatStyle = FlatStyle.Standard;
            btnAmateur.FlatAppearance.BorderSize = 1;
        }

        private void btnHard_MouseEnter(object sender, EventArgs e)
        {
            btnHard.FlatStyle = FlatStyle.Flat;
            btnHard.FlatAppearance.BorderSize = 2;
        }

        private void btnHard_MouseLeave(object sender, EventArgs e)
        {
            btnHard.FlatStyle = FlatStyle.Standard;
            btnHard.FlatAppearance.BorderSize = 1;
        }

        private void lblBackToMenu_Click(object sender, EventArgs e)
        {
            ReturnToMenu?.Invoke();
        }
    }
}
