using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace DigiScriptor
{
    public partial class UserControlStars : UserControl
    {
        private Boolean decDTxt_Valid = false;
        private Boolean decMinTxt_Valid = false;
        private Boolean decSecTxt_Valid = false;
        private Boolean rAsHrTxt_Valid = false;
        private Boolean rAsMinTxt_Valid = false;
        private Boolean rAsSecTxt_Valid = false;
        private Boolean durTxt_Valid = true;
        private Boolean distanceTxt_Valid = true;

        private Boolean selecting = false;



        private String selectedName;

        private int DecD, DecMin, DecSec;
        private int RAHr, RAMin, RASec;
        private int duration = 0;
        private Double distance = 0;

        ToolTip toolTip = new ToolTip();




        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;
        DataTable dt = new DataTable();


        public UserControlStars()
        {
            InitializeComponent();
            //set up connection
            connect = new SqlConnection(sqlPath);
            LoadComboBox();


            SetupToolTips();

        }



        public void LoadComboBox()
        {
            //clear combo box
            StarFavorites.Items.Clear();

            //open database
            connect.Open();
            //establish connection
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from StarFavorites";
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StarFavorites.Items.Add(dr["Name"].ToString().Trim());

            }
            connect.Close();

        }



        private void SubBtn_Click(object sender, EventArgs e)
        {

            //check Right Ascention is correct
            if (rAsHrTxt_Valid == false || rAsMinTxt_Valid == false || rAsSecTxt_Valid == false)
            {
                //reort error in Right ascention
                if (MessageBox.Show("Right Ascention is not correct. Please validate data.") ==
                    DialogResult.OK)
                {
                    rAsHrTxt.Select();
                }

                return;
            }

            //check that Declination is correct
            if (decDTxt_Valid == false || decMinTxt_Valid == false || decSecTxt_Valid == false)
            {
                //report an error in declination
                if (MessageBox.Show("Declination is not correct. Please validate data.") ==
                    DialogResult.OK)
                {
                    decDTxt.Select();
                }
                return;
            }

            //check if duration is correct
            if (durTxt_Valid == false)
            {
                //report an error in declination
                if (MessageBox.Show("Duration is not correct. Please validate data.") ==
                    DialogResult.OK)
                {
                    durationTxt.Select();
                }
                return;
            }


            //check if distance is correct
            if(distanceTxt_Valid == false)
            {
                if(StarFavorites.Text != "")
                {
                    //if a star is selected then ignore distance

                }//report an error in declination
                else if (MessageBox.Show("Distance is not correct. Please validate data.") ==
                    DialogResult.OK)
                {
                    distanceTxt.Select();
                    return;
                }   

            }



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
                String description = String.Empty;

                //see if star is selected
                if (selectedName != String.Empty)
                {
                    description += "Name: " + selectedName + "\n";
                }


                //create desrciption 
                description += "Right Ascention: " + RAHr + "h " + RAMin + "m " + RASec + "s \n" +
                    "Declination: " + DecD + "° " + DecMin + "\' " + DecSec + "\"";


                //see if stars are on
                Boolean starsOn = HomeScreen.Current.getIsStarsOn();

                //see if stars are needed for commands to come
                if (!starsOn)
                {
                    ShowItem turnOnStars = new ShowItem("Turn on Stars", "Turn on stars for any command using stars", "\tstars on");
                    HomeScreen.Current.AddItem(turnOnStars);

                }


                //create star item
                ShowItem Staritem = new ShowItem("Star Move", description, codeMaker());

                //add show item to list
                HomeScreen.Current.AddItem(Staritem);

                //update the show list after submit
                HomeScreen.Current.UpdateList();

            }
            else
            {
                //what to do if no is selected

            }

        }


        private void DecDTxt_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (selecting == true)
            {
                //if correct keep text black
                decDTxt.ForeColor = Color.Black;
                decDTxt_Valid = true;
                value = Convert.ToInt32(decDTxt.Text);
                DecD = value;

            }
            //check if text is empty for user input
            else if (decDTxt.Text != "")
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(decDTxt.Text);
                    //validate data is within correct range
                    if (value >= -90 && value <= 90)
                    {
                        //if correct keep text black
                        decDTxt.ForeColor = Color.Black;
                        //data is valid
                        decDTxt_Valid = true;
                        DecD = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        decDTxt.ForeColor = Color.Red;
                        //data is invalid
                        decDTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    decDTxt.ForeColor = Color.Red;
                    //data is invalid
                    decDTxt_Valid = false;
                }

            }
            else
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                decDTxt_Valid = false;
            }


        }

        private void DecMinTxt_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (selecting == true)
            {
                //if correct keep text black
                DecMinTxt.ForeColor = Color.Black;
                decMinTxt_Valid = true;
                value = Convert.ToInt32(DecMinTxt.Text);
                DecMin = value;

            }

            //check if text is empty
            else if (DecMinTxt.Text != "")
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(DecMinTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        DecMinTxt.ForeColor = Color.Black;
                        decMinTxt_Valid = true;
                        DecMin = value;
                    }
                    else
                    {
                        //if invalid value then change to red text
                        DecMinTxt.ForeColor = Color.Red;
                        decMinTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    DecMinTxt.ForeColor = Color.Red;
                    decMinTxt_Valid = false;
                }

            }
            else
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                decMinTxt_Valid = false;
            }

        }

        private void DecSecTxt_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (selecting == true)
            {
                //if correct keep text black
                DecSecTxt.ForeColor = Color.Black;
                decSecTxt_Valid = true;
                value = Convert.ToInt32(DecSecTxt.Text);
                DecSec = value;

            }
            //check if text is empty
            else if (DecSecTxt.Text != "")
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(DecSecTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        DecSecTxt.ForeColor = Color.Black;
                        decSecTxt_Valid = true;
                        DecSec = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        DecSecTxt.ForeColor = Color.Red;
                        decSecTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    DecSecTxt.ForeColor = Color.Red;
                    decSecTxt_Valid = false;
                }

            }
            else
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                decSecTxt_Valid = false;
            }





        }


        private void RAsHrTxt_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (selecting == true)
            {
                //if correct keep text black
                rAsHrTxt.ForeColor = Color.Black;
                rAsHrTxt_Valid = true;
                value = Convert.ToInt32(rAsHrTxt.Text);
                RAHr = value;

            }

            //check if text is empty
            else if (rAsHrTxt.Text != "")
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(rAsHrTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 23)
                    {
                        //if correct keep text black
                        rAsHrTxt.ForeColor = Color.Black;
                        rAsHrTxt_Valid = true;
                        RAHr = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        rAsHrTxt.ForeColor = Color.Red;
                        rAsHrTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    rAsHrTxt.ForeColor = Color.Red;
                    rAsHrTxt_Valid = false;
                }

            }
            else
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                rAsHrTxt_Valid = false;
            }

        }

        private void RAsMinTxt_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            //see if selection is updating box
            if (selecting == true)
            {
                //if correct keep text black
                RAsMinTxt.ForeColor = Color.Black;
                rAsMinTxt_Valid = true;
                value = Convert.ToInt32(RAsMinTxt.Text);
                RAMin = value;

            }


            //check if text is empty
            else if (RAsMinTxt.Text != "")
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(RAsMinTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        RAsMinTxt.ForeColor = Color.Black;
                        rAsMinTxt_Valid = true;
                        RAMin = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAsMinTxt.ForeColor = Color.Red;
                        rAsMinTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAsMinTxt.ForeColor = Color.Red;
                    rAsMinTxt_Valid = false;
                }

            }
            else
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                rAsMinTxt_Valid = false;
            }

        }

        private void RAsSecTxt_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            //see if selection is updating box
            if (selecting == true)
            {
                //if correct keep text black
                RAsSecTxt.ForeColor = Color.Black;
                rAsSecTxt_Valid = true;
                value = Convert.ToInt32(RAsSecTxt.Text);
                RASec = value;

            }


            //check if text is empty
            else if (RAsSecTxt.Text != "")
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(RAsSecTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        RAsSecTxt.ForeColor = Color.Black;
                        rAsSecTxt_Valid = true;
                        RASec = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAsSecTxt.ForeColor = Color.Red;
                        rAsSecTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAsSecTxt.ForeColor = Color.Red;
                    rAsSecTxt_Valid = false;
                }

            }
            else
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                rAsSecTxt_Valid = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DurationTxt_TextChanged(object sender, EventArgs e)
        {

            int value = 0;


            if (durationTxt.Text != "")
            {

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(durationTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 1000)
                    {
                        //if correct keep text black
                        durationTxt.ForeColor = Color.Black;
                        durTxt_Valid = true;
                        duration = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        durationTxt.ForeColor = Color.Red;
                        durTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    durationTxt.ForeColor = Color.Red;
                    durTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                durTxt_Valid = false;
            }



        }

        private void panelStars_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CoordinateBox_Enter(object sender, EventArgs e)
        {

        }

        private void distanceTxt_TextChanged(object sender, EventArgs e)
        {

            Double value = 0;


            if (distanceTxt.Text != "")
            {

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToDouble(distanceTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 100000)
                    {
                        //if correct keep text black
                        distanceTxt.ForeColor = Color.Black;
                        distanceTxt_Valid = true;
                        distance = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        distanceTxt.ForeColor = Color.Red;
                        distanceTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    distanceTxt.ForeColor = Color.Red;
                    distanceTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                distanceTxt_Valid = false;
            }















        }

        private void StarFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedName = String.Empty;

            //open database
            connect.Open();
            //establish connection
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from StarFavorites";
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            try
            {
                //build command to search for star in DB
                String select = "Name = \'" + StarFavorites.Text + "\'";

                //get row with name from DB
                DataRow[] dr = dt.Select(select);

                //update txt from selection
                selecting = true;

                //grab data from database
                rAsHrTxt.Text = dr[1][1].ToString();
                RAsMinTxt.Text = dr[1][2].ToString();
                RAsSecTxt.Text = dr[1][3].ToString();
                decDTxt.Text = dr[1][4].ToString();
                DecMinTxt.Text = dr[1][5].ToString();
                DecSecTxt.Text = dr[1][6].ToString();

            }
            catch
            {

            }

            //close data base
            connect.Close();


            //update name
            selectedName = StarFavorites.Text;

            //default selecting
            selecting = false;

        }

        private void EditFavorite_Click(object sender, EventArgs e)
        {
            //bring up menu to edit favorite stars
            EditPopularStarsPopup editData = new EditPopularStarsPopup(this);
            editData.Show();
        }


        private String codeMaker()
        {
            String code = String.Empty;

            //if a favorite is picked then code based off name
            if (selectedName != String.Empty)
            {
                //remove spaces from name for DS to underStand
                string noSpaceName = selectedName;
                noSpaceName = noSpaceName.Replace(" ", "");

                //if marker checked then inable it in code
                if (checkMark.Checked)
                {
                    code += "\tstar" + noSpaceName + "marker on\n";
                }

                //if lable check then inable it in code
                if (checkLbl.Checked)
                {
                    code += "\tstar" + noSpaceName + "label on\n";
                }


                //create code for selected star

                code += "\teye turnto star";


                //add name into code for stars
                code += noSpaceName;
                

                if(duration > 0)
                {
                    code += " dur " + duration;
                }

            }
            else
            {
                //if no favorite selected
                code += "\teye face position celestial ";

                //add RA to code
                code += RAHr + ":" + RAMin + ":" + RASec + " ";

                //add dec to code
                code += DecD + ":" + DecMin + ":" + DecSec + " ";

                //add distance to code
                code += duration + " ly ";

                //get axis
                code += "axis +z ";

                //getting duration
                code += "dur " + duration;

            }

            return code;
        }


        void SetupToolTips()
        {


            //set up toolTip
            toolTip.AutoPopDelay = 4000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;


            //set up tool tip for DurationTxt
            toolTip.SetToolTip(durationTxt, "set duration to do move over");

            //set up tool tip for checkMark
            toolTip.SetToolTip(checkMark, "enable marker for star (only works for stars with names not cordinates)");

            //set up tool tip for checkLbl
            toolTip.SetToolTip(checkLbl, "enable label for star (only works for stars with names not cordinates)");



            //set up tool tip for favorite stars
            toolTip.SetToolTip(StarFavorites, "select star from star favorite database");


            //set up tool tip for editBtn
            toolTip.SetToolTip(EditFavorite, "edit database of favorite stars");




        }
    }
}