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
    public partial class UserControlGalaxies : UserControl
    {
        //SqlConnection setup string
        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;
        Boolean durationValid = true;
        int durationValue = 0;

        public UserControlGalaxies()
        {
            InitializeComponent();

            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //load database into the combo box
            LoadComboBox();
        }

        public void LoadComboBox()
        {
            comboBoxGalaxies.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select CommonName from GalaxiesScreenList";
            cmd.ExecuteNonQuery();

            //Add names to combobox
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxGalaxies.Items.Add(dr["CommonName"].ToString().Trim());
            }

            connect.Close();
        }

        private void btnAndromeda_Click(object sender, EventArgs e)
        {
            this.lblGalaxiesOutput.Text = this.btnAndromeda.Text;
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
            String outputLbl = lblGalaxiesOutput.Text;
            if (!(String.IsNullOrEmpty(outputLbl)) && durationValid)
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
                    Boolean isNavigationOn = HomeScreen.Current.GetIsNavOn();
                    String galaxyOutput = "";

                    //if navigation has not been turned on yet, turn it on to
                    //flyTo galaxy
                    if(!isNavigationOn)
                    {
                        ShowItem naviItem = new ShowItem("Navigation On", "turn navigation on", "\tnavigation on");
                        HomeScreen.Current.AddItem(naviItem);
                    }


                    connect.Open();
                    SqlCommand cmd = connect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    //cmd.CommandText = "select CommonName from GalaxiesScreenList WHERE (CommonName LIKE '%' + @searchValue + '%')";
                    //cmd.Parameters.AddWithValue("@searchValue", lblGalaxiesOutput.Text);
                    cmd.CommandText = "select CommonName, DigistarName from GalaxiesScreenList";
                    cmd.ExecuteNonQuery();

                    //Get the digistar name based on common name selected
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if((dr["CommonName"].ToString().Trim()).Contains(lblGalaxiesOutput.Text))
                        {
                            try
                            {
                                galaxyOutput = dr["DigistarName"].ToString().Trim();
                            } catch
                            {

                            }
                        }
                    }

                    connect.Close();

                    //the description shown in the Current Script
                    String cartDescription = "Move to " + lblGalaxiesOutput.Text + " Galaxy.\nDuration: " + durationValue + " seconds\n";

                    //lines of code for going to a galaxy
                    String cartCode = "\tscene attitude 0 -45 0\n";
                    cartCode += "\tstars on\n";
                    cartCode += "\t" + galaxyOutput + " on\n" + "\t" + galaxyOutput + " intensity 90 duration 4\n";
                    //cartCode += "\tnavigation on\n";
                    cartCode += "\tnavigation defaultOrbitRate 0\n";

                    if (durationValid)
                    {
                        cartCode += "\tnavigation flyto " + galaxyOutput + " duration " + durationValue + "\n";

                        //create star item
                        ShowItem galaxyItem = new ShowItem("Galaxy Move", cartDescription, cartCode);
                        //add show item to list
                        HomeScreen.Current.AddItem(galaxyItem);
                    }


                    //update the show list after submit
                    HomeScreen.Current.UpdateList();


                    //NO CONFIRMATIONS NEEDED
                    /*/for after submited is 'ok'
                    if (MessageBox.Show("Submitted") == DialogResult.OK)
                    {
                        //do something after submitted message
                    }
                    */

                }
            }
        }

        private void btnMilkyWay_Click(object sender, EventArgs e)
        {
            this.lblGalaxiesOutput.Text = this.btnMilkyWay.Text;
        }

        private void btnLargeMagCloud_Click(object sender, EventArgs e)
        {
            this.lblGalaxiesOutput.Text = this.btnLargeMagCloud.Text;
        }

        private void btnWhirlpool_Click(object sender, EventArgs e)
        {
            this.lblGalaxiesOutput.Text = this.btnWhirlpool.Text;
        }

        private void btnSombrero_Click(object sender, EventArgs e)
        {
            this.lblGalaxiesOutput.Text = this.btnSombrero.Text;
        }

        private void btnTriangulum_Click(object sender, EventArgs e)
        {
            this.lblGalaxiesOutput.Text = this.btnTriangulum.Text;
        }

        private void btnSearchGalaxies_Click(object sender, EventArgs e)
        {
            //Opens galaxies search/edit popup window when clicked
            SearchGalaxiesPopup searchGalaxyData = new SearchGalaxiesPopup(this);
            searchGalaxyData.Show();
        }

        private void textBoxDuration_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDuration.Text) || (textBoxDuration.Text).Equals(""))
            {
                durationValid = true;
                durationValue = 0;
                textBoxDuration.ForeColor = Color.Black;
            }
            else if (Int32.Parse(textBoxDuration.Text) > 200)
            {
                textBoxDuration.ForeColor = Color.Red;
                durationValid = false;
            }
            else if (Int32.Parse(textBoxDuration.Text) <= 200)
            {
                durationValid = true;
                durationValue = Int32.Parse(textBoxDuration.Text);
                textBoxDuration.ForeColor = Color.Black;
            }
            else
            {
                durationValid = false;
            }
        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }
    }
}
