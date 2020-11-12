using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DigiScriptor
{
    public partial class UserControlEarth : UserControl
    {
        //SqlConnection setup string
        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;

        //Variables
        double latitude, longitude = 0;
        private Boolean Latitude_Valid = false;
        private Boolean Longitude_Valid = false;
        string landLatitude, landLongitude;

        public UserControlEarth()
        {
            InitializeComponent();

            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //load database into the combo box
            LoadComboBox();
        }

        public void LoadComboBox()
        {
            //Clear combo box from old items
            popularLocationsCombo.Items.Clear();

            //Open DB connection
            connect.Open();

            //Bind cmd to create SQL commands
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //SQL command to load names into combo box
            cmd.CommandText = "select Name from EarthScreenFavorites";
            cmd.ExecuteNonQuery();

            //Populate combo box with names
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                popularLocationsCombo.Items.Add(dr["Name"].ToString().Trim());
            }
            
            //Close connection to DB
            connect.Close();
        }

        private void popularLocationsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void popularLocationsCombo_Click(object sender, EventArgs e)
        {
            //Now load combo box from editpopularearthpopup to let auto suggest work properly
            
            //Reload combo box every time it is clicked, assures data within is always accurate
            
            //LoadComboBox();
        }


        private void editPopularLocationsButton_Click(object sender, EventArgs e)
        {
            //Open edit popular earth locations popup window
            EditPopularEarthLocationsPopup editData = new EditPopularEarthLocationsPopup(this);
            editData.Show();

        }

        private void btnSubmitEarth_Click(object sender, EventArgs e)
        {
            String outputLbl = popularLocationsCombo.Text;
            if (!(String.IsNullOrEmpty(outputLbl)))
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
                    Boolean isNavigationOn = HomeScreen.Current.GetIsNavOn();

                    //if navigation has not been turned on yet, turn it on to
                    //flyTo galaxy
                    if (!isNavigationOn)
                    {
                        ShowItem naviItem = new ShowItem("Navigation On", "turn navigation on for flyTo commands", "navigation on;");
                        HomeScreen.Current.AddItem(naviItem);
                    }

                    getCoordinates();
                    String cartDescription = "move to " + popularLocationsCombo.Text.Trim();
                    String cartCode = "navigation landLatitude " + landLatitude + "\n" +
                                      "navigation landLongitude " + landLongitude + "\n ";

                    //create Earth item
                    ShowItem earthItem = new ShowItem("Earth Move", cartDescription, cartCode);

                    //add show item to list
                    HomeScreen.Current.AddItem(earthItem);


                    //update the show list after submit
                    HomeScreen.Current.UpdateList();
                }
            }
        }

        private void getCoordinates()
        {
            connect.Open();

            //Bind cmd to SQL commands
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //SQL command to select data from DB that coorolates to drop selection in drop down box
            cmd.CommandText = "select * from EarthScreenFavorites where Name = @Name";
            cmd.Parameters.AddWithValue("@Name", popularLocationsCombo.Text.Trim());
            cmd.ExecuteNonQuery();

            //Make a datareader that reads through the row
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();

            //While row still has info, add coordinates into string variables for script
            while (reader.Read())
            {
                landLatitude = reader["Latitude"].ToString();
                landLongitude = reader["Longitude"].ToString();
            }

            //Close Connection
            connect.Close();
        }

        private void panelEarth_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxLongitude_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (textBoxLongitude.Text != "")
            {
                double value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToDouble(textBoxLongitude.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 180)
                    {
                        //if correct keep text black
                        textBoxLongitude.ForeColor = Color.Black;
                        Longitude_Valid = true;
                        longitude = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        textBoxLongitude.ForeColor = Color.Red;
                        Longitude_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    textBoxLongitude.ForeColor = Color.Red;
                    Longitude_Valid = false;
                }

            }
            else
            {
                //no data input
                Longitude_Valid = false;
            }
        }

        private void textBoxLatitude_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (textBoxLatitude.Text != "")
            {
                double value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToDouble(textBoxLatitude.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 90)
                    {
                        //if correct keep text black
                        textBoxLatitude.ForeColor = Color.Black;
                        Latitude_Valid = true;
                        latitude = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        textBoxLatitude.ForeColor = Color.Red;
                        Latitude_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    textBoxLatitude.ForeColor = Color.Red;
                    Latitude_Valid = false;
                }

            }
            else
            {
                //no data input
                Latitude_Valid = false;
            }
        }
    }
}
