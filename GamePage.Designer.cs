
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
            this.pboxSubmarine = new System.Windows.Forms.PictureBox();
            this.FishSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.NonFishSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.SubmarineMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.lblNotFishCatch = new System.Windows.Forms.Label();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGameScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSubmarine)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxSubmarine
            // 
            this.pboxSubmarine.BackColor = System.Drawing.Color.Transparent;
            this.pboxSubmarine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSubmarine.BackgroundImage")));
            this.pboxSubmarine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxSubmarine.Location = new System.Drawing.Point(863, 593);
            this.pboxSubmarine.Name = "pboxSubmarine";
            this.pboxSubmarine.Size = new System.Drawing.Size(108, 78);
            this.pboxSubmarine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
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
            // lblNotFishCatch
            // 
            this.lblNotFishCatch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNotFishCatch.AutoSize = true;
            this.lblNotFishCatch.BackColor = System.Drawing.Color.Transparent;
            this.lblNotFishCatch.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotFishCatch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNotFishCatch.Location = new System.Drawing.Point(12, 9);
            this.lblNotFishCatch.Name = "lblNotFishCatch";
            this.lblNotFishCatch.Size = new System.Drawing.Size(83, 33);
            this.lblNotFishCatch.TabIndex = 12;
            this.lblNotFishCatch.Text = "Fail : 0";
            this.lblNotFishCatch.Visible = false;
            // 
            // panelGameOver
            // 
            this.panelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.panelGameOver.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.gameover;
            this.panelGameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGameOver.Location = new System.Drawing.Point(338, 170);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(337, 238);
            this.panelGameOver.TabIndex = 14;
            this.panelGameOver.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.playerscoredisplay;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblGameScore);
            this.panel1.Location = new System.Drawing.Point(455, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 64);
            this.panel1.TabIndex = 15;
            // 
            // lblGameScore
            // 
            this.lblGameScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGameScore.AutoSize = true;
            this.lblGameScore.BackColor = System.Drawing.Color.Transparent;
            this.lblGameScore.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGameScore.Location = new System.Drawing.Point(39, 9);
            this.lblGameScore.Name = "lblGameScore";
            this.lblGameScore.Size = new System.Drawing.Size(41, 44);
            this.lblGameScore.TabIndex = 10;
            this.lblGameScore.Text = "0";
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGameOver);
            this.Controls.Add(this.lblNotFishCatch);
            this.Controls.Add(this.pboxSubmarine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GamePage";
            this.Text = "GamePage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePage_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePage_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSubmarine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxSubmarine;
        private System.Windows.Forms.Timer FishSpawnTimer;
        private System.Windows.Forms.Timer NonFishSpawnTimer;
        private System.Windows.Forms.Timer SubmarineMoveTimer;
        private System.Windows.Forms.Label lblNotFishCatch;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGameScore;
    }
}