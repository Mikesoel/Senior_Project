using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

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
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.showPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.userControlHome = new DigiScriptor.UserControlHome();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(7, 666);
            this.splitter2.TabIndex = 22;
            this.splitter2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(10, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.showPanel);
            this.splitContainer1.Panel2.Controls.Add(this.lblCart);
            this.splitContainer1.Panel2.Controls.Add(this.btnSubmit);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1250, 650);
            this.splitContainer1.SplitterDistance = 706;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 23;
            // 
            // showPanel
            // 
            this.showPanel.AutoScroll = true;
            this.showPanel.BackColor = System.Drawing.Color.DarkGray;
            this.showPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showPanel.Location = new System.Drawing.Point(133, 109);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(310, 400);
            this.showPanel.TabIndex = 15;
            this.showPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.showPanel_Paint);
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblCart.Location = new System.Drawing.Point(212, 44);
            this.lblCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(159, 29);
            this.lblCart.TabIndex = 14;
            this.lblCart.Text = "Current Show";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmit.Location = new System.Drawing.Point(204, 545);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 49);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Generate Script";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // userControlHome
            // 
            this.userControlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControlHome.Location = new System.Drawing.Point(0, 0);
            this.userControlHome.Margin = new System.Windows.Forms.Padding(1);
            this.userControlHome.Name = "userControlHome";
            this.userControlHome.Size = new System.Drawing.Size(708, 646);
            this.userControlHome.TabIndex = 31;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1265, 666);
            this.Controls.Add(this.userControlHome);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1285, 716);
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
        // Events for moving between UserControl Panels
        //

        //HomeScreen -> Galaxies
        public void ButtonGalaxies(object sender, EventArgs e)
        {
            userControlGalaxies = new DigiScriptor.UserControlGalaxies();
            userControlGalaxies.btnGalaxiesBack.Click += ButtonGalaxiesBack;

            this.btnSubmit.Hide();
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
            this.btnSubmit.Show();
        }


        //HomeScreen -> Night Sky
        public void ButtonNightSky(object sender, EventArgs e)
        {
            userControlNightSky = new DigiScriptor.UserControlNightSky();
            userControlNightSky.btnSkyBack.Click += ButtonSkyBack;

            this.btnSubmit.Hide();
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
            this.btnSubmit.Show();
        }


        //HomeScreen -> Earth
        public void ButtonEarth(object sender, EventArgs e)
        {
            userControlEarth = new DigiScriptor.UserControlEarth();
            userControlEarth.btnEarthBack.Click += ButtonEarthBack;

            this.btnSubmit.Hide();
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
            this.btnSubmit.Show();
        }


        //HomeScreen -> Stars
        public void ButtonStars(object sender, EventArgs e)
        {
            userControlStars = new DigiScriptor.UserControlStars();
            userControlStars.btnStarsBack.Click += ButtonStarsBack;

            this.btnSubmit.Hide();
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
            this.btnSubmit.Show();
        }


        //HomeScreen -> Moons
        public void ButtonMoons(object sender, EventArgs e)
        {
            userControlMoons = new DigiScriptor.UserControlMoons();
            userControlMoons.btnMoonsBack.Click += ButtonMoonsBack;

            this.btnSubmit.Hide();
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
            this.btnSubmit.Show();
        }


        //HomeScreen -> Planets
        public void ButtonPlanets(object sender, EventArgs e)
        {
            userControlPlanets = new DigiScriptor.UserControlPlanets();
            userControlPlanets.btnPlanetsBack.Click += ButtonPlanetsBack;

            this.btnSubmit.Hide();
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
            this.btnSubmit.Show();
        }


        //HomeScreen -> Nebulae
        public void ButtonNebulae(object sender, EventArgs e)
        {
            userControlNebulae = new DigiScriptor.UserControlNebulae();
            userControlNebulae.btnNebulaeBack.Click += ButtonNebulaeBack;

            this.btnSubmit.Hide();
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
            this.btnSubmit.Show();
        }


        //HomeScreen -> Movies
        public void ButtonMovies(object sender, EventArgs e)
        {
            userControlMovies = new DigiScriptor.UserControlMovies();
            userControlMovies.btnMoviesBack.Click += ButtonMoviesBack;

            this.btnSubmit.Hide();
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
            this.btnSubmit.Show();
        }


        //HomeScreen -> DomeLights
        public void ButtonDomeLights(object sender, EventArgs e)
        {
            userControlDomeLights = new DigiScriptor.UserControlDomeLights();
            userControlDomeLights.btnDomeLightsBack.Click += ButtonDomeLightsBack;

            this.btnSubmit.Hide();
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
            this.btnSubmit.Show();
        }


        //
        // Events for writing to script file
        //

        // Galaxies Submit Output
        public void GalaxiesOutput(object sender, EventArgs e)
        {
            String outputString = null;
            String fileOutput = null;
            
            outputString = this.userControlGalaxies.lblGalaxiesOutput.Text;
            outputString = outputString.TrimEnd();

            if (!(outputString == "(Some Galaxy)"))
            {
                fileOutput = "scipt play " + outputString + ";\n";
                if (System.IO.File.Exists(filePath))
                {
                    using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(filePath, true)) //appending to file
                    {
                        // this only works for Andromeda
                        file.WriteLine(fileOutput);
                    }
                } else {
                    System.IO.File.WriteAllText(filePath, fileOutput);
                }

                // submitted pop-up
                if (MessageBox.Show("Submitted") == DialogResult.OK)
                {
                    this.userControlGalaxies.btnGalaxiesBack.PerformClick();
                }
            }
        }

        public FlowLayoutPanel showPanel;
    }
}

