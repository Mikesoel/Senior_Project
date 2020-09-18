namespace DigiScriptor
{
    partial class NightSkyScreen
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
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.back.Location = new System.Drawing.Point(12, 398);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(80, 40);
            this.back.TabIndex = 0;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.btn_back_click);
            // 
            // NightSkyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Name = "NightSkyScreen";
            this.Text = "NightSkyScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
    }
}