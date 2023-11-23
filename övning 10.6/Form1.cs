using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_10._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double VolymCylinder(double radie, double höjd)   // en metod jag gjort för att den ska kunna ta radien och höjden och sen multiplicera dem längre ner.
        {


            double V = Math.PI * radie * radie * höjd;// här är koden som multiplicerar 


            return V;
        }

         void indata(out double radie, out double höjd)
        {
            radie = double.Parse(textBox1.Text);
            höjd = double.Parse(textBox2.Text);
        }


        public void button1_Click_1(object sender, EventArgs e)
        {
            double radie;
            double höjd;
            indata(out radie, out höjd);
            label3.Text = VolymCylinder(radie,höjd).ToString();

        }
    }
}
