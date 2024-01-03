namespace WindowsFormsApplication2
{
    partial class Form1Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Game));
            this.tPacman = new System.Windows.Forms.Timer(this.components);
            this.tGhost = new System.Windows.Forms.Timer(this.components);
            this.tSpremeniSmer = new System.Windows.Forms.Timer(this.components);
            this.ograja = new System.Windows.Forms.Panel();
            this.Inventory3 = new System.Windows.Forms.PictureBox();
            this.Inventory2 = new System.Windows.Forms.PictureBox();
            this.Inventory1 = new System.Windows.Forms.PictureBox();
            this.pbPacman = new System.Windows.Forms.PictureBox();
            this.InventoryTxt = new System.Windows.Forms.Label();
            this.house = new System.Windows.Forms.PictureBox();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.scoreNum = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.PictureBox();
            this.PowerInventory = new System.Windows.Forms.PictureBox();
            this.PowerUptxt = new System.Windows.Forms.Label();
            this.PowerUpTimer = new System.Windows.Forms.Timer(this.components);
            this.ghostRespawn = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.AmmoRespawn = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ghostSpawner2 = new System.Windows.Forms.PictureBox();
            this.ghostSpawner1 = new System.Windows.Forms.PictureBox();
            this.ghostSpawner3 = new System.Windows.Forms.PictureBox();
            this.ghostSpawner4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PowerUpRespawnTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.TimeNumber = new System.Windows.Forms.Label();
            this.WaveCountDown = new System.Windows.Forms.Timer(this.components);
            this.newwaveText = new System.Windows.Forms.Label();
            this.newwaveNum = new System.Windows.Forms.Label();
            this.KillsTxt = new System.Windows.Forms.Label();
            this.KillsNum = new System.Windows.Forms.Label();
            this.WaveStart = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WaveTimer = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostSpawner2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostSpawner1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostSpawner3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostSpawner4)).BeginInit();
            this.SuspendLayout();
            // 
            // tPacman
            // 
            this.tPacman.Enabled = true;
            this.tPacman.Interval = 10;
            this.tPacman.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tGhost
            // 
            this.tGhost.Enabled = true;
            this.tGhost.Interval = 15;
            // 
            // tSpremeniSmer
            // 
            this.tSpremeniSmer.Enabled = true;
            this.tSpremeniSmer.Interval = 1000;
            // 
            // ograja
            // 
            this.ograja.BackColor = System.Drawing.Color.Transparent;
            this.ograja.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fence;
            this.ograja.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ograja.Location = new System.Drawing.Point(457, 259);
            this.ograja.Name = "ograja";
            this.ograja.Size = new System.Drawing.Size(194, 33);
            this.ograja.TabIndex = 2;
            // 
            // Inventory3
            // 
            this.Inventory3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Inventory3.BackgroundImage")));
            this.Inventory3.Location = new System.Drawing.Point(682, 43);
            this.Inventory3.Name = "Inventory3";
            this.Inventory3.Size = new System.Drawing.Size(32, 32);
            this.Inventory3.TabIndex = 4;
            this.Inventory3.TabStop = false;
            // 
            // Inventory2
            // 
            this.Inventory2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Inventory2.BackgroundImage")));
            this.Inventory2.Location = new System.Drawing.Point(644, 43);
            this.Inventory2.Name = "Inventory2";
            this.Inventory2.Size = new System.Drawing.Size(32, 32);
            this.Inventory2.TabIndex = 4;
            this.Inventory2.TabStop = false;
            // 
            // Inventory1
            // 
            this.Inventory1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Inventory1.BackgroundImage")));
            this.Inventory1.Location = new System.Drawing.Point(606, 43);
            this.Inventory1.Name = "Inventory1";
            this.Inventory1.Size = new System.Drawing.Size(32, 32);
            this.Inventory1.TabIndex = 4;
            this.Inventory1.TabStop = false;
            // 
            // pbPacman
            // 
            this.pbPacman.BackColor = System.Drawing.Color.Transparent;
            this.pbPacman.Image = global::WindowsFormsApplication2.Properties.Resources.pacman;
            this.pbPacman.Location = new System.Drawing.Point(682, 294);
            this.pbPacman.Name = "pbPacman";
            this.pbPacman.Size = new System.Drawing.Size(30, 30);
            this.pbPacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPacman.TabIndex = 0;
            this.pbPacman.TabStop = false;
            // 
            // InventoryTxt
            // 
            this.InventoryTxt.AutoSize = true;
            this.InventoryTxt.BackColor = System.Drawing.Color.Transparent;
            this.InventoryTxt.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryTxt.Location = new System.Drawing.Point(602, 9);
            this.InventoryTxt.Name = "InventoryTxt";
            this.InventoryTxt.Size = new System.Drawing.Size(85, 31);
            this.InventoryTxt.TabIndex = 5;
            this.InventoryTxt.Text = "Bullets";
            // 
            // house
            // 
            this.house.BackColor = System.Drawing.Color.Transparent;
            this.house.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.house;
            this.house.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.house.Location = new System.Drawing.Point(623, 180);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(142, 108);
            this.house.TabIndex = 6;
            this.house.TabStop = false;
            // 
            // scoreTxt
            // 
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.BackColor = System.Drawing.Color.Transparent;
            this.scoreTxt.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTxt.Location = new System.Drawing.Point(12, 9);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(70, 31);
            this.scoreTxt.TabIndex = 7;
            this.scoreTxt.Text = "Score:";
            // 
            // scoreNum
            // 
            this.scoreNum.AutoSize = true;
            this.scoreNum.BackColor = System.Drawing.Color.Transparent;
            this.scoreNum.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreNum.Location = new System.Drawing.Point(88, 9);
            this.scoreNum.Name = "scoreNum";
            this.scoreNum.Size = new System.Drawing.Size(23, 31);
            this.scoreNum.TabIndex = 8;
            this.scoreNum.Text = "0";
            // 
            // Speed
            // 
            this.Speed.BackColor = System.Drawing.Color.Transparent;
            this.Speed.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.speed;
            this.Speed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Speed.Location = new System.Drawing.Point(457, 51);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(24, 24);
            this.Speed.TabIndex = 9;
            this.Speed.TabStop = false;
            // 
            // PowerInventory
            // 
            this.PowerInventory.BackColor = System.Drawing.Color.Transparent;
            this.PowerInventory.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.inventory;
            this.PowerInventory.Image = global::WindowsFormsApplication2.Properties.Resources.inventory;
            this.PowerInventory.Location = new System.Drawing.Point(293, 7);
            this.PowerInventory.Name = "PowerInventory";
            this.PowerInventory.Size = new System.Drawing.Size(32, 32);
            this.PowerInventory.TabIndex = 4;
            this.PowerInventory.TabStop = false;
            // 
            // PowerUptxt
            // 
            this.PowerUptxt.AutoSize = true;
            this.PowerUptxt.BackColor = System.Drawing.Color.Transparent;
            this.PowerUptxt.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerUptxt.Location = new System.Drawing.Point(183, 9);
            this.PowerUptxt.Name = "PowerUptxt";
            this.PowerUptxt.Size = new System.Drawing.Size(104, 31);
            this.PowerUptxt.TabIndex = 7;
            this.PowerUptxt.Text = "PowerUp:";
            // 
            // PowerUpTimer
            // 
            this.PowerUpTimer.Enabled = true;
            this.PowerUpTimer.Interval = 1000;
            this.PowerUpTimer.Tick += new System.EventHandler(this.speedPower_Tick);
            // 
            // ghostRespawn
            // 
            this.ghostRespawn.Interval = 1000;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Yellow;
            this.timeLabel.Location = new System.Drawing.Point(330, 5);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(13, 13);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "0";
            this.timeLabel.Visible = false;
            // 
            // AmmoRespawn
            // 
            this.AmmoRespawn.Interval = 1000;
            this.AmmoRespawn.Tick += new System.EventHandler(this.AmmoRespawn_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(720, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(720, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // ghostSpawner2
            // 
            this.ghostSpawner2.BackColor = System.Drawing.Color.Transparent;
            this.ghostSpawner2.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.hole;
            this.ghostSpawner2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghostSpawner2.Location = new System.Drawing.Point(33, 363);
            this.ghostSpawner2.Name = "ghostSpawner2";
            this.ghostSpawner2.Size = new System.Drawing.Size(49, 42);
            this.ghostSpawner2.TabIndex = 14;
            this.ghostSpawner2.TabStop = false;
            // 
            // ghostSpawner1
            // 
            this.ghostSpawner1.BackColor = System.Drawing.Color.Transparent;
            this.ghostSpawner1.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.hole;
            this.ghostSpawner1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghostSpawner1.Location = new System.Drawing.Point(525, 68);
            this.ghostSpawner1.Name = "ghostSpawner1";
            this.ghostSpawner1.Size = new System.Drawing.Size(49, 42);
            this.ghostSpawner1.TabIndex = 14;
            this.ghostSpawner1.TabStop = false;
            // 
            // ghostSpawner3
            // 
            this.ghostSpawner3.BackColor = System.Drawing.Color.Transparent;
            this.ghostSpawner3.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.hole;
            this.ghostSpawner3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghostSpawner3.Location = new System.Drawing.Point(589, 363);
            this.ghostSpawner3.Name = "ghostSpawner3";
            this.ghostSpawner3.Size = new System.Drawing.Size(49, 42);
            this.ghostSpawner3.TabIndex = 14;
            this.ghostSpawner3.TabStop = false;
            // 
            // ghostSpawner4
            // 
            this.ghostSpawner4.BackColor = System.Drawing.Color.Transparent;
            this.ghostSpawner4.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.hole;
            this.ghostSpawner4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghostSpawner4.Location = new System.Drawing.Point(200, 156);
            this.ghostSpawner4.Name = "ghostSpawner4";
            this.ghostSpawner4.Size = new System.Drawing.Size(49, 42);
            this.ghostSpawner4.TabIndex = 14;
            this.ghostSpawner4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(330, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "0";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(330, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "0";
            this.label4.Visible = false;
            // 
            // PowerUpRespawnTimer
            // 
            this.PowerUpRespawnTimer.Interval = 1000;
            this.PowerUpRespawnTimer.Tick += new System.EventHandler(this.PowerUpRespawnTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(720, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "0";
            this.label5.Visible = false;
            // 
            // gameTime
            // 
            this.gameTime.Interval = 1000;
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold);
            this.Time.Location = new System.Drawing.Point(12, 31);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(68, 31);
            this.Time.TabIndex = 15;
            this.Time.Text = "Time:";
            // 
            // TimeNumber
            // 
            this.TimeNumber.AutoSize = true;
            this.TimeNumber.BackColor = System.Drawing.Color.Transparent;
            this.TimeNumber.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeNumber.Location = new System.Drawing.Point(88, 31);
            this.TimeNumber.Name = "TimeNumber";
            this.TimeNumber.Size = new System.Drawing.Size(23, 31);
            this.TimeNumber.TabIndex = 8;
            this.TimeNumber.Text = "0";
            // 
            // WaveCountDown
            // 
            this.WaveCountDown.Interval = 1000;
            this.WaveCountDown.Tick += new System.EventHandler(this.WaveCountDown_Tick);
            // 
            // newwaveText
            // 
            this.newwaveText.AutoSize = true;
            this.newwaveText.BackColor = System.Drawing.Color.Transparent;
            this.newwaveText.Font = new System.Drawing.Font("Viner Hand ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newwaveText.ForeColor = System.Drawing.Color.Red;
            this.newwaveText.Location = new System.Drawing.Point(-24, 137);
            this.newwaveText.Name = "newwaveText";
            this.newwaveText.Size = new System.Drawing.Size(468, 155);
            this.newwaveText.TabIndex = 16;
            this.newwaveText.Text = "Horde in:";
            // 
            // newwaveNum
            // 
            this.newwaveNum.AutoSize = true;
            this.newwaveNum.BackColor = System.Drawing.Color.Transparent;
            this.newwaveNum.Font = new System.Drawing.Font("Viner Hand ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newwaveNum.ForeColor = System.Drawing.Color.Red;
            this.newwaveNum.Location = new System.Drawing.Point(431, 133);
            this.newwaveNum.Name = "newwaveNum";
            this.newwaveNum.Size = new System.Drawing.Size(109, 155);
            this.newwaveNum.TabIndex = 16;
            this.newwaveNum.Text = "5";
            // 
            // KillsTxt
            // 
            this.KillsTxt.AutoSize = true;
            this.KillsTxt.BackColor = System.Drawing.Color.Transparent;
            this.KillsTxt.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillsTxt.Location = new System.Drawing.Point(468, 7);
            this.KillsTxt.Name = "KillsTxt";
            this.KillsTxt.Size = new System.Drawing.Size(70, 31);
            this.KillsTxt.TabIndex = 15;
            this.KillsTxt.Text = "Kills:";
            // 
            // KillsNum
            // 
            this.KillsNum.AutoSize = true;
            this.KillsNum.BackColor = System.Drawing.Color.Transparent;
            this.KillsNum.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillsNum.Location = new System.Drawing.Point(544, 7);
            this.KillsNum.Name = "KillsNum";
            this.KillsNum.Size = new System.Drawing.Size(23, 31);
            this.KillsNum.TabIndex = 8;
            this.KillsNum.Text = "0";
            // 
            // WaveStart
            // 
            this.WaveStart.Interval = 1000;
            this.WaveStart.Tick += new System.EventHandler(this.WaveStart_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(748, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "label6";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(737, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "0";
            this.label8.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(720, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "label6";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(748, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "label6";
            this.label11.Visible = false;
            // 
            // WaveTimer
            // 
            this.WaveTimer.Interval = 1000;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(737, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "0";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(737, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "0";
            this.label13.Visible = false;
            // 
            // Form1Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newwaveNum);
            this.Controls.Add(this.newwaveText);
            this.Controls.Add(this.KillsTxt);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.ghostSpawner1);
            this.Controls.Add(this.ghostSpawner4);
            this.Controls.Add(this.ghostSpawner3);
            this.Controls.Add(this.ghostSpawner2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.KillsNum);
            this.Controls.Add(this.TimeNumber);
            this.Controls.Add(this.scoreNum);
            this.Controls.Add(this.PowerUptxt);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.house);
            this.Controls.Add(this.InventoryTxt);
            this.Controls.Add(this.PowerInventory);
            this.Controls.Add(this.Inventory3);
            this.Controls.Add(this.Inventory2);
            this.Controls.Add(this.Inventory1);
            this.Controls.Add(this.ograja);
            this.Controls.Add(this.pbPacman);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1Game";
            this.Text = "Pacman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1Game_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1Game_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1Game_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.Inventory3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostSpawner2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostSpawner1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostSpawner3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostSpawner4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPacman;
        private System.Windows.Forms.Timer tPacman;
        private System.Windows.Forms.Timer tGhost;
        private System.Windows.Forms.Timer tSpremeniSmer;
        private System.Windows.Forms.Panel ograja;
        private System.Windows.Forms.PictureBox Inventory1;
        private System.Windows.Forms.PictureBox Inventory2;
        private System.Windows.Forms.PictureBox Inventory3;
        private System.Windows.Forms.Label InventoryTxt;
        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.Label scoreNum;
        private System.Windows.Forms.PictureBox Speed;
        private System.Windows.Forms.PictureBox PowerInventory;
        private System.Windows.Forms.Label PowerUptxt;
        private System.Windows.Forms.Timer PowerUpTimer;
        private System.Windows.Forms.Timer ghostRespawn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer AmmoRespawn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ghostSpawner2;
        private System.Windows.Forms.PictureBox ghostSpawner1;
        private System.Windows.Forms.PictureBox ghostSpawner3;
        private System.Windows.Forms.PictureBox ghostSpawner4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer PowerUpRespawnTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label TimeNumber;
        private System.Windows.Forms.Timer WaveCountDown;
        private System.Windows.Forms.Label newwaveText;
        private System.Windows.Forms.Label newwaveNum;
        private System.Windows.Forms.Label KillsTxt;
        private System.Windows.Forms.Label KillsNum;
        private System.Windows.Forms.Timer WaveStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer WaveTimer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

