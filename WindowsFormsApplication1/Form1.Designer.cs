namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TitleBox1 = new System.Windows.Forms.TextBox();
            this.GenreBox2 = new System.Windows.Forms.TextBox();
            this.DirectorBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeBox4 = new System.Windows.Forms.TextBox();
            this.RateBox5 = new System.Windows.Forms.TextBox();
            this.RevenueBox6 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rate";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TitleBox1
            // 
            this.TitleBox1.Location = new System.Drawing.Point(115, 64);
            this.TitleBox1.Name = "TitleBox1";
            this.TitleBox1.Size = new System.Drawing.Size(100, 20);
            this.TitleBox1.TabIndex = 6;
            this.TitleBox1.TextChanged += new System.EventHandler(this.TitleBox1_TextChanged);
            // 
            // GenreBox2
            // 
            this.GenreBox2.Location = new System.Drawing.Point(115, 105);
            this.GenreBox2.Name = "GenreBox2";
            this.GenreBox2.Size = new System.Drawing.Size(100, 20);
            this.GenreBox2.TabIndex = 7;
            this.GenreBox2.TextChanged += new System.EventHandler(this.GenreBox2_TextChanged);
            // 
            // DirectorBox3
            // 
            this.DirectorBox3.Location = new System.Drawing.Point(115, 145);
            this.DirectorBox3.Name = "DirectorBox3";
            this.DirectorBox3.Size = new System.Drawing.Size(100, 20);
            this.DirectorBox3.TabIndex = 8;
            this.DirectorBox3.TextChanged += new System.EventHandler(this.DirectorBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Revenue";
            // 
            // TimeBox4
            // 
            this.TimeBox4.Location = new System.Drawing.Point(115, 179);
            this.TimeBox4.Name = "TimeBox4";
            this.TimeBox4.Size = new System.Drawing.Size(100, 20);
            this.TimeBox4.TabIndex = 10;
            this.TimeBox4.TextChanged += new System.EventHandler(this.TimeBox4_TextChanged);
            // 
            // RateBox5
            // 
            this.RateBox5.Location = new System.Drawing.Point(115, 218);
            this.RateBox5.Name = "RateBox5";
            this.RateBox5.Size = new System.Drawing.Size(100, 20);
            this.RateBox5.TabIndex = 11;
            this.RateBox5.TextChanged += new System.EventHandler(this.RateBox5_TextChanged);
            // 
            // RevenueBox6
            // 
            this.RevenueBox6.Location = new System.Drawing.Point(115, 256);
            this.RevenueBox6.Name = "RevenueBox6";
            this.RevenueBox6.Size = new System.Drawing.Size(100, 20);
            this.RevenueBox6.TabIndex = 12;
            this.RevenueBox6.TextChanged += new System.EventHandler(this.RevenueBox6_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(129, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "RandRev";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 485);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RevenueBox6);
            this.Controls.Add(this.RateBox5);
            this.Controls.Add(this.TimeBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DirectorBox3);
            this.Controls.Add(this.GenreBox2);
            this.Controls.Add(this.TitleBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TitleBox1;
        private System.Windows.Forms.TextBox GenreBox2;
        private System.Windows.Forms.TextBox DirectorBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TimeBox4;
        private System.Windows.Forms.TextBox RateBox5;
        private System.Windows.Forms.TextBox RevenueBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

