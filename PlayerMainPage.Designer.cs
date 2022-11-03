
namespace AD_SeaAnimalGame
{
    partial class PlayerMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerMainPage));
            this.panelPMainPage = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPlayNow = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPMainPage
            // 
            this.panelPMainPage.BackColor = System.Drawing.Color.Transparent;
            this.panelPMainPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPMainPage.Location = new System.Drawing.Point(0, 0);
            this.panelPMainPage.Name = "panelPMainPage";
            this.panelPMainPage.Size = new System.Drawing.Size(984, 41);
            this.panelPMainPage.TabIndex = 7;
            this.panelPMainPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPMainPage_MouseDown);
            this.panelPMainPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPMainPage_MouseMove);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuit.Location = new System.Drawing.Point(22, 568);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 67);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlayNow
            // 
            this.btnPlayNow.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayNow.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg;
            this.btnPlayNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayNow.FlatAppearance.BorderSize = 0;
            this.btnPlayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayNow.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnPlayNow.ForeColor = System.Drawing.Color.White;
            this.btnPlayNow.Location = new System.Drawing.Point(578, 350);
            this.btnPlayNow.Name = "btnPlayNow";
            this.btnPlayNow.Size = new System.Drawing.Size(140, 70);
            this.btnPlayNow.TabIndex = 9;
            this.btnPlayNow.Text = "PLAY NOW";
            this.btnPlayNow.UseVisualStyleBackColor = false;
            this.btnPlayNow.Click += new System.EventHandler(this.btnPlayNow_Click);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.Transparent;
            this.btnScore.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg;
            this.btnScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnScore.ForeColor = System.Drawing.Color.White;
            this.btnScore.Location = new System.Drawing.Point(578, 453);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(140, 70);
            this.btnScore.TabIndex = 10;
            this.btnScore.Text = "SCORE";
            this.btnScore.UseVisualStyleBackColor = false;
            // 
            // PlayerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPlayNow);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.panelPMainPage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fish Legends";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPMainPage;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlayNow;
        private System.Windows.Forms.Button btnScore;
    }
}