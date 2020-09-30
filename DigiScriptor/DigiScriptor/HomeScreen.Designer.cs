using System;
using System.Runtime.CompilerServices;

namespace DigiScriptor
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtboxCart = new System.Windows.Forms.TextBox();
            this.userControlHome = new DigiScriptor.UserControlHome();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 1024);
            this.splitter2.TabIndex = 22;
            this.splitter2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblCart);
            this.splitContainer1.Panel2.Controls.Add(this.btnSubmit);
            this.splitContainer1.Panel2.Controls.Add(this.txtboxCart);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1875, 1000);
            this.splitContainer1.SplitterDistance = 1060;
            this.splitContainer1.TabIndex = 23;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblCart.Location = new System.Drawing.Point(318, 67);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(247, 40);
            this.lblCart.TabIndex = 14;
            this.lblCart.Text = "Shopping Cart";
            this.lblCart.Click += new System.EventHandler(this.lblCart_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmit.Location = new System.Drawing.Point(340, 860);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(186, 75);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // txtboxCart
            // 
            this.txtboxCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtboxCart.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCart.Location = new System.Drawing.Point(166, 147);
            this.txtboxCart.Multiline = true;
            this.txtboxCart.Name = "txtboxCart";
            this.txtboxCart.ReadOnly = true;
            this.txtboxCart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxCart.Size = new System.Drawing.Size(551, 661);
            this.txtboxCart.TabIndex = 12;
            this.txtboxCart.Text = resources.GetString("txtboxCart.Text");
            // 
            // userControlHome
            // 
            this.userControlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControlHome.Location = new System.Drawing.Point(0, 0);
            this.userControlHome.Name = "userControlHome";
            this.userControlHome.Size = new System.Drawing.Size(1062, 994);
            this.userControlHome.TabIndex = 31;
            this.userControlHome.Load += new System.EventHandler(this.userControlHome_Load);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.userControlHome);
            this.Name = "HomeScreen";
            this.Text = "DigiScriptor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtboxCart;
        private UserControlHome userControlHome;
        private UserControlGalaxies userControlGalaxies;
        private UserControlNightSky userControlNightSky;
        private UserControlEarth userControlEarth;
        private UserControlDomeLights userControlDomeLights;
        private UserControlMoons userControlMoons;
        private UserControlPlanets userControlPlanets;
        private UserControlNebulae userControlNebulae;
        private UserControlMovies userControlMovies;
        private UserControlStars userControlStars;



        //
        // Events from UserControl Panels
        //

        //HomeScreen -> Galaxies
        public void ButtonGalaxies(object sender, EventArgs e)
        {
            userControlGalaxies = new DigiScriptor.UserControlGalaxies();
            userControlGalaxies.btnGalaxiesBack.Click += ButtonGalaxiesBack;

            this.Controls.Add(userControlGalaxies);
            userControlGalaxies.Show();
            userControlGalaxies.BringToFront();
            this.userControlHome.Hide();
        }

        //Galaxies -> HomeScreen
        public void ButtonGalaxiesBack(object sender, EventArgs e)
        {
            this.userControlGalaxies.Dispose();
            this.userControlHome.Show();
        }


        //HomeScreen -> Night Sky
        public void ButtonNightSky(object sender, EventArgs e)
        {
            userControlNightSky = new DigiScriptor.UserControlNightSky();
            userControlNightSky.btnSkyBack.Click += ButtonSkyBack;

            this.Controls.Add(userControlNightSky);
            userControlNightSky.Show();
            userControlNightSky.BringToFront();
            this.userControlHome.Hide();
        }

        //Night Sky -> HomeScreen
        public void ButtonSkyBack(object sender, EventArgs e)
        {
            this.userControlNightSky.Dispose();
            this.userControlHome.Show();
        }


        //HomeScreen -> Earth
        public void ButtonEarth(object sender, EventArgs e)
        {
            userControlEarth = new DigiScriptor.UserControlEarth();
            userControlEarth.btnEarthBack.Click += ButtonEarthBack;

            this.Controls.Add(userControlEarth);
            userControlEarth.Show();
            userControlEarth.BringToFront();
            this.userControlHome.Hide();
        }

        //Earth -> HomeScreen
        public void ButtonEarthBack(object sender, EventArgs e)
        {
            this.userControlEarth.Dispose();
            this.userControlHome.Show();
        }


        //HomeScreen -> Stars
        public void ButtonStars(object sender, EventArgs e)
        {
            userControlStars = new DigiScriptor.UserControlStars();
            userControlStars.btnStarsBack.Click += ButtonStarsBack;

            this.Controls.Add(userControlStars);
            userControlStars.Show();
            userControlStars.BringToFront();
            this.userControlHome.Hide();
        }

        //Stars -> HomeScreen
        public void ButtonStarsBack(object sender, EventArgs e)
        {
            this.userControlStars.Dispose();
            this.userControlHome.Show();
        }


        //HomeScreen -> Moons
        public void ButtonMoons(object sender, EventArgs e)
        {
            userControlMoons = new DigiScriptor.UserControlMoons();
            userControlMoons.btnMoonsBack.Click += ButtonMoonsBack;

            this.Controls.Add(userControlMoons);
            userControlMoons.Show();
            userControlMoons.BringToFront();
            this.userControlHome.Hide();
        }

        //Moons -> HomeScreen
        public void ButtonMoonsBack(object sender, EventArgs e)
        {
            this.userControlMoons.Dispose();
            this.userControlHome.Show();
        }


        //HomeScreen -> Planets
        public void ButtonPlanets(object sender, EventArgs e)
        {
            userControlPlanets = new DigiScriptor.UserControlPlanets();
            userControlPlanets.btnPlanetsBack.Click += ButtonPlanetsBack;

            this.Controls.Add(userControlPlanets);
            userControlPlanets.Show();
            userControlPlanets.BringToFront();
            this.userControlHome.Hide();
        }

        //Planets -> HomeScreen
        public void ButtonPlanetsBack(object sender, EventArgs e)
        {
            this.userControlPlanets.Dispose();
            this.userControlHome.Show();
        }


        //HomeScreen -> Nebulae
        public void ButtonNebulae(object sender, EventArgs e)
        {
            userControlNebulae = new DigiScriptor.UserControlNebulae();
            userControlNebulae.btnNebulaeBack.Click += ButtonNebulaeBack;

            this.Controls.Add(userControlNebulae);
            userControlNebulae.Show();
            userControlNebulae.BringToFront();
            this.userControlHome.Hide();
        }

        //Nebulae -> HomeScreen
        public void ButtonNebulaeBack(object sender, EventArgs e)
        {
            this.userControlNebulae.Dispose();
            this.userControlHome.Show();
        }


        //HomeScreen -> Movies
        public void ButtonMovies(object sender, EventArgs e)
        {
            userControlMovies = new DigiScriptor.UserControlMovies();
            userControlMovies.btnMoviesBack.Click += ButtonMoviesBack;

            this.Controls.Add(userControlMovies);
            userControlMovies.Show();
            userControlMovies.BringToFront();
            this.userControlHome.Hide();
        }

        //Movies -> HomeScreen
        public void ButtonMoviesBack(object sender, EventArgs e)
        {
            this.userControlMovies.Dispose();
            this.userControlHome.Show();
        }


        //HomeScreen -> DomeLights
        public void ButtonDomeLights(object sender, EventArgs e)
        {
            userControlDomeLights = new DigiScriptor.UserControlDomeLights();
            userControlDomeLights.btnDomeLightsBack.Click += ButtonDomeLightsBack;

            this.Controls.Add(userControlDomeLights);
            userControlDomeLights.Show();
            userControlDomeLights.BringToFront();
            this.userControlHome.Hide();
        }

        //DomeLights -> HomeScreen
        public void ButtonDomeLightsBack(object sender, EventArgs e)
        {
            this.userControlDomeLights.Dispose();
            this.userControlHome.Show();
        }

    }
}

