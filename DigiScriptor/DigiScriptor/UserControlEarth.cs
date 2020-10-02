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

namespace DigiScriptor
{
    public partial class UserControlEarth : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Richie\Source\Repos\Mikesoel\Senior_Project\DigiScriptor\DigiScriptor\DigiDataBase.mdf;Integrated Security=True");


        public UserControlEarth()
        {
            InitializeComponent();
            LoadComboBox();

        }

        public void LoadComboBox()
        {
            popularLocationsCombo.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from EarthScreenFavorites";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                popularLocationsCombo.Items.Add(dr["Name"].ToString());
            }
            connect.Close();
        }

        private void popularLocationsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void popularLocationsCombo_Click(object sender, EventArgs e)
        {
            LoadComboBox();
        }


        private void editPopularLocationsButton_Click(object sender, EventArgs e)
        {
            EditPopularEarthLocationsPopup editData = new EditPopularEarthLocationsPopup();
            editData.Show();

        }

        private void btnSubmitEarth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Earth Selections Submitted");
        }
    }
}
