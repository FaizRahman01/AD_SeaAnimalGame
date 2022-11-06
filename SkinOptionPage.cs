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
        public SkinOptionPage()
        {
            InitializeComponent();
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
        }

        private void btnUse2_Click(object sender, EventArgs e)
        {
            lblPlayerChoice.Text = "Fantom";
        }

        private void btnUse3_Click(object sender, EventArgs e)
        {
            lblPlayerChoice.Text = "Veindal";
        }

        private void btnConfirmChange_Click(object sender, EventArgs e)
        {
            PlayerSkin2 pskin2 = new PlayerSkin2();
            PlayerSkin3 pskin3 = new PlayerSkin3();
        }
    }
}
