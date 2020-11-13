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
            this.components = new System.ComponentModel.Container();
            this.panelDomeLights = new System.Windows.Forms.Panel();
            this.dtimmer_unit = new System.Windows.Forms.Label();
            this.dtransTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dimmerValue = new System.Windows.Forms.TextBox();
            this.colorEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblManualColor = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.btnSubmitPlanet = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.dimmer = new System.Windows.Forms.TrackBar();
            this.btnDomeLightsBack = new System.Windows.Forms.Button();
            this.lblDomeLights = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.panelDomeLights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimmer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDomeLights
            // 
            this.panelDomeLights.Controls.Add(this.dtimmer_unit);
            this.panelDomeLights.Controls.Add(this.dtransTime);
            this.panelDomeLights.Controls.Add(this.label2);
            this.panelDomeLights.Controls.Add(this.dimmerValue);
            this.panelDomeLights.Controls.Add(this.colorEnter);
            this.panelDomeLights.Controls.Add(this.label1);
            this.panelDomeLights.Controls.Add(this.lblB);
            this.panelDomeLights.Controls.Add(this.lblG);
            this.panelDomeLights.Controls.Add(this.lblR);
            this.panelDomeLights.Controls.Add(this.lblManualColor);
            this.panelDomeLights.Controls.Add(this.textBoxG);
            this.panelDomeLights.Controls.Add(this.textBoxB);
            this.panelDomeLights.Controls.Add(this.textBoxR);
            this.panelDomeLights.Controls.Add(this.btnSubmitPlanet);
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
            // dtimmer_unit
            // 
            this.dtimmer_unit.AutoSize = true;
            this.dtimmer_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimmer_unit.Location = new System.Drawing.Point(379, 461);
            this.dtimmer_unit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dtimmer_unit.Name = "dtimmer_unit";
            this.dtimmer_unit.Size = new System.Drawing.Size(86, 25);
            this.dtimmer_unit.TabIndex = 60;
            this.dtimmer_unit.Text = "seconds";
            // 
            // dtransTime
            // 
            this.dtransTime.Location = new System.Drawing.Point(255, 461);
            this.dtransTime.Name = "dtransTime";
            this.dtransTime.Size = new System.Drawing.Size(91, 22);
            this.dtransTime.TabIndex = 59;
            this.dtransTime.TextChanged += new System.EventHandler(this.dtransTime_TextChanged);
            this.dtransTime.MouseHover += new System.EventHandler(this.dtransTime_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 458);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Dimmer transition time:";
            // 
            // dimmerValue
            // 
            this.dimmerValue.Location = new System.Drawing.Point(412, 400);
            this.dimmerValue.Name = "dimmerValue";
            this.dimmerValue.Size = new System.Drawing.Size(43, 22);
            this.dimmerValue.TabIndex = 57;
            // 
            // colorEnter
            // 
            this.colorEnter.Location = new System.Drawing.Point(366, 296);
            this.colorEnter.Name = "colorEnter";
            this.colorEnter.Size = new System.Drawing.Size(75, 23);
            this.colorEnter.TabIndex = 56;
            this.colorEnter.Text = "Enter";
            this.colorEnter.UseVisualStyleBackColor = true;
            this.colorEnter.Click += new System.EventHandler(this.colorEnter_Click);
            this.colorEnter.MouseHover += new System.EventHandler(this.colorEnter_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Dimmer:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(255, 292);
            this.lblB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(31, 25);
            this.lblB.TabIndex = 54;
            this.lblB.Text = "B:";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(150, 292);
            this.lblG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(33, 25);
            this.lblG.TabIndex = 53;
            this.lblG.Text = "G:";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(47, 292);
            this.lblR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(31, 25);
            this.lblR.TabIndex = 52;
            this.lblR.Text = "R:";
            // 
            // lblManualColor
            // 
            this.lblManualColor.AutoSize = true;
            this.lblManualColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualColor.Location = new System.Drawing.Point(62, 267);
            this.lblManualColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManualColor.Name = "lblManualColor";
            this.lblManualColor.Size = new System.Drawing.Size(185, 25);
            this.lblManualColor.TabIndex = 51;
            this.lblManualColor.Text = "Manual Color Entry:";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(190, 296);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(58, 22);
            this.textBoxG.TabIndex = 50;
            this.textBoxG.TextChanged += new System.EventHandler(this.textBoxG_TextChanged);
            this.textBoxG.MouseHover += new System.EventHandler(this.textBoxG_MouseHover);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(288, 295);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(58, 22);
            this.textBoxB.TabIndex = 49;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            this.textBoxB.MouseHover += new System.EventHandler(this.textBoxB_MouseHover);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(85, 295);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(58, 22);
            this.textBoxR.TabIndex = 48;
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxR_TextChanged);
            this.textBoxR.MouseHover += new System.EventHandler(this.textBoxR_MouseHover);
            // 
            // btnSubmitPlanet
            // 
            this.btnSubmitPlanet.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmitPlanet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitPlanet.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitPlanet.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnSubmitPlanet.Location = new System.Drawing.Point(140, 528);
            this.btnSubmitPlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitPlanet.Name = "btnSubmitPlanet";
            this.btnSubmitPlanet.Size = new System.Drawing.Size(165, 60);
            this.btnSubmitPlanet.TabIndex = 47;
            this.btnSubmitPlanet.Text = "Submit";
            this.btnSubmitPlanet.UseVisualStyleBackColor = false;
            this.btnSubmitPlanet.Click += new System.EventHandler(this.btnSubmitPlanet_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 31;
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(116, 115);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(160, 57);
            this.colorBtn.TabIndex = 30;
            this.colorBtn.Text = "Select a Color";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // dimmer
            // 
            this.dimmer.LargeChange = 1;
            this.dimmer.Location = new System.Drawing.Point(154, 387);
            this.dimmer.Name = "dimmer";
            this.dimmer.Size = new System.Drawing.Size(239, 56);
            this.dimmer.TabIndex = 29;
            this.dimmer.Scroll += new System.EventHandler(this.dimmer_Scroll);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
        private System.Windows.Forms.Button btnSubmitPlanet;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label lblManualColor;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button colorEnter;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.TextBox dimmerValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dtimmer_unit;
        private System.Windows.Forms.TextBox dtransTime;
        private System.Windows.Forms.ToolTip toolTip5;
    }
}
