﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DigiScriptor
{
    public partial class SaveMenu : Form
    {
        string filePath = string.Empty;
        FileStream fs;

        public List<ShowItem> showList = new List<ShowItem>();



        public SaveMenu()
        {
            InitializeComponent();

            


        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }



        public void UpdateList()
        {

            showList = HomeScreen.Current.GetList();


            for (int i =0; i < showList.Count; i++)
            {
                ShowPanel.Controls.Add(showList[i]);

            }



        }



        private void Location_Btn_Click(object sender, EventArgs e)
        {
            //set up dialog box for .ds and .js files
            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "JaveScript files (*.js)|*.js|DigiStarScript files (*.ds)|*.ds";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;


            //if file is picked or named then update saved file path and text of path
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                LoctxtBox.Text = filePath;
            }




        }

        private void SaveMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //check that a file path is selected
            if (filePath == string.Empty)
            {
                //error that a file not selected
                MessageBox.Show("A file must be selected");
            }
            else
            {
                //check that file existe
                if (File.Exists(filePath))
                {

                    try
                    {
                        //open file and write to it
                        //fs = File.OpenWrite(filePath);
                        System.IO.File.WriteAllText(filePath, HomeScreen.Current.showCodeBuilder());



                        //close file after writing to it
                        //fs.Close();
                    }
                    catch
                    {

                    }




                }
                else
                {
                    //if file doesnt exist
                    try
                    {
                        //create new file and then write code to it
                        System.IO.File.WriteAllText(filePath, HomeScreen.Current.showCodeBuilder());

                        
                    }
                    catch
                    {
                        //couldnt create file
                        MessageBox.Show("error creating file");
                    }

                }

            }

        }

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}