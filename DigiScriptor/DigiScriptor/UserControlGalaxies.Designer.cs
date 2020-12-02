namespace DigiScriptor
{
    partial class UserControlGalaxies
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
            this.components = new System.ComponentModel.Container();
            this.panelGalaxies = new System.Windows.Forms.Panel();
            this.lblDuration = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.btnSearchGalaxies = new System.Windows.Forms.Button();
            this.lblSearchGalaxies = new System.Windows.Forms.Label();
            this.btnSubmitGalaxy = new System.Windows.Forms.Button();
            this.lblGalaxiesOutput = new System.Windows.Forms.Label();
            this.btnGalaxiesBack = new System.Windows.Forms.Button();
            this.lblGalaxyDestination = new System.Windows.Forms.Label();
            this.lblGalaxyFavorites = new System.Windows.Forms.Label();
            this.btnTriangulum = new System.Windows.Forms.Button();
            this.btnWhirlpool = new System.Windows.Forms.Button();
            this.btnLargeMagCloud = new System.Windows.Forms.Button();
            this.btnSombrero = new System.Windows.Forms.Button();
            this.btnMilkyWay = new System.Windows.Forms.Button();
            this.comboBoxGalaxies = new System.Windows.Forms.ComboBox();
            this.lblGalaxies = new System.Windows.Forms.Label();
            this.btnAndromeda = new System.Windows.Forms.Button();
            this.digiDataBaseDataSet = new DigiScriptor.DigiDataBaseDataSet();
            this.digiDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelGalaxies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGalaxies
            // 
            this.panelGalaxies.Controls.Add(this.lblDuration);
            this.panelGalaxies.Controls.Add(this.textBoxDuration);
            this.panelGalaxies.Controls.Add(this.btnSearchGalaxies);
            this.panelGalaxies.Controls.Add(this.lblSearchGalaxies);
            this.panelGalaxies.Controls.Add(this.btnSubmitGalaxy);
            this.panelGalaxies.Controls.Add(this.lblGalaxiesOutput);
            this.panelGalaxies.Controls.Add(this.btnGalaxiesBack);
            this.panelGalaxies.Controls.Add(this.lblGalaxyDestination);
            this.panelGalaxies.Controls.Add(this.lblGalaxyFavorites);
            this.panelGalaxies.Controls.Add(this.btnTriangulum);
            this.panelGalaxies.Controls.Add(this.btnWhirlpool);
            this.panelGalaxies.Controls.Add(this.btnLargeMagCloud);
            this.panelGalaxies.Controls.Add(this.btnSombrero);
            this.panelGalaxies.Controls.Add(this.btnMilkyWay);
            this.panelGalaxies.Controls.Add(this.comboBoxGalaxies);
            this.panelGalaxies.Controls.Add(this.lblGalaxies);
            this.panelGalaxies.Controls.Add(this.btnAndromeda);
            this.panelGalaxies.Location = new System.Drawing.Point(0, 3);
            this.panelGalaxies.Name = "panelGalaxies";
            this.panelGalaxies.Size = new System.Drawing.Size(1062, 994);
            this.panelGalaxies.TabIndex = 27;
            this.panelGalaxies.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGalaxies_Paint);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblDuration.Location = new System.Drawing.Point(763, 732);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(129, 28);
            this.lblDuration.TabIndex = 33;
            this.lblDuration.Text = "Duration (s):";
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(898, 736);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 26);
            this.textBoxDuration.TabIndex = 32;
            this.textBoxDuration.TextChanged += new System.EventHandler(this.textBoxDuration_TextChanged);
            // 
            // btnSearchGalaxies
            // 
            this.btnSearchGalaxies.Location = new System.Drawing.Point(731, 330);
            this.btnSearchGalaxies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchGalaxies.Name = "btnSearchGalaxies";
            this.btnSearchGalaxies.Size = new System.Drawing.Size(112, 35);
            this.btnSearchGalaxies.TabIndex = 31;
            this.btnSearchGalaxies.Text = "Search";
            this.btnSearchGalaxies.UseVisualStyleBackColor = true;
            this.btnSearchGalaxies.Click += new System.EventHandler(this.btnSearchGalaxies_Click);
            // 
            // lblSearchGalaxies
            // 
            this.lblSearchGalaxies.AutoSize = true;
            this.lblSearchGalaxies.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchGalaxies.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblSearchGalaxies.Location = new System.Drawing.Point(726, 253);
            this.lblSearchGalaxies.Name = "lblSearchGalaxies";
            this.lblSearchGalaxies.Size = new System.Drawing.Size(132, 28);
            this.lblSearchGalaxies.TabIndex = 30;
            this.lblSearchGalaxies.Text = "Quick Search";
            // 
            // btnSubmitGalaxy
            // 
            this.btnSubmitGalaxy.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitGalaxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitGalaxy.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitGalaxy.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitGalaxy.Location = new System.Drawing.Point(786, 792);
            this.btnSubmitGalaxy.Name = "btnSubmitGalaxy";
            this.btnSubmitGalaxy.Size = new System.Drawing.Size(186, 75);
            this.btnSubmitGalaxy.TabIndex = 29;
            this.btnSubmitGalaxy.Text = "Submit";
            this.btnSubmitGalaxy.UseVisualStyleBackColor = false;
            this.btnSubmitGalaxy.Click += new System.EventHandler(this.btnSubmitGalaxy_Click);
            // 
            // lblGalaxiesOutput
            // 
            this.lblGalaxiesOutput.BackColor = System.Drawing.Color.Silver;
            this.lblGalaxiesOutput.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalaxiesOutput.ForeColor = System.Drawing.Color.Black;
            this.lblGalaxiesOutput.Location = new System.Drawing.Point(760, 524);
            this.lblGalaxiesOutput.Name = "lblGalaxiesOutput";
            this.lblGalaxiesOutput.Size = new System.Drawing.Size(242, 180);
            this.lblGalaxiesOutput.TabIndex = 28;
            this.lblGalaxiesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGalaxiesOutput.Click += new System.EventHandler(this.lblGalaxiesOutput_Click);
            // 
            // btnGalaxiesBack
            // 
            this.btnGalaxiesBack.BackColor = System.Drawing.Color.Gray;
            this.btnGalaxiesBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGalaxiesBack.Location = new System.Drawing.Point(34, 930);
            this.btnGalaxiesBack.Name = "btnGalaxiesBack";
            this.btnGalaxiesBack.Size = new System.Drawing.Size(85, 39);
            this.btnGalaxiesBack.TabIndex = 27;
            this.btnGalaxiesBack.Text = "Back";
            this.btnGalaxiesBack.UseVisualStyleBackColor = false;
            this.btnGalaxiesBack.Click += new System.EventHandler(this.btnGalaxiesBack_Click);
            // 
            // lblGalaxyDestination
            // 
            this.lblGalaxyDestination.AutoSize = true;
            this.lblGalaxyDestination.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalaxyDestination.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblGalaxyDestination.Location = new System.Drawing.Point(788, 461);
            this.lblGalaxyDestination.Name = "lblGalaxyDestination";
            this.lblGalaxyDestination.Size = new System.Drawing.Size(183, 43);
            this.lblGalaxyDestination.TabIndex = 26;
            this.lblGalaxyDestination.Text = "Destination:";
            // 
            // lblGalaxyFavorites
            // 
            this.lblGalaxyFavorites.AutoSize = true;
            this.lblGalaxyFavorites.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalaxyFavorites.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblGalaxyFavorites.Location = new System.Drawing.Point(295, 213);
            this.lblGalaxyFavorites.Name = "lblGalaxyFavorites";
            this.lblGalaxyFavorites.Size = new System.Drawing.Size(143, 43);
            this.lblGalaxyFavorites.TabIndex = 25;
            this.lblGalaxyFavorites.Text = "Favorites";
            // 
            // btnTriangulum
            // 
            this.btnTriangulum.BackColor = System.Drawing.Color.DimGray;
            this.btnTriangulum.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriangulum.ForeColor = System.Drawing.Color.Black;
            this.btnTriangulum.Location = new System.Drawing.Point(390, 636);
            this.btnTriangulum.Name = "btnTriangulum";
            this.btnTriangulum.Size = new System.Drawing.Size(249, 112);
            this.btnTriangulum.TabIndex = 24;
            this.btnTriangulum.Text = "Triangulum";
            this.btnTriangulum.UseVisualStyleBackColor = false;
            this.btnTriangulum.Click += new System.EventHandler(this.btnTriangulum_Click);
            // 
            // btnWhirlpool
            // 
            this.btnWhirlpool.BackColor = System.Drawing.Color.DimGray;
            this.btnWhirlpool.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhirlpool.ForeColor = System.Drawing.Color.Black;
            this.btnWhirlpool.Location = new System.Drawing.Point(390, 459);
            this.btnWhirlpool.Name = "btnWhirlpool";
            this.btnWhirlpool.Size = new System.Drawing.Size(249, 112);
            this.btnWhirlpool.TabIndex = 23;
            this.btnWhirlpool.Text = "Whirlpool";
            this.btnWhirlpool.UseVisualStyleBackColor = false;
            this.btnWhirlpool.Click += new System.EventHandler(this.btnWhirlpool_Click);
            // 
            // btnLargeMagCloud
            // 
            this.btnLargeMagCloud.BackColor = System.Drawing.Color.DimGray;
            this.btnLargeMagCloud.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargeMagCloud.ForeColor = System.Drawing.Color.Black;
            this.btnLargeMagCloud.Location = new System.Drawing.Point(91, 459);
            this.btnLargeMagCloud.Name = "btnLargeMagCloud";
            this.btnLargeMagCloud.Size = new System.Drawing.Size(249, 112);
            this.btnLargeMagCloud.TabIndex = 22;
            this.btnLargeMagCloud.Text = "Pinwheel";
            this.btnLargeMagCloud.UseVisualStyleBackColor = false;
            this.btnLargeMagCloud.Click += new System.EventHandler(this.btnLargeMagCloud_Click);
            // 
            // btnSombrero
            // 
            this.btnSombrero.BackColor = System.Drawing.Color.DimGray;
            this.btnSombrero.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSombrero.ForeColor = System.Drawing.Color.Black;
            this.btnSombrero.Location = new System.Drawing.Point(91, 636);
            this.btnSombrero.Name = "btnSombrero";
            this.btnSombrero.Size = new System.Drawing.Size(249, 112);
            this.btnSombrero.TabIndex = 21;
            this.btnSombrero.Text = "Sombrero";
            this.btnSombrero.UseVisualStyleBackColor = false;
            this.btnSombrero.Click += new System.EventHandler(this.btnSombrero_Click);
            // 
            // btnMilkyWay
            // 
            this.btnMilkyWay.BackColor = System.Drawing.Color.DimGray;
            this.btnMilkyWay.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilkyWay.ForeColor = System.Drawing.Color.Black;
            this.btnMilkyWay.Location = new System.Drawing.Point(91, 284);
            this.btnMilkyWay.Name = "btnMilkyWay";
            this.btnMilkyWay.Size = new System.Drawing.Size(249, 112);
            this.btnMilkyWay.TabIndex = 20;
            this.btnMilkyWay.Text = "Milky Way";
            this.btnMilkyWay.UseVisualStyleBackColor = false;
            this.btnMilkyWay.Click += new System.EventHandler(this.btnMilkyWay_Click);
            // 
            // comboBoxGalaxies
            // 
            this.comboBoxGalaxies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxGalaxies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGalaxies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGalaxies.FormattingEnabled = true;
            this.comboBoxGalaxies.Location = new System.Drawing.Point(731, 284);
            this.comboBoxGalaxies.Name = "comboBoxGalaxies";
            this.comboBoxGalaxies.Size = new System.Drawing.Size(296, 37);
            this.comboBoxGalaxies.Sorted = true;
            this.comboBoxGalaxies.TabIndex = 19;
            this.comboBoxGalaxies.SelectedIndexChanged += new System.EventHandler(this.comboBoxGalaxies_SelectedIndexChanged);
            // 
            // lblGalaxies
            // 
            this.lblGalaxies.AutoSize = true;
            this.lblGalaxies.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalaxies.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblGalaxies.Location = new System.Drawing.Point(22, 42);
            this.lblGalaxies.Name = "lblGalaxies";
            this.lblGalaxies.Size = new System.Drawing.Size(211, 67);
            this.lblGalaxies.TabIndex = 18;
            this.lblGalaxies.Text = "Galaxies";
            // 
            // btnAndromeda
            // 
            this.btnAndromeda.BackColor = System.Drawing.Color.DimGray;
            this.btnAndromeda.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAndromeda.ForeColor = System.Drawing.Color.Black;
            this.btnAndromeda.Location = new System.Drawing.Point(390, 284);
            this.btnAndromeda.Name = "btnAndromeda";
            this.btnAndromeda.Size = new System.Drawing.Size(249, 112);
            this.btnAndromeda.TabIndex = 17;
            this.btnAndromeda.Text = "Andromeda";
            this.btnAndromeda.UseVisualStyleBackColor = false;
            this.btnAndromeda.Click += new System.EventHandler(this.btnAndromeda_Click);
            // 
            // digiDataBaseDataSet
            // 
            this.digiDataBaseDataSet.DataSetName = "DigiDataBaseDataSet";
            this.digiDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // digiDataBaseDataSetBindingSource
            // 
            this.digiDataBaseDataSetBindingSource.DataSource = this.digiDataBaseDataSet;
            this.digiDataBaseDataSetBindingSource.Position = 0;
            // 
            // UserControlGalaxies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelGalaxies);
            this.Name = "UserControlGalaxies";
            this.Size = new System.Drawing.Size(1062, 997);
            this.Load += new System.EventHandler(this.UserControlGalaxies_Load);
            this.panelGalaxies.ResumeLayout(false);
            this.panelGalaxies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGalaxies;
        public System.Windows.Forms.Button btnSubmitGalaxy;
        public System.Windows.Forms.Label lblGalaxiesOutput;
        public System.Windows.Forms.Button btnGalaxiesBack;
        private System.Windows.Forms.Label lblGalaxyDestination;
        private System.Windows.Forms.Label lblGalaxyFavorites;
        private System.Windows.Forms.Button btnTriangulum;
        private System.Windows.Forms.Button btnWhirlpool;
        private System.Windows.Forms.Button btnLargeMagCloud;
        private System.Windows.Forms.Button btnSombrero;
        private System.Windows.Forms.Button btnMilkyWay;
        private System.Windows.Forms.ComboBox comboBoxGalaxies;
        private System.Windows.Forms.Label lblGalaxies;
        private System.Windows.Forms.Button btnAndromeda;
        private System.Windows.Forms.Label lblSearchGalaxies;
        private DigiDataBaseDataSet digiDataBaseDataSet;
        private System.Windows.Forms.BindingSource digiDataBaseDataSetBindingSource;
        private System.Windows.Forms.Button btnSearchGalaxies;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox textBoxDuration;
    }
}
