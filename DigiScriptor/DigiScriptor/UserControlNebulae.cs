﻿using System;
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
    public partial class UserControlNebulae : UserControl
    {
        //SqlConnection setup string
        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;

        public UserControlNebulae()
        {
            InitializeComponent();

            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //load database into the combo box
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            nebulaeDropdown.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from NebulaeFavorites";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                nebulaeDropdown.Items.Add(dr["Name"].ToString());
            }
            connect.Close();
        }

        private void lblNebulaeVantagePoint_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitNebulae_Click(object sender, EventArgs e)
        {
            //confirmation message
            String sub = "Submit?";
            String con = "Confirm";
            DialogResult results;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            //display messgae
            results = MessageBox.Show(sub, con, buttons);
            //if result is 'yes' then show submited
            if (results == DialogResult.Yes)
            {

                //create Earth item
                ShowItem Nebulaeitem = new ShowItem("Nebula Move", "this is a nebula move");

                //add show item to list
                HomeScreen.Current.AddItem(Nebulaeitem);



                //update the show list after submit
                HomeScreen.Current.UpdateList();


                //for after submited is 'ok'
                if (MessageBox.Show("Submitted") == DialogResult.OK)
                {
                    //do something after submitted message
                }

            }
            else
            {
                //what to do if no is selected

            }
        }

        private void editPopularNebulaeButton_Click(object sender, EventArgs e)
        {
            EditPopularNebulaePopup editNebulaeData = new EditPopularNebulaePopup();
            editNebulaeData.Show();
        }

        private void nebulaeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelNebulae_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
