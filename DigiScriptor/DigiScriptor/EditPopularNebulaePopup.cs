﻿using System;
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

        private string name = string.Empty;
        private string cellName = string.Empty;
        private Boolean DecDTxt_Valid = false;
        private Boolean DecMinTxt_Valid = false;
        private Boolean DecSecTxt_Valid = false;
        private Boolean RAsHrTxt_Valid = false;
        private Boolean RAsMinTxt_Valid = false;
        private Boolean RAsSecTxt_Valid = false;

        public EditPopularNebulaePopup()
        {
            InitializeComponent();

            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //Load nebulae database table into data grid
            LoadTable();
        }

        private void btnNebulaeSave_Click(object sender, EventArgs e)
        {
            //check Right Ascention is correct
            if (RAsHrTxt_Valid == false || RAsMinTxt_Valid == false || RAsSecTxt_Valid == false)
            {
                //reort error in Right ascention
                if (MessageBox.Show("Right Ascention is not correct. Please validate data.") ==
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
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into NebulaeFavorites (Name, Latitude, Longitude) VALUES (@Name, @Latitude, @Longitude)";
                cmd.Parameters.AddWithValue("@Name", name);
                //cmd.Parameters.AddWithValue("@Latitude", latitude);
                //cmd.Parameters.AddWithValue("@Longitude", longitude);
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
                        RAsSecTxt_Valid = true;

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

        }

    }
}