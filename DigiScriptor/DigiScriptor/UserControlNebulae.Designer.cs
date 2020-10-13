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
            this.nebulaeDropdown = new System.Windows.Forms.ComboBox();
            this.lblNebulaeSelectionDropdown = new System.Windows.Forms.Label();
            this.lblNebulaeTitle = new System.Windows.Forms.Label();
            this.btnSubmitNebulae = new System.Windows.Forms.Button();
            this.btnNebulaeBack = new System.Windows.Forms.Button();
            this.panelNebulae.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNebulae
            // 
            this.panelNebulae.Controls.Add(this.nebulaeDropdown);
            this.panelNebulae.Controls.Add(this.lblNebulaeSelectionDropdown);
            this.panelNebulae.Controls.Add(this.lblNebulaeTitle);
            this.panelNebulae.Controls.Add(this.btnSubmitNebulae);
            this.panelNebulae.Controls.Add(this.btnNebulaeBack);
            this.panelNebulae.Location = new System.Drawing.Point(0, 0);
            this.panelNebulae.Name = "panelNebulae";
            this.panelNebulae.Size = new System.Drawing.Size(1062, 997);
            this.panelNebulae.TabIndex = 27;
            // 
            // nebulaeDropdown
            // 
            this.nebulaeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nebulaeDropdown.FormattingEnabled = true;
            this.nebulaeDropdown.Location = new System.Drawing.Point(269, 111);
            this.nebulaeDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nebulaeDropdown.MaxDropDownItems = 20;
            this.nebulaeDropdown.Name = "nebulaeDropdown";
            this.nebulaeDropdown.Size = new System.Drawing.Size(222, 33);
            this.nebulaeDropdown.TabIndex = 26;
            // 
            // lblNebulaeSelectionDropdown
            // 
            this.lblNebulaeSelectionDropdown.AutoSize = true;
            this.lblNebulaeSelectionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNebulaeSelectionDropdown.Location = new System.Drawing.Point(29, 111);
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
            this.btnSubmitNebulae.Location = new System.Drawing.Point(828, 890);
            this.btnSubmitNebulae.Name = "btnSubmitNebulae";
            this.btnSubmitNebulae.Size = new System.Drawing.Size(186, 75);
            this.btnSubmitNebulae.TabIndex = 23;
            this.btnSubmitNebulae.Text = "Submit";
            this.btnSubmitNebulae.UseVisualStyleBackColor = false;
            // 
            // btnNebulaeBack
            // 
            this.btnNebulaeBack.BackColor = System.Drawing.Color.Gray;
            this.btnNebulaeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNebulaeBack.Location = new System.Drawing.Point(33, 927);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNebulae;
        private System.Windows.Forms.ComboBox nebulaeDropdown;
        private System.Windows.Forms.Label lblNebulaeSelectionDropdown;
        private System.Windows.Forms.Label lblNebulaeTitle;
        private System.Windows.Forms.Button btnSubmitNebulae;
        public System.Windows.Forms.Button btnNebulaeBack;
    }
}
