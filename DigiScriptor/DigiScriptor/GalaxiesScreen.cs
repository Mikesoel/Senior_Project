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
    public partial class GalaxiesScreen : Form
    {
        public static GalaxiesScreen Current;
        public GalaxiesScreen()
        {
            InitializeComponent();

            //used to keep track of this form
            Current = this;
        }

        private void btnLights_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnGalaxiesBack_Click(object sender, EventArgs e)
        {
            //bring back the previous form
            HomeScreen.Current.Show();

            //close this form
            this.Close();
        }

        private void GalaxiesScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
