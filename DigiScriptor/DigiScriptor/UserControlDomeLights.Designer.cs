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
            this.hex = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.dimmer = new System.Windows.Forms.TrackBar();
            this.btnDomeLightsBack = new System.Windows.Forms.Button();
            this.lblDomeLights = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSubmitPlanet = new System.Windows.Forms.Button();
            this.panelDomeLights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimmer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDomeLights
            // 
            this.panelDomeLights.Controls.Add(this.btnSubmitPlanet);
            this.panelDomeLights.Controls.Add(this.hex);
            this.panelDomeLights.Controls.Add(this.textBox1);
            this.panelDomeLights.Controls.Add(this.colorBtn);
            this.panelDomeLights.Controls.Add(this.dimmer);
            this.panelDomeLights.Controls.Add(this.btnDomeLightsBack);
            this.panelDomeLights.Controls.Add(this.lblDomeLights);
            this.panelDomeLights.Location = new System.Drawing.Point(0, 0);
            this.panelDomeLights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDomeLights.Name = "panelDomeLights";
            this.panelDomeLights.Size = new System.Drawing.Size(944, 798);
            this.panelDomeLights.TabIndex = 31;
            // 
            // hex
            // 
            this.hex.Location = new System.Drawing.Point(91, 456);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(100, 22);
            this.hex.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 31;
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(62, 115);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(160, 57);
            this.colorBtn.TabIndex = 30;
            this.colorBtn.Text = "Select a Color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // dimmer
            // 
            this.dimmer.Location = new System.Drawing.Point(62, 293);
            this.dimmer.Name = "dimmer";
            this.dimmer.Size = new System.Drawing.Size(239, 56);
            this.dimmer.TabIndex = 29;
            // 
            // btnDomeLightsBack
            // 
            this.btnDomeLightsBack.BackColor = System.Drawing.Color.Gray;
            this.btnDomeLightsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDomeLightsBack.Location = new System.Drawing.Point(18, 749);
            this.btnDomeLightsBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDomeLightsBack.Name = "btnDomeLightsBack";
            this.btnDomeLightsBack.Size = new System.Drawing.Size(76, 31);
            this.btnDomeLightsBack.TabIndex = 28;
            this.btnDomeLightsBack.Text = "Back";
            this.btnDomeLightsBack.UseVisualStyleBackColor = false;
            // 
            // lblDomeLights
            // 
            this.lblDomeLights.AutoSize = true;
            this.lblDomeLights.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomeLights.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblDomeLights.Location = new System.Drawing.Point(20, 34);
            this.lblDomeLights.Name = "lblDomeLights";
            this.lblDomeLights.Size = new System.Drawing.Size(244, 55);
            this.lblDomeLights.TabIndex = 3;
            this.lblDomeLights.Text = "Dome Lights";
            // 
            // btnSubmitPlanet
            // 
            this.btnSubmitPlanet.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitPlanet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitPlanet.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitPlanet.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitPlanet.Location = new System.Drawing.Point(80, 376);
            this.btnSubmitPlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitPlanet.Name = "btnSubmitPlanet";
            this.btnSubmitPlanet.Size = new System.Drawing.Size(165, 60);
            this.btnSubmitPlanet.TabIndex = 47;
            this.btnSubmitPlanet.Text = "Submit";
            this.btnSubmitPlanet.UseVisualStyleBackColor = false;
            this.btnSubmitPlanet.Click += new System.EventHandler(this.btnSubmitPlanet_Click);
            // 
            // UserControlDomeLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelDomeLights);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlDomeLights";
            this.Size = new System.Drawing.Size(944, 798);
            this.panelDomeLights.ResumeLayout(false);
            this.panelDomeLights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimmer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDomeLights;
        public System.Windows.Forms.Button btnDomeLightsBack;
        private System.Windows.Forms.Label lblDomeLights;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.TrackBar dimmer;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox hex;
        private System.Windows.Forms.Button btnSubmitPlanet;
    }
}
