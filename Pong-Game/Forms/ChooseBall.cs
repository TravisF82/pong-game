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
    public partial class ChooseBall : UserControl
    {
        public delegate void OnReturnToMenu();
        public event OnReturnToMenu ReturnToMenu;

        public ChooseBall()
        {
            InitializeComponent();
        }

        private void ChooseBall_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_pointer).GetHicon());
            btnTennisBall.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            btnBowlingBall.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            btnRandom.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            lblBackToMenu.Cursor = new Cursor(((Bitmap)Properties.Resources.cursor_hand).GetHicon());
            getSavedBall();
        }

        private void getSavedBall()
        {
            switch (GameSettings.selected_ball)
            {
                case "Tennis":
                    lblSelected.Location = new Point(lblTennisBall.Location.X, lblTennisBall.Bottom + 80);
                    break;
                case "Bowling":
                    lblSelected.Location = new Point(lblBowlingBall.Location.X, lblBowlingBall.Bottom + 80);
                    break;
                case "Random":
                    lblSelected.Location = new Point(lblRandom.Location.X, lblRandom.Bottom + 80);
                    break;
                default:

                    break;
            }
        }

        private void btnTennisBall_Click(object sender, EventArgs e)
        {
            GameSettings.selected_ball = "Tennis";
            getSavedBall();
            GameSettings.saveSettings();
        }

        private void btnBowlingBall_Click(object sender, EventArgs e)
        {
            GameSettings.selected_ball = "Bowling";
            getSavedBall();
            GameSettings.saveSettings();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            GameSettings.selected_ball = "Random";
            getSavedBall();
            GameSettings.saveSettings();
        }

        private void lblBackToMenu_Click(object sender, EventArgs e)
        {
            ReturnToMenu?.Invoke();
        }
    }
}
