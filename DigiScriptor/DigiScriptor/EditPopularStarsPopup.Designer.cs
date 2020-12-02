namespace DigiScriptor
{
    partial class EditPopularStarsPopup
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
            this.components = new System.ComponentModel.Container();
            this.StarDataBaseView = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.btnStarSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DecSecLbl = new System.Windows.Forms.Label();
            this.RAsSLbl = new System.Windows.Forms.Label();
            this.RightAscentionLbl = new System.Windows.Forms.Label();
            this.DecSecTxt = new System.Windows.Forms.TextBox();
            this.RAHrTxt = new System.Windows.Forms.TextBox();
            this.RAsMLbl = new System.Windows.Forms.Label();
            this.DecMinLbl = new System.Windows.Forms.Label();
            this.HrLbl = new System.Windows.Forms.Label();
            this.RAsSecTxt = new System.Windows.Forms.TextBox();
            this.DecMinTxt = new System.Windows.Forms.TextBox();
            this.RAsMinTxt = new System.Windows.Forms.TextBox();
            this.DecDLbl = new System.Windows.Forms.Label();
            this.DeclinationLbl = new System.Windows.Forms.Label();
            this.DecDTxt = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.digiDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digiDataBaseDataSet = new DigiScriptor.DigiDataBaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.StarDataBaseView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StarDataBaseView
            // 
            this.StarDataBaseView.AllowUserToAddRows = false;
            this.StarDataBaseView.AllowUserToDeleteRows = false;
            this.StarDataBaseView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StarDataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StarDataBaseView.Location = new System.Drawing.Point(282, 24);
            this.StarDataBaseView.Name = "StarDataBaseView";
            this.StarDataBaseView.Size = new System.Drawing.Size(506, 362);
            this.StarDataBaseView.TabIndex = 0;
            this.StarDataBaseView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(429, 401);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(192, 26);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete Selected Row";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // btnStarSave
            // 
            this.btnStarSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStarSave.Location = new System.Drawing.Point(201, 300);
            this.btnStarSave.Name = "btnStarSave";
            this.btnStarSave.Size = new System.Drawing.Size(75, 29);
            this.btnStarSave.TabIndex = 17;
            this.btnStarSave.Text = "Save";
            this.btnStarSave.UseVisualStyleBackColor = true;
            this.btnStarSave.Click += new System.EventHandler(this.btnStarSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DecSecLbl);
            this.groupBox1.Controls.Add(this.RAsSLbl);
            this.groupBox1.Controls.Add(this.RightAscentionLbl);
            this.groupBox1.Controls.Add(this.DecSecTxt);
            this.groupBox1.Controls.Add(this.RAHrTxt);
            this.groupBox1.Controls.Add(this.RAsMLbl);
            this.groupBox1.Controls.Add(this.DecMinLbl);
            this.groupBox1.Controls.Add(this.HrLbl);
            this.groupBox1.Controls.Add(this.RAsSecTxt);
            this.groupBox1.Controls.Add(this.DecMinTxt);
            this.groupBox1.Controls.Add(this.RAsMinTxt);
            this.groupBox1.Controls.Add(this.DecDLbl);
            this.groupBox1.Controls.Add(this.DeclinationLbl);
            this.groupBox1.Controls.Add(this.DecDTxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 253);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates";
            // 
            // DecSecLbl
            // 
            this.DecSecLbl.AutoSize = true;
            this.DecSecLbl.Location = new System.Drawing.Point(228, 215);
            this.DecSecLbl.Name = "DecSecLbl";
            this.DecSecLbl.Size = new System.Drawing.Size(17, 24);
            this.DecSecLbl.TabIndex = 23;
            this.DecSecLbl.Text = "\"";
            // 
            // RAsSLbl
            // 
            this.RAsSLbl.AutoSize = true;
            this.RAsSLbl.BackColor = System.Drawing.Color.Transparent;
            this.RAsSLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RAsSLbl.Location = new System.Drawing.Point(228, 98);
            this.RAsSLbl.Name = "RAsSLbl";
            this.RAsSLbl.Size = new System.Drawing.Size(17, 20);
            this.RAsSLbl.TabIndex = 16;
            this.RAsSLbl.Text = "s";
            // 
            // RightAscentionLbl
            // 
            this.RightAscentionLbl.AutoSize = true;
            this.RightAscentionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RightAscentionLbl.Location = new System.Drawing.Point(6, 25);
            this.RightAscentionLbl.Name = "RightAscentionLbl";
            this.RightAscentionLbl.Size = new System.Drawing.Size(110, 17);
            this.RightAscentionLbl.TabIndex = 2;
            this.RightAscentionLbl.Text = "Right Ascension";
            // 
            // DecSecTxt
            // 
            this.DecSecTxt.Location = new System.Drawing.Point(122, 215);
            this.DecSecTxt.Name = "DecSecTxt";
            this.DecSecTxt.Size = new System.Drawing.Size(100, 29);
            this.DecSecTxt.TabIndex = 20;
            this.DecSecTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecSecTxt.TextChanged += new System.EventHandler(this.DecSecTxt_TextChanged);
            // 
            // RAHrTxt
            // 
            this.RAHrTxt.AcceptsTab = true;
            this.RAHrTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RAHrTxt.Location = new System.Drawing.Point(122, 28);
            this.RAHrTxt.Name = "RAHrTxt";
            this.RAHrTxt.Size = new System.Drawing.Size(100, 29);
            this.RAHrTxt.TabIndex = 11;
            this.RAHrTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RAHrTxt.TextChanged += new System.EventHandler(this.RAsHrTxt_TextChanged);
            // 
            // RAsMLbl
            // 
            this.RAsMLbl.AutoSize = true;
            this.RAsMLbl.BackColor = System.Drawing.Color.Transparent;
            this.RAsMLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RAsMLbl.Location = new System.Drawing.Point(228, 63);
            this.RAsMLbl.Name = "RAsMLbl";
            this.RAsMLbl.Size = new System.Drawing.Size(22, 20);
            this.RAsMLbl.TabIndex = 15;
            this.RAsMLbl.Text = "m";
            // 
            // DecMinLbl
            // 
            this.DecMinLbl.AutoSize = true;
            this.DecMinLbl.Location = new System.Drawing.Point(228, 180);
            this.DecMinLbl.Name = "DecMinLbl";
            this.DecMinLbl.Size = new System.Drawing.Size(14, 24);
            this.DecMinLbl.TabIndex = 22;
            this.DecMinLbl.Text = "\'";
            // 
            // HrLbl
            // 
            this.HrLbl.AutoSize = true;
            this.HrLbl.BackColor = System.Drawing.Color.Transparent;
            this.HrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HrLbl.Location = new System.Drawing.Point(228, 28);
            this.HrLbl.Name = "HrLbl";
            this.HrLbl.Size = new System.Drawing.Size(18, 20);
            this.HrLbl.TabIndex = 14;
            this.HrLbl.Text = "h";
            // 
            // RAsSecTxt
            // 
            this.RAsSecTxt.Location = new System.Drawing.Point(122, 98);
            this.RAsSecTxt.Name = "RAsSecTxt";
            this.RAsSecTxt.Size = new System.Drawing.Size(100, 29);
            this.RAsSecTxt.TabIndex = 13;
            this.RAsSecTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RAsSecTxt.TextChanged += new System.EventHandler(this.RAsSecTxt_TextChanged);
            // 
            // DecMinTxt
            // 
            this.DecMinTxt.Location = new System.Drawing.Point(122, 180);
            this.DecMinTxt.Name = "DecMinTxt";
            this.DecMinTxt.Size = new System.Drawing.Size(100, 29);
            this.DecMinTxt.TabIndex = 19;
            this.DecMinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecMinTxt.TextChanged += new System.EventHandler(this.DecMinTxt_TextChanged);
            // 
            // RAsMinTxt
            // 
            this.RAsMinTxt.Location = new System.Drawing.Point(122, 63);
            this.RAsMinTxt.Name = "RAsMinTxt";
            this.RAsMinTxt.Size = new System.Drawing.Size(100, 29);
            this.RAsMinTxt.TabIndex = 12;
            this.RAsMinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RAsMinTxt.TextChanged += new System.EventHandler(this.RAsMinTxt_TextChanged);
            // 
            // DecDLbl
            // 
            this.DecDLbl.AutoSize = true;
            this.DecDLbl.Location = new System.Drawing.Point(228, 145);
            this.DecDLbl.Name = "DecDLbl";
            this.DecDLbl.Size = new System.Drawing.Size(16, 24);
            this.DecDLbl.TabIndex = 21;
            this.DecDLbl.Text = "°";
            // 
            // DeclinationLbl
            // 
            this.DeclinationLbl.AutoSize = true;
            this.DeclinationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeclinationLbl.Location = new System.Drawing.Point(6, 145);
            this.DeclinationLbl.Name = "DeclinationLbl";
            this.DeclinationLbl.Size = new System.Drawing.Size(78, 17);
            this.DeclinationLbl.TabIndex = 17;
            this.DeclinationLbl.Text = "Declination";
            // 
            // DecDTxt
            // 
            this.DecDTxt.Location = new System.Drawing.Point(122, 145);
            this.DecDTxt.Name = "DecDTxt";
            this.DecDTxt.Size = new System.Drawing.Size(100, 29);
            this.DecDTxt.TabIndex = 18;
            this.DecDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecDTxt.TextChanged += new System.EventHandler(this.DecDTxt_TextChanged);
            // 
            // NametextBox
            // 
            this.NametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NametextBox.Location = new System.Drawing.Point(12, 300);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(183, 26);
            this.NametextBox.TabIndex = 19;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Namelabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Namelabel.Location = new System.Drawing.Point(12, 280);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(45, 17);
            this.Namelabel.TabIndex = 20;
            this.Namelabel.Text = "Name";
            // 
            // digiDataBaseDataSetBindingSource
            // 
            this.digiDataBaseDataSetBindingSource.DataSource = this.digiDataBaseDataSet;
            this.digiDataBaseDataSetBindingSource.Position = 0;
            // 
            // digiDataBaseDataSet
            // 
            this.digiDataBaseDataSet.DataSetName = "DigiDataBaseDataSet";
            this.digiDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EditPopularStarsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStarSave);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.StarDataBaseView);
            this.Name = "EditPopularStarsPopup";
            this.Text = "Edit Popular Stars";
            this.Load += new System.EventHandler(this.EditPopularStarsPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StarDataBaseView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StarDataBaseView;
        private System.Windows.Forms.BindingSource digiDataBaseDataSetBindingSource;
        private DigiDataBaseDataSet digiDataBaseDataSet;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button btnStarSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label RightAscentionLbl;
        private System.Windows.Forms.Label RAsSLbl;
        private System.Windows.Forms.TextBox RAHrTxt;
        private System.Windows.Forms.Label RAsMLbl;
        private System.Windows.Forms.Label HrLbl;
        private System.Windows.Forms.TextBox RAsSecTxt;
        private System.Windows.Forms.TextBox RAsMinTxt;
        private System.Windows.Forms.Label DecSecLbl;
        private System.Windows.Forms.TextBox DecSecTxt;
        private System.Windows.Forms.Label DecMinLbl;
        private System.Windows.Forms.TextBox DecMinTxt;
        private System.Windows.Forms.Label DecDLbl;
        private System.Windows.Forms.Label DeclinationLbl;
        private System.Windows.Forms.TextBox DecDTxt;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label Namelabel;
    }
}