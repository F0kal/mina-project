using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            double t1 = double.Parse(textBox1.Text);
            double t2 = double.Parse(textBox3.Text);
            char tecken = char.Parse(textBox2.Text);

            if (tecken == '*')
            {
                double gånger = t1 * t2;
                lblSvar.Text = gånger.ToString();
            }

            else if (tecken == '/')
            {
                double division = t1 / t2;
                lblSvar.Text = division.ToString();
            }

            else if (tecken == '+')
            {
                double plus = t1 + t2;
                lblSvar.Text = plus.ToString();
            }

            else if (tecken == '-')
            {
                double minus = t1 - t2;
                lblSvar.Text = minus.ToString();
            }

            else lblSvar.Text = "ogiltigt räknesätt snälla använd *, /, +, - ";
       
            
            
            
            
            
            
            
            /*  switch (tecken)
            {
                case '*':
                double gånger = t1 * t2;
                lblSvar.Text = gånger.ToString();
                break;

                case '/':
                double division = t1 / t2;
                lblSvar.Text = division.ToString();
                break;

                case '+':
                double plus = t1 + t2;
                lblSvar.Text = plus.ToString();
                break;

                case '-':
                double minus = t1 - t2;
                lblSvar.Text = minus.ToString();
                break;
          */

            }


        }
    }

