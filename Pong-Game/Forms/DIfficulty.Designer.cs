namespace Pong.Forms
{
    partial class DIfficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIfficulty));
            btnEasy = new Button();
            btnAmateur = new Button();
            btnHard = new Button();
            lblBackToMenu = new Label();
            SuspendLayout();
            // 
            // btnEasy
            // 
            btnEasy.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnEasy.ForeColor = Color.Lime;
            btnEasy.Image = (Image)resources.GetObject("btnEasy.Image");
            btnEasy.Location = new Point(312, 16);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(150, 65);
            btnEasy.TabIndex = 8;
            btnEasy.Text = "Easy";
            btnEasy.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEasy.UseVisualStyleBackColor = false;
            btnEasy.Click += btnEasy_Click;
            btnEasy.MouseEnter += btnEasy_MouseEnter;
            btnEasy.MouseLeave += btnEasy_MouseLeave;
            // 
            // btnAmateur
            // 
            btnAmateur.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnAmateur.ForeColor = Color.Gold;
            btnAmateur.Image = (Image)resources.GetObject("btnAmateur.Image");
            btnAmateur.Location = new Point(312, 100);
            btnAmateur.Name = "btnAmateur";
            btnAmateur.Size = new Size(150, 65);
            btnAmateur.TabIndex = 9;
            btnAmateur.Text = "Amateur";
            btnAmateur.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAmateur.UseVisualStyleBackColor = false;
            btnAmateur.Click += btnAmateur_Click;
            btnAmateur.MouseEnter += btnAmateur_MouseEnter;
            btnAmateur.MouseLeave += btnAmateur_MouseLeave;
            // 
            // btnHard
            // 
            btnHard.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnHard.ForeColor = Color.Red;
            btnHard.Image = (Image)resources.GetObject("btnHard.Image");
            btnHard.Location = new Point(312, 190);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(150, 65);
            btnHard.TabIndex = 10;
            btnHard.Text = "Hard";
            btnHard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnHard.UseVisualStyleBackColor = false;
            btnHard.Click += btnHard_Click;
            btnHard.MouseEnter += btnHard_MouseEnter;
            btnHard.MouseLeave += btnHard_MouseLeave;
            // 
            // lblBackToMenu
            // 
            lblBackToMenu.AutoSize = true;
            lblBackToMenu.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackToMenu.ForeColor = Color.White;
            lblBackToMenu.Location = new Point(197, 271);
            lblBackToMenu.Name = "lblBackToMenu";
            lblBackToMenu.Size = new Size(354, 42);
            lblBackToMenu.TabIndex = 11;
            lblBackToMenu.Text = "<-- Back to Menu";
            lblBackToMenu.Click += lblBackToMenu_Click;
            // 
            // DIfficulty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(lblBackToMenu);
            Controls.Add(btnHard);
            Controls.Add(btnAmateur);
            Controls.Add(btnEasy);
            DoubleBuffered = true;
            Name = "DIfficulty";
            Size = new Size(776, 325);
            Load += DIfficulty_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEasy;
        private Button btnAmateur;
        private Button btnHard;
        private Label lblBackToMenu;
    }
}
