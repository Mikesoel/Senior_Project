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

namespace DigiScriptor
{
    public partial class UserControlGalaxies : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\savan\source\repos\Senior_Project\DigiScriptor\DigiScriptor\DigiDataBase.mdf;Integrated Security=True");

        public UserControlGalaxies()
        {
            InitializeComponent();
            LoadComboBox();
        }

        public void LoadComboBox()
        {
            comboBoxGalaxies.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from GalaxiesScreenList";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxGalaxies.Items.Add((dr["Name"].ToString()).TrimEnd());
            }
            connect.Close();
        }

        private void btnAndromeda_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGalaxiesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            //userControlHome.Show();
        }

        private void UserControlGalaxies_Load(object sender, EventArgs e)
        {
            
        }

        private void panelGalaxies_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGalaxiesOutput_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGalaxies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblGalaxiesOutput.Text = this.comboBoxGalaxies.Text;
        }

        private void comboBoxGalaxies_Click(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void btnSubmitGalaxy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
