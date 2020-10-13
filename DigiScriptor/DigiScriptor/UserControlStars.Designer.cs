namespace DigiScriptor
{
    partial class UserControlStars
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
            this.panelStars = new System.Windows.Forms.Panel();
            this.btnStarsBack = new System.Windows.Forms.Button();
            this.labelStars = new System.Windows.Forms.Label();
            this.panelStars.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStars
            // 
            this.panelStars.Controls.Add(this.btnStarsBack);
            this.panelStars.Controls.Add(this.labelStars);
            this.panelStars.Location = new System.Drawing.Point(0, 0);
            this.panelStars.Name = "panelStars";
            this.panelStars.Size = new System.Drawing.Size(1062, 997);
            this.panelStars.TabIndex = 30;
            // 
            // btnStarsBack
            // 
            this.btnStarsBack.BackColor = System.Drawing.Color.Gray;
            this.btnStarsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarsBack.Location = new System.Drawing.Point(32, 936);
            this.btnStarsBack.Name = "btnStarsBack";
            this.btnStarsBack.Size = new System.Drawing.Size(85, 39);
            this.btnStarsBack.TabIndex = 30;
            this.btnStarsBack.Text = "Back";
            this.btnStarsBack.UseVisualStyleBackColor = false;
            // 
            // labelStars
            // 
            this.labelStars.AutoSize = true;
            this.labelStars.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStars.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelStars.Location = new System.Drawing.Point(22, 42);
            this.labelStars.Name = "labelStars";
            this.labelStars.Size = new System.Drawing.Size(131, 67);
            this.labelStars.TabIndex = 3;
            this.labelStars.Text = "Stars";
            // 
            // UserControlStars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelStars);
            this.Name = "UserControlStars";
            this.Size = new System.Drawing.Size(1062, 997);
            this.panelStars.ResumeLayout(false);
            this.panelStars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStars;
        public System.Windows.Forms.Button btnStarsBack;
        private System.Windows.Forms.Label labelStars;
    }
}
