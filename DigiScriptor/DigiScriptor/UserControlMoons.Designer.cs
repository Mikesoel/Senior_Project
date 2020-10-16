namespace DigiScriptor
{
    partial class UserControlMoons
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMoons = new System.Windows.Forms.Panel();
            this.btnMoonsBack = new System.Windows.Forms.Button();
            this.labelMoons = new System.Windows.Forms.Label();
            this.lblMoonFav = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.editPopularLocationsButton = new System.Windows.Forms.Button();
            this.lblSelectMoonPlanet = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelMoons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMoons
            // 
            this.panelMoons.Controls.Add(this.listView1);
            this.panelMoons.Controls.Add(this.comboBox2);
            this.panelMoons.Controls.Add(this.lblSelectMoonPlanet);
            this.panelMoons.Controls.Add(this.editPopularLocationsButton);
            this.panelMoons.Controls.Add(this.comboBox1);
            this.panelMoons.Controls.Add(this.lblMoonFav);
            this.panelMoons.Controls.Add(this.btnMoonsBack);
            this.panelMoons.Controls.Add(this.labelMoons);
            this.panelMoons.Location = new System.Drawing.Point(0, 0);
            this.panelMoons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMoons.Name = "panelMoons";
            this.panelMoons.Size = new System.Drawing.Size(708, 648);
            this.panelMoons.TabIndex = 27;
            // 
            // btnMoonsBack
            // 
            this.btnMoonsBack.BackColor = System.Drawing.Color.Gray;
            this.btnMoonsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoonsBack.Location = new System.Drawing.Point(21, 608);
            this.btnMoonsBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoonsBack.Name = "btnMoonsBack";
            this.btnMoonsBack.Size = new System.Drawing.Size(57, 25);
            this.btnMoonsBack.TabIndex = 29;
            this.btnMoonsBack.Text = "Back";
            this.btnMoonsBack.UseVisualStyleBackColor = false;
            // 
            // labelMoons
            // 
            this.labelMoons.AutoSize = true;
            this.labelMoons.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoons.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelMoons.Location = new System.Drawing.Point(15, 27);
            this.labelMoons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoons.Name = "labelMoons";
            this.labelMoons.Size = new System.Drawing.Size(110, 45);
            this.labelMoons.TabIndex = 3;
            this.labelMoons.Text = "Moons";
            // 
            // lblMoonFav
            // 
            this.lblMoonFav.AutoSize = true;
            this.lblMoonFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblMoonFav.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblMoonFav.Location = new System.Drawing.Point(20, 104);
            this.lblMoonFav.Name = "lblMoonFav";
            this.lblMoonFav.Size = new System.Drawing.Size(133, 22);
            this.lblMoonFav.TabIndex = 30;
            this.lblMoonFav.Text = "Favorite moons";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Luna",
            "Io",
            "Titan"});
            this.comboBox1.Location = new System.Drawing.Point(159, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // editPopularLocationsButton
            // 
            this.editPopularLocationsButton.Location = new System.Drawing.Point(301, 105);
            this.editPopularLocationsButton.Name = "editPopularLocationsButton";
            this.editPopularLocationsButton.Size = new System.Drawing.Size(75, 23);
            this.editPopularLocationsButton.TabIndex = 32;
            this.editPopularLocationsButton.Text = "Add/Edit";
            this.editPopularLocationsButton.UseVisualStyleBackColor = true;
            // 
            // lblSelectMoonPlanet
            // 
            this.lblSelectMoonPlanet.AutoSize = true;
            this.lblSelectMoonPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblSelectMoonPlanet.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblSelectMoonPlanet.Location = new System.Drawing.Point(20, 195);
            this.lblSelectMoonPlanet.Name = "lblSelectMoonPlanet";
            this.lblSelectMoonPlanet.Size = new System.Drawing.Size(121, 22);
            this.lblSelectMoonPlanet.TabIndex = 33;
            this.lblSelectMoonPlanet.Text = "Sort by planet";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Earth",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune",
            "All"});
            this.comboBox2.Location = new System.Drawing.Point(159, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 34;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 256);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 321);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UserControlMoons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelMoons);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlMoons";
            this.Size = new System.Drawing.Size(708, 648);
            this.panelMoons.ResumeLayout(false);
            this.panelMoons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMoons;
        public System.Windows.Forms.Button btnMoonsBack;
        private System.Windows.Forms.Label labelMoons;
        private System.Windows.Forms.Label lblMoonFav;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblSelectMoonPlanet;
        private System.Windows.Forms.Button editPopularLocationsButton;
    }
}
