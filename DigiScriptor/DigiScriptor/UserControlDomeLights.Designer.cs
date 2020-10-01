namespace DigiScriptor
{
    partial class UserControlDomeLights
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
            this.panelDomeLights = new System.Windows.Forms.Panel();
            this.btnDomeLightsBack = new System.Windows.Forms.Button();
            this.lblDomeLights = new System.Windows.Forms.Label();
            this.panelDomeLights.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDomeLights
            // 
            this.panelDomeLights.Controls.Add(this.btnDomeLightsBack);
            this.panelDomeLights.Controls.Add(this.lblDomeLights);
            this.panelDomeLights.Location = new System.Drawing.Point(0, 0);
            this.panelDomeLights.Name = "panelDomeLights";
            this.panelDomeLights.Size = new System.Drawing.Size(1062, 997);
            this.panelDomeLights.TabIndex = 31;
            // 
            // btnDomeLightsBack
            // 
            this.btnDomeLightsBack.BackColor = System.Drawing.Color.Gray;
            this.btnDomeLightsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDomeLightsBack.Location = new System.Drawing.Point(20, 936);
            this.btnDomeLightsBack.Name = "btnDomeLightsBack";
            this.btnDomeLightsBack.Size = new System.Drawing.Size(85, 39);
            this.btnDomeLightsBack.TabIndex = 28;
            this.btnDomeLightsBack.Text = "Back";
            this.btnDomeLightsBack.UseVisualStyleBackColor = false;
            // 
            // lblDomeLights
            // 
            this.lblDomeLights.AutoSize = true;
            this.lblDomeLights.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomeLights.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDomeLights.Location = new System.Drawing.Point(22, 42);
            this.lblDomeLights.Name = "lblDomeLights";
            this.lblDomeLights.Size = new System.Drawing.Size(292, 67);
            this.lblDomeLights.TabIndex = 3;
            this.lblDomeLights.Text = "Dome Lights";
            // 
            // UserControlDomeLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelDomeLights);
            this.Name = "UserControlDomeLights";
            this.Size = new System.Drawing.Size(1062, 997);
            this.panelDomeLights.ResumeLayout(false);
            this.panelDomeLights.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDomeLights;
        public System.Windows.Forms.Button btnDomeLightsBack;
        private System.Windows.Forms.Label lblDomeLights;
    }
}
