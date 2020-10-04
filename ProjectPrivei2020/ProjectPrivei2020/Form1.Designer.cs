namespace ProjectPrivei2020
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.cardthreatlevel = new Bunifu.Framework.UI.BunifuCards();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvl2button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.level1button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.level3button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeholder = new Bunifu.Framework.UI.BunifuCards();
            this.closesafearea = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSensors = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblsensor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cardthreatlevel.SuspendLayout();
            this.closeholder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(241, 36);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(969, 618);
            this.map.TabIndex = 4;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // cardthreatlevel
            // 
            this.cardthreatlevel.BackColor = System.Drawing.Color.Black;
            this.cardthreatlevel.BorderRadius = 5;
            this.cardthreatlevel.BottomSahddow = true;
            this.cardthreatlevel.color = System.Drawing.Color.Navy;
            this.cardthreatlevel.Controls.Add(this.label3);
            this.cardthreatlevel.Controls.Add(this.label2);
            this.cardthreatlevel.Controls.Add(this.lvl2button);
            this.cardthreatlevel.Controls.Add(this.level1button);
            this.cardthreatlevel.Controls.Add(this.label1);
            this.cardthreatlevel.Controls.Add(this.level3button);
            this.cardthreatlevel.LeftSahddow = false;
            this.cardthreatlevel.Location = new System.Drawing.Point(617, 583);
            this.cardthreatlevel.Name = "cardthreatlevel";
            this.cardthreatlevel.RightSahddow = true;
            this.cardthreatlevel.ShadowDepth = 20;
            this.cardthreatlevel.Size = new System.Drawing.Size(232, 65);
            this.cardthreatlevel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(168, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Level 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Level 2";
            // 
            // lvl2button
            // 
            this.lvl2button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.lvl2button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lvl2button.BorderRadius = 0;
            this.lvl2button.ButtonText = "";
            this.lvl2button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvl2button.DisabledColor = System.Drawing.Color.Gray;
            this.lvl2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl2button.Iconcolor = System.Drawing.Color.Transparent;
            this.lvl2button.Iconimage = ((System.Drawing.Image)(resources.GetObject("lvl2button.Iconimage")));
            this.lvl2button.Iconimage_right = null;
            this.lvl2button.Iconimage_right_Selected = null;
            this.lvl2button.Iconimage_Selected = null;
            this.lvl2button.IconMarginLeft = 0;
            this.lvl2button.IconMarginRight = 0;
            this.lvl2button.IconRightVisible = true;
            this.lvl2button.IconRightZoom = 0D;
            this.lvl2button.IconVisible = true;
            this.lvl2button.IconZoom = 90D;
            this.lvl2button.IsTab = false;
            this.lvl2button.Location = new System.Drawing.Point(102, 9);
            this.lvl2button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvl2button.Name = "lvl2button";
            this.lvl2button.Normalcolor = System.Drawing.Color.Empty;
            this.lvl2button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.lvl2button.OnHoverTextColor = System.Drawing.Color.White;
            this.lvl2button.selected = false;
            this.lvl2button.Size = new System.Drawing.Size(32, 30);
            this.lvl2button.TabIndex = 6;
            this.lvl2button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lvl2button.Textcolor = System.Drawing.Color.White;
            this.lvl2button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl2button.Click += new System.EventHandler(this.lvl2button_Click);
            // 
            // level1button
            // 
            this.level1button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.level1button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.level1button.BorderRadius = 0;
            this.level1button.ButtonText = "";
            this.level1button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level1button.DisabledColor = System.Drawing.Color.Gray;
            this.level1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1button.Iconcolor = System.Drawing.Color.Transparent;
            this.level1button.Iconimage = ((System.Drawing.Image)(resources.GetObject("level1button.Iconimage")));
            this.level1button.Iconimage_right = null;
            this.level1button.Iconimage_right_Selected = null;
            this.level1button.Iconimage_Selected = null;
            this.level1button.IconMarginLeft = 0;
            this.level1button.IconMarginRight = 0;
            this.level1button.IconRightVisible = true;
            this.level1button.IconRightZoom = 0D;
            this.level1button.IconVisible = true;
            this.level1button.IconZoom = 90D;
            this.level1button.IsTab = false;
            this.level1button.Location = new System.Drawing.Point(21, 9);
            this.level1button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.level1button.Name = "level1button";
            this.level1button.Normalcolor = System.Drawing.Color.Empty;
            this.level1button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.level1button.OnHoverTextColor = System.Drawing.Color.White;
            this.level1button.selected = false;
            this.level1button.Size = new System.Drawing.Size(32, 30);
            this.level1button.TabIndex = 5;
            this.level1button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.level1button.Textcolor = System.Drawing.Color.White;
            this.level1button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1button.Click += new System.EventHandler(this.level1button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Level 1";
            // 
            // level3button
            // 
            this.level3button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.level3button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.level3button.BorderRadius = 0;
            this.level3button.ButtonText = "";
            this.level3button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level3button.DisabledColor = System.Drawing.Color.Gray;
            this.level3button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level3button.Iconcolor = System.Drawing.Color.Transparent;
            this.level3button.Iconimage = ((System.Drawing.Image)(resources.GetObject("level3button.Iconimage")));
            this.level3button.Iconimage_right = null;
            this.level3button.Iconimage_right_Selected = null;
            this.level3button.Iconimage_Selected = null;
            this.level3button.IconMarginLeft = 0;
            this.level3button.IconMarginRight = 0;
            this.level3button.IconRightVisible = true;
            this.level3button.IconRightZoom = 0D;
            this.level3button.IconVisible = true;
            this.level3button.IconZoom = 90D;
            this.level3button.IsTab = false;
            this.level3button.Location = new System.Drawing.Point(181, 9);
            this.level3button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.level3button.Name = "level3button";
            this.level3button.Normalcolor = System.Drawing.Color.Empty;
            this.level3button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.level3button.OnHoverTextColor = System.Drawing.Color.White;
            this.level3button.selected = false;
            this.level3button.Size = new System.Drawing.Size(32, 30);
            this.level3button.TabIndex = 3;
            this.level3button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.level3button.Textcolor = System.Drawing.Color.White;
            this.level3button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level3button.Click += new System.EventHandler(this.level3button_Click);
            // 
            // closeholder
            // 
            this.closeholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.closeholder.BorderRadius = 5;
            this.closeholder.BottomSahddow = true;
            this.closeholder.color = System.Drawing.Color.Red;
            this.closeholder.Controls.Add(this.closesafearea);
            this.closeholder.LeftSahddow = false;
            this.closeholder.Location = new System.Drawing.Point(1144, 42);
            this.closeholder.Name = "closeholder";
            this.closeholder.RightSahddow = true;
            this.closeholder.ShadowDepth = 20;
            this.closeholder.Size = new System.Drawing.Size(54, 47);
            this.closeholder.TabIndex = 10;
            // 
            // closesafearea
            // 
            this.closesafearea.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.closesafearea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closesafearea.BorderRadius = 0;
            this.closesafearea.ButtonText = "";
            this.closesafearea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closesafearea.DisabledColor = System.Drawing.Color.Gray;
            this.closesafearea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closesafearea.Iconcolor = System.Drawing.Color.Transparent;
            this.closesafearea.Iconimage = ((System.Drawing.Image)(resources.GetObject("closesafearea.Iconimage")));
            this.closesafearea.Iconimage_right = null;
            this.closesafearea.Iconimage_right_Selected = null;
            this.closesafearea.Iconimage_Selected = null;
            this.closesafearea.IconMarginLeft = 0;
            this.closesafearea.IconMarginRight = 0;
            this.closesafearea.IconRightVisible = true;
            this.closesafearea.IconRightZoom = 0D;
            this.closesafearea.IconVisible = true;
            this.closesafearea.IconZoom = 90D;
            this.closesafearea.IsTab = false;
            this.closesafearea.Location = new System.Drawing.Point(11, 11);
            this.closesafearea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closesafearea.Name = "closesafearea";
            this.closesafearea.Normalcolor = System.Drawing.Color.Empty;
            this.closesafearea.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.closesafearea.OnHoverTextColor = System.Drawing.Color.White;
            this.closesafearea.selected = false;
            this.closesafearea.Size = new System.Drawing.Size(32, 30);
            this.closesafearea.TabIndex = 9;
            this.closesafearea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closesafearea.Textcolor = System.Drawing.Color.White;
            this.closesafearea.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closesafearea.Click += new System.EventHandler(this.closesafearea_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ProjectPrivei2020.Properties.Resources._76264142_dark_blue_and_black_gradient_texture_background_abstract_surface_material;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(241, 654);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 29);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = global::ProjectPrivei2020.Properties.Resources.Sea_From_Sky_Earthview_Art_Nature_iphone_4s_wallpaper_ilikewallpaper_com;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAddSensors);
            this.panel1.Controls.Add(this.bunifuFlatButton3);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 647);
            this.panel1.TabIndex = 1;
            // 
            // btnAddSensors
            // 
            this.btnAddSensors.Activecolor = System.Drawing.Color.Transparent;
            this.btnAddSensors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddSensors.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSensors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSensors.BorderRadius = 0;
            this.btnAddSensors.ButtonText = "ADD LOCATIONS";
            this.btnAddSensors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSensors.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddSensors.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddSensors.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddSensors.Iconimage")));
            this.btnAddSensors.Iconimage_right = null;
            this.btnAddSensors.Iconimage_right_Selected = null;
            this.btnAddSensors.Iconimage_Selected = null;
            this.btnAddSensors.IconMarginLeft = 0;
            this.btnAddSensors.IconMarginRight = 0;
            this.btnAddSensors.IconRightVisible = true;
            this.btnAddSensors.IconRightZoom = 0D;
            this.btnAddSensors.IconVisible = true;
            this.btnAddSensors.IconZoom = 90D;
            this.btnAddSensors.IsTab = false;
            this.btnAddSensors.Location = new System.Drawing.Point(3, 545);
            this.btnAddSensors.Name = "btnAddSensors";
            this.btnAddSensors.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddSensors.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddSensors.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddSensors.selected = false;
            this.btnAddSensors.Size = new System.Drawing.Size(235, 48);
            this.btnAddSensors.TabIndex = 3;
            this.btnAddSensors.Text = "ADD LOCATIONS";
            this.btnAddSensors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSensors.Textcolor = System.Drawing.Color.White;
            this.btnAddSensors.TextFont = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSensors.Click += new System.EventHandler(this.btnAddSensors_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "SAFE LOCATIONS";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(3, 491);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(235, 48);
            this.bunifuFlatButton3.TabIndex = 2;
            this.bunifuFlatButton3.Text = "SAFE LOCATIONS";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuFlatButton2.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "AFFECTED AREAS";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(3, 437);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(232, 48);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "AFFECTED AREAS";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "EMERGENCY DASHBOARD";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 390);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(235, 51);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "EMERGENCY DASHBOARD";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ProjectPrivei2020.Properties.Resources._76264142_dark_blue_and_black_gradient_texture_background_abstract_surface_material;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lblsensor);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1210, 36);
            this.panel2.TabIndex = 2;
            // 
            // lblsensor
            // 
            this.lblsensor.AutoSize = true;
            this.lblsensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsensor.Location = new System.Drawing.Point(152, 7);
            this.lblsensor.Name = "lblsensor";
            this.lblsensor.Size = new System.Drawing.Size(32, 24);
            this.lblsensor.TabIndex = 1;
            this.lblsensor.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sensor Value";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(83, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1210, 683);
            this.Controls.Add(this.closeholder);
            this.Controls.Add(this.cardthreatlevel);
            this.Controls.Add(this.map);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cardthreatlevel.ResumeLayout(false);
            this.cardthreatlevel.PerformLayout();
            this.closeholder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private GMap.NET.WindowsForms.GMapControl map;
        private Bunifu.Framework.UI.BunifuCards cardthreatlevel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton level3button;
        private Bunifu.Framework.UI.BunifuFlatButton level1button;
        private Bunifu.Framework.UI.BunifuFlatButton lvl2button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCards closeholder;
        private Bunifu.Framework.UI.BunifuFlatButton closesafearea;
        private System.Windows.Forms.Label lblsensor;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddSensors;
        private System.Windows.Forms.Button button1;
    }
}

