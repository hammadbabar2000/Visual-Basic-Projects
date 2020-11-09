using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_System_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            double n1;
            double n2;
            double n3;
            double n4;
            double n5;
            double a;
            string c;
            string r;
            
            //////////////////////////////////////////////////////////////////////////////////////////////////
            n1 = double.Parse(TextBox1.Text); //Text box for english (Textbox1)
            n2 = double.Parse(TextBox2.Text); //Text box for math (Textbox2)
            n3 = double.Parse(TextBox3.Text); //Text box for sience (Textbox3)
            n4 = double.Parse(TextBox4.Text); //Text box for gym (Textbox4)
            n5 = double.Parse(TextBox5.Text); //Text box for computer (Textbox5)
            c = TextBox7.Text; //Text box for comment (Textbox7)
            a = (n1 + n2 + n3 + n4 + n5) / 5;
            r = System.Convert.ToString(a);
            r = TextBox6.Text;
            

            //////////////////////////////////////////////////////////////////////////////////////////////////
            
            {
                
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}