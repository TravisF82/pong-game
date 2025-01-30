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
    public partial class Pause : UserControl
    {
        public delegate void OnGameResumed();
        public event OnGameResumed GameResumed;

        public delegate void OnReturnToMenu();
        public event OnReturnToMenu ReturnToMenu;

        public Pause()
        {
            InitializeComponent();
        }

        private void Pause_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_pointer).GetHicon());
            btnResume.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            btnMainMenu.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            GameResumed?.Invoke();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            ReturnToMenu?.Invoke();
        }

        private void Pause_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                GameResumed?.Invoke();
            }
        }
    }
}
