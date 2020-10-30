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

        
        private string cellName = string.Empty;


        //Booleans to check data
        private Boolean DecDTxt_Valid = false;
        private Boolean DecMinTxt_Valid = false;
        private Boolean DecSecTxt_Valid = false;
        private Boolean RAHrTxt_Valid = false;
        private Boolean RAMinTxt_Valid = false;
        private Boolean RASecTxt_Valid = false;
        private Boolean Name_Valid = false;
        int RAHr,RAMin,RASec,DDeg,DMin,DSec = 0;
        string starName = string.Empty;
        UserControlStars starPanel;




        public EditPopularStarsPopup(UserControlStars StarP)
        {
            InitializeComponent();
            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //Load star database table into data grid
            LoadTable();

            //load in star panel
            starPanel = StarP;



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
            //update combox
            starPanel.LoadComboBox();


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
            //see if any part of RA is wrong
            if (RAHrTxt_Valid ==false || RAMinTxt_Valid ==false || RASecTxt_Valid ==false)
            {
                MessageBox.Show("Right Ascension not correct");
                RAHrTxt.Focus();
            }

            //see if any part of Dec is wrong
            else if (DecDTxt_Valid == false || DecMinTxt_Valid == false || DecSecTxt_Valid == false)
            {
                MessageBox.Show("Declination not correct");
                DecDTxt.Focus();
            }

            //see if name invalid
            else if(Name_Valid == false)
            {
                MessageBox.Show("Invalid name. cant be blank or start with a space");
                NametextBox.Focus();
            }

            else
            {
                //data is valid add entry to database
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //create sql command
                cmd.CommandText = "insert into StarFavorites (Name, RAHr, RAMin, RASec, DDeg, DMin, DSec) VALUES (@Name,  @RAHr, @RAMin, @RASec, @DDeg, @DMin, @DSec)";
                cmd.Parameters.AddWithValue("@Name", starName);
                cmd.Parameters.AddWithValue("@RAHr", RAHr);
                cmd.Parameters.AddWithValue("@RAMin", RAMin);
                cmd.Parameters.AddWithValue("@RASec", RASec);
                cmd.Parameters.AddWithValue("@DDeg", DDeg);
                cmd.Parameters.AddWithValue("@DMin", DMin);
                cmd.Parameters.AddWithValue("@DSec", DSec);
                cmd.ExecuteNonQuery();
                connect.Close();
                LoadTable();

                starPanel.LoadComboBox();
               
            }


        }

        private void EditPopularStarsPopup_Load(object sender, EventArgs e)
        {

        }


        private void RAsHrTxt_TextChanged(object sender, EventArgs e)
        {

            //check if text is empty
            if (RAHrTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(RAHrTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 23)
                    {
                        //if correct keep text black
                        RAHrTxt.ForeColor = Color.Black;
                        RAHrTxt_Valid = true;
                        RAHr = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAHrTxt.ForeColor = Color.Red;
                        RAHrTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAHrTxt.ForeColor = Color.Red;
                    RAHrTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                RAHrTxt_Valid = false;
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
                        RAMinTxt_Valid = true;
                        RAMin = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAsMinTxt.ForeColor = Color.Red;
                        RAMinTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAsMinTxt.ForeColor = Color.Red;
                    RAMinTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                RAMinTxt_Valid = false;
            }

        }
        

        private void RAsSecTxt_TextChanged(object sender, EventArgs e)
        {
            //check if text is empty
            if (RAsSecTxt.Text != "")
            {
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(RAsSecTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
                    {
                        //if correct keep text black
                        RAsSecTxt.ForeColor = Color.Black;
                        RASecTxt_Valid = true;
                        RASec = value;

                    }
                    else
                    {
                        //if invalid value then change to red text
                        RAsSecTxt.ForeColor = Color.Red;
                        RASecTxt_Valid = false;
                    }
                }
                catch
                {
                    //if not a number then change text to red
                    RAsSecTxt.ForeColor = Color.Red;
                    RASecTxt_Valid = false;
                }

            }
            else
            {
                //no data input
                RASecTxt_Valid = false;
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
                int value = 0;

                //if something is in box try to convert to int
                try
                {
                    value = Convert.ToInt32(DecSecTxt.Text);
                    //validate data is within correct range
                    if (value >= 0 && value <= 59)
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

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            //chaek if name is valid
            if(NametextBox.Text == "" || NametextBox.Text.StartsWith(" "))
            {
                Name_Valid = false;
                starName = string.Empty;
            }
            else
            {
                Name_Valid = true;
                starName = NametextBox.Text;
            }

        }
    }
}
