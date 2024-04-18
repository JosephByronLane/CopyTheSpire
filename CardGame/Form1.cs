using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using WinFormAnimation;
using Application = System.Windows.Forms.Application;
using Image = System.Drawing.Image;
using WMPLib;
using System.Threading;

namespace CardGame
{

    public partial class mainForm : Form
    {


        public bool ENABLE_MAIN_MENU = true;
        public bool ENABLE_SOUND = true;

        #region Variables
        bool arrastrando = false;
        bool actualproceed = false;

        Point originalPos;

        Player player;
        


        //patrones de ataque
        Attackpatterns Aggresive = new Attackpatterns(10, 25, 1, 10,
                               false, 0, false, 0,
                                 Attackpatterns.TipoBias.Attack, 30);
        Attackpatterns Defensive = new Attackpatterns(10, 15, 10, 20,
                               false, 0, false, 0,
                            Attackpatterns.TipoBias.Defense, 30);
        Attackpatterns Neutral = new Attackpatterns(10, 15, 10, 20,
                             false, 0, false, 0,
                              Attackpatterns.TipoBias.None, 30);
        Attackpatterns Boss = new Attackpatterns(2, 5, 20, 30,
                             false, 0, false, 0,
                               Attackpatterns.TipoBias.Defense, 30);




        List<Enemigo> enemylist = new List<Enemigo>();
        Enemigo enemy;
        Enemigo sphereEnemy;
        Enemigo headEnemy;
        Enemigo spearandshieldEnemy;
        Enemigo heartEnemy;
        //todas
        public Mazo mazo = new Mazo();

        //en juego
        public List<Carta> Pila = new List<Carta>();
        //mano
        public List<CartaGlobal> Mano = new List<CartaGlobal>();
        //usadas
        public List<Carta> Cementerio = new List<Carta>();
        #endregion

        #region Form Instance
        public mainForm()
        {

            InitializeComponent();
            this.Cursor = new Cursor(Properties.Resources.cursor__1_.Handle);
            Point menutxtstartpoint = new Point(mmplaytest.Location.X, mmplaytest.Location.Y);
            var prevvalues = this.Controls;



            /// testing functions

            //STRENGTH WORKS
            //player.AddBuff("strength",5 ); 

            //WEAKNESS WORKS
            //player.AddDebuff("weakness", 5);


            //player.AddDebuff("vulnerable", 4);
            Attack angercard = new Attack(1, 300, 0, Anger);
            Skill blockcard = new Skill(1, 5, Block);


            Aggresive.initializeattackpattern();
            Defensive.initializeattackpattern();
            Neutral.initializeattackpattern();
            Boss.initializeattackpattern();

            enemy = new Enemigo(30, Aggresive, Enemy1);             
            sphereEnemy= new Enemigo(25,Defensive,Enemy1);
            headEnemy = new Enemigo(75, Neutral, Enemy1);
            spearandshieldEnemy = new Enemigo(55, Aggresive, Enemy1);
            heartEnemy = new Enemigo(150, Boss, Enemy1);
            Mano.Add(angercard);
            Mano.Add(blockcard);


            player = new Player(3, 75, PlanyerP);
            
            enemylist.Add(enemy);
            enemylist.Add(sphereEnemy);
            enemylist.Add(headEnemy);
            enemylist.Add(spearandshieldEnemy);
            enemylist.Add(heartEnemy);


            hptextUI.Text = Convert.ToString(player.HP);
            hptext2.Text = Convert.ToString(player.hp);
            ///end of testing section



            ////Manage transparency
            //var sprites = this.Controls.OfType<PictureBox>();
            //foreach (PictureBox pb in sprites)
            //{
            //    pb.BackColor = Color.Transparent;

            //    if (pb.Tag.Equals("card"))
            //    {
            //        /*pb.Name = "carta"+ tmp;
            //        tmp++;*/
            //        //solo cartas
            //        pb.BringToFront();
            //    }

            //    if (pb.Tag.Equals("ui"))
            //    {
            //        /*pb.Name = "carta"+ tmp;
            //        tmp++;*/
            //        //solo cartas
            //        pb.BringToFront();
            //    }

            //    if (pb.Tag.Equals("topui"))
            //    {
            //        /*pb.Name = "carta"+ tmp;
            //        tmp++;*/
            //        //solo cartas
            //        pb.BringToFront();
            //    }
            //}
            //foreach (Label lb in this.Controls.OfType<Label>())
            //{
            //    if (lb.Tag.Equals("ui"))
            //    {
            //        /*pb.Name = "carta"+ tmp;
            //        tmp++;*/
            //        //solo cartas
            //        lb.BringToFront();
            //    }
            //}

            //Agregar 10 cartas diferentes al Deck

            //pila

            Pila.Add(new Carta("C1", 6, 0, new PictureBox()));
            Pila[0].ImgPath = "Bash";

            CartaUI(Pila[0]);

            //5 cartas
            List<Carta> hand = new List<Carta>();
            //for 1-5
            hand.Add(new Carta("Strike", 6, 0, Anger));
            //instanciar UI



            InitializeEnemy();
            InitializePlayer();

            if (ENABLE_MAIN_MENU)
            {
                StartMainMenu();
            }
            else
            {
                playbg($"lv{enemylistiterator + 1}.wav");
                playam($"lv{enemylistiterator + 1}am.wav");
            }




        }
        #endregion

        #region UI Actions


        void CartaUI(Carta c)
        {

            c.Visual.Size = new Size(160, 200);
            c.Visual.Location = new Point((this.Width / 2) - (c.Visual.Width / 2), (this.Height) - (c.Visual.Height + 50));
            c.Visual.BackColor = Color.Transparent;
            c.Visual.BackgroundImageLayout = ImageLayout.Stretch;
            c.Visual.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("Bash");
            c.Visual.Name = c.Nombre;
            c.Visual.Click += new EventHandler(c.doDMG);
            c.Visual.BringToFront();
            Controls.Add(c.Visual);


        }
       
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            originalPos = Anger.Location;
            arrastrando = true;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                var pos = ActiveForm.PointToClient(MousePosition);
                Anger.Location = new Point(pos.X - (Anger.Width / 2), pos.Y - (Anger.Height / 2));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
            Anger.Location = originalPos;
        }

        private void Player_Click(object sender, EventArgs e)
        {
            Anim_PlayerAtk(sender);

        }

        private void Clickeado(object sender, EventArgs e)
        {

            if (((PictureBox)sender).Name == "holi0")
            {
                ((PictureBox)sender).BackColor = Color.Blue;

            }
            if (((PictureBox)sender).Name == "holi100")
            {
                ((PictureBox)sender).BackColor = Color.Green;
            }

        }
        private void Anger_Click(object sender, EventArgs e)
        {
            //Anim_MovetoCenter(sender);
            Anim_PlayerAtk(player.VisualP);
            enemylist[enemylistiterator].Takedamage(100, player);
            if (enemylist[enemylistiterator].isdead)
            {
                DieAnimation(enemylist[enemylistiterator].VisualP);
                
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Block_Click(object sender, EventArgs e)
        {
            player.addblock(5);
            //Anim_CardVanish(sender);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //fuck i didnt mean to click this
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            //fuck i didnt mean to click this either
        }
        private void topbarUI_Paint(object sender, PaintEventArgs e)
        {
            //jesus fuck i keep trying to double click to edit the text but i forget
            //it opens this stupid fucking menu
        }
        private void label1_Click_3(object sender, EventArgs e)
        {
            //jesus fuck im going to kill myself
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //jesus fucking christ 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //for what man, for what
        }


        
        #endregion

        #region Animations
        async void Anim_PlayerAtk(object target)
        {
            this.atkiconenemy.Visible = true;

            Point playerPos = ((Control)target).Location;
            new Animator2D(
                 new Path2D(playerPos.X, playerPos.X + 100, playerPos.Y, playerPos.Y, 100)
                 .ContinueTo(playerPos.ToFloat2D(), 100, 0))
                 .Play(target, Animator2D.KnownProperties.Location);
            await Task.Delay(500);
            this.atkiconenemy.Visible = false;
        }


        void Anim_MovetoCenter(object target)
        {
            Point cardPos = ((Control)target).Location;
            Point discardpos = discardpilepanell.Location;
            new Animator2D(
                new Path2D(cardPos.X, (ActiveForm.Width / 2) - (((Control)target).Width/2), cardPos.Y, (ActiveForm.Height / 2) - (((Control)target).Height/2), 200)
                .ContinueTo(discardpos.ToFloat2D(),100,0)
                
                ).Play(target, Animator2D.KnownProperties.Location);
                        
        }

        void Anim_CardVanish(object target)
        {
            ((Control)target).Visible = false;
        }
        async void enemyatkanim(Enemigo enem)
        {
            this.atkplayericon.Visible = true;

            Point enmpos = ((Control)enem.VisualP).Location;
            new Animator2D(
                 new Path2D(enmpos.X, enmpos.X - 100, enmpos.Y, enmpos.Y, 200)
                 .ContinueTo(enmpos.ToFloat2D(), 100, 0))
                 .Play(enem.VisualP, Animator2D.KnownProperties.Location);
            await Task.Delay(500);
            this.atkplayericon.Visible = false;

        }
        int enemyatkiterator = 0;
        int enemylistiterator = 0;

        async void playerTurnEnd()
        {
            playuisfx($"ent.wav");
            await Task.Delay(100);

            endturnbanner.BringToFront();
            endturntxt.BringToFront();
            endturnbanner.Visible = true;
            endturntxt.Text = "Enemy turn";
            endturntxt.Visible = true;
            playuisfx($"endt.wav");


            await Task.Delay(1000);
            endturnbanner.Visible = false;
            endturntxt.Visible = false;

            enemylist[enemylistiterator].resetblock();

            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Attack{enemyatkiterator}"))
            {

                enemyatkanim(enemylist[enemylistiterator]);
                player.Takedamage(enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"],
                               enemylist[enemylistiterator]);
                if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 80)
                {
                    playatksfx("enatk_sythe.wav");
                }
                else if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 40)
                {
                    playatksfx("enatk_axe.wav");

                }
                else if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 30)
                {
                    playatksfx("enatk_butcher.wav");

                }
                else if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 20)
                {
                    playatksfx("enatk_scimitar.wav");

                }
                else if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 10)
                {
                    playatksfx("enatk_sword.wav");

                }
                else if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 5)
                {
                    playatksfx("enatk_dagger.wav");

                }
                else if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] >= 0)
                {
                    playatksfx("enatk_knife.wav");

                }
                if (player.isdead)
                {
                    await Task.Delay(300);
                    playerdie();
                }
            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Block{enemyatkiterator}"))
            {
                playdefsfx($"def{rnd2.Next(1, 4)}.wav");

                enemylist[enemylistiterator].addblock(enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Block{enemyatkiterator}"]);
            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Strength{enemyatkiterator}"))
            {
                enemylist[enemylistiterator].AddBuff("Strength", enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator]["Strength"]);
            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Dexterity{enemyatkiterator}"))
            {
                enemylist[enemylistiterator].AddBuff("Strength", enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator]["Dexterity"]);

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Vulnerability{enemyatkiterator}"))
            {
                player.AddBuff("Vulnerability", enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator]["Vulnerability"]);

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Weakness{enemyatkiterator}"))
            {
                player.AddBuff("Weakness", enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator]["Weakness"]);

            }

            player.resetblock();
            player.resetenergy();
            InitializePlayer();
            enemyatkiterator++;
            await Task.Delay(1000);

            ///enemy turn doer
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Attack{enemyatkiterator}"))
            {
               if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 80)
                {
                    mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.attack_intent_7;

                }
                else if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 40)
                {
                    mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.attack_intent_6;

                }
                else if(enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 30)
                {
                    mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.attack_intent_5;

                }
                else if(enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 20)
                {
                    mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.attack_intent_4;

                }
                else if(enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 10)
                {
                    mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.attack_intent_3;

                }
                else if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] > 5)
                {
                    mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.attack_intent_2;

                }
                else if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"] >= 0)
                {
                    mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.attack_intent_1;

                }
                mainForm.ActiveForm.Controls.Find("enemyintentatkintent", true)[0].Text = Convert.ToString(
                    enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"]);
                mainForm.ActiveForm.Controls.Find("enemyintentatkintent", true)[0].Show();
               

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Block{enemyatkiterator}"))
            {
                mainForm.ActiveForm.Controls.Find("enemyintentatkintent", true)[0].Hide();
                mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.block;

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Strength{enemyatkiterator}"))
            {
                mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.buff1;
                mainForm.ActiveForm.Controls.Find("enemyintentatkintent", true)[0].Hide();

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Dexterity{enemyatkiterator}"))
            {
                mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.buff1;
                mainForm.ActiveForm.Controls.Find("enemyintentatkintent", true)[0].Hide();

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey("Weakness"))
            {
               
                mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.debuff1;
                mainForm.ActiveForm.Controls.Find("enemyintentatkintent", true)[0].Hide();

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey("Vulnerability"))
            {
               
                mainForm.ActiveForm.Controls.Find("enemyintent", true)[0].BackgroundImage = Properties.Resources.debuff1;
                mainForm.ActiveForm.Controls.Find("enemyintentatkintent", true)[0].Hide();

            }
            if (!player.isdead)
            {
                endturnbanner.BringToFront();
                endturntxt.BringToFront();
                endturnbanner.Visible = true;
                endturntxt.Text = "Player turn";
                endturntxt.Visible = true;
                playptsfx($"pt{rnd2.Next(2,5)}.wav");

                await Task.Delay(1000);
                endturnbanner.Visible = false;
                endturntxt.Visible = false;
                InitializePlayer();
            }

        }

        void InitializePlayer()
        {
            energytxtui.Text = ($"{player.Energy}/{player.totalenergy}");
        }

        void InitializeEnemy()
        {
            enemyatkiterator = 0;
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Attack{enemyatkiterator}"))
            {
                this.enemyintent.BackgroundImage = Properties.Resources.attack_intent_2;
                this.enemyintentatkintent.Text = Convert.ToString(
                    enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator][$"Attack{enemyatkiterator}"]);
                this.enemyintent.Show();

                this.enemyintentatkintent.Show();


            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Block{enemyatkiterator}"))
            {
                this.enemyintent.Show();
                this.enemyintentatkintent.Hide();
                this.enemyintent.BackgroundImage = Properties.Resources.block;

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Strength{enemyatkiterator}"))
            {
                this.enemyintent.BackgroundImage = Properties.Resources.buff1;
                this.enemyintent.Show();

                this.enemyintentatkintent.Hide();

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey($"Dexterity{enemyatkiterator}"))
            {
                this.enemyintent.BackgroundImage = Properties.Resources.buff1;
                this.enemyintent.Show();

                this.enemyintentatkintent.Hide();

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey("Weakness"))
            {
                enemy.AddBuff("Weakness",
                              enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator]["Weakness"]);
                this.enemyintent.BackgroundImage = Properties.Resources.debuff1;
                this.enemyintent.Show();

                this.enemyintentatkintent.Hide();

            }
            if (enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator].ContainsKey("Vulnerability"))
            {
                enemy.AddBuff("Vulnerability",
                              enemylist[enemylistiterator].attackpatterns.Attackpattern[enemyatkiterator]["Vulnerability"]);
                this.enemyintent.BackgroundImage = Properties.Resources.debuff1;
                this.enemyintent.Show();

                this.enemyintentatkintent.Hide();

            }

            this.enemyhpbartext.Text = Convert.ToString(enemylist[enemylistiterator].HP);

        }
        private void endturnuipanel_Paint(object sender, PaintEventArgs e)
        {
            playerTurnEnd();
        }
        private void endturntxtui_Click(object sender, EventArgs e)
        {
            playerTurnEnd();
        }

        private void testbtn_Click(object sender, EventArgs e)
        {
            InitializeEnemy();

        }

        public async void StartMainMenu()
        {
            
            loadingscreen.Visible = true;
            loadingscreen.Size = new Size(1627, 939);
            loadingscreen.Location = new Point(0,0);
            loadingscreen.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("loadingscreen");
            loadingscreen.BringToFront();
            loadingscreen.Show();
            var allc = this.Controls;

            foreach (Control a in allc)
            {
                if (a.Tag != "mm")
                {
                    a.Hide();
                }
                else
                {
                    a.Show();
                }

            }



            this.BackgroundImage= (Image)Properties.Resources.ResourceManager.GetObject("mmbg");
            Panel c = new Panel();
            c.Size = new Size(555, 391);
            c.Location = new Point((this.Width / 2) - (c.Width / 2), (this.Height/2)-(c.Height/2 ));
            c.BackgroundImageLayout = ImageLayout.Zoom;
            c.BackColor = Color.Transparent;
            c.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("logo");
            c.Name = "mmlogo";
            c.Tag = "mm";
            Controls.Add(c);
            ///CLOUDS


            cloud1.Visible = true;
            cloud1.Enabled = true;
            cloud1.BringToFront();
            Controls.Add(cloud1);
            Point c1loc= new Point(cloud1.Location.X,cloud1.Location.Y);
            new Animator2D(
                new Path2D(c1loc.X, c1loc.X - 1000, c1loc.Y, c1loc.Y, 50000)
                )
            { Repeat = true }
                .Play(cloud1, Animator2D.KnownProperties.Location);


            cloud2.Visible = true;
            cloud2.Enabled = true;
            cloud1.BringToFront();
            Controls.Add(cloud1);
            Point c2loc = new Point(cloud2.Location.X, cloud2.Location.Y);
            new Animator2D(
                new Path2D(c2loc.X, c2loc.X - 1000, c2loc.Y, c2loc.Y, 70000))
            { Repeat = true }
                .Play(cloud2, Animator2D.KnownProperties.Location);


            cloud3.Visible = true;
            cloud3.Enabled = true;
            cloud1.BringToFront();
            Controls.Add(cloud1);
            Point c3loc = new Point(cloud3.Location.X, cloud3.Location.Y);
            new Animator2D(
                new Path2D(c3loc.X, c3loc.X - 1000, c3loc.Y, c3loc.Y, 50000)
                )
            { Repeat = true }
                 .Play(cloud3, Animator2D.KnownProperties.Location);

            Enemy1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"Enemy{enemylistiterator + 1}");
            await Task.Delay(3000);
            loadingscreen.Hide();
            playbg("mmmusic.wav");
            playam("windam1.wav");
            //windam(true);
        }
        WindowsMediaPlayer bgmsc = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer amb = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer atksfx = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer uisfx = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer defsfx = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer ptsfx = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer hbsfx = new  WindowsMediaPlayer();

        public void playbg(string path)
        {
            if (ENABLE_SOUND)
            {
                bgmsc.URL = Convert.ToString(path);

                bgmsc.controls.play();
            }
        }
        public void playbg(bool stop)
        {
            bgmsc.controls.stop();
        }

        public void playam(string path)
        {
            if (ENABLE_SOUND)
            {
                amb.URL = Convert.ToString(path);

                amb.controls.play();
            }
        }

        public void playatksfx(string path)
        {
            if (ENABLE_SOUND)
            {
                atksfx.URL = Convert.ToString(path);

                atksfx.controls.play();

            }
        }
        public void playuisfx(string path)
        {
            if (ENABLE_SOUND)
            {
                uisfx.URL = Convert.ToString(path);

                uisfx.controls.play();

            }
        }
        public void playdefsfx(string path)
        {
            if (ENABLE_SOUND)
            {
                defsfx.URL = Convert.ToString(path);

                defsfx.controls.play();

            }
        }
        public void playptsfx(string path)
        {
            if (ENABLE_SOUND)
            {
                ptsfx.URL = Convert.ToString(path);

                ptsfx.controls.play();
            }
        }
        public void playhbsfx(string path)
        {
            if (ENABLE_SOUND)
            {
                hbsfx.URL = Convert.ToString(path);

                ptsfx.controls.play();

            }
        }
        public void playhbsfx(bool stop)
        {
            hbsfx.controls.stop();
        }

        public async void launchgame()
        {


            loadingscreen.Visible = true;
            loadingscreen.BringToFront();
            var allc = this.Controls;
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("BG1");

            foreach (Control a in allc)
            {
                if (a.Tag == "mm" || a.Tag == "nn" || a.Tag == "map")
                {
                    a.Hide();
                }
                else
                {
                    a.Show();
                }

            }
            InitializeEnemy();
            await Task.Delay(1000);

            loadingscreen.Hide();





        }

        public async void DieAnimation(object target)
        {
            playbg(false);
            if (enemylistiterator > 3)
            {
                hbcancel += 5;
            }
            playptsfx("bvst.wav");
            playhbsfx(false);
            Point cardPos = ((Control)target).Location;            
            new Animator2D(
                new Path2D(cardPos.X, cardPos.X+10, cardPos.Y,cardPos.Y, 200)
                .ContinueTo(new Float2D(cardPos.X - 20, cardPos.Y ),200)
                .ContinueTo(new Float2D(cardPos.X + 20, cardPos.Y), 200)
                .ContinueTo(new Float2D(cardPos.X - 20, cardPos.Y), 200)
                .ContinueTo(new Float2D(cardPos.X + 10, cardPos.Y), 200)
                ).Play(target, Animator2D.KnownProperties.Location);
            playbg($"bossv1.wav");
            
            await Task.Delay(800);
            actualproceed = true;
            ((Control)target).Visible=false;

            this.proceedbtn.Enabled = true;
            this.proceedbtn.Visible = true;
            this.proceedbtntext.Visible = true;
            this.endturnuipanel.Visible = false;
            this.endturnuipanel.Enabled = false;

            this.endturntxtui.Visible = false;
            this.endturntxtui.Enabled = false;

            this.enemyintent.Visible = false;
            this.enemyintentatkintent.Visible = false;

            this.enemyhpbartext.Visible = false;

        }
        public void playerdie()
        {
            playbg(false);
            playptsfx("dst.wav");
            foreach (Control a in this.Controls)
            {
                if (a.Name != "PlanyerP")
                {
                    a.Hide();
                }

            }

            PlanyerP.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("corpse");
            this.BackgroundImage= (Image)Properties.Resources.ResourceManager.GetObject("defeat");
            hptext2.Hide();

            this.proceedbtn.Enabled = true;
            this.proceedbtn.Visible = true;
            this.endturnuipanel.Visible = false;
            this.endturnuipanel.Enabled = false;

            this.endturntxtui.Visible = false;
            this.endturntxtui.Enabled = false;

            this.enemyintent.Visible = false;
            this.enemyintentatkintent.Visible = false;

            this.enemyhpbartext.Visible = false;
            this.proceedbtntext.Text = "Try again";

            playbg($"de{rnd2.Next(1,5)}.wav");

        }

        #endregion

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void mmplaytest_Click(object sender, EventArgs e)
        {
            launchgame();
            playbg($"lv{enemylistiterator+1}.wav");
            mapproceed();



        }

        private void proceedbtn_Paint(object sender, PaintEventArgs e)
        {

        }
        private void proceedbtn_Click(object sender, EventArgs e)
        {

            playuisfx($"uiclick{rnd2.Next(1, 3)}.wav");

            if (actualproceed)
            {
                enemylistiterator++;
                actualproceed = false;
            }
            mapproceed();

            if (enemylistiterator == 5 || player.isdead)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                player.resetenergy();
                player.resetblock();
                InitializePlayer();

                mapmenu.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"mapuiat{enemylistiterator + 1}");
                floortextUI.Text = Convert.ToString(enemylistiterator);

                Enemy1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"Enemy{enemylistiterator + 1}");
                switch (enemylistiterator)
                {
                    case 1:
                        resetenemy(sphereEnemy);
                        break;
                    case 2:
                        resetenemy(headEnemy);
                        break;
                    case 3:
                        resetenemy(spearandshieldEnemy);
                        break;
                    case 4:
                        resetenemy(heartEnemy);

                        double t1;
                        double t2;

                        double r = 1.69;

                        t1 = heartEnemy.VisualP.Width * r;
                        t2 = heartEnemy.VisualP.Height * r;


                    //380, 274
                         heartEnemy.VisualP.Width = 942;
                        heartEnemy.VisualP.Height = 763;


                    // 845, 343
                        heartEnemy.VisualP.Top = -150;
                        heartEnemy.VisualP.Left = 643;


                       // enemyintent.Left -= 650;
                        enemyblock.Top += 250;
                        enemyblock.Left += 80;

                    enemyintent.Left -= 300;

                   heartEnemy.VisualP.Controls.Add(enemyintent);

                    enemyintent.BringToFront();
                    enemyintentatkintent.BringToFront();
                    enemyhpbartext.BringToFront();
                    enemyhpnar.BringToFront();
                    enemyblock.BringToFront();
                    enemyblocktext.BringToFront();


                    foreach (Control a in this.Controls)
                        {
                            if (a.Tag == "topui")
                            {
                                a.BringToFront();
                            }
                            else
                            {

                            }

                        }

                        break;
                    case 5:
                        restartgame();

                        break;
                }
                



        }
        int hbcancel = 0;
        public async void startheartbeat()
        {
                playhbsfx($"hblong.wav");
                await Task.Delay(2000);
        }  

        public void restartgame()
        {

            foreach (Control a in this.Controls)
            {
                if (a.Name == "PlanyerP" || a.Name== "proceedbtntext" || a.Name== "proceedbtn")
                {
                    a.Show();
                }
                else
                {
                    a.Hide();

                }

            }
            playptsfx("vst.wav");

            PlanyerP.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("corpse");

            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("victory");

            Enemy1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"Enemy{enemylistiterator + 1}");
            this.proceedbtn.Enabled = true;
            this.proceedbtn.Visible = true;
            this.proceedbtntext.Text = "Restart";

        }
        public void resetenemy(Enemigo e)
        {
            enemyhpbartext.Text = e.HP.ToString();
            enemyhpnar.Width = 374;
            InitializeEnemy();

        }
        Random rnd2 = new Random();
        private void genericcardplayer(object sender, EventArgs e)
        {
            foreach (var carta in Mano)
            {
                if (sender == carta.Visual)
                {
                    if (carta is Attack)
                    {
                        if (player.canplay(((Attack)carta).Energia))
                        {
                            enemylist[enemylistiterator].Takedamage(((Attack)carta).Damage, player);
                            player.reduceEnergy(((Attack)carta).Energia);
                            if (enemylist[enemylistiterator].isdead)
                            {
                                DieAnimation(enemylist[enemylistiterator].VisualP);
                                
                            }
                            playatksfx($"atk{rnd2.Next(1,3)}.wav");
                        }
                        else
                        {

                        }

                    }
                    if (carta is Skill)
                    {
                        if (player.canplay(((Skill)carta).Energia))
                        {
                            player.addblock(((Skill)carta).Block);
                            player.reduceEnergy(((Skill)carta).Energia);
                            playdefsfx($"def{rnd2.Next(1, 4)}.wav");

                        }
                        else
                        {

                        }
                    }

                }
            }
        }


        private void mmplaytest_MouseHover(object sender, EventArgs e)
        {
            Point startpos = ((Control)sender).Location;
            new Animator2D(
                new Path2D(startpos.X, startpos.X + 30, startpos.Y, startpos.Y, 100)
                ).Play(sender, Animator2D.KnownProperties.Location);
            
            mmplaytest.BringToFront();

        }

        private void mmplaytest_MouseLeave(object sender, EventArgs e)
        {
            Point startpos = mmplaytest.Location;
            new Animator2D(
                new Path2D(startpos.X, startpos.X-30 , startpos.Y, startpos.Y, 100)
                ).Play(sender, Animator2D.KnownProperties.Location);
            TransparentPanel lightup = new TransparentPanel();

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }
        bool ismapactive = true;
        List<bool> controlpreviousstate = new List<bool>();

        public void mapproceed()
        {

            playuisfx($"uiclick{rnd2.Next(1, 3)}.wav");
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"BG{enemylistiterator + 1}");

            var allc = this.Controls;

            if (mapmenu.Visible)
            {
                int listiterator = 0;

                foreach (Control c in allc)
                {
                    if (c.Tag != "topui")
                    {
                        if (c.Tag != "mm")
                        {
                            if (c.Tag != "nn")
                            {
                                c.Show();

                            }
                        }

                    }

                }
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"BG{enemylistiterator + 1}");
                mapmenu.Visible = false;
                proceedbtn.Visible = false;
                proceedbtntext.Visible = false;
                this.Enemy1.Visible = true;
                if (enemylistiterator == 4)
                {
                    startheartbeat();
                    playam($"bsb.wav");
                }
                if (enemylistiterator < 5)
                {
                    this.endturnuipanel.Visible = true;
                    this.endturnuipanel.Enabled = true;

                    this.endturntxtui.Visible = true;
                    this.endturntxtui.Enabled = true;

                    InitializeEnemy();
                    //if (!mapmenu.Visible)
                    //{
                    //    playbg($"lv{enemylistiterator + 1}.wav");

                    //}
                    if (enemylistiterator == 4)
                    {
                        playbg($"lv{enemylistiterator + 1}.wav");

                    }
                    playam($"wd{rnd2.Next(1, 3)}.wav");
                    playam($"bs{rnd2.Next(1, 3)}.wav");

                    this.enemyhpbartext.Visible = true;

                }


            }
            else
            {

                if (enemylistiterator != 4)
                {
                    playbg($"lv{enemylistiterator + 1}.wav");

                }

                //saves previous loadstates
                foreach (Control c in allc)
                {
                    if (c.Tag != "topui")
                    {
                        controlpreviousstate.Add(c.Visible);
                        c.Visible = false;
                    }
                }
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"mapbg");
                mapmenu.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"mapuiat{enemylistiterator + 1}");
                mapmenu.Visible = true;
                mapmenu.Size = new Size(601, 852);
                mapmenu.BackgroundImageLayout = ImageLayout.Zoom;
                mapmenu.BringToFront();
                proceedbtn.Visible = true;
                proceedbtntext.Visible = true;
            }
        }

        public void fakemapshow(bool show)
        {
            PictureBox fakemap = new PictureBox();

            if (show)
            {
                fakemap.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"mapbg");
                fakemap.Location = new Point(0, 0);
                fakemap.Size = new Size(this.Width, this.Height);
                Controls.Add(fakemap);
                fakemap.BringToFront();
                fakemap.Visible = true;
                proceedbtn.Visible = true;
                proceedbtntext.Visible = true;
                proceedbtn.BringToFront();
                proceedbtntext.BringToFront();
                var allc = this.Controls;
                foreach (Control a in allc)
                {
                    if (a.Tag == "topui")
                    {
                        a.BringToFront();
                    }
                }
            }
            else
            {
                fakemap.Visible = false;
                proceedbtn.Visible = false;
                proceedbtntext.Visible = false;
            }
        }
        




        private void topbarUImap_Click(object sender, EventArgs e)
        {
            playuisfx($"uiclick{rnd2.Next(1, 3)}.wav");

            var allc = this.Controls;


            if (mapmenu.Visible)
            {
                int listiterator = 0;

                foreach (Control c in allc)
                {
                    if (c.Tag != "topui")
                    {
                        if (controlpreviousstate[listiterator])
                        {
                            c.Visible = true;
                        }
                        listiterator++;

                    }

                }
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"BG{enemylistiterator + 1}");
                mapmenu.Visible = false;

            }
            else
            {
                //saves previous loadstates
                foreach (Control c in allc)
                {
                    if (c.Tag != "topui")
                    {
                        controlpreviousstate.Add(c.Visible);
                        c.Visible = false;
                    }

                }
                this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"mapbg");
                mapmenu.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject($"mapuiat{enemylistiterator + 2}");
                mapmenu.Visible = true;
                mapmenu.Size = new Size(601, 852);
                mapmenu.BackgroundImageLayout = ImageLayout.Zoom;
                mapmenu.BringToFront();
                
            }
        }

        private void paneltest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Masterui_Paint(object sender, PaintEventArgs e)
        {

        }

        private void proceedbtn_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }


    #region Clases


    /// <summary>
    /// 
    /// necitamos usar herencia/polimorfismo en las clases, mi idea de ello era tener una clase global CartaGlobal
    /// y tener 3 otras clases, attack, skill y power, y van a heredar Carta Global, a la hora de definir una carta
    /// usamos Skill <name> = new skill ();
    /// NOTA: las clases estan basadas en las cartas que escojimos, por ejemplo se que hay cartas de ataque que buffean
    /// o cartas skill que hacen daño pero vamos a querer suicidarnos si hacemos eso asi que generalizemoslo
    /// 
    /// </summary>
    /// 

    public abstract class CartaGlobal
    {
        public string Name;
        public PictureBox Visual;
        public string ImgPath;
        public int Energia;
    }
    public class Attack: CartaGlobal
    {
        public int Damage;
        public int Block;
        bool debuff;
        Dictionary<string,int> Debuffs = new Dictionary<string, int>();
        public Attack(int eng, int Dmg, int Blk, string debuffname, int debuffstr, PictureBox pic)
        {
            
            this.Damage = Dmg;
            this.Block = Blk;
            this.debuff = true;
            Visual = pic;
            this.Energia = eng;
            if (debuff)
            {
                Debuffs.Add(debuffname, debuffstr);
            }
        }
        public Attack(int eng, int Dmg, int Blk,  PictureBox pic)
        {

            this.Damage = Dmg;
            this.Block = Blk;
            this.Energia = eng;

            Visual = pic;
        }
    }
    public class Skill: CartaGlobal
    {
        public int Block;
        bool buff;
        Dictionary<string,int> Buffs = new Dictionary<string, int>();
        public Skill(int eng, int Blk, string buffname,int buffstr, PictureBox pic)
        {
            
            this.Block = Blk;
            this.buff = true;
            Visual = pic;
            this.Energia = eng;

            if (buff)
            {
                Buffs.Add(buffname, buffstr);
            }
        }
        public Skill(int eng, int Blk, PictureBox pic)
        {

            this.Block = Blk;
            Visual = pic;
            this.Energia = eng;

        }
    }
    public class Power: CartaGlobal
    {
        Dictionary<string,int> Buffs = new Dictionary<string, int>();
        public Power(int eng, string buffname, int buffstr, PictureBox pic)
        {
            Buffs.Add(buffname, buffstr);
            Visual = pic;
            this.Energia = eng;

        }
    }




    public abstract class Interactable
    {
        public int HP;
        public int fullhealth;
        public int fullwidth;
        public bool isdead = false;
        public bool isbuffed = false;
        public bool isdebuffed = false;
        public bool isblocking = false;
        public Dictionary<string, int> debuffs = new Dictionary<string, int>();
        public Dictionary<string, int> buffs = new Dictionary<string, int>();
        public PictureBox Visual;
        public Panel VisualP;
        public int block = 0;

        public Interactable(int hp, PictureBox PicBox)
        {
            this.HP = hp;
            this.fullhealth = hp;
            this.Visual = PicBox;

        }
        public Interactable(int hp, Panel Panel)
        {
            this.HP = hp;
            this.fullhealth = hp;
            this.VisualP = Panel;
        }
        public void AddDebuff(string name, int lastingturns)
        {

            if (debuffs.ContainsKey(name.ToLower()))
            {
                debuffs[name.ToLower()] += lastingturns;
            }
            debuffs.Add(name.ToLower(), lastingturns);
            isdebuffed = true;
        }
        public void AddBuff(string name, int intensity)
        {
            
                if (this.buffs.ContainsKey(name.ToLower()))
                {
                    this.debuffs[name.ToLower()] += intensity;
                }
            

            this.buffs.Add(name.ToLower(), intensity);
            this.isbuffed = true; //hehehehe
        }
        public virtual void Takedamage(int damage, Interactable attacker) //documention: fucking read bro
        {
            fullwidth = 374;


            double damage2 = Convert.ToDouble(damage);
            
            if (this.debuffs.ContainsKey("vulnerable"))
            {
                damage2 *= 1.5;
            }
            if (attacker.debuffs.ContainsKey("weakness"))
            {
                damage2 *= .75;
            }

            
            if (attacker.buffs != null)
            {
                if (attacker.buffs.ContainsKey("strength"))
                {
                    damage2 += attacker.buffs["strength"];

                }
            }



            if (this.block <= 0)
            {
                this.HP -= Convert.ToInt32(damage2);

            }

            this.block -= Convert.ToInt32(damage2);
            if (this.block <= 0 && isblocking)
            {
                this.HP += this.block;
                isblocking = false;
                mainForm.ActiveForm.Controls.Find("blockicon", true)[0].Hide();
                mainForm.ActiveForm.Controls.Find("blocktxTHISONE", true)[0].Text = Convert.ToString(this.block);
                mainForm.ActiveForm.Controls.Find("blocktxTHISONE", true)[0].Hide();
            }
            damage2 -= this.block;
            mainForm.ActiveForm.Controls.Find("blocktxTHISONE", true)[0].Text = Convert.ToString(this.block);
            if (HP < 0)
            {
                HP = 0;
            }
            mainForm.ActiveForm.Controls.Find("hptext2", true)[0].Text = Convert.ToString(HP);
            mainForm.ActiveForm.Controls.Find("hpbarui", true)[0].Width = HP*fullwidth / fullhealth;
            if (this.HP <= 0)
            {
                isdead = true;
            }

        }

        // use this one after each turn to lower its  remaining turns/remove a debuff from the actor
        // im not 100% sure if this piece of  code actually works lmao
        public void debuffrefresh()
        {
            if (isdebuffed)
            {
                foreach (var remainingturns in debuffs.Keys)
                {
                    debuffs[remainingturns] -= 1;
                    if (debuffs[remainingturns] == 0)
                    { //especially this part here, perhaps it should be
                        debuffs.Remove(remainingturns);
                    }
                }
                if (debuffs.Count == 0)
                {
                    isdebuffed = false;
                }
            } // over here, outside of the foreach, but alas:  yolo.
        }

        public void buffincrease(string buffname)
        {
            buffname = buffname.ToLower();
            if (buffs.ContainsKey(buffname))
            {
                buffs[buffname] += 1;
            }
        }

        public virtual void addblock(int block)
        {
            this.block += block;
            mainForm.ActiveForm.Controls.Find("blockicon",true)[0].Show();
            mainForm.ActiveForm.Controls.Find("blocktxTHISONE", true)[0].Text = Convert.ToString(this.block);
            mainForm.ActiveForm.Controls.Find("blocktxTHISONE", true)[0].Show();
            isblocking = true;

        }
        public virtual void resetblock()
        {
            this.block = 0;
            mainForm.ActiveForm.Controls.Find("blockicon", true)[0].Hide();
            mainForm.ActiveForm.Controls.Find("blocktxTHISONE", true)[0].Text = Convert.ToString(this.block);
            mainForm.ActiveForm.Controls.Find("blocktxTHISONE", true)[0].Hide();
            isblocking=false;
        }

    }



    public class Player : Interactable
    {
        public int Energy;
        public int totalenergy;
        public int hp;

        public Player(int energy, int hp, PictureBox PicBox) : base(hp, PicBox)
        {
            Energy = energy;
            totalenergy = energy;
            this.hp = hp;
            Visual = PicBox;
        }
        public Player(int energy, int hp, Panel panel) : base(hp, panel)
        {
            Energy = energy;
            totalenergy = energy;
            this.hp = hp;
            VisualP = panel;
        }
        public bool canplay(int energyrequired)
        {
            if (this.Energy >= energyrequired)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public void reduceEnergy(int reducedemergy) 
        {
            this.Energy -= reducedemergy;
            mainForm.ActiveForm.Controls.Find("energytxtui", true)[0].Text = ($"{this.Energy}/{totalenergy}");
        }

        public void resetenergy()
        {
            this.Energy = totalenergy;
        }
    }

    public class Enemigo : Interactable 
    {
        public Attackpatterns attackpatterns;
        public Enemigo(int hp, Attackpatterns paterno, PictureBox PicBox) : base(hp, PicBox)
        {
            attackpatterns = paterno;
            this.HP = hp;
            Visual = PicBox;
        }

        public Enemigo(int hp, Attackpatterns paterno, Panel panel) : base(hp, panel)
        {
            attackpatterns = paterno;
            this.HP = hp;
            VisualP=panel;
        }


        public override void Takedamage(int damage, Interactable attacker) //documention: fucking read bro
        {
            fullwidth = 374;


            double damage2 = Convert.ToDouble(damage);

            if (this.debuffs.ContainsKey("vulnerable"))
            {
                damage2 *= 1.5;
            }
            if (attacker.debuffs.ContainsKey("weakness"))
            {
                damage2 *= .75;
            }
            if (attacker.buffs.ContainsKey("strength"))
            {
                damage2 += attacker.buffs["strength"];

            }

            if (this.block <= 0)
            {
                this.HP -= Convert.ToInt32(damage2);
                goto noblock;
            }

            this.block -= Convert.ToInt32(damage2);
            if (this.block <= 0)
            {
                this.HP += this.block;
                mainForm.ActiveForm.Controls.Find("enemyblock", true)[0].Hide();
                mainForm.ActiveForm.Controls.Find("enemyblocktext", true)[0].Text = Convert.ToString(this.block);
                mainForm.ActiveForm.Controls.Find("enemyblocktext", true)[0].Hide();
            }
            damage2 -= this.block;
            mainForm.ActiveForm.Controls.Find("enemyblocktext", true)[0].Text = Convert.ToString(this.block);
            noblock:
            mainForm.ActiveForm.Controls.Find("enemyhpbartext", true)[0].Text = Convert.ToString(HP);
            mainForm.ActiveForm.Controls.Find("enemyhpbartext", true)[0].Text = Convert.ToString(HP);
            mainForm.ActiveForm.Controls.Find("enemyhpnar", true)[0].Width = HP * fullwidth / fullhealth;
            mainForm.ActiveForm.Controls.Find("enemyhpnar", true)[0].Width = HP * fullwidth / fullhealth;

            if (this.HP <= 0)
            {
                isdead = true;
                mainForm.ActiveForm.Controls.Find("enemyhpbartext", true)[0].Text = "0";

            }


        }
        public override void addblock(int block)
        {
            this.block += block;
            mainForm.ActiveForm.Controls.Find("enemyblock", true)[0].Show();
            mainForm.ActiveForm.Controls.Find("enemyblocktext", true)[0].Text = Convert.ToString(this.block);
            mainForm.ActiveForm.Controls.Find("enemyblocktext", true)[0].Show();


        }
        public override void resetblock()
        {
            this.block = 0;
            mainForm.ActiveForm.Controls.Find("enemyblock", true)[0].Hide();
            mainForm.ActiveForm.Controls.Find("enemyblocktext", true)[0].Text = Convert.ToString(this.block);
            mainForm.ActiveForm.Controls.Find("enemyblocktext", true)[0].Hide();

        }

    }

    /// <summary>
    /// 
    /// antes de empezar, si, se que esto es una manera muy estupida de hacer las cosas
    /// pero si tienes alguna mejor idea dime pls
    /// 
    /// en el slay the spire original cada enemigo tiene un patron de ataque distinto, pero como  lnt que 
    /// hueva hacer eso aca, mejor hagamos patrones de ataque genericos y darle esos a los enemigos.
    /// 
    /// tambien, en el slay the spire original hay ataques con debuffo, pero como aqui mi intencion es utilizar 
    /// una lista, eso solo permite que sea Attack/block/debuff/buff y su cantidad.
    /// 
    /// si tienes alguna idea mejor avisa pl0x
    /// 
    /// </summary>


    public class Attackpatterns
    {
        public List<Dictionary<string, int>> Attackpattern = new List<Dictionary<string, int>>();


        public int atkmin;
        public int atkmax;
        public int blkmin;
        public int blkmax;
        public bool isbuffpossible;
        public int buffstr;
        public bool isdebuffpossible;
        public int debuffstr;
        public int attackpatternlength;

        //public string bias;


        Random rnd = new Random();


        public TipoBias bias;
        public enum TipoBias
        {
            Attack,
            Defense,
            Debuff,
            Buff,
            None
        }

        public Attackpatterns(int atkmin, int atkmax, int blkmin, int blkmax, bool buff, int buffstr, bool debuff, int debuffstr, TipoBias bias, int attackpatternlength)
        {
            this.atkmin = atkmin;
            this.atkmax = atkmax;
            this.blkmin = blkmin;
            this.blkmax = blkmax;
            this.isbuffpossible = buff;
            this.buffstr = buffstr;
            this.isdebuffpossible = debuff;
            this.debuffstr = debuffstr;
            this.bias = bias;
            this.attackpatternlength = attackpatternlength;
        }
        public void initializeattackpattern()
        {
            double atkselector;
            double buffselector;
            double debuffselector;
            for (int i = 0; i < attackpatternlength; i++)
            {
                Dictionary<string, int> tempdict = new Dictionary<string, int>();

                atkselector = rnd.Next(0, 9);
                buffselector = rnd.Next(0, 9);
                debuffselector = rnd.Next(0, 9);

                switch (bias)
                {
                    case TipoBias.Attack:
                        atkselector *= 0.75;
                        break;
                    case TipoBias.Defense:
                        atkselector *= 1.5;
                        break;
                    case TipoBias.Debuff:
                        buffselector *= 0.75;
                        break;
                    case TipoBias.Buff:
                        buffselector *= 1.5;
                        break;
                    case TipoBias.None:
                        break;
                }

                if (atkselector < 5.0)
                {
                    if (buffselector < 5.0 && isdebuffpossible)
                    {
                        if (debuffselector < 5.0)
                        {
                            tempdict.Add($"Weakness{i}", debuffstr);
                            Attackpattern.Add(tempdict);
                        }
                        else
                        {
                            tempdict.Add($"Vulnerable{i}", debuffstr);
                            Attackpattern.Add(tempdict);
                        }
                    }
                    else
                    {
                        tempdict.Add($"Attack{i}", rnd.Next(atkmin, atkmax));
                        Attackpattern.Add(tempdict);
                    }

                }
                if (atkselector > 5.0)
                {
                    if (buffselector > 5.0 && isbuffpossible)
                    {
                        if (debuffselector > 5.0)
                        {
                            tempdict.Add($"Strength{i}", buffstr);
                            Attackpattern.Add(tempdict);
                        }
                        else
                        {
                            tempdict.Add($"Dexterity{i}", buffstr);
                            Attackpattern.Add(tempdict);
                        }
                    }
                    else
                    {
                        tempdict.Add($"Block{i}", rnd.Next(blkmin, blkmax));
                        Attackpattern.Add(tempdict);
                    }

                }

            }

        }
    }






    /// <summary>
    /// Ejemplo de clase carta, puedes ponerla en un archivo a parte para mejor manejo.
    /// TODO: herencia y poli.
    /// </summary>
    public class Carta
    {
        public string Nombre;
        public int Danio;
        public int Bloqueo;
        public int Energia;
        public PictureBox Visual;
        public string ImgPath;

        public TipoCarta Tipo;
        public enum TipoCarta
        {
            Attack,
            Skill,
            Power,
            State
        }

        public Carta() { }
        public Carta(string nombre, int d, int b, PictureBox control)
        {
            Nombre = nombre;
            Danio = d;
            Bloqueo = b;
            Visual = control;
        }


        public void doDMG(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

    }

    public class TransparentPanel : Panel
    {
        private const int WS_EX_TRANSPARENT = 0x00000020;
        public TransparentPanel()
        {
            SetStyle(ControlStyles.Opaque, true);
        }

        private int opacity = 100;
        [DefaultValue(100)]
        public int Opacity
        {
            get
            {
                return this.opacity;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("value must be between 0 and 100");
                this.opacity = value;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(this.opacity * 255 / 100, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
    }

    /// <summary>
    /// Todas las cartas que existen para nuestro juego(Starter) sacadas del JSON.
    /// TODO: Poner daño y bloqueo en el json.
    /// </summary>
    public class Mazo
    {
        public List<Carta> cartas { get; private set; }

        public Mazo()
        {
            cartas= new List<Carta>();
            var assembly = Assembly.GetExecutingAssembly();

            string resourceName = "CardGame.Resources.Cartas.json";
            string result;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }

            //var jsonObject = JsonConvert.DeserializeObject<dynamic>(result);
            var jsonO = JObject.Parse(result);

            //for (int i = 0; i < 10; i++)
            for (int i = 0; i < (jsonO["Cartas"].Count() - 1); i++)
            {
                var info = jsonO["Cartas"][i];

                if (((string)info["Rarity"]).Equals("Starter"))
                {
                    Carta c = new Carta
                    {
                        Nombre = (string)info["Name"],
                        Energia = (int)info["Energy"],
                        ImgPath = (string)info["Img"]

                    };
                    foreach (Carta.TipoCarta tc in (Carta.TipoCarta[])Enum.GetValues(typeof(Carta.TipoCarta)))
                    {
                        if (((string)info["Type"]).Equals(tc.ToString()))
                        {
                            c.Tipo = tc;
                        }
                    }
                    /*switch (info.Value<string>("Type"))
                    {
                        case "Attack":
                            c.Tipo = Carta.TipoCarta.Attack;
                            break;
                        case "Skill":
                            c.Tipo = Carta.TipoCarta.Skill;
                            break;
                        case "Power":
                            c.Tipo = Carta.TipoCarta.Power;
                            break;
                        case "State":
                            c.Tipo = Carta.TipoCarta.State;
                            break;
                        default:
                            c.Tipo = Carta.TipoCarta.State;
                            break;
                    }*/
                    cartas.Add(c);

                    Console.WriteLine(c.Nombre +" | "+ c.Danio + " | " + c.Tipo + " | " + c.Energia + " | " + c.ImgPath);

                }
            }

        }

    }


    #endregion
}
