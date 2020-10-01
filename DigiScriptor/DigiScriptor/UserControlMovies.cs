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
    public partial class UserControlMovies : UserControl
    {
        public UserControlMovies()
        {
            InitializeComponent();
        }

        private void btnFrozenWorlds_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.comboBoxMovies.Text;
        }
    }
}
