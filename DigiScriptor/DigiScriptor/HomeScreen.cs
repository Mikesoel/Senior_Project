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

        //create show list
        private List<ShowItem> theList = new List<ShowItem>();
        
        //create flag for whether turning navigation on has been added
        //to the show list
        private Boolean isNavigationOn = false;


        //create flag if stars need to be on
        private Boolean isStarOn = false;



        //create singular save menu
        public SaveMenu save;



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

            //populateList();

        }



        private void populateList()
        {
            //test show
            for (int i = 0; i < 2; i++)
            {

                ShowItem test = new ShowItem();
                test.Title = "test title " + i;
                test.Description = "this is a test description";
                theList.Add(test);
                
            }

            UpdateList();

        }


        public void UpdateList()
        {
            ShowItem lastItem = new ShowItem();
            //update the show list
            for(int i= 0; i < theList.Count; i++)
            {
                //go through list adding show items to the show
                showPanel.Controls.Add(theList[i]);
                lastItem = theList[i];
            }

            //auto scroll to last item in list (newest item added)
            showPanel.ScrollControlIntoView(lastItem);


        }

        public void AddItem(ShowItem newItem)
        {
            //add items to list from other screens
            theList.Add(newItem);

            //checking to see if the item being added is to turn
            //navigation on
            if ((newItem.Title).Equals("Navigation On"))
            {
                isNavigationOn = true;
            }

            //checking to see if the item being added is to turn
            //stars on
            if((newItem.Title).Equals("Turn on Stars"))
            {
                isStarOn = true;
            }


            UpdateList();
        }

        public List<ShowItem> GetList()
        {
            return theList;
        }

     


        public void Swap<ShowItem>(int index1, int index2)
        {
            //swap two ShowItems in the list
            DigiScriptor.ShowItem tmp = theList[index1];
            theList[index1] = theList[index2];
            theList[index2] = tmp;
            UpdateList();
        }


        public int GetListCount()
        {
            //returns the number of elements in the ShowItem list
            return theList.Count;
        }


        public Boolean GetIsNavOn()
        {
            //returns whether nagivation has been turned on yet
            return isNavigationOn;
        }



        public Boolean getIsStarsOn()
        {
            return isStarOn;
        }


        private void HomeScreen_Load(object sender, EventArgs e)
        {
            userControlHome.Show();
            userControlHome.BringToFront();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if(save != null)
            {
                //if previously closed then remake save popup
                if(save.IsDisposed == true)
                {
                    save = null;
                    save = new SaveMenu();
                }

                //make sure show is showing and brought to front
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

        public string showCodeBuilder()
        {
            string codeOut = string.Empty;

            for (int i = 0; i < theList.Count; i++)
            {
                //comment the title
                codeOut += @"#";
                codeOut += theList[i].Title;
                codeOut += "\n";

                //comment the description
                codeOut += " \"\"\" " + "\n";
                if((theList[i].Title).Contains("Custom"))
                {
                    codeOut += "user inputted code";
                } else
                {
                    codeOut += theList[i].Description;
                }
                codeOut += "\n";
                codeOut += "\"\"\"";
                codeOut += "\n";


                //add in delay
                codeOut += "+" + theList[i].Delay + "\n";


                //check if the item has code
                if (theList[i].Code != "")
                {
                    codeOut += theList[i].Code;
                    codeOut += "\n\n";
                }
                else
                {
                    //fill code sections with comment
                    codeOut += @"# code goes here!!!!!";
                    codeOut += "\n\n";
                }

            }//end of for-loop

            return codeOut;
        }
    }
}
