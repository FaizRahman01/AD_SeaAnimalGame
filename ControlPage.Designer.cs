
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
            this.lblControl1 = new System.Windows.Forms.Label();
            this.lblControl2 = new System.Windows.Forms.Label();
            this.lblControl3 = new System.Windows.Forms.Label();
            this.lblControl4 = new System.Windows.Forms.Label();
            this.panelControlPage.SuspendLayout();
            this.panelControl.SuspendLayout();
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
            this.panelControl.Controls.Add(this.lblControl4);
            this.panelControl.Controls.Add(this.lblControl3);
            this.panelControl.Controls.Add(this.lblControl2);
            this.panelControl.Controls.Add(this.lblControl1);
            this.panelControl.Location = new System.Drawing.Point(231, 76);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(571, 564);
            this.panelControl.TabIndex = 6;
            // 
            // lblControl1
            // 
            this.lblControl1.AutoSize = true;
            this.lblControl1.BackColor = System.Drawing.Color.Transparent;
            this.lblControl1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl1.ForeColor = System.Drawing.Color.Black;
            this.lblControl1.Location = new System.Drawing.Point(72, 77);
            this.lblControl1.Name = "lblControl1";
            this.lblControl1.Size = new System.Drawing.Size(190, 34);
            this.lblControl1.TabIndex = 13;
            this.lblControl1.Text = "W - Move Up";
            // 
            // lblControl2
            // 
            this.lblControl2.AutoSize = true;
            this.lblControl2.BackColor = System.Drawing.Color.Transparent;
            this.lblControl2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl2.ForeColor = System.Drawing.Color.Black;
            this.lblControl2.Location = new System.Drawing.Point(72, 159);
            this.lblControl2.Name = "lblControl2";
            this.lblControl2.Size = new System.Drawing.Size(216, 34);
            this.lblControl2.TabIndex = 14;
            this.lblControl2.Text = "S - Move Down";
            // 
            // lblControl3
            // 
            this.lblControl3.AutoSize = true;
            this.lblControl3.BackColor = System.Drawing.Color.Transparent;
            this.lblControl3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl3.ForeColor = System.Drawing.Color.Black;
            this.lblControl3.Location = new System.Drawing.Point(72, 238);
            this.lblControl3.Name = "lblControl3";
            this.lblControl3.Size = new System.Drawing.Size(204, 34);
            this.lblControl3.TabIndex = 15;
            this.lblControl3.Text = "A - Move Left";
            // 
            // lblControl4
            // 
            this.lblControl4.AutoSize = true;
            this.lblControl4.BackColor = System.Drawing.Color.Transparent;
            this.lblControl4.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl4.ForeColor = System.Drawing.Color.Black;
            this.lblControl4.Location = new System.Drawing.Point(72, 311);
            this.lblControl4.Name = "lblControl4";
            this.lblControl4.Size = new System.Drawing.Size(218, 34);
            this.lblControl4.TabIndex = 16;
            this.lblControl4.Text = "D - Move Right";
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
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlPage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label lblControl1;
        private System.Windows.Forms.Label lblControl3;
        private System.Windows.Forms.Label lblControl2;
        private System.Windows.Forms.Label lblControl4;
    }
}