
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScorePage));
            this.panelScorePage = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelScorePage.SuspendLayout();
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
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.BackColor = System.Drawing.Color.Transparent;
            this.panelControl.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.darkbluebg;
            this.panelControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelControl.Location = new System.Drawing.Point(231, 76);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(571, 564);
            this.panelControl.TabIndex = 7;
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
            this.panelScorePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelScorePage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelControl;
    }
}