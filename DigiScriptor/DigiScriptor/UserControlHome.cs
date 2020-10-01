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
    public partial class UserControlHome : UserControl
    {
        private HomeScreen homeScreen;
        private UserControlGalaxies userControlGalaxy;
        public UserControlHome()
        {
            InitializeComponent();

            homeScreen = (HomeScreen)this.FindForm();
            //userControlGalaxy = homeScreen.userControlGalaxies;
        }

        public void btnGalaxies_Click(object sender, EventArgs e)
        {
            
        }

        private void panelHomeScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNebulae_Click(object sender, EventArgs e)
        {

        }
    }
}
