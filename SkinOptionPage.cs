using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_SeaAnimalGame
{
    public partial class SkinOptionPage : Form
    {
        private Point windowLocation;
        public static SkinOptionPage SkinOptionInstance;
        public Label lblskin;
        public string skin;
        public SkinOptionPage()
        {
            InitializeComponent();
            SkinOptionInstance = this;
            lblskin = lblPlayerChoice;
        }


        private void panelSkinOptionPage_MouseDown(object sender, MouseEventArgs e)
        {
            this.windowLocation = e.Location;
        }

        private void panelSkinOptionPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Refers to the Form location (or whatever you trigger the event on)
                this.Location = new Point(
                    (this.Location.X - windowLocation.X) + e.X,
                    (this.Location.Y - windowLocation.Y) + e.Y
                );

                this.Update();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerMainPage pmainpage = new PlayerMainPage();
            pmainpage.Show();
        }

        private void btnUse1_Click(object sender, EventArgs e)
        {
            lblPlayerChoice.Text = "Spekter";
            skin = lblPlayerChoice.Text;
        }

        private void btnUse2_Click(object sender, EventArgs e)
        {
            lblPlayerChoice.Text = "Fantom";
            skin = lblPlayerChoice.Text;
        }

        private void btnUse3_Click(object sender, EventArgs e)
        {
            lblPlayerChoice.Text = "Veindal";
            skin = lblPlayerChoice.Text;
        }

        private void SkinOptionPage_Load(object sender, EventArgs e)
        {
            lblPlayerChoice.Text = skin;
        }
    }
}
