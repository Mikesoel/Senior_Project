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
    public partial class EditPopularStarsPopup : Form
    {

        //SqlConnection setup string
        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;

        private string name = string.Empty;
        private string cellName = string.Empty;


        public EditPopularStarsPopup()
        {
            InitializeComponent();
            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //Load star database table into data grid
            LoadTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //Tracks user selected row in datagridview
            
            foreach (DataGridViewRow row in StarDataBaseView.SelectedRows)
            {
                MessageBox.Show("Successfully Deleted " + StarDataBaseView.SelectedCells[0].Value.ToString());

                //Reads info from first cell in row selected to use as variable to delete selected from database
                cellName = StarDataBaseView.SelectedCells[0].Value.ToString();

                //Queries database with selected info to delete row
                cmd.CommandText = "DELETE FROM StarFavorites WHERE Name = @index";
                cmd.Parameters.AddWithValue("@index", cellName);
                cmd.ExecuteNonQuery();

            }
            connect.Close();
            LoadTable();


        }


        private void LoadTable()
        {
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name, RAHr, RAMin, RASec, DDEG, Dmin, Dsec from StarFavorites";
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
                StarDataBaseView.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }

        private void btnStarSave_Click(object sender, EventArgs e)
        {

        }
    }
}
