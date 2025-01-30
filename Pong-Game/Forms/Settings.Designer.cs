namespace Pong.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            lblMuteSfx = new Label();
            btnMuteSfx = new Button();
            lblBackToMenu = new Label();
            lblHowToPlay = new Label();
            lblControls = new Label();
            SuspendLayout();
            // 
            // lblMuteSfx
            // 
            lblMuteSfx.AutoSize = true;
            lblMuteSfx.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMuteSfx.ForeColor = Color.White;
            lblMuteSfx.Location = new Point(123, 18);
            lblMuteSfx.Name = "lblMuteSfx";
            lblMuteSfx.Size = new Size(186, 42);
            lblMuteSfx.TabIndex = 7;
            lblMuteSfx.Text = "Mute SFX";
            // 
            // btnMuteSfx
            // 
            btnMuteSfx.BackgroundImage = (Image)resources.GetObject("btnMuteSfx.BackgroundImage");
            btnMuteSfx.BackgroundImageLayout = ImageLayout.Stretch;
            btnMuteSfx.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnMuteSfx.ForeColor = Color.White;
            btnMuteSfx.Location = new Point(128, 74);
            btnMuteSfx.Name = "btnMuteSfx";
            btnMuteSfx.Size = new Size(47, 47);
            btnMuteSfx.TabIndex = 8;
            btnMuteSfx.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMuteSfx.UseVisualStyleBackColor = false;
            btnMuteSfx.Click += btnMuteSfx_Click;
            // 
            // lblBackToMenu
            // 
            lblBackToMenu.AutoSize = true;
            lblBackToMenu.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackToMenu.ForeColor = Color.White;
            lblBackToMenu.Location = new Point(209, 261);
            lblBackToMenu.Name = "lblBackToMenu";
            lblBackToMenu.Size = new Size(354, 42);
            lblBackToMenu.TabIndex = 9;
            lblBackToMenu.Text = "<-- Back to Menu";
            lblBackToMenu.Click += lblBackToMenu_Click;
            // 
            // lblHowToPlay
            // 
            lblHowToPlay.AutoSize = true;
            lblHowToPlay.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHowToPlay.ForeColor = Color.White;
            lblHowToPlay.Location = new Point(452, 18);
            lblHowToPlay.Name = "lblHowToPlay";
            lblHowToPlay.Size = new Size(270, 42);
            lblHowToPlay.TabIndex = 10;
            lblHowToPlay.Text = "How To Play:";
            // 
            // lblControls
            // 
            lblControls.AutoSize = true;
            lblControls.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblControls.ForeColor = Color.White;
            lblControls.Location = new Point(400, 74);
            lblControls.Name = "lblControls";
            lblControls.Size = new Size(373, 145);
            lblControls.TabIndex = 11;
            lblControls.Text = "Move Paddle - Drag Mouse\r\nPowerups:\r\n1 - Speed Increase\r\n2 - Speed Decrease\r\n3 - Ball Invisibility\r\n";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(lblControls);
            Controls.Add(lblHowToPlay);
            Controls.Add(lblBackToMenu);
            Controls.Add(btnMuteSfx);
            Controls.Add(lblMuteSfx);
            Name = "Settings";
            Size = new Size(776, 325);
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMuteSfx;
        private Button btnMuteSfx;
        private Label lblBackToMenu;
        private Label lblHowToPlay;
        private Label lblControls;
    }
}
