using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace DigiScriptor
{
    public partial class HomeScreen : Form
    {
        public static HomeScreen Current;
        public String dir;
        public String fileName;
        public String filePath;

        private List<ShowItem> theList = new List<ShowItem>();

        //create singular save menu
        SaveMenu save;






        public HomeScreen()
        {
            InitializeComponent();

            //used to keep track of this form
            Current = this;
            dir = Directory.GetCurrentDirectory();
            fileName = "script.txt";
            filePath = dir + "\\" + fileName;
            Console.WriteLine(filePath);

            // Events for moving to different screens
            this.userControlHome.btnGalaxies.Click += ButtonGalaxies;
            this.userControlHome.btnSky.Click += ButtonNightSky;
            this.userControlHome.btnEarth.Click += ButtonEarth;
            this.userControlHome.btnStars.Click += ButtonStars;
            this.userControlHome.btnMoons.Click += ButtonMoons;
            this.userControlHome.btnPlanets.Click += ButtonPlanets;
            this.userControlHome.btnNebulae.Click += ButtonNebulae;
            this.userControlHome.btnMovies.Click += ButtonMovies;
            this.userControlHome.btnLights.Click += ButtonDomeLights;



            populateList();

        }



        private void populateList()
        {
            //test show
            for (int i = 0; i < 2; i++)
            {

                ShowItem test = new ShowItem();
                test.Title = "test title " + i;
                test.Decription = "this is a test description";
                theList.Add(test);
                
            }

            UpdateList();

        }




        public void UpdateList()
        {
            //update the show list
            for(int i= 0; i < theList.Count; i++)
            {
                //go through list adding show items to the show
                showPanel.Controls.Add(theList[i]);

            }
        }

        public void AddItem(ShowItem newItem)
        {
            //add items to list from other screens
            theList.Add(newItem);
            UpdateList();
        }





        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            userControlHome.Show();
            userControlHome.BringToFront();

            
        }

        private void lblDigi_Click_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLights_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCart_Click(object sender, EventArgs e)
        {

        }

        private void panelDomeLights_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNebulae_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMoons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show("Submitted") == DialogResult.OK)
            {
                //do some stuff
            }
            */

            if(save != null)
            {
                //if previously closed then remake save popup
                if (save.IsDisposed == true)
                {
                    save = null;
                    save = new SaveMenu();
                }

                //make sure show is showing and bring to front
                save.Show();
                save.Focus();
            }
            else
            {
                //initial time save menu shows
                save = new SaveMenu();
                save.Show();
            }

        }

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
