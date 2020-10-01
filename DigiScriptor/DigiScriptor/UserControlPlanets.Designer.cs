namespace DigiScriptor
{
    partial class UserControlPlanets
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
            this.panelPlanets = new System.Windows.Forms.Panel();
            this.lblPlanetSelectionDropdown = new System.Windows.Forms.Label();
            this.planetDropdown = new System.Windows.Forms.ComboBox();
            this.btnPlanetsBack = new System.Windows.Forms.Button();
            this.labelPlanets = new System.Windows.Forms.Label();
            this.orbitRadio = new System.Windows.Forms.RadioButton();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rotationRadio = new System.Windows.Forms.RadioButton();
            this.panelPlanets.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlanets
            // 
            this.panelPlanets.Controls.Add(this.textBox1);
            this.panelPlanets.Controls.Add(this.rotationRadio);
            this.panelPlanets.Controls.Add(this.textBoxLatitude);
            this.panelPlanets.Controls.Add(this.orbitRadio);
            this.panelPlanets.Controls.Add(this.lblPlanetSelectionDropdown);
            this.panelPlanets.Controls.Add(this.planetDropdown);
            this.panelPlanets.Controls.Add(this.btnPlanetsBack);
            this.panelPlanets.Controls.Add(this.labelPlanets);
            this.panelPlanets.Location = new System.Drawing.Point(0, 0);
            this.panelPlanets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPlanets.Name = "panelPlanets";
            this.panelPlanets.Size = new System.Drawing.Size(944, 798);
            this.panelPlanets.TabIndex = 27;
            // 
            // lblPlanetSelectionDropdown
            // 
            this.lblPlanetSelectionDropdown.AutoSize = true;
            this.lblPlanetSelectionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetSelectionDropdown.Location = new System.Drawing.Point(25, 118);
            this.lblPlanetSelectionDropdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanetSelectionDropdown.Name = "lblPlanetSelectionDropdown";
            this.lblPlanetSelectionDropdown.Size = new System.Drawing.Size(174, 25);
            this.lblPlanetSelectionDropdown.TabIndex = 32;
            this.lblPlanetSelectionDropdown.Text = "Planet Selections: ";
            // 
            // planetDropdown
            // 
            this.planetDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetDropdown.FormattingEnabled = true;
            this.planetDropdown.Items.AddRange(new object[] {
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune",
            "Dwarf Planet"});
            this.planetDropdown.Location = new System.Drawing.Point(211, 119);
            this.planetDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.planetDropdown.MaxDropDownItems = 20;
            this.planetDropdown.Name = "planetDropdown";
            this.planetDropdown.Size = new System.Drawing.Size(197, 28);
            this.planetDropdown.TabIndex = 31;
            this.planetDropdown.Text = "Select a Planet";
            // 
            // btnPlanetsBack
            // 
            this.btnPlanetsBack.BackColor = System.Drawing.Color.Gray;
            this.btnPlanetsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanetsBack.Location = new System.Drawing.Point(28, 749);
            this.btnPlanetsBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlanetsBack.Name = "btnPlanetsBack";
            this.btnPlanetsBack.Size = new System.Drawing.Size(76, 31);
            this.btnPlanetsBack.TabIndex = 30;
            this.btnPlanetsBack.Text = "Back";
            this.btnPlanetsBack.UseVisualStyleBackColor = false;
            // 
            // labelPlanets
            // 
            this.labelPlanets.AutoSize = true;
            this.labelPlanets.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanets.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlanets.Location = new System.Drawing.Point(20, 34);
            this.labelPlanets.Name = "labelPlanets";
            this.labelPlanets.Size = new System.Drawing.Size(157, 55);
            this.labelPlanets.TabIndex = 3;
            this.labelPlanets.Text = "Planets";
            // 
            // orbitRadio
            // 
            this.orbitRadio.AutoSize = true;
            this.orbitRadio.Location = new System.Drawing.Point(28, 177);
            this.orbitRadio.Margin = new System.Windows.Forms.Padding(4);
            this.orbitRadio.Name = "northRadio";
            this.orbitRadio.Size = new System.Drawing.Size(109, 21);
            this.orbitRadio.TabIndex = 34;
            this.orbitRadio.TabStop = true;
            this.orbitRadio.Text = "Orbit Speed:";
            this.orbitRadio.UseVisualStyleBackColor = true;
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(145, 177);
            this.textBoxLatitude.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(132, 22);
            this.textBoxLatitude.TabIndex = 35;
            this.textBoxLatitude.Text = "Enter Latitude";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 223);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "Enter Latitude";
            // 
            // rotationRadio
            // 
            this.rotationRadio.AutoSize = true;
            this.rotationRadio.Location = new System.Drawing.Point(28, 223);
            this.rotationRadio.Margin = new System.Windows.Forms.Padding(4);
            this.rotationRadio.Name = "radioButton1";
            this.rotationRadio.Size = new System.Drawing.Size(127, 21);
            this.rotationRadio.TabIndex = 36;
            this.rotationRadio.TabStop = true;
            this.rotationRadio.Text = "Rotation Speed";
            this.rotationRadio.UseVisualStyleBackColor = true;
            // 
            // UserControlPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelPlanets);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlPlanets";
            this.Size = new System.Drawing.Size(944, 798);
            this.panelPlanets.ResumeLayout(false);
            this.panelPlanets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlanets;
        public System.Windows.Forms.Button btnPlanetsBack;
        private System.Windows.Forms.Label labelPlanets;
        private System.Windows.Forms.ComboBox planetDropdown;
        private System.Windows.Forms.Label lblPlanetSelectionDropdown;
        private System.Windows.Forms.RadioButton orbitRadio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rotationRadio;
        private System.Windows.Forms.TextBox textBoxLatitude;
    }
}
