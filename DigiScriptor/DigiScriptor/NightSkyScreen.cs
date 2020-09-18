using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiScriptor
{
    public partial class NightSkyScreen : Form
    {
        public NightSkyScreen()
        {
            InitializeComponent();
        }

        public void btn_back_click(object sender, EventArgs e)
        {
            //show the home screeen 
            HomeScreen.Current.Show();

            //close the star screen
            this.Close();
        }
    }
}
