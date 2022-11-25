
namespace AD_SeaAnimalGame
{
    partial class ControlPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPage));
            this.panelControlPage = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelControlPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControlPage
            // 
            this.panelControlPage.BackColor = System.Drawing.Color.Transparent;
            this.panelControlPage.Controls.Add(this.btnBack);
            this.panelControlPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlPage.Location = new System.Drawing.Point(0, 0);
            this.panelControlPage.Name = "panelControlPage";
            this.panelControlPage.Size = new System.Drawing.Size(1000, 41);
            this.panelControlPage.TabIndex = 3;
            this.panelControlPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControlPage_MouseDown);
            this.panelControlPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControlPage_MouseMove);
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
            this.panelControl.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.controlkey;
            this.panelControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 41);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1000, 659);
            this.panelControl.TabIndex = 6;
            // 
            // ControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AD_SeaAnimalGame.Properties.Resources.boy_fishing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelControlPage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlPage";
            this.panelControlPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlPage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelControl;
    }
}