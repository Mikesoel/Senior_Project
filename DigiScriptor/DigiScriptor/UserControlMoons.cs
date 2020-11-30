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
    public partial class UserControlMoons : UserControl
    {

        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;
        public UserControlMoons()
        {
            InitializeComponent();

            connect = new SqlConnection(sqlPath);

            LoadComboBox();
        }

        private void panelMoons_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadComboBox()
        {
            //Clear contents from Nebulae Favorites combo box
            MoonFavCombo.Items.Clear();

            //Open DB connection
            connect.Open();

            //Bind cmd to SQL commands
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //SQL command to select names from DB
            cmd.CommandText = "select Name from MoonFav";
            cmd.ExecuteNonQuery();

            //Add names to combobox
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                MoonFavCombo.Items.Add(dr["Name"].ToString().Trim());
            }

            //Close DB connection
            connect.Close();
        }
    }
}
