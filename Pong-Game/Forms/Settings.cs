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
    public partial class Settings : UserControl
    {
        public delegate void ReturnToMenuClick();
        public event ReturnToMenuClick ReturnToMenu;

        public Settings()
        {
            InitializeComponent();
            btnMuteSfx.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            lblBackToMenu.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            loadCurrentSettings();
        }

        private void loadCurrentSettings()
        {
            if (GameSettings.sfx_muted)
            {
                btnMuteSfx.BackgroundImage = Properties.Resources.check_icon;
            }
            else
            {
                btnMuteSfx.BackgroundImage = Properties.Resources.x_icon;
            }
        }

        private void btnMuteSfx_Click(object sender, EventArgs e)
        {
            if (GameSettings.sfx_muted)
            {
                GameSettings.sfx_muted = false;
                btnMuteSfx.BackgroundImage = Properties.Resources.x_icon;
            }
            else
            {
                GameSettings.sfx_muted = true;
                btnMuteSfx.BackgroundImage = Properties.Resources.check_icon;
            }
            GameSettings.saveSettings();
        }

        private void lblBackToMenu_Click(object sender, EventArgs e)
        {
            ReturnToMenu?.Invoke();
        }
    }
}
