namespace DigiScriptor
{
    partial class SaveMenu
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoctxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Location_btn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // LoctxtBox
            // 
            this.LoctxtBox.Location = new System.Drawing.Point(95, 12);
            this.LoctxtBox.Name = "LoctxtBox";
            this.LoctxtBox.ReadOnly = true;
            this.LoctxtBox.Size = new System.Drawing.Size(438, 20);
            this.LoctxtBox.TabIndex = 0;
            this.LoctxtBox.TextChanged += new System.EventHandler(this.LoctxtBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output Location:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Location_btn
            // 
            this.Location_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location_btn.Location = new System.Drawing.Point(539, 10);
            this.Location_btn.Name = "Location_btn";
            this.Location_btn.Size = new System.Drawing.Size(75, 23);
            this.Location_btn.TabIndex = 2;
            this.Location_btn.Text = "Location";
            this.Location_btn.UseVisualStyleBackColor = true;
            this.Location_btn.Click += new System.EventHandler(this.Location_Btn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveBtn.Location = new System.Drawing.Point(539, 39);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // SaveMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(629, 73);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Location_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoctxtBox);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SaveMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Menu";
            this.Load += new System.EventHandler(this.SaveMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox LoctxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Location_btn;
        private System.Windows.Forms.Button SaveBtn;
    }
}