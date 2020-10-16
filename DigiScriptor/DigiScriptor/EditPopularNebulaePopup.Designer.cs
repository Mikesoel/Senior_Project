namespace DigiScriptor
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
            this.btnNebulaeDelete = new System.Windows.Forms.Button();
            this.btnNebulaeSave = new System.Windows.Forms.Button();
            this.txtBoxLongitude = new System.Windows.Forms.TextBox();
            this.txtBoxLatitude = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblNebulaeLong = new System.Windows.Forms.Label();
            this.lblNebulaeLat = new System.Windows.Forms.Label();
            this.lblNebulaeName = new System.Windows.Forms.Label();
            this.nebulaeDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nebulaeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNebulaeDelete
            // 
            this.btnNebulaeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNebulaeDelete.Location = new System.Drawing.Point(429, 401);
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
            this.btnNebulaeSave.Location = new System.Drawing.Point(143, 182);
            this.btnNebulaeSave.Name = "btnNebulaeSave";
            this.btnNebulaeSave.Size = new System.Drawing.Size(75, 29);
            this.btnNebulaeSave.TabIndex = 16;
            this.btnNebulaeSave.Text = "Save";
            this.btnNebulaeSave.UseVisualStyleBackColor = true;
            this.btnNebulaeSave.Click += new System.EventHandler(this.btnNebulaeSave_Click);
            // 
            // txtBoxLongitude
            // 
            this.txtBoxLongitude.Location = new System.Drawing.Point(115, 138);
            this.txtBoxLongitude.Name = "txtBoxLongitude";
            this.txtBoxLongitude.Size = new System.Drawing.Size(135, 20);
            this.txtBoxLongitude.TabIndex = 15;
            this.txtBoxLongitude.TextChanged += new System.EventHandler(this.txtBoxLongitude_TextChanged);
            // 
            // txtBoxLatitude
            // 
            this.txtBoxLatitude.Location = new System.Drawing.Point(115, 91);
            this.txtBoxLatitude.Name = "txtBoxLatitude";
            this.txtBoxLatitude.Size = new System.Drawing.Size(135, 20);
            this.txtBoxLatitude.TabIndex = 14;
            this.txtBoxLatitude.TextChanged += new System.EventHandler(this.txtBoxLatitude_TextChanged);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(115, 43);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(135, 20);
            this.txtBoxName.TabIndex = 13;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // lblNebulaeLong
            // 
            this.lblNebulaeLong.AutoSize = true;
            this.lblNebulaeLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNebulaeLong.Location = new System.Drawing.Point(24, 136);
            this.lblNebulaeLong.Name = "lblNebulaeLong";
            this.lblNebulaeLong.Size = new System.Drawing.Size(84, 20);
            this.lblNebulaeLong.TabIndex = 12;
            this.lblNebulaeLong.Text = "Longitude ";
            // 
            // lblNebulaeLat
            // 
            this.lblNebulaeLat.AutoSize = true;
            this.lblNebulaeLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNebulaeLat.Location = new System.Drawing.Point(33, 89);
            this.lblNebulaeLat.Name = "lblNebulaeLat";
            this.lblNebulaeLat.Size = new System.Drawing.Size(75, 20);
            this.lblNebulaeLat.TabIndex = 11;
            this.lblNebulaeLat.Text = "Latitude: ";
            // 
            // lblNebulaeName
            // 
            this.lblNebulaeName.AutoSize = true;
            this.lblNebulaeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNebulaeName.Location = new System.Drawing.Point(44, 41);
            this.lblNebulaeName.Name = "lblNebulaeName";
            this.lblNebulaeName.Size = new System.Drawing.Size(55, 20);
            this.lblNebulaeName.TabIndex = 10;
            this.lblNebulaeName.Text = "Name:";
            // 
            // nebulaeDataGrid
            // 
            this.nebulaeDataGrid.AllowUserToAddRows = false;
            this.nebulaeDataGrid.AllowUserToDeleteRows = false;
            this.nebulaeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nebulaeDataGrid.Location = new System.Drawing.Point(282, 24);
            this.nebulaeDataGrid.Name = "nebulaeDataGrid";
            this.nebulaeDataGrid.RowHeadersWidth = 62;
            this.nebulaeDataGrid.Size = new System.Drawing.Size(495, 362);
            this.nebulaeDataGrid.TabIndex = 9;
            this.nebulaeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nebulaeDataGrid_CellContentClick);
            // 
            // EditPopularNebulaePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNebulaeDelete);
            this.Controls.Add(this.btnNebulaeSave);
            this.Controls.Add(this.txtBoxLongitude);
            this.Controls.Add(this.txtBoxLatitude);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblNebulaeLong);
            this.Controls.Add(this.lblNebulaeLat);
            this.Controls.Add(this.lblNebulaeName);
            this.Controls.Add(this.nebulaeDataGrid);
            this.Name = "EditPopularNebulaePopup";
            this.Text = "Add/Edit Popular Nebulae";
            this.Load += new System.EventHandler(this.EditPopularNebulaePopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nebulaeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNebulaeDelete;
        private System.Windows.Forms.Button btnNebulaeSave;
        private System.Windows.Forms.TextBox txtBoxLongitude;
        private System.Windows.Forms.TextBox txtBoxLatitude;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblNebulaeLong;
        private System.Windows.Forms.Label lblNebulaeLat;
        private System.Windows.Forms.Label lblNebulaeName;
        private System.Windows.Forms.DataGridView nebulaeDataGrid;
    }
}