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
        private static HomeScreen home;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\savan\source\repos\Senior_Project\DigiScriptor\DigiScriptor\DigiDataBase.mdf;Integrated Security=True");

        public UserControlMovies()
        {
            InitializeComponent();

            LoadComboBox();
            //lblMoviesOutput.MaximumSize = new Size(100, 0);
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
                String sub = "submit?";
                String con = "Confirm";
                DialogResult results;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //display messgae
                results = MessageBox.Show(sub, con, buttons);
                //if result is 'yes' then show submited
                if (results == DialogResult.Yes)
                {
                    String cartOutput = "play " + lblMoviesOutput.Text;
                    //create star item
                    ShowItem movieItem = new ShowItem("Movie Play", cartOutput);

                    //add show item to list
                    HomeScreen.Current.AddItem(movieItem);


                    //update the show list after submit
                    HomeScreen.Current.UpdateList();


                    //for after submited is 'ok'
                    if (MessageBox.Show("submitted") == DialogResult.OK)
                    {
                        //do something after submitted message
                    }

                }
            }
        }

        private void lblMoviesOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
