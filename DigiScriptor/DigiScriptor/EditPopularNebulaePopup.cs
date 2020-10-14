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

    public partial class EditPopularNebulaePopup : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\savan\source\repos\Senior_Project\DigiScriptor\DigiScriptor\DigiDataBase.mdf;Integrated Security=True");
        private string name = string.Empty;
        private string cellName = string.Empty;
        private int latitude, longitude;
        private Boolean latitude_Valid = false;
        private Boolean longitude_Valid = false;

        public EditPopularNebulaePopup()
        {
            InitializeComponent();
            LoadTable();
        }

        private void btnNebulaeSave_Click(object sender, EventArgs e)
        {
            // Check lat and long text box validity
            if (latitude_Valid == false && longitude_Valid == false)
            {
                MessageBox.Show("Latitude and Longitude values are invalid");

                // Clear both boxes if invalid
                txtBoxLatitude.Clear();
                txtBoxLongitude.Clear();
            }

            //Check latitude validity if longitude is valid
            else if (latitude_Valid == false)
            {
                MessageBox.Show("Latitude value is invalid");
                //clear latitude box if invalid
                txtBoxLatitude.Clear();
            }

            //Check longitude validity if latitude is valid
            else if (longitude_Valid == false)
            {
                MessageBox.Show("Latitude value is invalid");
                //clear longitude box if invalid
                txtBoxLongitude.Clear();
            }

            // If all values valid, add to database
            else
            {
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into NebulaeFavorites (Name, Latitude, Longitude) VALUES (@Name, @Latitude, @Longitude)";
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Latitude", latitude);
                cmd.Parameters.AddWithValue("@Longitude", longitude);
                cmd.ExecuteNonQuery();
                connect.Close();
                LoadTable();
            }
        }

        //Load table from database into data grid view
        private void LoadTable()

        {
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name, Latitude, Longitude from NebulaeFavorites";
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
                nebulaeDataGrid.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            name = txtBoxName.Text;
        }

        private void txtBoxLatitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNebulaeDelete_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //Tracks user selected row in datagridview
            foreach (DataGridViewRow row in nebulaeDataGrid.SelectedRows)
            {
                MessageBox.Show("Successfully Deleted " + nebulaeDataGrid.SelectedCells[0].Value.ToString());

                //Reads info from first cell in row selected to use as variable to delete selected from database
                cellName = nebulaeDataGrid.SelectedCells[0].Value.ToString();

                //Queries database with selected info to delete row
                cmd.CommandText = "DELETE FROM NebulaeFavorites WHERE Name = @index";
                cmd.Parameters.AddWithValue("@index", cellName);
                cmd.ExecuteNonQuery();

            }
            connect.Close();
            LoadTable();
        }

        private void EditPopularNebulaePopup_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxLongitude_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
