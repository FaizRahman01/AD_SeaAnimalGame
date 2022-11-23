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
    public partial class PlayerMainPage : Form
    {

        public PlayerMainPage()
        {
            InitializeComponent();
        }

        //point use for coordinate x,y
        private Point FormPosition;

        //user can drag the panel that place on top 
        private void panelPMainPage_MouseDown(object sender, MouseEventArgs e)
        {
            //make the mouse cursor position stay on where it clicks on the panel
            this.FormPosition = e.Location;
        }

        private void panelPMainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // let user to drag the form anywhere in coordinate x and y
                this.Location = new Point(
                    (this.Location.X - FormPosition.X) + e.X,
                    (this.Location.Y - FormPosition.Y) + e.Y
                );

                this.Update();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            
            //messagebox with ok cancel button
            DialogResult logoutConfirmation = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.OKCancel);
            //if the user press ok the it will go to the MainPage but the user will not go to the other page if press cancecl
            if (logoutConfirmation == DialogResult.OK)
            {
                //hide this page and open other form
                this.Hide();
                MainPage mainpage = new MainPage();
                mainpage.Show();
                //refresh the form and reset any passing value to the farm
                Application.Restart();
            }
        }

        private void btnPlayNow_Click(object sender, EventArgs e)
        {
            //hide this page and open other form
            this.Hide();
            GamePage gamepage = new GamePage();
            gamepage.Show();
        }

        private void btnSkin_Click(object sender, EventArgs e)
        {
            //hide this page and open other form
            this.Hide();
            SkinOptionPage skinoptionpage = new SkinOptionPage();
            skinoptionpage.Show();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            //hide this page and open other form
            this.Hide();
            ScorePage scorepage = new ScorePage();
            scorepage.Show();
        }


    }
}
