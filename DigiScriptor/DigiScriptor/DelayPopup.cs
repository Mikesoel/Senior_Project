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
        Boolean validValue = true;
        int value = 0;
        ShowItem item;

        public DelayPopup()
        {
            InitializeComponent();
        }

        public DelayPopup(String Title, int time, ShowItem item)
        {
            InitializeComponent();

            //set title for window
            this.Text = Title + " Delay";

            //get current delay
            currentDelay = time;
            DelayBox.Text = time.ToString();

            //get ShowItem
            this.item = item;
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
                if (validValue)
                {
                    //update button to show time delay
                    item.updateDelayBtn("+" + value.ToString());
                    item.Delay = value;
                }
                else
                {
                    //pop up for trying to input invalid time
                    MessageBox.Show("invalid time");
                    return;
                }

            }
            catch
            {

            }

            
            this.Close();
        }

        private void delayBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //try to convert to int value
                value = Convert.ToInt32(DelayBox.Text);

                if (value >= 0)
                {
                    //valid value
                    DelayBox.ForeColor = Color.Black;
                    validValue = true;
                }
                else
                {
                    //not valid value
                    DelayBox.ForeColor = Color.Red;
                    validValue = false;
                }


            }
            catch
            {
                //error on data entered
                DelayBox.ForeColor = Color.Red;
                validValue = false;
            }
        }
    }
}
