using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace övning_10._2
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

#pragma warning disable IDE1006 // Naming Styles
        private void button1_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            int r = int.Parse(textBox1.Text);// här hämtar den värderna från textboxen
            int h = int.Parse(textBox2.Text);
            label3.Text = VolymCylinder(r, h).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
