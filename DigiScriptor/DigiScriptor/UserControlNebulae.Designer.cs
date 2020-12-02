namespace DigiScriptor
{
    partial class UserControlNebulae
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
            this.panelNebulae = new System.Windows.Forms.Panel();
            this.lblGalaxies = new System.Windows.Forms.Label();
            this.editPopularNebulaeButton = new System.Windows.Forms.Button();
            this.nebulaePanel = new System.Windows.Forms.Panel();
            this.comboNebVantagePoint = new System.Windows.Forms.ComboBox();
            this.txtBoxNebVantagePoint = new System.Windows.Forms.TextBox();
            this.lblNebulaeVantagePoint = new System.Windows.Forms.Label();
            this.nebulaeDropdown = new System.Windows.Forms.ComboBox();
            this.lblNebulaeSelectionDropdown = new System.Windows.Forms.Label();
            this.btnSubmitNebulae = new System.Windows.Forms.Button();
            this.btnNebulaeBack = new System.Windows.Forms.Button();
            this.panelNebulae.SuspendLayout();
            this.nebulaePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNebulae
            // 
            this.panelNebulae.Controls.Add(this.lblGalaxies);
            this.panelNebulae.Controls.Add(this.editPopularNebulaeButton);
            this.panelNebulae.Controls.Add(this.nebulaePanel);
            this.panelNebulae.Controls.Add(this.lblNebulaeVantagePoint);
            this.panelNebulae.Controls.Add(this.nebulaeDropdown);
            this.panelNebulae.Controls.Add(this.lblNebulaeSelectionDropdown);
            this.panelNebulae.Controls.Add(this.btnSubmitNebulae);
            this.panelNebulae.Controls.Add(this.btnNebulaeBack);
            this.panelNebulae.Location = new System.Drawing.Point(0, 0);
            this.panelNebulae.Margin = new System.Windows.Forms.Padding(2);
            this.panelNebulae.Name = "panelNebulae";
            this.panelNebulae.Size = new System.Drawing.Size(708, 648);
            this.panelNebulae.TabIndex = 27;
            this.panelNebulae.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNebulae_Paint);
            // 
            // lblGalaxies
            // 
            this.lblGalaxies.AutoSize = true;
            this.lblGalaxies.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalaxies.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblGalaxies.Location = new System.Drawing.Point(18, 11);
            this.lblGalaxies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGalaxies.Name = "lblGalaxies";
            this.lblGalaxies.Size = new System.Drawing.Size(120, 45);
            this.lblGalaxies.TabIndex = 31;
            this.lblGalaxies.Text = "Nebula";
            // 
            // editPopularNebulaeButton
            // 
            this.editPopularNebulaeButton.Location = new System.Drawing.Point(387, 72);
            this.editPopularNebulaeButton.Name = "editPopularNebulaeButton";
            this.editPopularNebulaeButton.Size = new System.Drawing.Size(75, 23);
            this.editPopularNebulaeButton.TabIndex = 30;
            this.editPopularNebulaeButton.Text = "Search/Edit";
            this.editPopularNebulaeButton.UseVisualStyleBackColor = true;
            this.editPopularNebulaeButton.Click += new System.EventHandler(this.editPopularNebulaeButton_Click);
            // 
            // nebulaePanel
            // 
            this.nebulaePanel.Controls.Add(this.comboNebVantagePoint);
            this.nebulaePanel.Controls.Add(this.txtBoxNebVantagePoint);
            this.nebulaePanel.Location = new System.Drawing.Point(179, 130);
            this.nebulaePanel.Name = "nebulaePanel";
            this.nebulaePanel.Size = new System.Drawing.Size(237, 29);
            this.nebulaePanel.TabIndex = 29;
            // 
            // comboNebVantagePoint
            // 
            this.comboNebVantagePoint.FormattingEnabled = true;
            this.comboNebVantagePoint.Items.AddRange(new object[] {
            "Miles",
            "Meters",
            "Kilometers",
            "Astronomical Units"});
            this.comboNebVantagePoint.Location = new System.Drawing.Point(109, 3);
            this.comboNebVantagePoint.Name = "comboNebVantagePoint";
            this.comboNebVantagePoint.Size = new System.Drawing.Size(121, 21);
            this.comboNebVantagePoint.TabIndex = 1;
            // 
            // txtBoxNebVantagePoint
            // 
            this.txtBoxNebVantagePoint.Location = new System.Drawing.Point(3, 3);
            this.txtBoxNebVantagePoint.Name = "txtBoxNebVantagePoint";
            this.txtBoxNebVantagePoint.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNebVantagePoint.TabIndex = 0;
            this.txtBoxNebVantagePoint.Text = "400";
            // 
            // lblNebulaeVantagePoint
            // 
            this.lblNebulaeVantagePoint.AutoSize = true;
            this.lblNebulaeVantagePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNebulaeVantagePoint.Location = new System.Drawing.Point(59, 134);
            this.lblNebulaeVantagePoint.Name = "lblNebulaeVantagePoint";
            this.lblNebulaeVantagePoint.Size = new System.Drawing.Size(114, 20);
            this.lblNebulaeVantagePoint.TabIndex = 28;
            this.lblNebulaeVantagePoint.Text = "Vantage Point:";
            this.lblNebulaeVantagePoint.Click += new System.EventHandler(this.lblNebulaeVantagePoint_Click);
            // 
            // nebulaeDropdown
            // 
            this.nebulaeDropdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nebulaeDropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nebulaeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nebulaeDropdown.FormattingEnabled = true;
            this.nebulaeDropdown.Location = new System.Drawing.Point(182, 72);
            this.nebulaeDropdown.MaxDropDownItems = 20;
            this.nebulaeDropdown.Name = "nebulaeDropdown";
            this.nebulaeDropdown.Size = new System.Drawing.Size(186, 24);
            this.nebulaeDropdown.TabIndex = 26;
            this.nebulaeDropdown.SelectedIndexChanged += new System.EventHandler(this.nebulaeDropdown_SelectedIndexChanged);
            this.nebulaeDropdown.Click += new System.EventHandler(this.nebulaeDropdown_Click);
            // 
            // lblNebulaeSelectionDropdown
            // 
            this.lblNebulaeSelectionDropdown.AutoSize = true;
            this.lblNebulaeSelectionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNebulaeSelectionDropdown.Location = new System.Drawing.Point(22, 72);
            this.lblNebulaeSelectionDropdown.Name = "lblNebulaeSelectionDropdown";
            this.lblNebulaeSelectionDropdown.Size = new System.Drawing.Size(154, 20);
            this.lblNebulaeSelectionDropdown.TabIndex = 25;
            this.lblNebulaeSelectionDropdown.Text = "Nebulae Selections: ";
            // 
            // btnSubmitNebulae
            // 
            this.btnSubmitNebulae.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitNebulae.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitNebulae.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNebulae.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitNebulae.Location = new System.Drawing.Point(552, 578);
            this.btnSubmitNebulae.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitNebulae.Name = "btnSubmitNebulae";
            this.btnSubmitNebulae.Size = new System.Drawing.Size(124, 49);
            this.btnSubmitNebulae.TabIndex = 23;
            this.btnSubmitNebulae.Text = "Submit";
            this.btnSubmitNebulae.UseVisualStyleBackColor = false;
            this.btnSubmitNebulae.Click += new System.EventHandler(this.btnSubmitNebulae_Click);
            // 
            // btnNebulaeBack
            // 
            this.btnNebulaeBack.BackColor = System.Drawing.Color.Gray;
            this.btnNebulaeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNebulaeBack.Location = new System.Drawing.Point(22, 603);
            this.btnNebulaeBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnNebulaeBack.Name = "btnNebulaeBack";
            this.btnNebulaeBack.Size = new System.Drawing.Size(57, 25);
            this.btnNebulaeBack.TabIndex = 22;
            this.btnNebulaeBack.Text = "Back";
            this.btnNebulaeBack.UseVisualStyleBackColor = false;
            // 
            // UserControlNebulae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelNebulae);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlNebulae";
            this.Size = new System.Drawing.Size(708, 648);
            this.panelNebulae.ResumeLayout(false);
            this.panelNebulae.PerformLayout();
            this.nebulaePanel.ResumeLayout(false);
            this.nebulaePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNebulae;
        public System.Windows.Forms.ComboBox nebulaeDropdown;
        private System.Windows.Forms.Label lblNebulaeSelectionDropdown;
        private System.Windows.Forms.Button btnSubmitNebulae;
        public System.Windows.Forms.Button btnNebulaeBack;
        private System.Windows.Forms.Label lblNebulaeVantagePoint;
        private System.Windows.Forms.Panel nebulaePanel;
        private System.Windows.Forms.ComboBox comboNebVantagePoint;
        private System.Windows.Forms.TextBox txtBoxNebVantagePoint;
        private System.Windows.Forms.Button editPopularNebulaeButton;
        private System.Windows.Forms.Label lblGalaxies;
    }
}
