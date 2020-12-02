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
    public partial class UserControlNightSky : UserControl
    {
        private Boolean DateSelected = false;
        private Boolean HourSelected = false;
        private Boolean MinSelected = false;
        private Boolean PeriodSelected = false;

        public UserControlNightSky()
        {
            InitializeComponent();
            //default date selection made for user, current date 
            monthCalendar1.SetDate(DateTime.Now);

        }

        //required monthCalendar
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //choose date from calendar
            DateSelected = true;
        }//end monthcalendar

        //combo box for hours
        private void comboBox_Hours_SelectedIndexChanged(object sender, EventArgs e)
        {
            //choose hour
            if (comboBox_Hours.SelectedIndex >= 0)
            {
                HourSelected = true;
            }
            else
            {
                //error msg if hours not selected
                HourSelected = false;
            }

        }//end combo box hour

        //combo box for minutes
        private void comboBox_Min_SelectedIndexChanged(object sender, EventArgs e)
        {
            //choose minutes increments of 5 min
            if (comboBox_Min.SelectedIndex >= 0)
            {
                MinSelected = true;
            }
            else
            {
                //error msg if minutes not selected
                MinSelected = false;
            }

        }//end combo box min

        //combo box for periods
        private void comboBox_Periods_SelectedIndexChanged(object sender, EventArgs e)
        {
            //choose period, AM or PM
            if (comboBox_Periods.SelectedIndex >= 0)
            {
                PeriodSelected = true;
            }
            else
            {
                //error msg if period not selected
                PeriodSelected = false;
            }

        }//end combo box period

        //submit button
        private void button_Submit_Click(object sender, EventArgs e)
        {
            //confirmation message
            String sub = "Submit?";
            String con = "Confirm";
            DialogResult results;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //if date is not selected, display error msg
            if (DateSelected == false)
            {
                MessageBox.Show("Error: Date not selected.");
            }

            //if hour not selected, display error msg
            else if (HourSelected == false)
            {
                MessageBox.Show("Error: Hours not selected.");
            }

            //if minutes not selected, display error msg
            else if (MinSelected == false)
            {
                MessageBox.Show("Error: Minutes not selected.");
            }

            //if period not selected, display error msg
            else if (PeriodSelected == false)
            {
                MessageBox.Show("Error: Period not selected.");
            }

            //no error message, successfully submitted
            else
            {


                //build selection submission output string
                sub = "Selected: \nDate: " + monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy")
                    + "\nTime: " + comboBox_Hours.SelectedItem.ToString() + ":" +
                    comboBox_Min.SelectedItem.ToString() + " " +
                    comboBox_Periods.SelectedItem.ToString() + "\n";

                //checkbox options
                //if more stars is selected
                if (checkBox_MoreStars.Checked == true)
                {
                    sub += "\nMore Stars";
                }

                //if constellation art is selected
                if (checkBox_ConstArt.Checked == true)
                {
                    sub += "\nConstellation Art";
                }

                //is constellation lines is selected
                if (checkBox_ConstLines.Checked == true)
                {
                    sub += "\nConstellation Lines";
                }

                //if label constellations are selected
                if (checkBox_LabelConst.Checked == true)
                {
                    sub += "\nLabel Constellations";
                }


                //display message
                results = MessageBox.Show(sub, con, buttons);
                //if result is 'yes' then show submitted
                if (results == DialogResult.Yes)
                {

                    //create star item
                    ShowItem nightitem = new ShowItem("Night Sky Move", sub, createCode());

                    //add show item to list
                    HomeScreen.Current.AddItem(nightitem);



                    //update the show list after submit
                    HomeScreen.Current.UpdateList();

                }
                else
                {
                    //what to do if no is selected - nothing will show in current Show box

                }
            }

        }//end submit btn


        private void checkBox_MoreStars_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_LabelConst_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_ConstArt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_ConstLines_CheckedChanged(object sender, EventArgs e)
        {

        }


        private String createCode()
        {
            String code = String.Empty;

            //if an option is made then create code based off specific option
            if (checkBox_MoreStars.Checked == true)
            {
                code += "\t";
            }

            if (checkBox_LabelConst.Checked == true)
            {
                code += "\t";
            }

            if (checkBox_ConstLines.Checked == true)
            {
                code += "\t";
            }

            if (checkBox_ConstArt.Checked == true)
            {
                code += "\t";
            }



            code += "sceneDate " + monthCalendar1.SelectionStart.ToString();

            return code;
        }


    }//end UserControlNightSky

}//end DigiScriptor

