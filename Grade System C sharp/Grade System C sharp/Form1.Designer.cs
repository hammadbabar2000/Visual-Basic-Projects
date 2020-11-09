using System;

namespace Grade_System_C_sharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private EventHandler Form1_Load;

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
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mark 11";
            // 
            // TextBox9
            // 
            this.TextBox9.Location = new System.Drawing.Point(457, 75);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(100, 20);
            this.TextBox9.TabIndex = 31;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(330, 75);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(94, 26);
            this.Label10.TabIndex = 44;
            this.Label10.Text = "Teacher";
            // 
            // TextBox8
            // 
            this.TextBox8.Location = new System.Drawing.Point(162, 81);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(100, 20);
            this.TextBox8.TabIndex = 28;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(12, 75);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(91, 26);
            this.Label9.TabIndex = 43;
            this.Label9.Text = "Student";
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(311, 342);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(110, 37);
            this.Button3.TabIndex = 37;
            this.Button3.Text = "Clear";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // TextBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(461, 322);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(106, 20);
            this.TextBox7.TabIndex = 42;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(467, 194);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(100, 20);
            this.TextBox6.TabIndex = 41;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(456, 259);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(111, 26);
            this.Label8.TabIndex = 40;
            this.Label8.Text = "Comment";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(462, 141);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(95, 26);
            this.Label7.TabIndex = 38;
            this.Label7.Text = "Average";
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(311, 385);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(110, 37);
            this.Button2.TabIndex = 39;
            this.Button2.Text = "E&xit";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(311, 299);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(110, 37);
            this.Button1.TabIndex = 36;
            this.Button1.Text = "Calulate";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(163, 395);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(100, 20);
            this.TextBox5.TabIndex = 35;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(163, 327);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(100, 20);
            this.TextBox4.TabIndex = 34;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(163, 266);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(100, 20);
            this.TextBox3.TabIndex = 33;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(163, 200);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 32;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(163, 141);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 30;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(12, 388);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(125, 26);
            this.Label5.TabIndex = 29;
            this.Label5.Text = "Computers";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(12, 322);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(61, 26);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Gym";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 260);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 26);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Science";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 194);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 26);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Math";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "English";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 428);
            this.Controls.Add(this.TextBox9);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.TextBox8);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.TextBox7);
            this.Controls.Add(this.TextBox6);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mark 11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox TextBox9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TextBox8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.TextBox TextBox7;
        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label6;
    }
}

