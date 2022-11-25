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

    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //point use for coordinate x,y
        private Point FormPosition;

        //user can drag the panel that place on top 
        private void panelMainPage_MouseDown(object sender, MouseEventArgs e)
        {
            //make the mouse cursor position stay on where it clicks on the panel
            this.FormPosition = e.Location;
        }

        private void panelMainPage_MouseMove(object sender, MouseEventArgs e)
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            //hide this page and open other form
            this.Hide();
            PlayerNamePage pnamepage = new PlayerNamePage();
            pnamepage.Show();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            //hide this page and open other form
            this.Hide();
            ControlPage controlpage = new ControlPage();
            controlpage.Show();
        }

        public PlayerNamePage PlayerNamePage
        {
            get => default;
            set
            {
            }
        }

        public ControlPage ControlPage
        {
            get => default;
            set
            {
            }
        }
    }
}
