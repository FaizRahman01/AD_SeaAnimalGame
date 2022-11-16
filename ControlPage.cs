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
    public partial class ControlPage : Form
    {

        public ControlPage()
        {
            InitializeComponent();
        }
        private Point FormPosition;
        private void panelControlPage_MouseDown(object sender, MouseEventArgs e)
        {
            this.FormPosition = e.Location;
        }

        private void panelControlPage_MouseMove(object sender, MouseEventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainpage = new MainPage();
            mainpage.Show();
        }
    }
}
