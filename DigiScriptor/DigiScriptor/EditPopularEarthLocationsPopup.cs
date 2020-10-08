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

        public EditPopularEarthLocationsPopup()
        {
            InitializeComponent();
            LoadTable();

        }

        private void LoadTable()

        {
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name, Latitude, Longitude from EarthScreenFavorites";
            cmd.ExecuteNonQuery();

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
            latitude = Int32.Parse(latitudeTextBox.Text);
        }

        private void longitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            longitude = Int32.Parse(longitudeTextBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                MessageBox.Show("Successfully Deleted " +dataGridView1.SelectedCells[0].Value.ToString());
                cellName = dataGridView1.SelectedCells[0].Value.ToString();
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
