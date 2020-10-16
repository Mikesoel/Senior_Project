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
            this.digiDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digiDataBaseDataSet = new DigiScriptor.DigiDataBaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.StarDataBaseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StarDataBaseView
            // 
            this.StarDataBaseView.AllowUserToAddRows = false;
            this.StarDataBaseView.AllowUserToDeleteRows = false;
            this.StarDataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StarDataBaseView.Location = new System.Drawing.Point(282, 24);
            this.StarDataBaseView.Name = "StarDataBaseView";
            this.StarDataBaseView.Size = new System.Drawing.Size(495, 362);
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
            this.btnStarSave.Location = new System.Drawing.Point(107, 295);
            this.btnStarSave.Name = "btnStarSave";
            this.btnStarSave.Size = new System.Drawing.Size(75, 29);
            this.btnStarSave.TabIndex = 17;
            this.btnStarSave.Text = "Save";
            this.btnStarSave.UseVisualStyleBackColor = true;
            this.btnStarSave.Click += new System.EventHandler(this.btnStarSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 265);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates";
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStarSave);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.StarDataBaseView);
            this.Name = "EditPopularStarsPopup";
            this.Text = "EditPopularStarsPopup";
            ((System.ComponentModel.ISupportInitialize)(this.StarDataBaseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digiDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StarDataBaseView;
        private System.Windows.Forms.BindingSource digiDataBaseDataSetBindingSource;
        private DigiDataBaseDataSet digiDataBaseDataSet;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button btnStarSave;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}