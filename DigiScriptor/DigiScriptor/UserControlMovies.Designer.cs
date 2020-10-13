namespace DigiScriptor
{
    partial class UserControlMovies
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
            this.panelMovies = new System.Windows.Forms.Panel();
            this.btnMoviesBack = new System.Windows.Forms.Button();
            this.labelMovies = new System.Windows.Forms.Label();
            this.panelMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMovies
            // 
            this.panelMovies.Controls.Add(this.btnMoviesBack);
            this.panelMovies.Controls.Add(this.labelMovies);
            this.panelMovies.Location = new System.Drawing.Point(0, 0);
            this.panelMovies.Name = "panelMovies";
            this.panelMovies.Size = new System.Drawing.Size(1062, 997);
            this.panelMovies.TabIndex = 29;
            // 
            // btnMoviesBack
            // 
            this.btnMoviesBack.BackColor = System.Drawing.Color.Gray;
            this.btnMoviesBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoviesBack.Location = new System.Drawing.Point(20, 936);
            this.btnMoviesBack.Name = "btnMoviesBack";
            this.btnMoviesBack.Size = new System.Drawing.Size(85, 39);
            this.btnMoviesBack.TabIndex = 28;
            this.btnMoviesBack.Text = "Back";
            this.btnMoviesBack.UseVisualStyleBackColor = false;
            // 
            // labelMovies
            // 
            this.labelMovies.AutoSize = true;
            this.labelMovies.Font = new System.Drawing.Font("Bernard MT Condensed", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovies.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelMovies.Location = new System.Drawing.Point(22, 42);
            this.labelMovies.Name = "labelMovies";
            this.labelMovies.Size = new System.Drawing.Size(171, 67);
            this.labelMovies.TabIndex = 3;
            this.labelMovies.Text = "Movies";
            // 
            // UserControlMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelMovies);
            this.Name = "UserControlMovies";
            this.Size = new System.Drawing.Size(1062, 997);
            this.panelMovies.ResumeLayout(false);
            this.panelMovies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMovies;
        public System.Windows.Forms.Button btnMoviesBack;
        private System.Windows.Forms.Label labelMovies;
    }
}
