using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiScriptor
{
    class PanelGalaxies : Panel
    {
        private Panel panelGalaxiesTest;
        //public System.Windows.Forms.Panel panelGalaxies;
        public PanelGalaxies()
        {
            //panelGalaxies = new System.Windows.Forms.Panel();
            //panelGalaxies = fillPanel(panelGalaxies);

            InitializeComponent();
        }

        public Panel fillPanel(Panel panelGalaxies)
        { 
            Button btnSubmitGalaxy = new System.Windows.Forms.Button();
            Label lblGalaxiesOutput = new System.Windows.Forms.Label();
            Button btnGalaxiesBack = new System.Windows.Forms.Button();
            Label lblGalaxyDestination = new System.Windows.Forms.Label();
            Label lblGalaxyFavorites = new System.Windows.Forms.Label();
            Button btnTriangulum = new System.Windows.Forms.Button();
            Button btnWhirlpool = new System.Windows.Forms.Button();
            Button btnLargeMagCloud = new System.Windows.Forms.Button();
            Button btnSombrero = new System.Windows.Forms.Button();
            Button btnMilkyWay = new System.Windows.Forms.Button();
            ComboBox comboBoxGalaxies = new System.Windows.Forms.ComboBox();
            Label lblGalaxies = new System.Windows.Forms.Label();
            Button btnAndromeda = new System.Windows.Forms.Button();

            // 
            // btnSubmitGalaxy
            // 
            btnSubmitGalaxy.BackColor = System.Drawing.Color.DimGray;
            btnSubmitGalaxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmitGalaxy.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSubmitGalaxy.ForeColor = System.Drawing.Color.SpringGreen;
            btnSubmitGalaxy.Location = new System.Drawing.Point(769, 490);
            btnSubmitGalaxy.Name = "btnSubmitGalaxy";
            btnSubmitGalaxy.Size = new System.Drawing.Size(186, 75);
            btnSubmitGalaxy.TabIndex = 29;
            btnSubmitGalaxy.Text = "Submit";
            btnSubmitGalaxy.UseVisualStyleBackColor = false;
            // 
            // lblGalaxiesOutput
            // 
            lblGalaxiesOutput.AutoSize = true;
            lblGalaxiesOutput.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGalaxiesOutput.ForeColor = System.Drawing.SystemColors.Menu;
            lblGalaxiesOutput.Location = new System.Drawing.Point(758, 386);
            lblGalaxiesOutput.Name = "lblGalaxiesOutput";
            lblGalaxiesOutput.Size = new System.Drawing.Size(213, 43);
            lblGalaxiesOutput.TabIndex = 28;
            lblGalaxiesOutput.Text = "(Some Galaxy)";
            // 
            // btnGalaxiesBack
            // 
            btnGalaxiesBack.BackColor = System.Drawing.Color.Gray;
            btnGalaxiesBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGalaxiesBack.Location = new System.Drawing.Point(34, 930);
            btnGalaxiesBack.Name = "btnGalaxiesBack";
            btnGalaxiesBack.Size = new System.Drawing.Size(85, 39);
            btnGalaxiesBack.TabIndex = 27;
            btnGalaxiesBack.Text = "Back";
            btnGalaxiesBack.UseVisualStyleBackColor = false;
            //btnGalaxiesBack.Click += new System.EventHandler(this.btnGalaxiesBack_Click);
            // 
            // lblGalaxyDestination
            // 
            lblGalaxyDestination.AutoSize = true;
            lblGalaxyDestination.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGalaxyDestination.ForeColor = System.Drawing.SystemColors.Menu;
            lblGalaxyDestination.Location = new System.Drawing.Point(772, 312);
            lblGalaxyDestination.Name = "lblGalaxyDestination";
            lblGalaxyDestination.Size = new System.Drawing.Size(183, 43);
            lblGalaxyDestination.TabIndex = 26;
            lblGalaxyDestination.Text = "Destination:";
            // 
            // lblGalaxyFavorites
            // 
            lblGalaxyFavorites.AutoSize = true;
            lblGalaxyFavorites.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGalaxyFavorites.ForeColor = System.Drawing.SystemColors.Menu;
            lblGalaxyFavorites.Location = new System.Drawing.Point(292, 157);
            lblGalaxyFavorites.Name = "lblGalaxyFavorites";
            lblGalaxyFavorites.Size = new System.Drawing.Size(143, 43);
            lblGalaxyFavorites.TabIndex = 25;
            lblGalaxyFavorites.Text = "Favorites";
            // 
            // btnTriangulum
            // 
            btnTriangulum.BackColor = System.Drawing.Color.DimGray;
            btnTriangulum.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTriangulum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnTriangulum.Location = new System.Drawing.Point(391, 478);
            btnTriangulum.Name = "btnTriangulum";
            btnTriangulum.Size = new System.Drawing.Size(197, 87);
            btnTriangulum.TabIndex = 24;
            btnTriangulum.Text = "Triangulum";
            btnTriangulum.UseVisualStyleBackColor = false;
            // 
            // btnWhirlpool
            // 
            btnWhirlpool.BackColor = System.Drawing.Color.DimGray;
            btnWhirlpool.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnWhirlpool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnWhirlpool.Location = new System.Drawing.Point(391, 355);
            btnWhirlpool.Name = "btnWhirlpool";
            btnWhirlpool.Size = new System.Drawing.Size(197, 87);
            btnWhirlpool.TabIndex = 23;
            btnWhirlpool.Text = "Whirlpool";
            btnWhirlpool.UseVisualStyleBackColor = false;
            // 
            // btnLargeMagCloud
            // 
            btnLargeMagCloud.BackColor = System.Drawing.Color.DimGray;
            btnLargeMagCloud.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLargeMagCloud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnLargeMagCloud.Location = new System.Drawing.Point(138, 355);
            btnLargeMagCloud.Name = "btnLargeMagCloud";
            btnLargeMagCloud.Size = new System.Drawing.Size(197, 87);
            btnLargeMagCloud.TabIndex = 22;
            btnLargeMagCloud.Text = "Large Magellanic Cloud";
            btnLargeMagCloud.UseVisualStyleBackColor = false;
            // 
            // btnSombrero
            // 
            btnSombrero.BackColor = System.Drawing.Color.DimGray;
            btnSombrero.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSombrero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnSombrero.Location = new System.Drawing.Point(138, 478);
            btnSombrero.Name = "btnSombrero";
            btnSombrero.Size = new System.Drawing.Size(197, 87);
            btnSombrero.TabIndex = 21;
            btnSombrero.Text = "Sombrero";
            btnSombrero.UseVisualStyleBackColor = false;
            // 
            // btnMilkyWay
            // 
            btnMilkyWay.BackColor = System.Drawing.Color.DimGray;
            btnMilkyWay.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMilkyWay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnMilkyWay.Location = new System.Drawing.Point(138, 225);
            btnMilkyWay.Name = "btnMilkyWay";
            btnMilkyWay.Size = new System.Drawing.Size(197, 87);
            btnMilkyWay.TabIndex = 20;
            btnMilkyWay.Text = "Milky Way";
            btnMilkyWay.UseVisualStyleBackColor = false;
            // 
            // comboBoxGalaxies
            // 
            comboBoxGalaxies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBoxGalaxies.FormattingEnabled = true;
            comboBoxGalaxies.Location = new System.Drawing.Point(718, 164);
            comboBoxGalaxies.Name = "comboBoxGalaxies";
            comboBoxGalaxies.Size = new System.Drawing.Size(296, 37);
            comboBoxGalaxies.Sorted = true;
            comboBoxGalaxies.TabIndex = 19;
            // 
            // lblGalaxies
            // 
            lblGalaxies.AutoSize = true;
            lblGalaxies.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGalaxies.ForeColor = System.Drawing.SystemColors.ControlDark;
            lblGalaxies.Location = new System.Drawing.Point(22, 42);
            lblGalaxies.Name = "lblGalaxies";
            lblGalaxies.Size = new System.Drawing.Size(211, 67);
            lblGalaxies.TabIndex = 18;
            lblGalaxies.Text = "Galaxies";
            // 
            // btnAndromeda
            // 
            btnAndromeda.BackColor = System.Drawing.Color.DimGray;
            btnAndromeda.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAndromeda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAndromeda.Location = new System.Drawing.Point(391, 225);
            btnAndromeda.Name = "btnAndromeda";
            btnAndromeda.Size = new System.Drawing.Size(197, 87);
            btnAndromeda.TabIndex = 17;
            btnAndromeda.Text = "Andromeda";
            btnAndromeda.UseVisualStyleBackColor = false;


            panelGalaxies.Controls.Add(btnSubmitGalaxy);
            panelGalaxies.Controls.Add(lblGalaxiesOutput);
            panelGalaxies.Controls.Add(btnGalaxiesBack);
            panelGalaxies.Controls.Add(lblGalaxyDestination);
            panelGalaxies.Controls.Add(lblGalaxyFavorites);
            panelGalaxies.Controls.Add(btnTriangulum);
            panelGalaxies.Controls.Add(btnWhirlpool);
            panelGalaxies.Controls.Add(btnLargeMagCloud);
            panelGalaxies.Controls.Add(btnSombrero);
            panelGalaxies.Controls.Add(btnMilkyWay);
            panelGalaxies.Controls.Add(comboBoxGalaxies);
            panelGalaxies.Controls.Add(lblGalaxies);
            panelGalaxies.Controls.Add(btnAndromeda);
            panelGalaxies.Location = new System.Drawing.Point(10, 0);
            panelGalaxies.Name = "panelGalaxies2";
            panelGalaxies.Size = new System.Drawing.Size(1062, 997);
            panelGalaxies.TabIndex = 26;

            return panelGalaxies;
        }

        private void InitializeComponent()
        {
            this.panelGalaxiesTest = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelGalaxiesTest
            // 
            this.panelGalaxiesTest.Location = new System.Drawing.Point(0, 0);
            this.panelGalaxiesTest.Name = "panelGalaxiesTest";
            this.panelGalaxiesTest.Size = new System.Drawing.Size(200, 100);
            this.panelGalaxiesTest.TabIndex = 0;
            //this.ResumeLayout(false);

            Button btnSubmitGalaxy = new System.Windows.Forms.Button();
            Label lblGalaxiesOutput = new System.Windows.Forms.Label();
            Button btnGalaxiesBack = new System.Windows.Forms.Button();
            Label lblGalaxyDestination = new System.Windows.Forms.Label();
            Label lblGalaxyFavorites = new System.Windows.Forms.Label();
            Button btnTriangulum = new System.Windows.Forms.Button();
            Button btnWhirlpool = new System.Windows.Forms.Button();
            Button btnLargeMagCloud = new System.Windows.Forms.Button();
            Button btnSombrero = new System.Windows.Forms.Button();
            Button btnMilkyWay = new System.Windows.Forms.Button();
            ComboBox comboBoxGalaxies = new System.Windows.Forms.ComboBox();
            Label lblGalaxies = new System.Windows.Forms.Label();
            Button btnAndromeda = new System.Windows.Forms.Button();

            // 
            // btnSubmitGalaxy
            // 
            btnSubmitGalaxy.BackColor = System.Drawing.Color.DimGray;
            btnSubmitGalaxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSubmitGalaxy.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSubmitGalaxy.ForeColor = System.Drawing.Color.SpringGreen;
            btnSubmitGalaxy.Location = new System.Drawing.Point(769, 490);
            btnSubmitGalaxy.Name = "btnSubmitGalaxy";
            btnSubmitGalaxy.Size = new System.Drawing.Size(186, 75);
            btnSubmitGalaxy.TabIndex = 29;
            btnSubmitGalaxy.Text = "Submit";
            btnSubmitGalaxy.UseVisualStyleBackColor = false;
            // 
            // lblGalaxiesOutput
            // 
            lblGalaxiesOutput.AutoSize = true;
            lblGalaxiesOutput.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGalaxiesOutput.ForeColor = System.Drawing.SystemColors.Menu;
            lblGalaxiesOutput.Location = new System.Drawing.Point(758, 386);
            lblGalaxiesOutput.Name = "lblGalaxiesOutput";
            lblGalaxiesOutput.Size = new System.Drawing.Size(213, 43);
            lblGalaxiesOutput.TabIndex = 28;
            lblGalaxiesOutput.Text = "(Some Galaxy)";
            // 
            // btnGalaxiesBack
            // 
            btnGalaxiesBack.BackColor = System.Drawing.Color.Gray;
            btnGalaxiesBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGalaxiesBack.Location = new System.Drawing.Point(34, 930);
            btnGalaxiesBack.Name = "btnGalaxiesBack";
            btnGalaxiesBack.Size = new System.Drawing.Size(85, 39);
            btnGalaxiesBack.TabIndex = 27;
            btnGalaxiesBack.Text = "Back";
            btnGalaxiesBack.UseVisualStyleBackColor = false;
            //btnGalaxiesBack.Click += new System.EventHandler(this.btnGalaxiesBack_Click);
            // 
            // lblGalaxyDestination
            // 
            lblGalaxyDestination.AutoSize = true;
            lblGalaxyDestination.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGalaxyDestination.ForeColor = System.Drawing.SystemColors.Menu;
            lblGalaxyDestination.Location = new System.Drawing.Point(772, 312);
            lblGalaxyDestination.Name = "lblGalaxyDestination";
            lblGalaxyDestination.Size = new System.Drawing.Size(183, 43);
            lblGalaxyDestination.TabIndex = 26;
            lblGalaxyDestination.Text = "Destination:";
            // 
            // lblGalaxyFavorites
            // 
            lblGalaxyFavorites.AutoSize = true;
            lblGalaxyFavorites.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGalaxyFavorites.ForeColor = System.Drawing.SystemColors.Menu;
            lblGalaxyFavorites.Location = new System.Drawing.Point(292, 157);
            lblGalaxyFavorites.Name = "lblGalaxyFavorites";
            lblGalaxyFavorites.Size = new System.Drawing.Size(143, 43);
            lblGalaxyFavorites.TabIndex = 25;
            lblGalaxyFavorites.Text = "Favorites";
            // 
            // btnTriangulum
            // 
            btnTriangulum.BackColor = System.Drawing.Color.DimGray;
            btnTriangulum.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTriangulum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnTriangulum.Location = new System.Drawing.Point(391, 478);
            btnTriangulum.Name = "btnTriangulum";
            btnTriangulum.Size = new System.Drawing.Size(197, 87);
            btnTriangulum.TabIndex = 24;
            btnTriangulum.Text = "Triangulum";
            btnTriangulum.UseVisualStyleBackColor = false;
            // 
            // btnWhirlpool
            // 
            btnWhirlpool.BackColor = System.Drawing.Color.DimGray;
            btnWhirlpool.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnWhirlpool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnWhirlpool.Location = new System.Drawing.Point(391, 355);
            btnWhirlpool.Name = "btnWhirlpool";
            btnWhirlpool.Size = new System.Drawing.Size(197, 87);
            btnWhirlpool.TabIndex = 23;
            btnWhirlpool.Text = "Whirlpool";
            btnWhirlpool.UseVisualStyleBackColor = false;
            // 
            // btnLargeMagCloud
            // 
            btnLargeMagCloud.BackColor = System.Drawing.Color.DimGray;
            btnLargeMagCloud.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLargeMagCloud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnLargeMagCloud.Location = new System.Drawing.Point(138, 355);
            btnLargeMagCloud.Name = "btnLargeMagCloud";
            btnLargeMagCloud.Size = new System.Drawing.Size(197, 87);
            btnLargeMagCloud.TabIndex = 22;
            btnLargeMagCloud.Text = "Large Magellanic Cloud";
            btnLargeMagCloud.UseVisualStyleBackColor = false;
            // 
            // btnSombrero
            // 
            btnSombrero.BackColor = System.Drawing.Color.DimGray;
            btnSombrero.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSombrero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnSombrero.Location = new System.Drawing.Point(138, 478);
            btnSombrero.Name = "btnSombrero";
            btnSombrero.Size = new System.Drawing.Size(197, 87);
            btnSombrero.TabIndex = 21;
            btnSombrero.Text = "Sombrero";
            btnSombrero.UseVisualStyleBackColor = false;
            // 
            // btnMilkyWay
            // 
            btnMilkyWay.BackColor = System.Drawing.Color.DimGray;
            btnMilkyWay.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnMilkyWay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnMilkyWay.Location = new System.Drawing.Point(138, 225);
            btnMilkyWay.Name = "btnMilkyWay";
            btnMilkyWay.Size = new System.Drawing.Size(197, 87);
            btnMilkyWay.TabIndex = 20;
            btnMilkyWay.Text = "Milky Way";
            btnMilkyWay.UseVisualStyleBackColor = false;
            // 
            // comboBoxGalaxies
            // 
            comboBoxGalaxies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBoxGalaxies.FormattingEnabled = true;
            comboBoxGalaxies.Location = new System.Drawing.Point(718, 164);
            comboBoxGalaxies.Name = "comboBoxGalaxies";
            comboBoxGalaxies.Size = new System.Drawing.Size(296, 37);
            comboBoxGalaxies.Sorted = true;
            comboBoxGalaxies.TabIndex = 19;
            // 
            // lblGalaxies
            // 
            lblGalaxies.AutoSize = true;
            lblGalaxies.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGalaxies.ForeColor = System.Drawing.SystemColors.ControlDark;
            lblGalaxies.Location = new System.Drawing.Point(22, 42);
            lblGalaxies.Name = "lblGalaxies";
            lblGalaxies.Size = new System.Drawing.Size(211, 67);
            lblGalaxies.TabIndex = 18;
            lblGalaxies.Text = "Galaxies";
            // 
            // btnAndromeda
            // 
            btnAndromeda.BackColor = System.Drawing.Color.DimGray;
            btnAndromeda.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAndromeda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAndromeda.Location = new System.Drawing.Point(391, 225);
            btnAndromeda.Name = "btnAndromeda";
            btnAndromeda.Size = new System.Drawing.Size(197, 87);
            btnAndromeda.TabIndex = 17;
            btnAndromeda.Text = "Andromeda";
            btnAndromeda.UseVisualStyleBackColor = false;


            this.panelGalaxiesTest.Controls.Add(btnSubmitGalaxy);
            this.panelGalaxiesTest.Controls.Add(lblGalaxiesOutput);
            this.panelGalaxiesTest.Controls.Add(btnGalaxiesBack);
            this.panelGalaxiesTest.Controls.Add(lblGalaxyDestination);
            this.panelGalaxiesTest.Controls.Add(lblGalaxyFavorites);
            this.panelGalaxiesTest.Controls.Add(btnTriangulum);
            this.panelGalaxiesTest.Controls.Add(btnWhirlpool);
            this.panelGalaxiesTest.Controls.Add(btnLargeMagCloud);
            this.panelGalaxiesTest.Controls.Add(btnSombrero);
            this.panelGalaxiesTest.Controls.Add(btnMilkyWay);
            this.panelGalaxiesTest.Controls.Add(comboBoxGalaxies);
            this.panelGalaxiesTest.Controls.Add(lblGalaxies);
            this.panelGalaxiesTest.Controls.Add(btnAndromeda);
            this.panelGalaxiesTest.Location = new System.Drawing.Point(10, 0);
            this.panelGalaxiesTest.Name = "panelGalaxies2";
            this.panelGalaxiesTest.Size = new System.Drawing.Size(1062, 997);
            this.panelGalaxiesTest.TabIndex = 26;

            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
