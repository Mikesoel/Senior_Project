using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace DigiScriptor
{
    public partial class HomeScreen : Form
    {
        public static HomeScreen Current;
        public String dir;
        public String fileName;
        public String filePath;

        public HomeScreen()
        {
            InitializeComponent();

            //used to keep track of this form
            Current = this;
            dir = Directory.GetCurrentDirectory();
            fileName = "script.txt";
            filePath = dir + "\\" + fileName;
            Console.WriteLine(filePath);

            // Events for moving to different screens
            this.userControlHome.btnGalaxies.Click += ButtonGalaxies;
            this.userControlHome.btnSky.Click += ButtonNightSky;
            this.userControlHome.btnEarth.Click += ButtonEarth;
            this.userControlHome.btnStars.Click += ButtonStars;
            this.userControlHome.btnMoons.Click += ButtonMoons;
            this.userControlHome.btnPlanets.Click += ButtonPlanets;
            this.userControlHome.btnNebulae.Click += ButtonNebulae;
            this.userControlHome.btnMovies.Click += ButtonMovies;
            this.userControlHome.btnLights.Click += ButtonDomeLights;

        }



        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            userControlHome.Show();
            userControlHome.BringToFront();

            
        }

        private void lblDigi_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLights_Click_1(object sender, EventArgs e)
        {

        }

<<<<<<<<< Temporary merge branch 1
        private void btnNebulae_Click(object sender, EventArgs e)
=========
        private void btnEarth_Click_1(object sender, EventArgs e)
        {
            //close home screen
            //this.Hide();

            //open earth screen
            //EarthScreen earScreen = new EarthScreen();
            //earScreen.Show();
            
        }

        private void btnNebulae_Click_1(object sender, EventArgs e)
>>>>>>>>> Temporary merge branch 2
        {
            //hiding the home screen
            this.Hide();

            //opening up the galaxies screen
            NebulaeScreen nebScreen = new NebulaeScreen();
            nebScreen.Show();
        }
<<<<<<<<< Temporary merge branch 1
=========

        private void btnSky_Click_1(object sender, EventArgs e)
        {
            //hide the home screen
            this.Hide();

            //open night sky screen
            NightSkyScreen skyScreen = new NightSkyScreen();
            skyScreen.Show();
        }

        private void btnStars_Click_1(object sender, EventArgs e)
        {
            //hiding the home screen
            this.Hide();


            // open stars screen
            StarsScreen starScreen = new StarsScreen();
            starScreen.Show();
        }

        private void lblCart_Click(object sender, EventArgs e)
        {

        }

        private void panelDomeLights_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNebulae_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMoons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Submitted") == DialogResult.OK)
            {
                //do some stuff
            }
        }
    }
}
