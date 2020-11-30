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
    public partial class UserControlPlanets : UserControl
    {
        private Boolean textBoxVantage_Valid = false;
        private Boolean textBoxOrbit_Valid = false;
        private Boolean textBoxRot_Valid = false;
        private Boolean RotationAxis_selected = false;
        private Boolean planet_selected = false;
        private Boolean rs_unit_selected = false;
        private Boolean os_unit_selected = false;
        private Boolean vp_unit_selected = false;


        public UserControlPlanets()
        {
            InitializeComponent();
        }

       //Mouse Hover implementation to provide more details to the user
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
            toolTip5.Show("Choose unit of distance", vp_units);
        }

        private void textBoxVantage_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (textBoxVantage.Text != "")
            {
                int value;

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
            //check that a planet has been selected by the planet dropdown menu
            planet_selected = true;
        }
        private void axisDropdown_TextChanged(object sender, EventArgs e)
        {
            //check that the rotation axis has been selected from the rotaion dropdowwn
            RotationAxis_selected = true;
        }

        private void vp_units_TextChanged(object sender, EventArgs e)
        {
           //check if the user chose a unit for the vantage point
            vp_unit_selected = true;
        }
        private void os_units_TextChanged(object sender, EventArgs e)
        {
            //check if the user chose a unit for the orbit speed
            os_unit_selected = true;
        }

        private void rs_units_TextChanged(object sender, EventArgs e)
        {
            //check if the user chose a unit for the rotation speed
            rs_unit_selected = true;
        }


        private Boolean ValidPlanetEntry()
        {
         //checks if all inputs have been completed and are valid
            if (textBoxRot_Valid & textBoxOrbit_Valid & textBoxVantage_Valid & planet_selected & RotationAxis_selected & vp_unit_selected & os_unit_selected & rs_unit_selected)
            {
                return true;
            }else   return false;
        }
        private void btnSubmitPlanet_Click(object sender, EventArgs e)
        {
            
            if (ValidPlanetEntry())
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
                   // String cartOutput = "planet action added";
                                 
                    //update the show list after submit
                    HomeScreen.Current.UpdateList();

                    Boolean isNavigationOn = HomeScreen.Current.GetIsNavOn();

                    //if navigation has not been turned on yet, turn it on to
                    //flyTo galaxy
                    if (!isNavigationOn)
                    {
                        ShowItem naviItem = new ShowItem("Navigation On", "turn navigation on for flyTo commands", "navigation on;");
                        HomeScreen.Current.AddItem(naviItem);
                    }

                    String cartDescription = "*planet* action added";
                    String cartCode = "<insert ds code clip for planet here >";

                    //create star item
                    ShowItem planetItem = new ShowItem("Planet Move", cartDescription, cartCode);
                    

                    //add show item to list
                    HomeScreen.Current.AddItem(planetItem);


                    //update the show list after submit
                    HomeScreen.Current.UpdateList();


                    //NO CONFIRMATIONS NEEDED
                    /*/for after submited is 'ok'
                    if (MessageBox.Show("Submitted") == DialogResult.OK)
                    {
                        //do something after submitted message
                    }
                    */

                }
            }
        }

        
    }
}
