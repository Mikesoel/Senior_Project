using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiScriptor
{
    public partial class HomeScreen : Form
    {
        public static HomeScreen Current;
        public HomeScreen()
        {
            InitializeComponent();

            //used to keep track of this form
            Current = this;
        }

        private void btnLights_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEarth_Click(object sender, EventArgs e)
        {
            //close home screen
            this.Hide();

            //open earth screen
            EarthScreen earScreen = new EarthScreen();
            earScreen.Show();
        }

        private void btnSky_Click(object sender, EventArgs e)
        {

        }

        private void btnGalaxies_Click(object sender, EventArgs e)
        {
            //hiding the home screen
            this.Hide();

            //opening up the galaxies screen
            GalaxiesScreen galScreen = new GalaxiesScreen();
            galScreen.Show();
        }

        private void btnStars_Click(object sender, EventArgs e)
        {
            //hiding the home screen
            this.Hide();


            // open stars screen
            StarsScreen starScreen = new StarsScreen();
            starScreen.Show();

        }



        private void btnNebulae_Click(object sender, EventArgs e)
        {
            //hiding the home screen
            this.Hide();

            //opening up the galaxies screen
            NebulaeScreen nebScreen = new NebulaeScreen();
            nebScreen.Show();
        }
    }
}
