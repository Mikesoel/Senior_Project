namespace DigiScriptor
{
    partial class NebulaeScreen
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
            this.btnNebulaeBack = new System.Windows.Forms.Button();
            this.btnSubmitNebulae = new System.Windows.Forms.Button();
            this.lblNebulaeTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNebulaeBack
            // 
            this.btnNebulaeBack.BackColor = System.Drawing.Color.Gray;
            this.btnNebulaeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNebulaeBack.Location = new System.Drawing.Point(11, 414);
            this.btnNebulaeBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnNebulaeBack.Name = "btnNebulaeBack";
            this.btnNebulaeBack.Size = new System.Drawing.Size(57, 25);
            this.btnNebulaeBack.TabIndex = 16;
            this.btnNebulaeBack.Text = "Back";
            this.btnNebulaeBack.UseVisualStyleBackColor = false;
            this.btnNebulaeBack.Click += new System.EventHandler(this.btnNebulaeBack_Click);
            // 
            // btnSubmitNebulae
            // 
            this.btnSubmitNebulae.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitNebulae.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitNebulae.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitNebulae.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitNebulae.Location = new System.Drawing.Point(665, 390);
            this.btnSubmitNebulae.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitNebulae.Name = "btnSubmitNebulae";
            this.btnSubmitNebulae.Size = new System.Drawing.Size(124, 49);
            this.btnSubmitNebulae.TabIndex = 18;
            this.btnSubmitNebulae.Text = "Submit";
            this.btnSubmitNebulae.UseVisualStyleBackColor = false;
            this.btnSubmitNebulae.Click += new System.EventHandler(this.btnSubmitNebulae_Click);
            // 
            // lblNebulaeTitle
            // 
            this.lblNebulaeTitle.AutoSize = true;
            this.lblNebulaeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNebulaeTitle.Location = new System.Drawing.Point(12, 30);
            this.lblNebulaeTitle.Name = "lblNebulaeTitle";
            this.lblNebulaeTitle.Size = new System.Drawing.Size(112, 29);
            this.lblNebulaeTitle.TabIndex = 19;
            this.lblNebulaeTitle.Text = "Nebulae";
            // 
            // NebulaeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNebulaeTitle);
            this.Controls.Add(this.btnSubmitNebulae);
            this.Controls.Add(this.btnNebulaeBack);
            this.Name = "NebulaeScreen";
            this.Text = "Nebulae";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNebulaeBack;
        private System.Windows.Forms.Button btnSubmitNebulae;
        private System.Windows.Forms.Label lblNebulaeTitle;
    }
}