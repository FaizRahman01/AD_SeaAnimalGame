using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_SeaAnimalGame
{
    class SpawnItem
    {
        public PictureBox CreateFish()
        {
            PictureBox pbNormalFish = new PictureBox();
            pbNormalFish.Height = 50;
            pbNormalFish.Width = 50;
            pbNormalFish.Image = Properties.Resources.bluefish;
            pbNormalFish.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNormalFish.BackColor = Color.Transparent;


            return pbNormalFish;
        }

        public PictureBox CreateNotFish()
        {
            PictureBox pbNotFish = new PictureBox();
            pbNotFish.Height = 50;
            pbNotFish.Width = 50;
            pbNotFish.Image = Properties.Resources.trash;
            pbNotFish.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNotFish.BackColor = Color.Transparent;

            return pbNotFish;
        }

        public PictureBox CreateFish2()
        {
            PictureBox pbNormalFish2 = new PictureBox();
            pbNormalFish2.Height = 50;
            pbNormalFish2.Width = 50;
            pbNormalFish2.Image = Properties.Resources.yellowfish;
            pbNormalFish2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNormalFish2.BackColor = Color.Transparent;

            return pbNormalFish2;
        }

        public PictureBox CreateNotFish2()
        {
            PictureBox pbNotFish2 = new PictureBox();
            pbNotFish2.Height = 50;
            pbNotFish2.Width = 50;
            pbNotFish2.Image = Properties.Resources.bottle;
            pbNotFish2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNotFish2.BackColor = Color.Transparent;

            return pbNotFish2;
        }

        public PictureBox CreateSeaTurtle()
        {
            PictureBox pbSeaTurtle = new PictureBox();
            pbSeaTurtle.Height = 50;
            pbSeaTurtle.Width = 50;
            pbSeaTurtle.Image = Properties.Resources.seaturtle;
            pbSeaTurtle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSeaTurtle.BackColor = Color.Transparent;

            return pbSeaTurtle;
        }

        public PictureBox CreateOctopus()
        {
            PictureBox pbOctopus = new PictureBox();
            pbOctopus.Height = 50;
            pbOctopus.Width = 50;
            pbOctopus.Image = Properties.Resources.octopus;
            pbOctopus.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOctopus.BackColor = Color.Transparent;

            return pbOctopus;
        }
    }
}
