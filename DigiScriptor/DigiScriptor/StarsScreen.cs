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
    public partial class StarsScreen : Form
    {
        public StarsScreen()
        {
            InitializeComponent();
        }

        private void StarsScreen_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //bring back the previous form
            HomeScreen.Current.Show();

            //close this form
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 90)
            {
                Submit.Enabled = true;
            }
            else
            {
                Submit.Enabled=false;
            }
        }

        private void Right_Ascention_txt_TextChanged(object sender, EventArgs e)
        {
            if(Right_Ascention_txt.Text != "")
            {
                progressBar1.Increment(30);
            }
            else
            {
                progressBar1.Increment(-30);
            }
        }

        private void declination_txt_TextChanged(object sender, EventArgs e)
        {
            if (declination_txt.Text != "")
            {
                progressBar1.Increment(30);
            }
            else
            {
                progressBar1.Increment(-30);
            }
        }

        private void hr_angle_txt_TextChanged(object sender, EventArgs e)
        {
            if (hr_angle_txt.Text != "")
            {
                progressBar1.Increment(30);
            }
            else
            {
                progressBar1.Increment(-30);
            }

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
