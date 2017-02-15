using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double Összeadás(double x, double y)
        {

            return x + y;
        }

        public double Kivonás(double x, double y)
        {

            return x - y;
        }

        public double Szorzás(double x, double y)
        {

            return x * y;
        }

        public double Osztás(double x, double y)
        {

            return x / y;
        }
    }
}