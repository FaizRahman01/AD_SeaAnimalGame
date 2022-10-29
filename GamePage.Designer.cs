
namespace AD_SeaAnimalGame
{
    partial class GamePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.panelGamePage = new System.Windows.Forms.Panel();
            this.lblGameTimer = new System.Windows.Forms.Label();
            this.lblGameScore = new System.Windows.Forms.Label();
            this.pboxSubmarine = new System.Windows.Forms.PictureBox();
            this.FishSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.NonFishSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.SubmarineMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.panelGamePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSubmarine)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGamePage
            // 
            this.panelGamePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGamePage.Controls.Add(this.lblGameTimer);
            this.panelGamePage.Controls.Add(this.lblGameScore);
            this.panelGamePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGamePage.Location = new System.Drawing.Point(0, 0);
            this.panelGamePage.Name = "panelGamePage";
            this.panelGamePage.Size = new System.Drawing.Size(1000, 41);
            this.panelGamePage.TabIndex = 8;
            this.panelGamePage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGamePage_MouseDown);
            this.panelGamePage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGamePage_MouseMove);
            // 
            // lblGameTimer
            // 
            this.lblGameTimer.AutoSize = true;
            this.lblGameTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTimer.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGameTimer.Location = new System.Drawing.Point(858, 4);
            this.lblGameTimer.Name = "lblGameTimer";
            this.lblGameTimer.Size = new System.Drawing.Size(142, 33);
            this.lblGameTimer.TabIndex = 7;
            this.lblGameTimer.Text = "Timer : 60 S";
            // 
            // lblGameScore
            // 
            this.lblGameScore.AutoSize = true;
            this.lblGameScore.BackColor = System.Drawing.Color.Transparent;
            this.lblGameScore.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGameScore.Location = new System.Drawing.Point(449, 2);
            this.lblGameScore.Name = "lblGameScore";
            this.lblGameScore.Size = new System.Drawing.Size(104, 33);
            this.lblGameScore.TabIndex = 0;
            this.lblGameScore.Text = "Score : 0";
            // 
            // pboxSubmarine
            // 
            this.pboxSubmarine.BackColor = System.Drawing.Color.Transparent;
            this.pboxSubmarine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSubmarine.BackgroundImage")));
            this.pboxSubmarine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxSubmarine.Location = new System.Drawing.Point(455, 375);
            this.pboxSubmarine.Name = "pboxSubmarine";
            this.pboxSubmarine.Size = new System.Drawing.Size(108, 78);
            this.pboxSubmarine.TabIndex = 9;
            this.pboxSubmarine.TabStop = false;
            // 
            // FishSpawnTimer
            // 
            this.FishSpawnTimer.Enabled = true;
            this.FishSpawnTimer.Interval = 7000;
            this.FishSpawnTimer.Tick += new System.EventHandler(this.FishSpawnTimer_Tick);
            // 
            // NonFishSpawnTimer
            // 
            this.NonFishSpawnTimer.Enabled = true;
            this.NonFishSpawnTimer.Interval = 7500;
            this.NonFishSpawnTimer.Tick += new System.EventHandler(this.NonFishSpawnTimer_Tick);
            // 
            // SubmarineMoveTimer
            // 
            this.SubmarineMoveTimer.Enabled = true;
            this.SubmarineMoveTimer.Interval = 20;
            this.SubmarineMoveTimer.Tick += new System.EventHandler(this.SubmarineMoveTimer_Tick);
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pboxSubmarine);
            this.Controls.Add(this.panelGamePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GamePage";
            this.Text = "GamePage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePage_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePage_KeyUp);
            this.panelGamePage.ResumeLayout(false);
            this.panelGamePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSubmarine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGamePage;
        private System.Windows.Forms.Label lblGameTimer;
        private System.Windows.Forms.Label lblGameScore;
        private System.Windows.Forms.PictureBox pboxSubmarine;
        private System.Windows.Forms.Timer FishSpawnTimer;
        private System.Windows.Forms.Timer NonFishSpawnTimer;
        private System.Windows.Forms.Timer SubmarineMoveTimer;
    }
}