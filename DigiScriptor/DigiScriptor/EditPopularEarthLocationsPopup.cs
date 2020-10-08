using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DigiScriptor
{
    public partial class EditPopularEarthLocationsPopup : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Richie\Source\Repos\Mikesoel\Senior_Project\DigiScriptor\DigiScriptor\DigiDataBase.mdf;Integrated Security=True");
        private string name = string.Empty;
        private string cellName = string.Empty;
        private int latitude, longitude;
        private Boolean latitude_Valid = false;
        private Boolean longitude_Valid = false;

        public EditPopularEarthLocationsPopup()
        {
            InitializeComponent();
            LoadTable();                                                                                

        }

       //Load table from database into data grid view
        private void LoadTable()

        {
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name, Latitude, Longitude from EarthScreenFavorites";
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
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into EarthScreenFavorites (Name, Latitude, Longitude) VALUES (@Name, @Latitude, @Longitude)";
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Latitude", latitude);
            cmd.Parameters.AddWithValue("@Longitude", longitude);
            cmd.ExecuteNonQuery();
            connect.Close();
            LoadTable();

        }

        private void latitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (latitudeTextBox.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(latitudeTextBox.Text);
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
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(longitudeTextBox.Text);
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
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            //Tracks user selected row in datagridview
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                MessageBox.Show("Successfully Deleted " +dataGridView1.SelectedCells[0].Value.ToString());
                
                //Reads info from first cell in row selected to use as variable to delete selected from database
                cellName = dataGridView1.SelectedCells[0].Value.ToString();
                
                //Queries database with selected info to delete row
                cmd.CommandText = "DELETE FROM EarthScreenFavorites WHERE Name = @index";
                cmd.Parameters.AddWithValue("@index", cellName);
                cmd.ExecuteNonQuery();
               
            }
            connect.Close();
            LoadTable();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
        }


    }
}
