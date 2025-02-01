namespace Pong.Forms
{
    partial class ChooseBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseBall));
            lblChooseBall = new Label();
            pnlContainer = new Panel();
            btnRandom = new Button();
            lblRandom = new Label();
            lblSelected = new Label();
            btnBowlingBall = new Button();
            lblBowlingBall = new Label();
            btnTennisBall = new Button();
            lblTennisBall = new Label();
            lblBackToMenu = new Label();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblChooseBall
            // 
            lblChooseBall.AutoSize = true;
            lblChooseBall.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChooseBall.ForeColor = Color.White;
            lblChooseBall.Location = new Point(210, 5);
            lblChooseBall.Name = "lblChooseBall";
            lblChooseBall.Size = new Size(354, 42);
            lblChooseBall.TabIndex = 8;
            lblChooseBall.Text = "Choose Your Ball";
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(btnRandom);
            pnlContainer.Controls.Add(lblRandom);
            pnlContainer.Controls.Add(lblSelected);
            pnlContainer.Controls.Add(btnBowlingBall);
            pnlContainer.Controls.Add(lblBowlingBall);
            pnlContainer.Controls.Add(btnTennisBall);
            pnlContainer.Controls.Add(lblTennisBall);
            pnlContainer.Location = new Point(24, 44);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(730, 233);
            pnlContainer.TabIndex = 9;
            // 
            // btnRandom
            // 
            btnRandom.BackgroundImage = (Image)resources.GetObject("btnRandom.BackgroundImage");
            btnRandom.BackgroundImageLayout = ImageLayout.Stretch;
            btnRandom.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnRandom.ForeColor = Color.White;
            btnRandom.Location = new Point(354, 60);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(47, 47);
            btnRandom.TabIndex = 15;
            btnRandom.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRandom.UseVisualStyleBackColor = false;
            btnRandom.Click += btnRandom_Click;
            // 
            // lblRandom
            // 
            lblRandom.AutoSize = true;
            lblRandom.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRandom.ForeColor = Color.White;
            lblRandom.Location = new Point(333, 11);
            lblRandom.Name = "lblRandom";
            lblRandom.Size = new Size(90, 25);
            lblRandom.TabIndex = 14;
            lblRandom.Text = "Random";
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelected.ForeColor = Color.LimeGreen;
            lblSelected.Location = new Point(155, 110);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(116, 25);
            lblSelected.TabIndex = 13;
            lblSelected.Text = "Selected";
            // 
            // btnBowlingBall
            // 
            btnBowlingBall.BackgroundImage = (Image)resources.GetObject("btnBowlingBall.BackgroundImage");
            btnBowlingBall.BackgroundImageLayout = ImageLayout.Stretch;
            btnBowlingBall.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnBowlingBall.ForeColor = Color.White;
            btnBowlingBall.Location = new Point(186, 60);
            btnBowlingBall.Name = "btnBowlingBall";
            btnBowlingBall.Size = new Size(47, 47);
            btnBowlingBall.TabIndex = 12;
            btnBowlingBall.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBowlingBall.UseVisualStyleBackColor = false;
            btnBowlingBall.Click += btnBowlingBall_Click;
            // 
            // lblBowlingBall
            // 
            lblBowlingBall.AutoSize = true;
            lblBowlingBall.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBowlingBall.ForeColor = Color.White;
            lblBowlingBall.Location = new Point(165, 11);
            lblBowlingBall.Name = "lblBowlingBall";
            lblBowlingBall.Size = new Size(103, 25);
            lblBowlingBall.TabIndex = 11;
            lblBowlingBall.Text = "Bowling";
            // 
            // btnTennisBall
            // 
            btnTennisBall.BackgroundImage = (Image)resources.GetObject("btnTennisBall.BackgroundImage");
            btnTennisBall.BackgroundImageLayout = ImageLayout.Stretch;
            btnTennisBall.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnTennisBall.ForeColor = Color.White;
            btnTennisBall.Location = new Point(47, 60);
            btnTennisBall.Name = "btnTennisBall";
            btnTennisBall.Size = new Size(47, 47);
            btnTennisBall.TabIndex = 10;
            btnTennisBall.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTennisBall.UseVisualStyleBackColor = false;
            btnTennisBall.Click += btnTennisBall_Click;
            // 
            // lblTennisBall
            // 
            lblTennisBall.AutoSize = true;
            lblTennisBall.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTennisBall.ForeColor = Color.White;
            lblTennisBall.Location = new Point(26, 11);
            lblTennisBall.Name = "lblTennisBall";
            lblTennisBall.Size = new Size(90, 25);
            lblTennisBall.TabIndex = 9;
            lblTennisBall.Text = "Tennis";
            // 
            // lblBackToMenu
            // 
            lblBackToMenu.AutoSize = true;
            lblBackToMenu.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBackToMenu.ForeColor = Color.White;
            lblBackToMenu.Location = new Point(261, 286);
            lblBackToMenu.Name = "lblBackToMenu";
            lblBackToMenu.Size = new Size(253, 29);
            lblBackToMenu.TabIndex = 10;
            lblBackToMenu.Text = "<-- Back to Menu";
            lblBackToMenu.Click += lblBackToMenu_Click;
            // 
            // ChooseBall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(lblBackToMenu);
            Controls.Add(pnlContainer);
            Controls.Add(lblChooseBall);
            Name = "ChooseBall";
            Size = new Size(776, 325);
            Load += ChooseBall_Load;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChooseBall;
        private Panel pnlContainer;
        private Label lblTennisBall;
        private Button btnBowlingBall;
        private Label lblBowlingBall;
        private Button btnTennisBall;
        private Label lblSelected;
        private Button btnRandom;
        private Label lblRandom;
        private Label lblBackToMenu;
    }
}
