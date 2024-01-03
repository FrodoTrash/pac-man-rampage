using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace WindowsFormsApplication2
{
    public partial class Form1Game : Form
    {
        /*
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        */
        public Form1Game()
        {
            InitializeComponent();
            if (PowerUpRespawnTime == PowerUpTimeNext)
            {
                xspeed = randomNumber.Next(0, 700);
                yspeed = randomNumber.Next(0, 400);
                Point speedSpawn = new Point(xspeed, yspeed);
                Speed.Location = speedSpawn;
                Speed.Show();
            }
           


        }
        Random randomNumber = new Random();
        char smerPacman;
        string facing;
        bool PacmanSepremika = false;
        //powerup aktiviran
        bool PwrSpeed = false;
        bool pacmanArmed = false;
        //hitrost
        int speedNormal =  3;
        int speedPowerUp = 6;

        //za raketo
        Point mouseLoc;

        //HUD
        int ammo = 0;
        int timer = 0;
        public static int score = 0;
        int kills=0;

        //waves
        int ghostSpeed = 1;
        int ghostblueSpeed = 2;



        private void timer1_Tick(object sender, EventArgs e) //bscly game engine
        {
            gameTime.Start();
            //unarmed, brez powerup
            if (PacmanSepremika == true && !PwrSpeed && !pacmanArmed)
            {

                switch (smerPacman)
                {
                    case 'R': pbPacman.Left += speedNormal; facing = "right"; pbPacman.Image = Properties.Resources.pacmanAngryDESNO; break;
                    case 'L': pbPacman.Left -= speedNormal; facing = "left"; pbPacman.Image = Properties.Resources.pacmanAngryLEVO; break;
                    case 'D': pbPacman.Top += speedNormal; facing = "down"; pbPacman.Image = Properties.Resources.pacmanAngryDOL; break;
                    case 'U': pbPacman.Top -= speedNormal; facing = "up"; pbPacman.Image = Properties.Resources.pacmanAngryGOR; break;
                }
            }
            //unarmed z powerupm
            else if (PacmanSepremika == true && PwrSpeed == true && !pacmanArmed)
            {

                switch (smerPacman)
                {

                    case 'R': pbPacman.Left += speedPowerUp; facing = "right"; pbPacman.Image = Properties.Resources.pacmanAngryDESNO; break;
                    case 'L': pbPacman.Left -= speedPowerUp; facing = "left"; pbPacman.Image = Properties.Resources.pacmanAngryLEVO; break;
                    case 'D': pbPacman.Top += speedPowerUp; facing = "down"; pbPacman.Image = Properties.Resources.pacmanAngryDOL; break;
                    case 'U': pbPacman.Top -= speedPowerUp; facing = "up"; pbPacman.Image = Properties.Resources.pacmanAngryGOR; break;
                }
            }
            //armed brez powerup
            if (PacmanSepremika == true && !PwrSpeed && pacmanArmed)
            {

                switch (smerPacman)
                {
                    case 'R': pbPacman.Left += speedNormal; facing = "right"; pbPacman.Image = Properties.Resources.pacmanGunDESNO; break;
                    case 'L': pbPacman.Left -= speedNormal; facing = "left"; pbPacman.Image = Properties.Resources.pacmanGunLEVO; break;
                    case 'D': pbPacman.Top += speedNormal; facing = "down"; pbPacman.Image = Properties.Resources.pacmanGunDOL; break;
                    case 'U': pbPacman.Top -= speedNormal; facing = "up"; pbPacman.Image = Properties.Resources.pacmanGunGOR; break;
                }
            }
            //armed z powerup
            else if (PacmanSepremika == true && PwrSpeed == true && pacmanArmed)
            {

                switch (smerPacman)
                {
                    case 'R': pbPacman.Left += speedPowerUp; facing = "right"; pbPacman.Image = Properties.Resources.pacmanGunDESNO; break;
                    case 'L': pbPacman.Left -= speedPowerUp; facing = "left"; pbPacman.Image = Properties.Resources.pacmanGunLEVO; break;
                    case 'D': pbPacman.Top += speedPowerUp; facing = "down"; pbPacman.Image = Properties.Resources.pacmanGunDOL; break;
                    case 'U': pbPacman.Top -= speedPowerUp; facing = "up"; pbPacman.Image = Properties.Resources.pacmanGunGOR; break;
                }
            }

            //prikaz pozicije v consoli
            if (PacmanSepremika)
                for (int i = 0; i < 1; i++)
                {
                    //$pacman$//
                    //Console.Write("\rPACMAN: {0}", pbPacman.Location);

                }
            //form limiti
            //$pacman$//
            if (pbPacman.Left >= 800 - 40)//desno
            {
                pbPacman.Left = 800 - 41;
                PacmanSepremika = false;
            }
            if (pbPacman.Left <= 0)//levo
            {
                pbPacman.Left = 0 + 1;
                PacmanSepremika = false;
            }
            if (pbPacman.Top >= 430)//dol
            {
                pbPacman.Top = 430 - 1;
                PacmanSepremika = false;
            }
            if (pbPacman.Top <= 0)//gor
            {
                pbPacman.Top = 0 + 1;
                PacmanSepremika = false;
            }

            //collides

            //collide z hiso
            if (pbPacman.Bounds.IntersectsWith(house.Bounds))
                PacmanSepremika = false;
            //collide z ograjo
            if (pbPacman.Bounds.IntersectsWith(ograja.Bounds))
                PacmanSepremika = false;
            if (Speed.Bounds.IntersectsWith(ograja.Bounds))
            {
                xspeed = randomNumber.Next(0, 700);
                yspeed = randomNumber.Next(0, 400);
                Point speedSpawn = new Point(xspeed, yspeed);
                Speed.Location = speedSpawn;
            }


            //ghost z spawnerji
            ghostSpawner1.SendToBack();
            ghostSpawner2.SendToBack();
            ghostSpawner3.SendToBack();
            ghostSpawner4.SendToBack();

            //powerups - collide
            //speed
            if (pbPacman.Bounds.IntersectsWith(Speed.Bounds))
            {
                Speed.Visible = false;
                PwrSpeed = true;
                PowerInventory.Image = Properties.Resources.inventorySpeed;

            }

            //Collide z ammo
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "ammobox")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pbPacman.Bounds) && ammo < 3)
                    {
                        this.Controls.Remove(((PictureBox)x));
                        SoundPlayer snd = new SoundPlayer(WindowsFormsApplication2.Properties.Resources.reloadSound);
                        snd.Play();
                        ((PictureBox)x).Dispose();
                        ammo += 1;
                        pacmanArmed = true;
                    }
                    if (((PictureBox)x).Bounds.IntersectsWith(pbPacman.Bounds) && ammo == 3)
                    {
                        ((PictureBox)x).SendToBack();
                        ammo = 3;
                    }
                }
                if (x is PictureBox && x.Tag == "ghost")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pbPacman.Bounds))
                    {
                        tPacman.Enabled = false;
                        //this.Text = "Game over";
                        SoundPlayer snd = new SoundPlayer(WindowsFormsApplication2.Properties.Resources.Death);
                        snd.Play();
                        //DeathScreen.Visible = true;
                        gameover = true;
                        this.Close();
                        Form openForm = new deathscreen();
                        openForm.ShowDialog();
                        score = 0;

                    }

                    if (((PictureBox)x).Left > pbPacman.Left)//desno
                    {
                        ((PictureBox)x).Left -= ghostSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ghostLEVO;
                    }
                    if (((PictureBox)x).Left < pbPacman.Left)//levo
                    {
                        ((PictureBox)x).Left += ghostSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ghostDESNO;
                    }

                    if (((PictureBox)x).Top > pbPacman.Top)//gor
                    {
                        ((PictureBox)x).Top -= ghostSpeed;
                    }
                    if (((PictureBox)x).Top < pbPacman.Top)//dol
                    {
                        ((PictureBox)x).Top += ghostSpeed;
                    }
                }
                if (x is PictureBox && x.Tag == "ghostblue")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pbPacman.Bounds))
                    {
                        tPacman.Enabled = false;
                        //this.Text = "Game over";
                        SoundPlayer snd = new SoundPlayer(WindowsFormsApplication2.Properties.Resources.Death);
                        snd.Play();
                        //DeathScreen.Visible = true;
                        gameover = true;
                        this.Close();
                        Form openForm = new deathscreen();
                        openForm.ShowDialog();
                        score = 0;
                    }

                    if (((PictureBox)x).Left > pbPacman.Left)//desno
                    {
                        ((PictureBox)x).Left -= ghostblueSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ghostBlueLEVO;
                    }
                    if (((PictureBox)x).Left < pbPacman.Left)//levo
                    {
                        ((PictureBox)x).Left += ghostblueSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ghostBlueDesno;
                    }

                    if (((PictureBox)x).Top > pbPacman.Top)//gor
                    {
                        ((PictureBox)x).Top -= ghostblueSpeed;
                    }
                    if (((PictureBox)x).Top < pbPacman.Top)//dol
                    {
                        ((PictureBox)x).Top += ghostblueSpeed;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "ghost"))
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score += 10;
                            kills++;
                            this.Controls.Remove(j);
                            j.Dispose();
                            this.Controls.Remove(j);
                            x.Dispose();
                            scoreNum.Text = score.ToString();
                            KillsNum.Text = kills.ToString();
                            ghostwavekills++;
                            currentGhosts--;
                            SoundPlayer snd = new SoundPlayer(WindowsFormsApplication2.Properties.Resources.ghostDead);
                            snd.Play();
                        }
                    }
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "ghostblue"))
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score += 20;
                            kills++;
                            this.Controls.Remove(j);
                            j.Dispose();
                            this.Controls.Remove(j);
                            x.Dispose();
                            scoreNum.Text = score.ToString();
                            KillsNum.Text = kills.ToString();
                            ghostwavekills++;
                            currentGhosts--;
                            SoundPlayer snd = new SoundPlayer(WindowsFormsApplication2.Properties.Resources.ghostDead);
                            snd.Play();
                        }
                    }
                }
            }

            //ammo respawn
            if (ammo == 0)
            {
                AmmoRespawn.Start();
                pacmanArmed = false;
            }

            //konec wave
            if (wavecomplete == true)
            {
                WaveCountDown.Start();
            }
            if (wavecomplete == false)
            {
                WaveStart.Start();
                WaveCountDown.Start();
            }

            //ammo v invenotry
            switch (ammo)
            {
                case 0: Inventory1.Image = Properties.Resources.inventory; Inventory2.Image = Properties.Resources.inventory; Inventory3.Image = Properties.Resources.inventory; break;
                case 1: Inventory1.Image = Properties.Resources.inventoryBullet; Inventory2.Image = Properties.Resources.inventory; Inventory3.Image = Properties.Resources.inventory; break;
                case 2: Inventory1.Image = Properties.Resources.inventoryBullet; Inventory2.Image = Properties.Resources.inventoryBullet; Inventory3.Image = Properties.Resources.inventory; break;
                case 3: Inventory1.Image = Properties.Resources.inventoryBullet; Inventory2.Image = Properties.Resources.inventoryBullet; Inventory3.Image = Properties.Resources.inventoryBullet; break;
            }
        }
        //int ghostsToSpawn; //kolio se jih mora spawnat
        //int ghoststokill; //koliko duhov za ubit 

        int ghostwavekills = 0; //koliko duhov sem ubil trenutno
        bool gameover = false;
        bool wavecomplete = false;
        int maxGhosts=6;
        int currentGhosts = 0;

        int spawningTime; //ko se sreca z ghostspawntime se pojavi duh
        int spawningTimeNext = 5;//prvi se bo cez 5sec spawnow
        private void WaveStart_Tick(object sender, EventArgs e)
        {
            //ko se zacne
                spawningTime++;
            
            if (spawningTime == spawningTimeNext && kills < 5 && currentGhosts <= maxGhosts)
            {
                makeGhost();
                
                //k

            }
            else if ( kills >=5 && spawningTime == spawningTimeNext && currentGhosts <= maxGhosts)
            {
                makeBlueGhost();
                
                
            }
            else if (kills >= 10 && spawningTime == spawningTimeNext && currentGhosts <= maxGhosts)
            {
                makeBlueGhost();
                makeGhost(); 
            }
            if(spawningTime > spawningTimeNext)
            {
                spawningTime = 0;
            }

            label12.Text = spawningTime.ToString();
                label8.Text = spawningTimeNext.ToString();
            label13.Text = currentGhosts.ToString();





            label6.Text = "killed " +ghostwavekills.ToString();
            //label7.Text = "to kill " + ghoststokill.ToString();            
            label10.Text = "complete " + wavecomplete.ToString();
            //label11.Text = "to spawn " + ghostsToSpawn.ToString();
        }

        int wavecountdown =5;
        private void WaveCountDown_Tick(object sender, EventArgs e)
        {
            //konec wave
            wavecountdown--;
            newwaveNum.Text = wavecountdown.ToString();
            newwaveNum.SendToBack();
            newwaveText.SendToBack();
            if (wavecountdown == 0)
            {
                newwaveNum.Text = wavecountdown.ToString();
                wavecountdown = 0;
                WaveCountDown.Stop();
                newwaveNum.Dispose();
                newwaveText.Dispose();

            }
        }
        //smer streljanja 
        private void shoot(string direct)
        {
            bulllet shoot = new bulllet();
            shoot.direction = direct;
            shoot.bulletLeft = pbPacman.Left+5;
            shoot.bulletTop = pbPacman.Top+5;
            shoot.mkBullet(this);
        }       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W: smerPacman = 'U'; PacmanSepremika = true; break;
                case Keys.S: smerPacman = 'D'; PacmanSepremika = true; break;
                case Keys.A: smerPacman = 'L'; PacmanSepremika = true; break;
                case Keys.D: smerPacman = 'R'; PacmanSepremika = true; break;
                case Keys.Space: PacmanSepremika = false;  break;
                case Keys.ShiftKey: PacmanSepremika = false;  break;
            }
        }
     
        private void Form1Game_KeyUp(object sender, KeyEventArgs e)
        {            
            if(e.KeyCode == Keys.X && pacmanArmed)
            {
                shoot(facing);
                SoundPlayer snd = new SoundPlayer(WindowsFormsApplication2.Properties.Resources.shootSound);
                snd.Play();
                ammo--;
            }
        }

        int ammoSpawnTimer = 0;
        int ammoSpawnTimerNext = 5;
        int yspeed;
        int xspeed;

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (!AllocConsole())
            // MessageBox.Show("Erorr, Console");


        }



        //timer za powerupe 5 sekund trajanje
        int PowerUpTime;
        int PowerUpRespawnTime;
        int PowerUpTimeNext;

        private void speedPower_Tick(object sender, EventArgs e)
        {
            //ko pobere
            if (PwrSpeed == true)
            {
                Speed.Enabled = false;
                PowerUpTimer.Start();
                PowerUpTime++;

                timeLabel.Text = PowerUpTime.ToString();
                
            }
            //ko powerUp potece po 5tih sekundah
            if (PowerUpTime == 5)
            {
                PwrSpeed = false;
                PowerUpTime = 0;
                PowerUpTimeNext = randomNumber.Next(3, 6);
                timeLabel.Text = PowerUpTime.ToString();
                label3.Text = PowerUpTimeNext.ToString();
                PowerInventory.Image = Properties.Resources.inventory;

                PowerUpRespawnTimer.Start();
            }
        }

        private void PowerUpRespawnTimer_Tick(object sender, EventArgs e)
        {
            PowerUpRespawnTime++;
            label4.Text = PowerUpRespawnTime.ToString();

            if (PowerUpRespawnTime == PowerUpTimeNext)
            {
                xspeed = randomNumber.Next(0, 700);
                yspeed = randomNumber.Next(0, 400);
                Point speedSpawn = new Point(xspeed, yspeed);
                Speed.Location = speedSpawn;
                Speed.Show();
                Speed.Enabled = true;
                PowerUpRespawnTime = 0;
                PowerUpRespawnTimer.Stop();
            }

        }

        private void AmmoRespawn_Tick(object sender, EventArgs e)
        {
            
            ammoSpawnTimer++;
            if (ammoSpawnTimer == ammoSpawnTimerNext)
            {
                AmmoBoxDrop();
                ammoSpawnTimer = 0;
            }
            label1.Text = ammoSpawnTimer.ToString();
            label2.Text = ammoSpawnTimerNext.ToString();
            label5.Text = ammo.ToString();
        }

        //mouse click 
        private void Form1Game_MouseClick(object sender, MouseEventArgs e)
        {
            //kordinate miske click
            mouseLoc = new Point(e.X, e.Y);
            Console.Write(mouseLoc);
        }

        class bulllet
        {
            public string direction;
            public int speed = 20;
            PictureBox Bullet = new PictureBox();
            Timer tm = new Timer();

            public int bulletLeft;
            public int bulletTop;

            public void mkBullet(Form1Game form1Game)
            {
                Bullet.BackColor = System.Drawing.Color.White;
                Bullet.Size = new Size(5, 5);
                Bullet.Tag = "bullet";
                Bullet.Left = bulletLeft;
                Bullet.Top = bulletTop;
                Bullet.BringToFront();
                form1Game.Controls.Add(Bullet);

                tm.Interval = speed;
                tm.Tick += new EventHandler(tm_Tick);
                tm.Start();
            }
            public void tm_Tick(object sender, EventArgs e)
            {
                if(direction == "left")
                {
                    Bullet.Left -= speed;
                }
                if (direction == "right")
                {
                    Bullet.Left += speed;
                }
                if (direction == "up")
                {
                    Bullet.Top -= speed;
                }
                if (direction == "down")
                {
                    Bullet.Top += speed;
                }
                if (Bullet.Left < 1 || Bullet.Left > 800 || Bullet.Top < 1 || Bullet.Top > 500)
                {
                    tm.Stop();
                    tm.Dispose();
                    Bullet.Dispose();
                    tm = null;
                    Bullet = null; 
                }
            }
        }

       

        private void AmmoBoxDrop()
        {
            ammoSpawnTimerNext = randomNumber.Next(1, 6);
            PictureBox ammoBox = new PictureBox();
            ammoBox.Image = Properties.Resources.ammoBox;
            ammoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ammoBox.Size = new System.Drawing.Size(24, 24);
            ammoBox.Left = randomNumber.Next(24, 776);
            ammoBox.Top = randomNumber.Next(24, 476);
            ammoBox.Tag = "ammobox";
            ammoBox.BackColor = Color.Transparent;
            this.Controls.Add(ammoBox);
        }


        private void makeGhost()
        {
            currentGhosts++;
            spawningTime = 0;
            //spawnerji
            spawningTimeNext = randomNumber.Next(1, 6);
            Point spawner1 = new Point(40, 363);
            Point spawner2 = new Point(206, 156);
            Point spawner3 = new Point(535, 68);
            Point spawner4 = new Point(595, 363);
            Point[] spawnerji = { spawner1, spawner2, spawner3, spawner4 };
            int randomSpawn = randomNumber.Next(4);

            PictureBox ghost = new PictureBox();
            ghost.Tag = "ghost";
            ghost.Image = Properties.Resources.ghost;
            ghost.SizeMode = PictureBoxSizeMode.StretchImage;
            ghost.Size = new System.Drawing.Size(30, 30);
            ghost.BackColor = Color.Transparent;
            ghost.Location = spawnerji[randomSpawn];
            //ghost.Left = randomNumber.Next(0, 800);
            //ghost.Top = randomNumber.Next(0, 500);

            //ghost.Location = spawner1;
            this.Controls.Add(ghost);
        }
        private void makeBlueGhost()
        {
            currentGhosts++;
            spawningTime = 0;
            //spawnerji
            spawningTimeNext = randomNumber.Next(1, 6);
            Point spawner1 = new Point(40, 363);
            Point spawner2 = new Point(206, 156);
            Point spawner3 = new Point(535, 68);
            Point spawner4 = new Point(595, 363);
            Point[] spawnerji = { spawner1, spawner2, spawner3, spawner4 };
            int randomSpawn = randomNumber.Next(4);

            PictureBox ghost = new PictureBox();
            ghost.Tag = "ghostblue";
            ghost.Image = Properties.Resources.ghostBlueDesno;
            ghost.SizeMode = PictureBoxSizeMode.StretchImage;
            ghost.Size = new System.Drawing.Size(30, 30);
            ghost.BackColor = Color.Transparent;
            ghost.Location = spawnerji[randomSpawn];

            this.Controls.Add(ghost);
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            timer++;
            TimeNumber.Text = timer.ToString();
            if (gameover == true)
                gameTime.Stop();
        }

        private void Form1Game_Load(object sender, EventArgs e)
        {
            spawningTimeNext = randomNumber.Next(3, 6);
        }

        private void Form1Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form openForm = new Menu();
            openForm.ShowDialog();
        }

        private void newwaveText_Click(object sender, EventArgs e)
        {

        }
    }   
}
            