
namespace AD_SeaAnimalGame
{
    partial class ScorePage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScorePage));
            this.panelScorePage = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.lblGameChart = new System.Windows.Forms.Label();
            this.btnSearchPlayer = new System.Windows.Forms.Button();
            this.lblShowPName = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tboxSearchPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopScore = new System.Windows.Forms.Label();
            this.lblPlayerId = new System.Windows.Forms.Label();
            this.lblPIdTitle = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPNameTitle = new System.Windows.Forms.Label();
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.PlayerScoreChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelScorePage.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerScoreChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panelScorePage
            // 
            this.panelScorePage.BackColor = System.Drawing.Color.Transparent;
            this.panelScorePage.Controls.Add(this.btnBack);
            this.panelScorePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelScorePage.Location = new System.Drawing.Point(0, 0);
            this.panelScorePage.Name = "panelScorePage";
            this.panelScorePage.Size = new System.Drawing.Size(1000, 41);
            this.panelScorePage.TabIndex = 4;
            this.panelScorePage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelScorePage_MouseDown);
            this.panelScorePage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelScorePage_MouseMove);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(6, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.darkbluebg;
            this.panelControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelControl.Controls.Add(this.lblGameChart);
            this.panelControl.Controls.Add(this.btnSearchPlayer);
            this.panelControl.Controls.Add(this.lblShowPName);
            this.panelControl.Controls.Add(this.lblResult);
            this.panelControl.Controls.Add(this.lblSearch);
            this.panelControl.Controls.Add(this.tboxSearchPName);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.lblTopScore);
            this.panelControl.Controls.Add(this.lblPlayerId);
            this.panelControl.Controls.Add(this.lblPIdTitle);
            this.panelControl.Controls.Add(this.lblPlayerName);
            this.panelControl.Controls.Add(this.lblPNameTitle);
            this.panelControl.Controls.Add(this.dataGridViewScore);
            this.panelControl.Controls.Add(this.PlayerScoreChart);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 41);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1000, 659);
            this.panelControl.TabIndex = 7;
            // 
            // lblGameChart
            // 
            this.lblGameChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGameChart.AutoSize = true;
            this.lblGameChart.BackColor = System.Drawing.Color.Transparent;
            this.lblGameChart.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameChart.ForeColor = System.Drawing.Color.Navy;
            this.lblGameChart.Location = new System.Drawing.Point(543, 194);
            this.lblGameChart.Name = "lblGameChart";
            this.lblGameChart.Size = new System.Drawing.Size(189, 33);
            this.lblGameChart.TabIndex = 36;
            this.lblGameChart.Text = "Top 5 Score";
            this.lblGameChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchPlayer
            // 
            this.btnSearchPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchPlayer.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.buttonbg;
            this.btnSearchPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchPlayer.FlatAppearance.BorderSize = 0;
            this.btnSearchPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPlayer.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSearchPlayer.ForeColor = System.Drawing.Color.White;
            this.btnSearchPlayer.Location = new System.Drawing.Point(406, 524);
            this.btnSearchPlayer.Name = "btnSearchPlayer";
            this.btnSearchPlayer.Size = new System.Drawing.Size(114, 40);
            this.btnSearchPlayer.TabIndex = 35;
            this.btnSearchPlayer.Text = "Search";
            this.btnSearchPlayer.UseVisualStyleBackColor = false;
            this.btnSearchPlayer.Click += new System.EventHandler(this.btnSearchPlayer_Click);
            // 
            // lblShowPName
            // 
            this.lblShowPName.AutoSize = true;
            this.lblShowPName.BackColor = System.Drawing.Color.Transparent;
            this.lblShowPName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPName.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblShowPName.Location = new System.Drawing.Point(294, 572);
            this.lblShowPName.Name = "lblShowPName";
            this.lblShowPName.Size = new System.Drawing.Size(18, 21);
            this.lblShowPName.TabIndex = 34;
            this.lblShowPName.Text = "-";
            this.lblShowPName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblResult.Location = new System.Drawing.Point(163, 572);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(125, 21);
            this.lblResult.TabIndex = 33;
            this.lblResult.Text = "Player Name:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Navy;
            this.lblSearch.Location = new System.Drawing.Point(155, 490);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(128, 31);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Player ID";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxSearchPName
            // 
            this.tboxSearchPName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tboxSearchPName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tboxSearchPName.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSearchPName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboxSearchPName.Location = new System.Drawing.Point(161, 524);
            this.tboxSearchPName.MaxLength = 20;
            this.tboxSearchPName.Name = "tboxSearchPName";
            this.tboxSearchPName.Size = new System.Drawing.Size(233, 38);
            this.tboxSearchPName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(543, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 30;
            this.label1.Text = "User Profile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopScore
            // 
            this.lblTopScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTopScore.AutoSize = true;
            this.lblTopScore.BackColor = System.Drawing.Color.Transparent;
            this.lblTopScore.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopScore.ForeColor = System.Drawing.Color.Navy;
            this.lblTopScore.Location = new System.Drawing.Point(177, 56);
            this.lblTopScore.Name = "lblTopScore";
            this.lblTopScore.Size = new System.Drawing.Size(203, 33);
            this.lblTopScore.TabIndex = 29;
            this.lblTopScore.Text = "Top 5 Player";
            this.lblTopScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerId
            // 
            this.lblPlayerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerId.AutoSize = true;
            this.lblPlayerId.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerId.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerId.Location = new System.Drawing.Point(670, 96);
            this.lblPlayerId.Name = "lblPlayerId";
            this.lblPlayerId.Size = new System.Drawing.Size(27, 33);
            this.lblPlayerId.TabIndex = 28;
            this.lblPlayerId.Text = "-";
            // 
            // lblPIdTitle
            // 
            this.lblPIdTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPIdTitle.AutoSize = true;
            this.lblPIdTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPIdTitle.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIdTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblPIdTitle.Location = new System.Drawing.Point(552, 107);
            this.lblPIdTitle.Name = "lblPIdTitle";
            this.lblPIdTitle.Size = new System.Drawing.Size(81, 21);
            this.lblPIdTitle.TabIndex = 27;
            this.lblPIdTitle.Text = "User ID:";
            this.lblPIdTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerName.Location = new System.Drawing.Point(670, 142);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(27, 33);
            this.lblPlayerName.TabIndex = 26;
            this.lblPlayerName.Text = "-";
            // 
            // lblPNameTitle
            // 
            this.lblPNameTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPNameTitle.AutoSize = true;
            this.lblPNameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPNameTitle.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNameTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblPNameTitle.Location = new System.Drawing.Point(552, 148);
            this.lblPNameTitle.Name = "lblPNameTitle";
            this.lblPNameTitle.Size = new System.Drawing.Size(101, 21);
            this.lblPNameTitle.TabIndex = 14;
            this.lblPNameTitle.Text = "UserName:";
            this.lblPNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewScore.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dataGridViewScore.Location = new System.Drawing.Point(161, 98);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.Size = new System.Drawing.Size(249, 366);
            this.dataGridViewScore.TabIndex = 1;
            // 
            // PlayerScoreChart
            // 
            this.PlayerScoreChart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerScoreChart.BackColor = System.Drawing.Color.MediumTurquoise;
            chartArea1.Name = "ChartArea1";
            this.PlayerScoreChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PlayerScoreChart.Legends.Add(legend1);
            this.PlayerScoreChart.Location = new System.Drawing.Point(549, 230);
            this.PlayerScoreChart.Name = "PlayerScoreChart";
            this.PlayerScoreChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.EmptyPointStyle.IsValueShownAsLabel = true;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Player Score";
            this.PlayerScoreChart.Series.Add(series1);
            this.PlayerScoreChart.Size = new System.Drawing.Size(305, 276);
            this.PlayerScoreChart.TabIndex = 0;
            this.PlayerScoreChart.Text = "Score Chart";
            // 
            // ScorePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.boy_fishing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelScorePage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScorePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScorePage";
            this.Load += new System.EventHandler(this.ScorePage_Load);
            this.panelScorePage.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerScoreChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelScorePage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.DataVisualization.Charting.Chart PlayerScoreChart;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.Label lblPNameTitle;
        private System.Windows.Forms.Label lblPIdTitle;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerId;
        private System.Windows.Forms.Label lblTopScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxSearchPName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblShowPName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSearchPlayer;
        private System.Windows.Forms.Label lblGameChart;
    }
}