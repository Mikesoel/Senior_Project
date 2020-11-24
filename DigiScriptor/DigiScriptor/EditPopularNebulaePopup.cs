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

    public partial class EditPopularNebulaePopup : Form
    {
        //SqlConnection setup string
        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;

        //Variables for nebula name, declination degree/min/max and right ascension hour/minutes/seconds
        private string commonName = string.Empty;
        private string sciName = string.Empty;
        private string search = string.Empty;
        int RAHr, RAMin, DDeg, DMin = 0;
        private string nebulaID = null;
        double RASec, DSec = 0;
        private Boolean DecDTxt_Valid = false;
        private Boolean DecMinTxt_Valid = false;
        private Boolean DecSecTxt_Valid = false;
        private Boolean RAsHrTxt_Valid = false;
        private Boolean RAsMinTxt_Valid = false;
        private Boolean RAsSecTxt_Valid = false;
        private Boolean sciName_Valid = false;
        private Boolean search_Valid = false;
        private Boolean editRow = false;
        UserControlNebulae nebulaePanel;
        public string selection;

        public EditPopularNebulaePopup(UserControlNebulae NebulaeP)
        {
            InitializeComponent();

            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //Load nebulae database table into data grid
            LoadTable();

            nebulaePanel = NebulaeP;
        }

        private void btnNebulaeSave_Click(object sender, EventArgs e)
        {
            //check Right Ascention is correct
            if (RAsHrTxt_Valid == false || RAsMinTxt_Valid == false || RAsSecTxt_Valid == false)
            {
                //reort error in Right ascention
                if (MessageBox.Show("Right Ascension is not correct. Please validate data.") ==
                    DialogResult.OK)
                {
                    RAsHrTxt.Select();
                }

                return;
            }

            //check that Declination is correct
            if (DecDTxt_Valid == false || DecMinTxt_Valid == false || DecSecTxt_Valid == false)
            {
                //report an error in declination
                if (MessageBox.Show("Declination is not correct. Please validate data.") ==
                    DialogResult.OK)
                {
                    DecDTxt.Select();
                }
                return;
            }

            // If all values valid, add to database
            else
            {
                // Open DB connection
                connect.Open();
                
                //Bind cmd to SQL commands
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;

                
                //SQL Command to update data if user wishes to edit data in DB
                if (editRow == true)
                {
                    //set editRow to false to prevent future save/delete issues
                    editRow = false;
                    cmd.CommandText = "Update NebulaeFavorites Set CommonName = @commonName, ScientificName = @sciName, RAHr = @RAHr, RAMin = @RAMin, RASec = @RASec, DDeg = @DDeg, DMin = @DMin, DSec = @DSec WHERE (NebulaeID = @NebID)";
                    cmd.Parameters.AddWithValue("@NebID", nebulaID);
                }

                //SQL command to be entered into DB with Scientific Name
               else if (sciName_Valid == true)
                    cmd.CommandText = "insert into NebulaeFavorites (CommonName, ScientificName, RAHr, RAMin, RASec, DDeg, DMin, DSec) VALUES (@commonName, @sciName, @RAHr, @RAMin, @RASec, @DDeg, @DMin, @DSec)";
                
                //SQL command to be entered into DB without scientific name
                else
                    cmd.CommandText = "insert into NebulaeFavorites (CommonName, RAHr, RAMin, RASec, DDeg, DMin, DSec) VALUES (@commonName,  @RAHr, @RAMin, @RASec, @DDeg, @DMin, @DSec)";

                //Bind variables to SQL command names
                cmd.Parameters.AddWithValue("@commonName", commonName);
                cmd.Parameters.AddWithValue("@sciName", sciName);
                cmd.Parameters.AddWithValue("@RAHr", RAHr);
                cmd.Parameters.AddWithValue("@RAMin", RAMin);
                cmd.Parameters.AddWithValue("@RASec", RASec);
                cmd.Parameters.AddWithValue("@DDeg", DDeg);
                cmd.Parameters.AddWithValue("@DMin", DMin);
                cmd.Parameters.AddWithValue("@DSec", DSec);

                cmd.ExecuteNonQuery();
                
                //Close DB connection and reload datagrid
                connect.Close();
                MessageBox.Show("Submitted " + commonName.Trim() + " into database");
                
                //Clear data from Text boxes
                Clear_Input();

                //Reload Table
                LoadTable();

                //Reload combo box on nebulae user control
                nebulaePanel.LoadComboBox();

                //Set nebula ID to null to prevent unwanted editing or deleting
                nebulaID = null;
            }
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
                cmd.CommandText = "select CommonName, ScientificName, RAHr, RAMin, RASec, DDEG, Dmin, Dsec, NebulaeID " +
                                  "FROM NebulaeFavorites";
            }

            //SQL command to be entered into DB if search is true
            else
            {
                cmd.CommandText = "select CommonName, ScientificName, RAHr, RAMin, RASec, DDEG, Dmin, Dsec, NebulaeID FROM NebulaeFavorites WHERE (CommonName LIKE '%' + @searchValue + '%') " +
                    "OR (ScientificName LIKE '%' + @searchValue + '%') " +
                    "OR (RAHr LIKE '%' + @searchValue + '%')" +
                    "OR (RAMin LIKE '%' + @searchValue + '%')" +
                    "OR (RASec LIKE '%' + @searchValue + '%')" +
                    "OR (DDEG LIKE '%' + @searchValue + '%')" +
                    "OR (Dmin LIKE '%' + @searchValue + '%')" +
                    "OR (Dsec LIKE '%' + @searchValue + '%')";
                
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
            commonName = txtBoxName.Text;
        }


        private void btnNebulaeDelete_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow row in nebulaeDataGrid.SelectedRows)
                {
                    MessageBox.Show("Successfully Deleted " + nebulaeDataGrid.SelectedCells[0].Value.ToString());

                    //Reads nebula id from specified cell to use to delete row from DB
                    nebulaID = nebulaeDataGrid.SelectedCells[8].Value.ToString();

                    //Queries database with selected info to delete row
                    cmd.CommandText = "DELETE FROM NebulaeFavorites WHERE NebulaeID = @index";
                    cmd.Parameters.AddWithValue("@index", nebulaID);
                    cmd.ExecuteNonQuery();
                    nebulaID = null;

                }
                //Close DB connection and reload datagrid view
                connect.Close();
                LoadTable();
            }
        }

        private void RAsHrTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (RAsHrTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(RAsHrTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 23)
                    {
                        //if correct keep text black
                        RAsHrTxt.ForeColor = Color.Black;
                        RAsHrTxt_Valid = true;
                        RAHr = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAsHrTxt.ForeColor = Color.Red;
                        RAsHrTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAsHrTxt.ForeColor = Color.Red;
                    RAsHrTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                RAsHrTxt_Valid = false;
            }
        }

        private void RAsMinTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (RAsMinTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(RAsMinTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        RAsMinTxt.ForeColor = Color.Black;
                        RAsMinTxt_Valid = true;
                        RAMin = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAsMinTxt.ForeColor = Color.Red;
                        RAsMinTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAsMinTxt.ForeColor = Color.Red;
                    RAsMinTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                RAsMinTxt_Valid = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //When clear button is clicked, clear all contents from text boxes

            Clear_Input();
        }

        private void Clear_Input()
        {
            //Function to clear all text boxes of data
            txtBoxName.Clear();
            txtBoxSciName.Clear();
            RAsHrTxt.Clear();
            RAsMinTxt.Clear();
            RAsSecTxt.Clear();
            DecDTxt.Clear();
            DecMinTxt.Clear();
            DecSecTxt.Clear();
        }

        private void txtBoxSciName_TextChanged(object sender, EventArgs e)
        {
            //Tests if user inputted scientific name
            //If yes, boolean set to true to use a different SQL statement
            if (txtBoxSciName.Text != "")
            {
                sciName = txtBoxName.Text;
                sciName_Valid = true;
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            //Tests is user inputted into search field
            //If boolean set to true, database gets searched with every input
            //Updates every text change event in text box
            if (searchTxt.Text != "")
            {
                search = searchTxt.Text;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void RAsSecTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (RAsSecTxt.Text != "")
            {
                double value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToDouble(RAsSecTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59.9)
                    {
                        //if correct keep text black
                        RAsSecTxt.ForeColor = Color.Black;
                        RAsSecTxt_Valid = true;
                        RASec = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAsSecTxt.ForeColor = Color.Red;
                        RAsSecTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAsSecTxt.ForeColor = Color.Red;
                    RAsSecTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                RAsSecTxt_Valid = false;
            }
        }

        private void DecDTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (DecDTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(DecDTxt.Text);
                    //validate data is within correct range
                    if (value >= -90 && value <= 90)
                    {
                        //if correct keep text black
                        DecDTxt.ForeColor = Color.Black;
                        //data is valid
                        DecDTxt_Valid = true;
                        DDeg = value;
                    }
                    else
                    {
                        //if invalid value then change to red text
                        DecDTxt.ForeColor = Color.Red;
                        //data is invalid
                        DecDTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    DecDTxt.ForeColor = Color.Red;
                    //data is invalid
                    DecDTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                DecDTxt_Valid = false;
            }
        }

        private void editRowBtn_Click(object sender, EventArgs e)
        {
            //sets editRow boolean to true to use different SQL statement when save button is clicked
            editRow = true;
            
            //Sends all data from selected row into text boxes
            foreach (DataGridViewRow row in nebulaeDataGrid.SelectedRows)
            {
                //Reads info from each cell in data table and adds to text boxes to be edited
                txtBoxName.Text = nebulaeDataGrid.SelectedCells[0].Value.ToString().Trim();
                txtBoxSciName.Text = nebulaeDataGrid.SelectedCells[1].Value.ToString().Trim();
                RAsHrTxt.Text = nebulaeDataGrid.SelectedCells[2].Value.ToString();
                RAsMinTxt.Text = nebulaeDataGrid.SelectedCells[3].Value.ToString();
                RAsSecTxt.Text = nebulaeDataGrid.SelectedCells[4].Value.ToString();
                DecDTxt.Text = nebulaeDataGrid.SelectedCells[5].Value.ToString();
                DecMinTxt.Text = nebulaeDataGrid.SelectedCells[6].Value.ToString();
                DecSecTxt.Text = nebulaeDataGrid.SelectedCells[7].Value.ToString();
                nebulaID = nebulaeDataGrid.SelectedCells[8].Value.ToString();

            }

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in nebulaeDataGrid.SelectedRows)
            {
                //Reads nebula name from specified cell to use to add name to combo box
                selection = nebulaeDataGrid.SelectedCells[0].Value.ToString();

                //sets combo box text and trims
                nebulaePanel.nebulaeDropdown.Text = selection.Trim();

            }
            this.Close();
        }

        private void DecMinTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (DecMinTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(DecMinTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        DecMinTxt.ForeColor = Color.Black;
                        DecMinTxt_Valid = true;
                        DMin = value;
                    }
                    else
                    {
                        //if invalid value then change to red text
                        DecMinTxt.ForeColor = Color.Red;
                        DecMinTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    DecMinTxt.ForeColor = Color.Red;
                    DecMinTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                DecMinTxt_Valid = false;
            }
        }

        private void DecSecTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (DecSecTxt.Text != "")
            {
                double value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToDouble(DecSecTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59.9)
                    {
                        //if correct keep text black
                        DecSecTxt.ForeColor = Color.Black;
                        DecSecTxt_Valid = true;
                        DSec = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        DecSecTxt.ForeColor = Color.Red;
                        DecSecTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    DecSecTxt.ForeColor = Color.Red;
                    DecSecTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                DecSecTxt_Valid = false;
            }
        }

        private void EditPopularNebulaePopup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'digiDataBaseDataSet.NebulaeFavorites' table. You can move, or remove it, as needed.
            //this.nebulaeFavoritesTableAdapter.Fill(this.digiDataBaseDataSet.NebulaeFavorites);

        }

        private void LoadData()
        {
            //this.nebulaeFavoritesTableAdapter.UpdateAll(this.digiDataBaseDataSet);
        }

    }
}
