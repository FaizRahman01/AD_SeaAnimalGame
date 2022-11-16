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
        private Point FormPosition;
        private void panelMainPage_MouseDown(object sender, MouseEventArgs e)
        {
            this.FormPosition = e.Location;
        }

        private void panelMainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Refers to the Form location (or whatever you trigger the event on)
                this.Location = new Point(
                    (this.Location.X - FormPosition.X) + e.X,
                    (this.Location.Y - FormPosition.Y) + e.Y
                );

                this.Update();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerNamePage pnamepage = new PlayerNamePage();
            pnamepage.Show();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            ControlPage controlpage = new ControlPage();
            controlpage.Show();
        }
    }
}
