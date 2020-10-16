namespace DigiScriptor
{
    partial class EditPopularEarthLocationsPopup
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.popupLabel1 = new System.Windows.Forms.Label();
            this.popupLabel2 = new System.Windows.Forms.Label();
            this.popupLabel3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.dataSave = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(742, 557);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // popupLabel1
            // 
            this.popupLabel1.AutoSize = true;
            this.popupLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.popupLabel1.Location = new System.Drawing.Point(48, 80);
            this.popupLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.popupLabel1.Name = "popupLabel1";
            this.popupLabel1.Size = new System.Drawing.Size(84, 29);
            this.popupLabel1.TabIndex = 1;
            this.popupLabel1.Text = "Name:";
            // 
            // popupLabel2
            // 
            this.popupLabel2.AutoSize = true;
            this.popupLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.popupLabel2.Location = new System.Drawing.Point(32, 154);
            this.popupLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.popupLabel2.Name = "popupLabel2";
            this.popupLabel2.Size = new System.Drawing.Size(110, 29);
            this.popupLabel2.TabIndex = 2;
            this.popupLabel2.Text = "Latitude: ";
            // 
            // popupLabel3
            // 
            this.popupLabel3.AutoSize = true;
            this.popupLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.popupLabel3.Location = new System.Drawing.Point(18, 226);
            this.popupLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.popupLabel3.Name = "popupLabel3";
            this.popupLabel3.Size = new System.Drawing.Size(126, 29);
            this.popupLabel3.TabIndex = 3;
            this.popupLabel3.Text = "Longitude ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(154, 83);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 26);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Location = new System.Drawing.Point(154, 157);
            this.latitudeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(200, 26);
            this.latitudeTextBox.TabIndex = 5;
            this.latitudeTextBox.TextChanged += new System.EventHandler(this.latitudeTextBox_TextChanged);
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.Location = new System.Drawing.Point(154, 229);
            this.longitudeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(200, 26);
            this.longitudeTextBox.TabIndex = 6;
            this.longitudeTextBox.TextChanged += new System.EventHandler(this.longitudeTextBox_TextChanged);
            // 
            // dataSave
            // 
            this.dataSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataSave.Location = new System.Drawing.Point(196, 297);
            this.dataSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataSave.Name = "dataSave";
            this.dataSave.Size = new System.Drawing.Size(112, 45);
            this.dataSave.TabIndex = 7;
            this.dataSave.Text = "Save";
            this.dataSave.UseVisualStyleBackColor = true;
            this.dataSave.Click += new System.EventHandler(this.dataSave_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteButton.Location = new System.Drawing.Point(626, 634);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(288, 40);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete Selected Row";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditPopularEarthLocationsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataSave);
            this.Controls.Add(this.longitudeTextBox);
            this.Controls.Add(this.latitudeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.popupLabel3);
            this.Controls.Add(this.popupLabel2);
            this.Controls.Add(this.popupLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditPopularEarthLocationsPopup";
            this.Text = "Add/Edit Popular Locations";
            this.Load += new System.EventHandler(this.EditPopularEarthLocationsPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label popupLabel1;
        private System.Windows.Forms.Label popupLabel2;
        private System.Windows.Forms.Label popupLabel3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.Button dataSave;
        private System.Windows.Forms.Button deleteButton;
    }
}