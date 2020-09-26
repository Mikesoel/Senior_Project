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
    public partial class NebulaeScreen : Form
    {
        public NebulaeScreen()
        {
            InitializeComponent();
        }


        private void btnNebulaeBack_Click(object sender, EventArgs e)
        {
            //bring back the previous form
            HomeScreen.Current.Show();

            //close this form
            this.Close();
        }

        private void btnSubmitNebulae_Click(object sender, EventArgs e)
        {

        }
    }
}
