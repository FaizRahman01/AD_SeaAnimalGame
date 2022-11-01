
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
            this.lblGameTimer = new System.Windows.Forms.Label();
            this.pboxSubmarine = new System.Windows.Forms.PictureBox();
            this.FishSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.NonFishSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.SubmarineMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSubmarine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameTimer
            // 
            this.lblGameTimer.AutoSize = true;
            this.lblGameTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTimer.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGameTimer.Location = new System.Drawing.Point(846, 9);
            this.lblGameTimer.Name = "lblGameTimer";
            this.lblGameTimer.Size = new System.Drawing.Size(142, 33);
            this.lblGameTimer.TabIndex = 7;
            this.lblGameTimer.Text = "Timer : 60 S";
            // 
            // pboxSubmarine
            // 
            this.pboxSubmarine.BackColor = System.Drawing.Color.Transparent;
            this.pboxSubmarine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxSubmarine.BackgroundImage")));
            this.pboxSubmarine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxSubmarine.Location = new System.Drawing.Point(455, 375);
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
            // lblGameScore
            // 
            this.lblGameScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGameScore.AutoSize = true;
            this.lblGameScore.BackColor = System.Drawing.Color.Transparent;
            this.lblGameScore.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGameScore.Location = new System.Drawing.Point(449, 9);
            this.lblGameScore.Name = "lblGameScore";
            this.lblGameScore.Size = new System.Drawing.Size(104, 33);
            this.lblGameScore.TabIndex = 10;
            this.lblGameScore.Text = "Score : 0";
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lblGameScore);
            this.Controls.Add(this.lblGameTimer);
            this.Controls.Add(this.pboxSubmarine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GamePage";
            this.Text = "GamePage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePage_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePage_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSubmarine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGameTimer;
        private System.Windows.Forms.PictureBox pboxSubmarine;
        private System.Windows.Forms.Timer FishSpawnTimer;
        private System.Windows.Forms.Timer NonFishSpawnTimer;
        private System.Windows.Forms.Timer SubmarineMoveTimer;
        private System.Windows.Forms.Label lblGameScore;
    }
}