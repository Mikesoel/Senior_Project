﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiScriptor
{
    public partial class StarsScreen : Form
    {
        public StarsScreen()
        {
            InitializeComponent();
        }

        private void StarsScreen_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //bring back the previous form
            HomeScreen.Current.Show();

            //close this form
            this.Close();
        }
    }
}
