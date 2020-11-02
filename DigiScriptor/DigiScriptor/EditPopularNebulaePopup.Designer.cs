﻿namespace DigiScriptor
{
    partial class EditPopularNebulaePopup
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
            this.btnNebulaeDelete = new System.Windows.Forms.Button();
            this.btnNebulaeSave = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblNebulaeName = new System.Windows.Forms.Label();
            this.nebulaeDataGrid = new System.Windows.Forms.DataGridView();
            this.nebulaeFavoritesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.digiDataBaseDataSet = new DigiScriptor.DigiDataBaseDataSet();
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
            this.lblSciName = new System.Windows.Forms.Label();
            this.txtBoxSciName = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.nebulaeFavoritesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nebulaeFavoritesTableAdapter = new DigiScriptor.DigiDataBaseDataSetTableAdapters.NebulaeFavoritesTableAdapter();
            this.nebulaeFavoritesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.editRowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nebulaeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nebulaeFavoritesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSet)).BeginInit();
            this.CoordinateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nebulaeFavoritesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nebulaeFavoritesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNebulaeDelete
            // 
            this.btnNebulaeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNebulaeDelete.Location = new System.Drawing.Point(660, 678);
            this.btnNebulaeDelete.Name = "btnNebulaeDelete";
            this.btnNebulaeDelete.Size = new System.Drawing.Size(192, 26);
            this.btnNebulaeDelete.TabIndex = 17;
            this.btnNebulaeDelete.Text = "Delete Selected Row";
            this.btnNebulaeDelete.UseVisualStyleBackColor = true;
            this.btnNebulaeDelete.Click += new System.EventHandler(this.btnNebulaeDelete_Click);
            // 
            // btnNebulaeSave
            // 
            this.btnNebulaeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNebulaeSave.Location = new System.Drawing.Point(243, 274);
            this.btnNebulaeSave.Name = "btnNebulaeSave";
            this.btnNebulaeSave.Size = new System.Drawing.Size(75, 29);
            this.btnNebulaeSave.TabIndex = 16;
            this.btnNebulaeSave.Text = "Save";
            this.btnNebulaeSave.UseVisualStyleBackColor = true;
            this.btnNebulaeSave.Click += new System.EventHandler(this.btnNebulaeSave_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(281, 49);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(174, 20);
            this.txtBoxName.TabIndex = 13;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // lblNebulaeName
            // 
            this.lblNebulaeName.AutoSize = true;
            this.lblNebulaeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNebulaeName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNebulaeName.Location = new System.Drawing.Point(147, 49);
            this.lblNebulaeName.Name = "lblNebulaeName";
            this.lblNebulaeName.Size = new System.Drawing.Size(123, 20);
            this.lblNebulaeName.TabIndex = 10;
            this.lblNebulaeName.Text = "Common Name:";
            // 
            // nebulaeDataGrid
            // 
            this.nebulaeDataGrid.AllowUserToAddRows = false;
            this.nebulaeDataGrid.AllowUserToDeleteRows = false;
            this.nebulaeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nebulaeDataGrid.Location = new System.Drawing.Point(141, 320);
            this.nebulaeDataGrid.Name = "nebulaeDataGrid";
            this.nebulaeDataGrid.RowHeadersWidth = 62;
            this.nebulaeDataGrid.Size = new System.Drawing.Size(941, 339);
            this.nebulaeDataGrid.TabIndex = 9;
            // 
            // nebulaeFavoritesBindingSource2
            // 
            this.nebulaeFavoritesBindingSource2.DataMember = "NebulaeFavorites";
            this.nebulaeFavoritesBindingSource2.DataSource = this.digiDataBaseDataSet;
            // 
            // digiDataBaseDataSet
            // 
            this.digiDataBaseDataSet.DataSetName = "DigiDataBaseDataSet";
            this.digiDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.CoordinateBox.Location = new System.Drawing.Point(145, 104);
            this.CoordinateBox.Name = "CoordinateBox";
            this.CoordinateBox.Size = new System.Drawing.Size(400, 164);
            this.CoordinateBox.TabIndex = 33;
            this.CoordinateBox.TabStop = false;
            this.CoordinateBox.Text = "Coordinates";
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
            // DecDTxt
            // 
            this.DecDTxt.Location = new System.Drawing.Point(6, 116);
            this.DecDTxt.Name = "DecDTxt";
            this.DecDTxt.Size = new System.Drawing.Size(100, 29);
            this.DecDTxt.TabIndex = 4;
            this.DecDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DecDTxt.TextChanged += new System.EventHandler(this.DecDTxt_TextChanged);
            // 
            // DeclinationLbl
            // 
            this.DeclinationLbl.AutoSize = true;
            this.DeclinationLbl.Location = new System.Drawing.Point(7, 90);
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
            // RAsHrTxt
            // 
            this.RAsHrTxt.AcceptsTab = true;
            this.RAsHrTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RAsHrTxt.Location = new System.Drawing.Point(6, 57);
            this.RAsHrTxt.Name = "RAsHrTxt";
            this.RAsHrTxt.Size = new System.Drawing.Size(100, 29);
            this.RAsHrTxt.TabIndex = 1;
            this.RAsHrTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RAsHrTxt.TextChanged += new System.EventHandler(this.RAsHrTxt_TextChanged);
            // 
            // lblSciName
            // 
            this.lblSciName.AutoSize = true;
            this.lblSciName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSciName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSciName.Location = new System.Drawing.Point(129, 79);
            this.lblSciName.Name = "lblSciName";
            this.lblSciName.Size = new System.Drawing.Size(141, 20);
            this.lblSciName.TabIndex = 34;
            this.lblSciName.Text = "Scientific Name(s):";
            // 
            // txtBoxSciName
            // 
            this.txtBoxSciName.Location = new System.Drawing.Point(281, 81);
            this.txtBoxSciName.Name = "txtBoxSciName";
            this.txtBoxSciName.Size = new System.Drawing.Size(174, 20);
            this.txtBoxSciName.TabIndex = 35;
            this.txtBoxSciName.TextChanged += new System.EventHandler(this.txtBoxSciName_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearButton.Location = new System.Drawing.Point(367, 274);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 29);
            this.clearButton.TabIndex = 36;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Location = new System.Drawing.Point(628, 161);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 37;
            this.lblSearch.Text = "Search: ";
            // 
            // searchTxt
            // 
            this.searchTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchTxt.Location = new System.Drawing.Point(702, 161);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(206, 20);
            this.searchTxt.TabIndex = 38;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // nebulaeFavoritesBindingSource
            // 
            this.nebulaeFavoritesBindingSource.DataMember = "NebulaeFavorites";
            this.nebulaeFavoritesBindingSource.DataSource = this.digiDataBaseDataSet;
            // 
            // nebulaeFavoritesTableAdapter
            // 
            this.nebulaeFavoritesTableAdapter.ClearBeforeFill = true;
            // 
            // nebulaeFavoritesBindingSource1
            // 
            this.nebulaeFavoritesBindingSource1.DataMember = "NebulaeFavorites";
            this.nebulaeFavoritesBindingSource1.DataSource = this.digiDataBaseDataSet;
            // 
            // editRowBtn
            // 
            this.editRowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editRowBtn.Location = new System.Drawing.Point(391, 678);
            this.editRowBtn.Name = "editRowBtn";
            this.editRowBtn.Size = new System.Drawing.Size(192, 26);
            this.editRowBtn.TabIndex = 39;
            this.editRowBtn.Text = "Edit Selected Row";
            this.editRowBtn.UseVisualStyleBackColor = true;
            this.editRowBtn.Click += new System.EventHandler(this.editRowBtn_Click);
            // 
            // EditPopularNebulaePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 731);
            this.Controls.Add(this.editRowBtn);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.txtBoxSciName);
            this.Controls.Add(this.lblSciName);
            this.Controls.Add(this.CoordinateBox);
            this.Controls.Add(this.btnNebulaeDelete);
            this.Controls.Add(this.btnNebulaeSave);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblNebulaeName);
            this.Controls.Add(this.nebulaeDataGrid);
            this.Name = "EditPopularNebulaePopup";
            this.Text = "Add/Edit Popular Nebulae";
            this.Load += new System.EventHandler(this.EditPopularNebulaePopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nebulaeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nebulaeFavoritesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSet)).EndInit();
            this.CoordinateBox.ResumeLayout(false);
            this.CoordinateBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nebulaeFavoritesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nebulaeFavoritesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNebulaeDelete;
        private System.Windows.Forms.Button btnNebulaeSave;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblNebulaeName;
        private System.Windows.Forms.DataGridView nebulaeDataGrid;
        private System.Windows.Forms.GroupBox CoordinateBox;
        private System.Windows.Forms.Label DecSecLbl;
        private System.Windows.Forms.TextBox DecSecTxt;
        private System.Windows.Forms.Label DecMinLbl;
        private System.Windows.Forms.TextBox DecMinTxt;
        private System.Windows.Forms.Label DecDLbl;
        private System.Windows.Forms.Label RAsSLbl;
        private System.Windows.Forms.Label RAsMLbl;
        private System.Windows.Forms.Label HrLbl;
        private System.Windows.Forms.TextBox RAsSecTxt;
        private System.Windows.Forms.TextBox RAsMinTxt;
        private System.Windows.Forms.TextBox DecDTxt;
        private System.Windows.Forms.Label DeclinationLbl;
        private System.Windows.Forms.Label RightAscentionLbl;
        private System.Windows.Forms.TextBox RAsHrTxt;
        private System.Windows.Forms.Label lblSciName;
        private System.Windows.Forms.TextBox txtBoxSciName;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox searchTxt;
        private DigiDataBaseDataSet digiDataBaseDataSet;
        private System.Windows.Forms.BindingSource nebulaeFavoritesBindingSource;
        private DigiDataBaseDataSetTableAdapters.NebulaeFavoritesTableAdapter nebulaeFavoritesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nebulaeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDEGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsecDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nebulaeFavoritesBindingSource1;
        private System.Windows.Forms.BindingSource nebulaeFavoritesBindingSource2;
        private System.Windows.Forms.Button editRowBtn;
    }
}