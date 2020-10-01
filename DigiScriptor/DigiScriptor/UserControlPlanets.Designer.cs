namespace DigiScriptor
{
    partial class UserControlPlanets
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
            this.panelPlanets = new System.Windows.Forms.Panel();
            this.btnPlanetsBack = new System.Windows.Forms.Button();
            this.labelPlanets = new System.Windows.Forms.Label();
            this.panelPlanets.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlanets
            // 
            this.panelPlanets.Controls.Add(this.btnPlanetsBack);
            this.panelPlanets.Controls.Add(this.labelPlanets);
            this.panelPlanets.Location = new System.Drawing.Point(0, 0);
            this.panelPlanets.Name = "panelPlanets";
            this.panelPlanets.Size = new System.Drawing.Size(1062, 997);
            this.panelPlanets.TabIndex = 27;
            // 
            // btnPlanetsBack
            // 
            this.btnPlanetsBack.BackColor = System.Drawing.Color.Gray;
            this.btnPlanetsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanetsBack.Location = new System.Drawing.Point(32, 936);
            this.btnPlanetsBack.Name = "btnPlanetsBack";
            this.btnPlanetsBack.Size = new System.Drawing.Size(85, 39);
            this.btnPlanetsBack.TabIndex = 30;
            this.btnPlanetsBack.Text = "Back";
            this.btnPlanetsBack.UseVisualStyleBackColor = false;
            // 
            // labelPlanets
            // 
            this.labelPlanets.AutoSize = true;
            this.labelPlanets.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlanets.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelPlanets.Location = new System.Drawing.Point(22, 42);
            this.labelPlanets.Name = "labelPlanets";
            this.labelPlanets.Size = new System.Drawing.Size(187, 67);
            this.labelPlanets.TabIndex = 3;
            this.labelPlanets.Text = "Planets";
            // 
            // UserControlPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelPlanets);
            this.Name = "UserControlPlanets";
            this.Size = new System.Drawing.Size(1062, 997);
            this.panelPlanets.ResumeLayout(false);
            this.panelPlanets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlanets;
        public System.Windows.Forms.Button btnPlanetsBack;
        private System.Windows.Forms.Label labelPlanets;
    }
}
