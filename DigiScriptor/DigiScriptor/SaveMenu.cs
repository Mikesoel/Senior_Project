using System;
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



        public SaveMenu()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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
                    
                    MessageBox.Show("file exist");

                    try
                    {
                        fs = File.OpenWrite(filePath);




                        fs.Close();
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
                        fs = File.Create(filePath);





                        fs.Close();
                    }
                    catch
                    {
                        //couldnt create file
                        MessageBox.Show("error creating file");
                    }

                }

            }

        }











    }
}
