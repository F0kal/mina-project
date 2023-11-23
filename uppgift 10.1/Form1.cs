using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uppgift_10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            double Omkrets (double radi )
        {
           
            double  Omkrets = radi * 2 * Math.PI;

            return Omkrets;
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            

            double radie = double.Parse(textBox1.Text);
            double omkrets = Omkrets(radie);
            textBox2.Text = omkrets.ToString();
        }
    }
}
