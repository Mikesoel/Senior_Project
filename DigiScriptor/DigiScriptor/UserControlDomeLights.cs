using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DigiScriptor
{
    public partial class UserControlDomeLights : UserControl
    {
        private Boolean r_valid = false;
        private Boolean g_valid = false;
        private Boolean b_valid = false;
        private Boolean dtt_valid = false;
        private int r;
        private int g;
        private int b;
        int OGr_value = 0;
        int OGg_value = 0;
        int OGb_value = 0;
        public UserControlDomeLights()
        {
            InitializeComponent();
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
            //decimals rounded to whole numbers
            textBoxR.Text = "" + Decimal.Round((decimal)(((colorDialog1.Color.R) /255.0)*100));
            textBoxG.Text = "" + Decimal.Round((decimal)((colorDialog1.Color.G)/255.00)*100);
            textBoxB.Text = "" + Decimal.Round((decimal)((colorDialog1.Color.B) / 255.00) * 100);
            OGr_value = Convert.ToInt32(textBoxR.Text);
            OGg_value = Convert.ToInt32(textBoxG.Text);
            OGb_value = Convert.ToInt32(textBoxB.Text);
            dimmer.Value = dimmer.Minimum;

        }

        private void btnSubmitPlanet_Click(object sender, EventArgs e)
        {

            if (r_valid & g_valid & b_valid)
            {
                
                //confirmation message
                String sub = "Submit?";
                String con = "Confirm";
                DialogResult results;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //display messgae
                results = MessageBox.Show(sub, con, buttons);
                //if result is 'yes' then show submited
                if (results == DialogResult.Yes)
                {
                    String cartOutput = "Domelights Update:";
                    int dur = Convert.ToInt32(dtransTime.Text);
                    String cartCode = "\tcovelights color "+  r + " " + g + " " + b + " dur " + dur;

                    //create star item
                    ShowItem lightItem = new ShowItem("Domelights", cartOutput,cartCode);
                   

                    //add show item to list
                    HomeScreen.Current.AddItem(lightItem);


                    //update the show list after submit
                    HomeScreen.Current.UpdateList();


                   

                }
            }
        }
        //Mouse hover gives direction to the user on inputs of the manual color entry
        private void textBoxR_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter a number between 0 and 100", textBoxR);
        }

        private void textBoxG_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Enter a number between 0 and 100", textBoxR);

        }

        private void textBoxB_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Enter a number between 0 and 100", textBoxR);

        }
        private void colorEnter_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Pressing enter creates a custom color displayed in the box", textBoxR);
        }
        private void dtransTime_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Duration for lights to reach level of dimness", textBoxR);
        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {
            if (textBoxR.Text != "")
            {
                int value;
                //
                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(textBoxR.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 100)
                    {
                        //if correct keep text black
                        textBoxR.ForeColor = Color.Black;
                        //data is valid
                        r_valid = true;

                        r = (int)((((value)/100.0)*255));
                    }
                    else
                    {
                        //if invalid value then change to red text
                        textBoxR.ForeColor = Color.Red;
                        //data is invalid
                        r_valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    textBoxR.ForeColor = Color.Red;
                    //data is invalid
                    r_valid = false;
                }

            }
        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {
            if (textBoxG.Text != "")
            {
                int value;
                //
                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(textBoxG.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 100)
                    {
                        //if correct keep text black
                        textBoxG.ForeColor = Color.Black;
                        //data is valid
                        g_valid = true;
                        g = (int)((((value) / 100.0) * 255));

                    }
                    else
                    {
                        //if invalid value then change to red text
                        textBoxG.ForeColor = Color.Red;
                        //data is invalid
                        g_valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    textBoxG.ForeColor = Color.Red;
                    //data is invalid
                    g_valid = false;
                }

            }
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            if (textBoxR.Text != "")
            {
                int value;
                //
                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(textBoxB.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 100)
                    {
                        //if correct keep text black
                        textBoxB.ForeColor = Color.Black;
                        //data is valid
                        b_valid = true;
                        b = (int)((((value) / 100.0) * 255));

                    }
                    else
                    {
                        //if invalid value then change to red text
                        textBoxB.ForeColor = Color.Red;
                        //data is invalid
                        b_valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    textBoxB.ForeColor = Color.Red;
                    //data is invalid
                    b_valid = false;
                }

            }
        }

        private void colorEnter_Click(object sender, EventArgs e)
        {
            colorDialog1.CustomColors = new int[] {ColorTranslator.ToOle(Color.FromArgb(r, g, b)) };
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
            dimmer.Value = (0);
        }

        private void dimmer_Scroll(object sender, EventArgs e)
        {
            

            dimmerValue.Text = "" + dimmer.Value;
            if(dimmer.Value==0)
            {
                //textBox1.BackColor = Color.FromArgb(r_value,g_value,b_value);
                textBox1.BackColor = colorDialog1.Color;
            }
           else if(textBoxR.Text!=null & r_valid & textBoxG.Text !=null & g_valid & textBoxB.Text!=null & b_valid)
            {
               // int r_value = Convert.ToInt32(textBoxR.Text);
                //int g_value = Convert.ToInt32(textBoxG.Text);
                //int b_value = Convert.ToInt32(textBoxB.Text);

                r = OGr_value - (dimmer.Value)*(int)((OGr_value) /10.0) ;
                g = OGg_value - (dimmer.Value)*(int)((OGg_value) /10.0 );
                b = OGb_value - (dimmer.Value)*(int)((OGb_value) /10.0) ;
                
                Color myRgbColor = new Color();
                myRgbColor= Color.FromArgb(r,g,b);
                textBox1.BackColor = myRgbColor;
                textBoxR.Text=""+r;
                textBoxG.Text=""+g;
                textBoxB.Text = "" + b;

            }
            
        }

        

        private void dtransTime_TextChanged(object sender, EventArgs e)
        {

            if (dtransTime.Text != "")
            {
                int value;
                //
                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(dtransTime.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 9999)
                    {
                        //if correct keep text black
                        dtransTime.ForeColor = Color.Black;
                        //data is valid
                        dtt_valid = true;

                                            }
                    else
                    {
                        //if invalid value then change to red text
                        dtransTime.ForeColor = Color.Red;
                        //data is invalid
                        dtt_valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    dtransTime.ForeColor = Color.Red;
                    //data is invalid
                    dtt_valid = false;
                }

            }
        }

    }
}
