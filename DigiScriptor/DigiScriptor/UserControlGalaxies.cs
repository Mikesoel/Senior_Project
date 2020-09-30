using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiScriptor
{
    public partial class UserControlGalaxies : UserControl
    {
        private HomeScreen homeScreen;
        private UserControlHome userControlHome;

        public UserControlGalaxies()
        {
            InitializeComponent();

            homeScreen = (HomeScreen)this.Parent;
            //userControlHome = homeScreen.userControlHome;
        }

        private void btnAndromeda_Click(object sender, EventArgs e)
        {

        }

        private void btnGalaxiesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            //userControlHome.Show();
        }

        private void UserControlGalaxies_Load(object sender, EventArgs e)
        {
            
        }

        private void panelGalaxies_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
