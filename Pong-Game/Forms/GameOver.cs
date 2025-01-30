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
    public partial class GameOver : UserControl
    {
        public delegate void OnGameRestarted();
        public event OnGameRestarted GameRestarted;

        public delegate void OnGameExited();
        public event OnGameExited GameExited;

        public GameOver()
        {
            InitializeComponent();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_pointer).GetHicon());
            btnPlayAgain.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            btnMainMenu.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            GameRestarted?.Invoke();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            GameExited?.Invoke();
        }
    }
}
