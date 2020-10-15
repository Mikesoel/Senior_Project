namespace DigiScriptor
{
    partial class NightSkyScreen
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
            this.back = new System.Windows.Forms.Button();
            this.comboBox_Hours = new System.Windows.Forms.ComboBox();
            this.comboBox_Min = new System.Windows.Forms.ComboBox();
            this.comboBox_Periods = new System.Windows.Forms.ComboBox();
            this.groupBox_DateTime = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label_Time = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.checkBox_MoreStars = new System.Windows.Forms.CheckBox();
            this.label_Options = new System.Windows.Forms.Label();
            this.checkBox_ConstLabel = new System.Windows.Forms.CheckBox();
            this.checkBox_ConstLines = new System.Windows.Forms.CheckBox();
            this.checkBox_ConstArt = new System.Windows.Forms.CheckBox();
            this.groupBox_DateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(44, 958);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(209, 94);
            this.back.TabIndex = 0;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // comboBox_Hours
            // 
            this.comboBox_Hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox_Hours.FormattingEnabled = true;
            this.comboBox_Hours.ItemHeight = 64;
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
            this.comboBox_Hours.Location = new System.Drawing.Point(925, 174);
            this.comboBox_Hours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Hours.Name = "comboBox_Hours";
            this.comboBox_Hours.Size = new System.Drawing.Size(213, 72);
            this.comboBox_Hours.TabIndex = 2;
            // 
            // comboBox_Min
            // 
            this.comboBox_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox_Min.FormattingEnabled = true;
            this.comboBox_Min.Items.AddRange(new object[] {
            "00",
            "5",
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
            this.comboBox_Min.Location = new System.Drawing.Point(1182, 174);
            this.comboBox_Min.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Min.Name = "comboBox_Min";
            this.comboBox_Min.Size = new System.Drawing.Size(213, 72);
            this.comboBox_Min.TabIndex = 3;
            this.comboBox_Min.SelectedIndexChanged += new System.EventHandler(this.comboBox_Min_SelectedIndexChanged);
            // 
            // comboBox_Periods
            // 
            this.comboBox_Periods.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox_Periods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox_Periods.FormattingEnabled = true;
            this.comboBox_Periods.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboBox_Periods.Location = new System.Drawing.Point(1440, 174);
            this.comboBox_Periods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Periods.Name = "comboBox_Periods";
            this.comboBox_Periods.Size = new System.Drawing.Size(213, 72);
            this.comboBox_Periods.TabIndex = 4;
            // 
            // groupBox_DateTime
            // 
            this.groupBox_DateTime.Controls.Add(this.comboBox_Hours);
            this.groupBox_DateTime.Controls.Add(this.monthCalendar1);
            this.groupBox_DateTime.Controls.Add(this.label_Time);
            this.groupBox_DateTime.Controls.Add(this.comboBox_Periods);
            this.groupBox_DateTime.Controls.Add(this.comboBox_Min);
            this.groupBox_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox_DateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_DateTime.Location = new System.Drawing.Point(44, 28);
            this.groupBox_DateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_DateTime.Name = "groupBox_DateTime";
            this.groupBox_DateTime.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_DateTime.Size = new System.Drawing.Size(1786, 592);
            this.groupBox_DateTime.TabIndex = 5;
            this.groupBox_DateTime.TabStop = false;
            this.groupBox_DateTime.Text = "Date And Time Of Night";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(51, 85);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(870, 85);
            this.label_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(169, 64);
            this.label_Time.TabIndex = 5;
            this.label_Time.Text = "Time:";
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(1659, 958);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(215, 94);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // checkBox_MoreStars
            // 
            this.checkBox_MoreStars.AutoSize = true;
            this.checkBox_MoreStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_MoreStars.Location = new System.Drawing.Point(348, 692);
            this.checkBox_MoreStars.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_MoreStars.Name = "checkBox_MoreStars";
            this.checkBox_MoreStars.Size = new System.Drawing.Size(261, 50);
            this.checkBox_MoreStars.TabIndex = 11;
            this.checkBox_MoreStars.Text = "More Stars";
            this.checkBox_MoreStars.UseVisualStyleBackColor = true;
            // 
            // label_Options
            // 
            this.label_Options.AutoSize = true;
            this.label_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_Options.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Options.Location = new System.Drawing.Point(51, 677);
            this.label_Options.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Options.Name = "label_Options";
            this.label_Options.Size = new System.Drawing.Size(238, 64);
            this.label_Options.TabIndex = 12;
            this.label_Options.Text = "Options:";
            // 
            // checkBox_ConstLabel
            // 
            this.checkBox_ConstLabel.AutoSize = true;
            this.checkBox_ConstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_ConstLabel.Location = new System.Drawing.Point(768, 692);
            this.checkBox_ConstLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_ConstLabel.Name = "checkBox_ConstLabel";
            this.checkBox_ConstLabel.Size = new System.Drawing.Size(426, 50);
            this.checkBox_ConstLabel.TabIndex = 13;
            this.checkBox_ConstLabel.Text = "Label Constellations";
            this.checkBox_ConstLabel.UseVisualStyleBackColor = true;
            // 
            // checkBox_ConstLines
            // 
            this.checkBox_ConstLines.AutoSize = true;
            this.checkBox_ConstLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_ConstLines.Location = new System.Drawing.Point(768, 788);
            this.checkBox_ConstLines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_ConstLines.Name = "checkBox_ConstLines";
            this.checkBox_ConstLines.Size = new System.Drawing.Size(404, 50);
            this.checkBox_ConstLines.TabIndex = 14;
            this.checkBox_ConstLines.Text = "Constellation Lines";
            this.checkBox_ConstLines.UseVisualStyleBackColor = true;
            // 
            // checkBox_ConstArt
            // 
            this.checkBox_ConstArt.AutoSize = true;
            this.checkBox_ConstArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox_ConstArt.Location = new System.Drawing.Point(348, 788);
            this.checkBox_ConstArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_ConstArt.Name = "checkBox_ConstArt";
            this.checkBox_ConstArt.Size = new System.Drawing.Size(360, 50);
            this.checkBox_ConstArt.TabIndex = 15;
            this.checkBox_ConstArt.Text = "Constellation Art";
            this.checkBox_ConstArt.UseVisualStyleBackColor = true;
            // 
            // NightSkyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(2487, 1191);
            this.Controls.Add(this.checkBox_ConstArt);
            this.Controls.Add(this.checkBox_ConstLines);
            this.Controls.Add(this.checkBox_ConstLabel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label_Options);
            this.Controls.Add(this.checkBox_MoreStars);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox_DateTime);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NightSkyScreen";
            this.Text = "NightSkyScreen";
            this.Load += new System.EventHandler(this.NightSkyScreen_Load);
            this.groupBox_DateTime.ResumeLayout(false);
            this.groupBox_DateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_Hours;
        private System.Windows.Forms.ComboBox comboBox_Min;
        private System.Windows.Forms.ComboBox comboBox_Periods;
        private System.Windows.Forms.GroupBox groupBox_DateTime;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.CheckBox checkBox_MoreStars;
        private System.Windows.Forms.Label label_Options;
        private System.Windows.Forms.CheckBox checkBox_ConstLabel;
        private System.Windows.Forms.CheckBox checkBox_ConstLines;
        private System.Windows.Forms.CheckBox checkBox_ConstArt;
    }
}