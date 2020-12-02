namespace DigiScriptor
{
    partial class SearchGalaxiesPopup
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
            this.galaxyDataGrid = new System.Windows.Forms.DataGridView();
            this.searchGalaxyTxt = new System.Windows.Forms.TextBox();
            this.lblSearchGalaxy = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.galaxyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // galaxyDataGrid
            // 
            this.galaxyDataGrid.AllowUserToAddRows = false;
            this.galaxyDataGrid.AllowUserToDeleteRows = false;
            this.galaxyDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.galaxyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.galaxyDataGrid.Location = new System.Drawing.Point(401, 60);
            this.galaxyDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.galaxyDataGrid.Name = "galaxyDataGrid";
            this.galaxyDataGrid.RowHeadersWidth = 62;
            this.galaxyDataGrid.Size = new System.Drawing.Size(759, 557);
            this.galaxyDataGrid.TabIndex = 1;
            // 
            // searchGalaxyTxt
            // 
            this.searchGalaxyTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchGalaxyTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchGalaxyTxt.Location = new System.Drawing.Point(53, 138);
            this.searchGalaxyTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchGalaxyTxt.Name = "searchGalaxyTxt";
            this.searchGalaxyTxt.Size = new System.Drawing.Size(307, 26);
            this.searchGalaxyTxt.TabIndex = 40;
            this.searchGalaxyTxt.TextChanged += new System.EventHandler(this.searchGalaxyTxt_TextChanged);
            // 
            // lblSearchGalaxy
            // 
            this.lblSearchGalaxy.AutoSize = true;
            this.lblSearchGalaxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchGalaxy.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearchGalaxy.Location = new System.Drawing.Point(48, 104);
            this.lblSearchGalaxy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchGalaxy.Name = "lblSearchGalaxy";
            this.lblSearchGalaxy.Size = new System.Drawing.Size(101, 29);
            this.lblSearchGalaxy.TabIndex = 39;
            this.lblSearchGalaxy.Text = "Search: ";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSelect.Location = new System.Drawing.Point(72, 577);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(288, 40);
            this.btnSelect.TabIndex = 101;
            this.btnSelect.Text = "Select Row For Show";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // SearchGalaxiesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.searchGalaxyTxt);
            this.Controls.Add(this.lblSearchGalaxy);
            this.Controls.Add(this.galaxyDataGrid);
            this.MaximizeBox = false;
            this.Name = "SearchGalaxiesPopup";
            this.Text = "Search/Edit Galaxies";
            ((System.ComponentModel.ISupportInitialize)(this.galaxyDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView galaxyDataGrid;
        private System.Windows.Forms.TextBox searchGalaxyTxt;
        private System.Windows.Forms.Label lblSearchGalaxy;
        private System.Windows.Forms.Button btnSelect;
    }
}