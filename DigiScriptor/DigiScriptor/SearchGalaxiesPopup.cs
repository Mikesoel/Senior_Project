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
using System.IO;

namespace DigiScriptor
{
    public partial class SearchGalaxiesPopup : Form
    {
        //SqlConnection setup string
        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;

        private string commonName = string.Empty;
        private string sciName = string.Empty;
        private string search = string.Empty;
        private Boolean search_Valid = false;
        UserControlGalaxies galaxiesPanel;
        public string selection;

        public SearchGalaxiesPopup(UserControlGalaxies galaxiesPage)
        {
            InitializeComponent();

            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //Load nebulae database table into data grid
            LoadTable();

            galaxiesPanel = galaxiesPage;
        }

        //Load table from database into data grid view
        private void LoadTable()

        {
            //Open DB connection
            connect.Open();

            //Bind cmd to SQL commands
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //SQL command to be entered into DB if search is false
            if (search_Valid == false)
            {
                cmd.CommandText = "select CommonName, DigistarName, GalaxyID " +
                                  "FROM GalaxiesScreenList";
            }

            //SQL command to be entered into DB if search is true
            else
            {
                cmd.CommandText = "select CommonName, DigistarName, GalaxyID FROM GalaxiesScreenList WHERE (CommonName LIKE '%' + @searchValue + '%') " +
                    "OR (DigistarName LIKE '%' + @searchValue + '%') ";

                //Binds text from search text box into searchValue variable
                cmd.Parameters.AddWithValue("@searchValue", search);
            }
            cmd.ExecuteNonQuery();

            //Bind DB into datagrid view
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                galaxyDataGrid.DataSource = bSource;
                sda.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }



        private void searchGalaxyTxt_TextChanged(object sender, EventArgs e)
        {
            //Tests is user inputted into search field
            //If boolean set to true, database gets searched with every input
            //Updates every text change event in text box
            if (searchGalaxyTxt.Text != "")
            {
                search = searchGalaxyTxt.Text;
                search_Valid = true;
                LoadTable();
            }

            //If search text becomes empty (user done searching)
            //Boolean set to false and table loaded again with all data
            else
            {
                search_Valid = false;
                LoadTable();
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in galaxyDataGrid.SelectedRows)
            {
                //Reads nebula name from specified cell to use to add name to combo box
                selection = galaxyDataGrid.SelectedCells[0].Value.ToString();

                //sets combo box text and trims
                galaxiesPanel.lblGalaxiesOutput.Text = selection.Trim();

            }
            this.Close();
        }
    }
}
