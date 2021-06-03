using System;
using System.Security;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alien_Blastar
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, goUp, goDown, GameOver;
        bool pause;
        string facing = "up";
        int PlayerHealth = 100;
        int ammo = 10;
        int speed = 20;
        int innitspeedbullets = 10;
        int AlienSpeed = 3;
        int score;
        Random randNum = new Random();

        List<PictureBox> aliensList = new List<PictureBox>();



        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Health_Click(object sender, EventArgs e)
        {

        }

        private void Kills_Click(object sender, EventArgs e)
        {

        }

        private void Ammo_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            YouWin.Visible = false;
            
            if (PlayerHealth > 2)
            {
                HealthBar.Value = PlayerHealth;
            }
            else
            {
                YouWin.Text = "You lose!";
                YouWin.Visible = true;
                GameOver = true;
                Player.Image = Properties.Resources.Explosion;
                GameTimer.Stop();
            }

            Ammo.Text = "Ammo: " + ammo;
            Kills.Text = "Kills: " + score;

            if(score == 30)
            {
                YouWin.Text = "You Win!";
                YouWin.Visible = true;
                GameOver = true;
                GameTimer.Stop();
            }

            if (goLeft == true && Player.Left > 0)
            {
                Player.Left -= speed;
            }

            if (goRight == true && Player.Left + Player.Width < this.ClientSize.Width)
            {
                Player.Left += speed;
            }

            if (goUp == true && Player.Top > 38)
            {
                Player.Top -= speed;
            }

            if (goDown == true && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "PowerUp")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        PlayerHealth += 10;
                    }
                }


                if (x is PictureBox && x.Tag == "Alien")
                {

                    // below is the if statament thats checking the bounds of the player and the zombie

                    if (((PictureBox)x).Bounds.IntersectsWith(Player.Bounds))
                    {
                        PlayerHealth -= 1; // if the zombie hits the player then we decrease the health by 1
                    }

                    //move zombie towards the player picture box

                    if (((PictureBox)x).Left > Player.Left)
                    {
                        ((PictureBox)x).Left -= AlienSpeed; // move zombie towards the left of the player
                        ((PictureBox)x).Image = Properties.Resources.AlienRight__1_; // change the zombie image to the left
                    }

                    if (((PictureBox)x).Top > Player.Top)
                    {
                        ((PictureBox)x).Top -= AlienSpeed; // move zombie upwards towards the players top
                        ((PictureBox)x).Image = Properties.Resources.AlienUp; // change the zombie picture to the top pointing image
                    }
                    if (((PictureBox)x).Left < Player.Left)
                    {
                        ((PictureBox)x).Left += AlienSpeed; // move zombie towards the right of the player
                        ((PictureBox)x).Image = Properties.Resources.AlienRight__2_; // change the image to the right image
                    }
                    if (((PictureBox)x).Top < Player.Top)
                    {
                        ((PictureBox)x).Top += AlienSpeed; // move the zombie towards the bottom of the player
                        ((PictureBox)x).Image = Properties.Resources.AlienDown; // change the image to the down zombie
                    }

                    foreach (Control j in this.Controls)
                    {
                        // below is the selection thats identifying the bullet and zombie

                        if (j is PictureBox && j.Tag == "Bullet" && x is PictureBox && x.Tag == "Alien")
                        {
                            // below is the if statement thats checking if bullet hits the zombie
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++; // increase the kill score by 1 
                                this.Controls.Remove(j); // this will remove the bullet from the screen
                                j.Dispose(); // this will dispose the bullet all together from the program
                                this.Controls.Remove(x); // this will remove the zombie from the screen
                                x.Dispose(); // this will dispose the zombie from the program
                                MakeAliens(); // this function will invoke the make aliens function to add another zombie to the game
                            }
                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {


            if(GameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                Player.Image = Properties.Resources.Left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                Player.Image = Properties.Resources.Right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                Player.Image = Properties.Resources.Up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                Player.Image = Properties.Resources.Down;
            }

            if (e.KeyCode == Keys.P)
            {
                pause = true;
                GameTimer.Stop();
                YouWin.Text = "Paused, Press U to Unpause";
                YouWin.Visible = true;
            }

            if (e.KeyCode == Keys.U && pause == true)
            {
                GameTimer.Start();
                YouWin.Text = "Paused";
                YouWin.Visible = true;
            }

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;

            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && GameOver == false)
            {
                ammo--;
                innitspeedbullets++;
                ShootBullet(facing);

                if(ammo < 1)
                {
                    DropAmmo();
                }
                
                if (innitspeedbullets == 25)
                {
                    PowerUp();
                }
            }

            if(e.KeyCode == Keys.Enter && GameOver == true)
            {
                RestartGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = Player.Left + (Player.Width / 2);
            shootBullet.bulletTop = Player.Top + (Player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeAliens()
        {

            // when this function is called it will make Aliens in the game

            PictureBox Alien = new PictureBox(); // create a new picture box called Alien
            Alien.Tag = "Alien"; // add a tag to it called Alien
            Alien.Image = Properties.Resources.AlienUp; // the default picture for the Alien is AlienUp
            Alien.Left = randNum.Next(0, 650); // generate a number between 0 and 650 and assignment that to the new Aliens left 
            Alien.BackColor = Color.Transparent;
            Alien.Top = randNum.Next(40, 700); // generate a number between 0 and 700 and assignment that to the new Aliens top
            Alien.SizeMode = PictureBoxSizeMode.StretchImage; // set auto size for the new picture box
            aliensList.Add(Alien); // Add the Alien to the Alien List
            this.Controls.Add(Alien); // Add the picture box to the screen
            Player.SendToBack(); // Bring the player to the back
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.StretchImage;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(40, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            Player.BringToFront();
        }

        private void PowerUp()
        {

                PictureBox powerup = new PictureBox();
                powerup.Image = Properties.Resources.PowerUp;
                powerup.SizeMode = PictureBoxSizeMode.StretchImage;
                powerup.Left = randNum.Next(10, this.ClientSize.Width - powerup.Width);
                powerup.Top = randNum.Next(10, this.ClientSize.Height - powerup.Height);
                powerup.Tag = "PowerUp";
                powerup.BackColor = Color.Transparent;
                this.Controls.Add(powerup);
                Player.BringToFront();
            
        }



        private void RestartGame()
        {
            Player.Image = Properties.Resources.Up;

            foreach(PictureBox i in aliensList)
            {
                this.Controls.Remove(i);
            }

            aliensList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeAliens();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            GameOver = false;

            PlayerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();
        }
    }
}
