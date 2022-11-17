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
         public PictureBox pbSpawn()
		 {
            PictureBox pbSpawnItem = new PictureBox();
            pbSpawnItem.Height = 50;
            pbSpawnItem.Width = 50;
            pbSpawnItem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpawnItem.BackColor = Color.Transparent;
            
			return pbSpawnItem;
		}

    }
	
	
    class SpawnFish:SpawnItem
    {
        SpawnItem mySpawnFishItem = new SpawnItem();
        public PictureBox CreateFish()
        {
            PictureBox pbNormalFish = mySpawnFishItem.pbSpawn();
            pbNormalFish.Image = Properties.Resources.bluefish;

            return pbNormalFish;
        }

        public PictureBox CreateFish2()
        {
            PictureBox pbNormalFish2 = mySpawnFishItem.pbSpawn();
            pbNormalFish2.Image = Properties.Resources.yellowfish;

            return pbNormalFish2;
        }

        public PictureBox CreateSeaTurtle()
        {
            PictureBox pbSeaTurtle = mySpawnFishItem.pbSpawn();
            pbSeaTurtle.Image = Properties.Resources.seaturtle;

            return pbSeaTurtle;
        }

        public PictureBox CreateOctopus()
        {
            PictureBox pbOctopus = mySpawnFishItem.pbSpawn();
            pbOctopus.Image = Properties.Resources.octopus;

            return pbOctopus;
        }
    }
        
        
       

       
    class SpawnNotFish:SpawnItem
    {
        SpawnItem mySpawnNotFishItem = new SpawnItem();
        public PictureBox CreateNotFish2()
        {
            PictureBox pbNotFish2 = mySpawnNotFishItem.pbSpawn();
            pbNotFish2.Image = Properties.Resources.bottle;

            return pbNotFish2;
        }

        public PictureBox CreateNotFish()
        {
            PictureBox pbNotFish = mySpawnNotFishItem.pbSpawn();
            pbNotFish.Image = Properties.Resources.trash;

            return pbNotFish;
        }
    }
     
   
}