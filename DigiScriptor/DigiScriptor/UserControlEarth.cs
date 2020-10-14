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

        public UserControlEarth()
        {
            InitializeComponent();

            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //load database into the combo box
            LoadComboBox();
        }

        private void LoadComboBox()
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

        private void panelEarth_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
