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
        private int r;
        private int g;
        private int b;
        public UserControlDomeLights()
        {
            InitializeComponent();
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
            textBoxR.Text = "" + ((colorDialog1.Color.R)/255)*100;
            textBoxG.Text = "" + ((colorDialog1.Color.G)/255)*100;
            textBoxB.Text = "" + ((colorDialog1.Color.B)/255)*100;
            //converts the rgb to a hex color
            String hex_color = String.Format("#{0:X2}{1:X2}{2:X2}", colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            //hex.Text = hex_color;
           


        }

        private void btnSubmitPlanet_Click(object sender, EventArgs e)
        {

            if (r_valid & g_valid & b_valid)
            {
                
                //confirmation message
                String sub = "submit?";
                String con = "Confirm";
                DialogResult results;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //display messgae
                results = MessageBox.Show(sub, con, buttons);
                //if result is 'yes' then show submited
                if (results == DialogResult.Yes)
                {
                    String cartOutput = "Domelights Update";

                    //create star item
                    ShowItem planetItem = new ShowItem("Domelights", cartOutput);

                    //add show item to list
                    HomeScreen.Current.AddItem(planetItem);


                    //update the show list after submit
                    HomeScreen.Current.UpdateList();


                    //for after submited is 'ok'
                    if (MessageBox.Show("submitted") == DialogResult.OK)
                    {
                        //do something after submitted message
                    }

                }
            }
        }
        //Mouse hover gives direction to the user on inputs of the manual color entry
        private void textBoxR_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter a number between 0 and 255", textBoxR);
        }

        private void textBoxG_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Enter a number between 0 and 255", textBoxR);

        }

        private void textBoxB_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Enter a number between 0 and 255", textBoxR);

        }
        private void colorEnter_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Pressing enter creates a custom color displayed in the box", textBoxR);
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
                    if (value >= 0 && value <= 255)
                    {
                        //if correct keep text black
                        textBoxR.ForeColor = Color.Black;
                        //data is valid
                        r_valid = true;

                        r = value;
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
                    if (value >= 0 && value <= 255)
                    {
                        //if correct keep text black
                        textBoxG.ForeColor = Color.Black;
                        //data is valid
                        g_valid = true;
                        g = value;

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
                    if (value >= 0 && value <= 255)
                    {
                        //if correct keep text black
                        textBoxB.ForeColor = Color.Black;
                        //data is valid
                        b_valid = true;
                        b = value;

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
        }

        private void dimmer_Scroll(object sender, EventArgs e)
        {
            dimmerValue.Text = "" + dimmer.Value;
            

        }
    }
}
