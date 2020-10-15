namespace DigiScriptor
{
    partial class ShowItem
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
            this.titleBox = new System.Windows.Forms.GroupBox();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.titleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Controls.Add(this.descriptionBox);
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleBox.Location = new System.Drawing.Point(0, 4);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(275, 96);
            this.titleBox.TabIndex = 0;
            this.titleBox.TabStop = false;
            this.titleBox.Text = "default title";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descriptionBox.Location = new System.Drawing.Point(7, 26);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(262, 64);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.TabStop = false;
            this.descriptionBox.Text = "";
            // 
            // ShowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleBox);
            this.Name = "ShowItem";
            this.Size = new System.Drawing.Size(275, 100);
            this.titleBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox titleBox;
        private System.Windows.Forms.RichTextBox descriptionBox;
    }
}
