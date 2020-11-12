﻿namespace DigiScriptor
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
            this.titleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Controls.Add(this.btnUp);
            this.titleBox.Controls.Add(this.btnDown);
            this.titleBox.Controls.Add(this.descriptionBox);
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.titleBox.Location = new System.Drawing.Point(0, 5);
            this.titleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleBox.Name = "titleBox";
            this.titleBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleBox.Size = new System.Drawing.Size(412, 206);
            this.titleBox.TabIndex = 0;
            this.titleBox.TabStop = false;
            this.titleBox.Text = "default title";
            this.titleBox.Enter += new System.EventHandler(this.titleBox_Enter);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.Location = new System.Drawing.Point(329, 74);
            this.btnUp.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(73, 34);
            this.btnUp.TabIndex = 38;
            this.btnUp.Text = "up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(329, 112);
            this.btnDown.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(73, 34);
            this.btnDown.TabIndex = 39;
            this.btnDown.Text = "down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.descriptionBox.Location = new System.Drawing.Point(8, 38);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(314, 158);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.TabStop = false;
            this.descriptionBox.Text = "";
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // ShowItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShowItem";
            this.Size = new System.Drawing.Size(412, 216);
            this.titleBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox titleBox;
        public System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
    }
}
