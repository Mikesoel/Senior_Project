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
    public partial class DelayPopup : Form
    {
        private int currentDelay = 0;

        public DelayPopup()
        {
            InitializeComponent();
        }

        public DelayPopup(String Title, int time)
        {
            InitializeComponent();

            //set title for window
            this.Text = Title + " Delay";

            //get current delay
            currentDelay = time;
            DelayBox.Text = time.ToString();

        }


        public int returnDelay
        {
            get { return currentDelay; }
            set { currentDelay = value; }

        }






        private void DelayPopup_Load(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //if cancel button hit then close window and dont change delay
            this.DialogResult = DialogResult.Cancel;


            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            //if OK button hit then update delay and close window
            this.DialogResult = DialogResult.OK;
            try
            {
                

            }
            catch
            {

            }

            
            this.Close();
        }

        private void delayBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
