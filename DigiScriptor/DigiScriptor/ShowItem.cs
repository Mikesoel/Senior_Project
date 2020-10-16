using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiScriptor
{
    public partial class ShowItem : UserControl
    {
        public ShowItem()
        {
            InitializeComponent();
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

        }



        public ShowItem(String Title,String Description, String Code)
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
        }




        #region Properties

        private String title = "";
        private String description = "";
        private String code = "";

        //set up setters and getters for showitems
        public String Title
        {
            get { return title; }
            set { title = value; titleBox.Text = value; }
        }


        public String Decription
        {
            get { return description; }
            set { description = value; descriptionBox.Text = value; }
        }


        public String Code
        {
            get { return code; }
            set { code = value; }

        }



        #endregion

    }
}
