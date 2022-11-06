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
    public partial class PlayerNamePage : Form
    {
        private Point windowLocation;
        public PlayerNamePage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelPNamePage_MouseDown(object sender, MouseEventArgs e)
        {
            this.windowLocation = e.Location;
        }

        private void panelPNamePage_MouseMove(object sender, MouseEventArgs e)
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
            MainPage mainpage = new MainPage();
            mainpage.Show();
        }

        private void btnLoginPlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            SkinOptionPage skinoptionpage = new SkinOptionPage();
            skinoptionpage.Show();
        }

        private void btnRegisterPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}
