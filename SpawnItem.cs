using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_SeaAnimalGame
{
    //parent class 'SpawnItem'
    class SpawnItem
    {
        public GamePage GamePage
        {
            get => default;
            set
            {
            }
        }

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
	
	//child class 'SpawnFIsh'
    class SpawnFish:SpawnItem
    {
        //call the SpawnItem class
        SpawnItem mySpawnFishItem = new SpawnItem();
        public PictureBox CreateFish()
        {
            //use the same properties as in the SpawnItem class
            PictureBox pbNormalFish = mySpawnFishItem.pbSpawn();
            //use the picturebox image from properties
            pbNormalFish.Image = Properties.Resources.bluefish;
            //return the value of method to the picturebox
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
        
        
       

     //child class 'SpawnNotFish'  
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