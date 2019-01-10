namespace WindowsFormsApp1
{
    partial class PsuDropCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMesetaRate = new System.Windows.Forms.TextBox();
            this.txtAreaRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpecialRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.txtDNR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meseta Rate";
            // 
            // txtMesetaRate
            // 
            this.txtMesetaRate.Location = new System.Drawing.Point(90, 45);
            this.txtMesetaRate.Name = "txtMesetaRate";
            this.txtMesetaRate.Size = new System.Drawing.Size(100, 20);
            this.txtMesetaRate.TabIndex = 1;
            // 
            // txtAreaRate
            // 
            this.txtAreaRate.Location = new System.Drawing.Point(90, 75);
            this.txtAreaRate.Name = "txtAreaRate";
            this.txtAreaRate.Size = new System.Drawing.Size(100, 20);
            this.txtAreaRate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area Rate";
            // 
            // txtItemRate
            // 
            this.txtItemRate.Location = new System.Drawing.Point(90, 108);
            this.txtItemRate.Name = "txtItemRate";
            this.txtItemRate.Size = new System.Drawing.Size(100, 20);
            this.txtItemRate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Rate";
            // 
            // txtSpecialRate
            // 
            this.txtSpecialRate.Location = new System.Drawing.Point(90, 136);
            this.txtSpecialRate.Name = "txtSpecialRate";
            this.txtSpecialRate.Size = new System.Drawing.Size(100, 20);
            this.txtSpecialRate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(3, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Special Rate";
            // 
            // txtResult1
            // 
            this.txtResult1.Location = new System.Drawing.Point(90, 176);
            this.txtResult1.Multiline = true;
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.ReadOnly = true;
            this.txtResult1.Size = new System.Drawing.Size(186, 18);
            this.txtResult1.TabIndex = 9;
            // 
            // txtDNR
            // 
            this.txtDNR.Location = new System.Drawing.Point(90, 16);
            this.txtDNR.Name = "txtDNR";
            this.txtDNR.ReadOnly = true;
            this.txtDNR.Size = new System.Drawing.Size(100, 20);
            this.txtDNR.TabIndex = 11;
            this.txtDNR.Text = "50000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(35, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DNR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(29, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Result";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DeepPink;
            this.button1.Location = new System.Drawing.Point(90, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PsuDropCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDNR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResult1);
            this.Controls.Add(this.txtSpecialRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtItemRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAreaRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMesetaRate);
            this.Controls.Add(this.label1);
            this.Name = "PsuDropCalculator";
            this.Text = "Psu Drop Rate Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMesetaRate;
        private System.Windows.Forms.TextBox txtAreaRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpecialRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.TextBox txtDNR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

