using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DigiScriptor
{
    public partial class UserControlMovies : UserControl
    {
        private static HomeScreen home;

        public UserControlMovies()
        {
            InitializeComponent();

            home = (HomeScreen)this.FindForm();
        }

        private void comboBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.comboBoxMovies.Text;
        }

        private void btnTwoSmallPieces_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnTwoSmallPieces.Text;
        }

        private void btnPharaohs_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnPharaohs.Text;
        }

        private void btnChristmasStar_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnChristmasStar.Text;
        }

        private void btnSecretsSun_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnSecretsSun.Text;
        }

        private void btnFrozenWorlds_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnFrozenWorlds.Text;
        }
    }
}
