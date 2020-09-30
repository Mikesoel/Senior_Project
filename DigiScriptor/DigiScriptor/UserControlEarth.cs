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
    public partial class UserControlEarth : UserControl
    {
        public UserControlEarth()
        {
            InitializeComponent();
        }

        private void popularLocationsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (popularLocationsCombo.Text == "Add New")
            {
                MessageBox.Show("Hey");
            }
        }
    }
}
