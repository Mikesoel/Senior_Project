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
            this.components = new System.ComponentModel.Container();
            this.panelPlanets = new System.Windows.Forms.Panel();
            this.lblRotaion = new System.Windows.Forms.Label();
            this.lblVantage = new System.Windows.Forms.Label();
            this.lblOrbit = new System.Windows.Forms.Label();
            this.textBoxVantage = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxRotation = new System.Windows.Forms.TextBox();
            this.textBoxOrbit = new System.Windows.Forms.TextBox();
            this.lblPlanetSelectionDropdown = new System.Windows.Forms.Label();
            this.planetDropdown = new System.Windows.Forms.ComboBox();
            this.btnPlanetsBack = new System.Windows.Forms.Button();
            this.labelPlanets = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitPlanet = new System.Windows.Forms.Button();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbBoxDist = new System.Windows.Forms.ComboBox();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panelPlanets.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlanets
            // 
            this.panelPlanets.Controls.Add(this.comboBox3);
            this.panelPlanets.Controls.Add(this.comboBox2);
            this.panelPlanets.Controls.Add(this.cmbBoxDist);
            this.panelPlanets.Controls.Add(this.btnSubmitPlanet);
            this.panelPlanets.Controls.Add(this.label1);
            this.panelPlanets.Controls.Add(this.lblRotaion);
            this.panelPlanets.Controls.Add(this.lblVantage);
            this.panelPlanets.Controls.Add(this.lblOrbit);
            this.panelPlanets.Controls.Add(this.textBoxVantage);
            this.panelPlanets.Controls.Add(this.comboBox1);
            this.panelPlanets.Controls.Add(this.textBoxRotation);
            this.panelPlanets.Controls.Add(this.textBoxOrbit);
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
            // lblRotaion
            // 
            this.lblRotaion.AutoSize = true;
            this.lblRotaion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotaion.Location = new System.Drawing.Point(23, 368);
            this.lblRotaion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotaion.Name = "lblRotaion";
            this.lblRotaion.Size = new System.Drawing.Size(152, 25);
            this.lblRotaion.TabIndex = 44;
            this.lblRotaion.Text = "Rotation Speed:";
            // 
            // lblVantage
            // 
            this.lblVantage.AutoSize = true;
            this.lblVantage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVantage.Location = new System.Drawing.Point(25, 189);
            this.lblVantage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVantage.Name = "lblVantage";
            this.lblVantage.Size = new System.Drawing.Size(141, 25);
            this.lblVantage.TabIndex = 43;
            this.lblVantage.Text = "Vantage Point:";
            // 
            // lblOrbit
            // 
            this.lblOrbit.AutoSize = true;
            this.lblOrbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrbit.Location = new System.Drawing.Point(25, 282);
            this.lblOrbit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrbit.Name = "lblOrbit";
            this.lblOrbit.Size = new System.Drawing.Size(123, 25);
            this.lblOrbit.TabIndex = 42;
            this.lblOrbit.Text = "Orbit Speed:";
            // 
            // textBoxVantage
            // 
            this.textBoxVantage.Location = new System.Drawing.Point(211, 193);
            this.textBoxVantage.Name = "textBoxVantage";
            this.textBoxVantage.Size = new System.Drawing.Size(173, 22);
            this.textBoxVantage.TabIndex = 41;
            this.textBoxVantage.Text = "Enter desired vantage point";
            this.textBoxVantage.TextChanged += new System.EventHandler(this.textBoxVantage_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Axis of rotation",
            "Equator (halfway between axis)"});
            this.comboBox1.Location = new System.Drawing.Point(211, 442);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.MaxDropDownItems = 20;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 28);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.Text = "Select an axis";
            // 
            // textBoxRotation
            // 
            this.textBoxRotation.Location = new System.Drawing.Point(211, 372);
            this.textBoxRotation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRotation.Name = "textBoxRotation";
            this.textBoxRotation.Size = new System.Drawing.Size(173, 22);
            this.textBoxRotation.TabIndex = 37;
            this.textBoxRotation.Text = "Enter Rotation Speed";
            this.textBoxRotation.TextChanged += new System.EventHandler(this.textBoxRotation_TextChanged);
            this.textBoxRotation.MouseHover += new System.EventHandler(this.textBoxRotation_MouseHover);
            // 
            // textBoxOrbit
            // 
            this.textBoxOrbit.Location = new System.Drawing.Point(211, 282);
            this.textBoxOrbit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOrbit.Name = "textBoxOrbit";
            this.textBoxOrbit.Size = new System.Drawing.Size(173, 22);
            this.textBoxOrbit.TabIndex = 35;
            this.textBoxOrbit.Text = "Enter Orbit Speed";
            this.textBoxOrbit.TextChanged += new System.EventHandler(this.textBoxOrbit_TextChanged);
            this.textBoxOrbit.MouseHover += new System.EventHandler(this.textBoxOrbit_MouseHover);
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
            this.planetDropdown.Size = new System.Drawing.Size(306, 28);
            this.planetDropdown.TabIndex = 31;
            this.planetDropdown.Text = "Select a Planet";
            this.planetDropdown.TextChanged += new System.EventHandler(this.planetDropdown_TextChanged);
            this.planetDropdown.MouseHover += new System.EventHandler(this.planetDropdown_MouseHover);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 441);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Rotation Axis:";
            // 
            // btnSubmitPlanet
            // 
            this.btnSubmitPlanet.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitPlanet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitPlanet.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitPlanet.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitPlanet.Location = new System.Drawing.Point(192, 575);
            this.btnSubmitPlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitPlanet.Name = "btnSubmitPlanet";
            this.btnSubmitPlanet.Size = new System.Drawing.Size(165, 60);
            this.btnSubmitPlanet.TabIndex = 46;
            this.btnSubmitPlanet.Text = "Submit";
            this.btnSubmitPlanet.UseVisualStyleBackColor = false;
            this.btnSubmitPlanet.MouseHover += new System.EventHandler(this.btnSubmitPlanet_MouseHover);
            // 
            // cmbBoxDist
            // 
            this.cmbBoxDist.FormattingEnabled = true;
            this.cmbBoxDist.Items.AddRange(new object[] {
            "Meters",
            "Kilometers"});
            this.cmbBoxDist.Location = new System.Drawing.Point(418, 191);
            this.cmbBoxDist.Name = "cmbBoxDist";
            this.cmbBoxDist.Size = new System.Drawing.Size(99, 24);
            this.cmbBoxDist.TabIndex = 47;
            this.cmbBoxDist.MouseHover += new System.EventHandler(this.cmbBoxDist_MouseHover);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "km/hr",
            "km/s"});
            this.comboBox2.Location = new System.Drawing.Point(418, 286);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 24);
            this.comboBox2.TabIndex = 48;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "km/hr",
            "km/s"});
            this.comboBox3.Location = new System.Drawing.Point(418, 372);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(99, 24);
            this.comboBox3.TabIndex = 49;
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
        private System.Windows.Forms.TextBox textBoxRotation;
        private System.Windows.Forms.TextBox textBoxOrbit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox textBoxVantage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label lblOrbit;
        private System.Windows.Forms.Label lblRotaion;
        private System.Windows.Forms.Label lblVantage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitPlanet;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ComboBox cmbBoxDist;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
