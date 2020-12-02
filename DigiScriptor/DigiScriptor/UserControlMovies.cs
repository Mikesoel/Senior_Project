using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DigiScriptor
{
    public partial class UserControlMovies : UserControl
    {
        //SqlConnection setup string
        string sqlPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + @"DigiDataBase.mdf;Integrated Security=True";
        SqlConnection connect;

        public UserControlMovies()
        {
            InitializeComponent();

            //make the SqlConnection with local file path
            connect = new SqlConnection(sqlPath);

            //load database into the combo box
            LoadComboBox();
        }

        public void LoadComboBox()
        {
            comboBoxMovies.Items.Clear();
            connect.Open();
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Name from MoviesScreenList";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxMovies.Items.Add((dr["Name"].ToString()).TrimEnd());
            }
            connect.Close();
        }

        private void comboBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.comboBoxMovies.Text;
        }

        private void comboBoxMovies_Click(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void btnTwoSmallPieces_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnTwoSmallPieces.Text;
        }

        private void btnPharaohs_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnPharaohs.Text;
        }

        private void btnChristmasStar_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnChristmasStar.Text;
        }

        private void btnSecretsSun_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnSecretsSun.Text;
        }

        private void btnFrozenWorlds_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnFrozenWorlds.Text;
        }

        private void btnSubmitMovies_Click(object sender, EventArgs e)
        {
            String outputLbl = lblMoviesOutput.Text;
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
                    String cartDescription = "play " + lblMoviesOutput.Text;
                    String cartCode = "\tmovie play " + lblMoviesOutput.Text;

                    //create star item
                    ShowItem movieItem = new ShowItem("Movie Play", cartDescription, cartCode);

                    //add show item to list
                    HomeScreen.Current.AddItem(movieItem);


                    //update the show list after submit
                    HomeScreen.Current.UpdateList();

                }
            }
        }

        private void lblMoviesOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnDarkMatter_Click(object sender, EventArgs e)
        {
            this.lblMoviesOutput.Text = this.btnDarkMatter.Text;
        }
    }
}
