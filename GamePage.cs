using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.OleDb;


namespace AD_SeaAnimalGame
{
    public partial class GamePage : Form
    {

        OleDbConnection dbcon = new OleDbConnection(Properties.Resources.AccessDB_StringConnection);

        Random randomSpawn = new Random();

        //use list to store the new picturebox that add to the form
        List<PictureBox> fish = new List<PictureBox>();
        List<PictureBox> notfish = new List<PictureBox>();
        List<PictureBox> octopus = new List<PictureBox>();
        List<PictureBox> seaturtle = new List<PictureBox>();
        List<PictureBox> fish2 = new List<PictureBox>();
        List<PictureBox> notfish2 = new List<PictureBox>();
        public GamePage()
        {
            InitializeComponent();
            
        }

        //point use for coordinate x,y
        private Point FormPosition;

        //user can drag the panel that place on top (panel of submarine hp)

        private void panelGamePage_MouseDown(object sender, MouseEventArgs e)
        {
            //make the mouse cursor position stay on where it clicks on the panel
            this.FormPosition = e.Location;
        }

        private void panelGamePage_MouseMove(object sender, MouseEventArgs e)
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


        private void GamePage_Load(object sender, EventArgs e)
        {
            //get passing value in Session.cs from the PlayerNamePage
            lblPlayerName.Text = Session.SessionName;
            dbcon.Open();

            OleDbCommand dbcmdlogin = new OleDbCommand();
            dbcmdlogin.Connection = dbcon;
            //show player id that match the playername that show as a label that get the passing value from Session.cs
            dbcmdlogin.CommandText = "select PlayerId, PlayerName from PlayerTbl where PlayerName = '" + lblPlayerName.Text + "' ";

            OleDbDataReader dbreader = dbcmdlogin.ExecuteReader();


            if (dbreader.Read())
            {

                lblPlayerId.Text = dbreader["PlayerId"].ToString();

            }
            else
            {
                MessageBox.Show("Player name not found");
            }

            dbcon.Close();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {

            try
            {
                dbcon.Open();
                //insert score in database that take the value from the label show in form
                OleDbCommand dbcmd = new OleDbCommand("insert into PlayerScoreTbl (PlayerId, PlayerScore)values ('" + lblPlayerId.Text + "','" + lblGameScore.Text + "')", dbcon);
                dbcmd.ExecuteNonQuery();
                dbcon.Close();

                this.Hide();
                PlayerMainPage pmainpage = new PlayerMainPage();
                pmainpage.Show();
                TimeCounter = 120;
            }
            catch
            {
                MessageBox.Show("Database cannot read the player id");
                this.Hide();
                MainPage mainpage = new MainPage();
                mainpage.Show();
                Application.Restart();
            }
        }

        private void btnCloseGame_Click(object sender, EventArgs e)
        {
            //if the user decide to exit the game it will not store the score in database
            Application.Exit();
            TimeCounter = 120;
        }

        //call the class in SpawnItem.cs
        SpawnFish spawnFishItem = new SpawnFish();
        SpawnNotFish spawnNotFishItem = new SpawnNotFish();
        private void FishSpawn()
        {

            PictureBox pbfishspawn = spawnFishItem.CreateFish();
            //spawn new pic box for level 1 fish
            int x = randomSpawn.Next(10, this.ClientSize.Width - pbfishspawn.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbfishspawn.Height);
            pbfishspawn.Location = new Point(x, y);
            //add any picturebox that spawn inside the form and add it to the list
            fish.Add(pbfishspawn);
            this.Controls.Add(pbfishspawn);

        }

        private async void FishSpawn2()
        //need to add async to use await task.delay 
        {
            PictureBox pbfishspawn2 = spawnFishItem.CreateFish2();
            //spawn new pic box for level 2 fish
            int x = randomSpawn.Next(10, this.ClientSize.Width - pbfishspawn2.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbfishspawn2.Height);
            pbfishspawn2.Location = new Point(x, y);
            //add any picturebox that spawn inside the form and add it to the list
            fish2.Add(pbfishspawn2);
            this.Controls.Add(pbfishspawn2);
            //after 3 second when the new picturebox add,it will make picturebox visible = false
            await Task.Delay(3000);
            pbfishspawn2.Visible = false;
        }

        private async void SeaTurtleSpawn()
        //need to add async to use await task.delay 
        {
            PictureBox pbseaturtlespawn = spawnFishItem.CreateSeaTurtle();
            //spawn new pic box for sea turtle object
            int x = randomSpawn.Next(10, this.ClientSize.Width - pbseaturtlespawn.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbseaturtlespawn.Height);
            pbseaturtlespawn.Location = new Point(x, y);
            //add any picturebox that spawn inside the form and add it to the list
            seaturtle.Add(pbseaturtlespawn);
            this.Controls.Add(pbseaturtlespawn);
            //after 3 second when the new picturebox add,it will make picturebox visible = false
            await Task.Delay(3000);
            pbseaturtlespawn.Visible = false;
        }

        private async void OctopusSpawn()
        //need to add async to use await task.delay 
        {
            PictureBox pboctopusspawn = spawnFishItem.CreateOctopus();
            //spawn new pic box for octopus object
            int x = randomSpawn.Next(10, this.ClientSize.Width - pboctopusspawn.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pboctopusspawn.Height);
            pboctopusspawn.Location = new Point(x, y);
            //add any picturebox that spawn inside the form and add it to the list
            octopus.Add(pboctopusspawn);
            this.Controls.Add(pboctopusspawn);
            //after 3 second when the new picturebox add,it will make picturebox visible = false
            await Task.Delay(3000);
            pboctopusspawn.Visible = false;
        }

        private void NotFishSpawn()
        {
            PictureBox pbnotfishspawn = spawnNotFishItem.CreateNotFish();
            //spawn new pic box for level 1 random object
            int x = randomSpawn.Next(10, this.ClientSize.Width - pbnotfishspawn.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbnotfishspawn.Height);
            pbnotfishspawn.Location = new Point(x, y);
            //add any picturebox that spawn inside the form and add it to the list
            notfish.Add(pbnotfishspawn);
            this.Controls.Add(pbnotfishspawn);


        }

        private async void NotFishSpawn2()
        //need to add async to use await task.delay 
        {
            PictureBox pbnotfishspawn2 = spawnNotFishItem.CreateNotFish2();
            //spawn new pic box for level 2 random object
            int x = randomSpawn.Next(10, this.ClientSize.Width - pbnotfishspawn2.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbnotfishspawn2.Height);
            pbnotfishspawn2.Location = new Point(x, y);
            //add any picturebox that spawn inside the form and add it to the list
            notfish2.Add(pbnotfishspawn2);
            this.Controls.Add(pbnotfishspawn2);
            //after 3 second when the new picturebox add,it will make picturebox visible = false
            await Task.Delay(3000);
            pbnotfishspawn2.Visible = false;
        }

        bool submarineUp, submarineDown, submarineLeft, submarineRight;
        private void GamePage_KeyDown(object sender, KeyEventArgs e)
        //when the user press any of the key it will run anything that is set inside this event
        {
            if (e.KeyCode == Keys.Escape)
            //when the user press esc button the panel for game over will become visible
            {
                CountdownGameTimer.Stop();
                FishSpawnTimer.Stop();
                NonFishSpawnTimer.Stop();
                TurtleSpawnTimer.Stop();
                OctopusSpawnTimer.Stop();
                FishSpawnTimer2.Stop();
                NotFishSpawnTimer2.Stop();
                SubmarineMoveTimer.Stop();
                panelGameOver.Visible = true;
            }

            if (e.KeyCode == Keys.A)
            {
                submarineLeft = true;
                
            }
            if (e.KeyCode == Keys.D)
            {
                submarineRight = true;
                
            }
            if (e.KeyCode == Keys.W)
            {
                submarineUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                submarineDown = true;

            }
        }

        private void GamePage_KeyUp(object sender, KeyEventArgs e)
        //when the user not press any of the key it will not do anything
        {
            if (e.KeyCode == Keys.A)
            {
                submarineLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                submarineRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                submarineUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                submarineDown = false;
            }
        }


        //timer event for all spawn item

        private void FishSpawnTimer_Tick(object sender, EventArgs e)
        {
            FishSpawn();
        }
        private void NonFishSpawnTimer_Tick(object sender, EventArgs e)
        {
            NotFishSpawn();
        }
        private void TurtleSpawnTimer_Tick(object sender, EventArgs e)
        {
            SeaTurtleSpawn();
        }
        private void OctopusSpawnTimer_Tick(object sender, EventArgs e)
        {
            OctopusSpawn();
        }

        private void FishSpawnTimer2_Tick(object sender, EventArgs e)
        {
            FishSpawn2();
        }
        private void NotFishSpawnTimer2_Tick(object sender, EventArgs e)
        {
            NotFishSpawn2();
        }

        //game timer set to 120 second
        int TimeCounter = 120;
        private void CountdownGameTimer_Tick(object sender, EventArgs e)
        {
            //use the value of TimeCounter and show it as a label
            lblGameTImer.Text = String.Format("{0} s", TimeCounter);

            if (TimeCounter > 0)
            {
                //if the timer is more than 0 seconds it will deduct 1 seconds of the game timer
                CountdownGameTimer.Start();
                TimeCounter--;
            }
            else if (TimeCounter == 0)
            {
                //the game timer reach 0 seconds the game will stop running
                CountdownGameTimer.Stop();
                FishSpawnTimer.Stop();
                NonFishSpawnTimer.Stop();
                TurtleSpawnTimer.Stop();
                OctopusSpawnTimer.Stop();
                FishSpawnTimer2.Stop();
                NotFishSpawnTimer2.Stop();
                SubmarineMoveTimer.Stop();
                panelGameOver.Visible = true;
            }


            if(TimeCounter > 100)
            {
                //game timer more than 100 second will make the spawn item for level 2 not show
                TurtleSpawnTimer.Stop();
                OctopusSpawnTimer.Stop();
                FishSpawnTimer2.Stop();
                NotFishSpawnTimer2.Stop();
            }

            else if(TimeCounter <= 100 && TimeCounter > 0)
            {
                //time counter value less and equal to 100 && more than 0 will spawn the level 2 picturebox
                TurtleSpawnTimer.Start();
                OctopusSpawnTimer.Start();
                FishSpawnTimer2.Start();
                NotFishSpawnTimer2.Start();

                //remove any level 1 picturebox when timer reach 101 seconds
                foreach (PictureBox fishpb in fish.ToList())
                {
                    fish.Remove(fishpb);
                    this.Controls.Remove(fishpb);
                }

                foreach(PictureBox notfishpb in notfish.ToList())
                {
                    notfish.Remove(notfishpb);
                    this.Controls.Remove(notfishpb);

                }
                //stop the level 1 picturebox add into the form
                FishSpawnTimer.Stop();
                NonFishSpawnTimer.Stop();

                lblLevelDisplay.Text = "Level 2";
            }

        }

        //set the submarine speed
        int submarineSpeed = 12;

        int correctCatch = 0;
        int wrongCatch = 0;
        //set default starting player score to 0
        int playerScore = 0;
        //playerHP use for the progress bar
        int playerHP = 100;

        private void SubmarineMoveTimer_Tick(object sender, EventArgs e)
        {
            //call the skin properties name inside the PlayerSkin.cs class
            PlayerSkin1 pskin1 = new PlayerSkin1();
            PlayerSkin2 pskin2 = new PlayerSkin2();
            PlayerSkin3 pskin3 = new PlayerSkin3();

            //skingame use to call the method from the class 
            string skingame;
            //bitmap can be use to call the value from the variable and use 
            //it to call the properties name 
            Bitmap skinImage;


            //one of the if statement will be use from what the user
            //has select from SkinOptionPage.cs and pass the skin value to this form
            if (SkinOptionPage.SkinOptionInstance.skin == "Spekter")
            {
                //get the value of skin properties name from the class
                skingame = pskin1.GetMainSkin();
                skinImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(skingame);
                //image name for propeties get from PlayerSkin.cs
                pboxSubmarine.Image = skinImage;
            }
            else if (SkinOptionPage.SkinOptionInstance.skin == "Fantom")
            {
                //get the value of skin properties name from the class
                skingame = pskin2.GetSecondSkin();
                skinImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(skingame);
                //image name for propeties get from PlayerSkin.cs
                pboxSubmarine.Image = skinImage;

            }
            else if (SkinOptionPage.SkinOptionInstance.skin == "Veindal")
            {
                //get the value of skin properties name from the class
                skingame = pskin3.GetThirdSkin();
                skinImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(skingame);
                //image name for propeties get from PlayerSkin.cs
                pboxSubmarine.Image = skinImage;
            }
            else
            {
                //get the value of skin properties name from the class
                skingame = pskin2.GetSecondSkin();
                skinImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(skingame);
                //image name for propeties get from PlayerSkin.cs
                pboxSubmarine.Image = skinImage;
            }

            
            //move left
            if (submarineLeft == true && pboxSubmarine.Left > 0)
            {
                pboxSubmarine.Left -= submarineSpeed;
                //run one of the if statement from what skin that the player choose
                if(skingame.ToString() == "submarineleft")
                {
                    //change the picturebox image if move to left
                    pboxSubmarine.Image = Properties.Resources.submarineleft;
                }
                else if(skingame.ToString() == "submarine2left")
                {
                    pboxSubmarine.Image = Properties.Resources.submarine2left;
                }
                else if (skingame.ToString() == "submarine3left")
                {
                    pboxSubmarine.Image = Properties.Resources.submarine3left;
                }
            }
            //move right
            if (submarineRight == true && pboxSubmarine.Left < 877)
            {
                pboxSubmarine.Left += submarineSpeed;
                //run one of the if statement from what skin that the player choose
                if (skingame.ToString() == "submarineleft")
                {
                    //change the picturebox image if move to right
                    pboxSubmarine.Image = Properties.Resources.submarineright;
                }
                else if (skingame.ToString() == "submarine2left")
                {
                    pboxSubmarine.Image = Properties.Resources.submarine2right;
                }
                else if (skingame.ToString() == "submarine3left")
                {
                    pboxSubmarine.Image = Properties.Resources.submarine3right;
                }
            }
            //move up
            if (submarineUp == true && pboxSubmarine.Top > 0)
            {
                pboxSubmarine.Top -= submarineSpeed;
            }
            //move down
            if (submarineDown == true && pboxSubmarine.Top < 599)
            {
                pboxSubmarine.Top += submarineSpeed;
            }

            //show playerScore as label
            lblGameScore.Text = "" + playerScore;
            //show the value of each item they hit
            //wrongCatch for the not sea animal object
            lblNotFishCatch.Text = "NotFish: " + wrongCatch;
            //correctCatch for the sea animal
            lblFishCatch.Text = "Fish: " + correctCatch;

            submarineHP.Value = Convert.ToInt32(playerHP);

            foreach (PictureBox fishpb in fish.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(fishpb.Bounds))
                {
                    //everytime the submarine intersect with any picturebox it will remove 
                    //the picturebox
                    fish.Remove(fishpb);
                    this.Controls.Remove(fishpb);

                    correctCatch++;
                    //reset the wrongcatch value to 0 
                    wrongCatch = 0;
                    playerScore = correctCatch + wrongCatch;
                    //if the user hit the picturebox it will make the progressbar become full
                    playerHP = 100;
                    //show how many score add in label
                    lblPointEarn.Text = "+1";
                    //soundplayer use for game sound effect everytime picturebox got hit
                    SoundPlayer player = new SoundPlayer(Properties.Resources.correct);
                    player.Play();
                }

            }

            foreach (PictureBox notfishpb in notfish.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(notfishpb.Bounds))
                {
                    //everytime the submarine intersect with any picturebox it will remove 
                    //the picturebox
                    notfish.Remove(notfishpb);
                    this.Controls.Remove(notfishpb);

                    SoundPlayer player = new SoundPlayer(Properties.Resources.wrong);
                    player.Play();


                    lblPointEarn.Text = "-1";
                    //reduce the progressbar value is user hit the
                    //picturebox which is not seaanimal
                    playerHP -= 20;
                    wrongCatch++;
                    correctCatch--;
                    playerScore = correctCatch;

                    if (playerScore < 0)
                    {
                        playerScore = 0;
                    }

                    if (correctCatch < 0)
                    {
                        correctCatch = 0;
                    }
                    //if wrongcatch value equal to 5 the game will end
                    if (wrongCatch == 5)
                    {
                        CountdownGameTimer.Stop();
                        FishSpawnTimer.Stop();
                        NonFishSpawnTimer.Stop();
                        TurtleSpawnTimer.Stop();
                        OctopusSpawnTimer.Stop();
                        FishSpawnTimer2.Stop();
                        NotFishSpawnTimer2.Stop();
                        SubmarineMoveTimer.Stop();
                        panelGameOver.Visible = true;

                    }
                }

            }
  
            foreach (PictureBox octopuspb in octopus.ToList())
            {
                //if any picturebox that spawn in form visible = false it will not use
                //the if statement
                if (pboxSubmarine.Bounds.IntersectsWith(octopuspb.Bounds) && octopuspb.Visible == true)
                {
                    //everytime the submarine intersect with any picturebox it will remove 
                    //the picturebox
                    octopus.Remove(octopuspb);
                    this.Controls.Remove(octopuspb);
                    correctCatch += 2;
                    wrongCatch = 0;

                    playerScore = correctCatch + wrongCatch;
                    playerHP = 100;
                    lblPointEarn.Text = "+2";

                    SoundPlayer player = new SoundPlayer(Properties.Resources.correct);
                    player.Play();
                }

            }

            foreach (PictureBox seaturtlepb in seaturtle.ToList())
            {
                //if any picturebox that spawn in form visible = false it will not use
                //the if statement
                if (pboxSubmarine.Bounds.IntersectsWith(seaturtlepb.Bounds) && seaturtlepb.Visible == true)
                {
                    //everytime the submarine intersect with any picturebox it will remove 
                    //the picturebox
                    seaturtle.Remove(seaturtlepb);
                    this.Controls.Remove(seaturtlepb);

                    correctCatch += 3;
                    wrongCatch = 0;

                    playerScore = correctCatch + wrongCatch;
                    playerHP = 100;
                    lblPointEarn.Text = "+3";

                    SoundPlayer player = new SoundPlayer(Properties.Resources.correct);
                    player.Play();
                }

            }

            foreach (PictureBox fishpb2 in fish2.ToList())
            {
                //if any picturebox that spawn in form visible = false it will not use
                //the if statement
                if (pboxSubmarine.Bounds.IntersectsWith(fishpb2.Bounds) && fishpb2.Visible == true)
                {
                    //everytime the submarine intersect with any picturebox it will remove 
                    //the picturebox
                    fish2.Remove(fishpb2);
                    this.Controls.Remove(fishpb2);

                    correctCatch++;
                    wrongCatch = 0;
                    playerScore = correctCatch + wrongCatch;
                    playerHP = 100;
                    lblPointEarn.Text = "+1";

                    SoundPlayer player = new SoundPlayer(Properties.Resources.correct);
                    player.Play();
                }

            }

            foreach (PictureBox notfishpb2 in notfish2.ToList())
            {
                //if any picturebox that spawn in form visible = false it will not use
                //the if statement
                if (pboxSubmarine.Bounds.IntersectsWith(notfishpb2.Bounds) && notfishpb2.Visible == true)
                {
                    //everytime the submarine intersect with any picturebox it will remove 
                    //the picturebox
                    notfish2.Remove(notfishpb2);
                    this.Controls.Remove(notfishpb2);

                    SoundPlayer player = new SoundPlayer(Properties.Resources.wrong);
                    player.Play();


                    lblPointEarn.Text = "-1";
                    playerHP -= 20;
                    wrongCatch++;
                    correctCatch--;
                    playerScore = correctCatch;

                    if (playerScore < 0)
                    {
                        playerScore = 0;
                    }

                    if (correctCatch < 0)
                    {
                        correctCatch = 0;
                    }

                    if (wrongCatch == 5)
                    {
                        CountdownGameTimer.Stop();
                        FishSpawnTimer.Stop();
                        NonFishSpawnTimer.Stop();
                        TurtleSpawnTimer.Stop();
                        OctopusSpawnTimer.Stop();
                        FishSpawnTimer2.Stop();
                        NotFishSpawnTimer2.Stop();
                        SubmarineMoveTimer.Stop();
                        panelGameOver.Visible = true;

                    }
                }

            }

        }
    }
}
