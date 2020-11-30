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
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.DelayBtn = new System.Windows.Forms.Button();
            this.titleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Controls.Add(this.DelayBtn);
            this.titleBox.Controls.Add(this.btnUp);
            this.titleBox.Controls.Add(this.btnDown);
            this.titleBox.Controls.Add(this.descriptionBox);
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleBox.Location = new System.Drawing.Point(0, 0);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(277, 140);
            this.titleBox.TabIndex = 0;
            this.titleBox.TabStop = false;
            this.titleBox.Text = "default title";
            this.titleBox.Enter += new System.EventHandler(this.titleBox_Enter);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(233, 53);
            this.btnUp.Margin = new System.Windows.Forms.Padding(1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 20);
            this.btnUp.TabIndex = 38;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(233, 75);
            this.btnDown.Margin = new System.Windows.Forms.Padding(1);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 20);
            this.btnDown.TabIndex = 39;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descriptionBox.Location = new System.Drawing.Point(5, 25);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(224, 104);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.TabStop = false;
            this.descriptionBox.Text = "";
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // DelayBtn
            // 
            this.DelayBtn.Font = new System.Drawing.Font("Arial", 8F);
            this.DelayBtn.Location = new System.Drawing.Point(233, 29);
            this.DelayBtn.Name = "DelayBtn";
            this.DelayBtn.Size = new System.Drawing.Size(40, 20);
            this.DelayBtn.TabIndex = 40;
            this.DelayBtn.Text = "⌛";
            this.DelayBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DelayBtn.UseVisualStyleBackColor = true;
            this.DelayBtn.Click += new System.EventHandler(this.DelayBtn_Click);
            // 
            // ShowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleBox);
            this.Name = "ShowItem";
            this.Size = new System.Drawing.Size(280, 140);
            this.titleBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox titleBox;
        public System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button DelayBtn;
    }
}