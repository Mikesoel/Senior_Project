using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DigiScriptor
{
    public partial class ShowItem : UserControl
    {
        ToolTip toolTip = new ToolTip();




        public ShowItem()
        {
            InitializeComponent();


            //toolTip setup
            SetupToolTips();


        }


        public ShowItem(String Title, String Description)
        {
            InitializeComponent();
            //set tittle and text 
            title = Title;
            titleBox.Text = Title;


            //set description and text box
            description = Description;
            descriptionBox.Text = Description;


            //toolTip setup
            SetupToolTips();


        }


        public ShowItem(String Title, String Description, String Code)
        {
            InitializeComponent();
            //set tittle and text 
            title = Title;
            titleBox.Text = Title;


            //set description and text box
            description = Description;
            descriptionBox.Text = Description;

            //set code
            code = Code;


            //toolTip setup
            SetupToolTips();


        }




        #region Properties

        private String title = "";
        private String description = "";
        private String code = "";
        private int delay = 0;

        //set up setters and getters for showitems
        public String Title
        {
            get { return title; }
            set { title = value; titleBox.Text = value; }
        }


        public String Description
        {
            get { return description; }
            set { description = value; descriptionBox.Text = value; }
        }


        public String Code
        {
            get { return code; }
            set { code = value; }

        }


        public int Delay
        {
            get { return delay; }
            set { delay = value; }
        }

        #endregion

        private void titleBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            //get the index of this ShowItem in the list
            List<ShowItem> list = HomeScreen.Current.GetList();
            int thisIndex = list.IndexOf(this);

            if (list.Count >= 2) //make sure there are at least two items in the list
            {
                if (thisIndex > 0) //if you press "up", there should be something above
                {
                    //if this iem does not need to have navigation on, do the swap
                    if(!((this.Title).Contains("Galaxy") || (this.Title).Contains("Nebula") || (this.Title).Contains("Star") || 
                         (this.Title).Contains("Planet") || (this.Title).Contains("Moon")))
                    {
                        //swap with the ShowItem above
                        HomeScreen.Current.Swap<ShowItem>(thisIndex, thisIndex - 1);

                    } else //check to see if Navigation On is the ShowItem directly above
                    {
                        if (!(list[thisIndex - 1].Title).Contains("Navigation"))
                        {
                            HomeScreen.Current.Swap<ShowItem>(thisIndex, thisIndex - 1);
                        }
                    }
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //get the index of this ShowItem in the list
            List<ShowItem> list = HomeScreen.Current.GetList();
            int thisIndex = list.IndexOf(this);

            if (list.Count >= 2) //make sure there are at least two items in the list
            {
                if (thisIndex < list.Count - 1) //if you press "down", there should be something belows
                {
                    HomeScreen.Current.Swap<ShowItem>(thisIndex, thisIndex + 1);
                }
            }
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {
            //if this is a Custom Code ShowItem, update the code when user changes text
            if((this.Title).Contains("Custom"))
            {
                //this.description = descriptionBox.Text;
                this.code = descriptionBox.Text;
            }
        }


        void SetupToolTips()
        {


            //set up toolTip
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;

            toolTip.SetToolTip(DelayBtn, "Set delay");



        }

        private void DelayBtn_Click(object sender, EventArgs e)
        {
            DelayPopup DelayScreen = new DelayPopup(title,delay,this);
            DelayScreen.Show();


        }

        public void updateDelayBtn(String value)
        {

            this.DelayBtn.Text = value;

        }


        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            List<ShowItem> list = HomeScreen.Current.GetList();
            int thisIndex = list.IndexOf(this);

            if (list.Count >= 1 && !((this.Title).Contains("Navigation"))) //make sure there is one item to delete
            {
                //confirmation message
                String sub = "Are you sure you want to delete? This will permanently remove this item from the Show.";
                String con = "Confirm";
                DialogResult results;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                //display messgae
                results = MessageBox.Show(sub, con, buttons);
                
                //if result is 'yes' then delete the ShowItem
                if (results == DialogResult.Yes)
                {
                    list.Remove(list[thisIndex]); //removing this ShowItem
                    HomeScreen.Current.showPanel.Controls.Clear();
                    HomeScreen.Current.UpdateList();
                }
            }
        }
    }
}
