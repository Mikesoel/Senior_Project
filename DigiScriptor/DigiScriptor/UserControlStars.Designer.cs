namespace DigiScriptor
{
    partial class UserControlStars
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
            this.panelStars = new System.Windows.Forms.Panel();
            this.EditFavorite = new System.Windows.Forms.Button();
            this.FavLbl = new System.Windows.Forms.Label();
            this.SubBtn = new System.Windows.Forms.Button();
            this.CoordinateBox = new System.Windows.Forms.GroupBox();
            this.distancLbl = new System.Windows.Forms.Label();
            this.distanceTxt = new System.Windows.Forms.TextBox();
            this.DistanceLbl = new System.Windows.Forms.Label();
            this.checkLbl = new System.Windows.Forms.CheckBox();
            this.checkMark = new System.Windows.Forms.CheckBox();
            this.secondsLbl = new System.Windows.Forms.Label();
            this.durationTxt = new System.Windows.Forms.TextBox();
            this.DurationLbl = new System.Windows.Forms.Label();
            this.DecSecLbl = new System.Windows.Forms.Label();
            this.DecSecTxt = new System.Windows.Forms.TextBox();
            this.DecMinLbl = new System.Windows.Forms.Label();
            this.DecMinTxt = new System.Windows.Forms.TextBox();
            this.DecDLbl = new System.Windows.Forms.Label();
            this.RAsSLbl = new System.Windows.Forms.Label();
            this.RAsMLbl = new System.Windows.Forms.Label();
            this.HrLbl = new System.Windows.Forms.Label();
            this.RAsSecTxt = new System.Windows.Forms.TextBox();
            this.RAsMinTxt = new System.Windows.Forms.TextBox();
            this.decDTxt = new System.Windows.Forms.TextBox();
            this.DeclinationLbl = new System.Windows.Forms.Label();
            this.RightAscentionLbl = new System.Windows.Forms.Label();
            this.rAsHrTxt = new System.Windows.Forms.TextBox();
            this.StarFavorites = new System.Windows.Forms.ComboBox();
            this.btnStarsBack = new System.Windows.Forms.Button();
            this.labelStars = new System.Windows.Forms.Label();
            this.panelStars.SuspendLayout();
            this.CoordinateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStars
            // 
            this.panelStars.Controls.Add(this.EditFavorite);
            this.panelStars.Controls.Add(this.FavLbl);
            this.panelStars.Controls.Add(this.SubBtn);
            this.panelStars.Controls.Add(this.CoordinateBox);
            this.panelStars.Controls.Add(this.StarFavorites);
            this.panelStars.Controls.Add(this.btnStarsBack);
            this.panelStars.Controls.Add(this.labelStars);
            this.panelStars.Location = new System.Drawing.Point(0, 0);
            this.panelStars.Margin = new System.Windows.Forms.Padding(2);
            this.panelStars.Name = "panelStars";
            this.panelStars.Size = new System.Drawing.Size(708, 648);
            this.panelStars.TabIndex = 30;
            this.panelStars.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStars_Paint);
            // 
            // EditFavorite
            // 
            this.EditFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditFavorite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditFavorite.Location = new System.Drawing.Point(61, 181);
            this.EditFavorite.Name = "EditFavorite";
            this.EditFavorite.Size = new System.Drawing.Size(154, 29);
            this.EditFavorite.TabIndex = 34;
            this.EditFavorite.Text = "Edit Favorites";
            this.EditFavorite.UseVisualStyleBackColor = true;
            this.EditFavorite.Click += new System.EventHandler(this.EditFavorite_Click);
            // 
            // FavLbl
            // 
            this.FavLbl.AutoSize = true;
            this.FavLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FavLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FavLbl.Location = new System.Drawing.Point(57, 114);
            this.FavLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FavLbl.Name = "FavLbl";
            this.FavLbl.Size = new System.Drawing.Size(86, 24);
            this.FavLbl.TabIndex = 33;
            this.FavLbl.Text = "Favorites";
            // 
            // SubBtn
            // 
            this.SubBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubBtn.BackColor = System.Drawing.Color.DimGray;
            this.SubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SubBtn.ForeColor = System.Drawing.Color.SpringGreen;
            this.SubBtn.Location = new System.Drawing.Point(550, 584);
            this.SubBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(124, 49);
            this.SubBtn.TabIndex = 7;
            this.SubBtn.Text = "Submit";
            this.SubBtn.UseVisualStyleBackColor = false;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // CoordinateBox
            // 
            this.CoordinateBox.Controls.Add(this.distancLbl);
            this.CoordinateBox.Controls.Add(this.distanceTxt);
            this.CoordinateBox.Controls.Add(this.DistanceLbl);
            this.CoordinateBox.Controls.Add(this.checkLbl);
            this.CoordinateBox.Controls.Add(this.checkMark);
            this.CoordinateBox.Controls.Add(this.secondsLbl);
            this.CoordinateBox.Controls.Add(this.durationTxt);
            this.CoordinateBox.Controls.Add(this.DurationLbl);
            this.CoordinateBox.Controls.Add(this.DecSecLbl);
            this.CoordinateBox.Controls.Add(this.DecSecTxt);
            this.CoordinateBox.Controls.Add(this.DecMinLbl);
            this.CoordinateBox.Controls.Add(this.DecMinTxt);
            this.CoordinateBox.Controls.Add(this.DecDLbl);
            this.CoordinateBox.Controls.Add(this.RAsSLbl);
            this.CoordinateBox.Controls.Add(this.RAsMLbl);
            this.CoordinateBox.Controls.Add(this.HrLbl);
            this.CoordinateBox.Controls.Add(this.RAsSecTxt);
            this.CoordinateBox.Controls.Add(this.RAsMinTxt);
            this.CoordinateBox.Controls.Add(this.decDTxt);
            this.CoordinateBox.Controls.Add(this.DeclinationLbl);
            this.CoordinateBox.Controls.Add(this.RightAscentionLbl);
            this.CoordinateBox.Controls.Add(this.rAsHrTxt);
            this.CoordinateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CoordinateBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CoordinateBox.Location = new System.Drawing.Point(274, 114);
            this.CoordinateBox.Name = "CoordinateBox";
            this.CoordinateBox.Size = new System.Drawing.Size(400, 249);
            this.CoordinateBox.TabIndex = 32;
            this.CoordinateBox.TabStop = false;
            this.CoordinateBox.Text = "Coordinates";
            this.CoordinateBox.Enter += new System.EventHandler(this.CoordinateBox_Enter);
            // 
            // distancLbl
            // 
            this.distancLbl.AutoSize = true;
            this.distancLbl.Location = new System.Drawing.Point(105, 176);
            this.distancLbl.Name = "distancLbl";
            this.distancLbl.Size = new System.Drawing.Size(23, 24);
            this.distancLbl.TabIndex = 23;
            this.distancLbl.Text = "ly";
            // 
            // distanceTxt
            // 
            this.distanceTxt.Location = new System.Drawing.Point(6, 176);
            this.distanceTxt.Name = "distanceTxt";
            this.distanceTxt.Size = new System.Drawing.Size(100, 29);
            this.distanceTxt.TabIndex = 7;
            this.distanceTxt.Text = "0";
            this.distanceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.distanceTxt.TextChanged += new System.EventHandler(this.distanceTxt_TextChanged);
            // 
            // DistanceLbl
            // 
            this.DistanceLbl.AutoSize = true;
            this.DistanceLbl.Location = new System.Drawing.Point(7, 148);
            this.DistanceLbl.Name = "DistanceLbl";
            this.DistanceLbl.Size = new System.Drawing.Size(82, 24);
            this.DistanceLbl.TabIndex = 21;
            this.DistanceLbl.Text = "Distance";
            // 
            // checkLbl
            // 
            this.checkLbl.AutoSize = true;
            this.checkLbl.Location = new System.Drawing.Point(319, 210);
            this.checkLbl.Name = "checkLbl";
            this.checkLbl.Size = new System.Drawing.Size(75, 28);
            this.checkLbl.TabIndex = 20;
            this.checkLbl.Text = "Label";
            this.checkLbl.UseVisualStyleBackColor = true;
            // 
            // checkMark
            // 
            this.checkMark.AutoSize = true;
            this.checkMark.Location = new System.Drawing.Point(225, 210);
            this.checkMark.Name = "checkMark";
            this.checkMark.Size = new System.Drawing.Size(87, 28);
            this.checkMark.TabIndex = 19;
            this.checkMark.Text = "Marker";
            this.checkMark.UseVisualStyleBackColor = true;
            // 
            // secondsLbl
            // 
            this.secondsLbl.AutoSize = true;
            this.secondsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.secondsLbl.Location = new System.Drawing.Point(242, 176);
            this.secondsLbl.Name = "secondsLbl";
            this.secondsLbl.Size = new System.Drawing.Size(37, 20);
            this.secondsLbl.TabIndex = 18;
            this.secondsLbl.Text = "Sec";
            // 
            // durationTxt
            // 
            this.durationTxt.Location = new System.Drawing.Point(136, 175);
            this.durationTxt.Name = "durationTxt";
            this.durationTxt.Size = new System.Drawing.Size(99, 29);
            this.durationTxt.TabIndex = 8;
            this.durationTxt.Text = "0";
            this.durationTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.durationTxt.TextChanged += new System.EventHandler(this.DurationTxt_TextChanged);
            // 
            // DurationLbl
            // 
            this.DurationLbl.AutoSize = true;
            this.DurationLbl.Location = new System.Drawing.Point(132, 148);
            this.DurationLbl.Name = "DurationLbl";
            this.DurationLbl.Size = new System.Drawing.Size(80, 24);
            this.DurationLbl.TabIndex = 16;
            this.DurationLbl.Text = "Duration";
            this.DurationLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // DecSecLbl
            // 
            this.DecSecLbl.AutoSize = true;
            this.DecSecLbl.Location = new System.Drawing.Point(376, 116);
            this.DecSecLbl.Name = "DecSecLbl";
            this.DecSecLbl.Size = new System.Drawing.Size(17, 24);
            this.DecSecLbl.TabIndex = 15;
            this.DecSecLbl.Text = "\"";
            // 
            // DecSecTxt
            // 
            this.DecSecTxt.Location = new System.Drawing.Point(270, 116);
            this.DecSecTxt.Name = "DecSecTxt";
            this.DecSecTxt.Size = new System.Drawing.Size(100, 29);
            this.DecSecTxt.TabIndex = 6;
            this.DecSecTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecSecTxt.TextChanged += new System.EventHandler(this.DecSecTxt_TextChanged);
            // 
            // DecMinLbl
            // 
            this.DecMinLbl.AutoSize = true;
            this.DecMinLbl.Location = new System.Drawing.Point(242, 116);
            this.DecMinLbl.Name = "DecMinLbl";
            this.DecMinLbl.Size = new System.Drawing.Size(14, 24);
            this.DecMinLbl.TabIndex = 13;
            this.DecMinLbl.Text = "\'";
            // 
            // DecMinTxt
            // 
            this.DecMinTxt.Location = new System.Drawing.Point(136, 116);
            this.DecMinTxt.Name = "DecMinTxt";
            this.DecMinTxt.Size = new System.Drawing.Size(100, 29);
            this.DecMinTxt.TabIndex = 5;
            this.DecMinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecMinTxt.TextChanged += new System.EventHandler(this.DecMinTxt_TextChanged);
            // 
            // DecDLbl
            // 
            this.DecDLbl.AutoSize = true;
            this.DecDLbl.Location = new System.Drawing.Point(112, 116);
            this.DecDLbl.Name = "DecDLbl";
            this.DecDLbl.Size = new System.Drawing.Size(16, 24);
            this.DecDLbl.TabIndex = 11;
            this.DecDLbl.Text = "°";
            // 
            // RAsSLbl
            // 
            this.RAsSLbl.AutoSize = true;
            this.RAsSLbl.BackColor = System.Drawing.Color.Transparent;
            this.RAsSLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RAsSLbl.Location = new System.Drawing.Point(376, 57);
            this.RAsSLbl.Name = "RAsSLbl";
            this.RAsSLbl.Size = new System.Drawing.Size(17, 20);
            this.RAsSLbl.TabIndex = 10;
            this.RAsSLbl.Text = "s";
            // 
            // RAsMLbl
            // 
            this.RAsMLbl.AutoSize = true;
            this.RAsMLbl.BackColor = System.Drawing.Color.Transparent;
            this.RAsMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RAsMLbl.Location = new System.Drawing.Point(242, 57);
            this.RAsMLbl.Name = "RAsMLbl";
            this.RAsMLbl.Size = new System.Drawing.Size(22, 20);
            this.RAsMLbl.TabIndex = 9;
            this.RAsMLbl.Text = "m";
            // 
            // HrLbl
            // 
            this.HrLbl.AutoSize = true;
            this.HrLbl.BackColor = System.Drawing.Color.Transparent;
            this.HrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HrLbl.Location = new System.Drawing.Point(112, 57);
            this.HrLbl.Name = "HrLbl";
            this.HrLbl.Size = new System.Drawing.Size(18, 20);
            this.HrLbl.TabIndex = 8;
            this.HrLbl.Text = "h";
            // 
            // RAsSecTxt
            // 
            this.RAsSecTxt.Location = new System.Drawing.Point(270, 57);
            this.RAsSecTxt.Name = "RAsSecTxt";
            this.RAsSecTxt.Size = new System.Drawing.Size(100, 29);
            this.RAsSecTxt.TabIndex = 3;
            this.RAsSecTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RAsSecTxt.TextChanged += new System.EventHandler(this.RAsSecTxt_TextChanged);
            // 
            // RAsMinTxt
            // 
            this.RAsMinTxt.Location = new System.Drawing.Point(136, 57);
            this.RAsMinTxt.Name = "RAsMinTxt";
            this.RAsMinTxt.Size = new System.Drawing.Size(100, 29);
            this.RAsMinTxt.TabIndex = 2;
            this.RAsMinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RAsMinTxt.TextChanged += new System.EventHandler(this.RAsMinTxt_TextChanged);
            // 
            // decDTxt
            // 
            this.decDTxt.Location = new System.Drawing.Point(6, 116);
            this.decDTxt.Name = "decDTxt";
            this.decDTxt.Size = new System.Drawing.Size(100, 29);
            this.decDTxt.TabIndex = 4;
            this.decDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.decDTxt.TextChanged += new System.EventHandler(this.DecDTxt_TextChanged);
            // 
            // DeclinationLbl
            // 
            this.DeclinationLbl.AutoSize = true;
            this.DeclinationLbl.Location = new System.Drawing.Point(7, 89);
            this.DeclinationLbl.Name = "DeclinationLbl";
            this.DeclinationLbl.Size = new System.Drawing.Size(103, 24);
            this.DeclinationLbl.TabIndex = 2;
            this.DeclinationLbl.Text = "Declination";
            // 
            // RightAscentionLbl
            // 
            this.RightAscentionLbl.AutoSize = true;
            this.RightAscentionLbl.Location = new System.Drawing.Point(7, 29);
            this.RightAscentionLbl.Name = "RightAscentionLbl";
            this.RightAscentionLbl.Size = new System.Drawing.Size(147, 24);
            this.RightAscentionLbl.TabIndex = 1;
            this.RightAscentionLbl.Text = "Right Ascension";
            // 
            // rAsHrTxt
            // 
            this.rAsHrTxt.AcceptsTab = true;
            this.rAsHrTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rAsHrTxt.Location = new System.Drawing.Point(6, 57);
            this.rAsHrTxt.Name = "rAsHrTxt";
            this.rAsHrTxt.Size = new System.Drawing.Size(100, 29);
            this.rAsHrTxt.TabIndex = 1;
            this.rAsHrTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rAsHrTxt.TextChanged += new System.EventHandler(this.RAsHrTxt_TextChanged);
            // 
            // StarFavorites
            // 
            this.StarFavorites.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.StarFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.StarFavorites.FormattingEnabled = true;
            this.StarFavorites.Location = new System.Drawing.Point(61, 143);
            this.StarFavorites.Name = "StarFavorites";
            this.StarFavorites.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StarFavorites.Size = new System.Drawing.Size(154, 32);
            this.StarFavorites.Sorted = true;
            this.StarFavorites.TabIndex = 0;
            this.StarFavorites.SelectedIndexChanged += new System.EventHandler(this.StarFavorites_SelectedIndexChanged);
            // 
            // btnStarsBack
            // 
            this.btnStarsBack.BackColor = System.Drawing.Color.Gray;
            this.btnStarsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarsBack.Location = new System.Drawing.Point(21, 608);
            this.btnStarsBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnStarsBack.Name = "btnStarsBack";
            this.btnStarsBack.Size = new System.Drawing.Size(57, 25);
            this.btnStarsBack.TabIndex = 3;
            this.btnStarsBack.Text = "Back";
            this.btnStarsBack.UseVisualStyleBackColor = false;
            // 
            // labelStars
            // 
            this.labelStars.AutoSize = true;
            this.labelStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStars.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelStars.Location = new System.Drawing.Point(15, 27);
            this.labelStars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStars.Name = "labelStars";
            this.labelStars.Size = new System.Drawing.Size(109, 44);
            this.labelStars.TabIndex = 3;
            this.labelStars.Text = "Stars";
            // 
            // UserControlStars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelStars);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlStars";
            this.Size = new System.Drawing.Size(708, 648);
            this.panelStars.ResumeLayout(false);
            this.panelStars.PerformLayout();
            this.CoordinateBox.ResumeLayout(false);
            this.CoordinateBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStars;
        public System.Windows.Forms.Button btnStarsBack;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.ComboBox StarFavorites;
        private System.Windows.Forms.GroupBox CoordinateBox;
        private System.Windows.Forms.TextBox rAsHrTxt;
        private System.Windows.Forms.Label RightAscentionLbl;
        private System.Windows.Forms.Label DeclinationLbl;
        private System.Windows.Forms.TextBox decDTxt;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Label HrLbl;
        private System.Windows.Forms.TextBox RAsSecTxt;
        private System.Windows.Forms.TextBox RAsMinTxt;
        private System.Windows.Forms.Label RAsSLbl;
        private System.Windows.Forms.Label RAsMLbl;
        private System.Windows.Forms.Label DecDLbl;
        private System.Windows.Forms.Label DecSecLbl;
        private System.Windows.Forms.TextBox DecSecTxt;
        private System.Windows.Forms.Label DecMinLbl;
        private System.Windows.Forms.TextBox DecMinTxt;
        private System.Windows.Forms.Label FavLbl;
        private System.Windows.Forms.Button EditFavorite;
        private System.Windows.Forms.Label DurationLbl;
        private System.Windows.Forms.Label secondsLbl;
        private System.Windows.Forms.TextBox durationTxt;
        private System.Windows.Forms.CheckBox checkLbl;
        private System.Windows.Forms.CheckBox checkMark;
        private System.Windows.Forms.TextBox distanceTxt;
        private System.Windows.Forms.Label DistanceLbl;
        private System.Windows.Forms.Label distancLbl;
    }
}
