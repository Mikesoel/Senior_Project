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
            saveFileDialog.Filter = "DigiStarScript files (*.ds)|*.ds";
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
                try
                {
                    //create new file and then write code to it
                    System.IO.File.WriteAllText(filePath, HomeScreen.Current.showCodeBuilder());
                    
                    //close save menu after file is created
                    this.Close();
                }
                catch
                {
                    //couldnt create file
                    MessageBox.Show("error creating file");
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoctxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
