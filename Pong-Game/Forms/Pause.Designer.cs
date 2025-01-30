namespace Pong.Forms
{
    partial class Pause
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pause));
            btnResume = new Button();
            btnMainMenu = new Button();
            lblHeader = new Label();
            SuspendLayout();
            // 
            // btnResume
            // 
            btnResume.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnResume.ForeColor = Color.White;
            btnResume.Image = (Image)resources.GetObject("btnResume.Image");
            btnResume.Location = new Point(22, 115);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(150, 65);
            btnResume.TabIndex = 8;
            btnResume.Text = "Resume ";
            btnResume.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnResume.UseVisualStyleBackColor = false;
            btnResume.Click += btnResume_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Unispace", 14.25F, FontStyle.Bold);
            btnMainMenu.ForeColor = Color.White;
            btnMainMenu.Image = (Image)resources.GetObject("btnMainMenu.Image");
            btnMainMenu.Location = new Point(196, 115);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(150, 65);
            btnMainMenu.TabIndex = 9;
            btnMainMenu.Text = "Exit";
            btnMainMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Unispace", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(116, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(144, 42);
            lblHeader.TabIndex = 10;
            lblHeader.Text = "Paused";
            // 
            // Pause
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(lblHeader);
            Controls.Add(btnMainMenu);
            Controls.Add(btnResume);
            DoubleBuffered = true;
            Name = "Pause";
            Size = new Size(394, 303);
            Load += Pause_Load;
            KeyPress += Pause_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnResume;
        private Button btnMainMenu;
        private Label lblHeader;
    }
}
