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
            this.editPopularNebulaeButton = new System.Windows.Forms.Button();
            this.nebulaePanel = new System.Windows.Forms.Panel();
            this.comboNebVantagePoint = new System.Windows.Forms.ComboBox();
            this.txtBoxNebVantagePoint = new System.Windows.Forms.TextBox();
            this.lblNebulaeVantagePoint = new System.Windows.Forms.Label();
            this.nebulaeDropdown = new System.Windows.Forms.ComboBox();
            this.lblNebulaeSelectionDropdown = new System.Windows.Forms.Label();
            this.lblNebulaeTitle = new System.Windows.Forms.Label();
            this.btnSubmitNebulae = new System.Windows.Forms.Button();
            this.btnNebulaeBack = new System.Windows.Forms.Button();
            this.panelNebulae.SuspendLayout();
            this.nebulaePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNebulae
            // 
            this.panelNebulae.Controls.Add(this.editPopularNebulaeButton);
            this.panelNebulae.Controls.Add(this.nebulaePanel);
            this.panelNebulae.Controls.Add(this.lblNebulaeVantagePoint);
            this.panelNebulae.Controls.Add(this.nebulaeDropdown);
            this.panelNebulae.Controls.Add(this.lblNebulaeSelectionDropdown);
            this.panelNebulae.Controls.Add(this.lblNebulaeTitle);
            this.panelNebulae.Controls.Add(this.btnSubmitNebulae);
            this.panelNebulae.Controls.Add(this.btnNebulaeBack);
            this.panelNebulae.Location = new System.Drawing.Point(0, 0);
            this.panelNebulae.Name = "panelNebulae";
            this.panelNebulae.Size = new System.Drawing.Size(1062, 997);
            this.panelNebulae.TabIndex = 27;
            this.panelNebulae.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNebulae_Paint);
            // 
            // editPopularNebulaeButton
            // 
            this.editPopularNebulaeButton.Location = new System.Drawing.Point(526, 112);
            this.editPopularNebulaeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editPopularNebulaeButton.Name = "editPopularNebulaeButton";
            this.editPopularNebulaeButton.Size = new System.Drawing.Size(112, 35);
            this.editPopularNebulaeButton.TabIndex = 30;
            this.editPopularNebulaeButton.Text = "Add/Edit";
            this.editPopularNebulaeButton.UseVisualStyleBackColor = true;
            this.editPopularNebulaeButton.Click += new System.EventHandler(this.editPopularNebulaeButton_Click);
            // 
            // nebulaePanel
            // 
            this.nebulaePanel.Controls.Add(this.comboNebVantagePoint);
            this.nebulaePanel.Controls.Add(this.txtBoxNebVantagePoint);
            this.nebulaePanel.Location = new System.Drawing.Point(268, 200);
            this.nebulaePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nebulaePanel.Name = "nebulaePanel";
            this.nebulaePanel.Size = new System.Drawing.Size(356, 45);
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
            this.comboNebVantagePoint.Location = new System.Drawing.Point(164, 5);
            this.comboNebVantagePoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboNebVantagePoint.Name = "comboNebVantagePoint";
            this.comboNebVantagePoint.Size = new System.Drawing.Size(180, 28);
            this.comboNebVantagePoint.TabIndex = 1;
            // 
            // txtBoxNebVantagePoint
            // 
            this.txtBoxNebVantagePoint.Location = new System.Drawing.Point(4, 5);
            this.txtBoxNebVantagePoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNebVantagePoint.Name = "txtBoxNebVantagePoint";
            this.txtBoxNebVantagePoint.Size = new System.Drawing.Size(148, 26);
            this.txtBoxNebVantagePoint.TabIndex = 0;
            this.txtBoxNebVantagePoint.Text = "400";
            // 
            // lblNebulaeVantagePoint
            // 
            this.lblNebulaeVantagePoint.AutoSize = true;
            this.lblNebulaeVantagePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNebulaeVantagePoint.Location = new System.Drawing.Point(88, 206);
            this.lblNebulaeVantagePoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNebulaeVantagePoint.Name = "lblNebulaeVantagePoint";
            this.lblNebulaeVantagePoint.Size = new System.Drawing.Size(168, 29);
            this.lblNebulaeVantagePoint.TabIndex = 28;
            this.lblNebulaeVantagePoint.Text = "Vantage Point:";
            this.lblNebulaeVantagePoint.Click += new System.EventHandler(this.lblNebulaeVantagePoint_Click);
            // 
            // nebulaeDropdown
            // 
            this.nebulaeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nebulaeDropdown.FormattingEnabled = true;
            this.nebulaeDropdown.Location = new System.Drawing.Point(273, 111);
            this.nebulaeDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nebulaeDropdown.MaxDropDownItems = 20;
            this.nebulaeDropdown.Name = "nebulaeDropdown";
            this.nebulaeDropdown.Size = new System.Drawing.Size(222, 33);
            this.nebulaeDropdown.TabIndex = 26;
            this.nebulaeDropdown.SelectedIndexChanged += new System.EventHandler(this.nebulaeDropdown_SelectedIndexChanged);
            // 
            // lblNebulaeSelectionDropdown
            // 
            this.lblNebulaeSelectionDropdown.AutoSize = true;
            this.lblNebulaeSelectionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNebulaeSelectionDropdown.Location = new System.Drawing.Point(33, 111);
            this.lblNebulaeSelectionDropdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNebulaeSelectionDropdown.Name = "lblNebulaeSelectionDropdown";
            this.lblNebulaeSelectionDropdown.Size = new System.Drawing.Size(236, 29);
            this.lblNebulaeSelectionDropdown.TabIndex = 25;
            this.lblNebulaeSelectionDropdown.Text = "Nebulae Selections: ";
            // 
            // lblNebulaeTitle
            // 
            this.lblNebulaeTitle.AutoSize = true;
            this.lblNebulaeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNebulaeTitle.Location = new System.Drawing.Point(22, 42);
            this.lblNebulaeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNebulaeTitle.Name = "lblNebulaeTitle";
            this.lblNebulaeTitle.Size = new System.Drawing.Size(158, 40);
            this.lblNebulaeTitle.TabIndex = 24;
            this.lblNebulaeTitle.Text = "Nebulae";
            // 
            // btnSubmitNebulae
            // 
            this.btnSubmitNebulae.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitNebulae.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitNebulae.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNebulae.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitNebulae.Location = new System.Drawing.Point(828, 889);
            this.btnSubmitNebulae.Name = "btnSubmitNebulae";
            this.btnSubmitNebulae.Size = new System.Drawing.Size(186, 75);
            this.btnSubmitNebulae.TabIndex = 23;
            this.btnSubmitNebulae.Text = "Submit";
            this.btnSubmitNebulae.UseVisualStyleBackColor = false;
            this.btnSubmitNebulae.Click += new System.EventHandler(this.btnSubmitNebulae_Click);
            // 
            // btnNebulaeBack
            // 
            this.btnNebulaeBack.BackColor = System.Drawing.Color.Gray;
            this.btnNebulaeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNebulaeBack.Location = new System.Drawing.Point(33, 928);
            this.btnNebulaeBack.Name = "btnNebulaeBack";
            this.btnNebulaeBack.Size = new System.Drawing.Size(86, 38);
            this.btnNebulaeBack.TabIndex = 22;
            this.btnNebulaeBack.Text = "Back";
            this.btnNebulaeBack.UseVisualStyleBackColor = false;
            // 
            // UserControlNebulae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelNebulae);
            this.Name = "UserControlNebulae";
            this.Size = new System.Drawing.Size(1062, 997);
            this.panelNebulae.ResumeLayout(false);
            this.panelNebulae.PerformLayout();
            this.nebulaePanel.ResumeLayout(false);
            this.nebulaePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNebulae;
        private System.Windows.Forms.ComboBox nebulaeDropdown;
        private System.Windows.Forms.Label lblNebulaeSelectionDropdown;
        private System.Windows.Forms.Label lblNebulaeTitle;
        private System.Windows.Forms.Button btnSubmitNebulae;
        public System.Windows.Forms.Button btnNebulaeBack;
        private System.Windows.Forms.Label lblNebulaeVantagePoint;
        private System.Windows.Forms.Panel nebulaePanel;
        private System.Windows.Forms.ComboBox comboNebVantagePoint;
        private System.Windows.Forms.TextBox txtBoxNebVantagePoint;
        private System.Windows.Forms.Button editPopularNebulaeButton;
    }
}
