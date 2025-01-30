namespace Pong.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            lblHeader = new Label();
            btnOnePlayer = new Button();
            btnTwoPlayer = new Button();
            btnSettings = new Button();
            pnlContainer = new Panel();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(357, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(102, 42);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "Pong";
            // 
            // btnOnePlayer
            // 
            btnOnePlayer.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnOnePlayer.ForeColor = Color.White;
            btnOnePlayer.Image = (Image)resources.GetObject("btnOnePlayer.Image");
            btnOnePlayer.Location = new Point(312, 85);
            btnOnePlayer.Name = "btnOnePlayer";
            btnOnePlayer.Size = new Size(150, 65);
            btnOnePlayer.TabIndex = 7;
            btnOnePlayer.Text = "One Player";
            btnOnePlayer.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnOnePlayer.UseVisualStyleBackColor = false;
            btnOnePlayer.Click += btnOnePlayer_Click;
            btnOnePlayer.MouseEnter += btnOnePlayer_MouseEnter;
            btnOnePlayer.MouseLeave += btnOnePlayer_MouseLeave;
            // 
            // btnTwoPlayer
            // 
            btnTwoPlayer.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnTwoPlayer.ForeColor = Color.White;
            btnTwoPlayer.Image = (Image)resources.GetObject("btnTwoPlayer.Image");
            btnTwoPlayer.Location = new Point(312, 156);
            btnTwoPlayer.Name = "btnTwoPlayer";
            btnTwoPlayer.Size = new Size(150, 69);
            btnTwoPlayer.TabIndex = 8;
            btnTwoPlayer.Text = "Two Player";
            btnTwoPlayer.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTwoPlayer.UseVisualStyleBackColor = false;
            btnTwoPlayer.Click += btnTwoPlayer_Click;
            btnTwoPlayer.MouseEnter += btnTwoPlayer_MouseEnter;
            btnTwoPlayer.MouseLeave += btnTwoPlayer_MouseLeave;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(312, 231);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(150, 69);
            btnSettings.TabIndex = 9;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            btnSettings.MouseEnter += btnSettings_MouseEnter;
            btnSettings.MouseLeave += btnSettings_MouseLeave;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(btnOnePlayer);
            pnlContainer.Controls.Add(btnSettings);
            pnlContainer.Controls.Add(btnTwoPlayer);
            pnlContainer.Location = new Point(12, 93);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(776, 325);
            pnlContainer.TabIndex = 10;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContainer);
            Controls.Add(lblHeader);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += Menu_FormClosing;
            Load += Menu_Load;
            pnlContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnOnePlayer;
        private Button btnTwoPlayer;
        private Button btnSettings;
        private Panel pnlContainer;
    }
}