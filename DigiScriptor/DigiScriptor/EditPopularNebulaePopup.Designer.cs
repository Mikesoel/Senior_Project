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
            this.btnNebulaeDelete.Location = new System.Drawing.Point(644, 617);
            this.btnNebulaeDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNebulaeDelete.Name = "btnNebulaeDelete";
            this.btnNebulaeDelete.Size = new System.Drawing.Size(288, 40);
            this.btnNebulaeDelete.TabIndex = 17;
            this.btnNebulaeDelete.Text = "Delete Selected Row";
            this.btnNebulaeDelete.UseVisualStyleBackColor = true;
            this.btnNebulaeDelete.Click += new System.EventHandler(this.btnNebulaeDelete_Click);
            // 
            // btnNebulaeSave
            // 
            this.btnNebulaeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNebulaeSave.Location = new System.Drawing.Point(214, 280);
            this.btnNebulaeSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNebulaeSave.Name = "btnNebulaeSave";
            this.btnNebulaeSave.Size = new System.Drawing.Size(112, 45);
            this.btnNebulaeSave.TabIndex = 16;
            this.btnNebulaeSave.Text = "Save";
            this.btnNebulaeSave.UseVisualStyleBackColor = true;
            this.btnNebulaeSave.Click += new System.EventHandler(this.btnNebulaeSave_Click);
            // 
            // txtBoxLongitude
            // 
            this.txtBoxLongitude.Location = new System.Drawing.Point(172, 212);
            this.txtBoxLongitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxLongitude.Name = "txtBoxLongitude";
            this.txtBoxLongitude.Size = new System.Drawing.Size(200, 26);
            this.txtBoxLongitude.TabIndex = 15;
            this.txtBoxLongitude.TextChanged += new System.EventHandler(this.txtBoxLongitude_TextChanged);
            // 
            // txtBoxLatitude
            // 
            this.txtBoxLatitude.Location = new System.Drawing.Point(172, 140);
            this.txtBoxLatitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxLatitude.Name = "txtBoxLatitude";
            this.txtBoxLatitude.Size = new System.Drawing.Size(200, 26);
            this.txtBoxLatitude.TabIndex = 14;
            this.txtBoxLatitude.TextChanged += new System.EventHandler(this.txtBoxLatitude_TextChanged);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(172, 66);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(200, 26);
            this.txtBoxName.TabIndex = 13;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // lblNebulaeLong
            // 
            this.lblNebulaeLong.AutoSize = true;
            this.lblNebulaeLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNebulaeLong.Location = new System.Drawing.Point(36, 209);
            this.lblNebulaeLong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNebulaeLong.Name = "lblNebulaeLong";
            this.lblNebulaeLong.Size = new System.Drawing.Size(126, 29);
            this.lblNebulaeLong.TabIndex = 12;
            this.lblNebulaeLong.Text = "Longitude ";
            // 
            // lblNebulaeLat
            // 
            this.lblNebulaeLat.AutoSize = true;
            this.lblNebulaeLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNebulaeLat.Location = new System.Drawing.Point(50, 137);
            this.lblNebulaeLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNebulaeLat.Name = "lblNebulaeLat";
            this.lblNebulaeLat.Size = new System.Drawing.Size(110, 29);
            this.lblNebulaeLat.TabIndex = 11;
            this.lblNebulaeLat.Text = "Latitude: ";
            // 
            // lblNebulaeName
            // 
            this.lblNebulaeName.AutoSize = true;
            this.lblNebulaeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNebulaeName.Location = new System.Drawing.Point(66, 63);
            this.lblNebulaeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNebulaeName.Name = "lblNebulaeName";
            this.lblNebulaeName.Size = new System.Drawing.Size(84, 29);
            this.lblNebulaeName.TabIndex = 10;
            this.lblNebulaeName.Text = "Name:";
            // 
            // nebulaeDataGrid
            // 
            this.nebulaeDataGrid.AllowUserToAddRows = false;
            this.nebulaeDataGrid.AllowUserToDeleteRows = false;
            this.nebulaeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nebulaeDataGrid.Location = new System.Drawing.Point(423, 37);
            this.nebulaeDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nebulaeDataGrid.Name = "nebulaeDataGrid";
            this.nebulaeDataGrid.RowHeadersWidth = 62;
            this.nebulaeDataGrid.Size = new System.Drawing.Size(742, 557);
            this.nebulaeDataGrid.TabIndex = 9;
            // 
            // EditPopularNebulaePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnNebulaeDelete);
            this.Controls.Add(this.btnNebulaeSave);
            this.Controls.Add(this.txtBoxLongitude);
            this.Controls.Add(this.txtBoxLatitude);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblNebulaeLong);
            this.Controls.Add(this.lblNebulaeLat);
            this.Controls.Add(this.lblNebulaeName);
            this.Controls.Add(this.nebulaeDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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