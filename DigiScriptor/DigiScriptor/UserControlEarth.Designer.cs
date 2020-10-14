namespace DigiScriptor
{
    partial class UserControlEarth
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
            this.panelEarth = new System.Windows.Forms.Panel();
            this.editPopularLocationsButton = new System.Windows.Forms.Button();
            this.btnSubmitEarth = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboVantagePoint = new System.Windows.Forms.ComboBox();
            this.txtBoxVantagePoint = new System.Windows.Forms.TextBox();
            this.lblEarthVantagePoint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.westRadioButton = new System.Windows.Forms.RadioButton();
            this.eastRadio = new System.Windows.Forms.RadioButton();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.northRadio = new System.Windows.Forms.RadioButton();
            this.southRadio = new System.Windows.Forms.RadioButton();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.btnEarthBack = new System.Windows.Forms.Button();
            this.lblEarthCustomLocation = new System.Windows.Forms.Label();
            this.popularLocationsCombo = new System.Windows.Forms.ComboBox();
            this.lblPopularDropdown = new System.Windows.Forms.Label();
            this.lblEarthTitle = new System.Windows.Forms.Label();
            this.panelEarth.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEarth
            // 
            this.panelEarth.Controls.Add(this.editPopularLocationsButton);
            this.panelEarth.Controls.Add(this.btnSubmitEarth);
            this.panelEarth.Controls.Add(this.panel4);
            this.panelEarth.Controls.Add(this.lblEarthVantagePoint);
            this.panelEarth.Controls.Add(this.panel1);
            this.panelEarth.Controls.Add(this.btnEarthBack);
            this.panelEarth.Controls.Add(this.lblEarthCustomLocation);
            this.panelEarth.Controls.Add(this.popularLocationsCombo);
            this.panelEarth.Controls.Add(this.lblPopularDropdown);
            this.panelEarth.Controls.Add(this.lblEarthTitle);
            this.panelEarth.Location = new System.Drawing.Point(0, 0);
            this.panelEarth.Name = "panelEarth";
            this.panelEarth.Size = new System.Drawing.Size(1062, 997);
            this.panelEarth.TabIndex = 25;
            this.panelEarth.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEarth_Paint);
            // 
            // editPopularLocationsButton
            // 
            this.editPopularLocationsButton.Location = new System.Drawing.Point(488, 108);
            this.editPopularLocationsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editPopularLocationsButton.Name = "editPopularLocationsButton";
            this.editPopularLocationsButton.Size = new System.Drawing.Size(112, 35);
            this.editPopularLocationsButton.TabIndex = 29;
            this.editPopularLocationsButton.Text = "Add/Edit";
            this.editPopularLocationsButton.UseVisualStyleBackColor = true;
            this.editPopularLocationsButton.Click += new System.EventHandler(this.editPopularLocationsButton_Click);
            // 
            // btnSubmitEarth
            // 
            this.btnSubmitEarth.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitEarth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEarth.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEarth.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitEarth.Location = new System.Drawing.Point(842, 898);
            this.btnSubmitEarth.Name = "btnSubmitEarth";
            this.btnSubmitEarth.Size = new System.Drawing.Size(186, 75);
            this.btnSubmitEarth.TabIndex = 26;
            this.btnSubmitEarth.Text = "Submit";
            this.btnSubmitEarth.UseVisualStyleBackColor = false;
            this.btnSubmitEarth.Click += new System.EventHandler(this.btnSubmitEarth_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboVantagePoint);
            this.panel4.Controls.Add(this.txtBoxVantagePoint);
            this.panel4.Location = new System.Drawing.Point(244, 300);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 45);
            this.panel4.TabIndex = 28;
            // 
            // comboVantagePoint
            // 
            this.comboVantagePoint.FormattingEnabled = true;
            this.comboVantagePoint.Items.AddRange(new object[] {
            "Miles",
            "Meters",
            "Kilometers",
            "Astronomical Units"});
            this.comboVantagePoint.Location = new System.Drawing.Point(164, 5);
            this.comboVantagePoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboVantagePoint.Name = "comboVantagePoint";
            this.comboVantagePoint.Size = new System.Drawing.Size(180, 28);
            this.comboVantagePoint.TabIndex = 1;
            // 
            // txtBoxVantagePoint
            // 
            this.txtBoxVantagePoint.Location = new System.Drawing.Point(4, 5);
            this.txtBoxVantagePoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxVantagePoint.Name = "txtBoxVantagePoint";
            this.txtBoxVantagePoint.Size = new System.Drawing.Size(148, 26);
            this.txtBoxVantagePoint.TabIndex = 0;
            this.txtBoxVantagePoint.Text = "400";
            // 
            // lblEarthVantagePoint
            // 
            this.lblEarthVantagePoint.AutoSize = true;
            this.lblEarthVantagePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarthVantagePoint.Location = new System.Drawing.Point(27, 300);
            this.lblEarthVantagePoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEarthVantagePoint.Name = "lblEarthVantagePoint";
            this.lblEarthVantagePoint.Size = new System.Drawing.Size(168, 29);
            this.lblEarthVantagePoint.TabIndex = 27;
            this.lblEarthVantagePoint.Text = "Vantage Point:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBoxLongitude);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxLatitude);
            this.panel1.Location = new System.Drawing.Point(244, 189);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 85);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.westRadioButton);
            this.panel3.Controls.Add(this.eastRadio);
            this.panel3.Location = new System.Drawing.Point(164, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 40);
            this.panel3.TabIndex = 5;
            // 
            // westRadioButton
            // 
            this.westRadioButton.AutoSize = true;
            this.westRadioButton.Location = new System.Drawing.Point(90, 5);
            this.westRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.westRadioButton.Name = "westRadioButton";
            this.westRadioButton.Size = new System.Drawing.Size(71, 24);
            this.westRadioButton.TabIndex = 1;
            this.westRadioButton.TabStop = true;
            this.westRadioButton.Text = "West";
            this.westRadioButton.UseVisualStyleBackColor = true;
            // 
            // eastRadio
            // 
            this.eastRadio.AutoSize = true;
            this.eastRadio.Location = new System.Drawing.Point(4, 5);
            this.eastRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eastRadio.Name = "eastRadio";
            this.eastRadio.Size = new System.Drawing.Size(67, 24);
            this.eastRadio.TabIndex = 0;
            this.eastRadio.TabStop = true;
            this.eastRadio.Text = "East";
            this.eastRadio.UseVisualStyleBackColor = true;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(4, 46);
            this.textBoxLongitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(148, 26);
            this.textBoxLongitude.TabIndex = 6;
            this.textBoxLongitude.Text = "Enter Longitude";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.northRadio);
            this.panel2.Controls.Add(this.southRadio);
            this.panel2.Location = new System.Drawing.Point(164, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 34);
            this.panel2.TabIndex = 5;
            // 
            // northRadio
            // 
            this.northRadio.AutoSize = true;
            this.northRadio.Location = new System.Drawing.Point(4, 5);
            this.northRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.northRadio.Name = "northRadio";
            this.northRadio.Size = new System.Drawing.Size(73, 24);
            this.northRadio.TabIndex = 1;
            this.northRadio.TabStop = true;
            this.northRadio.Text = "North";
            this.northRadio.UseVisualStyleBackColor = true;
            // 
            // southRadio
            // 
            this.southRadio.AutoSize = true;
            this.southRadio.Location = new System.Drawing.Point(90, 5);
            this.southRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.southRadio.Name = "southRadio";
            this.southRadio.Size = new System.Drawing.Size(77, 24);
            this.southRadio.TabIndex = 2;
            this.southRadio.TabStop = true;
            this.southRadio.Text = "South";
            this.southRadio.UseVisualStyleBackColor = true;
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(4, 8);
            this.textBoxLatitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(148, 26);
            this.textBoxLatitude.TabIndex = 0;
            this.textBoxLatitude.Text = "Enter Latitude";
            // 
            // btnEarthBack
            // 
            this.btnEarthBack.BackColor = System.Drawing.Color.Gray;
            this.btnEarthBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarthBack.Location = new System.Drawing.Point(20, 935);
            this.btnEarthBack.Name = "btnEarthBack";
            this.btnEarthBack.Size = new System.Drawing.Size(86, 38);
            this.btnEarthBack.TabIndex = 25;
            this.btnEarthBack.Text = "Back";
            this.btnEarthBack.UseVisualStyleBackColor = false;
            // 
            // lblEarthCustomLocation
            // 
            this.lblEarthCustomLocation.AutoSize = true;
            this.lblEarthCustomLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarthCustomLocation.Location = new System.Drawing.Point(27, 189);
            this.lblEarthCustomLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEarthCustomLocation.Name = "lblEarthCustomLocation";
            this.lblEarthCustomLocation.Size = new System.Drawing.Size(198, 29);
            this.lblEarthCustomLocation.TabIndex = 23;
            this.lblEarthCustomLocation.Text = "Custom Location:";
            // 
            // popularLocationsCombo
            // 
            this.popularLocationsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.popularLocationsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popularLocationsCombo.FormattingEnabled = true;
            this.popularLocationsCombo.Location = new System.Drawing.Point(244, 106);
            this.popularLocationsCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.popularLocationsCombo.MaxDropDownItems = 20;
            this.popularLocationsCombo.Name = "popularLocationsCombo";
            this.popularLocationsCombo.Size = new System.Drawing.Size(222, 33);
            this.popularLocationsCombo.TabIndex = 22;
            this.popularLocationsCombo.SelectedIndexChanged += new System.EventHandler(this.popularLocationsCombo_SelectedIndexChanged);
            this.popularLocationsCombo.Click += new System.EventHandler(this.popularLocationsCombo_Click);
            // 
            // lblPopularDropdown
            // 
            this.lblPopularDropdown.AutoSize = true;
            this.lblPopularDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularDropdown.Location = new System.Drawing.Point(27, 108);
            this.lblPopularDropdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPopularDropdown.Name = "lblPopularDropdown";
            this.lblPopularDropdown.Size = new System.Drawing.Size(212, 29);
            this.lblPopularDropdown.TabIndex = 21;
            this.lblPopularDropdown.Text = "Popular Locations:";
            // 
            // lblEarthTitle
            // 
            this.lblEarthTitle.AutoSize = true;
            this.lblEarthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarthTitle.Location = new System.Drawing.Point(22, 42);
            this.lblEarthTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEarthTitle.Name = "lblEarthTitle";
            this.lblEarthTitle.Size = new System.Drawing.Size(108, 40);
            this.lblEarthTitle.TabIndex = 20;
            this.lblEarthTitle.Text = "Earth";
            // 
            // UserControlEarth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelEarth);
            this.Name = "UserControlEarth";
            this.Size = new System.Drawing.Size(1062, 997);
            this.panelEarth.ResumeLayout(false);
            this.panelEarth.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEarth;
        private System.Windows.Forms.Button btnSubmitEarth;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboVantagePoint;
        private System.Windows.Forms.TextBox txtBoxVantagePoint;
        private System.Windows.Forms.Label lblEarthVantagePoint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton westRadioButton;
        private System.Windows.Forms.RadioButton eastRadio;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton northRadio;
        private System.Windows.Forms.RadioButton southRadio;
        private System.Windows.Forms.TextBox textBoxLatitude;
        public System.Windows.Forms.Button btnEarthBack;
        private System.Windows.Forms.Label lblEarthCustomLocation;
        private System.Windows.Forms.ComboBox popularLocationsCombo;
        private System.Windows.Forms.Label lblPopularDropdown;
        private System.Windows.Forms.Label lblEarthTitle;
        private System.Windows.Forms.Button editPopularLocationsButton;
    }
}
