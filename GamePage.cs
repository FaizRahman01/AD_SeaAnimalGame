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


namespace AD_SeaAnimalGame
{
    public partial class GamePage : Form
    {
        private Point windowLocation;
        public static GamePage GamePageInstance;

        Random randomSpawn = new Random();
        List<PictureBox> fish = new List<PictureBox>();
        List<PictureBox> notfish = new List<PictureBox>();
        List<PictureBox> octopus = new List<PictureBox>();
        List<PictureBox> seaturtle = new List<PictureBox>();
        List<PictureBox> fish2 = new List<PictureBox>();
        List<PictureBox> notfish2 = new List<PictureBox>();
        public GamePage()
        {
            InitializeComponent();
            GamePageInstance = this;
        }

        private void FishSpawn()
        {

            PictureBox pbNormalFish = new PictureBox();
            pbNormalFish.Height = 50;
            pbNormalFish.Width = 50;
            pbNormalFish.Image = Properties.Resources.bluefish;
            pbNormalFish.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNormalFish.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - pbNormalFish.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbNormalFish.Height);
            pbNormalFish.Location = new Point(x, y);

            fish.Add(pbNormalFish);
            this.Controls.Add(pbNormalFish);
        }

        private void NotFishSpawn()
        {

            PictureBox pbNotFish = new PictureBox();
            pbNotFish.Height = 50;
            pbNotFish.Width = 50;
            pbNotFish.Image = Properties.Resources.trash;
            pbNotFish.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNotFish.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - pbNotFish.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbNotFish.Height);
            pbNotFish.Location = new Point(x, y);

            notfish.Add(pbNotFish);
            this.Controls.Add(pbNotFish);


        }

        private async void SeaTurtleSpawn()
        {
            //spawn new pic box for sea turtle object
            PictureBox pbSeaTurtle = new PictureBox();
            pbSeaTurtle.Height = 50;
            pbSeaTurtle.Width = 50;
            pbSeaTurtle.Image = Properties.Resources.seaturtle;
            pbSeaTurtle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSeaTurtle.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - pbSeaTurtle.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbSeaTurtle.Height);
            pbSeaTurtle.Location = new Point(x, y);

            seaturtle.Add(pbSeaTurtle);
            this.Controls.Add(pbSeaTurtle);

            await Task.Delay(3000);
            pbSeaTurtle.Dispose();
        }


        private async void OctopusSpawn()
        {
            //spawn new pic box for octopus object
            PictureBox pbOctopus = new PictureBox();
            pbOctopus.Height = 50;
            pbOctopus.Width = 50;
            pbOctopus.Image = Properties.Resources.octopus;
            pbOctopus.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOctopus.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - pbOctopus.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbOctopus.Height);
            pbOctopus.Location = new Point(x, y);

            octopus.Add(pbOctopus);
            this.Controls.Add(pbOctopus);

            await Task.Delay(3000);
            pbOctopus.Dispose();
        }

        private async void FishSpawn2()
        {

            PictureBox pbNormalFish2 = new PictureBox();
            pbNormalFish2.Height = 50;
            pbNormalFish2.Width = 50;
            pbNormalFish2.Image = Properties.Resources.yellowfish;
            pbNormalFish2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNormalFish2.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - pbNormalFish2.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbNormalFish2.Height);
            pbNormalFish2.Location = new Point(x, y);

            fish2.Add(pbNormalFish2);
            this.Controls.Add(pbNormalFish2);

            await Task.Delay(3000);
            pbNormalFish2.Dispose();
        }

        private async void NotFishSpawn2()
        {

            PictureBox pbNotFish2 = new PictureBox();
            pbNotFish2.Height = 50;
            pbNotFish2.Width = 50;
            pbNotFish2.Image = Properties.Resources.bottle;
            pbNotFish2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNotFish2.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - pbNotFish2.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - pbNotFish2.Height);
            pbNotFish2.Location = new Point(x, y);

            notfish2.Add(pbNotFish2);
            this.Controls.Add(pbNotFish2);

            await Task.Delay(3000);
            pbNotFish2.Dispose();
        }


        private void panelGamePage_MouseDown(object sender, MouseEventArgs e)
        {
            this.windowLocation = e.Location;
        }

        private void panelGamePage_MouseMove(object sender, MouseEventArgs e)
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

        bool submarineUp, submarineDown, submarineLeft, submarineRight;

        int submarineSpeed = 12;

        private void GamePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
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


        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerMainPage pmainpage = new PlayerMainPage();
            pmainpage.Show();
            TimeCounter = 120;
        }

        private void btnCloseGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
            TimeCounter = 120;
        }

        int TimeCounter = 120;
        private void CountdownGameTimer_Tick(object sender, EventArgs e)
        {
            lblGameTImer.Text = String.Format("{0} s", TimeCounter);

            if (TimeCounter > 0)
            {
                CountdownGameTimer.Start();
                TimeCounter--;
            }
            else if (TimeCounter == 0)
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


            if(TimeCounter > 100)
            {
                TurtleSpawnTimer.Stop();
                OctopusSpawnTimer.Stop();
                FishSpawnTimer2.Stop();
                NotFishSpawnTimer2.Stop();
            }

            else if(TimeCounter <= 100 && TimeCounter > 0)
            {
                TurtleSpawnTimer.Start();
                OctopusSpawnTimer.Start();
                FishSpawnTimer2.Start();
                NotFishSpawnTimer2.Start();

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
                FishSpawnTimer.Stop();
                NonFishSpawnTimer.Stop();

                lblLevelDisplay.Text = "Level 2";
            }

        }


        int wrongCatch = 0;
        int playerScore = 0;
        int correctCatch = 0;
        int playerHP = 100;

        private void SubmarineMoveTimer_Tick(object sender, EventArgs e)
        {
            PlayerSkin1 pskin1 = new PlayerSkin1();
            PlayerSkin2 pskin2 = new PlayerSkin2();
            PlayerSkin3 pskin3 = new PlayerSkin3();

            string skingame;
            Bitmap skinImage;

            if (SkinOptionPage.SkinOptionInstance.skin == "Spekter")
            {
                pskin1.SetMainSkin("submarineleft");
                skingame = pskin1.GetMainSkin();
                skinImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(skingame);
                pboxSubmarine.Image = skinImage;
            }
            else if (SkinOptionPage.SkinOptionInstance.skin == "Fantom")
            {
                pskin2.SetSecondSkin("submarine2left");
                skingame = pskin2.GetSecondSkin();
                skinImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(skingame);
                pboxSubmarine.Image = skinImage;

            }
            else if (SkinOptionPage.SkinOptionInstance.skin == "Veindal")
            {
                pskin3.SetThirdSkin("submarine3left");
                skingame = pskin3.GetThirdSkin();
                skinImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(skingame);
                pboxSubmarine.Image = skinImage;
            }
            else
            {
                pskin2.SetSecondSkin("submarineleft");
                skingame = pskin2.GetSecondSkin();
                skinImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(skingame);
                pboxSubmarine.Image = skinImage;
            }

            
            //move left
            if (submarineLeft == true && pboxSubmarine.Left > 0)
            {
                pboxSubmarine.Left -= submarineSpeed;

                if(skingame.ToString() == "submarineleft")
                {
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

                if (skingame.ToString() == "submarineleft")
                {
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


            lblGameScore.Text = "" + playerScore;
            lblNotFishCatch.Text = "NotFish: " + wrongCatch;
            lblFishCatch.Text = "Fish: " + correctCatch;

            submarineHP.Value = Convert.ToInt32(playerHP);

            foreach (PictureBox fishpb in fish.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(fishpb.Bounds))
                {
                    // if the collision happened do the following
                    fish.Remove(fishpb);
                    this.Controls.Remove(fishpb);

                    correctCatch++;
                    wrongCatch = 0;
                    playerScore = correctCatch + wrongCatch;
                    playerHP = 100;
                    lblPointEarn.Text = "+1";

                    SoundPlayer player = new SoundPlayer(Properties.Resources.correct);
                    player.Play();
                }

            }

            foreach (PictureBox notfishpb in notfish.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(notfishpb.Bounds))
                {
                    // if the collision happened do the following
                    notfish.Remove(notfishpb);
                    this.Controls.Remove(notfishpb);

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

            //remove octopus when intersect  with submarine
            foreach (PictureBox octopuspb in octopus.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(octopuspb.Bounds))
                {

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

            //remove sea turtle when intersect  with submarine
            foreach (PictureBox seaturtlepb in seaturtle.ToList())
            {
                if (pboxSubmarine.Bounds.IntersectsWith(seaturtlepb.Bounds))
                {

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
                if (pboxSubmarine.Bounds.IntersectsWith(fishpb2.Bounds))
                {
                    // if the collision happened do the following
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
                if (pboxSubmarine.Bounds.IntersectsWith(notfishpb2.Bounds))
                {
                    // if the collision happened do the following
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
