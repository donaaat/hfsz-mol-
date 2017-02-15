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

        private void Form1_Load(object sender, EventArgs e)
        {
            private void btnEquals_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "&quot
            {

                Calculator myCalculator = new Calculator();

                if (double.TryParse(txtDisplay.Text, out y))

                    switch (operation)
                    {
                        case '+':
                           
                            textBox1.Text = (myCalculator.Add(x, y)).ToString();
                            break;

                        case '-':
                            textBox1.Text = (myCalculator.Subtract(x, y)).ToString();
                            break;
                    }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out x))
            {
                operation = '+';
                textBox1.Clear();
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out x))
            {
                operation = '-';
                textBox1.Clear();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out x))
            {
                operation = '*';
            }

        }
    }
}