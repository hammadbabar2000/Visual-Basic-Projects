using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_C_Sharp
{
    public partial class Form1 : Form
    {    

        public Form1()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise; 
        }
        
        //The Add button
        private void button1_Click(object sender, EventArgs e)
        {
            long  n1;
            long n2;
            long answer;
            n1 = long.Parse(textBox1.Text);
            n2 = long.Parse(textBox2.Text);
            answer = n1 + n2;
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));
        }
        
        //The Subtract button
        private void button2_Click(object sender, EventArgs e)
        {
            long n1;
            long n2;
            long answer;
            n1 = long.Parse(textBox1.Text);
            n2 = long.Parse(textBox2.Text);
            answer = n1 - n2;
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));
        }
        
        //The Multiplcation button
        private void button3_Click(object sender, EventArgs e)
        {
            long n1;
            long  n2;
            long answer;
            n1 = long.Parse(textBox1.Text);
            n2 = long.Parse(textBox2.Text);
            answer = n1 * n2;
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));

        }
        
        //The Divide button
        private void button4_Click(object sender, EventArgs e)
        {
            long n1;
            long n2;
            long answer;
            n1 = long.Parse(textBox1.Text);
            n2 = long.Parse(textBox2.Text);
            answer = n1 / n2;
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));
        }
        
        //The Clear Button
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");
            textBox1.Focus(); 
        }
        
        //The ^2 Button
        private void button6_Click(object sender, EventArgs e)
        {
            double  n1;
            double  answer;
            n1 = double .Parse(textBox1.Text);
            answer = n1 * n1;
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));
        }
        
        //The power button
        private void button7_Click(object sender, EventArgs e)
        {
            double  n1;
            double  n2;
            double  answer;
            n1 = double .Parse(textBox1.Text);
            n2 = double .Parse(textBox2.Text);
            answer = Math.Pow(n1,n2); 
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));
        }
        
        //The Sin Button
        private void button8_Click(object sender, EventArgs e)
        {
            double n1;
            double answer;
            n1 = double.Parse(textBox1.Text);
            answer = Math.Sin(n1 * Math.PI/180);
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));
        }
        
        //The Cos Button
        private void button9_Click(object sender, EventArgs e)
        {
            double n1;
            double answer;
            n1 = double.Parse(textBox1.Text);
            answer = Math.Cos (n1 * Math.PI / 180);
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));
        }
        
        //The Tan Button
        private void button10_Click(object sender, EventArgs e)
        {
            double n1;
            double answer;
            n1 = double.Parse(textBox1.Text);
            answer = Math.Tan (n1 * Math.PI / 180);
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));
        }
        
        //The Squair Root Button
        private void button11_Click(object sender, EventArgs e)
        {  
            double n1;
            double answer;
            n1 = double.Parse(textBox1.Text);
            answer = Math.Sqrt (n1);
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));
        }
        //Degeries to Radias
        private void button12_Click(object sender, EventArgs e)
        {
            double n1;
            double answer;
            n1 = double.Parse(textBox1.Text);
            answer = n1 * Math.PI / 180;
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(), ("ANSWER"));
        }
        //Radias to Degeries
        private void button13_Click(object sender, EventArgs e)
        {
            double n1;
            double answer;
            n1 = double.Parse(textBox1.Text);
            answer = n1 / Math.PI * 180;
            textBox3.Text = answer.ToString();
            MessageBox.Show(answer.ToString(),("ANSWER"));
        }
    }
}
