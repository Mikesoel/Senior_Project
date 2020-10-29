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
        private Button btnSubmitGalaxy;
        private Label lblGalaxiesOutput;
        private Button btnGalaxiesBack;
        private Label lblGalaxyDestination;
        private Label lblGalaxyFavorites;
        private Button btnTriangulum;
        private Button btnWhirlpool;
        private Button btnLargeMagCloud;
        private Button btnSombrero;
        private Button btnMilkyWay;
        private ComboBox comboBoxGalaxies;
        private Label lblGalaxies;
        private Button btnAndromeda;
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
            this.btnSubmitGalaxy = new System.Windows.Forms.Button();
            this.lblGalaxiesOutput = new System.Windows.Forms.Label();
            this.btnGalaxiesBack = new System.Windows.Forms.Button();
            this.lblGalaxyDestination = new System.Windows.Forms.Label();
            this.lblGalaxyFavorites = new System.Windows.Forms.Label();
            this.btnTriangulum = new System.Windows.Forms.Button();
            this.btnWhirlpool = new System.Windows.Forms.Button();
            this.btnLargeMagCloud = new System.Windows.Forms.Button();
            this.btnSombrero = new System.Windows.Forms.Button();
            this.btnMilkyWay = new System.Windows.Forms.Button();
            this.comboBoxGalaxies = new System.Windows.Forms.ComboBox();
            this.lblGalaxies = new System.Windows.Forms.Label();
            this.btnAndromeda = new System.Windows.Forms.Button();
            this.panelGalaxiesTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGalaxiesTest
            // 
            this.panelGalaxiesTest.Controls.Add(this.btnSubmitGalaxy);
            this.panelGalaxiesTest.Controls.Add(this.lblGalaxiesOutput);
            this.panelGalaxiesTest.Controls.Add(this.btnGalaxiesBack);
            this.panelGalaxiesTest.Controls.Add(this.lblGalaxyDestination);
            this.panelGalaxiesTest.Controls.Add(this.lblGalaxyFavorites);
            this.panelGalaxiesTest.Controls.Add(this.btnTriangulum);
            this.panelGalaxiesTest.Controls.Add(this.btnWhirlpool);
            this.panelGalaxiesTest.Controls.Add(this.btnLargeMagCloud);
            this.panelGalaxiesTest.Controls.Add(this.btnSombrero);
            this.panelGalaxiesTest.Controls.Add(this.btnMilkyWay);
            this.panelGalaxiesTest.Controls.Add(this.comboBoxGalaxies);
            this.panelGalaxiesTest.Controls.Add(this.lblGalaxies);
            this.panelGalaxiesTest.Controls.Add(this.btnAndromeda);
            this.panelGalaxiesTest.Location = new System.Drawing.Point(10, 0);
            this.panelGalaxiesTest.Name = "panelGalaxiesTest";
            this.panelGalaxiesTest.Size = new System.Drawing.Size(1062, 997);
            this.panelGalaxiesTest.TabIndex = 26;
            // 
            // btnSubmitGalaxy
            // 
            this.btnSubmitGalaxy.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitGalaxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitGalaxy.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitGalaxy.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitGalaxy.Location = new System.Drawing.Point(769, 490);
            this.btnSubmitGalaxy.Name = "btnSubmitGalaxy";
            this.btnSubmitGalaxy.Size = new System.Drawing.Size(186, 75);
            this.btnSubmitGalaxy.TabIndex = 29;
            this.btnSubmitGalaxy.Text = "Submit";
            this.btnSubmitGalaxy.UseVisualStyleBackColor = false;
            // 
            // lblGalaxiesOutput
            // 
            this.lblGalaxiesOutput.AutoSize = true;
            this.lblGalaxiesOutput.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalaxiesOutput.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblGalaxiesOutput.Location = new System.Drawing.Point(758, 386);
            this.lblGalaxiesOutput.Name = "lblGalaxiesOutput";
            this.lblGalaxiesOutput.Size = new System.Drawing.Size(175, 36);
            this.lblGalaxiesOutput.TabIndex = 28;
            this.lblGalaxiesOutput.Text = "(Some Galaxy)";
            // 
            // btnGalaxiesBack
            // 
            this.btnGalaxiesBack.BackColor = System.Drawing.Color.Gray;
            this.btnGalaxiesBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGalaxiesBack.Location = new System.Drawing.Point(34, 930);
            this.btnGalaxiesBack.Name = "btnGalaxiesBack";
            this.btnGalaxiesBack.Size = new System.Drawing.Size(85, 39);
            this.btnGalaxiesBack.TabIndex = 27;
            this.btnGalaxiesBack.Text = "Back";
            this.btnGalaxiesBack.UseVisualStyleBackColor = false;
            // 
            // lblGalaxyDestination
            // 
            this.lblGalaxyDestination.AutoSize = true;
            this.lblGalaxyDestination.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalaxyDestination.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblGalaxyDestination.Location = new System.Drawing.Point(772, 312);
            this.lblGalaxyDestination.Name = "lblGalaxyDestination";
            this.lblGalaxyDestination.Size = new System.Drawing.Size(153, 36);
            this.lblGalaxyDestination.TabIndex = 26;
            this.lblGalaxyDestination.Text = "Destination:";
            // 
            // lblGalaxyFavorites
            // 
            this.lblGalaxyFavorites.AutoSize = true;
            this.lblGalaxyFavorites.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalaxyFavorites.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblGalaxyFavorites.Location = new System.Drawing.Point(292, 157);
            this.lblGalaxyFavorites.Name = "lblGalaxyFavorites";
            this.lblGalaxyFavorites.Size = new System.Drawing.Size(117, 36);
            this.lblGalaxyFavorites.TabIndex = 25;
            this.lblGalaxyFavorites.Text = "Favorites";
            // 
            // btnTriangulum
            // 
            this.btnTriangulum.BackColor = System.Drawing.Color.DimGray;
            this.btnTriangulum.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriangulum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTriangulum.Location = new System.Drawing.Point(391, 478);
            this.btnTriangulum.Name = "btnTriangulum";
            this.btnTriangulum.Size = new System.Drawing.Size(197, 87);
            this.btnTriangulum.TabIndex = 24;
            this.btnTriangulum.Text = "Triangulum";
            this.btnTriangulum.UseVisualStyleBackColor = false;
            // 
            // btnWhirlpool
            // 
            this.btnWhirlpool.BackColor = System.Drawing.Color.DimGray;
            this.btnWhirlpool.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhirlpool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWhirlpool.Location = new System.Drawing.Point(391, 355);
            this.btnWhirlpool.Name = "btnWhirlpool";
            this.btnWhirlpool.Size = new System.Drawing.Size(197, 87);
            this.btnWhirlpool.TabIndex = 23;
            this.btnWhirlpool.Text = "Whirlpool";
            this.btnWhirlpool.UseVisualStyleBackColor = false;
            // 
            // btnLargeMagCloud
            // 
            this.btnLargeMagCloud.BackColor = System.Drawing.Color.DimGray;
            this.btnLargeMagCloud.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargeMagCloud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLargeMagCloud.Location = new System.Drawing.Point(138, 355);
            this.btnLargeMagCloud.Name = "btnLargeMagCloud";
            this.btnLargeMagCloud.Size = new System.Drawing.Size(197, 87);
            this.btnLargeMagCloud.TabIndex = 22;
            this.btnLargeMagCloud.Text = "Large Magellanic Cloud";
            this.btnLargeMagCloud.UseVisualStyleBackColor = false;
            // 
            // btnSombrero
            // 
            this.btnSombrero.BackColor = System.Drawing.Color.DimGray;
            this.btnSombrero.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSombrero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSombrero.Location = new System.Drawing.Point(138, 478);
            this.btnSombrero.Name = "btnSombrero";
            this.btnSombrero.Size = new System.Drawing.Size(197, 87);
            this.btnSombrero.TabIndex = 21;
            this.btnSombrero.Text = "Sombrero";
            this.btnSombrero.UseVisualStyleBackColor = false;
            // 
            // btnMilkyWay
            // 
            this.btnMilkyWay.BackColor = System.Drawing.Color.DimGray;
            this.btnMilkyWay.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilkyWay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMilkyWay.Location = new System.Drawing.Point(138, 225);
            this.btnMilkyWay.Name = "btnMilkyWay";
            this.btnMilkyWay.Size = new System.Drawing.Size(197, 87);
            this.btnMilkyWay.TabIndex = 20;
            this.btnMilkyWay.Text = "Milky Way";
            this.btnMilkyWay.UseVisualStyleBackColor = false;
            // 
            // comboBoxGalaxies
            // 
            this.comboBoxGalaxies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGalaxies.FormattingEnabled = true;
            this.comboBoxGalaxies.Location = new System.Drawing.Point(718, 164);
            this.comboBoxGalaxies.Name = "comboBoxGalaxies";
            this.comboBoxGalaxies.Size = new System.Drawing.Size(296, 33);
            this.comboBoxGalaxies.Sorted = true;
            this.comboBoxGalaxies.TabIndex = 19;
            // 
            // lblGalaxies
            // 
            this.lblGalaxies.AutoSize = true;
            this.lblGalaxies.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalaxies.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblGalaxies.Location = new System.Drawing.Point(22, 42);
            this.lblGalaxies.Name = "lblGalaxies";
            this.lblGalaxies.Size = new System.Drawing.Size(176, 55);
            this.lblGalaxies.TabIndex = 18;
            this.lblGalaxies.Text = "Galaxies";
            // 
            // btnAndromeda
            // 
            this.btnAndromeda.BackColor = System.Drawing.Color.DimGray;
            this.btnAndromeda.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndromeda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAndromeda.Location = new System.Drawing.Point(391, 225);
            this.btnAndromeda.Name = "btnAndromeda";
            this.btnAndromeda.Size = new System.Drawing.Size(197, 87);
            this.btnAndromeda.TabIndex = 17;
            this.btnAndromeda.Text = "Andromeda";
            this.btnAndromeda.UseVisualStyleBackColor = false;
            this.panelGalaxiesTest.ResumeLayout(false);
            this.panelGalaxiesTest.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}
