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
    public partial class UserControlPlanets : UserControl
    {
        private Boolean textBoxVantage_Valid = false;
        private Boolean textBoxOrbit_Valid = false;
        private Boolean textBoxRot_Valid = false;
        public UserControlPlanets()
        {
            InitializeComponent();
        }

        private void textBoxOrbit_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Enter desired speed you wish to orbit", textBoxOrbit);
        }

        private void textBoxRotation_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Enter desired speed you wish to rotate", textBoxRotation);
        }

        private void planetDropdown_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Enter the distance you wish to view planet",textBoxVantage);
        }

        private void btnSubmitPlanet_MouseHover(object sender, EventArgs e)
        {
            toolTip4.Show("Submit to shopping cart", btnSubmitPlanet);
        }
        private void cmbBoxDist_MouseHover(object sender, EventArgs e)
        {
            toolTip5.Show("Choose unit of distance", cmbBoxDist);
        }

        private void textBoxVantage_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (textBoxVantage.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(textBoxVantage.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 99999)
                    {
                        //if correct keep text black
                        textBoxVantage.ForeColor = Color.Black;
                        //data is valid
                        textBoxVantage_Valid = true;
                    }
                    else
                    {
                        //if invalid value then change to red text
                        textBoxVantage.ForeColor = Color.Red;
                        //data is invalid
                        textBoxVantage_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    textBoxVantage.ForeColor = Color.Red;
                    //data is invalid
                    textBoxVantage_Valid = false;
                }

            }
            else
            {
                //no data input
                textBoxVantage_Valid = false;
            }

        }

        private void textBoxOrbit_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (textBoxOrbit.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(textBoxOrbit.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 99999)
                    {
                        //if correct keep text black
                        textBoxOrbit.ForeColor = Color.Black;
                        //data is valid
                        textBoxOrbit_Valid = true;
                    }
                    else
                    {
                        //if invalid value then change to red text
                        textBoxOrbit.ForeColor = Color.Red;
                        //data is invalid
                        textBoxOrbit_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    textBoxOrbit.ForeColor = Color.Red;
                    //data is invalid
                    textBoxOrbit_Valid = false;
                }

            }
            else
            {
                //no data input
                textBoxOrbit_Valid = false;
            }
        }

        private void textBoxRotation_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (textBoxRotation.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(textBoxRotation.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 99999)
                    {
                        //if correct keep text black
                        textBoxRotation.ForeColor = Color.Black;
                        //data is valid
                        textBoxRot_Valid = true;
                    }
                    else
                    {
                        //if invalid value then change to red text
                        textBoxRotation.ForeColor = Color.Red;
                        //data is invalid
                        textBoxRot_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    textBoxRotation.ForeColor = Color.Red;
                    //data is invalid
                    textBoxRot_Valid = false;
                }

            }
            else
            {
                //no data input
                textBoxRot_Valid = false;
            }
        }

        private void planetDropdown_TextChanged(object sender, EventArgs e)
        {
            if (planetDropdown.Text == "mars")
            {
                
            }
        }

        
    }
}
