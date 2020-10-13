namespace DigiScriptor
{
    partial class UserControlNightSky
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
            this.panelNightSky = new System.Windows.Forms.Panel();
            this.btnSkyBack = new System.Windows.Forms.Button();
            this.labelNightSky = new System.Windows.Forms.Label();
            this.panelNightSky.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNightSky
            // 
            this.panelNightSky.Controls.Add(this.btnSkyBack);
            this.panelNightSky.Controls.Add(this.labelNightSky);
            this.panelNightSky.Location = new System.Drawing.Point(0, 1);
            this.panelNightSky.Name = "panelNightSky";
            this.panelNightSky.Size = new System.Drawing.Size(1062, 994);
            this.panelNightSky.TabIndex = 28;
            // 
            // btnSkyBack
            // 
            this.btnSkyBack.BackColor = System.Drawing.Color.Gray;
            this.btnSkyBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkyBack.Location = new System.Drawing.Point(32, 936);
            this.btnSkyBack.Name = "btnSkyBack";
            this.btnSkyBack.Size = new System.Drawing.Size(85, 39);
            this.btnSkyBack.TabIndex = 30;
            this.btnSkyBack.Text = "Back";
            this.btnSkyBack.UseVisualStyleBackColor = false;
            // 
            // labelNightSky
            // 
            this.labelNightSky.AutoSize = true;
            this.labelNightSky.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNightSky.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelNightSky.Location = new System.Drawing.Point(22, 42);
            this.labelNightSky.Name = "labelNightSky";
            this.labelNightSky.Size = new System.Drawing.Size(225, 67);
            this.labelNightSky.TabIndex = 3;
            this.labelNightSky.Text = "Night Sky";
            // 
            // UserControlNightSky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelNightSky);
            this.Name = "UserControlNightSky";
            this.Size = new System.Drawing.Size(1062, 997);
            this.panelNightSky.ResumeLayout(false);
            this.panelNightSky.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNightSky;
        public System.Windows.Forms.Button btnSkyBack;
        private System.Windows.Forms.Label labelNightSky;
    }
}
