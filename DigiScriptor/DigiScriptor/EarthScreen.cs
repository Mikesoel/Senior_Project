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
    public partial class EarthScreen : Form
    {
        public EarthScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEarthCustomLocation_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void latitudeRadio2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void northRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void eastRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void westRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEarthBack_Click(object sender, EventArgs e)
        {
            //bring back the previous form
            HomeScreen.Current.Show();

            //close this form
            this.Close();
        }

        private void EarthScreen_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxVantagePoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboVantagePoint_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void popularLocationsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
