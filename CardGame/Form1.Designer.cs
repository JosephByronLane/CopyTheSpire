namespace CardGame
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.Anger = new System.Windows.Forms.PictureBox();
            this.topbaruiname = new System.Windows.Forms.Label();
            this.Block = new System.Windows.Forms.PictureBox();
            this.topbarUI = new System.Windows.Forms.Panel();
            this.hptextUI = new System.Windows.Forms.Label();
            this.panelheartui = new System.Windows.Forms.Panel();
            this.paneltest = new System.Windows.Forms.Panel();
            this.decknumberUI = new System.Windows.Forms.Label();
            this.floortextUI = new System.Windows.Forms.Label();
            this.topbaruiFLOOr = new System.Windows.Forms.PictureBox();
            this.topbarUImap = new System.Windows.Forms.PictureBox();
            this.moneytextUI = new System.Windows.Forms.Label();
            this.topbaruiCOG = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.topbaruititle = new System.Windows.Forms.Label();
            this.EnergyUIpanel = new System.Windows.Forms.Panel();
            this.energytxtui = new System.Windows.Forms.Label();
            this.endturnuipanel = new System.Windows.Forms.Panel();
            this.endturntxtui = new System.Windows.Forms.Label();
            this.drawpileUIpanel = new System.Windows.Forms.Panel();
            this.drawpilenumbercoverui = new System.Windows.Forms.Panel();
            this.drawpilecounttxt = new System.Windows.Forms.Label();
            this.discardpilepanell = new System.Windows.Forms.Panel();
            this.discardpilenumbercoverui = new System.Windows.Forms.Panel();
            this.discardpileuitext = new System.Windows.Forms.Label();
            this.enemyintent = new System.Windows.Forms.Panel();
            this.enemyintentatkintent = new System.Windows.Forms.Label();
            this.PlanyerP = new System.Windows.Forms.Panel();
            this.atkplayericon = new System.Windows.Forms.Panel();
            this.blockicon = new System.Windows.Forms.Panel();
            this.blocktxTHISONE = new System.Windows.Forms.Label();
            this.hptext2 = new System.Windows.Forms.Label();
            this.hpbarui = new System.Windows.Forms.Panel();
            this.Enemy1 = new System.Windows.Forms.Panel();
            this.atkiconenemy = new System.Windows.Forms.Panel();
            this.enemyblock = new System.Windows.Forms.Panel();
            this.enemyblocktext = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.enemyhpnar = new System.Windows.Forms.Panel();
            this.enemyhpbartext = new System.Windows.Forms.Label();
            this.mmplaytest = new System.Windows.Forms.Label();
            this.proceedbtn = new System.Windows.Forms.Panel();
            this.proceedbtntext = new System.Windows.Forms.Label();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.cloud3 = new System.Windows.Forms.PictureBox();
            this.mapmenu = new System.Windows.Forms.PictureBox();
            this.loadingscreen = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.endturnbanner = new CardGame.TransparentPanel();
            this.endturntxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Anger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block)).BeginInit();
            this.topbarUI.SuspendLayout();
            this.paneltest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topbaruiFLOOr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topbarUImap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topbaruiCOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.EnergyUIpanel.SuspendLayout();
            this.endturnuipanel.SuspendLayout();
            this.drawpileUIpanel.SuspendLayout();
            this.drawpilenumbercoverui.SuspendLayout();
            this.discardpilepanell.SuspendLayout();
            this.discardpilenumbercoverui.SuspendLayout();
            this.enemyintent.SuspendLayout();
            this.PlanyerP.SuspendLayout();
            this.blockicon.SuspendLayout();
            this.Enemy1.SuspendLayout();
            this.enemyblock.SuspendLayout();
            this.proceedbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            this.endturnbanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // Anger
            // 
            this.Anger.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Anger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Anger.BackgroundImage")));
            this.Anger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Anger.Location = new System.Drawing.Point(945, 705);
            this.Anger.Margin = new System.Windows.Forms.Padding(2);
            this.Anger.Name = "Anger";
            this.Anger.Size = new System.Drawing.Size(128, 160);
            this.Anger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Anger.TabIndex = 0;
            this.Anger.TabStop = false;
            this.Anger.Tag = "card";
            this.Anger.Click += new System.EventHandler(this.genericcardplayer);
            this.Anger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.Anger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.Anger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // topbaruiname
            // 
            this.topbaruiname.AutoSize = true;
            this.topbaruiname.BackColor = System.Drawing.Color.Transparent;
            this.topbaruiname.Font = new System.Drawing.Font("Kreon", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbaruiname.Location = new System.Drawing.Point(11, 10);
            this.topbaruiname.Name = "topbaruiname";
            this.topbaruiname.Size = new System.Drawing.Size(128, 46);
            this.topbaruiname.TabIndex = 2;
            this.topbaruiname.Tag = "topui";
            this.topbaruiname.Text = "Ironclad";
            this.topbaruiname.Click += new System.EventHandler(this.label1_Click);
            // 
            // Block
            // 
            this.Block.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Block.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Block.BackgroundImage")));
            this.Block.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Block.Location = new System.Drawing.Point(449, 697);
            this.Block.Margin = new System.Windows.Forms.Padding(2);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(128, 160);
            this.Block.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Block.TabIndex = 3;
            this.Block.TabStop = false;
            this.Block.Tag = "card";
            this.Block.Click += new System.EventHandler(this.genericcardplayer);
            // 
            // topbarUI
            // 
            this.topbarUI.BackColor = System.Drawing.Color.Transparent;
            this.topbarUI.BackgroundImage = global::CardGame.Properties.Resources.bar;
            this.topbarUI.Controls.Add(this.hptextUI);
            this.topbarUI.Controls.Add(this.panelheartui);
            this.topbarUI.Controls.Add(this.paneltest);
            this.topbarUI.Controls.Add(this.floortextUI);
            this.topbarUI.Controls.Add(this.topbaruiFLOOr);
            this.topbarUI.Controls.Add(this.topbarUImap);
            this.topbarUI.Controls.Add(this.moneytextUI);
            this.topbarUI.Controls.Add(this.topbaruiCOG);
            this.topbarUI.Controls.Add(this.pictureBox4);
            this.topbarUI.Controls.Add(this.topbaruititle);
            this.topbarUI.Controls.Add(this.topbaruiname);
            this.topbarUI.Location = new System.Drawing.Point(1, 0);
            this.topbarUI.Name = "topbarUI";
            this.topbarUI.Size = new System.Drawing.Size(1616, 67);
            this.topbarUI.TabIndex = 12;
            this.topbarUI.Tag = "topui";
            this.topbarUI.Paint += new System.Windows.Forms.PaintEventHandler(this.topbarUI_Paint);
            // 
            // hptextUI
            // 
            this.hptextUI.AutoSize = true;
            this.hptextUI.BackColor = System.Drawing.Color.Transparent;
            this.hptextUI.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hptextUI.ForeColor = System.Drawing.Color.IndianRed;
            this.hptextUI.Location = new System.Drawing.Point(316, 24);
            this.hptextUI.Name = "hptextUI";
            this.hptextUI.Size = new System.Drawing.Size(54, 35);
            this.hptextUI.TabIndex = 14;
            this.hptextUI.Tag = "topui";
            this.hptextUI.Text = "0/0";
            // 
            // panelheartui
            // 
            this.panelheartui.BackColor = System.Drawing.Color.Transparent;
            this.panelheartui.BackgroundImage = global::CardGame.Properties.Resources.panelHeart;
            this.panelheartui.Location = new System.Drawing.Point(264, 12);
            this.panelheartui.Name = "panelheartui";
            this.panelheartui.Size = new System.Drawing.Size(55, 57);
            this.panelheartui.TabIndex = 24;
            this.panelheartui.Tag = "topui";
            // 
            // paneltest
            // 
            this.paneltest.BackColor = System.Drawing.Color.Transparent;
            this.paneltest.BackgroundImage = global::CardGame.Properties.Resources.deck;
            this.paneltest.Controls.Add(this.decknumberUI);
            this.paneltest.Location = new System.Drawing.Point(1445, 1);
            this.paneltest.Name = "paneltest";
            this.paneltest.Size = new System.Drawing.Size(68, 65);
            this.paneltest.TabIndex = 13;
            this.paneltest.Tag = "topui";
            this.paneltest.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltest_Paint);
            // 
            // decknumberUI
            // 
            this.decknumberUI.AutoSize = true;
            this.decknumberUI.BackColor = System.Drawing.Color.Transparent;
            this.decknumberUI.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decknumberUI.ForeColor = System.Drawing.Color.White;
            this.decknumberUI.Location = new System.Drawing.Point(21, 30);
            this.decknumberUI.Name = "decknumberUI";
            this.decknumberUI.Size = new System.Drawing.Size(54, 35);
            this.decknumberUI.TabIndex = 22;
            this.decknumberUI.Tag = "topui";
            this.decknumberUI.Text = "999";
            // 
            // floortextUI
            // 
            this.floortextUI.AutoSize = true;
            this.floortextUI.BackColor = System.Drawing.Color.Transparent;
            this.floortextUI.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floortextUI.ForeColor = System.Drawing.Color.White;
            this.floortextUI.Location = new System.Drawing.Point(694, 21);
            this.floortextUI.Name = "floortextUI";
            this.floortextUI.Size = new System.Drawing.Size(23, 35);
            this.floortextUI.TabIndex = 21;
            this.floortextUI.Tag = "ui";
            this.floortextUI.Text = "1";
            // 
            // topbaruiFLOOr
            // 
            this.topbaruiFLOOr.BackColor = System.Drawing.Color.Transparent;
            this.topbaruiFLOOr.Image = global::CardGame.Properties.Resources.floor;
            this.topbaruiFLOOr.Location = new System.Drawing.Point(628, 10);
            this.topbaruiFLOOr.Name = "topbaruiFLOOr";
            this.topbaruiFLOOr.Size = new System.Drawing.Size(60, 56);
            this.topbaruiFLOOr.TabIndex = 20;
            this.topbaruiFLOOr.TabStop = false;
            this.topbaruiFLOOr.Tag = "topui";
            // 
            // topbarUImap
            // 
            this.topbarUImap.BackColor = System.Drawing.Color.Transparent;
            this.topbarUImap.Image = global::CardGame.Properties.Resources.map;
            this.topbarUImap.Location = new System.Drawing.Point(1355, 3);
            this.topbarUImap.Name = "topbarUImap";
            this.topbarUImap.Size = new System.Drawing.Size(60, 56);
            this.topbarUImap.TabIndex = 17;
            this.topbarUImap.TabStop = false;
            this.topbarUImap.Tag = "topui";
            this.topbarUImap.Click += new System.EventHandler(this.topbarUImap_Click);
            // 
            // moneytextUI
            // 
            this.moneytextUI.AutoSize = true;
            this.moneytextUI.BackColor = System.Drawing.Color.Transparent;
            this.moneytextUI.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneytextUI.ForeColor = System.Drawing.Color.Gold;
            this.moneytextUI.Location = new System.Drawing.Point(491, 21);
            this.moneytextUI.Name = "moneytextUI";
            this.moneytextUI.Size = new System.Drawing.Size(67, 35);
            this.moneytextUI.TabIndex = 16;
            this.moneytextUI.Tag = "topui";
            this.moneytextUI.Text = "9999";
            // 
            // topbaruiCOG
            // 
            this.topbaruiCOG.BackColor = System.Drawing.Color.Transparent;
            this.topbaruiCOG.Image = global::CardGame.Properties.Resources.settings;
            this.topbaruiCOG.Location = new System.Drawing.Point(1534, 3);
            this.topbaruiCOG.Name = "topbaruiCOG";
            this.topbaruiCOG.Size = new System.Drawing.Size(60, 56);
            this.topbaruiCOG.TabIndex = 18;
            this.topbaruiCOG.TabStop = false;
            this.topbaruiCOG.Tag = "topui";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::CardGame.Properties.Resources.panelGoldBag;
            this.pictureBox4.Location = new System.Drawing.Point(425, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 56);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "topui";
            // 
            // topbaruititle
            // 
            this.topbaruititle.AutoSize = true;
            this.topbaruititle.BackColor = System.Drawing.Color.Transparent;
            this.topbaruititle.Font = new System.Drawing.Font("Kreon Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbaruititle.Location = new System.Drawing.Point(145, 28);
            this.topbaruititle.Name = "topbaruititle";
            this.topbaruititle.Size = new System.Drawing.Size(86, 23);
            this.topbaruititle.TabIndex = 3;
            this.topbaruititle.Tag = "topui";
            this.topbaruititle.Text = "the Ironclad";
            this.topbaruititle.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // EnergyUIpanel
            // 
            this.EnergyUIpanel.BackColor = System.Drawing.Color.Transparent;
            this.EnergyUIpanel.BackgroundImage = global::CardGame.Properties.Resources.merged;
            this.EnergyUIpanel.Controls.Add(this.energytxtui);
            this.EnergyUIpanel.Location = new System.Drawing.Point(197, 653);
            this.EnergyUIpanel.Name = "EnergyUIpanel";
            this.EnergyUIpanel.Size = new System.Drawing.Size(121, 123);
            this.EnergyUIpanel.TabIndex = 13;
            // 
            // energytxtui
            // 
            this.energytxtui.AutoSize = true;
            this.energytxtui.BackColor = System.Drawing.Color.Transparent;
            this.energytxtui.Font = new System.Drawing.Font("Kreon", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.energytxtui.ForeColor = System.Drawing.Color.White;
            this.energytxtui.Location = new System.Drawing.Point(16, 24);
            this.energytxtui.Name = "energytxtui";
            this.energytxtui.Size = new System.Drawing.Size(102, 71);
            this.energytxtui.TabIndex = 23;
            this.energytxtui.Tag = "ui";
            this.energytxtui.Text = "3/3";
            // 
            // endturnuipanel
            // 
            this.endturnuipanel.BackColor = System.Drawing.Color.Transparent;
            this.endturnuipanel.BackgroundImage = global::CardGame.Properties.Resources.endTurnButton;
            this.endturnuipanel.Controls.Add(this.endturntxtui);
            this.endturnuipanel.Location = new System.Drawing.Point(1218, 613);
            this.endturnuipanel.Name = "endturnuipanel";
            this.endturnuipanel.Size = new System.Drawing.Size(239, 110);
            this.endturnuipanel.TabIndex = 14;
            this.endturnuipanel.Tag = "chara";
            this.endturnuipanel.Click += new System.EventHandler(this.endturntxtui_Click);
            // 
            // endturntxtui
            // 
            this.endturntxtui.AutoSize = true;
            this.endturntxtui.BackColor = System.Drawing.Color.Transparent;
            this.endturntxtui.Font = new System.Drawing.Font("Kreon", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endturntxtui.ForeColor = System.Drawing.Color.White;
            this.endturntxtui.Location = new System.Drawing.Point(61, 33);
            this.endturntxtui.Name = "endturntxtui";
            this.endturntxtui.Size = new System.Drawing.Size(144, 46);
            this.endturntxtui.TabIndex = 24;
            this.endturntxtui.Tag = "chara";
            this.endturntxtui.Text = "End Turn";
            this.endturntxtui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endturntxtui.Click += new System.EventHandler(this.endturntxtui_Click);
            // 
            // drawpileUIpanel
            // 
            this.drawpileUIpanel.BackColor = System.Drawing.Color.Transparent;
            this.drawpileUIpanel.BackgroundImage = global::CardGame.Properties.Resources._base;
            this.drawpileUIpanel.Controls.Add(this.drawpilenumbercoverui);
            this.drawpileUIpanel.Location = new System.Drawing.Point(19, 750);
            this.drawpileUIpanel.Name = "drawpileUIpanel";
            this.drawpileUIpanel.Size = new System.Drawing.Size(126, 126);
            this.drawpileUIpanel.TabIndex = 23;
            // 
            // drawpilenumbercoverui
            // 
            this.drawpilenumbercoverui.BackColor = System.Drawing.Color.Transparent;
            this.drawpilenumbercoverui.BackgroundImage = global::CardGame.Properties.Resources.countCircle;
            this.drawpilenumbercoverui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drawpilenumbercoverui.Controls.Add(this.drawpilecounttxt);
            this.drawpilenumbercoverui.Location = new System.Drawing.Point(34, 30);
            this.drawpilenumbercoverui.Name = "drawpilenumbercoverui";
            this.drawpilenumbercoverui.Size = new System.Drawing.Size(136, 123);
            this.drawpilenumbercoverui.TabIndex = 24;
            this.drawpilenumbercoverui.Tag = "ui";
            // 
            // drawpilecounttxt
            // 
            this.drawpilecounttxt.AutoSize = true;
            this.drawpilecounttxt.BackColor = System.Drawing.Color.Transparent;
            this.drawpilecounttxt.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawpilecounttxt.ForeColor = System.Drawing.Color.White;
            this.drawpilecounttxt.Location = new System.Drawing.Point(48, 42);
            this.drawpilecounttxt.Name = "drawpilecounttxt";
            this.drawpilecounttxt.Size = new System.Drawing.Size(41, 35);
            this.drawpilecounttxt.TabIndex = 23;
            this.drawpilecounttxt.Tag = "ui";
            this.drawpilecounttxt.Text = "99";
            // 
            // discardpilepanell
            // 
            this.discardpilepanell.BackColor = System.Drawing.Color.Transparent;
            this.discardpilepanell.BackgroundImage = global::CardGame.Properties.Resources.base1;
            this.discardpilepanell.Controls.Add(this.discardpilenumbercoverui);
            this.discardpilepanell.Location = new System.Drawing.Point(1490, 757);
            this.discardpilepanell.Name = "discardpilepanell";
            this.discardpilepanell.Size = new System.Drawing.Size(116, 119);
            this.discardpilepanell.TabIndex = 23;
            // 
            // discardpilenumbercoverui
            // 
            this.discardpilenumbercoverui.BackColor = System.Drawing.Color.Transparent;
            this.discardpilenumbercoverui.BackgroundImage = global::CardGame.Properties.Resources.countCircle__1_;
            this.discardpilenumbercoverui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.discardpilenumbercoverui.Controls.Add(this.discardpileuitext);
            this.discardpilenumbercoverui.Location = new System.Drawing.Point(0, 27);
            this.discardpilenumbercoverui.Name = "discardpilenumbercoverui";
            this.discardpilenumbercoverui.Size = new System.Drawing.Size(87, 86);
            this.discardpilenumbercoverui.TabIndex = 24;
            this.discardpilenumbercoverui.Tag = "ui";
            // 
            // discardpileuitext
            // 
            this.discardpileuitext.AutoSize = true;
            this.discardpileuitext.BackColor = System.Drawing.Color.Transparent;
            this.discardpileuitext.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardpileuitext.ForeColor = System.Drawing.Color.White;
            this.discardpileuitext.Location = new System.Drawing.Point(8, 46);
            this.discardpileuitext.Name = "discardpileuitext";
            this.discardpileuitext.Size = new System.Drawing.Size(41, 35);
            this.discardpileuitext.TabIndex = 23;
            this.discardpileuitext.Tag = "ui";
            this.discardpileuitext.Text = "99";
            // 
            // enemyintent
            // 
            this.enemyintent.BackColor = System.Drawing.Color.Transparent;
            this.enemyintent.BackgroundImage = global::CardGame.Properties.Resources.attack_intent_7;
            this.enemyintent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.enemyintent.Controls.Add(this.enemyintentatkintent);
            this.enemyintent.Location = new System.Drawing.Point(960, 237);
            this.enemyintent.Name = "enemyintent";
            this.enemyintent.Size = new System.Drawing.Size(139, 110);
            this.enemyintent.TabIndex = 24;
            // 
            // enemyintentatkintent
            // 
            this.enemyintentatkintent.AutoSize = true;
            this.enemyintentatkintent.BackColor = System.Drawing.Color.Transparent;
            this.enemyintentatkintent.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyintentatkintent.ForeColor = System.Drawing.Color.White;
            this.enemyintentatkintent.Location = new System.Drawing.Point(45, 68);
            this.enemyintentatkintent.Name = "enemyintentatkintent";
            this.enemyintentatkintent.Size = new System.Drawing.Size(41, 35);
            this.enemyintentatkintent.TabIndex = 25;
            this.enemyintentatkintent.Tag = "ui";
            this.enemyintentatkintent.Text = "99";
            // 
            // PlanyerP
            // 
            this.PlanyerP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlanyerP.BackColor = System.Drawing.Color.Transparent;
            this.PlanyerP.BackgroundImage = global::CardGame.Properties.Resources.pj;
            this.PlanyerP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlanyerP.Controls.Add(this.atkplayericon);
            this.PlanyerP.Controls.Add(this.blockicon);
            this.PlanyerP.Location = new System.Drawing.Point(296, 370);
            this.PlanyerP.Name = "PlanyerP";
            this.PlanyerP.Size = new System.Drawing.Size(380, 260);
            this.PlanyerP.TabIndex = 25;
            this.PlanyerP.Tag = "chara";
            this.PlanyerP.Click += new System.EventHandler(this.Player_Click);
            this.PlanyerP.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // atkplayericon
            // 
            this.atkplayericon.BackColor = System.Drawing.Color.Transparent;
            this.atkplayericon.BackgroundImage = global::CardGame.Properties.Resources.slash_1;
            this.atkplayericon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.atkplayericon.Location = new System.Drawing.Point(81, 17);
            this.atkplayericon.Name = "atkplayericon";
            this.atkplayericon.Size = new System.Drawing.Size(268, 215);
            this.atkplayericon.TabIndex = 36;
            this.atkplayericon.Tag = "nores";
            this.atkplayericon.Visible = false;
            // 
            // blockicon
            // 
            this.blockicon.BackColor = System.Drawing.Color.Transparent;
            this.blockicon.BackgroundImage = global::CardGame.Properties.Resources.block;
            this.blockicon.Controls.Add(this.blocktxTHISONE);
            this.blockicon.Location = new System.Drawing.Point(30, 178);
            this.blockicon.Name = "blockicon";
            this.blockicon.Size = new System.Drawing.Size(63, 66);
            this.blockicon.TabIndex = 27;
            this.blockicon.Tag = "nores";
            this.blockicon.Visible = false;
            // 
            // blocktxTHISONE
            // 
            this.blocktxTHISONE.AutoSize = true;
            this.blocktxTHISONE.BackColor = System.Drawing.Color.Transparent;
            this.blocktxTHISONE.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocktxTHISONE.ForeColor = System.Drawing.Color.Black;
            this.blocktxTHISONE.Location = new System.Drawing.Point(22, 16);
            this.blocktxTHISONE.Name = "blocktxTHISONE";
            this.blocktxTHISONE.Size = new System.Drawing.Size(23, 35);
            this.blocktxTHISONE.TabIndex = 25;
            this.blocktxTHISONE.Tag = "ui";
            this.blocktxTHISONE.Text = "1";
            this.blocktxTHISONE.Visible = false;
            // 
            // hptext2
            // 
            this.hptext2.AutoSize = true;
            this.hptext2.BackColor = System.Drawing.Color.Transparent;
            this.hptext2.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hptext2.ForeColor = System.Drawing.Color.White;
            this.hptext2.Location = new System.Drawing.Point(499, 659);
            this.hptext2.Name = "hptext2";
            this.hptext2.Size = new System.Drawing.Size(23, 35);
            this.hptext2.TabIndex = 25;
            this.hptext2.Tag = "ui";
            this.hptext2.Text = "1";
            // 
            // hpbarui
            // 
            this.hpbarui.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hpbarui.BackColor = System.Drawing.Color.Transparent;
            this.hpbarui.BackgroundImage = global::CardGame.Properties.Resources.healthbar;
            this.hpbarui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hpbarui.Location = new System.Drawing.Point(302, 636);
            this.hpbarui.Name = "hpbarui";
            this.hpbarui.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hpbarui.Size = new System.Drawing.Size(374, 24);
            this.hpbarui.TabIndex = 27;
            this.hpbarui.Tag = "ui";
            // 
            // Enemy1
            // 
            this.Enemy1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1.BackgroundImage = global::CardGame.Properties.Resources.Enemy1;
            this.Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Enemy1.Controls.Add(this.atkiconenemy);
            this.Enemy1.Controls.Add(this.enemyblock);
            this.Enemy1.Location = new System.Drawing.Point(845, 343);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(380, 274);
            this.Enemy1.TabIndex = 26;
            this.Enemy1.Tag = "chara";
            // 
            // atkiconenemy
            // 
            this.atkiconenemy.BackColor = System.Drawing.Color.Transparent;
            this.atkiconenemy.BackgroundImage = global::CardGame.Properties.Resources.slash_1;
            this.atkiconenemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.atkiconenemy.Location = new System.Drawing.Point(62, 56);
            this.atkiconenemy.Name = "atkiconenemy";
            this.atkiconenemy.Size = new System.Drawing.Size(268, 215);
            this.atkiconenemy.TabIndex = 35;
            this.atkiconenemy.Tag = "nores";
            this.atkiconenemy.Visible = false;
            // 
            // enemyblock
            // 
            this.enemyblock.BackColor = System.Drawing.Color.Transparent;
            this.enemyblock.BackgroundImage = global::CardGame.Properties.Resources.block;
            this.enemyblock.Controls.Add(this.enemyblocktext);
            this.enemyblock.Location = new System.Drawing.Point(314, 208);
            this.enemyblock.Name = "enemyblock";
            this.enemyblock.Size = new System.Drawing.Size(63, 66);
            this.enemyblock.TabIndex = 28;
            this.enemyblock.Tag = "nores";
            this.enemyblock.Visible = false;
            // 
            // enemyblocktext
            // 
            this.enemyblocktext.AutoSize = true;
            this.enemyblocktext.BackColor = System.Drawing.Color.Transparent;
            this.enemyblocktext.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyblocktext.ForeColor = System.Drawing.Color.Black;
            this.enemyblocktext.Location = new System.Drawing.Point(22, 16);
            this.enemyblocktext.Name = "enemyblocktext";
            this.enemyblocktext.Size = new System.Drawing.Size(23, 35);
            this.enemyblocktext.TabIndex = 25;
            this.enemyblocktext.Tag = "ui";
            this.enemyblocktext.Text = "1";
            this.enemyblocktext.Visible = false;
            // 
            // enemyhpnar
            // 
            this.enemyhpnar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enemyhpnar.BackColor = System.Drawing.Color.Transparent;
            this.enemyhpnar.BackgroundImage = global::CardGame.Properties.Resources.healthbar;
            this.enemyhpnar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemyhpnar.Location = new System.Drawing.Point(851, 636);
            this.enemyhpnar.Name = "enemyhpnar";
            this.enemyhpnar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enemyhpnar.Size = new System.Drawing.Size(374, 24);
            this.enemyhpnar.TabIndex = 28;
            this.enemyhpnar.Tag = "ui";
            // 
            // enemyhpbartext
            // 
            this.enemyhpbartext.AutoSize = true;
            this.enemyhpbartext.BackColor = System.Drawing.Color.Transparent;
            this.enemyhpbartext.Font = new System.Drawing.Font("Kreon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyhpbartext.ForeColor = System.Drawing.Color.White;
            this.enemyhpbartext.Location = new System.Drawing.Point(1026, 659);
            this.enemyhpbartext.Name = "enemyhpbartext";
            this.enemyhpbartext.Size = new System.Drawing.Size(23, 35);
            this.enemyhpbartext.TabIndex = 28;
            this.enemyhpbartext.Tag = "ui";
            this.enemyhpbartext.Text = "1";
            // 
            // mmplaytest
            // 
            this.mmplaytest.AutoSize = true;
            this.mmplaytest.BackColor = System.Drawing.Color.Transparent;
            this.mmplaytest.Font = new System.Drawing.Font("Kreon", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmplaytest.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mmplaytest.Location = new System.Drawing.Point(91, 602);
            this.mmplaytest.Name = "mmplaytest";
            this.mmplaytest.Size = new System.Drawing.Size(95, 58);
            this.mmplaytest.TabIndex = 29;
            this.mmplaytest.Tag = "mm";
            this.mmplaytest.Text = "Play";
            this.mmplaytest.Visible = false;
            this.mmplaytest.Click += new System.EventHandler(this.mmplaytest_Click);
            this.mmplaytest.MouseLeave += new System.EventHandler(this.mmplaytest_MouseLeave);
            this.mmplaytest.MouseHover += new System.EventHandler(this.mmplaytest_MouseHover);
            // 
            // proceedbtn
            // 
            this.proceedbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.proceedbtn.BackColor = System.Drawing.Color.Transparent;
            this.proceedbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("proceedbtn.BackgroundImage")));
            this.proceedbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.proceedbtn.Controls.Add(this.proceedbtntext);
            this.proceedbtn.Location = new System.Drawing.Point(1279, 450);
            this.proceedbtn.Name = "proceedbtn";
            this.proceedbtn.Size = new System.Drawing.Size(298, 167);
            this.proceedbtn.TabIndex = 30;
            this.proceedbtn.Tag = "nn";
            this.proceedbtn.Visible = false;
            this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
            this.proceedbtn.Paint += new System.Windows.Forms.PaintEventHandler(this.proceedbtn_Paint_1);
            // 
            // proceedbtntext
            // 
            this.proceedbtntext.AutoSize = true;
            this.proceedbtntext.Font = new System.Drawing.Font("Kreon", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedbtntext.Location = new System.Drawing.Point(99, 62);
            this.proceedbtntext.Name = "proceedbtntext";
            this.proceedbtntext.Size = new System.Drawing.Size(124, 46);
            this.proceedbtntext.TabIndex = 0;
            this.proceedbtntext.Tag = "nn";
            this.proceedbtntext.Text = "Proceed";
            this.proceedbtntext.Click += new System.EventHandler(this.proceedbtn_Click);
            // 
            // cloud1
            // 
            this.cloud1.BackColor = System.Drawing.Color.Transparent;
            this.cloud1.BackgroundImage = global::CardGame.Properties.Resources.cloud1;
            this.cloud1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cloud1.Location = new System.Drawing.Point(1032, 61);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(502, 284);
            this.cloud1.TabIndex = 31;
            this.cloud1.TabStop = false;
            this.cloud1.Tag = "mm";
            this.cloud1.Visible = false;
            // 
            // cloud3
            // 
            this.cloud3.BackColor = System.Drawing.Color.Transparent;
            this.cloud3.BackgroundImage = global::CardGame.Properties.Resources.cloud3;
            this.cloud3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cloud3.Location = new System.Drawing.Point(1104, 729);
            this.cloud3.Name = "cloud3";
            this.cloud3.Size = new System.Drawing.Size(368, 156);
            this.cloud3.TabIndex = 33;
            this.cloud3.TabStop = false;
            this.cloud3.Tag = "mm";
            this.cloud3.Visible = false;
            // 
            // mapmenu
            // 
            this.mapmenu.BackColor = System.Drawing.Color.Transparent;
            this.mapmenu.BackgroundImage = global::CardGame.Properties.Resources.mapuiat5;
            this.mapmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mapmenu.Location = new System.Drawing.Point(533, 76);
            this.mapmenu.Name = "mapmenu";
            this.mapmenu.Size = new System.Drawing.Size(112, 59);
            this.mapmenu.TabIndex = 36;
            this.mapmenu.TabStop = false;
            this.mapmenu.Tag = "map";
            this.mapmenu.Visible = false;
            // 
            // loadingscreen
            // 
            this.loadingscreen.Location = new System.Drawing.Point(701, 97);
            this.loadingscreen.Name = "loadingscreen";
            this.loadingscreen.Size = new System.Drawing.Size(53, 30);
            this.loadingscreen.TabIndex = 34;
            this.loadingscreen.TabStop = false;
            this.loadingscreen.Tag = "mm";
            this.loadingscreen.Visible = false;
            // 
            // cloud2
            // 
            this.cloud2.BackColor = System.Drawing.Color.Transparent;
            this.cloud2.BackgroundImage = global::CardGame.Properties.Resources.cloud2;
            this.cloud2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cloud2.Location = new System.Drawing.Point(53, 76);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(502, 284);
            this.cloud2.TabIndex = 32;
            this.cloud2.TabStop = false;
            this.cloud2.Tag = "mm";
            this.cloud2.Visible = false;
            // 
            // endturnbanner
            // 
            this.endturnbanner.Controls.Add(this.endturntxt);
            this.endturnbanner.Location = new System.Drawing.Point(8, 361);
            this.endturnbanner.Name = "endturnbanner";
            this.endturnbanner.Opacity = 75;
            this.endturnbanner.Size = new System.Drawing.Size(1616, 123);
            this.endturnbanner.TabIndex = 35;
            this.endturnbanner.Tag = "nn";
            this.endturnbanner.Visible = false;
            // 
            // endturntxt
            // 
            this.endturntxt.AutoSize = true;
            this.endturntxt.BackColor = System.Drawing.Color.Transparent;
            this.endturntxt.Font = new System.Drawing.Font("Kreon", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endturntxt.Location = new System.Drawing.Point(612, 9);
            this.endturntxt.Name = "endturntxt";
            this.endturntxt.Size = new System.Drawing.Size(364, 94);
            this.endturntxt.TabIndex = 0;
            this.endturntxt.Tag = "nn";
            this.endturntxt.Text = "Enemy Turn";
            this.endturntxt.Visible = false;
            this.endturntxt.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BackgroundImage = global::CardGame.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1611, 900);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.loadingscreen);
            this.Controls.Add(this.mapmenu);
            this.Controls.Add(this.endturnbanner);
            this.Controls.Add(this.cloud3);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.mmplaytest);
            this.Controls.Add(this.hptext2);
            this.Controls.Add(this.proceedbtn);
            this.Controls.Add(this.hpbarui);
            this.Controls.Add(this.enemyhpbartext);
            this.Controls.Add(this.enemyhpnar);
            this.Controls.Add(this.enemyintent);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.PlanyerP);
            this.Controls.Add(this.discardpilepanell);
            this.Controls.Add(this.drawpileUIpanel);
            this.Controls.Add(this.endturnuipanel);
            this.Controls.Add(this.EnergyUIpanel);
            this.Controls.Add(this.topbarUI);
            this.Controls.Add(this.Block);
            this.Controls.Add(this.Anger);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy the Spire";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Anger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block)).EndInit();
            this.topbarUI.ResumeLayout(false);
            this.topbarUI.PerformLayout();
            this.paneltest.ResumeLayout(false);
            this.paneltest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topbaruiFLOOr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topbarUImap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topbaruiCOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.EnergyUIpanel.ResumeLayout(false);
            this.EnergyUIpanel.PerformLayout();
            this.endturnuipanel.ResumeLayout(false);
            this.endturnuipanel.PerformLayout();
            this.drawpileUIpanel.ResumeLayout(false);
            this.drawpilenumbercoverui.ResumeLayout(false);
            this.drawpilenumbercoverui.PerformLayout();
            this.discardpilepanell.ResumeLayout(false);
            this.discardpilenumbercoverui.ResumeLayout(false);
            this.discardpilenumbercoverui.PerformLayout();
            this.enemyintent.ResumeLayout(false);
            this.enemyintent.PerformLayout();
            this.PlanyerP.ResumeLayout(false);
            this.blockicon.ResumeLayout(false);
            this.blockicon.PerformLayout();
            this.Enemy1.ResumeLayout(false);
            this.enemyblock.ResumeLayout(false);
            this.enemyblock.PerformLayout();
            this.proceedbtn.ResumeLayout(false);
            this.proceedbtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            this.endturnbanner.ResumeLayout(false);
            this.endturnbanner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Anger;
        private System.Windows.Forms.Label topbaruiname;
        private System.Windows.Forms.PictureBox Block;
        private System.Windows.Forms.Panel topbarUI;
        private System.Windows.Forms.Label topbaruititle;
        private System.Windows.Forms.Label hptextUI;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label moneytextUI;
        private System.Windows.Forms.PictureBox topbarUImap;
        private System.Windows.Forms.PictureBox topbaruiCOG;
        private System.Windows.Forms.PictureBox topbaruiFLOOr;
        private System.Windows.Forms.Panel paneltest;
        private System.Windows.Forms.Label decknumberUI;
        private System.Windows.Forms.Label floortextUI;
        private System.Windows.Forms.Panel EnergyUIpanel;
        private System.Windows.Forms.Panel endturnuipanel;
        private System.Windows.Forms.Label energytxtui;
        private System.Windows.Forms.Label endturntxtui;
        private System.Windows.Forms.Panel drawpileUIpanel;
        private System.Windows.Forms.Panel discardpilepanell;
        private System.Windows.Forms.Panel drawpilenumbercoverui;
        private System.Windows.Forms.Panel discardpilenumbercoverui;
        private System.Windows.Forms.Label drawpilecounttxt;
        private System.Windows.Forms.Label discardpileuitext;
        private System.Windows.Forms.Panel panelheartui;
        public System.Windows.Forms.Panel enemyintent;
        private System.Windows.Forms.Label enemyintentatkintent;
        private System.Windows.Forms.Panel PlanyerP;
        private System.Windows.Forms.Panel Enemy1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label hptext2;
        public System.Windows.Forms.Panel blockicon;
        private System.Windows.Forms.Label blocktxt;
        private System.Windows.Forms.Label blocktxTHISONE;
        public System.Windows.Forms.Panel hpbarui;
        public System.Windows.Forms.Panel enemyhpnar;
        private System.Windows.Forms.Label enemyhpbartext;
        public System.Windows.Forms.Panel enemyblock;
        private System.Windows.Forms.Label enemyblocktext;
        private System.Windows.Forms.Label mmplaytest;
        private System.Windows.Forms.Panel proceedbtn;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud3;
        private System.Windows.Forms.Label proceedbtntext;
        private System.Windows.Forms.Panel atkiconenemy;
        private System.Windows.Forms.Panel atkplayericon;
        private TransparentPanel endturnbanner;
        private System.Windows.Forms.Label endturntxt;
        private System.Windows.Forms.PictureBox mapmenu;
        private System.Windows.Forms.PictureBox loadingscreen;
        private System.Windows.Forms.PictureBox cloud2;
    }
}

