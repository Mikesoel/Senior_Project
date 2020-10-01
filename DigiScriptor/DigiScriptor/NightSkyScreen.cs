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
    public partial class NightSkyScreen : Form { 
private void label_Time_Click(object sender, EventArgs e)
    {

    }
        public NightSkyScreen()
        {
            InitializeComponent();
        }

    private void btn_back_Click(object sender, EventArgs e)
    {
        //back button goes back to Home Screen
        HomeScreen.Current.Show();

        //close Night Sky form
        this.Close();
    }

        private void comboBox_Min_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NightSkyScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
