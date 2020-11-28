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
        private Boolean DecDTxt_Valid = false;
        private Boolean DecMinTxt_Valid = false;
        private Boolean DecSecTxt_Valid = false;
        private Boolean RAsHrTxt_Valid = false;
        private Boolean RAsMinTxt_Valid = false;
        private Boolean RAsSecTxt_Valid = false;
        private Boolean durTxt_Valid = true;

        private Boolean selecting = false;



        private String selectedName;

        private int DecD,DecMin,DecSec;
        private int RAHr, RAMin, RASec;
        private int duration = 0;


        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;
        DataTable dt = new DataTable();


        public UserControlStars()
        {
            InitializeComponent();
            //set up connection
            connect = new SqlConnection(sqlPath);
            LoadComboBox();
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
            if(RAsHrTxt_Valid == false|| RAsMinTxt_Valid == false || RAsSecTxt_Valid == false)
            {
                //reort error in Right ascention
                if (MessageBox.Show("Right Ascention is not correct. Please validate data.") ==
                    DialogResult.OK)
                {
                    RAsHrTxt.Select();
                }

                return;
            }

            //check that Declination is correct
            if(DecDTxt_Valid== false|| DecMinTxt_Valid == false || DecSecTxt_Valid == false)
            {   
                //report an error in declination
                if(MessageBox.Show("Declination is not correct. Please validate data.") ==
                    DialogResult.OK)
                {
                    DecDTxt.Select();
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
                    DurationTxt.Select();
                }
                return;
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
                if(selectedName != String.Empty)
                {
                    description += "Name: " + selectedName + "\n";
                }


                //create desrciption 
                description += "Right Ascention: " + RAHr + "h " + RAMin + "m " + RASec + "s \n"+
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
                DecDTxt.ForeColor = Color.Black;
                DecDTxt_Valid = true;
                value = Convert.ToInt32(DecDTxt.Text);
                DecD = value;

            }
            //check if text is empty for user input
            else if(DecDTxt.Text != "")
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

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
                        DecD = value;

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
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                DecDTxt_Valid = false;
            }
            

        }

        private void DecMinTxt_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (selecting == true)
            {
                //if correct keep text black
                DecMinTxt.ForeColor = Color.Black;
                DecMinTxt_Valid = true;
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
                        DecMinTxt_Valid = true;
                        DecMin = value;
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
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                DecMinTxt_Valid = false;
            }

        }

        private void DecSecTxt_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (selecting == true)
            {
                //if correct keep text black
                DecSecTxt.ForeColor = Color.Black;
                DecSecTxt_Valid = true;
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
                        DecSecTxt_Valid = true;
                        DecSec = value;

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
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                DecSecTxt_Valid = false;
            }





        }


        private void RAsHrTxt_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (selecting == true)
            {
                //if correct keep text black
                RAsHrTxt.ForeColor = Color.Black;
                RAsHrTxt_Valid = true;
                value = Convert.ToInt32(RAsHrTxt.Text);
                RAHr = value;

            }

            //check if text is empty
            else if (RAsHrTxt.Text != "")
            {
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

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
                        RAHr = value;

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
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                RAsHrTxt_Valid = false;
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
                RAsMinTxt_Valid = true;
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
                        RAsMinTxt_Valid = true;
                        RAMin = value;

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
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                RAsMinTxt_Valid = false;
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
                RAsSecTxt_Valid = true;
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
                        RAsSecTxt_Valid = true;
                        RASec = value;

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
                //clear selected if user types in box
                StarFavorites.SelectedItem = null;
                selectedName = String.Empty;

                //no data input
                RAsSecTxt_Valid = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DurationTxt_TextChanged(object sender, EventArgs e)
        {

            int value = 0;


            if (DurationTxt.Text != "")
            {

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(DurationTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 1000)
                    {
                        //if correct keep text black
                        DurationTxt.ForeColor = Color.Black;
                        durTxt_Valid = true;
                        duration = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        DurationTxt.ForeColor = Color.Red;
                        durTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    DurationTxt.ForeColor = Color.Red;
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

            try {
                //build command to search for star in DB
                String select = "Name = \'" + StarFavorites.Text + "\'";

                //get row with name from DB
                DataRow[] dr = dt.Select(select);

                //update txt from selection
                selecting = true;

                //grab data from database
                RAsHrTxt.Text = dr[1][1].ToString();
                RAsMinTxt.Text = dr[1][2].ToString();
                RAsSecTxt.Text = dr[1][3].ToString();
                DecDTxt.Text = dr[1][4].ToString();
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
            if(selectedName != String.Empty)
            {
                //create code for selected star

                code += "\teye turnTo star";

                //remove spaces from name for DS to underStand
                string noSpaceName = selectedName;
                noSpaceName = noSpaceName.Replace(" ", "");

                //add name into code for stars
                code += noSpaceName;

            }
            else
            {




            }

            return code;
        }

    }
}
