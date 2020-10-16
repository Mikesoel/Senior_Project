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
    public partial class UserControlDomeLights : UserControl
    {
        public UserControlDomeLights()
        {
            InitializeComponent();
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
            String hex_color = String.Format("#{0:X2}{1:X2}{2:X2}", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            hex.Text = hex_color;
           


        }
    }
}
