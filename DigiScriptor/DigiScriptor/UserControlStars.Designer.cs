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
            this.SubBtn = new System.Windows.Forms.Button();
            this.CoordinateBox = new System.Windows.Forms.GroupBox();
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
            this.DecDTxt = new System.Windows.Forms.TextBox();
            this.DeclinationLbl = new System.Windows.Forms.Label();
            this.RightAscentionLbl = new System.Windows.Forms.Label();
            this.RAsHrTxt = new System.Windows.Forms.TextBox();
            this.StarFavorites = new System.Windows.Forms.ComboBox();
            this.btnStarsBack = new System.Windows.Forms.Button();
            this.labelStars = new System.Windows.Forms.Label();
            this.FavLbl = new System.Windows.Forms.Label();
            this.panelStars.SuspendLayout();
            this.CoordinateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStars
            // 
            this.panelStars.Controls.Add(this.FavLbl);
            this.panelStars.Controls.Add(this.SubBtn);
            this.panelStars.Controls.Add(this.CoordinateBox);
            this.panelStars.Controls.Add(this.StarFavorites);
            this.panelStars.Controls.Add(this.btnStarsBack);
            this.panelStars.Controls.Add(this.labelStars);
            this.panelStars.Location = new System.Drawing.Point(0, 0);
            this.panelStars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelStars.Name = "panelStars";
            this.panelStars.Size = new System.Drawing.Size(944, 798);
            this.panelStars.TabIndex = 30;
            // 
            // SubBtn
            // 
            this.SubBtn.BackColor = System.Drawing.Color.DimGray;
            this.SubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.SubBtn.ForeColor = System.Drawing.Color.SpringGreen;
            this.SubBtn.Location = new System.Drawing.Point(733, 719);
            this.SubBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(165, 60);
            this.SubBtn.TabIndex = 7;
            this.SubBtn.Text = "Submit";
            this.SubBtn.UseVisualStyleBackColor = false;
            this.SubBtn.Click += new System.EventHandler(this.SubBtn_Click);
            // 
            // CoordinateBox
            // 
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
            this.CoordinateBox.Controls.Add(this.DecDTxt);
            this.CoordinateBox.Controls.Add(this.DeclinationLbl);
            this.CoordinateBox.Controls.Add(this.RightAscentionLbl);
            this.CoordinateBox.Controls.Add(this.RAsHrTxt);
            this.CoordinateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CoordinateBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CoordinateBox.Location = new System.Drawing.Point(365, 140);
            this.CoordinateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoordinateBox.Name = "CoordinateBox";
            this.CoordinateBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoordinateBox.Size = new System.Drawing.Size(533, 202);
            this.CoordinateBox.TabIndex = 32;
            this.CoordinateBox.TabStop = false;
            this.CoordinateBox.Text = "Coordinates";
            // 
            // DecSecLbl
            // 
            this.DecSecLbl.AutoSize = true;
            this.DecSecLbl.Location = new System.Drawing.Point(501, 143);
            this.DecSecLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DecSecLbl.Name = "DecSecLbl";
            this.DecSecLbl.Size = new System.Drawing.Size(21, 29);
            this.DecSecLbl.TabIndex = 15;
            this.DecSecLbl.Text = "\"";
            // 
            // DecSecTxt
            // 
            this.DecSecTxt.Location = new System.Drawing.Point(360, 143);
            this.DecSecTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DecSecTxt.Name = "DecSecTxt";
            this.DecSecTxt.Size = new System.Drawing.Size(132, 34);
            this.DecSecTxt.TabIndex = 6;
            this.DecSecTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecSecTxt.TextChanged += new System.EventHandler(this.DecSecTxt_TextChanged);
            // 
            // DecMinLbl
            // 
            this.DecMinLbl.AutoSize = true;
            this.DecMinLbl.Location = new System.Drawing.Point(323, 143);
            this.DecMinLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DecMinLbl.Name = "DecMinLbl";
            this.DecMinLbl.Size = new System.Drawing.Size(17, 29);
            this.DecMinLbl.TabIndex = 13;
            this.DecMinLbl.Text = "\'";
            // 
            // DecMinTxt
            // 
            this.DecMinTxt.Location = new System.Drawing.Point(181, 143);
            this.DecMinTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DecMinTxt.Name = "DecMinTxt";
            this.DecMinTxt.Size = new System.Drawing.Size(132, 34);
            this.DecMinTxt.TabIndex = 5;
            this.DecMinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecMinTxt.TextChanged += new System.EventHandler(this.DecMinTxt_TextChanged);
            // 
            // DecDLbl
            // 
            this.DecDLbl.AutoSize = true;
            this.DecDLbl.Location = new System.Drawing.Point(149, 143);
            this.DecDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DecDLbl.Name = "DecDLbl";
            this.DecDLbl.Size = new System.Drawing.Size(21, 29);
            this.DecDLbl.TabIndex = 11;
            this.DecDLbl.Text = "°";
            // 
            // RAsSLbl
            // 
            this.RAsSLbl.AutoSize = true;
            this.RAsSLbl.BackColor = System.Drawing.Color.Transparent;
            this.RAsSLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RAsSLbl.Location = new System.Drawing.Point(501, 70);
            this.RAsSLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RAsSLbl.Name = "RAsSLbl";
            this.RAsSLbl.Size = new System.Drawing.Size(22, 25);
            this.RAsSLbl.TabIndex = 10;
            this.RAsSLbl.Text = "s";
            // 
            // RAsMLbl
            // 
            this.RAsMLbl.AutoSize = true;
            this.RAsMLbl.BackColor = System.Drawing.Color.Transparent;
            this.RAsMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RAsMLbl.Location = new System.Drawing.Point(323, 70);
            this.RAsMLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RAsMLbl.Name = "RAsMLbl";
            this.RAsMLbl.Size = new System.Drawing.Size(28, 25);
            this.RAsMLbl.TabIndex = 9;
            this.RAsMLbl.Text = "m";
            // 
            // HrLbl
            // 
            this.HrLbl.AutoSize = true;
            this.HrLbl.BackColor = System.Drawing.Color.Transparent;
            this.HrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HrLbl.Location = new System.Drawing.Point(149, 70);
            this.HrLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HrLbl.Name = "HrLbl";
            this.HrLbl.Size = new System.Drawing.Size(23, 25);
            this.HrLbl.TabIndex = 8;
            this.HrLbl.Text = "h";
            // 
            // RAsSecTxt
            // 
            this.RAsSecTxt.Location = new System.Drawing.Point(360, 70);
            this.RAsSecTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RAsSecTxt.Name = "RAsSecTxt";
            this.RAsSecTxt.Size = new System.Drawing.Size(132, 34);
            this.RAsSecTxt.TabIndex = 3;
            this.RAsSecTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RAsSecTxt.TextChanged += new System.EventHandler(this.RAsSecTxt_TextChanged);
            // 
            // RAsMinTxt
            // 
            this.RAsMinTxt.Location = new System.Drawing.Point(181, 70);
            this.RAsMinTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RAsMinTxt.Name = "RAsMinTxt";
            this.RAsMinTxt.Size = new System.Drawing.Size(132, 34);
            this.RAsMinTxt.TabIndex = 2;
            this.RAsMinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RAsMinTxt.TextChanged += new System.EventHandler(this.RAsMinTxt_TextChanged);
            // 
            // DecDTxt
            // 
            this.DecDTxt.Location = new System.Drawing.Point(8, 143);
            this.DecDTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DecDTxt.Name = "DecDTxt";
            this.DecDTxt.Size = new System.Drawing.Size(132, 34);
            this.DecDTxt.TabIndex = 4;
            this.DecDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecDTxt.TextChanged += new System.EventHandler(this.DecDTxt_TextChanged);
            // 
            // DeclinationLbl
            // 
            this.DeclinationLbl.AutoSize = true;
            this.DeclinationLbl.Location = new System.Drawing.Point(9, 110);
            this.DeclinationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeclinationLbl.Name = "DeclinationLbl";
            this.DeclinationLbl.Size = new System.Drawing.Size(133, 29);
            this.DeclinationLbl.TabIndex = 2;
            this.DeclinationLbl.Text = "Declination";
            // 
            // RightAscentionLbl
            // 
            this.RightAscentionLbl.AutoSize = true;
            this.RightAscentionLbl.Location = new System.Drawing.Point(9, 36);
            this.RightAscentionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RightAscentionLbl.Name = "RightAscentionLbl";
            this.RightAscentionLbl.Size = new System.Drawing.Size(186, 29);
            this.RightAscentionLbl.TabIndex = 1;
            this.RightAscentionLbl.Text = "Right Ascension";
            // 
            // RAsHrTxt
            // 
            this.RAsHrTxt.AcceptsTab = true;
            this.RAsHrTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RAsHrTxt.Location = new System.Drawing.Point(8, 70);
            this.RAsHrTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RAsHrTxt.Name = "RAsHrTxt";
            this.RAsHrTxt.Size = new System.Drawing.Size(132, 34);
            this.RAsHrTxt.TabIndex = 1;
            this.RAsHrTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RAsHrTxt.TextChanged += new System.EventHandler(this.RAsHrTxt_TextChanged);
            // 
            // StarFavorites
            // 
            this.StarFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.StarFavorites.FormattingEnabled = true;
            this.StarFavorites.Location = new System.Drawing.Point(81, 176);
            this.StarFavorites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StarFavorites.Name = "StarFavorites";
            this.StarFavorites.Size = new System.Drawing.Size(204, 37);
            this.StarFavorites.TabIndex = 0;
            // 
            // btnStarsBack
            // 
            this.btnStarsBack.BackColor = System.Drawing.Color.Gray;
            this.btnStarsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarsBack.Location = new System.Drawing.Point(28, 748);
            this.btnStarsBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStarsBack.Name = "btnStarsBack";
            this.btnStarsBack.Size = new System.Drawing.Size(76, 31);
            this.btnStarsBack.TabIndex = 3;
            this.btnStarsBack.Text = "Back";
            this.btnStarsBack.UseVisualStyleBackColor = false;
            // 
            // labelStars
            // 
            this.labelStars.AutoSize = true;
            this.labelStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStars.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelStars.Location = new System.Drawing.Point(20, 33);
            this.labelStars.Name = "labelStars";
            this.labelStars.Size = new System.Drawing.Size(133, 54);
            this.labelStars.TabIndex = 3;
            this.labelStars.Text = "Stars";
            // 
            // FavLbl
            // 
            this.FavLbl.AutoSize = true;
            this.FavLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FavLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FavLbl.Location = new System.Drawing.Point(76, 140);
            this.FavLbl.Name = "FavLbl";
            this.FavLbl.Size = new System.Drawing.Size(112, 29);
            this.FavLbl.TabIndex = 33;
            this.FavLbl.Text = "Favorites";
            // 
            // UserControlStars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelStars);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlStars";
            this.Size = new System.Drawing.Size(944, 798);
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
        private System.Windows.Forms.TextBox RAsHrTxt;
        private System.Windows.Forms.Label RightAscentionLbl;
        private System.Windows.Forms.Label DeclinationLbl;
        private System.Windows.Forms.TextBox DecDTxt;
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
    }
}
