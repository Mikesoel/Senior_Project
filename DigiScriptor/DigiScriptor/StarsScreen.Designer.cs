namespace DigiScriptor
{
    partial class StarsScreen
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
            this.Star_favorites = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Right_Ascention_txt = new System.Windows.Forms.TextBox();
            this.hr_angle_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.declination_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Submit = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Star_favorites
            // 
            this.Star_favorites.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Star_favorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Star_favorites.FormattingEnabled = true;
            this.Star_favorites.Items.AddRange(new object[] {
            "Sirius",
            "Polaris",
            "Betelgeuse",
            "Rigel"});
            this.Star_favorites.Location = new System.Drawing.Point(108, 87);
            this.Star_favorites.Margin = new System.Windows.Forms.Padding(4);
            this.Star_favorites.Name = "Star_favorites";
            this.Star_favorites.Size = new System.Drawing.Size(191, 37);
            this.Star_favorites.TabIndex = 0;
            this.Star_favorites.Text = "Favorite Stars";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(56, 32);
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Right_Ascention_txt);
            this.groupBox1.Controls.Add(this.hr_angle_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.declination_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(432, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Right_Ascention_txt
            // 
            this.Right_Ascention_txt.Location = new System.Drawing.Point(193, 48);
            this.Right_Ascention_txt.Name = "Right_Ascention_txt";
            this.Right_Ascention_txt.Size = new System.Drawing.Size(317, 34);
            this.Right_Ascention_txt.TabIndex = 6;
            this.Right_Ascention_txt.TextChanged += new System.EventHandler(this.Right_Ascention_txt_TextChanged);
            // 
            // hr_angle_txt
            // 
            this.hr_angle_txt.Location = new System.Drawing.Point(194, 216);
            this.hr_angle_txt.Name = "hr_angle_txt";
            this.hr_angle_txt.Size = new System.Drawing.Size(317, 34);
            this.hr_angle_txt.TabIndex = 5;
            this.hr_angle_txt.TextChanged += new System.EventHandler(this.hr_angle_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hour Angle";
            // 
            // declination_txt
            // 
            this.declination_txt.Location = new System.Drawing.Point(194, 132);
            this.declination_txt.Name = "declination_txt";
            this.declination_txt.Size = new System.Drawing.Size(317, 34);
            this.declination_txt.TabIndex = 3;
            this.declination_txt.TextChanged += new System.EventHandler(this.declination_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Declination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Right Ascention";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(656, 504);
            this.progressBar1.Maximum = 90;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(265, 38);
            this.progressBar1.Step = 30;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Submit
            // 
            this.Submit.Enabled = false;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Submit.Location = new System.Drawing.Point(927, 504);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(128, 38);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // StarsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Star_favorites);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StarsScreen";
            this.Text = "StarsScreen";
            this.Load += new System.EventHandler(this.StarsScreen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Star_favorites;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hr_angle_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox declination_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Right_Ascention_txt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Submit;
    }
}