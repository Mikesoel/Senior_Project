namespace DigiScriptor
{
    partial class EarthScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEarthTitle = new System.Windows.Forms.Label();
            this.lblPopularDropdown = new System.Windows.Forms.Label();
            this.popularLocationsCombo = new System.Windows.Forms.ComboBox();
            this.lblEarthCustomLocation = new System.Windows.Forms.Label();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.northRadio = new System.Windows.Forms.RadioButton();
            this.southRadio = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.westRadioButton = new System.Windows.Forms.RadioButton();
            this.eastRadio = new System.Windows.Forms.RadioButton();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEarthBack = new System.Windows.Forms.Button();
            this.btnSubmitEarth = new System.Windows.Forms.Button();
            this.lblEarthVantagePoint = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBoxVantagePoint = new System.Windows.Forms.TextBox();
            this.comboVantagePoint = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEarthTitle
            // 
            this.lblEarthTitle.AutoSize = true;
            this.lblEarthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarthTitle.Location = new System.Drawing.Point(12, 30);
            this.lblEarthTitle.Name = "lblEarthTitle";
            this.lblEarthTitle.Size = new System.Drawing.Size(74, 29);
            this.lblEarthTitle.TabIndex = 0;
            this.lblEarthTitle.Text = "Earth";
            this.lblEarthTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPopularDropdown
            // 
            this.lblPopularDropdown.AutoSize = true;
            this.lblPopularDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularDropdown.Location = new System.Drawing.Point(13, 75);
            this.lblPopularDropdown.Name = "lblPopularDropdown";
            this.lblPopularDropdown.Size = new System.Drawing.Size(140, 20);
            this.lblPopularDropdown.TabIndex = 1;
            this.lblPopularDropdown.Text = "Popular Locations:";
            // 
            // popularLocationsCombo
            // 
            this.popularLocationsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popularLocationsCombo.FormattingEnabled = true;
            this.popularLocationsCombo.Items.AddRange(new object[] {
            "Disneyland",
            "Grand Canyon",
            "Mount Everest",
            "Sacramento State",
            "Stonehenge",
            "Eiffel Tower",
            "Great Wall of China",
            "Add New"});
            this.popularLocationsCombo.Location = new System.Drawing.Point(159, 74);
            this.popularLocationsCombo.MaxDropDownItems = 20;
            this.popularLocationsCombo.Name = "popularLocationsCombo";
            this.popularLocationsCombo.Size = new System.Drawing.Size(149, 24);
            this.popularLocationsCombo.TabIndex = 2;
            this.popularLocationsCombo.SelectedIndexChanged += new System.EventHandler(this.popularLocationsCombo_SelectedIndexChanged);
            // 
            // lblEarthCustomLocation
            // 
            this.lblEarthCustomLocation.AutoSize = true;
            this.lblEarthCustomLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarthCustomLocation.Location = new System.Drawing.Point(13, 129);
            this.lblEarthCustomLocation.Name = "lblEarthCustomLocation";
            this.lblEarthCustomLocation.Size = new System.Drawing.Size(133, 20);
            this.lblEarthCustomLocation.TabIndex = 3;
            this.lblEarthCustomLocation.Text = "Custom Location:";
            this.lblEarthCustomLocation.Click += new System.EventHandler(this.lblEarthCustomLocation_Click);
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(3, 3);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxLatitude.TabIndex = 0;
            this.textBoxLatitude.Text = "Enter Latitude";
            this.textBoxLatitude.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // northRadio
            // 
            this.northRadio.AutoSize = true;
            this.northRadio.Location = new System.Drawing.Point(3, 3);
            this.northRadio.Name = "northRadio";
            this.northRadio.Size = new System.Drawing.Size(51, 17);
            this.northRadio.TabIndex = 1;
            this.northRadio.TabStop = true;
            this.northRadio.Text = "North";
            this.northRadio.UseVisualStyleBackColor = true;
            this.northRadio.CheckedChanged += new System.EventHandler(this.northRadio_CheckedChanged);
            // 
            // southRadio
            // 
            this.southRadio.AutoSize = true;
            this.southRadio.Location = new System.Drawing.Point(60, 3);
            this.southRadio.Name = "southRadio";
            this.southRadio.Size = new System.Drawing.Size(53, 17);
            this.southRadio.TabIndex = 2;
            this.southRadio.TabStop = true;
            this.southRadio.Text = "South";
            this.southRadio.UseVisualStyleBackColor = true;
            this.southRadio.CheckedChanged += new System.EventHandler(this.latitudeRadio2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBoxLongitude);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxLatitude);
            this.panel1.Location = new System.Drawing.Point(159, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 55);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.westRadioButton);
            this.panel3.Controls.Add(this.eastRadio);
            this.panel3.Location = new System.Drawing.Point(109, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 26);
            this.panel3.TabIndex = 5;
            // 
            // westRadioButton
            // 
            this.westRadioButton.AutoSize = true;
            this.westRadioButton.Location = new System.Drawing.Point(60, 3);
            this.westRadioButton.Name = "westRadioButton";
            this.westRadioButton.Size = new System.Drawing.Size(50, 17);
            this.westRadioButton.TabIndex = 1;
            this.westRadioButton.TabStop = true;
            this.westRadioButton.Text = "West";
            this.westRadioButton.UseVisualStyleBackColor = true;
            this.westRadioButton.CheckedChanged += new System.EventHandler(this.westRadioButton_CheckedChanged);
            // 
            // eastRadio
            // 
            this.eastRadio.AutoSize = true;
            this.eastRadio.Location = new System.Drawing.Point(3, 3);
            this.eastRadio.Name = "eastRadio";
            this.eastRadio.Size = new System.Drawing.Size(46, 17);
            this.eastRadio.TabIndex = 0;
            this.eastRadio.TabStop = true;
            this.eastRadio.Text = "East";
            this.eastRadio.UseVisualStyleBackColor = true;
            this.eastRadio.CheckedChanged += new System.EventHandler(this.eastRadio_CheckedChanged);
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(3, 30);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxLongitude.TabIndex = 6;
            this.textBoxLongitude.Text = "Enter Longitude";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.northRadio);
            this.panel2.Controls.Add(this.southRadio);
            this.panel2.Location = new System.Drawing.Point(109, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 22);
            this.panel2.TabIndex = 5;
            // 
            // btnEarthBack
            // 
            this.btnEarthBack.BackColor = System.Drawing.Color.Gray;
            this.btnEarthBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarthBack.Location = new System.Drawing.Point(11, 414);
            this.btnEarthBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnEarthBack.Name = "btnEarthBack";
            this.btnEarthBack.Size = new System.Drawing.Size(57, 25);
            this.btnEarthBack.TabIndex = 15;
            this.btnEarthBack.Text = "Back";
            this.btnEarthBack.UseVisualStyleBackColor = false;
            this.btnEarthBack.Click += new System.EventHandler(this.btnEarthBack_Click);
            // 
            // btnSubmitEarth
            // 
            this.btnSubmitEarth.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitEarth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEarth.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEarth.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitEarth.Location = new System.Drawing.Point(665, 390);
            this.btnSubmitEarth.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitEarth.Name = "btnSubmitEarth";
            this.btnSubmitEarth.Size = new System.Drawing.Size(124, 49);
            this.btnSubmitEarth.TabIndex = 17;
            this.btnSubmitEarth.Text = "Submit";
            this.btnSubmitEarth.UseVisualStyleBackColor = false;
            // 
            // lblEarthVantagePoint
            // 
            this.lblEarthVantagePoint.AutoSize = true;
            this.lblEarthVantagePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarthVantagePoint.Location = new System.Drawing.Point(13, 200);
            this.lblEarthVantagePoint.Name = "lblEarthVantagePoint";
            this.lblEarthVantagePoint.Size = new System.Drawing.Size(114, 20);
            this.lblEarthVantagePoint.TabIndex = 18;
            this.lblEarthVantagePoint.Text = "Vantage Point:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboVantagePoint);
            this.panel4.Controls.Add(this.txtBoxVantagePoint);
            this.panel4.Location = new System.Drawing.Point(159, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 29);
            this.panel4.TabIndex = 19;
            // 
            // txtBoxVantagePoint
            // 
            this.txtBoxVantagePoint.Location = new System.Drawing.Point(3, 3);
            this.txtBoxVantagePoint.Name = "txtBoxVantagePoint";
            this.txtBoxVantagePoint.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVantagePoint.TabIndex = 0;
            this.txtBoxVantagePoint.Text = "400";
            this.txtBoxVantagePoint.TextChanged += new System.EventHandler(this.txtBoxVantagePoint_TextChanged);
            // 
            // comboVantagePoint
            // 
            this.comboVantagePoint.FormattingEnabled = true;
            this.comboVantagePoint.Items.AddRange(new object[] {
            "Miles",
            "Meters",
            "Kilometers",
            "Astronomical Units"});
            this.comboVantagePoint.Location = new System.Drawing.Point(109, 3);
            this.comboVantagePoint.Name = "comboVantagePoint";
            this.comboVantagePoint.Size = new System.Drawing.Size(121, 21);
            this.comboVantagePoint.TabIndex = 1;
            this.comboVantagePoint.SelectedIndexChanged += new System.EventHandler(this.comboVantagePoint_SelectedIndexChanged);
            // 
            // EarthScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblEarthVantagePoint);
            this.Controls.Add(this.btnSubmitEarth);
            this.Controls.Add(this.btnEarthBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEarthCustomLocation);
            this.Controls.Add(this.popularLocationsCombo);
            this.Controls.Add(this.lblPopularDropdown);
            this.Controls.Add(this.lblEarthTitle);
            this.Name = "EarthScreen";
            this.Text = "Earth";
            this.Load += new System.EventHandler(this.EarthScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEarthTitle;
        private System.Windows.Forms.Label lblPopularDropdown;
        private System.Windows.Forms.ComboBox popularLocationsCombo;
        private System.Windows.Forms.Label lblEarthCustomLocation;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.RadioButton northRadio;
        private System.Windows.Forms.RadioButton southRadio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton westRadioButton;
        private System.Windows.Forms.RadioButton eastRadio;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEarthBack;
        private System.Windows.Forms.Button btnSubmitEarth;
        private System.Windows.Forms.Label lblEarthVantagePoint;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboVantagePoint;
        private System.Windows.Forms.TextBox txtBoxVantagePoint;
    }
}