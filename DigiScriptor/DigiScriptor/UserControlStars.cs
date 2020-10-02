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
    public partial class UserControlStars : UserControl
    {
        private Boolean DecDTxt_Valid = true;
        private Boolean DecMinTxt_Valid = true;
        private Boolean DecSecTxt_Valid = true;
        private Boolean RAsHrTxt_Valid = true;
        private Boolean RAsMinTxt_Valid = true;
        private Boolean RAsSecTxt_Valid = true;





        public UserControlStars()
        {
            InitializeComponent();
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Submitted") == DialogResult.OK)
            {
                btnStarsBack.PerformClick();
            }

            


        }


        private void DecDTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if(DecDTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(DecDTxt.Text);
                    //validate data is within correct range
                    if (value >= -90 && value <= 90)
                    {   
                        //if correct keep text black
                        DecDTxt.ForeColor = Color.Black;
                        //data is valid
                        DecDTxt_Valid = true;
                    }
                    else
                    {
                        //if invalid value then change to red text
                        DecDTxt.ForeColor = Color.Red;
                        //data is invalid
                        DecDTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    DecDTxt.ForeColor = Color.Red;
                    //data is invalid
                    DecDTxt_Valid = false;
                }
                
            }
            else
            {
                //no data input
                DecDTxt_Valid = false;
            }
            

        }

        private void DecMinTxt_TextChanged(object sender, EventArgs e)
        {
           
            //check if text is empty
            if (DecMinTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(DecMinTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        DecMinTxt.ForeColor = Color.Black;
                        DecMinTxt_Valid = true;
                    }
                    else
                    {
                        //if invalid value then change to red text
                        DecMinTxt.ForeColor = Color.Red;
                        DecMinTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    DecMinTxt.ForeColor = Color.Red;
                    DecMinTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                DecMinTxt_Valid = false;
            }

        }

        private void DecSecTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (DecSecTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(DecSecTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        DecSecTxt.ForeColor = Color.Black;
                        DecSecTxt_Valid = true;


                    }
                    else
                    {
                        //if invalid value then change to red text
                        DecSecTxt.ForeColor = Color.Red;
                        DecSecTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    DecSecTxt.ForeColor = Color.Red;
                    DecSecTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                DecSecTxt_Valid = false;
            }

        }


        private void RAsHrTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (RAsHrTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(RAsHrTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 23)
                    {
                        //if correct keep text black
                        RAsHrTxt.ForeColor = Color.Black;
                        RAsHrTxt_Valid = true;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAsHrTxt.ForeColor = Color.Red;
                        RAsHrTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAsHrTxt.ForeColor = Color.Red;
                    RAsHrTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                RAsHrTxt_Valid = false;
            }

        }

        private void RAsMinTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (RAsMinTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(RAsMinTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        RAsMinTxt.ForeColor = Color.Black;
                        RAsMinTxt_Valid = true;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAsMinTxt.ForeColor = Color.Red;
                        RAsMinTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAsMinTxt.ForeColor = Color.Red;
                    RAsMinTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                RAsMinTxt_Valid = false;
            }

        }

        private void RAsSecTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (RAsSecTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(RAsSecTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        RAsSecTxt.ForeColor = Color.Black;
                        RAsSecTxt_Valid = true;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAsSecTxt.ForeColor = Color.Red;
                        RAsSecTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAsSecTxt.ForeColor = Color.Red;
                    RAsSecTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                RAsSecTxt_Valid = false;
            }

        }

        private void labelStars_Click(object sender, EventArgs e)
        {

        }
    }
}
