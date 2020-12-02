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
            this.rs_units = new System.Windows.Forms.ComboBox();
            this.os_units = new System.Windows.Forms.ComboBox();
            this.vp_units = new System.Windows.Forms.ComboBox();
            this.btnSubmitPlanet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRotaion = new System.Windows.Forms.Label();
            this.lblVantage = new System.Windows.Forms.Label();
            this.lblOrbit = new System.Windows.Forms.Label();
            this.textBoxVantage = new System.Windows.Forms.TextBox();
            this.axisDropdown = new System.Windows.Forms.ComboBox();
            this.textBoxRotation = new System.Windows.Forms.TextBox();
            this.textBoxOrbit = new System.Windows.Forms.TextBox();
            this.lblPlanetSelectionDropdown = new System.Windows.Forms.Label();
            this.planetDropdown = new System.Windows.Forms.ComboBox();
            this.btnPlanetsBack = new System.Windows.Forms.Button();
            this.labelPlanets = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDuration = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.panelPlanets.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlanets
            // 
            this.panelPlanets.Controls.Add(this.lblDuration);
            this.panelPlanets.Controls.Add(this.textBoxDuration);
            this.panelPlanets.Controls.Add(this.rs_units);
            this.panelPlanets.Controls.Add(this.os_units);
            this.panelPlanets.Controls.Add(this.vp_units);
            this.panelPlanets.Controls.Add(this.btnSubmitPlanet);
            this.panelPlanets.Controls.Add(this.label1);
            this.panelPlanets.Controls.Add(this.lblRotaion);
            this.panelPlanets.Controls.Add(this.lblVantage);
            this.panelPlanets.Controls.Add(this.lblOrbit);
            this.panelPlanets.Controls.Add(this.textBoxVantage);
            this.panelPlanets.Controls.Add(this.axisDropdown);
            this.panelPlanets.Controls.Add(this.textBoxRotation);
            this.panelPlanets.Controls.Add(this.textBoxOrbit);
            this.panelPlanets.Controls.Add(this.lblPlanetSelectionDropdown);
            this.panelPlanets.Controls.Add(this.planetDropdown);
            this.panelPlanets.Controls.Add(this.btnPlanetsBack);
            this.panelPlanets.Controls.Add(this.labelPlanets);
            this.panelPlanets.Location = new System.Drawing.Point(0, 0);
            this.panelPlanets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPlanets.Name = "panelPlanets";
            this.panelPlanets.Size = new System.Drawing.Size(1062, 998);
            this.panelPlanets.TabIndex = 27;
            // 
            // rs_units
            // 
            this.rs_units.FormattingEnabled = true;
            this.rs_units.Items.AddRange(new object[] {
            "hours",
            "minutes"});
            this.rs_units.Location = new System.Drawing.Point(503, 465);
            this.rs_units.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rs_units.Name = "rs_units";
            this.rs_units.Size = new System.Drawing.Size(111, 28);
            this.rs_units.TabIndex = 49;
            this.rs_units.TextChanged += new System.EventHandler(this.rs_units_TextChanged);
            // 
            // os_units
            // 
            this.os_units.FormattingEnabled = true;
            this.os_units.Items.AddRange(new object[] {
            "km/hr",
            "km/s"});
            this.os_units.Location = new System.Drawing.Point(503, 358);
            this.os_units.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.os_units.Name = "os_units";
            this.os_units.Size = new System.Drawing.Size(111, 28);
            this.os_units.TabIndex = 48;
            this.os_units.SelectedIndexChanged += new System.EventHandler(this.os_units_SelectedIndexChanged);
            this.os_units.TextChanged += new System.EventHandler(this.os_units_TextChanged);
            // 
            // vp_units
            // 
            this.vp_units.FormattingEnabled = true;
            this.vp_units.Items.AddRange(new object[] {
            "Meters",
            "Kilometers"});
            this.vp_units.Location = new System.Drawing.Point(503, 257);
            this.vp_units.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vp_units.Name = "vp_units";
            this.vp_units.Size = new System.Drawing.Size(111, 28);
            this.vp_units.TabIndex = 47;
            this.vp_units.TextChanged += new System.EventHandler(this.vp_units_TextChanged);
            this.vp_units.MouseHover += new System.EventHandler(this.cmbBoxDist_MouseHover);
            // 
            // btnSubmitPlanet
            // 
            this.btnSubmitPlanet.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitPlanet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitPlanet.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitPlanet.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitPlanet.Location = new System.Drawing.Point(428, 713);
            this.btnSubmitPlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitPlanet.Name = "btnSubmitPlanet";
            this.btnSubmitPlanet.Size = new System.Drawing.Size(186, 75);
            this.btnSubmitPlanet.TabIndex = 46;
            this.btnSubmitPlanet.Text = "Submit";
            this.btnSubmitPlanet.UseVisualStyleBackColor = false;
            this.btnSubmitPlanet.Click += new System.EventHandler(this.btnSubmitPlanet_Click);
            this.btnSubmitPlanet.MouseHover += new System.EventHandler(this.btnSubmitPlanet_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 552);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Rotation Axis:";
            // 
            // lblRotaion
            // 
            this.lblRotaion.AutoSize = true;
            this.lblRotaion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotaion.ForeColor = System.Drawing.Color.White;
            this.lblRotaion.Location = new System.Drawing.Point(54, 461);
            this.lblRotaion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRotaion.Name = "lblRotaion";
            this.lblRotaion.Size = new System.Drawing.Size(186, 29);
            this.lblRotaion.TabIndex = 44;
            this.lblRotaion.Text = "Rotation Speed:";
            // 
            // lblVantage
            // 
            this.lblVantage.AutoSize = true;
            this.lblVantage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVantage.ForeColor = System.Drawing.Color.White;
            this.lblVantage.Location = new System.Drawing.Point(20, 259);
            this.lblVantage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVantage.Name = "lblVantage";
            this.lblVantage.Size = new System.Drawing.Size(220, 29);
            this.lblVantage.TabIndex = 43;
            this.lblVantage.Text = "Orbit Radius Scale:";
            // 
            // lblOrbit
            // 
            this.lblOrbit.AutoSize = true;
            this.lblOrbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrbit.ForeColor = System.Drawing.Color.White;
            this.lblOrbit.Location = new System.Drawing.Point(90, 357);
            this.lblOrbit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrbit.Name = "lblOrbit";
            this.lblOrbit.Size = new System.Drawing.Size(150, 29);
            this.lblOrbit.TabIndex = 42;
            this.lblOrbit.Text = "Orbit Speed:";
            // 
            // textBoxVantage
            // 
            this.textBoxVantage.Location = new System.Drawing.Point(270, 259);
            this.textBoxVantage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxVantage.Name = "textBoxVantage";
            this.textBoxVantage.Size = new System.Drawing.Size(194, 26);
            this.textBoxVantage.TabIndex = 41;
            this.textBoxVantage.TextChanged += new System.EventHandler(this.textBoxVantage_TextChanged);
            // 
            // axisDropdown
            // 
            this.axisDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axisDropdown.FormattingEnabled = true;
            this.axisDropdown.Items.AddRange(new object[] {
            "Axis of rotation",
            "Equator (halfway between axis)"});
            this.axisDropdown.Location = new System.Drawing.Point(270, 552);
            this.axisDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axisDropdown.MaxDropDownItems = 20;
            this.axisDropdown.Name = "axisDropdown";
            this.axisDropdown.Size = new System.Drawing.Size(344, 33);
            this.axisDropdown.TabIndex = 39;
            this.axisDropdown.Text = "Select an axis";
            this.axisDropdown.TextChanged += new System.EventHandler(this.axisDropdown_TextChanged);
            // 
            // textBoxRotation
            // 
            this.textBoxRotation.Location = new System.Drawing.Point(270, 465);
            this.textBoxRotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRotation.Name = "textBoxRotation";
            this.textBoxRotation.Size = new System.Drawing.Size(194, 26);
            this.textBoxRotation.TabIndex = 37;
            this.textBoxRotation.TextChanged += new System.EventHandler(this.textBoxRotation_TextChanged);
            this.textBoxRotation.MouseHover += new System.EventHandler(this.textBoxRotation_MouseHover);
            // 
            // textBoxOrbit
            // 
            this.textBoxOrbit.Location = new System.Drawing.Point(270, 358);
            this.textBoxOrbit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOrbit.Name = "textBoxOrbit";
            this.textBoxOrbit.Size = new System.Drawing.Size(194, 26);
            this.textBoxOrbit.TabIndex = 35;
            this.textBoxOrbit.TextChanged += new System.EventHandler(this.textBoxOrbit_TextChanged);
            this.textBoxOrbit.MouseHover += new System.EventHandler(this.textBoxOrbit_MouseHover);
            // 
            // lblPlanetSelectionDropdown
            // 
            this.lblPlanetSelectionDropdown.AutoSize = true;
            this.lblPlanetSelectionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetSelectionDropdown.ForeColor = System.Drawing.Color.White;
            this.lblPlanetSelectionDropdown.Location = new System.Drawing.Point(29, 154);
            this.lblPlanetSelectionDropdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanetSelectionDropdown.Name = "lblPlanetSelectionDropdown";
            this.lblPlanetSelectionDropdown.Size = new System.Drawing.Size(212, 29);
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
            this.planetDropdown.Location = new System.Drawing.Point(270, 154);
            this.planetDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.planetDropdown.MaxDropDownItems = 20;
            this.planetDropdown.Name = "planetDropdown";
            this.planetDropdown.Size = new System.Drawing.Size(344, 33);
            this.planetDropdown.TabIndex = 31;
            this.planetDropdown.Text = "Select a Planet";
            this.planetDropdown.TextChanged += new System.EventHandler(this.planetDropdown_TextChanged);
            this.planetDropdown.MouseHover += new System.EventHandler(this.planetDropdown_MouseHover);
            // 
            // btnPlanetsBack
            // 
            this.btnPlanetsBack.BackColor = System.Drawing.Color.Gray;
            this.btnPlanetsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanetsBack.Location = new System.Drawing.Point(32, 936);
            this.btnPlanetsBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlanetsBack.Name = "btnPlanetsBack";
            this.btnPlanetsBack.Size = new System.Drawing.Size(86, 39);
            this.btnPlanetsBack.TabIndex = 30;
            this.btnPlanetsBack.Text = "Back";
            this.btnPlanetsBack.UseVisualStyleBackColor = false;
            // 
            // labelPlanets
            // 
            this.labelPlanets.AutoSize = true;
            this.labelPlanets.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanets.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlanets.Location = new System.Drawing.Point(22, 42);
            this.labelPlanets.Name = "labelPlanets";
            this.labelPlanets.Size = new System.Drawing.Size(187, 67);
            this.labelPlanets.TabIndex = 3;
            this.labelPlanets.Text = "Planets";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblDuration.Location = new System.Drawing.Point(379, 653);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(129, 28);
            this.lblDuration.TabIndex = 51;
            this.lblDuration.Text = "Duration (s):";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(514, 657);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 26);
            this.textBoxDuration.TabIndex = 50;
            this.textBoxDuration.TextChanged += new System.EventHandler(this.textBoxDuration_TextChanged);
            // 
            // UserControlPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelPlanets);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlPlanets";
            this.Size = new System.Drawing.Size(1062, 998);
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
        private System.Windows.Forms.ComboBox axisDropdown;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label lblOrbit;
        private System.Windows.Forms.Label lblRotaion;
        private System.Windows.Forms.Label lblVantage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitPlanet;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ComboBox vp_units;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ComboBox rs_units;
        private System.Windows.Forms.ComboBox os_units;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox textBoxDuration;
    }
}
