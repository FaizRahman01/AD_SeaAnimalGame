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
        //import anything from this page to use by other form
        public static SkinOptionPage SkinOptionInstance;
        //make the skin variable public to use by other form
        public string skin;
        public SkinOptionPage()
        {
            InitializeComponent();
            SkinOptionInstance = this;
        }

        //point use for coordinate x,y
        private Point FormPosition;

        //user can drag the panel that place on top 
        private void panelSkinOptionPage_MouseDown(object sender, MouseEventArgs e)
        {
            //make the mouse cursor position stay on where it clicks on the panel
            this.FormPosition = e.Location;
        }

        private void panelSkinOptionPage_MouseMove(object sender, MouseEventArgs e)
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
        //user need to click which skin name need to use on GamePage between the three button they click
        private void btnUse1_Click(object sender, EventArgs e)
        {
            //going to pass the skin value to GamePage 
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


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //hide this page and open other form
            this.Hide();
            PlayerMainPage pmainpage = new PlayerMainPage();
            pmainpage.Show();
        }
    }
}
