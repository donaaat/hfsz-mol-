using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double x;
        double y;
        char operation;


        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            x = 0;
            y = 0;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button0_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.Contains("nulával nem osztunk"))
            {
                textBox1.Clear();
            }

           
            else if (!textBox1.Text.StartsWith("0") || textBox1.Text.Contains("."))
            {
                
                textBox1.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Contains("nulával nem osztunk"))
            {
                textBox1.Clear();
            }
          
            textBox1.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Contains("nulával nem osztunk"))
            {
                textBox1.Clear();
            }
            
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.Contains("nulával nem osztunk"))
            {
                textBox1.Clear();
            }
           
            textBox1.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text.Contains("nulával nem osztunk"))
            {
                textBox1.Clear();
            }
           
            textBox1.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.Contains("nulával nem osztunk"))
            {
                textBox1.Clear();
            }
         
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            if (textBox1.Text.Contains("nulával nem osztunk"))
            {
                textBox1.Clear();
            }
           
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.Contains("nulával nem osztunk"))
            {
                textBox1.Clear();
            }
          
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.Contains("nulával nem osztunk"))
            {
                textBox1.Clear();
            }
            
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text.Contains("nulával nem osztunk"))
            {
                textBox1.Clear();
            }
           
            textBox1.Text += "9";
        }


    }
}
