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

        public UserControlGalaxies()
        {
            InitializeComponent();

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

        private void lblGalaxiesOutput_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGalaxies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblGalaxiesOutput.Text = this.comboBoxGalaxies.Text;
        }

        private void btnSubmitGalaxy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
