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
    public partial class UserControlNebulae : UserControl
    {
        //int RAHr, RAMin, DDeg, DMin = 0;
        //double RASec, DSec = 0;

        string RAHr, RAMin, DDeg, DMin, RASec, DSec;

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

        public void LoadComboBox()
        {
            //Clear contents from Nebulae Favorites combo box
            nebulaeDropdown.Items.Clear();
            
            //Open DB connection
            connect.Open();
            
            //Bind cmd to SQL commands
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            //SQL command to select names from DB
            cmd.CommandText = "select CommonName from NebulaeFavorites";
            cmd.ExecuteNonQuery();
            
            //Add names to combobox
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                nebulaeDropdown.Items.Add(dr["CommonName"].ToString().Trim());
            }
            
            //Close DB connection
            connect.Close();
        }

        //Gets Coordinates from DB and puts them into variables for Script Generation
        private void getCoordinates()
        {
            connect.Open();

            //Bind cmd to SQL commands
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //SQL command to select data from DB that coorolates to drop selection in drop down box
            cmd.CommandText = "select * from NebulaeFavorites where CommonName = @CommonName";
            cmd.Parameters.AddWithValue("@CommonName", nebulaeDropdown.Text.Trim());
            cmd.ExecuteNonQuery();

            //Make a datareader that reads through the row
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();

            //While row still has info, add coordinates into string variables for script
            while(reader.Read())
            {
                RAHr = reader["RAHr"].ToString();
                RAMin = reader["RAMin"].ToString();
                RASec = reader["RASec"].ToString();
                DDeg = reader["DDeg"].ToString();
                DMin = reader["DMin"].ToString();
                DSec = reader["DSec"].ToString();
            }

            //Close Connection
            connect.Close();
        }

        private void lblNebulaeVantagePoint_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitNebulae_Click(object sender, EventArgs e)
        {
            String outputLbl = nebulaeDropdown.Text;
            if (!(String.IsNullOrEmpty(outputLbl)))
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

                    //if navigation has not been turned on yet, turn it on to
                    //flyTo galaxy
                    if (!isNavigationOn)
                    {
                        ShowItem naviItem = new ShowItem("Navigation On", "turn navigation on for flyTo commands", "navigation on;");
                        HomeScreen.Current.AddItem(naviItem);
                    }

                    getCoordinates();
                    String cartDescription = "move to " + nebulaeDropdown.Text.Trim();
                    String cartCode = "\tnavigation flyTo celestial " + RAHr + ":" + RAMin + ":" + RASec + " " + DDeg + ":" + DMin + ":" + DSec + "";

                    //create Nebula item
                    ShowItem nebulaeItem = new ShowItem("Nebula Move", cartDescription, cartCode);

                    //add show item to list
                    HomeScreen.Current.AddItem(nebulaeItem);


                    //update the show list after submit
                    HomeScreen.Current.UpdateList();
                }
            }
        }

        private void editPopularNebulaeButton_Click(object sender, EventArgs e)
        {
            //Opens nebulae favorites add/edit popup window when clicked
            EditPopularNebulaePopup editNebulaeData = new EditPopularNebulaePopup(this);
            editNebulaeData.Show(); 
        }

        private void nebulaeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelNebulae_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nebulaeDropdown_Click(object sender, EventArgs e)
        {
            //Now load combo box from editpopularearthpopup to let auto suggest work properly
            //Reload combo box every time it is clicked, assures data within is always accurate
            //LoadComboBox();
        }
    }
}
