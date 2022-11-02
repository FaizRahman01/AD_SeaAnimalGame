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


        Random randomSpawn = new Random();
        List<PictureBox> fish = new List<PictureBox>();
        List<PictureBox> notfish = new List<PictureBox>();

        public GamePage()
        {
            InitializeComponent();
        }



        private void FishSpawn()
        {
            //spawn new pic box for fish object
            PictureBox normalFish = new PictureBox();
            normalFish.Height = 50;
            normalFish.Width = 50;
            normalFish.Image = Properties.Resources.bluefish;
            normalFish.SizeMode = PictureBoxSizeMode.StretchImage;
            normalFish.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - normalFish.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - normalFish.Height);
            normalFish.Location = new Point(x, y);

            fish.Add(normalFish);
            this.Controls.Add(normalFish);
            
        }

        private void NotFishSpawn()
        {
            //spawn new pic box for random object
            PictureBox notFish = new PictureBox();
            notFish.Height = 50;
            notFish.Width = 50;
            notFish.Image = Properties.Resources.trash;
            notFish.SizeMode = PictureBoxSizeMode.StretchImage;
            notFish.BackColor = Color.Transparent;

            int x = randomSpawn.Next(10, this.ClientSize.Width - notFish.Width);
            int y = randomSpawn.Next(10, this.ClientSize.Height - notFish.Height);
            notFish.Location = new Point(x, y);

            notfish.Add(notFish);
            this.Controls.Add(notFish);
        }



        //Event--------------------------------



        bool submarineUp, submarineDown, submarineLeft, submarineRight;

        int submarineSpeed = 12;

        private void GamePage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                submarineLeft = true;
                pboxSubmarine.Image = Properties.Resources.submarineleft;
            }
            if (e.KeyCode == Keys.D)
            {
                submarineRight = true;
                pboxSubmarine.Image = Properties.Resources.submarineright;
            }
            if (e.KeyCode == Keys.W)
            {
                submarineUp = true;
                pboxSubmarine.Image = Properties.Resources.submarineup;
            }
            if (e.KeyCode == Keys.S)
            {
                submarineDown = true;
                pboxSubmarine.Image = Properties.Resources.submarinedown;
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


        //timer for object spawn


        private void FishSpawnTimer_Tick(object sender, EventArgs e)
        {
            FishSpawn();

        }

        private void NonFishSpawnTimer_Tick(object sender, EventArgs e)
        {
            NotFishSpawn();
        }



        int playerScore = 0;

        private static int GameTime = 60;
        private int TimeCounter = GameTime;

        private void timerCountdownGame_Tick(object sender, EventArgs e)
        {
            lblGameTImer.Text = String.Format("{0} s", TimeCounter);

            

            if(TimeCounter > 0)
            {
                timerCountdownGame.Start();

                GameTime = TimeCounter;
                TimeCounter--;
            }
            else if(TimeCounter == 0)
            {
                timerCountdownGame.Stop();
                FishSpawnTimer.Stop();
                NonFishSpawnTimer.Stop();
                SubmarineMoveTimer.Stop();
                panelGameOver.Visible = true;
            }
        }

        private void btnCloseGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
            GameTime = 60;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerMainPage pmainpage = new PlayerMainPage();
            pmainpage.Show();

            GameTime = 60;
        }

        int wrongCatch = 0;
        int correctCatch = 0;
        private void SubmarineMoveTimer_Tick(object sender, EventArgs e)
        {
            if (submarineLeft == true && pboxSubmarine.Left > 0)
            {
                pboxSubmarine.Left -= submarineSpeed;
            }

            if (submarineRight == true && pboxSubmarine.Left < 877)
            {
                pboxSubmarine.Left += submarineSpeed;
            }

            if (submarineUp == true && pboxSubmarine.Top > 0)
            {
                pboxSubmarine.Top -= submarineSpeed;
            }

            if (submarineDown == true && pboxSubmarine.Top < 599)
            {
                pboxSubmarine.Top += submarineSpeed;
            }

            lblGameScore.Text = "" + playerScore;
            lblNotFishCatch.Text = "NotFish: " + wrongCatch;
            lblFishCatch.Text = "Fish: " + correctCatch;


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
                        timerCountdownGame.Stop();
                        FishSpawnTimer.Stop();
                        NonFishSpawnTimer.Stop();
                        SubmarineMoveTimer.Stop();
                        panelGameOver.Visible = true;

                    }
                }

            }
        }
    }
}
