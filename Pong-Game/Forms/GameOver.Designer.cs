namespace Pong.Forms
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            btnMainMenu = new Button();
            btnPlayAgain = new Button();
            lblGameOver = new Label();
            SuspendLayout();
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnMainMenu.ForeColor = Color.White;
            btnMainMenu.Image = (Image)resources.GetObject("btnMainMenu.Image");
            btnMainMenu.Location = new Point(209, 119);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(150, 65);
            btnMainMenu.TabIndex = 11;
            btnMainMenu.Text = "Exit";
            btnMainMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnPlayAgain.ForeColor = Color.White;
            btnPlayAgain.Image = (Image)resources.GetObject("btnPlayAgain.Image");
            btnPlayAgain.Location = new Point(35, 119);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(150, 65);
            btnPlayAgain.TabIndex = 10;
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPlayAgain.UseVisualStyleBackColor = false;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameOver.ForeColor = Color.White;
            lblGameOver.Location = new Point(93, 28);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(208, 29);
            lblGameOver.TabIndex = 12;
            lblGameOver.Text = "Player 1 Wins";
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(lblGameOver);
            Controls.Add(btnMainMenu);
            Controls.Add(btnPlayAgain);
            DoubleBuffered = true;
            Name = "GameOver";
            Size = new Size(394, 303);
            Load += GameOver_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMainMenu;
        private Button btnPlayAgain;
        private Label lblGameOver;
    }
}
