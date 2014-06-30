namespace TestApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.temperatureTxt = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.highsText = new System.Windows.Forms.TextBox();
            this.lowsText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(85, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Weather";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(85, 12);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(153, 20);
            this.dateTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature";
            // 
            // temperatureTxt
            // 
            this.temperatureTxt.Location = new System.Drawing.Point(85, 38);
            this.temperatureTxt.Name = "temperatureTxt";
            this.temperatureTxt.Size = new System.Drawing.Size(153, 20);
            this.temperatureTxt.TabIndex = 4;
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Interval = 10;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "City";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(85, 64);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(153, 20);
            this.cityText.TabIndex = 6;
            // 
            // highsText
            // 
            this.highsText.Location = new System.Drawing.Point(85, 91);
            this.highsText.Name = "highsText";
            this.highsText.Size = new System.Drawing.Size(153, 20);
            this.highsText.TabIndex = 7;
            // 
            // lowsText
            // 
            this.lowsText.Location = new System.Drawing.Point(85, 118);
            this.lowsText.Name = "lowsText";
            this.lowsText.Size = new System.Drawing.Size(153, 20);
            this.lowsText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Highs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lows";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 194);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lowsText);
            this.Controls.Add(this.highsText);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.temperatureTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Jon Lee\'s Weather App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox temperatureTxt;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox highsText;
        private System.Windows.Forms.TextBox lowsText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

