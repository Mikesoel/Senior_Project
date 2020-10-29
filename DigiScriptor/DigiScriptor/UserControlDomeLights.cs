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

        private void btnSubmitPlanet_Click(object sender, EventArgs e)
        {

            if (hex.Text != null)
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

    }
}
