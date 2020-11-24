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
    public partial class EditPopularEarthLocationsPopup : Form
    {

        //SqlConnection setup string
        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;
        private string name = string.Empty;
        private string earthID = string.Empty;
        private double latitude, longitude;
        private Boolean latitude_Valid = false;
        private Boolean longitude_Valid = false;
        private Boolean editRow = false;
        UserControlEarth earthPanel;

        public EditPopularEarthLocationsPopup(UserControlEarth EarthP)
        {
            InitializeComponent();

            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //Load earth favorites table into data grid
            LoadTable();

            earthPanel = EarthP;

        }

       //Load table from database into data grid view
        private void LoadTable()

        {
            //open connection to database
            connect.Open();
            
            //Set command for SQL commands
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            //SQL command for database
            cmd.CommandText = "select Name, Latitude, Longitude, LocationID from EarthScreenFavorites";
            cmd.ExecuteNonQuery();

            //opens connection for selected data from table
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //Save all data from text boxes into table. Database table automatically increments LocationID by 1 for each entry
        private void dataSave_Click(object sender, EventArgs e)
        {
            
            // Check lat and long text box validity
            if (latitude_Valid == false && longitude_Valid == false)
            {
                MessageBox.Show("Latitude and Longitude values are invalid");

                // Select Top text box if both incorrect
                latitudeTextBox.Select();
            }

            //Check latitude validity if longitude is valid
            else if (latitude_Valid == false)
            {
                MessageBox.Show("Latitude value is invalid");
                //Select latitude text box if incorrect
                latitudeTextBox.Select();
            }

            //Check longitude validity if latitude is valid
            else if (longitude_Valid == false)
            {
                MessageBox.Show("Latitude value is invalid");
                //Select longitude text box if incorrect
                longitudeTextBox.Select();
            }

            // If all values valid, add to database
            else
            {
                //Open connection to database
                connect.Open();
                
                //bind command to enter text for SQL commands
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //SQL Command to update data if user wishes to edit data in DB
                if (editRow == true)
                {
                    //set editRow to false to prevent future save/delete issues
                    editRow = false;
                    cmd.CommandText = "Update EarthScreenFavorites Set Name = @Name, Latitude = @Latitude, Longitude = @Longitude WHERE (LocationID = @EarthID)";
                    cmd.Parameters.AddWithValue("@EarthID", earthID);
                }

                else
                    cmd.CommandText = "insert into EarthScreenFavorites (Name, Latitude, Longitude) VALUES (@Name, @Latitude, @Longitude)";
                
                //variables for SQL command
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Latitude", latitude);
                cmd.Parameters.AddWithValue("@Longitude", longitude);
                cmd.ExecuteNonQuery();
                
                //close database connection
                connect.Close();
                
                //Re-Load database into datagrid
                LoadTable();
                earthPanel.LoadComboBox();

                //clear inputs
                Clear_Input();
            }

        }

        private void Clear_Input()
        {
            //Function to clear all text boxes of data
            nameTextBox.Clear();
            latitudeTextBox.Clear();
            longitudeTextBox.Clear();
        }

        private void latitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (latitudeTextBox.Text != "")
            {
                double value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToDouble(latitudeTextBox.Text);
                    //validate data is within correct range
                    if (value >= -180 && value <= 180)
                    {
                        //if correct keep text black
                        latitudeTextBox.ForeColor = Color.Black;
                        //data is valid
                        latitude_Valid = true;
                        latitude = value;
                    }
                    else
                    {
                        //if invalid value then change to red text
                        latitudeTextBox.ForeColor = Color.Red;
                        //data is invalid
                        latitude_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    latitudeTextBox.ForeColor = Color.Red;
                    //data is invalid
                    latitude_Valid = false;
                }

            }
            else
            {
                //no data input
                latitude_Valid = false;
            }
        }

        private void longitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (longitudeTextBox.Text != "")
            {
                double value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToDouble(longitudeTextBox.Text);
                    //validate data is within correct range
                    if (value >= -180 && value <= 180)
                    {
                        //if correct keep text black
                        longitudeTextBox.ForeColor = Color.Black;
                        //data is valid
                        longitude_Valid = true;
                        longitude = value;
                    }
                    else
                    {
                        //if invalid value then change to red text
                        longitudeTextBox.ForeColor = Color.Red;
                        //data is invalid
                        longitude_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    longitudeTextBox.ForeColor = Color.Red;
                    //data is invalid
                   longitude_Valid = false;
                }

            }
            else
            {
                //no data input
                longitude_Valid = false;
            }
        }

        //Delete selected row from datagrid and database table
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //confirmation message
            String sub = "Deleting will permanantly remove selected data from the database. \n"
                       + "Are you sure you want to proceed?";
            String con = "Confirm";
            DialogResult results;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //display messgae
            results = MessageBox.Show(sub, con, buttons);
            //if result is 'yes' then show submited
            if (results == DialogResult.Yes)
            {
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //Tracks user selected row in datagridview
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    MessageBox.Show("Successfully Deleted " + dataGridView1.SelectedCells[0].Value.ToString());

                    //Reads info from first cell in row selected to use as variable to delete selected from database
                    earthID = dataGridView1.SelectedCells[3].Value.ToString();

                    //Queries database with selected info to delete row
                    cmd.CommandText = "DELETE FROM EarthScreenFavorites WHERE LocationID = @index";
                    cmd.Parameters.AddWithValue("@index", earthID);
                    cmd.ExecuteNonQuery();

                }
                //Close database connection
                connect.Close();

                //Re-Load database into Datagrid and combobox in earth panel
                LoadTable();
                earthPanel.LoadComboBox();
            }
        }

        private void EditPopularEarthLocationsPopup_Load(object sender, EventArgs e)
        {

        }

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            //sets editRow boolean to true to use different SQL statement when save button is clicked
            editRow = true;

            //Sends all data from selected row into text boxes
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //Reads info from each cell in data table and adds to text boxes to be edited
                nameTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString().Trim();
                latitudeTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString().Trim();
                longitudeTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                earthID = dataGridView1.SelectedCells[3].Value.ToString();
            }

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //Name variable from textbox
            name = nameTextBox.Text;
        }


    }
}
