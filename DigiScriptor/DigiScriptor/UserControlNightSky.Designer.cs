namespace DigiScriptor
{
    partial class UserControlNightSky
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
            this.panelNightSky = new System.Windows.Forms.Panel();
            this.button_Submit = new System.Windows.Forms.Button();
            this.checkBox_ConstLines = new System.Windows.Forms.CheckBox();
            this.checkBox_LabelConst = new System.Windows.Forms.CheckBox();
            this.checkBox_ConstArt = new System.Windows.Forms.CheckBox();
            this.checkBox_MoreStars = new System.Windows.Forms.CheckBox();
            this.label_Options = new System.Windows.Forms.Label();
            this.groupBox_DateTime = new System.Windows.Forms.GroupBox();
            this.label_Min = new System.Windows.Forms.Label();
            this.label_Hour = new System.Windows.Forms.Label();
            this.comboBox_Periods = new System.Windows.Forms.ComboBox();
            this.comboBox_Min = new System.Windows.Forms.ComboBox();
            this.comboBox_Hours = new System.Windows.Forms.ComboBox();
            this.label_Time = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSkyBack = new System.Windows.Forms.Button();
            this.labelNightSky = new System.Windows.Forms.Label();
            this.panelNightSky.SuspendLayout();
            this.groupBox_DateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNightSky
            // 
            this.panelNightSky.Controls.Add(this.button_Submit);
            this.panelNightSky.Controls.Add(this.checkBox_ConstLines);
            this.panelNightSky.Controls.Add(this.checkBox_LabelConst);
            this.panelNightSky.Controls.Add(this.checkBox_ConstArt);
            this.panelNightSky.Controls.Add(this.checkBox_MoreStars);
            this.panelNightSky.Controls.Add(this.label_Options);
            this.panelNightSky.Controls.Add(this.groupBox_DateTime);
            this.panelNightSky.Controls.Add(this.btnSkyBack);
            this.panelNightSky.Controls.Add(this.labelNightSky);
            this.panelNightSky.Location = new System.Drawing.Point(0, 2);
            this.panelNightSky.Margin = new System.Windows.Forms.Padding(6);
            this.panelNightSky.Name = "panelNightSky";
            this.panelNightSky.Size = new System.Drawing.Size(2242, 1839);
            this.panelNightSky.TabIndex = 28;
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.Location = new System.Drawing.Point(1658, 1644);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(179, 68);
            this.button_Submit.TabIndex = 37;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // checkBox_ConstLines
            // 
            this.checkBox_ConstLines.AutoSize = true;
            this.checkBox_ConstLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_ConstLines.Location = new System.Drawing.Point(1108, 1140);
            this.checkBox_ConstLines.Name = "checkBox_ConstLines";
            this.checkBox_ConstLines.Size = new System.Drawing.Size(424, 50);
            this.checkBox_ConstLines.TabIndex = 36;
            this.checkBox_ConstLines.Text = "Constellations Lines";
            this.checkBox_ConstLines.UseVisualStyleBackColor = true;
            this.checkBox_ConstLines.CheckedChanged += new System.EventHandler(this.checkBox_ConstLines_CheckedChanged);
            // 
            // checkBox_LabelConst
            // 
            this.checkBox_LabelConst.AutoSize = true;
            this.checkBox_LabelConst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_LabelConst.Location = new System.Drawing.Point(1106, 1031);
            this.checkBox_LabelConst.Name = "checkBox_LabelConst";
            this.checkBox_LabelConst.Size = new System.Drawing.Size(426, 50);
            this.checkBox_LabelConst.TabIndex = 35;
            this.checkBox_LabelConst.Text = "Label Constellations";
            this.checkBox_LabelConst.UseVisualStyleBackColor = true;
            this.checkBox_LabelConst.CheckedChanged += new System.EventHandler(this.checkBox_LabelConst_CheckedChanged);
            // 
            // checkBox_ConstArt
            // 
            this.checkBox_ConstArt.AutoSize = true;
            this.checkBox_ConstArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_ConstArt.Location = new System.Drawing.Point(649, 1140);
            this.checkBox_ConstArt.Name = "checkBox_ConstArt";
            this.checkBox_ConstArt.Size = new System.Drawing.Size(360, 50);
            this.checkBox_ConstArt.TabIndex = 34;
            this.checkBox_ConstArt.Text = "Constellation Art";
            this.checkBox_ConstArt.UseVisualStyleBackColor = true;
            this.checkBox_ConstArt.CheckedChanged += new System.EventHandler(this.checkBox_ConstArt_CheckedChanged);
            // 
            // checkBox_MoreStars
            // 
            this.checkBox_MoreStars.AutoSize = true;
            this.checkBox_MoreStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_MoreStars.Location = new System.Drawing.Point(649, 1040);
            this.checkBox_MoreStars.Name = "checkBox_MoreStars";
            this.checkBox_MoreStars.Size = new System.Drawing.Size(261, 50);
            this.checkBox_MoreStars.TabIndex = 33;
            this.checkBox_MoreStars.Text = "More Stars";
            this.checkBox_MoreStars.UseVisualStyleBackColor = true;
            this.checkBox_MoreStars.CheckedChanged += new System.EventHandler(this.checkBox_MoreStars_CheckedChanged);
            // 
            // label_Options
            // 
            this.label_Options.AutoSize = true;
            this.label_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_Options.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Options.Location = new System.Drawing.Point(249, 1031);
            this.label_Options.Name = "label_Options";
            this.label_Options.Size = new System.Drawing.Size(217, 59);
            this.label_Options.TabIndex = 32;
            this.label_Options.Text = "Options:";
            // 
            // groupBox_DateTime
            // 
            this.groupBox_DateTime.Controls.Add(this.label_Min);
            this.groupBox_DateTime.Controls.Add(this.label_Hour);
            this.groupBox_DateTime.Controls.Add(this.comboBox_Periods);
            this.groupBox_DateTime.Controls.Add(this.comboBox_Min);
            this.groupBox_DateTime.Controls.Add(this.comboBox_Hours);
            this.groupBox_DateTime.Controls.Add(this.label_Time);
            this.groupBox_DateTime.Controls.Add(this.monthCalendar1);
            this.groupBox_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox_DateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_DateTime.Location = new System.Drawing.Point(69, 322);
            this.groupBox_DateTime.Name = "groupBox_DateTime";
            this.groupBox_DateTime.Size = new System.Drawing.Size(1768, 645);
            this.groupBox_DateTime.TabIndex = 31;
            this.groupBox_DateTime.TabStop = false;
            this.groupBox_DateTime.Text = "Date And Time Of Night";
            // 
            // label_Min
            // 
            this.label_Min.AutoSize = true;
            this.label_Min.Location = new System.Drawing.Point(1419, 199);
            this.label_Min.Name = "label_Min";
            this.label_Min.Size = new System.Drawing.Size(68, 59);
            this.label_Min.TabIndex = 6;
            this.label_Min.Text = "M";
            // 
            // label_Hour
            // 
            this.label_Hour.AutoSize = true;
            this.label_Hour.Location = new System.Drawing.Point(1128, 199);
            this.label_Hour.Name = "label_Hour";
            this.label_Hour.Size = new System.Drawing.Size(63, 59);
            this.label_Hour.TabIndex = 5;
            this.label_Hour.Text = "H";
            // 
            // comboBox_Periods
            // 
            this.comboBox_Periods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Periods.FormattingEnabled = true;
            this.comboBox_Periods.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBox_Periods.Location = new System.Drawing.Point(1505, 191);
            this.comboBox_Periods.Name = "comboBox_Periods";
            this.comboBox_Periods.Size = new System.Drawing.Size(191, 67);
            this.comboBox_Periods.TabIndex = 4;
            this.comboBox_Periods.SelectedIndexChanged += new System.EventHandler(this.comboBox_Periods_SelectedIndexChanged);
            // 
            // comboBox_Min
            // 
            this.comboBox_Min.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Min.DropDownWidth = 213;
            this.comboBox_Min.FormattingEnabled = true;
            this.comboBox_Min.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.comboBox_Min.Location = new System.Drawing.Point(1209, 191);
            this.comboBox_Min.Name = "comboBox_Min";
            this.comboBox_Min.Size = new System.Drawing.Size(191, 67);
            this.comboBox_Min.TabIndex = 3;
            this.comboBox_Min.SelectedIndexChanged += new System.EventHandler(this.comboBox_Min_SelectedIndexChanged);
            // 
            // comboBox_Hours
            // 
            this.comboBox_Hours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Hours.DropDownWidth = 213;
            this.comboBox_Hours.FormattingEnabled = true;
            this.comboBox_Hours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox_Hours.Location = new System.Drawing.Point(919, 191);
            this.comboBox_Hours.Name = "comboBox_Hours";
            this.comboBox_Hours.Size = new System.Drawing.Size(191, 67);
            this.comboBox_Hours.TabIndex = 2;
            this.comboBox_Hours.SelectedIndexChanged += new System.EventHandler(this.comboBox_Hours_SelectedIndexChanged);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(864, 104);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(154, 59);
            this.label_Time.TabIndex = 1;
            this.label_Time.Text = "Time:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(78, 104);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnSkyBack
            // 
            this.btnSkyBack.BackColor = System.Drawing.Color.Gray;
            this.btnSkyBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkyBack.Location = new System.Drawing.Point(69, 1644);
            this.btnSkyBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnSkyBack.Name = "btnSkyBack";
            this.btnSkyBack.Size = new System.Drawing.Size(179, 72);
            this.btnSkyBack.TabIndex = 30;
            this.btnSkyBack.Text = "Back";
            this.btnSkyBack.UseVisualStyleBackColor = false;
            // 
            // labelNightSky
            // 
            this.labelNightSky.AutoSize = true;
            this.labelNightSky.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNightSky.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelNightSky.Location = new System.Drawing.Point(46, 78);
            this.labelNightSky.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNightSky.Name = "labelNightSky";
            this.labelNightSky.Size = new System.Drawing.Size(448, 133);
            this.labelNightSky.TabIndex = 3;
            this.labelNightSky.Text = "Night Sky";
            // 
            // UserControlNightSky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelNightSky);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserControlNightSky";
            this.Size = new System.Drawing.Size(2242, 1844);
            this.panelNightSky.ResumeLayout(false);
            this.panelNightSky.PerformLayout();
            this.groupBox_DateTime.ResumeLayout(false);
            this.groupBox_DateTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNightSky;
        public System.Windows.Forms.Button btnSkyBack;
        private System.Windows.Forms.Label labelNightSky;
        private System.Windows.Forms.GroupBox groupBox_DateTime;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.ComboBox comboBox_Hours;
        private System.Windows.Forms.ComboBox comboBox_Periods;
        private System.Windows.Forms.ComboBox comboBox_Min;
        private System.Windows.Forms.CheckBox checkBox_ConstLines;
        private System.Windows.Forms.CheckBox checkBox_LabelConst;
        private System.Windows.Forms.CheckBox checkBox_ConstArt;
        private System.Windows.Forms.CheckBox checkBox_MoreStars;
        private System.Windows.Forms.Label label_Options;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Label label_Min;
        private System.Windows.Forms.Label label_Hour;
    }
}
