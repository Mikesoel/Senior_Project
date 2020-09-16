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
    }
}
