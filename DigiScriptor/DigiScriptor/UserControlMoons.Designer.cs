namespace DigiScriptor
{
    partial class UserControlMoons
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
            this.panelMoons = new System.Windows.Forms.Panel();
            this.btnMoonsBack = new System.Windows.Forms.Button();
            this.labelMoons = new System.Windows.Forms.Label();
            this.panelMoons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMoons
            // 
            this.panelMoons.Controls.Add(this.btnMoonsBack);
            this.panelMoons.Controls.Add(this.labelMoons);
            this.panelMoons.Location = new System.Drawing.Point(0, 0);
            this.panelMoons.Name = "panelMoons";
            this.panelMoons.Size = new System.Drawing.Size(1062, 997);
            this.panelMoons.TabIndex = 27;
            // 
            // btnMoonsBack
            // 
            this.btnMoonsBack.BackColor = System.Drawing.Color.Gray;
            this.btnMoonsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoonsBack.Location = new System.Drawing.Point(32, 936);
            this.btnMoonsBack.Name = "btnMoonsBack";
            this.btnMoonsBack.Size = new System.Drawing.Size(85, 39);
            this.btnMoonsBack.TabIndex = 29;
            this.btnMoonsBack.Text = "Back";
            this.btnMoonsBack.UseVisualStyleBackColor = false;
            // 
            // labelMoons
            // 
            this.labelMoons.AutoSize = true;
            this.labelMoons.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoons.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelMoons.Location = new System.Drawing.Point(22, 42);
            this.labelMoons.Name = "labelMoons";
            this.labelMoons.Size = new System.Drawing.Size(162, 67);
            this.labelMoons.TabIndex = 3;
            this.labelMoons.Text = "Moons";
            // 
            // UserControlMoons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelMoons);
            this.Name = "UserControlMoons";
            this.Size = new System.Drawing.Size(1062, 997);
            this.panelMoons.ResumeLayout(false);
            this.panelMoons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMoons;
        public System.Windows.Forms.Button btnMoonsBack;
        private System.Windows.Forms.Label labelMoons;
    }
}
